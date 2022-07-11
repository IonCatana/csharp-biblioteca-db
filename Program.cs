using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using csharp_biblioteca;



Biblioteca b = new Biblioteca("Lello e Irmão");

Scaffale s1 = new Scaffale("S001");
Scaffale s2 = new Scaffale("S002");
Scaffale s3 = new Scaffale("S003");

//"Libro 1"
Libro l1 = new Libro("ISBN1", "Lo straniero", 1942, "Storia", 220);

Autore a1 = new Autore("Albert", "Camus");
Autore a2 = new Autore("André", "Malraux");

l1.Autori.Add(a1);
l1.Autori.Add(a2);

l1.Scaffale = s1;

b.Documenti.Add(l1);


//"Libro 2"
Libro l2 = new Libro("ISBN2", "La condizione umana", 1933, "Storia", 130);

Autore a3 = new Autore("Boris", "Vian");
Autore a4 = new Autore("Umberto", "Eco");

l2.Autori.Add(a3);
l2.Autori.Add(a4);

l2.Scaffale = s2;
b.Documenti.Add(l2);


//"DVD"
DVD dvd1 = new DVD("Codice1", "Matrix", 2022, "Storia", 130);

dvd1.Autori.Add(a3);

dvd1.Scaffale = s3;
b.Documenti.Add(dvd1);


Utente u1 = new Utente("Ion", "Catana", "Telefono 1", "Email 1", "Password 1");

b.Utenti.Add(u1);

Prestito p1 = new Prestito("P00001", new DateTime(2022, 1, 20), new DateTime(2022, 2, 20), u1, l1);
Prestito p2 = new Prestito("P00002", new DateTime(2022, 3, 20), new DateTime(2022, 4, 20), u1, l2);

b.Prestiti.Add(p1);
b.Prestiti.Add(p2);

Console.WriteLine("\n\nSearchByCodice: ISBN1\n\n");

List<Documento> results = b.SearchByCodice("ISBN1");

foreach (Documento doc in results)
{
    Console.WriteLine(doc.ToString());

    if (doc.Autori.Count > 0)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Autori");
        Console.WriteLine("--------------------------");
        foreach (Autore a in doc.Autori)
        {
            Console.WriteLine(a.ToString());
            Console.WriteLine("--------------------------");
        }
    }
}
Console.WriteLine(b);
Console.WriteLine("\n\nSearchPrestiti: Ion, Catana\n\n");

List<Prestito> prestiti = b.SearchPrestiti("Ion", "Catana");

foreach (Prestito p in prestiti)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine("--------------------------");
}
