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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bthKøbereForside_Click(object sender, EventArgs e)
        {
            Form1 firstform = new Form1();

            firstform.Show();
            this.Hide();
        }

        private void btnKøbereBolig_Click(object sender, EventArgs e)
        {
            Form2 secondform = new Form2();
            secondform.Show();
            this.Hide();
        }

        private void btnKøbereSælgere_Click(object sender, EventArgs e)
        {
            Form3 thirdform = new Form3();

            thirdform.Show();

            this.Hide();
        }
    }
}
