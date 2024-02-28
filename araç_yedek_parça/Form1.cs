//210229040_SalihCanTuran

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using araç_yedek_parça;


namespace araç_yedek_parça
{
    public partial class Form1 : Form
    {
        public static string[] girişyapan { get; set; } = new string[2];

        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void müşteri_giriş(object sender, EventArgs e)
        {

            string userName = textBox1.Text;
            string userPassword = textBox2.Text;

            user kullanici = new user();
            bool isValidUserName = kullanici.ValidateUserName(userName);
            bool isValidUserPassword = kullanici.ValidateUserPassword(userPassword);

            if (isValidUserName && isValidUserPassword)
            {
                string kayıtlıKullanıcıDosyası = "müşteri.txt";
                List<user> kayıtlılar = new List<user>();
                user.Reader_kişi_bilgisi(kayıtlıKullanıcıDosyası, kayıtlılar);




                foreach (var item in kayıtlılar)
                {
                    if (item.user_name != userName || item.user_password != userPassword)
                    {
                        continue;

                    }

                    else if (item.user_name == userName && item.user_password == userPassword)

                    {



                        Müşterim müşteri = new Müşterim();
                        Müşterim.girişyapan = new string[] { item.user_name, item.user_password };
                        this.Hide();
                        müşteri.ShowDialog();


                        break;
                    }

                }

            }
            else
            {
                MessageBox.Show("Username or password is invalid. Please check your information or register");
            }

        }   


        private void Kayıt_butonu(object sender, EventArgs e)
        {
            Form2 yeni_kayıt=new Form2();
            this.Hide();
            yeni_kayıt.ShowDialog();
           
           
        }

   

     
       

        private void Satıcı_buton(object sender, EventArgs e)
        {
            string userName =User_Name_satıcı.Text ;
            string userPassword = User_Password_satıcı.Text;

            user kullanici = new user();
            bool isValidUserName = kullanici.ValidateUserName(userName);
            bool isValidUserPassword = kullanici.ValidateUserPassword(userPassword);

            if (isValidUserName && isValidUserPassword)
            {
                string kayıtlıKullanıcıDosyası = "satıcı.txt";
                List<user> kayıtlılar = new List<user>();
                user.Reader_kişi_bilgisi(kayıtlıKullanıcıDosyası, kayıtlılar);
                foreach (var item in kayıtlılar)
                {
                    if (item.user_name != userName || item.user_password != userPassword)
                    {
                        continue;

                    }

                    if (item.user_name == userName && item.user_password == userPassword)
                    {
                        Satıcı satıcım = new Satıcı();
                        Satıcı.girişyapan = new string[] { item.user_name, item.user_password };
                        this.Hide();
                        satıcım.ShowDialog();

                        break;
                    }

                    

                }



            }
            else
            {
                MessageBox.Show("Username or password is invalid. Please check your information or register");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void admin_buton(object sender, EventArgs e)
        {
            string userName = User_name_admin.Text;
            string userPassword = User_password_admin.Text;

            user kullanici = new user();
            bool isValidUserName = kullanici.ValidateUserName(userName);
            bool isValidUserPassword = kullanici.ValidateUserPassword(userPassword);

            if (isValidUserName && isValidUserPassword)
            {
                string kayıtlıKullanıcıDosyası = "admin.txt";
                List<user> kayıtlılar = new List<user>();
                user.Reader_kişi_bilgisi(kayıtlıKullanıcıDosyası, kayıtlılar);
                foreach (var item in kayıtlılar)
                {
                    if (item.user_name != userName || item.user_password != userPassword)
                    {
                        continue;

                    }

                    if (item.user_name == userName && item.user_password == userPassword)
                    {
                        Yönetici satıcım = new Yönetici();
                        
                        this.Hide();
                        satıcım.ShowDialog();
                    }

                    

                }
             

            }
            else
            {
                MessageBox.Show("Username or password is invalid. Please check your information or register");
            }
        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        
            

        }
    }

   
 }



class user
{
    
    

    public string[] kullanıcı = Form1.girişyapan;
    public string user_name { get; set; }
    public string user_password { get; set; }
    public string Name { get; set; }
    public string user_email { get; set; }
    public string user_phone { get; set; }

   
    public user()
    {
        
    }

 

    public static void Reader_kişi_bilgisi(string filePath, List<user> kayıtlılar)
    {
        using (StreamReader kayıtLog = new StreamReader(filePath))
        {
            while (!kayıtLog.EndOfStream == true)
            {
                user user = new user();
                user.user_name = kayıtLog.ReadLine()?.Replace("Username:", "");
                user.user_password = kayıtLog.ReadLine()?.Replace("Password:", "");
                user.Name = kayıtLog.ReadLine()?.Replace("Name:", "");
                user.user_email = kayıtLog.ReadLine()?.Replace("Email:", "");
                user.user_phone = kayıtLog.ReadLine()?.Replace("Phone:", "");

                kayıtlılar.Add(user);
                kayıtLog.ReadLine();
            }
        } 
    }


