using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA20220114
{
    public partial class FrmMain : Form
    {
        public string SelectedId = "-1";
        public string ConnectString { private get; set; }
        public FrmMain()
        {
            ConnectString =
               "Server = (localdb)\\MSSQLLocalDB; " +
               "Database = nelyviskola; ";
            //Véletlen elírtam az db nevét.
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Dgv_load();
        }

        private void Dgv_load() 
        {
            dgv.Rows.Clear();

            using (var c = new SqlConnection(ConnectString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT nyelvek.id, jelentkezesek.nev, nyelvek.nyelv, vizsgak.szint " +
                    "FROM nyelvek, vizsgak, jelentkezesek " +
                    "WHERE nyelvek.id = vizsgak.nyelvid " +
                    "AND vizsgak.sorsz = jelentkezesek.vizsga", c).ExecuteReader();

                while (r.Read()) 
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
            }
        }

        private void újVizsgázóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Vizsgazo v = new Frm_Vizsgazo();
            v.Show();
        }

        private void vizsgákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Kereso k = new Frm_Kereso();
            k.Show();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedId = dgv[0, e.RowIndex].Value.ToString();
            Frm_Vizsgazo v = new Frm_Vizsgazo();
            v.Show();
            
        }
    }
}
