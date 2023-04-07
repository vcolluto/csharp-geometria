using csharp_geometria;

int b, h;

Console.Write("Inserisci la base del rettangolo: ");
b=Convert.ToInt32(Console.ReadLine());

Console.Write("Inserisci l'altezza del rettangolo: ");
h = Convert.ToInt32(Console.ReadLine());

Rettangolo r1=new Rettangolo(b, h);


Rettangolo r2 = new Rettangolo(7, 3);

Rettangolo r3 = new Rettangolo(2, 8);


Console.WriteLine("Rettangolo1:");
r1.stampaRettangolo();


Console.WriteLine("Rettangolo2:");
r2.stampaRettangolo();


Console.WriteLine("Rettangolo3:");
r3.stampaRettangolo();
