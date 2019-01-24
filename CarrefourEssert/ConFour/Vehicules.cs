using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    abstract public class Vehicules
    {
        private int _roues;
        private double _taille;

        public int Roues { get => _roues; set => _roues = value; }
        public double Taille { get => _taille; set => _taille = value; }


    }
}
