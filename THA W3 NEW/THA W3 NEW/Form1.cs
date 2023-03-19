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

namespace THA_W3_NEW
{
    public partial class mainwindowform : Form
    {
        public static mainwindowform instance;
        public string a= "_";
        public string b= "_";
        public int o = 0;
        public Panel pnl;

        public mainwindowform()
        {
            InitializeComponent();
            instance = this;
            pnl = panelform1;
            button1.Enabled= false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (namatext.Text == "" || artistext.Text == "")
            {
                MessageBox.Show("Nama/Artis Tidak boleh empty");
            }
            else
            {
                a = namatext.Text;
                b = artistext.Text;
                secondwindowform.instance.lab1.Text = "“Hi, my name is " + a + " and my favorite artist is " + b + "”";
            }
        }

        private void openformbtn_Click(object sender, EventArgs e)
        {
            secondwindowform baru = new secondwindowform();
            baru.Show();
            o++;
            if (checkboxtrue.Checked == true && o > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            secondwindowform.instance.lab1.Text = "“Hi, my name is " + a + " and my favorite artist is "+ b + "”";
        }

        private void namatext_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkboxtrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxtrue.Checked == true && o>0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
