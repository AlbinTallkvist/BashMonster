using Namespace;

Spelare Spelaren = new Spelare();
Fiende Fienden = new Fiende();
bool vinst = false;

// Introducera spelet, skriv HP av spelare och fienden
System.Console.WriteLine("Welcome till fighting spelet, vänligen börja med att atackera fienden!");

while (!vinst) 
{
    // Starta första rundan och attackera monstret
    System.Console.WriteLine("Attackera nu! (Tryck Enter för att attackera)");
    System.Console.WriteLine($"Fienden har nu {Fienden.hp} hp kvar och du är {Spelaren.swagness} % swag"); // remembr hur man gjord uppdaterande nu igen

    System.Console.ReadLine(); // 

// Ta bort hp från monster
    Fienden.hp -= 10;
    Spelaren.swagness += 10;

// är hp = 0? avsluta spelet
    if (Fienden.hp <= 0)
    {
        System.Console.WriteLine("Bra jobbat, fienden är död!");
        System.Console.WriteLine("Klicka vilken knapp som helst för att avsluta");
        Console.ReadKey();
        vinst = true;
    }
}

 

// vad mer?



