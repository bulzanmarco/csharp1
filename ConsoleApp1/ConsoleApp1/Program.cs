using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Salut");
            Console.WriteLine("Salut");
            string x = Console.ReadLine();
            Console.WriteLine(x);
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + 10);
            x = "a" + "alfabet";
            string y = "Ana";
            y += "a";
            Console.WriteLine(y);
            Console.WriteLine(y == "Anaa");
            
            
            // Console.WriteLine(line);

            int[] vector= {1,2,3,4};
            int[] array = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(vector[i]);
            }
            for(int i=0;i<3;i++)
            {
                array[i] = 1;
            }
            for(int i=0;i<3;i++)
            {
                Console.Write(array[i] + " ");
            }
            
            string line = Console.ReadLine();
            string[] splitline = line.Split();
            for(int i=0;i<splitline.Length;i++)
            {
                Console.WriteLine(splitline[i]);
            }
            string haida=string.Join("$", splitline);
            Console.WriteLine(haida);
            
            int i = 0;
            while(i<=4)
            {
                ++i;
                Console.WriteLine("haida");
            }
            
            int i = 0;
            do
            {
                Console.WriteLine("mars");
                i++;
            } while (i );
            */
            int[] array = { 1, 2, 3, 4 };
            foreach(var i in array)
                {
                Console.WriteLine(i);
            }
            var x = 2;
            var y = "assfgdsg";
            switch(x)
            {
                case 1: {
                        Console.WriteLine(x)
                            break; }
                case 2:
                    {
                        console.write(x + 1);
                        break;
                    }

        }
    }
}
