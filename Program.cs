using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Encodings;
namespace SuperheroVillainCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            CollectionHandler collection = new CollectionHandler();
            int i;
            ForegroundColor = ConsoleColor.Green;
            string title = @"
            ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗    ████████╗ ██████╗     ████████╗██╗  ██╗███████╗    
            ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝    ╚══██╔══╝██╔═══██╗    ╚══██╔══╝██║  ██║██╔════╝    
            ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗         ██║   ██║   ██║       ██║   ███████║█████╗      
            ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝         ██║   ██║   ██║       ██║   ██╔══██║██╔══╝      
            ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗       ██║   ╚██████╔╝       ██║   ██║  ██║███████╗    
             ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝       ╚═╝    ╚═════╝        ╚═╝   ╚═╝  ╚═╝╚══════╝    
            ███████╗██╗   ██╗██████╗ ███████╗██████╗ ██╗  ██╗███████╗██████╗  ██████╗     ██╗                                    
            ██╔════╝██║   ██║██╔══██╗██╔════╝██╔══██╗██║  ██║██╔════╝██╔══██╗██╔═══██╗   ██╔╝                                    
            ███████╗██║   ██║██████╔╝█████╗  ██████╔╝███████║█████╗  ██████╔╝██║   ██║  ██╔╝                                     
            ╚════██║██║   ██║██╔═══╝ ██╔══╝  ██╔══██╗██╔══██║██╔══╝  ██╔══██╗██║   ██║ ██╔╝                                      
            ███████║╚██████╔╝██║     ███████╗██║  ██║██║  ██║███████╗██║  ██║╚██████╔╝██╔╝                                       
            ╚══════╝ ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝                                        
            ██╗   ██╗██╗██╗     ██╗      █████╗ ██╗███╗   ██╗                                                                    
            ██║   ██║██║██║     ██║     ██╔══██╗██║████╗  ██║                                                                    
            ██║   ██║██║██║     ██║     ███████║██║██╔██╗ ██║                                                                    
            ╚██╗ ██╔╝██║██║     ██║     ██╔══██║██║██║╚██╗██║                                                                    
             ╚████╔╝ ██║███████╗███████╗██║  ██║██║██║ ╚████║                                                                    
              ╚═══╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝                                                                    
            ███████╗████████╗ ██████╗ ██████╗  █████╗  ██████╗ ███████╗                                                          
            ██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗██╔══██╗██╔════╝ ██╔════╝                                                          
            ███████╗   ██║   ██║   ██║██████╔╝███████║██║  ███╗█████╗                                                            
            ╚════██║   ██║   ██║   ██║██╔══██╗██╔══██║██║   ██║██╔══╝                                                            
            ███████║   ██║   ╚██████╔╝██║  ██║██║  ██║╚██████╔╝███████╗                                                          
            ╚══════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ";
            bool myBool = true;
            while (myBool)
            {
                Clear();
                WriteLine($"\n{title}");
                WriteLine("\t\t[1] Create New Character        ");
                WriteLine("\t\t[2] Show Collection             ");
                WriteLine("\t\t[3] Start A Battle *Upcoming*   ");
                WriteLine("\t\t[4] Delete Character            ");
                WriteLine("\t\t[5] Exit                        ");
                string str_choice = ReadLine();
                Int32.TryParse(str_choice, out int choice); // Error handling
                switch (choice)
                {
                    case 1: // Create New Character
                        Clear();
                        collection.createCharacter();                       
                        break;

                    case 2: // Show Collection
                        Clear();
                        if (collection.getAllCharacters().Count <= 0)
                        {
                            WriteLine("\nCollection is empty! Press any key for menu...");
                            ReadKey();
                        }
                        else
                        {
                            WriteLine("*** SUPERHERO/VILLAIN FULL COLLECTION ***");
                            foreach (Character character in collection.getAllCharacters())
                            {
                                WriteLine(character.ToString());
                                WriteLine("\n---------------------------------");
                            }
                            WriteLine("Press any key for menu...");
                            ReadKey();
                        }
                        break;

                    case 3:        // For future development there will be an option for starting 
                        Clear();   // a game with chosen characters. A battle between a superhero and a villain.
                        WriteLine("Game options coming soon. Press any key for menu...");
                        ReadKey();
                        break;

                    case 4:// Delete Character 
                        Clear();
                        if (collection.getAllCharacters().Count <= 0)
                        {
                            WriteLine("\nCollection is empty! Press any key for menu...");
                            ReadKey();
                        }
                        else
                        {
                            WriteLine("All characters in the collection:");
                            i = 0;
                            foreach (Character character in collection.getAllCharacters())
                            {
                                WriteLine($"ID: {i++}\n{character}");
                                WriteLine("\n---------------------------------\n");
                            }
                            Write("Choose character by the provided ID for delete: ");
                            if (Int32.TryParse(ReadLine(), out int deleteChoice)) // Error handling    
                            {
                                if (deleteChoice >= 0 && deleteChoice < collection.getAllCharacters().Count)
                                {
                                    collection.deleteCharacter(deleteChoice);
                                    WriteLine($"Character [{deleteChoice}] was deleted. Press any key for menu...");
                                    ReadKey();
                                }
                                else
                                {
                                    WriteLine($"ID '{deleteChoice}' out of range. Press any key to try again...");
                                    ReadKey();
                                }
                            }
                            else
                            {
                                WriteLine("Wrong format. Press any key for menu...");
                                ReadKey();
                            }
                        }                      
                        break;

                    case 5: // Exit
                        Clear();
                        WriteLine("You will now exit. Press any key for closing window...");
                        ReadKey();
                        myBool = false;
                        break;

                    default: // Error handling
                        WriteLine("Unvalid choice. Try again...\n");
                        ReadKey();                       
                        break;
                }
            }
        }
    }
}
