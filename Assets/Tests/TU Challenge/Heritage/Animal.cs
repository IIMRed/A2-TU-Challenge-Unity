using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace TU_Challenge.Heritage
{
    public abstract class Animal
    {
        public enum AnimalState { Hungry, Full,
            AteBubulle
        }

        public event Action OnDie;
        public event Action<int> OnFed; // exemple d'un event avec une information donnée 

        // Exemple avec une func
        //Func<int,int , bool> _coucou;

        public bool IsAlive { get; private set; }
        public int Pattes { get; protected set; }
        public string Name { get; private set; }
        public AnimalState State { get; protected set; }

        public Animal(string name)
        {
            Debug.Log("Creation !");

            IsAlive = true;
            Pattes = 0;
            Name = name;
            State = AnimalState.Hungry;
        }

        public abstract string Crier();

        public void Die()
        {
            IsAlive = false;

            //if(OnDie != null) OnDie.Invoke();
            
            OnDie?.Invoke();
        }

        public void Feed()
        {
            State = AnimalState.Full;
            OnFed?.Invoke(12);
        }

        public virtual void EnterAnimalerie(Animalerie animalerie)
        {



        }
    }
}
