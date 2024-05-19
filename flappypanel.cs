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
        private List<string> historiagry = new List<string>();
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
            nickname = textBox1.Text;
            flappybirdgame = new flappybird();
            flappybirdgame.GameEnded += Flappybirdgame_GameEnded;
            flappybirdgame.Show();
        }
        private void Flappybirdgame_GameEnded(int score)
        {
            historiagry.Add($"{nickname}: {score}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            flappyhistory flappyhistorygame = new flappyhistory(historiagry);
            flappyhistorygame.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nickname = textBox1.Text;
        }
    }
}
