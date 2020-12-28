using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SuperheroVillainCollection
{
    public class Superhero : Character // Subclass type "Superhero"
    {
        public Superhero(string inputName, string inputDesc, string inputSuperpower, string inputWeakness, 
            string inputEnemy, string inputMission) : base(inputName, inputDesc, inputSuperpower, inputWeakness, 
                inputEnemy, inputMission) // Constructor base in main class 'Character'
        {
            type = "Superhero";
        }
    }
}
