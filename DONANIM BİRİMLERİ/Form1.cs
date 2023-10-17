using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DONANIM_BİRİMLERİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonturolet_Click(object sender, EventArgs e)
        {
            string secim;
            secim = listBox1.SelectedItems.ToString();
            if(secim == "mause"|| secim== "klavye" || secim == "kamera" || secim == "tarayıcı")
            {
                MessageBox.Show("bu parça , giriş birimidir.");
            }
            if (secim == "yazıcı" || secim == "hoparlör" || secim =="projeksiyon")
            {
                MessageBox.Show("bu parça,çıkış birimdir.");
            }
        }
    }
}
