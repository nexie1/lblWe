using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public class Voiture : Vehicules
    {
        public Voiture(int pNbRoues, double pTaille, bool pAvancer, bool pReculer, string pImmatriculation, string pCouleur, string pMarque, double pPosX, double pPosY) : base(pNbRoues, pTaille, pAvancer, pReculer, pImmatriculation, pCouleur, pMarque, pPosX, pPosY)
        {

        }

    } 
}

