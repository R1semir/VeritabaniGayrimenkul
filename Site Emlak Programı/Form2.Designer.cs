namespace Site_Emlak_Programı
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
            this.cmSite = new System.Windows.Forms.ComboBox();
            this.cmSatKira = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmOdaSayisi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txMetre = new System.Windows.Forms.TextBox();
            this.txFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txNot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txTel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmBlok = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txDaire = new System.Windows.Forms.TextBox();
            this.btnZambak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGül = new System.Windows.Forms.Button();
            this.btnMenekşe = new System.Windows.Forms.Button();
            this.btnPapatya = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gayrimenkul Bilgiler";
            // 
            // cmSite
            // 
            this.cmSite.FormattingEnabled = true;
            this.cmSite.Items.AddRange(new object[] {
            "ZambakSit",
            "PapatyaSit",
            "GülSit",
            "MenekşeSit"});
            this.cmSite.Location = new System.Drawing.Point(94, 105);
            this.cmSite.Name = "cmSite";
            this.cmSite.Size = new System.Drawing.Size(140, 28);
            this.cmSite.TabIndex = 2;
            this.cmSite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmSatKira
            // 
            this.cmSatKira.FormattingEnabled = true;
            this.cmSatKira.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cmSatKira.Location = new System.Drawing.Point(94, 155);
            this.cmSatKira.Name = "cmSatKira";
            this.cmSatKira.Size = new System.Drawing.Size(140, 28);
            this.cmSatKira.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sat/Kira:";
            // 
            // cmOdaSayisi
            // 
            this.cmOdaSayisi.FormattingEnabled = true;
            this.cmOdaSayisi.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.cmOdaSayisi.Location = new System.Drawing.Point(94, 207);
            this.cmOdaSayisi.Name = "cmOdaSayisi";
            this.cmOdaSayisi.Size = new System.Drawing.Size(140, 28);
            this.cmOdaSayisi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "MetreKare:";
            // 
            // txMetre
            // 
            this.txMetre.Location = new System.Drawing.Point(94, 259);
            this.txMetre.Name = "txMetre";
            this.txMetre.Size = new System.Drawing.Size(140, 25);
            this.txMetre.TabIndex = 8;
            // 
            // txFiyat
            // 
            this.txFiyat.Location = new System.Drawing.Point(94, 311);
            this.txFiyat.Name = "txFiyat";
            this.txFiyat.Size = new System.Drawing.Size(140, 25);
            this.txFiyat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fiyat:";
            // 
            // txNot
            // 
            this.txNot.Location = new System.Drawing.Point(379, 174);
            this.txNot.Multiline = true;
            this.txNot.Name = "txNot";
            this.txNot.Size = new System.Drawing.Size(140, 129);
            this.txNot.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notlar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // txAdSoyad
            // 
            this.txAdSoyad.Location = new System.Drawing.Point(379, 70);
            this.txAdSoyad.Name = "txAdSoyad";
            this.txAdSoyad.Size = new System.Drawing.Size(140, 25);
            this.txAdSoyad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad:";
            // 
            // txTel
            // 
            this.txTel.Location = new System.Drawing.Point(379, 122);
            this.txTel.Name = "txTel";
            this.txTel.Size = new System.Drawing.Size(140, 25);
            this.txTel.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon:";
            // 
            // cmBlok
            // 
            this.cmBlok.FormattingEnabled = true;
            this.cmBlok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmBlok.Location = new System.Drawing.Point(84, 361);
            this.cmBlok.Name = "cmBlok";
            this.cmBlok.Size = new System.Drawing.Size(51, 28);
            this.cmBlok.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Blok:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Daire No:";
            // 
            // txDaire
            // 
            this.txDaire.Location = new System.Drawing.Point(202, 362);
            this.txDaire.Name = "txDaire";
            this.txDaire.Size = new System.Drawing.Size(33, 25);
            this.txDaire.TabIndex = 21;
            // 
            // btnZambak
            // 
            this.btnZambak.BackColor = System.Drawing.Color.Gray;
            this.btnZambak.Location = new System.Drawing.Point(720, 105);
            this.btnZambak.Name = "btnZambak";
            this.btnZambak.Size = new System.Drawing.Size(107, 73);
            this.btnZambak.TabIndex = 22;
            this.btnZambak.Text = "Zambak";
            this.btnZambak.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(754, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Site:";
            // 
            // btnGül
            // 
            this.btnGül.BackColor = System.Drawing.Color.Gray;
            this.btnGül.Location = new System.Drawing.Point(616, 174);
            this.btnGül.Name = "btnGül";
            this.btnGül.Size = new System.Drawing.Size(107, 73);
            this.btnGül.TabIndex = 24;
            this.btnGül.Text = "Gül";
            this.btnGül.UseVisualStyleBackColor = false;
            // 
            // btnMenekşe
            // 
            this.btnMenekşe.BackColor = System.Drawing.Color.Gray;
            this.btnMenekşe.Location = new System.Drawing.Point(720, 243);
            this.btnMenekşe.Name = "btnMenekşe";
            this.btnMenekşe.Size = new System.Drawing.Size(107, 73);
            this.btnMenekşe.TabIndex = 25;
            this.btnMenekşe.Text = "Menekşe";
            this.btnMenekşe.UseVisualStyleBackColor = false;
            // 
            // btnPapatya
            // 
            this.btnPapatya.BackColor = System.Drawing.Color.Gray;
            this.btnPapatya.Location = new System.Drawing.Point(823, 175);
            this.btnPapatya.Name = "btnPapatya";
            this.btnPapatya.Size = new System.Drawing.Size(107, 73);
            this.btnPapatya.TabIndex = 26;
            this.btnPapatya.Text = "Papatya";
            this.btnPapatya.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 463);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(884, 197);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Site";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Metre";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Blok";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Daire";
            this.columnHeader7.Width = 49;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ad Soyad";
            this.columnHeader8.Width = 119;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telefon";
            this.columnHeader9.Width = 105;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Notlar";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Satılık/Kiralık";
            this.columnHeader11.Width = 100;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(94, 408);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(92, 39);
            this.btnGoruntule.TabIndex = 28;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(267, 408);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 39);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(418, 408);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 39);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(575, 408);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(92, 39);
            this.btnDuzelt.TabIndex = 31;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Id:";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(91, 60);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(40, 25);
            this.txId.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(970, 672);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnDuzelt);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPapatya);
            this.Controls.Add(this.btnMenekşe);
            this.Controls.Add(this.btnGül);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnZambak);
            this.Controls.Add(this.txDaire);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmBlok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txTel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txNot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txMetre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmOdaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmSatKira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Gayrimenkul Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmSite;
        private System.Windows.Forms.ComboBox cmSatKira;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmOdaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txMetre;
        private System.Windows.Forms.TextBox txFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmBlok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txDaire;
        private System.Windows.Forms.Button btnZambak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGül;
        private System.Windows.Forms.Button btnMenekşe;
        private System.Windows.Forms.Button btnPapatya;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txId;
    }
}