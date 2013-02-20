namespace WindowsFormsApplication1
{
    partial class Tedavi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedavi));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMusteriler = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkListDisler4 = new System.Windows.Forms.CheckedListBox();
            this.chkListDisler1 = new System.Windows.Forms.CheckedListBox();
            this.chkListDisler3 = new System.Windows.Forms.CheckedListBox();
            this.chkListDisler2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkListTedaviler = new System.Windows.Forms.CheckedListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboMusteriler);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(43, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 48);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(432, 18);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(143, 27);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta Adı Soyadı:";
            // 
            // comboMusteriler
            // 
            this.comboMusteriler.FormattingEnabled = true;
            this.comboMusteriler.Location = new System.Drawing.Point(167, 19);
            this.comboMusteriler.Name = "comboMusteriler";
            this.comboMusteriler.Size = new System.Drawing.Size(176, 21);
            this.comboMusteriler.TabIndex = 4;
            this.comboMusteriler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.chkListDisler4);
            this.groupBox2.Controls.Add(this.chkListDisler1);
            this.groupBox2.Controls.Add(this.chkListDisler3);
            this.groupBox2.Controls.Add(this.chkListDisler2);
            this.groupBox2.Location = new System.Drawing.Point(317, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 302);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DİŞLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chkListDisler4
            // 
            this.chkListDisler4.CheckOnClick = true;
            this.chkListDisler4.FormattingEnabled = true;
            this.chkListDisler4.Items.AddRange(new object[] {
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38"});
            this.chkListDisler4.Location = new System.Drawing.Point(258, 169);
            this.chkListDisler4.Name = "chkListDisler4";
            this.chkListDisler4.Size = new System.Drawing.Size(43, 124);
            this.chkListDisler4.TabIndex = 6;
            // 
            // chkListDisler1
            // 
            this.chkListDisler1.CheckOnClick = true;
            this.chkListDisler1.FormattingEnabled = true;
            this.chkListDisler1.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.chkListDisler1.Location = new System.Drawing.Point(7, 34);
            this.chkListDisler1.MultiColumn = true;
            this.chkListDisler1.Name = "chkListDisler1";
            this.chkListDisler1.Size = new System.Drawing.Size(43, 124);
            this.chkListDisler1.TabIndex = 0;
            // 
            // chkListDisler3
            // 
            this.chkListDisler3.CheckOnClick = true;
            this.chkListDisler3.FormattingEnabled = true;
            this.chkListDisler3.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.chkListDisler3.Location = new System.Drawing.Point(258, 34);
            this.chkListDisler3.Name = "chkListDisler3";
            this.chkListDisler3.Size = new System.Drawing.Size(43, 124);
            this.chkListDisler3.TabIndex = 5;
            // 
            // chkListDisler2
            // 
            this.chkListDisler2.CheckOnClick = true;
            this.chkListDisler2.FormattingEnabled = true;
            this.chkListDisler2.Items.AddRange(new object[] {
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48"});
            this.chkListDisler2.Location = new System.Drawing.Point(7, 169);
            this.chkListDisler2.Name = "chkListDisler2";
            this.chkListDisler2.Size = new System.Drawing.Size(43, 124);
            this.chkListDisler2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkListTedaviler);
            this.groupBox1.Location = new System.Drawing.Point(43, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 302);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEDAVİ EKLE";
            // 
            // chkListTedaviler
            // 
            this.chkListTedaviler.AllowDrop = true;
            this.chkListTedaviler.CheckOnClick = true;
            this.chkListTedaviler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkListTedaviler.ForeColor = System.Drawing.Color.Black;
            this.chkListTedaviler.FormattingEnabled = true;
            this.chkListTedaviler.Items.AddRange(new object[] {
            "KIRIK TEDAVİSİ\t\t\t",
            "APİKAL APSE\t\t\t",
            "KIRIK VEYA DÜŞMÜŞ DOLGU\t\t\t",
            "KÖK\t\t\t",
            "KÖK ANKERİ\t\t\t",
            "KÖK REZORBSİYONU\t\t\t",
            "KANAL TEDAVİSİ YAPILMIŞ\t\t\t",
            "LÜXE DİŞ\t\t\t",
            "MİNE HİPOLAZİSİ\t\t\t",
            "PERİODONTAL FİSTÜL\t\t\t",
            "PERİODONTOL APSE\t\t\t",
            "PULPİTİS\t\t\t",
            "APİKAL KİST\t\t\t",
            "YUMUŞAK DOKU LEZYONU\t\t\t",
            "KIRIK SERVİKAL\t\t\t",
            "KIRIK DİSTAL\t\t\t",
            "KIRIK MESSİAL\t\t\t",
            "KIRIK O\t\t\t",
            "KIRIK LİNGUAL\t\t\t",
            "KIRIK BUCCAL\t\t\t",
            "APİKAL REZEKSİYON\t\t\t",
            "ÇENE KIRIĞI",
            "Amalgam dolgu (bir yüzlü)",
            "Amalgam dolgu (iki yüzlü)",
            "Amalgam dolgu (üç yüzlü)",
            "Kanal tedavisi - Tek kanal(dolgu  hariç)\t\t",
            "Kanal tedavisi - İki kanal(dolgu  hariç)\t\t",
            "Kanal tedavisi - Üç kanal(dolgu  hariç)\t\t",
            "Kanal Tedavisi - İlave her kanal için ",
            "Dolgu (restorasyon) tamiri",
            "Dolgu sökümü (tek diş)",
            "Kanal dolgusu sökümü",
            "Diş çekimi"});
            this.chkListTedaviler.Location = new System.Drawing.Point(6, 34);
            this.chkListTedaviler.Name = "chkListTedaviler";
            this.chkListTedaviler.Size = new System.Drawing.Size(236, 259);
            this.chkListTedaviler.TabIndex = 0;
            this.chkListTedaviler.SelectedIndexChanged += new System.EventHandler(this.chkListTedaviler_SelectedIndexChanged);
            // 
            // Tedavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Tedavi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedavi";
            this.Load += new System.EventHandler(this.Tedavi_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMusteriler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox chkListDisler4;
        private System.Windows.Forms.CheckedListBox chkListDisler1;
        private System.Windows.Forms.CheckedListBox chkListDisler3;
        private System.Windows.Forms.CheckedListBox chkListDisler2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkListTedaviler;
    }
}