namespace KataCalculator
{
    public class Calculator
    {
        int result = 0;
      
        public int Add(string Numbers)
        {
            if (Numbers == String.Empty) return 0;
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

            foreach (String number in numbers)
            {
                if (string.IsNullOrWhiteSpace(number)) continue;
                var value = Int32.Parse(number);
               
                result += value;

            }


            return result;
            
        }
    }
}