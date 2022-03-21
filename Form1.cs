using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tab_control_Uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
         {
             if(tabControl1.SelectedIndex==2)
         {
          txtBilgi.Text = "";
          txtBilgi.Text += TxtAdSoyad.Text +"\r\n";
          txtBilgi.Text += txtTelefon.Text + "\r\n";
          txtBilgi.Text += txtAdres.Text + "\r\n";
          decimal hesap = 0;
          if (nCorba.Value > 0)
          {
            hesap += nCorba.Value*12;
            txtBilgi.Text += string.Format("Çorba {0:C}",nCorba.Value * 12) + "\r\n";
           }
             txtBilgi.Text += "-----------------";
             txtBilgi.Text += string.Format("Toplam {0:C}",hesap);
}
}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
