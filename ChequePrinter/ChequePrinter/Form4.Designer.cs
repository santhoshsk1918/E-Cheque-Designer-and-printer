namespace ChequePrinter
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.crossinchk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currencylab = new System.Windows.Forms.Label();
            this.Currencychangingcmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.siglab = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.color = new System.Windows.Forms.Label();
            this.colorset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errortemplatelab = new System.Windows.Forms.Label();
            this.templatenametxt = new System.Windows.Forms.TextBox();
            this.colorsavtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.GroupBox();
            this.chequedesignpan = new System.Windows.Forms.Panel();
            this.personpay = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.authorisedsigngb = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Payeeindiggb = new System.Windows.Forms.GroupBox();
            this.curlab = new System.Windows.Forms.Label();
            this.payeetxt = new System.Windows.Forms.TextBox();
            this.payeeinwordsgb = new System.Windows.Forms.GroupBox();
            this.curdiglab = new System.Windows.Forms.Label();
            this.currencywords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amtwordssec = new System.Windows.Forms.TextBox();
            this.amtwordsone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.crossingpic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.letterheadpic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.Container.SuspendLayout();
            this.chequedesignpan.SuspendLayout();
            this.personpay.SuspendLayout();
            this.authorisedsigngb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Payeeindiggb.SuspendLayout();
            this.payeeinwordsgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crossingpic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterheadpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select color for \r\nCheque Background\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(794, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crossinchk
            // 
            this.crossinchk.AutoSize = true;
            this.crossinchk.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossinchk.Location = new System.Drawing.Point(794, 216);
            this.crossinchk.Name = "crossinchk";
            this.crossinchk.Size = new System.Drawing.Size(162, 27);
            this.crossinchk.TabIndex = 6;
            this.crossinchk.Text = "Cross the Cheque";
            this.crossinchk.UseVisualStyleBackColor = true;
            this.crossinchk.CheckedChanged += new System.EventHandler(this.crossinchk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(794, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Change the Currency \r\nof the cheque";
            // 
            // currencylab
            // 
            this.currencylab.AutoSize = true;
            this.currencylab.Location = new System.Drawing.Point(791, 255);
            this.currencylab.Name = "currencylab";
            this.currencylab.Size = new System.Drawing.Size(0, 13);
            this.currencylab.TabIndex = 9;
            this.currencylab.Visible = false;
            // 
            // Currencychangingcmb
            // 
            this.Currencychangingcmb.FormattingEnabled = true;
            this.Currencychangingcmb.Items.AddRange(new object[] {
            "Indian_Rupee",
            "Euro",
            "Japanese_Yen",
            "Rusian_Ruble",
            "UK_Pound",
            "US_Dollars"});
            this.Currencychangingcmb.Location = new System.Drawing.Point(798, 320);
            this.Currencychangingcmb.Name = "Currencychangingcmb";
            this.Currencychangingcmb.Size = new System.Drawing.Size(162, 21);
            this.Currencychangingcmb.TabIndex = 10;
            this.Currencychangingcmb.Text = "Indian Rupee";
            this.Currencychangingcmb.SelectedIndexChanged += new System.EventHandler(this.Currencychangingcmb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(798, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 46);
            this.label7.TabIndex = 11;
            this.label7.Text = "Please select the \r\nauthorised signature";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Select Signature";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // siglab
            // 
            this.siglab.AutoSize = true;
            this.siglab.Location = new System.Drawing.Point(802, 414);
            this.siglab.Name = "siglab";
            this.siglab.Size = new System.Drawing.Size(0, 13);
            this.siglab.TabIndex = 13;
            this.siglab.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(808, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save cheque template";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(805, 622);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 33);
            this.button4.TabIndex = 15;
            this.button4.Text = "Print ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(802, 579);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(0, 13);
            this.color.TabIndex = 16;
            // 
            // colorset
            // 
            this.colorset.AutoSize = true;
            this.colorset.Location = new System.Drawing.Point(900, 589);
            this.colorset.Name = "colorset";
            this.colorset.Size = new System.Drawing.Size(0, 13);
            this.colorset.TabIndex = 17;
            this.colorset.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(797, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 46);
            this.label8.TabIndex = 18;
            this.label8.Text = "Please Type template\r\nname Before saving";
            // 
            // errortemplatelab
            // 
            this.errortemplatelab.AutoSize = true;
            this.errortemplatelab.Location = new System.Drawing.Point(802, 525);
            this.errortemplatelab.Name = "errortemplatelab";
            this.errortemplatelab.Size = new System.Drawing.Size(35, 13);
            this.errortemplatelab.TabIndex = 19;
            this.errortemplatelab.Text = "label9";
            this.errortemplatelab.Visible = false;
            // 
            // templatenametxt
            // 
            this.templatenametxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatenametxt.Location = new System.Drawing.Point(798, 542);
            this.templatenametxt.Name = "templatenametxt";
            this.templatenametxt.Size = new System.Drawing.Size(151, 31);
            this.templatenametxt.TabIndex = 20;
            // 
            // colorsavtxt
            // 
            this.colorsavtxt.Location = new System.Drawing.Point(808, 414);
            this.colorsavtxt.Name = "colorsavtxt";
            this.colorsavtxt.Size = new System.Drawing.Size(100, 20);
            this.colorsavtxt.TabIndex = 21;
            this.colorsavtxt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please use bellow \r\nControls  for \r\ncustamisation\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(785, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 100);
            this.panel2.TabIndex = 3;
            // 
            // Container
            // 
            this.Container.Controls.Add(this.chequedesignpan);
            this.Container.Controls.Add(this.panel1);
            this.Container.Location = new System.Drawing.Point(0, -5);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(785, 669);
            this.Container.TabIndex = 22;
            this.Container.TabStop = false;
            this.Container.Text = "groupBox1";
            // 
            // chequedesignpan
            // 
            this.chequedesignpan.Controls.Add(this.personpay);
            this.chequedesignpan.Controls.Add(this.authorisedsigngb);
            this.chequedesignpan.Controls.Add(this.Payeeindiggb);
            this.chequedesignpan.Controls.Add(this.payeeinwordsgb);
            this.chequedesignpan.Controls.Add(this.dateTimePicker1);
            this.chequedesignpan.Controls.Add(this.crossingpic);
            this.chequedesignpan.Location = new System.Drawing.Point(0, 395);
            this.chequedesignpan.Name = "chequedesignpan";
            this.chequedesignpan.Size = new System.Drawing.Size(781, 263);
            this.chequedesignpan.TabIndex = 4;
            // 
            // personpay
            // 
            this.personpay.Controls.Add(this.textBox3);
            this.personpay.Controls.Add(this.label6);
            this.personpay.Location = new System.Drawing.Point(116, 3);
            this.personpay.Name = "personpay";
            this.personpay.Size = new System.Drawing.Size(509, 47);
            this.personpay.TabIndex = 9;
            this.personpay.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(38, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(461, 31);
            this.textBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "pay";
            // 
            // authorisedsigngb
            // 
            this.authorisedsigngb.Controls.Add(this.pictureBox2);
            this.authorisedsigngb.Controls.Add(this.label5);
            this.authorisedsigngb.Location = new System.Drawing.Point(422, 174);
            this.authorisedsigngb.Name = "authorisedsigngb";
            this.authorisedsigngb.Size = new System.Drawing.Size(314, 81);
            this.authorisedsigngb.TabIndex = 8;
            this.authorisedsigngb.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(6, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Authorised Signatory/signatories\r\n";
            // 
            // Payeeindiggb
            // 
            this.Payeeindiggb.Controls.Add(this.curlab);
            this.Payeeindiggb.Controls.Add(this.payeetxt);
            this.Payeeindiggb.Location = new System.Drawing.Point(567, 68);
            this.Payeeindiggb.Name = "Payeeindiggb";
            this.Payeeindiggb.Size = new System.Drawing.Size(200, 100);
            this.Payeeindiggb.TabIndex = 7;
            this.Payeeindiggb.TabStop = false;
            // 
            // curlab
            // 
            this.curlab.AutoSize = true;
            this.curlab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curlab.Location = new System.Drawing.Point(12, 16);
            this.curlab.Name = "curlab";
            this.curlab.Size = new System.Drawing.Size(123, 23);
            this.curlab.TabIndex = 4;
            this.curlab.Text = "Rupee in Digits";
            // 
            // payeetxt
            // 
            this.payeetxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payeetxt.Location = new System.Drawing.Point(16, 42);
            this.payeetxt.MaxLength = 15;
            this.payeetxt.Name = "payeetxt";
            this.payeetxt.Size = new System.Drawing.Size(153, 33);
            this.payeetxt.TabIndex = 2;
            // 
            // payeeinwordsgb
            // 
            this.payeeinwordsgb.Controls.Add(this.curdiglab);
            this.payeeinwordsgb.Controls.Add(this.currencywords);
            this.payeeinwordsgb.Controls.Add(this.label4);
            this.payeeinwordsgb.Controls.Add(this.amtwordssec);
            this.payeeinwordsgb.Controls.Add(this.amtwordsone);
            this.payeeinwordsgb.Location = new System.Drawing.Point(11, 68);
            this.payeeinwordsgb.Name = "payeeinwordsgb";
            this.payeeinwordsgb.Size = new System.Drawing.Size(550, 100);
            this.payeeinwordsgb.TabIndex = 6;
            this.payeeinwordsgb.TabStop = false;
            // 
            // curdiglab
            // 
            this.curdiglab.AutoSize = true;
            this.curdiglab.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curdiglab.Location = new System.Drawing.Point(0, 67);
            this.curdiglab.Name = "curdiglab";
            this.curdiglab.Size = new System.Drawing.Size(100, 15);
            this.curdiglab.TabIndex = 4;
            this.curdiglab.Text = "(Rupee in Words)";
            // 
            // currencywords
            // 
            this.currencywords.AutoSize = true;
            this.currencywords.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencywords.Location = new System.Drawing.Point(40, 61);
            this.currencywords.Name = "currencywords";
            this.currencywords.Size = new System.Drawing.Size(0, 23);
            this.currencywords.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // amtwordssec
            // 
            this.amtwordssec.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtwordssec.Location = new System.Drawing.Point(136, 60);
            this.amtwordssec.MaxLength = 50;
            this.amtwordssec.Name = "amtwordssec";
            this.amtwordssec.Size = new System.Drawing.Size(408, 31);
            this.amtwordssec.TabIndex = 2;
            // 
            // amtwordsone
            // 
            this.amtwordsone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtwordsone.Location = new System.Drawing.Point(136, 23);
            this.amtwordsone.MaxLength = 100;
            this.amtwordsone.Name = "amtwordsone";
            this.amtwordsone.Size = new System.Drawing.Size(408, 31);
            this.amtwordsone.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(631, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // crossingpic
            // 
            this.crossingpic.Image = global::ChequePrinter.Properties.Resources.crs;
            this.crossingpic.Location = new System.Drawing.Point(0, 0);
            this.crossingpic.Name = "crossingpic";
            this.crossingpic.Size = new System.Drawing.Size(100, 50);
            this.crossingpic.TabIndex = 0;
            this.crossingpic.TabStop = false;
            this.crossingpic.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.letterheadpic);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 389);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChequePrinter.Properties.Resources.rule051;
            this.pictureBox1.Location = new System.Drawing.Point(0, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // letterheadpic
            // 
            this.letterheadpic.Location = new System.Drawing.Point(3, 2);
            this.letterheadpic.Name = "letterheadpic";
            this.letterheadpic.Size = new System.Drawing.Size(782, 378);
            this.letterheadpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.letterheadpic.TabIndex = 0;
            this.letterheadpic.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.colorsavtxt);
            this.Controls.Add(this.templatenametxt);
            this.Controls.Add(this.errortemplatelab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.colorset);
            this.Controls.Add(this.color);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.siglab);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Currencychangingcmb);
            this.Controls.Add(this.currencylab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crossinchk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "Form4";
            this.Text = "Design the Cheque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Container.ResumeLayout(false);
            this.chequedesignpan.ResumeLayout(false);
            this.personpay.ResumeLayout(false);
            this.personpay.PerformLayout();
            this.authorisedsigngb.ResumeLayout(false);
            this.authorisedsigngb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Payeeindiggb.ResumeLayout(false);
            this.Payeeindiggb.PerformLayout();
            this.payeeinwordsgb.ResumeLayout(false);
            this.payeeinwordsgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crossingpic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterheadpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox crossinchk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currencylab;
        private System.Windows.Forms.ComboBox Currencychangingcmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label siglab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label colorset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label errortemplatelab;
        private System.Windows.Forms.TextBox templatenametxt;
        private System.Windows.Forms.TextBox colorsavtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Container;
        private System.Windows.Forms.Panel chequedesignpan;
        private System.Windows.Forms.GroupBox personpay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox authorisedsigngb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Payeeindiggb;
        private System.Windows.Forms.Label curlab;
        private System.Windows.Forms.TextBox payeetxt;
        private System.Windows.Forms.GroupBox payeeinwordsgb;
        private System.Windows.Forms.Label curdiglab;
        private System.Windows.Forms.Label currencywords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amtwordssec;
        private System.Windows.Forms.TextBox amtwordsone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox crossingpic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox letterheadpic;

    }
}