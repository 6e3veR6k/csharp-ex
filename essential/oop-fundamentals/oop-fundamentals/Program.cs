using oop_fundamentals.Interfaces;
using oop_fundamentals.Models;
using System;
using System.Collections.Generic;

namespace oop_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITaskAnswer> answers = new List<ITaskAnswer>();
            answers.Add(new AddressAnswer());

            foreach(var answer in answers)
            {
                ShowDivider();
                answer.Process();
                ShowDivider();
            }
        }


        static void ShowDivider() => Console.WriteLine(new string('=', 80));
    }
}
