using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrefourEssert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCreateScene_Click(object sender, EventArgs e)
        {
            Feu feu = new Feu("rouge","piéton",43,45);
        }
    }
}
