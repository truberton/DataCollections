using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<string>();

            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";
            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };

            //cars.RemoveAt(2);

            for (int index = 0; index < cars.Count; index++)
            {
                Console.WriteLine(cars[index]);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 20},
                new Human(){Name = "Malle", Age = 25},
                new Human(){Name = "Palle", Age = 30},
                new Human(){Name = "Talle", Age = 20},
                new Human(){Name = "Ralle", Age = 20},
            };

            var human1 = new Human();
            human1.Name = "FalleN";
            human1.Age = 12;
            humans1.Add(human1);

            //DICTIONARY
            var openWith = new Dictionary<string, string>();
            //            KEY    VALUE
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            openWith["rtf"] = "winword.exe";
            openWith["doc"] = "winword.exe";

            Console.WriteLine("For key = rtf, value = {0} wolololololo {1} {2}", openWith["rtf"], "2", "3");

            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}", value);
            }
            else
            {
                Console.WriteLine("key = \"tif\" is not found ");
            }

            string value1 = "";
            if (openWith.TryGetValue("rtf", out value1))
            {
                Console.WriteLine("For key = \"rtf\", value = {0}", value1);
            }
            else
            {
                Console.WriteLine("key = \"rtf\" is not found ");
            }

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hyperterm.exe");
                Console.WriteLine("Value added for key ht: {0}", openWith["ht"]);
            }


            //while (true)
            //{
            //    var human = new Human();
            //    Console.WriteLine("Nimi:");
            //    human.Name = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(human.Name))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Vanus:");
            //    human.Age = int.Parse(Console.ReadLine());
            //    humans1.Add(human);
            //}

            //Console.WriteLine("NAME | AGE");
            //Console.WriteLine("----------");
            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
            Console.ReadLine();
        }
    }
}
