using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace ChequePrinter
{
    public partial class Form6 : Form
    {
        Image letterheadimg;

        private MySqlConnection connect;
        private string server;
        private string temname;
        private string uid;
        private string password;
        public Form6(Image revive, string name)
        {
            InitializeComponent();
            
            letterheadimg = revive;
            temname = name;
            namess.Text = temname;
            letterheadpic.Image = letterheadimg;
            currencylab.Text = "Indian_Rupee";
            setlocs();
        }

        void setlocs() {

            
            server = "localhost";

            uid = "root";
            password = "";
            string connectionString;
            connectionString = "datasource=" + server + ";" + "port=" +
            "3306" + ";" + "username=" + uid + ";" + "password=" + password + ";";

            connect = new MySqlConnection(connectionString);
            MySqlDataAdapter myDataAdaptor = new MySqlDataAdapter();
            string tempn = namess.Text;
            string query = "Select * from chequeprinter.points where `templatename` ='" + tempn + "';";

            MySqlCommand Commd = new MySqlCommand(query, connect);
            MySqlDataReader myreader;
            try
            {
                
                int xauth;
                int yauth;
                int xperpay;
                int yperpay;
                int xpayword;
                int ypayword;
                int xpaydig;
                int ypaydig;
                int xdate;
                int ydate;
                string col;
                bool chec;
                connect.Open();
                myreader = Commd.ExecuteReader();
                
                while (myreader.Read())
                {
                    MessageBox.Show("hi");
                    xauth = myreader.GetInt32("xauth");
                    yauth = myreader.GetInt32("yauth");
                    xperpay = myreader.GetInt32("xperpay");
                    yperpay = myreader.GetInt32("yperpay");
                    xpayword = myreader.GetInt32("xpayword");
                    ypayword = myreader.GetInt32("ypayword");
                    xpaydig = myreader.GetInt32("xpaydig");
                    ypaydig = myreader.GetInt32("ypaydig");
                    xdate = myreader.GetInt32("xdate");
                    ydate = myreader.GetInt32("ydate");
                    col = myreader.GetString("col");
                    chec = myreader.GetBoolean("chec");

                    personpay.Location = new Point(xperpay, yperpay);
                    dateTimePicker1.Location = new Point(xdate, ydate);
                    payeeinwordsgb.Location = new Point(xpayword, ypayword);
                    Payeeindiggb.Location = new Point(xpaydig, ypaydig);
                    authorisedsigngb.Location = new Point(xauth, yauth);

                    if (chec == false)
                    {
                        crossingpic.Visible = false;
                        crossinchk.Checked = false;
                    }
                    else {
                        crossingpic.Visible = true;
                        crossinchk.Checked = true;

                    }

                    Color color = System.Drawing.ColorTranslator.FromHtml("#"+col);
                    chequedesignpan.BackColor = color;


                }


                

           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }


        private void crossinchk_CheckedChanged(object sender, EventArgs e)
        {
            bool ischecked = crossinchk.Checked;

            if (ischecked)
            {
                crossingpic.Visible = true;
            }
            else
            {
                crossingpic.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string p = openFileDialog1.SafeFileName;
                string ext = Path.GetExtension(p);

                ext = ext.ToLower();

                if (ext == ".png" || ext == ".jpeg" || ext == ".jpg")
                {

                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.Image = image;
                }
                else
                {
                    siglab.Text = "Please Select an image";
                    siglab.Visible = true;
                }
            }
        }

        private void Currencychangingcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Currencychangingcmb.SelectedIndex;
            this.Text = Currencychangingcmb.Items[selected].ToString();
            string selstr = this.Text;
            string present = currencylab.Text;
            double mon = Convert.ToDouble(payeetxt.Text);
            currency_convert con = new currency_convert();
            double retu = con.convertr(present, selstr, mon);


            payeetxt.Text = String.Format("{0}", retu);
            double val = Math.Round(retu, MidpointRounding.AwayFromZero);

            int value = Convert.ToInt32(val);

            string inwords = numbertoword.NumberToWords(value);
            inwords = inwords + " Only";
            int count = 0;
            foreach (char c in inwords)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            curlab.Text = selstr + " in Digits";
            curdiglab.Text = "(" + selstr + " in words)";
            if (count <= 100)
            {

                amtwordsone.Text = inwords;
            }
            else
            {
                string fir = inwords.Substring(0, 100);
                string sec = inwords.Substring(101, 150);
                amtwordsone.Text = fir;
                amtwordssec.Text = sec;

            }

            currencylab.Text = selstr;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }

        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.Container.Width, this.Container.Height);
            this.Container.DrawToBitmap(bmp, new Rectangle(0, 0, this.Container.Width, this.Container.Height));
            e.Graphics.DrawImage((Image)bmp, 5, y);
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void payeetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

       
    }
}
