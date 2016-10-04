using System;

class Superproject
{
    static void Main()
    {
        string naam;

        System.TimeSpan tijd;
        int dag;
        int maand;
        int jaar;
        tijd = DateTime.Now.TimeOfDay;
        dag = DateTime.Now.Day;
        maand = DateTime.Now.Month;
        jaar = DateTime.Now.Year;   
          
        string geboortejaarText;
        int geboortejaarGetal;
        int leeftijd;
        string antwoord;
        int invoer;

/*V0*/  Console.WriteLine("Hallo, ik ben een programma.");
        Console.WriteLine("Wat is jou naam?");
        naam = Console.ReadLine();
        Console.WriteLine("Hallo, " + naam + "!");
/*V1*/  Console.WriteLine("Wil je zien wat ik allemaal kan doen?");
        antwoord = Console.ReadLine();
        
        if (antwoord.ToUpper() == "JA")
        {
            Console.WriteLine("Leuk! Ik kan veel dingen, zoals de datum zeggen!");
        }
        else if (antwoord.ToUpper() == "NEE")
        {
            Console.WriteLine("Oh, um... In dat geval beëindig ik mezelf maar.");
            Console.WriteLine("Als je nu op een toets drukt eindigt het programma, jij ongeïntreseerde barbaar.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Je hoeft niet zo verlegen te zijn! Kijk eens wat ik kan:");
        }
        Console.WriteLine("De datum is " + dag + "-" + maand + "-" + jaar + ".");
/*V2*/  Console.WriteLine("In welk jaar ben je trouwens geboren?");
        geboortejaarText = Console.ReadLine();



        if (geboortejaarText.Contains==??iets anders dan cijfers??)
        {
            Console.WriteLine("Vul a.u.b nog een keer het jaar in waarin je bent geboren.");
            send back to line 48
            
        }
        else
        { 
        geboortejaarGetal = int.Parse(geboortejaarText);
        leeftijd = jaar - geboortejaarGetal;
        Console.WriteLine("Dan ben je " + leeftijd + " jaar oud!");
        }
        Console.WriteLine("Dat is toch zo... toch?");
        antwoord = Console.ReadLine();

        if(antwoord.ToUpper()=="JA")
        {
            Console.WriteLine("Geweldig het doet iets");
        }
        else
        {
            Console.WriteLine("Nou ja, wat maakt het toch eigenlijk uit als ik het niet helemaal goed heb, fouten kunnen gebeuren!");
        }
            
        Console.WriteLine("Maar ik kan nog veel meer! Druk op enter om verder te gaan.");
        invoer = Console.ReadKey().KeyChar;
        if (invoer == 13)
        {
            Console.WriteLine("\nWell done, Stanley");
        }
        else if((invoer>=65 && invoer <= 90)||(invoer >= 97 && invoer <=122))
        {
            Console.WriteLine("\nJe voerde \"tenminste\" een letter in");
        }
        else
        {
            Console.WriteLine("\nI AM THE NARRATOR HERE, STANLEY");
        }

        Console.WriteLine("Aanpassing!!!!!!!!!");

/*END*/ Console.WriteLine("Als je nu op een toets drukt eindigt het programma.");
        Console.ReadKey();
    }
}
