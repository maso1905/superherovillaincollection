using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SuperheroVillainCollection
{
    public class Villain : Character // Subclass type "Villain"
    {
        public Villain(string inputName, string inputDesc, string inputSuperpower, string inputWeakness,
            string inputEnemy, string inputMission) : base(inputName, inputDesc, inputSuperpower, inputWeakness,
                inputEnemy, inputMission) // Herited constructor
        {
            type = "Villain";
        }
    }
}
