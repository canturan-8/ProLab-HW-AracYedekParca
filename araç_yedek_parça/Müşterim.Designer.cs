namespace araç_yedek_parça
{
    partial class Müşterim
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
            this.comboBox_marka = new System.Windows.Forms.ComboBox();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.comboBox_paket = new System.Windows.Forms.ComboBox();
            this.comboBox_Parça = new System.Windows.Forms.ComboBox();
            this.comboBox_adet = new System.Windows.Forms.ComboBox();
            this.araç_label = new System.Windows.Forms.Label();
            this.Model_label = new System.Windows.Forms.Label();
            this.paket_label = new System.Windows.Forms.Label();
            this.parça_label = new System.Windows.Forms.Label();
            this.adet_label = new System.Windows.Forms.Label();
            this.sepete_eklenecek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sepete_ekle_buton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sepet_listesi_box = new System.Windows.Forms.ListBox();
            this.Hesap_sil = new System.Windows.Forms.Button();
            this.sepetten_sil = new System.Windows.Forms.Button();
            this.Geçmiş_talepler_box = new System.Windows.Forms.ListBox();
            this.Geçmiş_talepleri_güncelle_buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_marka
            // 
            this.comboBox_marka.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox_marka.FormattingEnabled = true;
            this.comboBox_marka.Location = new System.Drawing.Point(194, 93);
            this.comboBox_marka.Name = "comboBox_marka";
            this.comboBox_marka.Size = new System.Drawing.Size(117, 28);
            this.comboBox_marka.TabIndex = 1;
            this.comboBox_marka.SelectedIndexChanged += new System.EventHandler(this.comboBox_marka_SelectedIndexChanged);
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(193, 140);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(118, 28);
            this.comboBox_Model.TabIndex = 2;
            this.comboBox_Model.SelectedIndexChanged += new System.EventHandler(this.comboBox_Model_SelectedIndexChanged);
            // 
            // comboBox_paket
            // 
            this.comboBox_paket.FormattingEnabled = true;
            this.comboBox_paket.Location = new System.Drawing.Point(191, 186);
            this.comboBox_paket.Name = "comboBox_paket";
            this.comboBox_paket.Size = new System.Drawing.Size(120, 28);
            this.comboBox_paket.TabIndex = 3;
            this.comboBox_paket.SelectedIndexChanged += new System.EventHandler(this.comboBox_paket_SelectedIndexChanged);
            // 
            // comboBox_Parça
            // 
            this.comboBox_Parça.FormattingEnabled = true;
            this.comboBox_Parça.Location = new System.Drawing.Point(191, 229);
            this.comboBox_Parça.Name = "comboBox_Parça";
            this.comboBox_Parça.Size = new System.Drawing.Size(120, 28);
            this.comboBox_Parça.TabIndex = 4;
            this.comboBox_Parça.SelectedIndexChanged += new System.EventHandler(this.comboBox_Parça_SelectedIndexChanged);
            // 
            // comboBox_adet
            // 
            this.comboBox_adet.FormattingEnabled = true;
            this.comboBox_adet.Location = new System.Drawing.Point(190, 278);
            this.comboBox_adet.Name = "comboBox_adet";
            this.comboBox_adet.Size = new System.Drawing.Size(121, 28);
            this.comboBox_adet.TabIndex = 5;
            this.comboBox_adet.SelectedIndexChanged += new System.EventHandler(this.comboBox_adet_SelectedIndexChanged);
            // 
            // araç_label
            // 
            this.araç_label.AutoSize = true;
            this.araç_label.BackColor = System.Drawing.Color.Silver;
            this.araç_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.araç_label.Location = new System.Drawing.Point(135, 93);
            this.araç_label.Name = "araç_label";
            this.araç_label.Size = new System.Drawing.Size(52, 20);
            this.araç_label.TabIndex = 6;
            this.araç_label.Text = "Brand";
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.BackColor = System.Drawing.Color.Silver;
            this.Model_label.Location = new System.Drawing.Point(135, 143);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(52, 20);
            this.Model_label.TabIndex = 7;
            this.Model_label.Text = "Model";
            // 
            // paket_label
            // 
            this.paket_label.AutoSize = true;
            this.paket_label.BackColor = System.Drawing.Color.Silver;
            this.paket_label.Location = new System.Drawing.Point(129, 186);
            this.paket_label.Name = "paket_label";
            this.paket_label.Size = new System.Drawing.Size(58, 20);
            this.paket_label.TabIndex = 8;
            this.paket_label.Text = "Packet";
            // 
            // parça_label
            // 
            this.parça_label.AutoSize = true;
            this.parça_label.BackColor = System.Drawing.Color.Silver;
            this.parça_label.Location = new System.Drawing.Point(102, 237);
            this.parça_label.Name = "parça_label";
            this.parça_label.Size = new System.Drawing.Size(85, 20);
            this.parça_label.TabIndex = 9;
            this.parça_label.Text = "Spare Part";
            // 
            // adet_label
            // 
            this.adet_label.AutoSize = true;
            this.adet_label.BackColor = System.Drawing.Color.Silver;
            this.adet_label.Location = new System.Drawing.Point(116, 281);
            this.adet_label.Name = "adet_label";
            this.adet_label.Size = new System.Drawing.Size(68, 20);
            this.adet_label.TabIndex = 10;
            this.adet_label.Text = "Quantity";
            // 
            // sepete_eklenecek
            // 
            this.sepete_eklenecek.BackColor = System.Drawing.Color.AliceBlue;
            this.sepete_eklenecek.Location = new System.Drawing.Point(174, 374);
            this.sepete_eklenecek.Name = "sepete_eklenecek";
            this.sepete_eklenecek.Size = new System.Drawing.Size(82, 26);
            this.sepete_eklenecek.TabIndex = 12;
            this.sepete_eklenecek.TextChanged += new System.EventHandler(this.sepete_eklenecek_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "quantity you want to add";
            // 
            // sepete_ekle_buton
            // 
            this.sepete_ekle_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sepete_ekle_buton.Location = new System.Drawing.Point(156, 418);
            this.sepete_ekle_buton.Name = "sepete_ekle_buton";
            this.sepete_ekle_buton.Size = new System.Drawing.Size(118, 43);
            this.sepete_ekle_buton.TabIndex = 14;
            this.sepete_ekle_buton.Text = "Add to cart";
            this.sepete_ekle_buton.UseVisualStyleBackColor = false;
            this.sepete_ekle_buton.Click += new System.EventHandler(this.sepete_ekle_buton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(345, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update My Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sepet_listesi_box
            // 
            this.sepet_listesi_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sepet_listesi_box.FormattingEnabled = true;
            this.sepet_listesi_box.ItemHeight = 20;
            this.sepet_listesi_box.Location = new System.Drawing.Point(345, 186);
            this.sepet_listesi_box.Name = "sepet_listesi_box";
            this.sepet_listesi_box.Size = new System.Drawing.Size(343, 164);
            this.sepet_listesi_box.TabIndex = 16;
            this.sepet_listesi_box.SelectedIndexChanged += new System.EventHandler(this.sepet_listesi_SelectedIndexChanged);
            // 
            // Hesap_sil
            // 
            this.Hesap_sil.BackColor = System.Drawing.Color.Red;
            this.Hesap_sil.Location = new System.Drawing.Point(989, 34);
            this.Hesap_sil.Name = "Hesap_sil";
            this.Hesap_sil.Size = new System.Drawing.Size(177, 40);
            this.Hesap_sil.TabIndex = 17;
            this.Hesap_sil.Text = "delete my account";
            this.Hesap_sil.UseVisualStyleBackColor = false;
            this.Hesap_sil.Click += new System.EventHandler(this.Hesap_sil_Click);
            // 
            // sepetten_sil
            // 
            this.sepetten_sil.BackColor = System.Drawing.Color.IndianRed;
            this.sepetten_sil.Location = new System.Drawing.Point(627, 137);
            this.sepetten_sil.Name = "sepetten_sil";
            this.sepetten_sil.Size = new System.Drawing.Size(61, 27);
            this.sepetten_sil.TabIndex = 18;
            this.sepetten_sil.Text = "delete";
            this.sepetten_sil.UseVisualStyleBackColor = false;
            this.sepetten_sil.Click += new System.EventHandler(this.sepetten_sil_Click);
            // 
            // Geçmiş_talepler_box
            // 
            this.Geçmiş_talepler_box.FormattingEnabled = true;
            this.Geçmiş_talepler_box.ItemHeight = 20;
            this.Geçmiş_talepler_box.Location = new System.Drawing.Point(772, 189);
            this.Geçmiş_talepler_box.Name = "Geçmiş_talepler_box";
            this.Geçmiş_talepler_box.Size = new System.Drawing.Size(354, 164);
            this.Geçmiş_talepler_box.TabIndex = 19;
            this.Geçmiş_talepler_box.SelectedIndexChanged += new System.EventHandler(this.Geçmiş_talepler_box_SelectedIndexChanged);
            // 
            // Geçmiş_talepleri_güncelle_buton
            // 
            this.Geçmiş_talepleri_güncelle_buton.Location = new System.Drawing.Point(774, 136);
            this.Geçmiş_talepleri_güncelle_buton.Name = "Geçmiş_talepleri_güncelle_buton";
            this.Geçmiş_talepleri_güncelle_buton.Size = new System.Drawing.Size(232, 34);
            this.Geçmiş_talepleri_güncelle_buton.TabIndex = 20;
            this.Geçmiş_talepleri_güncelle_buton.Text = "Update my request results";
            this.Geçmiş_talepleri_güncelle_buton.UseVisualStyleBackColor = true;
            this.Geçmiş_talepleri_güncelle_buton.Click += new System.EventHandler(this.Geçmiş_talepleri_güncelle_buton_Click);
            // 
            // Müşterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::araç_yedek_parça.Properties.Resources.pngtree_car_retro_illustration_background_picture_image_2445218;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.Geçmiş_talepleri_güncelle_buton);
            this.Controls.Add(this.Geçmiş_talepler_box);
            this.Controls.Add(this.sepetten_sil);
            this.Controls.Add(this.Hesap_sil);
            this.Controls.Add(this.sepet_listesi_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sepete_ekle_buton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sepete_eklenecek);
            this.Controls.Add(this.adet_label);
            this.Controls.Add(this.parça_label);
            this.Controls.Add(this.paket_label);
            this.Controls.Add(this.Model_label);
            this.Controls.Add(this.araç_label);
            this.Controls.Add(this.comboBox_adet);
            this.Controls.Add(this.comboBox_Parça);
            this.Controls.Add(this.comboBox_paket);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.comboBox_marka);
            this.Controls.Add(this.label1);
            this.Name = "Müşterim";
            this.Text = "Müşterim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Müşterim_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Müşterim_FormClosed);
            this.Load += new System.EventHandler(this.Müşterim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_marka;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_paket;
        private System.Windows.Forms.ComboBox comboBox_Parça;
        private System.Windows.Forms.ComboBox comboBox_adet;
        private System.Windows.Forms.Label araç_label;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.Label paket_label;
        private System.Windows.Forms.Label parça_label;
        private System.Windows.Forms.Label adet_label;
        private System.Windows.Forms.TextBox sepete_eklenecek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sepete_ekle_buton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox sepet_listesi_box;
        private System.Windows.Forms.Button Hesap_sil;
        private System.Windows.Forms.Button sepetten_sil;
        private System.Windows.Forms.ListBox Geçmiş_talepler_box;
        private System.Windows.Forms.Button Geçmiş_talepleri_güncelle_buton;
    }
}