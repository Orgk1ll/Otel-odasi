using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev7
{
    public partial class Form2 : Form

    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=odev7;user=root;password=1234;SslMode=none;");


        public Form2()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            islempanel.Controls.Clear();
            f.TopLevel = false;
            islempanel.Controls.Add(f);
            f.Show();
            f.Dock = DockStyle.Fill;
            f.BringToFront();

        }
              
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            islempanel.Controls.Clear();
            f.TopLevel = false;
            islempanel.Controls.Add(f);
            f.Show();
            f.Dock = DockStyle.Fill;
            f.BringToFront();

            uyarıbox uyari = new uyarıbox();
            uyarıbox.mesaj = "DURUM";
            uyarıbox.text = "VERİLER GÜNCELLENDi";
            uyari.hataresim.Visible = false;
            uyari.onayresim.Visible = true;
            uyari.Show();
        }

        private void gunaGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
