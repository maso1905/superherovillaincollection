using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SuperheroVillainCollection
{
    public class Character
    {
        public string name;
        public string describtion;
        public string superpower;
        public string weakness;
        public string enemy;
        public string mission;
        public string type;
        public Character(string inputName, string inputDesc, string inputSuperpower, 
            string inputWeakness, string inputEnemy, string inputMission) // Main class constructor 
        {
            name = inputName;
            describtion = inputDesc;
            superpower = inputSuperpower;
            weakness = inputWeakness;
            enemy = inputEnemy;
            mission = inputMission;
        }      
        public override string ToString() // Method for writing each character to console
        {
            return $"Name: {name}\nType: {type}\nDescribtion: {describtion}\nSuperpower: " +
                $"{superpower}\nWeakness: {weakness}\nEnemy: {enemy}\nMission: {mission}";
        }
    }
}
