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
    public partial class flappybird2 : Form
    {
        private object nickname;

        public flappybird2()
        {
            InitializeComponent();
        }

        public flappybird2(object nickname)
        {
            this.nickname = nickname;
        }
    }
}
