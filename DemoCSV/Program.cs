using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\temp\test.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (var item in lines)
            //{
            //    Console.WriteLine(item);
            //}
            //lines.Add("Jean, Louis, Hasselt");  //hadi kayna f program

            //foreach (var item in lines)
            //{
            //    Console.WriteLine(item);
            //}
            //File.WriteAllLines(filePath, lines);       //hadi kanjabdo biha ay haja maktoba f file likatbna fl awal


            string filePath = @"C:\temp\test.txt";
            List<Persoon> people = new List<Persoon>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var item in lines)             //TOEVOEGEN VAN volledige person aan tekstfile
            {
                string[] entries = item.Split(',');
                Persoon person = new Persoon();
                person.FirstName = entries[0];
                person.LastName = entries[1];
                person.City = entries[2];
                people.Add(person);
            }
            List<string> output = new List<string>();

            people.Add(new Persoon { FirstName = "dija", LastName = "dijaK", City = "Cloit" });

            foreach (var item in people)
            {
                //File.WriteAllLines(filePath, lines);
                output.Add($"{item.FirstName}{item.LastName}{item.City}");
            }
            File.WriteAllLines(filePath, output);
        }
    }
}