using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_GradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intput > 81, 98, 29, 42, 57, 63, 34
            // output > 81, 100, 29, 42, 57, 65, 34

            Console.WriteLine(string.Join(" ", gradingStudents(new List<int>() { 81, 98, 29, 42, 57, 63, 34 })));
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    results.Add(grades[i]);
                }
                else
                {
                    if (grades[i] % 5 == 0)
                    {
                        results.Add(grades[i]);
                    }
                    else
                    {
                        int remainder = grades[i] % 5;
                        if (remainder > 2)
                        {
                            grades[i] += 5 - remainder;
                            results.Add(grades[i]);
                        }
                        else
                        {
                            results.Add(grades[i]);
                        }
                    }

                }
            }
            return results;
        }
    }
}
