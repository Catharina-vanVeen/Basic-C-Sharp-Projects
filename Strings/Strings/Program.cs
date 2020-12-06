using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Sonnet 60: ";
            string string2 = "Like As The Waves Make Towards The Pebbled Shore";
            string string3 = " - ";
            string string4 = "Shakespeare";
            string heading = string1.ToUpper() + string2 + string3 + string4;
            StringBuilder poem = new StringBuilder();
            poem.Append(heading);
            poem.Append("\n\nLike as the waves make towards the pebbled shore,");
            poem.Append("\nSo do our minutes hasten to their end;");
            poem.Append("\nEach changing place with that which goes before,");
            poem.Append("\nIn sequent toil all forwards do contend.");
            poem.Append("\nNativity, once in the main of light,");
            poem.Append("\nCrawls to maturity, wherewith being crowned,");
            poem.Append("\nCrooked eclipses ‘gainst his glory fight,");
            poem.Append("\nAnd Time that gave doth now his gift confound.");
            poem.Append("\nTime doth transfix the flourish set on youth");
            poem.Append("\nAnd delves the parallels in beauty’s brow,");
            poem.Append("\nFeeds on the rarities of nature’s truth,");
            poem.Append("\nAnd nothing stands but for his scythe to mow:");
            poem.Append("\nAnd yet to times in hope, my verse shall stand");
            poem.Append("\nPraising thy worth, despite his cruel hand.");

            Console.WriteLine(poem);
            Console.ReadKey();

        }
    }
}
