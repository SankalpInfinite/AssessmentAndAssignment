using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcession
{
    class Lambda_queries
    {
        public static void Main()
        {
            List<int> sq = new List<int>() { 10,2,30};
            var ans = sq.Select(x =>x*x).Where(square=>square>20);
            Console.WriteLine("List of numbers and their suares only if the square is greater than 20");
            foreach(var i in ans)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();

            List<string> inputCollection = new List<string>{"amsterdam", "bloom", "apple", "almond", "apex", "atom"};

            var str = inputCollection
                .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var i in str)
            {
                Console.Write(i + ",");
            }
            Console.ReadKey();
        }
    }
}
