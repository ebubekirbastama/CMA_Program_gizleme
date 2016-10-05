using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Program_gizleme
{
    public partial class Karsılama : MetroForm
    {
        public Karsılama()
        {
            InitializeComponent();
        }
        int sayi;
        private void Karsılama_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            webBrowser2.Hide();
            MessageBox.Show("Cumhuriyet Muhafız Alayı gizleme programına hoş geldiniz.","Cumhuriyet Muhafız Alayı & İslam");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi++;
            if (sayi == 15)
            {
                Hide();          
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }
    }
}
