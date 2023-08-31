using Namespace;

Spelare Spelaren = new Spelare();
Fiende Fienden = new Fiende();


// Introducera spelet, skriv HP av spelare och fienden
System.Console.WriteLine("Welcome till fighting spelet, vänligen börja med att atackera fienden!");
System.Console.WriteLine("Fienden har 100hp"); //Gör om så uppdateras varje runda
System.Console.WriteLine("Du har 0 swagness)"); // Gör så uppdateras varje runda


// är hp = 0? avsluta spelet
if (Fienden.hp == 0)
{
    System.Console.WriteLine("Bra jobbat, fienden är död!");
    System.Console.WriteLine("Klicka vilken knapp som helst för avsluta");
    Console.ReadKey();
}


// Starta första rundan och attackera monstret
System.Console.WriteLine("Attackera nu! (Enter för attackera)");

// Ta bort hp från monster
Fienden.hp -=10;
Spelaren.swagness =+10;


// är hp = över 0, starta nästa runda
System.Console.WriteLine("Aj du skada han, han har bara X hp kvar"); // gör så ändras
System.Console.WriteLine("Fett cool attack dock din swag nivå är nu X"); // gör så ändras
 

// vad mer?