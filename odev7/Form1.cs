using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace odev7
{
    public partial class Form1 : Form
    {

        public List<String> butonlist = new List<String>();
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=odev7;user=root;password=1234;SslMode=none;");
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public int sayac = 0;

        private void gunaGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public String dolu;
        public String cinsiyet;

        
        public void Form1_Load(object sender, EventArgs e)
        {
            kaydetbtn.Enabled = false;

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    String dolu = "";
                    String cinsiyet = "";
                    sayac++;
                    baglanti.Open();
                    MySqlCommand kayit = new MySqlCommand("SELECT dolu,cinsiyet FROM rezerve WHERE (rezerve_id = @id)", baglanti);
                    kayit.Parameters.AddWithValue("@id", sayac);
                    MySqlDataReader dr = kayit.ExecuteReader();
                    if (dr.Read())
                    {
                        dolu = dr["dolu"].ToString();
                        cinsiyet = dr["cinsiyet"].ToString();

                    }

                    baglanti.Close();

                    Button btn = new Button();

                    btn.Text = sayac.ToString();
                    btn.Name = sayac.ToString();
                    btn.Size = new Size(50, 50);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(55 * i, 55 * j);
                    ; String deger = sayac.ToString();
                    butonlist.Add(deger);
                    panel.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click);



                    if ((dolu.Equals("1")) && (cinsiyet.Equals("1")))
                    {
                        btn.BackColor = Color.Blue;
                        btn.ForeColor = Color.White;
                    }
                    else if ((dolu.Equals("1")) && (cinsiyet.Equals("0")))
                    {
                        btn.BackColor = Color.HotPink;
                        btn.ForeColor = Color.White;
                    }

                }

            }
            

        }
        
        public  String oda;
        public int a = 0;




        public String isim, soyisim;
        private void kaydetbtn_Click(object sender, EventArgs e)
        {

            Form2 f2 =new Form2();
            f2.guna2Button1.Refresh();



            sayac = 0;
            isim = ad.Text;
            soyisim = soyad.Text;
            cinsiyet = cinsiyetbox.SelectedIndex.ToString();



            baglanti.Open();
            MySqlCommand kayit = new MySqlCommand("UPDATE rezerve SET ad=@isim,soyad=@soyisim,dolu=@yer,cinsiyet=@cins  WHERE (rezerve_id=@rezid)", baglanti);
            kayit.Parameters.AddWithValue("@rezid", oda);
            kayit.Parameters.AddWithValue("@isim", isim);
            kayit.Parameters.AddWithValue("@soyisim", soyisim);
            kayit.Parameters.AddWithValue("@yer", 1.ToString());
            kayit.Parameters.AddWithValue("@cins", cinsiyet);
            kayit.ExecuteNonQuery();
            baglanti.Close();
           

            



            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    String dolu = "";
                    String cinsiyet = "";
                    sayac++;
                    baglanti.Open();
                    MySqlCommand kayit1 = new MySqlCommand("SELECT dolu,cinsiyet FROM rezerve WHERE (rezerve_id = @id)", baglanti);
                    kayit1.Parameters.AddWithValue("@id", sayac);
                    MySqlDataReader dr = kayit1.ExecuteReader();
                    if (dr.Read())
                    {
                        dolu = dr["dolu"].ToString();
                        cinsiyet = dr["cinsiyet"].ToString();

                    }

                    baglanti.Close();

                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    btn.Name = sayac.ToString();
                    btn.BackColor = Color.White;
                    btn.Size = new Size(50, 50);

                    btn.Location = new Point(55 * i, 55 * j);
                    ; String deger = sayac.ToString();
                    butonlist.Add(deger);
                    panel.Controls.Add(btn);



                    if ((dolu.Equals("1")) && (cinsiyet.Equals("1")))
                    {
                        btn.BackColor = Color.Blue;
                        btn.ForeColor = Color.White;
                    }
                    else if ((dolu.Equals("1")) && (cinsiyet.Equals("0")))
                    {
                        btn.BackColor = Color.HotPink;
                        btn.ForeColor = Color.White;
                    }
                    

                }

            }


            uyarıbox uyari = new uyarıbox();
            uyarıbox.mesaj = "DURUM";
            uyarıbox.text = "KAYIT TAMAMLANDI\nLÜTFEN YENİLE BUTONUNA TIKLAYIN";
            uyari.hataresim.Visible = false;
            uyari.onayresim.Visible = true;
            uyari.Show();


        }

        private void odabox_SelectedValueChanged(object sender, EventArgs e)
        {
            cinsiyet = cinsiyetbox.SelectedIndex.ToString();
        }

        private void cinsiyetlbl_Click(object sender, EventArgs e)
        {

        }

        public void btn_Click(object sender, EventArgs e)

        {

            Button btn = (Button)sender;
            if (btn.BackColor == Color.White && a<1 )
            {
                kaydetbtn.Enabled = true;

                btn.BackColor = Color.Green;
                oda = btn.Text;
                a++;

            }
            else if (btn.BackColor == Color.Blue)
            {
                kaydetbtn.Enabled = false;
                baglanti.Open();
                MySqlCommand kayit2 = new MySqlCommand("SELECT ad,soyad FROM rezerve WHERE (rezerve_id = @id)", baglanti);
                kayit2.Parameters.AddWithValue("@id", btn.Text);
                MySqlDataReader dr = kayit2.ExecuteReader();
                if (dr.Read())
                {
                    ad.Text = dr["ad"].ToString();
                    soyad.Text= dr["soyad"].ToString();

                }
                baglanti.Close();

            }
            else if (btn.BackColor == Color.HotPink)
            {
                kaydetbtn.Enabled = false;
                baglanti.Open();
                MySqlCommand kayit3 = new MySqlCommand("SELECT ad,soyad FROM rezerve WHERE (rezerve_id = @id)", baglanti);
                kayit3.Parameters.AddWithValue("@id", btn.Text);
                MySqlDataReader dr = kayit3.ExecuteReader();
                if (dr.Read())
                {
                    ad.Text = dr["ad"].ToString();
                    soyad.Text = dr["soyad"].ToString();

                }
                baglanti.Close();
                
            }
            else if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.White;
                a = 0;
            }
            





        }

    }




}


