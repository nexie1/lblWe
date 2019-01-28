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
        private string _typeFeu;
        public string Couleur { get => _couleur; set => _couleur = value; }
        public string TypeFeu { get => _typeFeu; set => _typeFeu = value; }

        public Feu(string pCouleur, string pTypeFeu, double pPosX, double pPosY) : base (pPosX, pPosY)
        {
            this.Couleur = pCouleur;
            this.TypeFeu = pTypeFeu;
        }

    }
}
