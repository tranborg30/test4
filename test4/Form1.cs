using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            Form2 secondform = new Form2();

            secondform.Show();

            this.Hide();
        }

        private void btnSælger_Click(object sender, EventArgs e)
        {
            Form3 thirdform = new Form3();

            thirdform.Show();

            this.Hide();
        }

        private void btnKøber_Click(object sender, EventArgs e)
        {
            Form4 fourthform = new Form4();
            fourthform.Show();

            this.Hide();
        }
    }
}
