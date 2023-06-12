class Program
{
    private static void Main(string[] args)
    {
        try
        {
            DirectoryInfo necessaryDelete = new DirectoryInfo("C:\\Users\\user\\Desktop\\FoldersForDelete");
            string folder = "C:\\Users\\user\\Desktop\\FoldersForDelete";

            Console.Write("Размер папки: ");
            Console.WriteLine(folder.Length + " байт");
            Console.Write("Очищено: ");
            Console.WriteLine(folder.Length + " байт");
            Console.WriteLine(TimeSpan.FromMinutes(30));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}