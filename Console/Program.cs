
using Service;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BService bService = new BService();
            bService.Print();
            System.Console.WriteLine("ddd");
        }
    }
}
