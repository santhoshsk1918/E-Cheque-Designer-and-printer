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
    public partial class Form4 : Form
    {
        Image letterheadimg;

        private MySqlConnection connect;
        private string server;

        private string uid;
        private string password;
        public Form4(Image recive)
        {
            InitializeComponent();
            letterheadimg = recive;
            letterheadpic.Image = letterheadimg;
            currencylab.Text = "Indian_Rupee";

            ChequePrinter.ControlMover.Init(this.payeeinwordsgb);
            ChequePrinter.ControlMover.Init(this.Payeeindiggb);
            ChequePrinter.ControlMover.Init(this.authorisedsigngb);
            ChequePrinter.ControlMover.Init(this.dateTimePicker1);
            ChequePrinter.ControlMover.Init(this.personpay);

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color colba = colorDialog1.Color;
            chequedesignpan.BackColor = colba;
            string col = colba.ToArgb().ToString("X8").Substring(2, 6);
            colorsavtxt.Text = col;
            //Color color = System.Drawing.ColorTranslator.FromHtml("#"+col);
            //chequedesignpan.BackColor = color;
            //MessageBox.Show(string.Format("{0}",col));
            
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

        private void payeetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //empty
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

            
            payeetxt.Text = String.Format("{0}",retu);
            double val = Math.Round(retu, MidpointRounding.AwayFromZero);
            
            int value = Convert.ToInt32(val);
            
            string inwords = numbertoword.NumberToWords(value);
            inwords = inwords + " Only";
            int count = 0;
                foreach(char c in inwords) {
                  if(char.IsLetter(c)) {
                    count++;
                  }
                }
                curlab.Text = selstr + " in Digits";
                curdiglab.Text = "(" +selstr+" in words)";
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

        private void payeetxt_KeyPress_1(object sender, KeyPressEventArgs e)
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
        

        private void button3_Click(object sender, EventArgs e)
        {
            int xperpay = personpay.Location.X;
            int yperpay = personpay.Location.Y;
            int xdate = dateTimePicker1.Location.X;
            int ydate = dateTimePicker1.Location.Y;
            int xpayeeinwords = payeeinwordsgb.Location.X;
            int ypayeeinwords = payeeinwordsgb.Location.Y;
            int xpayeeindig = Payeeindiggb.Location.X;
            int ypayeeindig = Payeeindiggb.Location.Y;
            int xauth = authorisedsigngb.Location.X;
            int yauth = authorisedsigngb.Location.Y;
            string colors = colorsavtxt.Text;

            xperpay = Convert.ToInt32(xperpay);
            yperpay = Convert.ToInt32(yperpay);
            xdate = Convert.ToInt32(xdate);
            ydate = Convert.ToInt32(ydate);
            xpayeeinwords = Convert.ToInt32(xpayeeinwords);
            ypayeeinwords = Convert.ToInt32(ypayeeinwords);
            xpayeeindig = Convert.ToInt32(xpayeeindig);
            ypayeeindig = Convert.ToInt32(ypayeeindig);
            xauth = Convert.ToInt32(xauth);
            yauth = Convert.ToInt32(yauth);



            
            bool cross = crossinchk.Checked;
            string templatename = templatenametxt.Text;
           



            if (templatename == "")
            {

                errortemplatelab.Text = "Please give a template name";
                errortemplatelab.Visible = true;
            }
            else {
                server = "localhost";

                uid = "root";
                password = "";
                string connectionString;
                connectionString = "datasource=" + server + ";" + "port=" +
                "3306" + ";" + "username=" + uid + ";" + "password=" + password + ";";

                connect = new MySqlConnection(connectionString);
                MySqlDataAdapter myDataAdaptor = new MySqlDataAdapter();
                string query = "INSERT INTO `chequeprinter`.`points`(`templatename`,`xauth`,`xperpay`,`yperpay`,`xdate`,`ydate`,`xpayword`,`ypayword`,`xpaydig`,`ypaydig`,`yauth`,`col`,`chec`)VALUES ('"+templatename+"','"+xauth+"','"+xperpay+"','"+yperpay+"','"+xdate+"','"+ydate+"','"+xpayeeinwords+"','"+ypayeeinwords+"','"+xpayeeindig+"','"+ypayeeindig+"','"+yauth+"','"+colors+"','"+cross+"') ;" ;

                MySqlCommand Commd = new MySqlCommand(query, connect);
                MySqlDataReader myreader;
                try
                {
                    connect.Open();
                    myreader = Commd.ExecuteReader();
                    while(myreader.Read()){
                    
                    }
                    errortemplatelab.Text = "template Saved";
                    errortemplatelab.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
            
            }
        }




    }
}

