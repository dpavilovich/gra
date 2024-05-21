using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    public partial class Form2 : Form
    {
        private int gridSize;
        private Button[,] buttons;
        private bool[,] mines;
        private bool[,] clicked;
        private bool cheatMode;
        private int totalMines;
        private int totalClicked;
        private string playerName;
        private string difficultyLevel;
        private Stopwatch stopwatch;
        private PanelSaper panelSaper;
        private Timer timer;

        public Form2(int gridSize, int totalMines, string playerName, string difficultyLevel, PanelSaper panelSaper)
        {
            InitializeComponent();
            this.gridSize = gridSize;
            this.totalMines = totalMines;
            this.playerName = playerName;
            this.difficultyLevel = difficultyLevel;
            this.panelSaper = panelSaper;
            buttons = new Button[gridSize, gridSize];
            mines = new bool[gridSize, gridSize];
            clicked = new bool[gridSize, gridSize];
            cheatMode = false; 
            stopwatch = new Stopwatch();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(Timer_Tick);
            this.Load += new EventHandler(Form2_Load);
            this.KeyDown += new KeyEventHandler(Form2_KeyDown); 
            this.KeyPreview = true; 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Czas gry: {stopwatch.Elapsed.TotalSeconds:F2} sekund";
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
            stopwatch.Start();
            timer.Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x = clickedButton.Location.X / 20;
            int y = clickedButton.Location.Y / 20;

            if (mines[x, y])
            {
                timer.Stop();
                stopwatch.Stop();
                MessageBox.Show("Trafiłeś na minę, przegrałeś!");
                this.Close();
            }
            else
            {
                RevealButton(x, y);
                if (totalClicked == gridSize * gridSize - totalMines)
                {
                    timer.Stop();
                    stopwatch.Stop();
                    string gameResult = $"Nazwa użytkownika: {playerName}, Poziom trudności: {difficultyLevel}, Czas: {stopwatch.Elapsed.TotalSeconds} sekund";
                    panelSaper.AddGameToHistory(gameResult);
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
                    clickedButton.BackColor = default(Color);
                }
                else
                {
                    clickedButton.BackColor = Color.Red;
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T) 
            {
                cheatMode = !cheatMode;
                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (mines[i, j])
                        {
                            buttons[i, j].BackColor = cheatMode ? Color.Red : default(Color);
                        }
                    }
                }
            }
        }
    }
}
