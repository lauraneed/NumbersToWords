namespace secondattemptstow_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user");
            {
                Console.Write("Enter a 4-digit number: ");
                int number = 0;

                
                if (int.TryParse(Console.ReadLine(), out number))
                {

                    string result = ConvertToSpokenWords(number);
                    Console.WriteLine($"here are your numbers my good sir: {result}");


              
                }
                else
                {
                    Console.WriteLine("no,no,no wrong input");
                }
            }

            static string ConvertToSpokenWords(int number)
            {
                
                string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                
                int thousands = number / 1000;
                int hundreds = (number % 1000) / 100;
                int tensDigit = (number % 100) / 10;
                int unitsDigit = number % 10;

                
                string result = "";

                if (thousands > 0)
                {
                    result += units[thousands] + " thousand ";
                }

                if (hundreds > 0)
                {
                    result += units[hundreds] + " hundred ";
                }

                
                if (tensDigit == 1 && unitsDigit > 0)
                {
                    result += teens[unitsDigit - 1] + " "; 
                }
                else
                {
                    result += tens[tensDigit] + " " + units[unitsDigit] + " ";
                }

                return result.Trim(); 
                //Console.ReadLine();
            }
        }
    }
    
}
