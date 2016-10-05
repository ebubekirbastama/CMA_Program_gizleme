using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Program_gizleme
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int gizle = 0;
        private const int goster = 5;
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        int hWnd;
        public void yenile()
        {
            listBox1.Items.Clear();
            Process[] Memory = Process.GetProcesses();

            foreach (Process prc in Memory)
            {
                listBox1.Items.Add(prc.ProcessName);
            }
        }
        ListBox l = new ListBox();
        ListBox li = new ListBox();
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == metroTextBox1.Text )
                {
                    hWnd = pr.MainWindowHandle.ToInt32();
                    l.Items.Add(hWnd);
                    li.Items.Add(metroTextBox1.Text);
                    ShowWindow(hWnd, gizle);
                }
            }
            yenile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] Memory = Process.GetProcesses();

            foreach (Process prc in Memory)
            {
                listBox1.Items.Add(prc.ProcessName);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            metroTextBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == metroTextBox1.Text)
                {
                    pr.Kill();
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == metroTextBox1.Text)
                {
                    for (int i = 0; i < li.Items.Count; i++)
                    {
                        if (metroTextBox1.Text==li.Items[i].ToString())
                        {
                            int dfr = int.Parse(l.Items[i].ToString());
                            ShowWindow(dfr, goster);
                        }
                  
                    }
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            iletisim il = new iletisim();
            il.ShowDialog();
        }
    }
}
