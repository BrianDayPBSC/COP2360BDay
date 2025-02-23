    class DivisionProgram
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number you want to divide.");
            string numerator = Console.ReadLine();

            Console.WriteLine("Please enter the number you want to divide by.");
            string denominator = Console.ReadLine();

            try
            {
                int number1 = Convert.ToInt32(numerator);
                int number2 = Convert.ToInt32(denominator);

                int result = Divide(number1, number2);
                Console.WriteLine($"Dividing {numerator} by {denominator} will give you {result}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both of your numbers are not a valid integer. Please try again.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero. Please try again.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please try again.");
            }
        }
        
        static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }

