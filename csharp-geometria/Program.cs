using csharp_geometria;
using System.Security.Cryptography;

int b, h;

Console.WriteLine("Vuoi creare un rettangolo personalizzato? ");
if (Console.ReadLine()=="sì")
{
    Console.Write("Inserisci la base del rettangolo: ");
    b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Inserisci l'altezza del rettangolo: ");
    h = Convert.ToInt32(Console.ReadLine());

    Rettangolo r1 = new Rettangolo(b, h);
    Console.WriteLine("Rettangolo1:");
    r1.stampaRettangolo();

}
// r1 non c'è più => garbage collector lo elimina dalla memoria


Rettangolo r2 = new Rettangolo(7, 3);

Console.WriteLine("La base di r2 è "+ r2.getBaseRettangolo());
//r2.baseRettangolo = -40;            //SBAGLIATO!!! => stato non valido!
r2.setBaseRettangolo(-20);

Rettangolo r3 = new Rettangolo(2, 8);





Console.WriteLine("Rettangolo2:");
r2.stampaRettangolo();


Console.WriteLine("Rettangolo3:");
r3.stampaRettangolo();


