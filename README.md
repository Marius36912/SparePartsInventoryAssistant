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
I forbindelse med denne aflevering har jeg anvendt generativ AI (ChatGPT fra OpenAI) som en faglig sparringspartner, men ikke som erstatning for min egen programmering. Al C# kode i projektet er skrevet af mig selv uden automatisk kodegenerering og uden brug af copilot lignende inline forslag i editoren. Jeg har brugt AI til at få forklaret begreber fra pensum (fx arrays, loops, branching og boolean logic), til at diskutere opbygning af programflow og flowchart, til at få hjælp til at finde og forstå små fejl (debugging) samt til sproglig forbedring af forklaringer og README tekst formidling. AI har ikke truffet beslutninger om, hvordan opgaven skulle løses, og har ikke skrevet den endelige løsning. Alle valg af datastrukturer, kontrolstrukturer og programlogik er mine egne og baseret på undervisningsmateriale og noter. Jeg tager det fulde ansvar for koden, dens funktionalitet og den samlede aflevering og følger DTU’s officielle retningslinjer for brug af generativ AI ved at dokumentere, hvordan AI er anvendt som støtte til læring og formidling, ikke som erstatning for mit eget arbejde.
