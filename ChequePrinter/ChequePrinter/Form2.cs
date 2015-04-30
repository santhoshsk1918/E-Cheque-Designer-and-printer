using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChequePrinter
{
       
    public partial class Form2 : Form
    {
        string pathname = "";
        public Image send;


        public Form2()
        {
            InitializeComponent();
        }

        private void browseletterheadbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string p = openFileDialog1.SafeFileName;
                letterheadlab.Text = p;
                string ext = Path.GetExtension(p);
                
                ext =  ext.ToLower();

                if (ext == ".png" || ext == ".jpeg" || ext == ".jpg")
                {
                    
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    send = Image.FromFile(openFileDialog1.FileName);
                    Form3 f3 = new Form3(send);
                    letterheadpic.Image = image;
                    letterheadpic.Visible = true;
                    letterheadnextbtn.Visible = true;
                    pathname = openFileDialog1.FileName;
                }
                else {
                    letterheadlab.Text = "Please Select a file with png or jpeg or jpg extention";
                }


            }
        }

        private void letterheadnextbtn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(send);
            f3.Show();
            this.Hide();


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
