using System;

namespace Excercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = {"English III", 
                                "Math II", 
                                "MusicTheory", 
                                "BioTech",
                                "Principles of Technology I", 
                                "Latin II",
                                "Latvian History", 
                                "Business Computer Infomation Systems",
            };
            string[] subjectTeachers = {"Ms. Lapan", 
                                        "Mrs. Gideon",
                                        "Mr. Davis", 
                                        "Ms. Palmer",
                                        "Ms. Garcia", 
                                        "Mrs. Barnett",
                                        "Ms. Johannessen", 
                                        "Mr. Bob",
            };

            Console.WriteLine("+------------------------------------------------------------+");
            for (int i = 0; i < subjects.Length; i++) 
            { 
                Console.WriteLine($"| {i+1} | {new String(' ', 36 - subjects[i].Length)}{subjects[i]} | " +
                                    $"{new String(' ', 15 - subjectTeachers[i].Length)}{subjectTeachers[i]} |");
            }
            Console.WriteLine("+------------------------------------------------------------+");

            Console.ReadKey();
        }
    }
}
