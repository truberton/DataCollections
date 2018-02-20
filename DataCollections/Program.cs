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
            #region list<>
            ////var cars = new List<string>();

            ////var car1 = "BMW";
            ////var car2 = "Lada";
            ////var car3 = "Mercedes";
            ////var car4 = "Ferrari";
            ////var car5 = "Opel";
            ////var car6 = "Saab";
            ////cars.Add(car1);
            ////cars.Add(car2);
            ////cars.Add(car3);
            ////cars.Add(car4);
            ////cars.Add(car5);
            ////cars.Add(car6);

            //var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };

            ////cars.RemoveAt(2);

            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 20},
            //    new Human(){Name = "Malle", Age = 25},
            //    new Human(){Name = "Palle", Age = 30},
            //    new Human(){Name = "Talle", Age = 20},
            //    new Human(){Name = "Ralle", Age = 20},
            //};

            //var query = (from element in humans1
            //             orderby element.Age descending
            //             where element.Age > 20
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //var human1 = new Human();
            //human1.Name = "FalleN";
            //human1.Age = 12;
            //humans1.Add(human1);

            ////while (true)
            ////{
            ////    var human = new Human();
            ////    Console.WriteLine("Nimi:");
            ////    human.Name = Console.ReadLine();
            ////    if (string.IsNullOrWhiteSpace(human.Name))
            ////    {
            ////        break;
            ////    }
            ////    Console.WriteLine("Vanus:");
            ////    human.Age = int.Parse(Console.ReadLine());
            ////    humans1.Add(human);
            ////}

            ////Console.WriteLine("NAME | AGE");
            ////Console.WriteLine("----------");
            ////foreach (var item in humans1)
            ////{
            ////    Console.WriteLine(item.Name + " " + item.Age);
            ////}
            #endregion

            #region Dictionary
            //var openWith = new Dictionary<string, string>();
            ////            KEY    VALUE
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";

            //Console.WriteLine("For key = rtf, value = {0} wolololololo {1} {2}", openWith["rtf"], "2", "3");

            //string value = "";
            //if (openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}", value);
            //}
            //else
            //{
            //    Console.WriteLine("key = \"tif\" is not found ");
            //}

            //string value1 = "";
            //if (openWith.TryGetValue("rtf", out value1))
            //{
            //    Console.WriteLine("For key = \"rtf\", value = {0}", value1);
            //}
            //else
            //{
            //    Console.WriteLine("key = \"rtf\" is not found ");
            //}

            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht: {0}", openWith["ht"]);
            //}

            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("key = {0}, value = {1}", kvp.Key, kvp.Value);
            //}

            ////Kõik valued
            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;
            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            ////Kõik keyd
            //Dictionary<string, string>.KeyCollection keyCollection = keyCollection = openWith.Keys;
            //foreach (var item in keyCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            ////Võtme kustutamine
            //openWith.Remove("doc");
            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found");
            //}
            #endregion

            #region Queue

            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");


            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            ////Võtab esimese elemendi queuest välja
            //Console.WriteLine("Dequeueing '{0}'", numbers.Dequeue());
            ////Vaatab järgmist queues
            //Console.WriteLine("Next item in queue '{0}'", numbers.Peek());
            ////Võtab järgmise välja
            //Console.WriteLine("Dequeueing '{0}'", numbers.Dequeue());

            ////Teeme koopia järjekorrast
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("Copy (1)");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("Copy (2)");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("QueueCopy contains 'four' = {0}", queueCopy.Contains("four"));
            //queueCopy.Clear();
            //Console.WriteLine("QueueCopy count is: {0}", queueCopy.Count);


            #endregion

            #region Stack (esimene mis läheb sisse, tuleb viimasena välja)

            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("Popping '{0}'", numbers.Pop());
            //Console.WriteLine("Peek at the next item to destack: {0}", numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());

            #endregion

            #region LINQ

            //andmekogu
            int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };

            var a = numbers.ElementAtOrDefault(15);
            var b = numbers.FirstOrDefault();
            var c = numbers.Take(3);
            var d = numbers.Average();
            var e = numbers.Max();

            Console.WriteLine(a);
            Console.WriteLine(b);

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(d);
            Console.WriteLine(e);

            //Loome päringu
            //var evenNumQuery = from num in numbers
            //               where (num % 2) == 0
            //               select num;
            //foreach (int num in evenNumQuery)
            //{
            //    Console.WriteLine("{0,1}", num);
            //}

            //int evenNumCount = evenNumQuery.Count();

            var evenNumQuery = (from num in numbers
                                where (num % 2) == 0
                                select num).ToList();

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 20},
                new Human(){Name = "Malle", Age = 25},
                new Human(){Name = "Palle", Age = 30},
                new Human(){Name = "Talle", Age = 40},
                new Human(){Name = "Ralle", Age = 20},
            };

            var f = humans1.Where(x => x.Name == "Kalle").FirstOrDefault().Name;
            var g = humans1.Where(x => x.Age == 40).ToList();
            var h = humans1.Where(x => x.Name.Contains("a")).ToList();
            var i = humans1.Where(x => x.Name.StartsWith("M")).ToList();

            Console.WriteLine(f);
            foreach (var item in g)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            foreach (var item in h)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            foreach (var item in i)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            //var query = (from element in humans1
            //             orderby element.Age descending
            //             where element.Age > 20
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //var a = numbers.Contains(4);

            //bool b = false;
            //foreach (var item in numbers)
            //{
            //    if (item == 6)
            //    {
            //        b = true;
            //    }
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            Console.ReadLine();
        }
    }
}
