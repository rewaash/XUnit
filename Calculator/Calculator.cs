using System.Runtime.CompilerServices;

namespace KataCalculator
{
    public class Calculator
    {
        int result = 0;
      
        public int Add(string Numbers)
        {
            if (Numbers == String.Empty) return 0;


            string[] numbers;
            numbers = ExtractNumbers( Numbers);
           
             string NegativeNumbers = new string("");

            foreach (String number in numbers)
            {
                if (string.IsNullOrWhiteSpace(number)) continue;

                var value = Int32.Parse(number);
                if (value < 0) { NegativeNumbers += value; continue; }
                if (value > 1000)
                    continue;
                result += value;

            }

            if(NegativeNumbers.Length > 0) { throw new ArgumentException($"negatives are not allowed :{NegativeNumbers}"); }


            return result;
            
        }

        private string[] ExtractNumbers(string Numbers)
        {
            string[] numbers;
            if (Numbers.StartsWith("//"))
            {
                numbers = Numbers.Split("\n",
             StringSplitOptions.RemoveEmptyEntries);
                var spliter = Numbers[2];
                if (numbers.Length < 2)
                    throw new IndexOutOfRangeException();

                numbers = numbers[1].Split(spliter,
              StringSplitOptions.RemoveEmptyEntries);


            }

            else
            {
                char[] spearator = { ',', '\n' };

                numbers = Numbers.Split(spearator,
                  StringSplitOptions.RemoveEmptyEntries);
            }

            return numbers; 

        }
    }
}