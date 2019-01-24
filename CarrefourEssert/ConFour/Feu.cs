using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public class Feu : Map
    {
        private string _couleur;
        public string Couleur { get => _couleur; set => _couleur = value; }


        public Feu(string pCouleur, double pPosX, double pPosY) : base (pPosX, pPosY)
        {
            this.Couleur = pCouleur;
        }

    }
}
