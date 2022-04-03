using System;
using System.Collections;

namespace AtaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator cr = new Creator();
            Delete dl = new Delete();

            string text;
            string tag;
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Ata Creator!");
                Console.WriteLine("1 - Create Ata");
                Console.WriteLine("2 - Delet Ata");
                Console.WriteLine("3 - Exit");
                Console.Write("Choose an option: ");
                option = Convert.ToInt32(Console.ReadLine());

                while (option < 1 || option > 3)
                {
                    Console.WriteLine("The chosen option is invalid");
                    Console.Write("Choose again, please: ");
                    option = Convert.ToInt32(Console.ReadLine());
                }

                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You chose the option 'Create Ata'");
                    Console.WriteLine();
                    Console.Write("Enter the Ata place of creation: ");
                    text = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter Ata tag: ");
                    tag = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the title of the meeting: ");
                    cr.title = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Enter the number of participants: ");
                    cr.numbPart = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 0; i < cr.numbPart; i++)
                    {
                        string n;
                        Console.Write($"Enter the {i + 1}º name: ");
                        n = Convert.ToString(Console.ReadLine());
                        cr.names.Add(n);
                    }

                    Console.WriteLine();
                    Console.Write("Enter the meeting description: ");
                    cr.description = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    text = $@"{text}\{tag}.txt";
                    cr.text = text;
                    cr.Cre();
                    Console.WriteLine();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                }

                if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You chose the option 'Delet Ata'");
                    Console.WriteLine();
                    Console.Write("Enter the Ata location: ");
                    dl.text = Convert.ToString(Console.ReadLine());
                    dl.del();
                    Console.WriteLine();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                }
            } while (option != 3);
        }
    }
}