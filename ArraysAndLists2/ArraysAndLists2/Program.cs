using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sonnet60 = { "Sonnet 60: Like As The Waves Make Towards The Pebbled Shore - Shakespeare",
                "Like as the waves make towards the pebbled shore,",
                "So do our minutes hasten to their end;",
                "Each changing place with that which goes before,",
                "In sequent toil all forwards do contend.",
                "Nativity, once in the main of light,",
                "Crawls to maturity, wherewith being crowned,",
                "Crooked eclipses ‘gainst his glory fight,",
                "And Time that gave doth now his gift confound.",
                "Time doth transfix the flourish set on youth",
                "And delves the parallels in beauty’s brow,",
                "Feeds on the rarities of nature’s truth,",
                "And nothing stands but for his scythe to mow:",
                "And yet to times in hope, my verse shall stand",
                "Praising thy worth, despite his cruel hand."
            };

            Console.WriteLine("Whast test would you like to add to each line of Sonnet 60 by William Shakespeare?");
            string addition = Console.ReadLine();

            for (int i = 0; i < sonnet60.Length; i++)
            {
                sonnet60[i] = sonnet60[i] + addition;
            }
            for (int i = 0; i < sonnet60.Length; i++)
            {
                Console.WriteLine(sonnet60[i]);
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            List<string> sonnet18 = new List<string>();
            sonnet18.Add("Sonnet 18: Shall I compare thee to a summer’s day? - Shakespeare");
            sonnet18.Add("Shall I compare thee to a summer’s day?");
            sonnet18.Add("Thou art more lovely and more temperate: ");
            sonnet18.Add("Rough winds do shake the darling buds of May,");
            sonnet18.Add("And summer’s lease hath all too short a date; ");
            sonnet18.Add("Sometime too hot the eye of heaven shines,");
            sonnet18.Add("And often is his gold complexion dimm'd;");
            sonnet18.Add("And every fair from fair sometime declines,");
            sonnet18.Add("By chance or nature’s changing course untrimm'd;");
            sonnet18.Add("But thy eternal summer shall not fade,");
            sonnet18.Add("Nor lose possession of that fair thou ow’st; ");
            sonnet18.Add("Nor shall death brag thou wander’st in his shade,");
            sonnet18.Add("When in eternal lines to time thou grow’st: ");
            sonnet18.Add("So long as men can breathe or eyes can see,");
            sonnet18.Add("So long lives this, and this gives life to thee.");


            Console.WriteLine("What text would you like to search for in Sonnet 18 by William Shakespeare?");
            string searchText = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < sonnet18.Count(); i++)
            {
                if (sonnet18[i].Contains(searchText))
                {
                    Console.WriteLine("Your text was found on line " + i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Your text was not found in the sonnet.");
            }

            List<string> fruit = new List<string>();
            fruit.Add("Apple");
            fruit.Add("Apple");
            fruit.Add("Banana");
            fruit.Add("Banana");
            fruit.Add("Cherry");
            fruit.Add("Grape");
            fruit.Add("Pear");

            Console.WriteLine("What fruit would you like to search for in the list?");
            string searchFruit = Console.ReadLine();
            bool foundFruit = false;
            for (int i = 0; i < fruit.Count(); i++)
            {
                if (fruit[i].Contains(searchFruit))
                {
                    Console.WriteLine("Your fruit was found on line " + i);
                    foundFruit = true;
                }
            }
            if (!foundFruit)
            {
                Console.WriteLine("Your fruit was not found in the list.");
            }

            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Gerbil");
            animals.Add("Dog");
            animals.Add("Hamster");
            animals.Add("Lizard");

            List<string> uniqueAnimals = new List<string>();
            foreach (string animal in animals)
            {
                if (uniqueAnimals.Contains(animal))
                {
                    Console.WriteLine(animal + ": has already appeared in the list.");
                }
                else
                {
                    uniqueAnimals.Add(animal);
                    Console.WriteLine(animal + ": first appearance.");
                }
            }


            Console.ReadKey();
        }
    }
}
