using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string fileName = @"C:\Users\ziaul\source\repos\Challenge\Challenge\Answers.json";
            string jsonfile = File.ReadAllText(fileName);

            var data = System.Text.Json.JsonSerializer.Deserialize<List<Employee>>(jsonfile);



            //foreach (Employee Employee in data)
            //{
            //Console.WriteLine("Employee ID " + Employee.EmployeeId + " Answeron " + Employee.AnsweredOn +
            //                  " Sccore " + Employee.ScoreAverge());



            Monitor scores = new Monitor();

            var allScores = scores.GroupScore(data);

            foreach (var month in allScores)
            {
                Console.WriteLine("Month: " + month.Key);
                foreach (var group in month.Value)
                {
                    Console.WriteLine($"GroupId: {group.Key}, Group score: {group.Value}");
                }
            }


            Console.ReadKey();

        }

    }
}

