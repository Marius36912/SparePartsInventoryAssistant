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
