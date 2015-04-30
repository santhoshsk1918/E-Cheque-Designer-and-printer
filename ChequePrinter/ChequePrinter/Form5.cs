using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChequePrinter
{
    public partial class Form5 : Form
    {
        Image letterheadimg;

        private MySqlConnection connect;
        private string server;

        private string uid;
        private string password;

        public Form5(Image recive)
        {
            InitializeComponent();
            letterheadimg = recive;
            FillCombo();
        }
        void FillCombo() {
            server = "localhost";

            uid = "root";
            password = "";
            string connectionString;
            connectionString = "datasource=" + server + ";" + "port=" +
            "3306" + ";" + "username=" + uid + ";" + "password=" + password + ";";

            connect = new MySqlConnection(connectionString);
            MySqlDataAdapter myDataAdaptor = new MySqlDataAdapter();
            string query = "Select * from chequeprinter.points";

            MySqlCommand Commd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;
            try
            {
                connect.Open();
                myreader = Commd.ExecuteReader();
                while (myreader.Read())
                {
                    string sName = myreader.GetString("templatename");
                    templatecombo.Items.Add(sName);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("hi");
                MessageBox.Show(ex.Message);
            }
        
        }
        
        

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string valu = combotxt.Text;
            Form6 frm = new Form6(letterheadimg, valu);
            frm.Show();
            this.Hide();

        }

        private void templatecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            combotxt.Text = templatecombo.Text;
        }
    }
}
