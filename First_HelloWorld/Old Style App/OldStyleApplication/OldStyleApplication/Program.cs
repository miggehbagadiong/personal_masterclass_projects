namespace OldStyleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine(); // reads the data in the next line. once entered, it will be stored
            //Console.Beep();

            Console.Beep();
            Console.WriteLine("Starting!");

            Console.Clear();
            Console.WriteLine("Hello What is your name?");
            string name = Console.ReadLine();
            Console.Beep();

            Console.Clear();
            Console.Beep();
            Console.WriteLine("Hello " + name + "!");

        }
    }
}
