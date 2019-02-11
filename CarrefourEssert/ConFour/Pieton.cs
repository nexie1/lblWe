using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarrefourEssert
{
    public class Pieton : PassagePieton
    {
        public Pieton()
        {

        }
        public void Freiner(PictureBox c)
        {
            int x = 0;

            c.Left += x;
        }
        public void Avancer(PictureBox c)
        {
            int x = 0;
            x -= 1;
            c.Left += x;
        }
    }
}