    public static void kişi_dosyası_güncelleme(string filePath, List<user> kayıt)
    {
        using (StreamWriter kayıtlıLog = new StreamWriter(filePath))
        {
            foreach (user item in kayıt)
            {
                kayıtlıLog.WriteLine($"Username:{item.user_name}");
                kayıtlıLog.WriteLine($"Password:{item.user_password}");
                kayıtlıLog.WriteLine($"Name:{item.Name}");
                kayıtlıLog.WriteLine($"email:{item.user_email}");
                kayıtlıLog.WriteLine($"Email:{item.user_phone}");
                kayıtlıLog.WriteLine("*****");
            }
        }

    }

    public bool ValidateUserName(string userName)
    {
        
        if (userName.Length < 5 || userName.Length > 20)
        {
            return false;
        }

       
        if (!Regex.IsMatch(userName, "^[a-zA-Z0-9]+$"))
        {
            return false;
        }

    
        if (!char.IsLetter(userName[0]))
        {
            return false;
        }

        return true;
    }

    public bool ValidateUserPassword(string userPassword)
    {

        if (userPassword.Length < 8 || userPassword.Length > 20)
        {
            return false;
        }

        
        if (!userPassword.Any(char.IsDigit))
        {
            return false;
        }

        
        if (!userPassword.Any(char.IsUpper))
        {
            return false;
        }

        
        if (!userPassword.Any(char.IsLower))
        {
            return false;
        }

        
        if (!userPassword.Intersect("!@#$%&*-+").Any())
        {
            return false;
        }

        
        if (userPassword.Contains(" "))
        {
            return false;
        }

        return true;
    }
    public bool IsValidName(string name)
    {
        
        if (string.IsNullOrEmpty(name) || !char.IsLetter(name[0]))
        {
            return false;
        }

        
        if (!name.All(char.IsLetterOrDigit))
        {
            return false;
        }

       
        return true;
    }


    public bool ValidateUserEmail(string userEmail)
    {
       
        if (Regex.IsMatch(userEmail, "^[^a-zA-Z0-9]"))
        {
            return false;
        }

       
        if (!userEmail.Contains("@"))
        {
            return false;
        }

        return true;
    }

    public bool ValidateUserPhone(string userPhone)
    {
       
        if (!Regex.IsMatch(userPhone, @"^\d{3}-\d{3}-\d{4}$"))
        {
            return false;
        }

    
        if (userPhone.Any(char.IsLetter))
        {
            return false;
        }

        return true;
    }
 

}


class admin:user
{
    public static void car_reader(string filePath, List<car> cars)
    {
        using (StreamReader carlog = new StreamReader(filePath))
        {
            while (!carlog.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.Marka = carlog.ReadLine()?.Replace("Brand:", "");
                cars_list.Model = carlog.ReadLine()?.Replace("Model:", "");
                cars_list.Paket = carlog.ReadLine()?.Replace("Packet:", "");
                cars_list.Yedek_parça = carlog.ReadLine()?.Replace("Spare Part:", "");
                cars_list.adet = carlog.ReadLine()?.Replace("Quantity:", "");


                cars.Add(cars_list);

                carlog.ReadLine();

            }
        }
    }

   
}

class dealer:user
{
    public static void car_reader(string filePath, List<car> cars)
    {
        using (StreamReader carlog = new StreamReader(filePath))
        {
            while (!carlog.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.Marka = carlog.ReadLine()?.Replace("Brand:", "");
                cars_list.Model = carlog.ReadLine()?.Replace("Model:", "");
                cars_list.Paket = carlog.ReadLine()?.Replace("Packet:", "");
                cars_list.Yedek_parça = carlog.ReadLine()?.Replace("Spare Part:", "");
                cars_list.adet = carlog.ReadLine()?.Replace("Quantity:", "");


                cars.Add(cars_list);

                carlog.ReadLine();

            }
        }
    }

    public static void sepet_listeleme_reader(string filePath, List<car> cars)
    {
        using (StreamReader carlist = new StreamReader(filePath))
        {
            while (!carlist.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.user_name = carlist.ReadLine()?.Replace("Username:", "");
                cars_list.Marka = carlist.ReadLine()?.Replace("selected Brand:", "");
                cars_list.Model = carlist.ReadLine()?.Replace("selected Model:", "");
                cars_list.Paket = carlist.ReadLine()?.Replace("selected Packet:", "");
                cars_list.Yedek_parça = carlist.ReadLine()?.Replace("selected Spare Part:", "");
                cars_list.adet = carlist.ReadLine()?.Replace("selected Quantity:", "");
                cars.Add(cars_list);

                carlist.ReadLine();

            }
        }
    }


