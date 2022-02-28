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
    public partial class Frm_Vizsgazo : Form
    {
        public string ConnectString { private get; set; }
        public Frm_Vizsgazo()
        {
            ConnectString =
                "Server = (localdb)\\MSSQLLocalDB; " +
                "Database = nelyviskola; ";
            InitializeComponent();
        }

        private void bt_uj_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectString))
            {
                    int szul = Convert.ToInt32(tb_szuli.Text);
                    if (tb_nev.Text != "" && tb_tel.Text.Length == 7 && szul < 2022)
                    {
                        c.Open();
                        var insert = new SqlCommand(
                            "INSERT INTO jelentkezesek (sorsz, nev, mobil, szulev) VALUES" +
                            $"('{tb_id.Text}','{tb_nev.Text}','{tb_szuli.Text}','{tb_tel.Text}')", c).ExecuteReader();
                        MessageBox.Show("Új jelentkező sikeresen hozáadva!");
                    }
                    else
                    {
                        MessageBox.Show("Hibásan megadott adat!");
                    }
                
            }
        }
    }
}
