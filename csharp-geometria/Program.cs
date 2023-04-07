using csharp_geometria;

int b, h;

Console.Write("Inserisci la base del rettangolo: ");
b=Convert.ToInt32(Console.ReadLine());

Console.Write("Inserisci l'altezza del rettangolo: ");
h = Convert.ToInt32(Console.ReadLine());

Rettangolo r1=new Rettangolo(b, h);

Console.WriteLine("Il perimetro è: " + r1.calcolaPerimetro());
Console.WriteLine("L'area è: " + r1.calcolaArea());