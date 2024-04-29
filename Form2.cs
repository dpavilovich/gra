using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    public partial class Form2 : Form
    {
        private int gridSize = 15;
        private Button[,] buttons;
        private bool[,] mines;
        private bool[,] clicked;
        private int totalMines = 35; // Zwiększono liczbę min do 35
        private int totalClicked = 0;

        public Form2()
        {
            InitializeComponent();
            buttons = new Button[gridSize, gridSize];
            mines = new bool[gridSize, gridSize];
            clicked = new bool[gridSize, gridSize];
            this.AutoScroll = true; // Włącz przewijanie
            this.AutoScrollMinSize = new Size(gridSize * 20, gridSize * 20); // Ustaw minimalny rozmiar obszaru przewijania
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(i * 20, j * 20);
                    buttons[i, j].Size = new Size(20, 20);
                    buttons[i, j].Click += new EventHandler(Button_Click);
                    buttons[i, j].MouseUp += new MouseEventHandler(Button_RightClick);
                    this.Controls.Add(buttons[i, j]);
                }
            }

            Random rand = new Random();
            for (int i = 0; i < totalMines; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(gridSize);
                    y = rand.Next(gridSize);
                } while (mines[x, y]);
                mines[x, y] = true;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x = clickedButton.Location.X / 20;
            int y = clickedButton.Location.Y / 20;

            if (mines[x, y])
            {
                MessageBox.Show("Przegrałeś!");
                this.Close();
            }
            else
            {
                RevealButton(x, y);
                if (totalClicked == gridSize * gridSize - totalMines)
                {
                    MessageBox.Show("Wygrałeś!");
                    this.Close();
                }
            }
        }

        private void Button_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button clickedButton = (Button)sender;
                if (clickedButton.BackColor == Color.Red)
                {
                    clickedButton.BackColor = default(Color); // Odoznaczanie prawym przyciskiem
                }
                else
                {
                    clickedButton.BackColor = Color.Red; // Oznaczanie prawym przyciskiem
                }
            }
        }

        private void RevealButton(int x, int y)
        {
            if (x < 0 || y < 0 || x >= gridSize || y >= gridSize || clicked[x, y])
                return;

            clicked[x, y] = true;
            totalClicked++;

            int surroundingMines = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int nx = x + i;
                    int ny = y + j;
                    if (nx >= 0 && nx < gridSize && ny >= 0 && ny < gridSize && mines[nx, ny])
                    {
                        surroundingMines++;
                    }
                }
            }

            buttons[x, y].Text = surroundingMines.ToString();
            buttons[x, y].Enabled = false;

            if (surroundingMines == 0)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        RevealButton(x + i, y + j);
                    }
                }
            }
        }
    }
}
