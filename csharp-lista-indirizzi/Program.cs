// See https://aka.ms/new-console-template for more information

// Open the file to read from.
StreamReader file = File.OpenText("C:\\Users\\khoda\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\Cartella Indirizzi\\addresses.csv");
while (!file.EndOfStream)
{
    string riga = file.ReadLine();
    Console.WriteLine(riga);
}
file.Close();













