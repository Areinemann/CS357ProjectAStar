using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS357Project
{
    public partial class Form1 : Form
    {
        NFA ogNFA = new NFA();

        public Form1()
        {
            InitializeComponent();
        }

        private void butNextStage_Click(object sender, EventArgs e)
        {
            int iFail       = 0;
            string states   = tbStates.Text.ToString();
            string alfa     = tbAlfa.Text.ToString();

            if (states.Length == 0)
            {
                iFail++;
            }

            if (alfa.Length == 0)
            {
                iFail++;
            }

            if (iFail == 0)
            {
                ogNFA.initStates(states);
                ogNFA.initLanguage(alfa);
            }

        }
    }
}
