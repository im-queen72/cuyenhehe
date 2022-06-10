using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTPTUD
{
    public partial class Form2 : Form
    {
        int i, n,T;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(TXTN.Text);
            T = 0;
            i = 1;
            do
            {
                if (i % 2 == 0) T = T + i;
                i += 1;

            }
            while (i <= n);
            lblKQ.Text = "Kết quả tính theo Do While là: " + Convert.ToString(T);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(TXTN.Text);
            T = 0;
            i = 1;
            while (i<=n)
            {
                if (i % 2 == 0) T = T + i;
                i = i + 1;

            }
            lblKQ.Text = "Kết quả tính theo While là: " + Convert.ToString(T);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(TXTN.Text);
            T = 0;
            for (i=1;i<=n;i++)
            {
                if (i % 2 == 0) T = T + i; 
                
            }
            lblKQ.Text="Kết quả tính theo For là: " + Convert.ToString(T);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
