using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {

        public Chat(string name) : base(name)
        {

            Pattes = 4;

        }

        public override string Crier()
        {
            switch (State)
            {
                case AnimalState.Hungry:
                    return "Miaou (j'ai faim)";
                case AnimalState.Full:
                    return "Miaou (c'est bon laisse moi tranquille humain)";
                case AnimalState.AteBubulle:
                    return "Miaou (Le poisson etait bon)";
                default:
                    return "";
            }

        }

        public override void EnterAnimalerie(Animalerie animalerie)
        {
            //base.EnterAnimalerie(animalerie);

            foreach(Animal el in animalerie.Zoo)
            {
                Chasse(el);
            }

            animalerie.OnAddAnimal += Chasse;
        }

        // DRY
        // Don't Repeat Yourself
        private void Chasse(Animal obj)
        {
            if (obj is Poisson)
            {
                obj.Die();
                EatBubulle();
                return;
            }
        }

        private void EatBubulle()
        {
            State = AnimalState.AteBubulle;
        }
    }
}
