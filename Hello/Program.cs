using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //WPisując na konsoli Hello Marcin przekazuje Marcin do
            //tablicy argumentów args[0] i pojawia się Witaj Marcin
            //Ograniczenie do pierwszego imienia
            //string name = args[0];
            //Console.WriteLine("Witaj, " + name);
       
            //To samo tylko więcej imion mogę wprowadzić
            foreach (var item in args)
            {
                Console.WriteLine("Hello, " + item);    
            }
        }
    }
}
