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
    public partial class flappypanel : Form
    {
        private flappybird flappybirdgame;
        private string nickname;
        private List<string> gameHistory = new List<string>();
        public flappypanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Proszę podać nazwę użytkownika.");
                return;
            }
            flappybirdgame = new flappybird();
            flappybirdgame.Show();
        }
    }
}
