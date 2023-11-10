using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chien : Animal
    {
        public Chien(string name):base(name)
        {
        }

        public override string Crier()
        {
            switch (State)
            {
                case AnimalState.Hungry:
                    return "Ouaf (j'ai faim)";
                case AnimalState.Full:
                    return "Ouaf (viens on joue ?)";
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
