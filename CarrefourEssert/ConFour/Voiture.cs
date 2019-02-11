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
    public class Voiture : Vehicule
    {



        public Voiture(int pNbRoues, double pTaille, string pImmatriculation, string pCouleur, string pMarque, double pPosX, double pPosY) : base(pNbRoues, pTaille, pImmatriculation, pCouleur, pMarque, pPosX, pPosY)
        {

        }

        public override void Freiner(PictureBox c)
        {
            int y = 0;
            
            c.Top += y;
        }
        public override void Avancer(PictureBox c)
        {
            int y = 0;
            y -= 1;
            c.Top += y;
        }
    } 
}

