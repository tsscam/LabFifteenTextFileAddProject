using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LabFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string Continue;
            Console.WriteLine("List of Countries");

            do
            {
                Console.WriteLine("Pick an option: \n [1] List of Countries \n [2] Add Country to List \n [3] End");
                string choice = "";
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Here is the list of countries provided:");
                    StreamReader rd = new StreamReader("../../Text1.txt");
                    string FileContent = ReadFromFile();
                    Console.WriteLine(FileContent);

                }

                if (choice == "2")
                {
                    Console.WriteLine("Please input the Country to ADD to LIST: ");
                    StreamWriter sw = new StreamWriter("../../Text1.txt", true);
                    string input = Console.ReadLine();
                    Console.WriteLine("The Country you provided is saved: ");
                    sw.WriteLine(input);

                }

                if (choice == "3")
                {
                    Console.WriteLine("Goodbye! Adios! Au Revoir! Arrivederci!");
                    break;
               
                    Console.WriteLine("Continue?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    if (Continue == "Y")
                        break;
                        if (Continue == "N")
                            return;
                }
            } while (run);
        }

                   
              
          public static void WriteToFile(string input)
        {

            StreamWriter sw = new StreamWriter("../../Text1.txt", true);
            sw.WriteLine(input);
            sw.Close();
        }
        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../Text1.txt");
            string FileContent = rd.ReadToEnd();
            rd.Close();
            return FileContent;
        }
    }
}
