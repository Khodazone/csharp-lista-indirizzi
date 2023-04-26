// See https://aka.ms/new-console-template for more information

// Open the file to read from.
StreamReader addresses = File.OpenText("C:\\Users\\khoda\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\Cartella Indirizzi\\addresses.csv");

addresses.ReadLine();
while (!addresses.EndOfStream)
{
    string riga = addresses.ReadLine();
    string[] split = riga.Split(",");

    try
    {
        string Name = split[0];
        string Surname = split[1];
        string Street = split[2];
        string City = split[3];
        string Province = split[4];
        int Zip = int.Parse(split[5]);

        // Print single address
        Address address = new Address(Name, Surname, Street, City, Province, Zip);

        Console.WriteLine(address);
    }
    catch (Exception e)
    {
        Console.WriteLine("Qualcosa non ha funzionato...");
        Console.WriteLine("L'errore è: " + e.Message);
    }
}
addresses.Close();


