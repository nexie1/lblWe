using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public abstract class Map
    {
        private double _posX;
        private double _posY;

        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }

        public Map(double pPosX, double pPosY)
        {
            this.PosX = pPosX;
            this.PosY = pPosY;
        }
    }
}
