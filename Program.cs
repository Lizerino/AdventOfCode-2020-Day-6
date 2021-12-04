using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string puzzleInput = System.IO.File.ReadAllText("E:\\Archive\\Repos\\MyCode\\Advent of Code\\2020\\Day 6\\input.txt");
            var splitPerGroup = puzzleInput.Split(Environment.NewLine + Environment.NewLine);
            int totalCount = 0;

            foreach (var group in splitPerGroup)
            {               
                int count = 0;
                var splitPerPerson = group.Split(Environment.NewLine);
                var sorterByLength = splitPerPerson.OrderByDescending(x => x.Length).ToArray();

                foreach (var letter in sorterByLength[0])
                {
                    var sameLetter = new List<char>();
                    for (int i = 1; i < sorterByLength.Length; i++)
                    {
                        if (sorterByLength[i].Contains(letter))
                        {
                            sameLetter.Add(letter);
                        }
                    }
                    if (sameLetter.Count==splitPerPerson.Length-1)
                    {
                        count++;
                    }
                }
            totalCount = totalCount + count;
            }


            Console.WriteLine(totalCount);
        }
    }
}
