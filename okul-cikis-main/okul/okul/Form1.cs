using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gunAd=comboBox1.Text;
            int gunNo=comboBox1.SelectedIndex;
            gunNo++;
      
            if (gunNo == 7 || gunNo == 6)
            {
                label2.Text = "Tatil";
            }
            else if(gunNo==5 || gunNo == 4)
            {
                label2.Text = "Okul çıkış saati 15.50 dir.";
            }
            else
            {
                label2.Text = "Okul çıkış saati 16.40 dir.";
            }
        }
    }
}
