using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3a_klakip
{
    public partial class Form1 : Form
    {
        private CalcIP calcip = new CalcIP();
        public Form1()
        {
            InitializeComponent();
            for( int i=0; i<=32; i++)
            {
                comboBox1.Items.Add(calcip.ipToDec(calcip.maski[i]));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
