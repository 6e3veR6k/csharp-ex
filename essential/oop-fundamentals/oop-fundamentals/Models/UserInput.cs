using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace oop_fundamentals.Models
{
    public class UserInput
    {
        public string ConsoleMessage { get; private set; }
        public Predicate<double> IsValidValue { get; set; }

        public UserInput(string message)
        {
            ConsoleMessage = message;
        }

        public void GetUserValue(out double inputValue)
        {
            while(true)
            {
                string userInput = GetUserInput();

                if(!double.TryParse(userInput, NumberStyles.Float, CultureInfo.InvariantCulture, out inputValue))
                {
                    continue;
                }

                if (IsValidValue == null)
                {
                    break;
                }

                if (IsValidValue(inputValue))
                {
                    break;
                }

                
            }
            
        }


        public void GetUserValue(out int inputValue)
        {
            while (true)
            {
                string userInput = GetUserInput();

                if (!int.TryParse(userInput, NumberStyles.Float, CultureInfo.InvariantCulture, out inputValue))
                {
                    continue;
                }


                if (IsValidValue == null)
                {
                    break;
                }

                if (IsValidValue(inputValue))
                {
                    break;
                }
            }
        }


        private string GetUserInput()
        {
            Console.Write(ConsoleMessage);
            return Console.ReadLine();
        }
    }
}
