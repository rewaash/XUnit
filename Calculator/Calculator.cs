namespace KataCalculator
{
    public class Calculator
    {
        int result = 0;
      
        public int Add(string Numbers)
        {
            if (Numbers == String.Empty) return 0;
            
            char[] spearator = { ',' };
          
               var numbers = Numbers.Split(spearator,
                  StringSplitOptions.RemoveEmptyEntries); 

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