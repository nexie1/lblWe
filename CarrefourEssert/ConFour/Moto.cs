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
    public class Moto : Vehicule
    {
        public Moto(int pNbRoues, double pTaille, string pImmatriculation, string pCouleur, string pMarque, double pPosX, double pPosY) : base(pNbRoues, pTaille, pImmatriculation, pCouleur, pMarque, pPosX, pPosY)
        {

        }

        public override void Freiner(PictureBox c)
        {

        }
        public override void Avancer(PictureBox c)
        {
            int vitesse = 0;

            vitesse += 1;
        }
    }
}

