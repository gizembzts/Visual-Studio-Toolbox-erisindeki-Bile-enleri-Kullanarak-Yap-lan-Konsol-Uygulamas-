using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselprogramlamaproje
{
    public partial class Form1 : Form
    {        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            // formda girilecek değerleri tutmak için değişkenler tanımlandı
            string adSoyad, email, telefonNo, dogumTarihi, cinsiyet, sehir;
            List<String> hobiler=new List<string>();

            // form elemanlarına girilen değerler değişkenlere atandı
            adSoyad = txtIsım.Text;
            email = txtEmail.Text;
            telefonNo = txtTelefon.Text;
            dogumTarihi = dateTimePicker1.Text;

            if (rButtonErkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else if(rButtonKadin.Checked==true)           
            {
                cinsiyet = "Kadın";
            }
            else
            {
                cinsiyet = " ";
            }

            sehir = comboBoxSehirler.SelectedItem.ToString();

            if (checkBox1.Checked == true)
            {
                hobiler.Add(checkBox1.Text);
            }
            if (checkBox2.Checked == true)                
            {
                hobiler.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                hobiler.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                hobiler.Add(checkBox4.Text);
            }

            string hobies = "";

            foreach(var hobi in hobiler)
            {
                hobies = hobies + "\n" + hobi.ToString();
            }
                      
            // Girilen kullanıcının isim ve telefon bilgisi listBox'a yazdırıldı
            listBox.Items.Add(adSoyad + " - " + telefonNo);

            // Form elemanları temizlendi
            txtIsım.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            rButtonErkek.Checked = false;
            rButtonKadin.Checked = false;           
            comboBoxSehirler.SelectedItem = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            // Girilen veriler messageBox ile gösterildi

            MessageBox.Show("İsim: " + adSoyad + "\nEmail: " + email +
                "\nTelefon: "+ telefonNo + "\nSehir: " + sehir + "\nCinsiyet: " + 
                cinsiyet + "\nDogum Tarihi:  " + dogumTarihi +
                "\nHobiler: " +hobies);
        }

        int dakika = 0, saniye = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Kronometre için timer oluşturuldu.             
            // Her 60 saniyede dakika değeri 1 arttırılıyor.
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            label9.Text = String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start(); // Form yüklendiğinde timer başlatılıyor. Interval = 1000 (Her 1 saniyede tekrar) 

            // picturBox'a resim url'si girilerek görsel atanıyor
            pictureBox1.ImageLocation = "https://cdn-icons-png.flaticon.com/512/456/456212.png";

            // ComboBox'a şehir isimleri eklenmekte
            comboBoxSehirler.Items.Add("İstanbul");
            comboBoxSehirler.Items.Add("Ankara");
            comboBoxSehirler.Items.Add("Kocaeli");
            comboBoxSehirler.Items.Add("Bursa");
            comboBoxSehirler.Items.Add("İzmir");
            comboBoxSehirler.Items.Add("Tokat");
            comboBoxSehirler.Items.Add("Mersin");
            comboBoxSehirler.Items.Add("Malatya");
            comboBoxSehirler.Items.Add("Burdur");
            comboBoxSehirler.Items.Add("Bilecik");
            comboBoxSehirler.Items.Add("Manisa");
            comboBoxSehirler.Items.Add("Afyon");

        }
    }
}
