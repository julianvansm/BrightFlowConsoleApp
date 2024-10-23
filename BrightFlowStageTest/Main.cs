class Program
{
    static void Main(string[] args)
    {

        CommandHandler commandHandler = new CommandHandler();
        string command = string.Empty;

        while (command.ToLower() != "exit")
        {
            Console.WriteLine("Voer een commando in. (list, createfile, date, reverse):");
            command = Console.ReadLine();
            commandHandler.HandleCommand(command);
        }

    }

}