    public static void sepet_listeleme_reader2(string filePath, List<car> cars)
    {
        using (StreamReader carlist = new StreamReader(filePath))
        {
            while (!carlist.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.user_name = carlist.ReadLine()?.Replace("Username:", "");
                cars_list.Marka = carlist.ReadLine()?.Replace("selected Brand:", "");
                cars_list.Model = carlist.ReadLine()?.Replace("selected Model:", "");
                cars_list.Paket = carlist.ReadLine()?.Replace("selected Packet:", "");
                cars_list.Yedek_parça = carlist.ReadLine()?.Replace("selected Spare Part:", "");
                cars_list.adet = carlist.ReadLine()?.Replace("selected Quantity:", "");
                cars_list.durum = carlist.ReadLine()?.Replace("Case:", "");

                cars.Add(cars_list);

                carlist.ReadLine();

            }
        }
    }
}

class customer : user
{
    public static void car_reader(string filePath, List<car> cars)
    {
        using (StreamReader carlog = new StreamReader(filePath))
        {
            while (!carlog.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.Marka = carlog.ReadLine()?.Replace("Brand:", "");
                cars_list.Model = carlog.ReadLine()?.Replace("Model:", "");
                cars_list.Paket = carlog.ReadLine()?.Replace("Packet:", "");
                cars_list.Yedek_parça = carlog.ReadLine()?.Replace("Spare Part:", "");
                cars_list.adet = carlog.ReadLine()?.Replace("Quantity:", "");
                

                cars.Add(cars_list);

                carlog.ReadLine();

            }
        }
    }

    public static void sepet_listeleme_reader(string filePath, List<car> cars)
    {
        using (StreamReader carlist = new StreamReader(filePath))
        {
            while (!carlist.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.user_name = carlist.ReadLine()?.Replace("Username:", "");
                cars_list.Marka = carlist.ReadLine()?.Replace("selected Brand:", "");
                cars_list.Model = carlist.ReadLine()?.Replace("selected Model:", "");
                cars_list.Paket = carlist.ReadLine()?.Replace("selected Packet:", "");
                cars_list.Yedek_parça = carlist.ReadLine()?.Replace("selected Spare Part:", "");
                cars_list.adet = carlist.ReadLine()?.Replace("selected Quantity:", "");
                cars.Add(cars_list);

                carlist.ReadLine();

            }
        }
    }


    public static void sepet_listeleme_reader2(string filePath, List<car> cars)
    {
        using (StreamReader carlist = new StreamReader(filePath))
        {
            while (!carlist.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.user_name = carlist.ReadLine()?.Replace("Username:", "");
                cars_list.Marka = carlist.ReadLine()?.Replace("selected Brand:", "");
                cars_list.Model = carlist.ReadLine()?.Replace("selected Model:", "");
                cars_list.Paket = carlist.ReadLine()?.Replace("selected Packet:", "");
                cars_list.Yedek_parça = carlist.ReadLine()?.Replace("selected Spare Part:", "");
                cars_list.adet = carlist.ReadLine()?.Replace("selected Quantity:", "");
                cars_list.durum = carlist.ReadLine()?.Replace("Case:", "");

                cars.Add(cars_list);

                carlist.ReadLine();

            }
        }
    }







}

class car : user
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Paket { get; set; }
    public string Yedek_parça { get; set; }
    public string adet { get; set; }

    public string durum {  get; set; }

    public static void sepet_güncelleme(string filePath, List<car> kayıt)
    {
        using (StreamWriter kayıtlıLog = new StreamWriter(filePath))
        {
            foreach (car item in kayıt)
            {
                kayıtlıLog.WriteLine($"Username:{item.user_name}");
                kayıtlıLog.WriteLine($"selected Brand:{item.Marka}");
                kayıtlıLog.WriteLine($"selected Model:{item.Model}");
                kayıtlıLog.WriteLine($"selected Packet:{item.Paket}");
                kayıtlıLog.WriteLine($"selected Spare Part:{item.Yedek_parça}");
                kayıtlıLog.WriteLine($"selected Quantity:{item.adet}");
                kayıtlıLog.WriteLine("*****");
            }
        }


    }



    public static void arac_güncelleme(string filePath, List<car> kayıt)
    {
        using (StreamWriter kayıtlıLog = new StreamWriter(filePath))
        {
            foreach (car item in kayıt)
            {
                kayıtlıLog.WriteLine($"Brand:{item.Marka}");
                kayıtlıLog.WriteLine($"Model:{item.Model}");
                kayıtlıLog.WriteLine($"Packet:{item.Paket}");
                kayıtlıLog.WriteLine($"Spare Part:{item.Yedek_parça}");
                kayıtlıLog.WriteLine($"Quantity:{item.adet}");
                kayıtlıLog.WriteLine("*****");
            }
        }

    }

    public static void car_reader(string filePath, List<car> cars)
    {
        using (StreamReader carlog = new StreamReader(filePath))
        {
            while (!carlog.EndOfStream == true)
            {
                car cars_list = new car();
                cars_list.Marka = carlog.ReadLine()?.Replace("Brand:", "");
                cars_list.Model = carlog.ReadLine()?.Replace("Model:", "");
                cars_list.Paket = carlog.ReadLine()?.Replace("Packet:", "");
                cars_list.Yedek_parça = carlog.ReadLine()?.Replace("Spare Part:", "");
                cars_list.adet = carlog.ReadLine()?.Replace("Quantity:", "");


                cars.Add(cars_list);

                carlog.ReadLine();

            }
        }
    }


}


