using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gra
{
    public partial class flappybird : Form
    {
        private string nickname;
        private flappybird2 gameflappy;
        public flappybird()
        {
            InitializeComponent();
        }

        private void flappybird_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Wprowadź nickname!!!");
                return;
            }
            gameflappy = new flappybird2(nickname);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
