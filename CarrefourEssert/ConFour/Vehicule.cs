/*Programme : Confour
 * Description : Simulation de trafic
 * Nom : Serigado, Fernandes, Cotture
 * Date : 21 / 01 / 19
 * Version : 1.0.0
 * */
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
     public abstract class Vehicule : Map
    {
        #region Attributs
        private string _typeVehicule;
        private int _nbRoues;
        private double _taille;
        private string _immatriculation;
        private string _couleur;
        private string _marque;
        #endregion

        #region Propriété
        public int NbRoues { get => _nbRoues; set => _nbRoues = value; }
        public double Taille { get => _taille; set => _taille = value; }
        public string Immatriculation { get => _immatriculation; set => _immatriculation = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public string Marque { get => _marque; set => _marque = value; }
        public string TypeVehicule { get => _typeVehicule; set => _typeVehicule = value; }
        #endregion

        #region ctor
        public Vehicule(int pNbRoues, double pTaille, string pImmatriculation, string pCouleur, string pMarque, double pPosX, double pPosY ) :base(pPosX, pPosY)
        {
            this.NbRoues = pNbRoues;
            this.Taille = pTaille;
            this.Immatriculation = pImmatriculation;
            this.Couleur = pCouleur;
            this.Marque = pMarque;
        }
        #endregion

        public abstract void Avancer(PictureBox c);
        public abstract void Freiner(PictureBox c);
    }
}
