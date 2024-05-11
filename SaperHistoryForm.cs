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
    public partial class SaperHistoryForm : Form
    {
        public SaperHistoryForm(List<string> gameHistory)
        {
            InitializeComponent();
            ListBox listBox = new ListBox();
            listBox.DataSource = gameHistory;
            listBox.Size = new Size(this.Width * 2, this.Height * 2);
            this.Controls.Add(listBox);
        }
    }
}
