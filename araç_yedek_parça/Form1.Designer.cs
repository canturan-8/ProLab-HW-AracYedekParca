//Salih Can Turan 210229040

namespace araç_yedek_parça
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Yeni_Kayıt = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.User_Name_satıcı = new System.Windows.Forms.TextBox();
            this.User_Password_satıcı = new System.Windows.Forms.TextBox();
            this.User_name_admin = new System.Windows.Forms.TextBox();
            this.User_password_admin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 10);
            this.label1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(68, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.müşteri_giriş);
            // 
            // Yeni_Kayıt
            // 
            this.Yeni_Kayıt.BackColor = System.Drawing.Color.LightBlue;
            this.Yeni_Kayıt.Location = new System.Drawing.Point(350, 186);
            this.Yeni_Kayıt.Name = "Yeni_Kayıt";
            this.Yeni_Kayıt.Size = new System.Drawing.Size(100, 43);
            this.Yeni_Kayıt.TabIndex = 5;
            this.Yeni_Kayıt.Text = "Login";
            this.Yeni_Kayıt.UseVisualStyleBackColor = false;
            this.Yeni_Kayıt.Click += new System.EventHandler(this.Satıcı_buton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(287, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(287, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // User_Name_satıcı
            // 
            this.User_Name_satıcı.Location = new System.Drawing.Point(385, 94);
            this.User_Name_satıcı.Name = "User_Name_satıcı";
            this.User_Name_satıcı.Size = new System.Drawing.Size(100, 26);
            this.User_Name_satıcı.TabIndex = 10;
            this.User_Name_satıcı.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // User_Password_satıcı
            // 
            this.User_Password_satıcı.Location = new System.Drawing.Point(385, 139);
            this.User_Password_satıcı.Name = "User_Password_satıcı";
            this.User_Password_satıcı.Size = new System.Drawing.Size(100, 26);
            this.User_Password_satıcı.TabIndex = 11;
            this.User_Password_satıcı.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // User_name_admin
            // 
            this.User_name_admin.Location = new System.Drawing.Point(669, 91);
            this.User_name_admin.Name = "User_name_admin";
            this.User_name_admin.Size = new System.Drawing.Size(103, 26);
            this.User_name_admin.TabIndex = 12;
            this.User_name_admin.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // User_password_admin
            // 
            this.User_password_admin.Location = new System.Drawing.Point(667, 142);
            this.User_password_admin.Name = "User_password_admin";
            this.User_password_admin.Size = new System.Drawing.Size(105, 26);
            this.User_password_admin.TabIndex = 13;
            this.User_password_admin.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(564, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(564, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(624, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Admin Login";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Location = new System.Drawing.Point(628, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.admin_buton);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(259, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 40);
            this.button4.TabIndex = 18;
            this.button4.Text = "Register ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Kayıt_butonu);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(9, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(12, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(346, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Dealer Login";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(75, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Customer Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::araç_yedek_parça.Properties.Resources.desktop_wallpaper_classic_car_backgrounds_vintage_car;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.User_password_admin);
            this.Controls.Add(this.User_name_admin);
            this.Controls.Add(this.User_Password_satıcı);
            this.Controls.Add(this.User_Name_satıcı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Yeni_Kayıt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giriş ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Yeni_Kayıt;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox User_Name_satıcı;
        private System.Windows.Forms.TextBox User_Password_satıcı;
        private System.Windows.Forms.TextBox User_name_admin;
        private System.Windows.Forms.TextBox User_password_admin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

