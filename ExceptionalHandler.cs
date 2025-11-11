using System;

namespace workshop3
{
    internal class ExceptionHandler
    {
        public void ConvertNumber()
        {
            try
            {
                Console.Write("Enter a number: ");
                int inputNumber = int.Parse(Console.ReadLine());  // may cause exception
                Console.WriteLine($"Converted number: {inputNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        public void ValidatePassword()
        {
            try
            {
                Console.Write("Enter password: ");
                string userPassword = Console.ReadLine();

                if (userPassword.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }

}
