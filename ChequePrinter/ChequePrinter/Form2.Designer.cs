namespace ChequePrinter
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.browseletterheadbtn = new System.Windows.Forms.Button();
            this.letterheadpic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.letterheadlab = new System.Windows.Forms.Label();
            this.letterheadnextbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.letterheadpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select a Letter head for the cheque\r\nPlease Select a jpg or png format for" +
                " the leatter head\r\n";
            // 
            // browseletterheadbtn
            // 
            this.browseletterheadbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseletterheadbtn.Location = new System.Drawing.Point(102, 58);
            this.browseletterheadbtn.Name = "browseletterheadbtn";
            this.browseletterheadbtn.Size = new System.Drawing.Size(146, 33);
            this.browseletterheadbtn.TabIndex = 1;
            this.browseletterheadbtn.Text = "Browse Letter head";
            this.browseletterheadbtn.UseVisualStyleBackColor = true;
            this.browseletterheadbtn.Click += new System.EventHandler(this.browseletterheadbtn_Click);
            // 
            // letterheadpic
            // 
            this.letterheadpic.Location = new System.Drawing.Point(12, 134);
            this.letterheadpic.Name = "letterheadpic";
            this.letterheadpic.Size = new System.Drawing.Size(565, 374);
            this.letterheadpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.letterheadpic.TabIndex = 2;
            this.letterheadpic.TabStop = false;
            this.letterheadpic.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // letterheadlab
            // 
            this.letterheadlab.AutoSize = true;
            this.letterheadlab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterheadlab.Location = new System.Drawing.Point(27, 97);
            this.letterheadlab.Name = "letterheadlab";
            this.letterheadlab.Size = new System.Drawing.Size(0, 19);
            this.letterheadlab.TabIndex = 3;
            // 
            // letterheadnextbtn
            // 
            this.letterheadnextbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterheadnextbtn.Location = new System.Drawing.Point(265, 58);
            this.letterheadnextbtn.Name = "letterheadnextbtn";
            this.letterheadnextbtn.Size = new System.Drawing.Size(99, 33);
            this.letterheadnextbtn.TabIndex = 4;
            this.letterheadnextbtn.Text = "Next";
            this.letterheadnextbtn.UseVisualStyleBackColor = true;
            this.letterheadnextbtn.Visible = false;
            this.letterheadnextbtn.Click += new System.EventHandler(this.letterheadnextbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 520);
            this.Controls.Add(this.letterheadnextbtn);
            this.Controls.Add(this.letterheadlab);
            this.Controls.Add(this.letterheadpic);
            this.Controls.Add(this.browseletterheadbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Browse Letter head";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.letterheadpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseletterheadbtn;
        private System.Windows.Forms.PictureBox letterheadpic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label letterheadlab;
        private System.Windows.Forms.Button letterheadnextbtn;
    }
}