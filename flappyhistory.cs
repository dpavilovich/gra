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
    public partial class flappyhistory : Form
    {
        public flappyhistory(List<string> historia)
        {
            InitializeComponent();
            ListBox listBox = new ListBox();
            listBox.Items.AddRange(historia.ToArray());
            listBox.Size = new Size(this.Width * 2, this.Height * 2);
            this.Controls.Add(listBox);
        }
    }
}
