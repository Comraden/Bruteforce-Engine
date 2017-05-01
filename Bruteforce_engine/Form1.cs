using Bruteforce_engine.AccManager;
using Bruteforce_engine.CheckerCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bruteforce_engine
{
    public partial class Form1 : Form
    {
        public Globals globals = new Globals();
        public Checker checker = new Checker();
        public AMCore acm = new AMCore("source.txt", "proxy.txt");

        public Form1()
        {
            InitializeComponent();
            AccLabelC.Text = Convert.ToString(Globals.accountsCount);
            ProxLabelC.Text = Convert.ToString(Globals.proxyCount);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checker.CreateThreads();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ErrLabelC.Text = Globals.errors.ToString();
            GoodLabelC.Text = Convert.ToString(Globals.goodAccounts);
            BadLabelC.Text = Convert.ToString(Globals.badAccounts);
            CaptLabelC.Text = Convert.ToString(Globals.captchaCount);

            string text = "";

            foreach (string acc in Globals.arrGood)
            {
                text += acc + "\r\n";
            }

            textBox3.Text = text;
            ThreLabelC.Text = Globals.threadsCount.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
