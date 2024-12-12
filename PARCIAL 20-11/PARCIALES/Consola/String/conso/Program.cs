using biblio;

Console.WriteLine("Escribi un texto y se contara la cantidad de caracteres: ");
string texto = Console.ReadLine();

bs bs = new bs();

Console.WriteLine("Cantidad de caracteres es: " + bs.StringLength(texto));
