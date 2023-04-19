using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace stamina
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer player1 = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        int taq_jup = 0, minut = 0, sekund = 0;
        string sanlar = "12 21 23 45 5 45 4 2 5 4 3 2 1 1";
        string qisqa = "lala jaz guz qis bala men sen ata apa aje baba aga suw nan alma qabaq gul musa kel ket ";
        string uzin = "otarbay perdebay jiyemurat atamurat mexanizatsiya gidrostanciya yadro antarktida qosimov kalashnikov salamat ";
        private void waqit_Tick(object sender, EventArgs e)
        {
            if(sekund == 59)
            {
                minut++;
                sekund = 0;
            }
            else
            {
                sekund++;
            }
            if (sekund == 10)
                label1.Text = "0" + minut + ":0" + sekund;
            else
                label1.Text = "0" + minut + ":" + sekund;
        }

        private void sanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bir.Text = sanlar;
            eki.Text = "";
            label1.Text = "00:00";
            sekund =0;
            minut=0;
        }

        private void uzinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bir.Text = uzin;
            eki.Text = "";
            label1.Text = "00:00";
            sekund = 0;
            minut = 0;
        }

        private void qisqaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bir.Text = qisqa;
            eki.Text = "";
            label1.Text = "00:00";
            sekund = 0;
            minut = 0;
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (baslawToolStripMenuItem.Text == "Baslaw" && e.KeyChar == ' ')
            {
                player.URL = "fon.Mp3";
                bir.Text = sanlar;
                eki.Text = "";
                waqit.Start();
                baslawToolStripMenuItem.Text = "Toqtatiw";

            }
            else if (e.KeyChar == bir.Text[0] && bir.Text != "")
            {
                bir.Text = bir.Text.Substring(1);
                eki.Text += e.KeyChar;
                if (eki.Text.Length > 15)
                    eki.Text = eki.Text.Substring(eki.Text.Length - 15);
            }
            else if (bir.Text == " ")
            {
                button1.Enabled = false;
                waqit.Stop();
            }
            else
            {
                player1.URL = "kl.Mp3";
            }
        }
    }
}
