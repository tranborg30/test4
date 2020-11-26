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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBoligRorside_Click(object sender, EventArgs e)
        {
            Form1 firstform = new Form1();

            firstform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 thirdform = new Form3();

            thirdform.Show();

            this.Hide();

        }

        private void btnBoligKøbere_Click(object sender, EventArgs e)
        {
            Form4 fourthform = new Form4();
            fourthform.Show();
            this.Hide();
        }
    }
}
