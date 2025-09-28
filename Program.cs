// README/Dokumentation – SparePartsInventoryAssistant
// Aflevering 4 i industriel programmering
// Programmet simulerer et lager for reservedele. Brugeren bliver spurgt
// igen og igen med loop, hvilken reservedel de leder efter. 
// Hvis brugeren skriver præcic navnet på en reservedel fra lageret, 
// svarer programmet at delen findes, og programmet stopper (exit).
// Hvis brugeren skriver et navn, som ikke er på lageret, 
// svarer programmet at delen ikke findes, og spørger igen.
// Brugeren kan også stille "specialspørgsmål" som fx: Do you actually have any parts? og 
// Is there anything in stock at all?
// Så svarer programmet med antallet af dele og en liste over navnene, og vender derefter tilbage til at spørge igen.
// Programmet afsluttes kun, når en del fra lageret er fundet.
//
//Valg af datatyper:
// string[] bruges til at gemme alle reservedelsnavne i lageret også brugt array
// string bruges til brugerens input (Console.ReadLine()).
// bool bruges i programmet til at afgøre, om en del blev fundet eller ej boolean logic.
///////////
//  Begrænsninger/regler for programmet:
// - Sammenligninger af reservedelsnavne er case baseret
//   (fx "PLC module" virker, men "plc module" gør ikke).
// - Programmet indeholder ingen fejlkontrol for tom input eller tal.
// - Lageret er fast defineret som tre dele: 
//"hydraulic pump", "PLC module", "servo motor".
//Brug af AI:
// Brugt en AI-assistent som sparringspartner til at tydeliggøre flowchart,
// debugge små fejl og finde bedre måder at forklare pensum på.
// Den endelige implementering og valg i koden er mine egne og baseret på pensum og noterne.


                // SparePartsInventoryAssistant Program //
using System;

namespace SparePartsInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lagerdata i et array af strings med fast lager
            string[] inventory = { "hydraulic pump", "PLC module", "servo motor" };

            Console.WriteLine("Hej. Welcome to the spare parts inventory!");

            while (true) // while indtil reservedel er der
            {
                Console.Write("Which part do you need? ");
                string input = Console.ReadLine() ?? "";

                // Specialspørgsmål
                var norm = input.Trim().ToLowerInvariant();
                if (norm.Contains("have any parts") || norm.Contains("anything in stock"))
                {
                    Console.WriteLine($"We have {inventory.Length} part(s)!");
                    foreach (var p in inventory) // foreach som nævnt i opgaven
                        Console.WriteLine(p);
                    continue; // tilbage til prompt
                }

                // match i lageret case sensititvt 
                bool found = false;
                foreach (var part in inventory) // foreach (pensum)
                {
                    if (input == part) // eksakt match for at undgå fejl!
                    {
                        Console.WriteLine($"I've got {part} here for you 😊. Bye!");
                        found = true;
                        break;
                    }
                }

                if (found) break; // programmet slutter kun ved positivt fund

                Console.WriteLine($"I am afraid we don't have any {input} in the inventory 😔");
            }
        }
    }
}

// example tests
// TEST 1
// Hej. Welcome to the spare parts inventory!
// Which part do you need? gripper
// I am afraid we don't have any gripper in the inventory 😔
// Which part do you need? PLC module
// I've got PLC module here for you 😊
// 
// Process finished with exit code 0.

// TEST 2
//Hej. Welcome to the spare parts inventory!
// Which part do you need? Do you actually have any parts?
// We have 3 part(s)!
// hydraulic pump
// PLC module
// servo motor
// Which part do you need? servo motor
// I've got servo motor here for you 😊
// 
// Process finished with exit code 0.
// 