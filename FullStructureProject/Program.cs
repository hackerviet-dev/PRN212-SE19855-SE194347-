using System.Text;

namespace FullStructureProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("hello");
            Console.WriteLine("hello2");
            Console.WriteLine("cac doi so cua ban");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadLine();
        }
    }
}