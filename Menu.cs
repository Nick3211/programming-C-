using System;
using System.Threading.Tasks;

namespace Chapter1
{

    public static class Program6
    {
        public static void Main()

        {

                Console.WriteLine("Programming C#, Chapter 1:");
                Console.WriteLine("Please choose a number to run the program.");
                Console.WriteLine("0............quit");
                Console.WriteLine("1............thread");
                Console.WriteLine("2............background thread");
                Console.WriteLine("3............stop thread");
                Console.WriteLine("4............thread static attribute");
                Console.WriteLine("5............task");
            var read="";
            int caseSwitch=0;
            do {
                read = Console.ReadLine();

                caseSwitch = int.Parse(read);

                switch (caseSwitch)
                {
                    case 0:
                        break; 
                    case 1:
                        program.threads();
                        break;
                    case 2:
                        Program.background();
                        break;
                    case 3:
                        program3.stopping();
                        break;
                    case 4:
                        program4.ThreadStaticAttribute();
                        break;
                    case 5:
                        Program5.task();
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            while (caseSwitch != 0);
        }
    }
}

