using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SuperheroVillainCollection
{
    public class CollectionHandler
    {
        private List<Character> characterList = new List<Character>(); // Full character list collection
        public List<Character> getAllCharacters() // Get all characters with deserializing from json file
        {
            if (File.Exists(@"collection.json") == true)
            {
                using (StreamReader file = File.OpenText("collection.json"))
                {
                    var serializer = new JsonSerializer();
                    characterList = (List<Character>)serializer.Deserialize(file, typeof(List<Character>));
                }
            }
            return characterList;
        }
      
        public Superhero addSuperhero(Superhero character) // Add Superhero to Character list
        {
            characterList.Add(character);
            string jsonString = JsonConvert.SerializeObject(characterList, Formatting.Indented);
            File.WriteAllText("collection.json", jsonString);
            return character;
        }
        public Villain addVillain(Villain character) // Add Villain to Character list
        {
            characterList.Add(character);
            string jsonString = JsonConvert.SerializeObject(characterList, Formatting.Indented);
            File.WriteAllText("collection.json", jsonString);
            return character;
        }
        public int deleteCharacter(int id) // Delete character
        {
            characterList.RemoveAt(id);
            string jsonString = JsonConvert.SerializeObject(characterList, Formatting.Indented);
            File.WriteAllText("collection.json", jsonString);
            return id;
        }
        public void createCharacter() // Create character
        {
            Write("Name:\t");
            string inputName = ReadLine();
            Write("Background story:\t");
            string inputDesc = ReadLine();
            Write("Superpower:\t");
            string inputSuperpower = ReadLine();
            Write("Weakness:\t");
            string inputWeakness = ReadLine();
            Write("Enemy:\t");
            string inputEnemy = ReadLine();
            Write("Mission:\t");
            string inputMission = ReadLine();
            WriteLine("\nChoose character type: [1] Superhero\t [2] Villain\t");
            string str_type_choice = ReadLine();
            Int32.TryParse(str_type_choice, out int type_choice);
            if (type_choice == 1) // Creates an object via the subclass "Superhero"
            {
                Superhero newSuperhero = new Superhero(inputName, inputDesc, inputSuperpower, inputWeakness,
                inputEnemy, inputMission);
                addSuperhero(newSuperhero); // Calling class for adding/serializing to list/to json
                WriteLine("\nSuperhero created!");
                ReadKey();
            }
            else if (type_choice == 2) // Creates an object via the subclass "Villain"
            {
                Villain newVillain = new Villain(inputName, inputDesc, inputSuperpower, inputWeakness,
                inputEnemy, inputMission);
                addVillain(newVillain); // Calling class for adding/serializing to list/to json
                WriteLine("\nVillain created! Press any key for menu...");
                ReadKey();
            }
            else
            {
                WriteLine("Choose 1 or 2. Press any key to try again..."); // Error handling
            }
        }
    }
}
