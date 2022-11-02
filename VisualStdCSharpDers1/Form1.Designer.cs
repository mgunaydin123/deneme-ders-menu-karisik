namespace VisualStdCSharpDers1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMesajGoruntule = new System.Windows.Forms.Button();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.buttonMetniSil = new System.Windows.Forms.Button();
            this.comboBoxİsimler = new System.Windows.Forms.ComboBox();
            this.buttonIsimekle = new System.Windows.Forms.Button();
            this.labelYazılanİsim = new System.Windows.Forms.Label();
            this.buttonLabelDegistir = new System.Windows.Forms.Button();
            this.listBoxDersler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxMetin = new System.Windows.Forms.RichTextBox();
            this.buttonRichTextBox = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMesajGoruntule
            // 
            this.buttonMesajGoruntule.Location = new System.Drawing.Point(16, 22);
            this.buttonMesajGoruntule.Name = "buttonMesajGoruntule";
            this.buttonMesajGoruntule.Size = new System.Drawing.Size(115, 23);
            this.buttonMesajGoruntule.TabIndex = 0;
            this.buttonMesajGoruntule.Text = "Mesaj Yaz";
            this.buttonMesajGoruntule.UseVisualStyleBackColor = true;
            this.buttonMesajGoruntule.Click += new System.EventHandler(this.buttonMesajGoruntule_Click);
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxMesaj.ForeColor = System.Drawing.Color.White;
            this.textBoxMesaj.Location = new System.Drawing.Point(221, 41);
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(149, 23);
            this.textBoxMesaj.TabIndex = 1;
            // 
            // buttonMetniSil
            // 
            this.buttonMetniSil.Location = new System.Drawing.Point(16, 60);
            this.buttonMetniSil.Name = "buttonMetniSil";
            this.buttonMetniSil.Size = new System.Drawing.Size(115, 23);
            this.buttonMetniSil.TabIndex = 2;
            this.buttonMetniSil.Text = "Sil";
            this.buttonMetniSil.UseVisualStyleBackColor = true;
            this.buttonMetniSil.Click += new System.EventHandler(this.buttonMetniSil_Click);
            // 
            // comboBoxİsimler
            // 
            this.comboBoxİsimler.FormattingEnabled = true;
            this.comboBoxİsimler.Items.AddRange(new object[] {
            "Mine Serkan",
            "Selma Kağan",
            "Egemen Leyla"});
            this.comboBoxİsimler.Location = new System.Drawing.Point(410, 87);
            this.comboBoxİsimler.Name = "comboBoxİsimler";
            this.comboBoxİsimler.Size = new System.Drawing.Size(121, 23);
            this.comboBoxİsimler.TabIndex = 3;
            this.comboBoxİsimler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonIsimekle
            // 
            this.buttonIsimekle.Location = new System.Drawing.Point(410, 41);
            this.buttonIsimekle.Name = "buttonIsimekle";
            this.buttonIsimekle.Size = new System.Drawing.Size(119, 23);
            this.buttonIsimekle.TabIndex = 4;
            this.buttonIsimekle.Text = "İsmi Comboya Ekle";
            this.buttonIsimekle.UseVisualStyleBackColor = true;
            this.buttonIsimekle.Click += new System.EventHandler(this.buttonIsimekle_Click);
            // 
            // labelYazılanİsim
            // 
            this.labelYazılanİsim.AutoSize = true;
            this.labelYazılanİsim.BackColor = System.Drawing.Color.Red;
            this.labelYazılanİsim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelYazılanİsim.ForeColor = System.Drawing.Color.White;
            this.labelYazılanİsim.Location = new System.Drawing.Point(38, 87);
            this.labelYazılanİsim.Name = "labelYazılanİsim";
            this.labelYazılanİsim.Size = new System.Drawing.Size(52, 23);
            this.labelYazılanİsim.TabIndex = 5;
            this.labelYazılanİsim.Text = "label1";
            // 
            // buttonLabelDegistir
            // 
            this.buttonLabelDegistir.Location = new System.Drawing.Point(23, 134);
            this.buttonLabelDegistir.Name = "buttonLabelDegistir";
            this.buttonLabelDegistir.Size = new System.Drawing.Size(115, 23);
            this.buttonLabelDegistir.TabIndex = 6;
            this.buttonLabelDegistir.Text = "Label Değiştir";
            this.buttonLabelDegistir.UseVisualStyleBackColor = true;
            this.buttonLabelDegistir.Click += new System.EventHandler(this.buttonLabelDegistir_Click);
            // 
            // listBoxDersler
            // 
            this.listBoxDersler.FormattingEnabled = true;
            this.listBoxDersler.ItemHeight = 15;
            this.listBoxDersler.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Kimya",
            "Biyoloji"});
            this.listBoxDersler.Location = new System.Drawing.Point(391, 184);
            this.listBoxDersler.Name = "listBoxDersler";
            this.listBoxDersler.Size = new System.Drawing.Size(120, 94);
            this.listBoxDersler.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMesajGoruntule);
            this.groupBox1.Controls.Add(this.buttonMetniSil);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metin Kutusu İşlemleri";
            // 
            // richTextBoxMetin
            // 
            this.richTextBoxMetin.Location = new System.Drawing.Point(31, 158);
            this.richTextBoxMetin.Name = "richTextBoxMetin";
            this.richTextBoxMetin.Size = new System.Drawing.Size(184, 138);
            this.richTextBoxMetin.TabIndex = 9;
            this.richTextBoxMetin.Text = "Hello C#\nMerhaba C#";
            // 
            // buttonRichTextBox
            // 
            this.buttonRichTextBox.Location = new System.Drawing.Point(246, 153);
            this.buttonRichTextBox.Name = "buttonRichTextBox";
            this.buttonRichTextBox.Size = new System.Drawing.Size(71, 30);
            this.buttonRichTextBox.TabIndex = 10;
            this.buttonRichTextBox.Text = "button1";
            this.buttonRichTextBox.UseVisualStyleBackColor = true;
            this.buttonRichTextBox.Click += new System.EventHandler(this.buttonRichTextBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(246, 302);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(144, 45);
            this.trackBarVolume.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "zeytin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 19);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "sosis";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(36, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 19);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Rus salatası";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(19, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 98);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kumpir Mlazeme";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 19);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 19);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 19);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.Text = "Big";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(19, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İçecek";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.labelYazılanİsim);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.buttonLabelDegistir);
            this.panel1.Location = new System.Drawing.Point(633, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 449);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonRichTextBox);
            this.Controls.Add(this.richTextBoxMetin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxDersler);
            this.Controls.Add(this.buttonIsimekle);
            this.Controls.Add(this.comboBoxİsimler);
            this.Controls.Add(this.textBoxMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonMesajGoruntule;
        private TextBox textBoxMesaj;
        private Button buttonMetniSil;
        private ComboBox comboBoxİsimler;
        private Button buttonIsimekle;
        private Label labelYazılanİsim;
        private Button buttonLabelDegistir;
        private ListBox listBoxDersler;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxMetin;
        private Button buttonRichTextBox;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private TrackBar trackBarVolume;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox3;
        private Panel panel1;
    }
}