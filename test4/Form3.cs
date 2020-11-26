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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 firstform = new Form1();

            firstform.Show();
            this.Hide();


        }

        private void btnSælgereBolig_Click(object sender, EventArgs e)
        {
            Form2 secondform = new Form2();
            secondform.Show();
            this.Hide();
        }

        private void btnSælgereKøbere_Click(object sender, EventArgs e)
        {
            Form4 fourthform = new Form4();
            fourthform.Show();
            this.Hide();
        }
    }
}
