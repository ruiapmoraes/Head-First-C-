using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF.Cap2.Pag64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // isto é um comentário
            string name = "Quentim";
            int x = 3;
            x = x  *17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é " + name
                        + "\nx is " + x
                        + "\nd is " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x ==10)
            {
                MessageBox.Show("X deve ser 10");
            }
            else
            {
                MessageBox.Show("X não é 10");
            }
        }
    }
}
