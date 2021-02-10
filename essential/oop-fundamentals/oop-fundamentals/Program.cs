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
            Initialize(answers);

            foreach (var answer in answers)
            {
                ShowDivider();
                answer.Process();
                ShowDivider();
            }
        }

        
        static void ShowDivider() => Console.WriteLine(new string('=', 80));


        private static void Initialize(List<ITaskAnswer> answers)
        {
            //answers.Add(new AddressAnswer());
            //answers.Add(new RectangleAnswer());
            //answers.Add(new BookAnswer());            
            answers.Add(new FigureAnswer());
        }
    }
}
