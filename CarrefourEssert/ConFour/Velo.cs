using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public class Velo : Vehicule
    {
        public Velo(int pNbRoues, double pTaille, string pImmatriculation, string pCouleur, string pMarque, double pPosX, double pPosY) : base(pNbRoues, pTaille, pImmatriculation, pCouleur, pMarque, pPosX, pPosY)
        {

        }
        
        public override void Freiner(Vehicule v)
        {

        }
        public override void Avancer(Vehicule v)
        {

        }
    }
}
