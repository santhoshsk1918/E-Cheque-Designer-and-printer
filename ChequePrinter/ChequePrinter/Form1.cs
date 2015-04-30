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
    public partial class Login_form : Form
    {
        private MySqlConnection connect;
        private string server;
        
        private string uid;
        private string password;
       
        public Login_form()
        {
            InitializeComponent();
        }

         private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                server = "localhost";
                
                uid = "root";
                password = "";
                string connectionString;
                connectionString = "datasource=" + server + ";" + "port=" +
                "3306" + ";" + "username=" + uid + ";" + "password=" + password + ";";

                connect = new MySqlConnection(connectionString);
                MySqlDataAdapter myDataAdaptor = new MySqlDataAdapter();
                MySqlCommand Commd = new MySqlCommand("Select * from chequeprinter.users where username='" + this.usernametxt.Text + "'and password='" + this.Passwordpwd.Text + "';", connect);

                MySqlDataReader myreader;
                connect.Open();

                myreader = Commd.ExecuteReader();

                int count = 0;

                while (myreader.Read()) {
                    count++;
                }

                if (count == 1)
                {
                    Form2 scnd = new Form2();
                    scnd.Show();
                    this.Hide();
                }
                else {
                    errorlab.Text = "Incorrect Username or Password";
                }
                
                connect.Close();

                  
            }
            catch (Exception ex) {
                errorlab.Text = "Could not connect to Database";
                MessageBox.Show(ex.Message);
               
            }

        }

         private void Login_form_FormClosed(object sender, FormClosedEventArgs e)
         {
             Application.Exit();
         }

       
           
        
    }
}
