//210229040_SalihCanTuran

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace araç_yedek_parça
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {//customer


            string userName = user_name.Text;
            string userPassword = password.Text;
            string Name = Namebox.Text;
            string userEmail = eposta.Text;
            string userPhone = phone.Text;



            user kayıt_olan_kullanıcı = new user();
            bool isvalidateUserName = kayıt_olan_kullanıcı.ValidateUserName(userName);
            bool isvalidatename = kayıt_olan_kullanıcı.IsValidName(Name);
            bool isvalidateUserPassword = kayıt_olan_kullanıcı.ValidateUserPassword(userPassword);
            bool isvaldateUserEmail = kayıt_olan_kullanıcı.ValidateUserEmail(userEmail);
            bool isvalidateUserPhone = kayıt_olan_kullanıcı.ValidateUserPhone(userPhone);


            if (isvalidateUserName && isvalidateUserPassword && isvaldateUserEmail && isvalidateUserPhone && isvalidatename)
            {
                string okunacak_dosya = @"satıcı.txt";
                string okunacak_dosya2 = @"admin.txt";
                string okunacak_dosya3 = @"müşteri.txt";
                List<user> tüm_kayıtlılar = new List<user>();
                user.Reader_kişi_bilgisi(okunacak_dosya, tüm_kayıtlılar);
                user.Reader_kişi_bilgisi(okunacak_dosya2, tüm_kayıtlılar);
                user.Reader_kişi_bilgisi(okunacak_dosya3, tüm_kayıtlılar);


                var yeniListe = tüm_kayıtlılar.Where(item => item.user_name.ToString() == userName).ToList();


                if (yeniListe.Count == 0)
                {
                    string dosya_yolu = @"müşteri.txt";
                    FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine($"Username:{userName}\nPassword:{userPassword}\nName:{Name}\nEmail:{userEmail}\nPhone:{userPhone}\n*****");
                    sw.Flush();
                    sw.Close();
                    fs.Close();



                    MessageBox.Show("Your registration has been completed successfully.");
                }
                else
                {
                    MessageBox.Show("This username is used by someone else");
                }


            }
            else
            {

                if (!isvalidateUserName)
                {
                    MessageBox.Show("• Kullanıcı adı 5 ila 20 karakterden oluşmaktadır.\n• Kullanıcı adı yalnızca nümerik veya alfabetik karakterler içerebilir.\n• Kullanıcı adının ilk karakteri alfabetik karakter olmalıdır.");
                }
                else if (!isvalidateUserPassword)
                {
                    MessageBox.Show("•şifre En az 8, en fazla 20 karakter içerir.\n•şifre En az bir rakam içerir.\n•şifre En az bir büyük harf alfabesi içerir.\n•şifre En az bir küçük harf alfabesi içerir.\n•şifre !@#$%&*-+ karakterlerinden oluşan en az bir özel karakter içerir.\n•şifre Hiçbir boşluk içermez. ");
                }
                else if (!isvalidatename)
                {
                    MessageBox.Show("•Name Büyük veya küçük harfle başlamalıdır.\n•Name Özel karakter içermemelidir.");
                }
                else if (!isvaldateUserEmail)
                {
                    MessageBox.Show("•email Özel karakterlerle başlatılamaz.\n•email @ sembolü içermelidir. ");
                }
                else if (!isvalidateUserPhone)
                {
                    MessageBox.Show("•telefon xxx-xxx-xxxx şeklinde olmalıdır.\n•telefon Hiçbir harf içermemelidir.");
                }
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//dealer
            string userName = user_name.Text;
            string userPassword = password.Text;
            string Name = Namebox.Text;
            string userEmail = eposta.Text;
            string userPhone = phone.Text;



            user kayıt_olan_kullanıcı = new user();
            bool isvalidateUserName = kayıt_olan_kullanıcı.ValidateUserName(userName);
            bool isvalidatename = kayıt_olan_kullanıcı.IsValidName(Name);
            bool isvalidateUserPassword = kayıt_olan_kullanıcı.ValidateUserPassword(userPassword);
            bool isvaldateUserEmail = kayıt_olan_kullanıcı.ValidateUserEmail(userEmail);
            bool isvalidateUserPhone = kayıt_olan_kullanıcı.ValidateUserPhone(userPhone);


            if (isvalidateUserName && isvalidateUserPassword && isvaldateUserEmail && isvalidateUserPhone && isvalidatename)
            {
                string okunacak_dosya = @"satıcı.txt";
                string okunacak_dosya2 = @"admin.txt";
                string okunacak_dosya3 = @"müşteri.txt";
                List<user> tüm_kayıtlılar = new List<user>();
                user.Reader_kişi_bilgisi(okunacak_dosya, tüm_kayıtlılar);
                user.Reader_kişi_bilgisi(okunacak_dosya2, tüm_kayıtlılar);
                user.Reader_kişi_bilgisi(okunacak_dosya3, tüm_kayıtlılar);


                var yeniListe = tüm_kayıtlılar.Where(item => item.user_name.ToString() == userName).ToList();

                if (yeniListe.Count == 0)
                {
                    string dosya_yolu = @"satıcı.txt";
                    FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine($"Username:{userName}\nPassword:{userPassword}\nName:{Name}\nEmail:{userEmail}\nPhone:{userPhone}\n*****");
                    sw.Flush();
                    sw.Close();
                    fs.Close();



                    MessageBox.Show("Your registration has been completed successfully.");
                }
                else
                {
                    MessageBox.Show("This username is used by someone else");
                }


            }
            else
            {

                if (!isvalidateUserName)
                {
                    MessageBox.Show("• Kullanıcı adı 5 ila 20 karakterden oluşmaktadır.\n• Kullanıcı adı yalnızca nümerik veya alfabetik karakterler içerebilir.\n• Kullanıcı adının ilk karakteri alfabetik karakter olmalıdır.");
                }
                else if (!isvalidateUserPassword)
                {
                    MessageBox.Show("•şifre En az 8, en fazla 20 karakter içerir.\n•şifre En az bir rakam içerir.\n•şifre En az bir büyük harf alfabesi içerir.\n•şifre En az bir küçük harf alfabesi içerir.\n•şifre !@#$%&*-+ karakterlerinden oluşan en az bir özel karakter içerir.\n•şifre Hiçbir boşluk içermez. ");
                }
                else if (!isvalidatename)
                {
                    MessageBox.Show("•Name Büyük veya küçük harfle başlamalıdır.\n•Name Özel karakter içermemelidir.");
                }
                else if (!isvaldateUserEmail)
                {
                    MessageBox.Show("•email Özel karakterlerle başlatılamaz.\n•email @ sembolü içermelidir. ");
                }
                else if (!isvalidateUserPhone)
                {
                    MessageBox.Show("•telefon xxx-xxx-xxxx şeklinde olmalıdır.\n•telefon Hiçbir harf içermemelidir.");
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {//admin
            string userName = user_name.Text;
            string userPassword = password.Text;
            string Name = Namebox.Text;
            string userEmail = eposta.Text;
            string userPhone = phone.Text;



            user kayıt_olan_kullanıcı = new user();
            bool isvalidateUserName = kayıt_olan_kullanıcı.ValidateUserName(userName);
            bool isvalidatename = kayıt_olan_kullanıcı.IsValidName(Name);
            bool isvalidateUserPassword = kayıt_olan_kullanıcı.ValidateUserPassword(userPassword);
            bool isvaldateUserEmail = kayıt_olan_kullanıcı.ValidateUserEmail(userEmail);
            bool isvalidateUserPhone = kayıt_olan_kullanıcı.ValidateUserPhone(userPhone);


            if (isvalidateUserName && isvalidateUserPassword && isvaldateUserEmail && isvalidateUserPhone && isvalidatename)
            {
                string okunacak_dosya = @"satıcı.txt";
                string okunacak_dosya2 = @"admin.txt";
                string okunacak_dosya3 = @"müşteri.txt";
                List<user> tüm_kayıtlılar = new List<user>();
                user.Reader_kişi_bilgisi(okunacak_dosya, tüm_kayıtlılar);
                user.Reader_kişi_bilgisi(okunacak_dosya2, tüm_kayıtlılar);
                user.Reader_kişi_bilgisi(okunacak_dosya3, tüm_kayıtlılar);


                var yeniListe = tüm_kayıtlılar.Where(item => item.user_name.ToString() == userName).ToList();

                if (yeniListe.Count == 0)
                {
                    string dosya_yolu = @"admin.txt";
                    FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine($"Username:{userName}\nPassword:{userPassword}\nName:{Name}\nEmail:{userEmail}\nPhone:{userPhone}\n*****");
                    sw.Flush();
                    sw.Close();
                    fs.Close();



                    MessageBox.Show("Your registration has been completed successfully.");
                }
                else
                {
                    MessageBox.Show("This username is used by someone else");
                }


            }
            else
            {

                if (!isvalidateUserName)
                {
                    MessageBox.Show("• Kullanıcı adı 5 ila 20 karakterden oluşmaktadır.\n• Kullanıcı adı yalnızca nümerik veya alfabetik karakterler içerebilir.\n• Kullanıcı adının ilk karakteri alfabetik karakter olmalıdır.");
                }
                else if (!isvalidateUserPassword)
                {
                    MessageBox.Show("•şifre En az 8, en fazla 20 karakter içerir.\n•şifre En az bir rakam içerir.\n•şifre En az bir büyük harf alfabesi içerir.\n•şifre En az bir küçük harf alfabesi içerir.\n•şifre !@#$%&*-+ karakterlerinden oluşan en az bir özel karakter içerir.\n•şifre Hiçbir boşluk içermez. ");
                }
                else if (!isvalidatename)
                {
                    MessageBox.Show("•Name Büyük veya küçük harfle başlamalıdır.\n•Name Özel karakter içermemelidir.");
                }
                else if (!isvaldateUserEmail )
                {
                    MessageBox.Show("•email Özel karakterlerle başlatılamaz.\n•email @ sembolü içermelidir. ");
                }
                else if (!isvalidateUserPhone)
                {
                    MessageBox.Show("•telefon xxx-xxx-xxxx şeklinde olmalıdır.\n•telefon Hiçbir harf içermemelidir.");
                }

            }
        }
    }
}






