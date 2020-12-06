using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
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

            int[] fibonacci = { 1, 1, 2, 3, 5, 8, 13, 21 };

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

            Console.WriteLine("Which line of Sonnet 60 by William Shakespeare would you like to read?");
            int lineSonnet60 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(sonnet60[lineSonnet60]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You chose a line that does not exist.");
            }

            Console.WriteLine("Which index of the fibonacci sequence would you like to see?");
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(fibonacci[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You chose an index that does not exist.");
            }

            Console.WriteLine("Which line of Sonnet 18 by William Shakespeare would you like to read?");
            int lineSonnet18 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(sonnet18[lineSonnet18]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You chose a line that does not exist.");
            }

            Console.ReadKey();

        }
    }
}
