
namespace L0ginSuccessful
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MinAttempts = 0;
            int MaxAttempts = 3;

            do
            {
                Console.Write("Enter your username:");
                string username = (Console.ReadLine());

                if (username == "Admin")
                {
                    Console.Write("Enter your password:");
                    string password = (Console.ReadLine());

                    if (password == "Admin1234!")
                    {
                        Console.WriteLine("Login Successful!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Credentials. Please try again. Only 3 maximum attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Credentials. Please try again. Only 3 maximum atempts.");
                }

                MinAttempts++; 

            } while (MinAttempts < MaxAttempts);

            if (MinAttempts == MaxAttempts)
            {
                Console.WriteLine("Login Unsuccsessful. Maximum attempts reached.");
            }
        }
    }
}

 