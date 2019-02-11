using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrefourEssert
{
    public interface Usager
    {
        void Avancer(Usager U);
        void Freiner(Usager U);

    }
}
