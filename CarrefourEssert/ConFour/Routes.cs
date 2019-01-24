using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public class Routes : Map
    {
        private string _type;
        private int _nbVoie;

        public string Type { get => _type; set => _type = value; }
        public int NbVoie { get => _nbVoie; set => _nbVoie = value; }

        public Routes(string pType, int pNbVoie, double pPosX, double pPosY) : base(pPosX, pPosY)
        {
            this.Type = pType;
            this.NbVoie = pNbVoie;
        }
    }
}
