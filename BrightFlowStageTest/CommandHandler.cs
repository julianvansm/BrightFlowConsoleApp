
class CommandHandler
{

    string content = "Dit is een voorbeeld bestand. Wist je dit al? Bruine beren kunnen wel 2 meter lang worden. " +
        "Mannetjesberen kunnen wel 318 kilo wegen en Vrouwtjesberen kunnen wel 169 kilo wegen. " +
        "De Bruine beren eten voornamelijk gras, wortels en bessen ook, eten ze soms vis, insecten en grondeekhoorns, of grotere zoogdieren als ze die kunnen vangen.";

    public void HandleCommand(string command)
    {
        switch (command.ToLower())
        {
            case "list":
                List();
                break;
            case "createfile":
                Console.WriteLine("Voer de naam van je bestand in:");
                string filePath = Console.ReadLine();
                CreateFile(filePath);
                break;
            case "date":
                Date();
                break;
            case "reverse":
                Console.WriteLine("Voer een quote in die jij graag wilt omdraaien:");
                string input = Console.ReadLine();
                Reverse(input);
                break;
            default:
                Console.WriteLine("Onbekend commando, sorry :( De mogelijke commandos zijn: list, createfile, date, reverse.");
                break;
        }
    }

    public void List()
    {

        List<Person> people = new List<Person>
        {
            new Person("Pieter Post", "123 straatje"),
            new Person("Ryan Reynolds", "2343 weggetje"),
            new Person("Barry Boomgaart", "23241 buurtje")
        };

        Console.WriteLine("Lijst van mensen:");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("+-------------------+-----------------------+");
        Console.WriteLine("| Naam:             | adres:                |");
        Console.WriteLine("+-------------------+-----------------------+");

        foreach (var person in people)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"| {person.Name,-17} | {person.Address,-21} |");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine("+-------------------+-----------------------+");

    }

    public void CreateFile(string filePath)
    {

        FileManager fileManager = new FileManager();
        fileManager.CreateFile(filePath, content);


    }

    public void Date()
    {
        DateHelper dateHelper = new DateHelper();
        Console.WriteLine("Huidige Datum: " + dateHelper.GetCurrentDate());
    }
    public void Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Geen input gevonden :(");
            return;
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine($"Omgedraaide Quote: {reversed}");
    }
}