﻿
namespace WebLinks
{
    internal class Program
    {

        class Link
        {
            private string name;
            private string url;
            private string description;
            private string fileId;

            public Link(string name, string url, string desc, string fileId) {
                this.name = name;
                this.url = url;
                this.description = desc;
                this.fileId = fileId;
            }
            
            public string Name {
                get { return name; }
                set { name = value; }   
            }

            public String Url
            {
                get { return url; } 
                set { url = value; }
            }

            public string Description
            {
                get { return description; }
                set { description = value; }
            }

            public string FileId
            {
                get { return fileId; }
                set { fileId = value; } 
            }
        }


        public static void PrintList() 
        {
            foreach (string element in lista) 
            {
                Console.WriteLine($"{komplett lista}{}{}");
            }
        }

        static void Main(string[] args)
        {
            PrintWelcome();
            string command;
            do
            {
                Console.Write(": ");
                command = Console.ReadLine();
                if (command == "quit")
                {
                    Console.WriteLine("Good bye!");
                }
                else if (command == "help")
                {
                    WriteTheHelp();
                }
                else if (command == "load")
                {
                    NotYetImplemented(command);
                }
                else if (command == "open")
                {
                    NotYetImplemented(command);
                }
                else
                {
                    Console.WriteLine($"Unknown command '{command}'");
                }
            } while (command != "quit");
        }

        private static void NotYetImplemented(string command)
        {
            Console.WriteLine($"Sorry: '{command}' is not yet implemented");
        }

        private static void PrintWelcome()
        {
            Console.WriteLine("Hello and welcome to the ... program ...");
            Console.WriteLine("that does ... something.");
            Console.WriteLine("Write 'help' for help!");
        }

        private static void WriteTheHelp()
        {
            string[] hstr = {
                "help  - display this help",
                "load  - load all links from a file",
                "open  - open a specific link",
                "quit  - quit the program"
            };
            foreach (string h in hstr) Console.WriteLine(h);
        }


        public static void LoadFile()
        {
            List <Links> Nyheter = new List<Links>();
            using (StreamReader sr = new StreamReader("Nyheter.txt")) {
                int counter = 0;
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    string[] line = ln.Split(", ");
                    string name = line[0];
                    string description= line[1];
                    string url= line[2];
                    Link[counter](line[0], line[1], line[2], counter);
                    Nyheter.Add(Link[counter]);
                    counter++;
                }
            }
        }
       

    }
}