using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gra
{
    public partial class PanelSaper : Form
    {
        private Form2 gameForm;
        private string playerName;
        private int gridSize;
        private int totalMines;
        private List<string> gameHistory = new List<string>();
        private string historyFilePath = "SaperHistory.txt";

        public PanelSaper()
        {
            InitializeComponent();
            if (File.Exists(historyFilePath))
            {
                gameHistory = File.ReadAllLines(historyFilePath).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać poziom trudności.");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Proszę podać nazwę użytkownika.");
                return;
            }

            string selectedDifficulty = (string)comboBox1.SelectedItem;
            gameForm = new Form2(gridSize, totalMines, playerName, selectedDifficulty, this);
            gameForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedDifficulty = (string)comboBox.SelectedItem;

            switch (selectedDifficulty)
            {
                case "Łatwy":
                    gridSize = 5;
                    totalMines = 3;
                    break;
                case "Średni":
                    gridSize = 10;
                    totalMines = 15;
                    break;
                case "Trudny":
                    gridSize = 15;
                    totalMines = 35;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            playerName = textBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaperHistoryForm saperHistoryForm = new SaperHistoryForm(gameHistory);
            saperHistoryForm.Show();
        }

        public void AddGameToHistory(string gameResult)
        {
            gameHistory.Add(gameResult);
            File.WriteAllLines(historyFilePath, gameHistory);
        }
    }
}
