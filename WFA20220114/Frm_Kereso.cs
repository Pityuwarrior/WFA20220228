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
    public partial class Frm_Kereso : Form
    {
        public string ConnectString { private get; set; }
        public Frm_Kereso()
        {
            ConnectString =
                "Server = (localdb)\\MSSQLLocalDB; " +
                "Database = nelyviskola; ";
            InitializeComponent();
        }

        private void Frm_Kereso_Load(object sender, EventArgs e)
        {
            CB();
            FILLDGV_KERES();
        }
        private void CB()
        {
            using (var c = new SqlConnection(ConnectString))
            {
                c.Open();
                var r = new SqlCommand(
                     "SELECT nyelvek.nyelv " +
                     "FROM nyelvek; ", c).ExecuteReader();
                while (r.Read())
                {
                    cb_keres.Items.Add(r[0]);
                }
                r.Close();
            }
        }
        private void FILLDGV_KERES() 
        {
            dgv_keres.Rows.Clear();

            using (var c = new SqlConnection(ConnectString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT vizsgak.idopont, nyelvek.nyelv, vizsgak.szint " +
                    "FROM nyelvek, vizsgak " +
                    "WHERE nyelvek.id = vizsgak.nyelvid " +
                    $"AND nyelvek.nyelv LIKE '%{cb_keres.Text}%'; ", c).ExecuteReader();

                while (r.Read())
                {
                    dgv_keres.Rows.Add(r[0], r[1], r[2]);
                }
                r.Close();
            }
        }

        private void cb_keres_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILLDGV_KERES();
        }


    }
}
