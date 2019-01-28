using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public class Route : Map
    {
        private string _type;
        private int _nbVoie;
        private string _sens;

        public string Type { get => _type; set => _type = value; }
        public int NbVoie { get => _nbVoie; set => _nbVoie = value; }
        public string Sens { get => _sens; set => _sens = value; }

        public Route(string pSens, string pType, int pNbVoie, double pPosX, double pPosY) : base(pPosX, pPosY)
        {
            this.Sens = pSens;
            this.Type = pType;
            this.NbVoie = pNbVoie;
        }
    }
}
