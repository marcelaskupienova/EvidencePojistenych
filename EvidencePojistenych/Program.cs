// See https://aka.ms/new-console-template for more information
using EvidencePojistenych;



Databaze databaze = new Databaze();
Console.WriteLine("EVIDENCE POJISTENYCH");
char volba = '0';
while (volba != '4')
{
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    volba = Console.ReadKey().KeyChar;
    
    switch (volba)
         {
        case'1':
            databaze.PridejPojistence();
            break;
        case '2':
            databaze.VypisPojistence();
            break;
            case '3':
            databaze.VyhledejPojistence();
            break;
        case '4':
            Console.WriteLine("\n\nLibovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("\n\nNeplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
  
   
}



