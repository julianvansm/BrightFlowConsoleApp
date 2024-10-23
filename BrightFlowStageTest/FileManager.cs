
class FileManager
{

    public void CreateFile(string filePath, string content)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine($"Sorry :(, dit bestand bestaat al: {filePath}");
            return;
        }

        File.WriteAllText(filePath, content);
        Console.WriteLine($"Uw tekstbestand is aangemaakt: {filePath}");
        Console.WriteLine($"Uw tekstbestand is aangemaakt: {filePath}");

    }
}