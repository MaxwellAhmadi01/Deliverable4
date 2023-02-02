// Name: Maxwell Ahmadi
// Date: 02/02/2023
// Project: Deliverable #4
// Description: This deliverable establishes a self-running fibonacci sequence for up to 25 numbers without user input


namespace Deliverable4
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] fibonacci = new int[25];

                // Initialize fibonacci series
                fibonacci[0] = 0;
                fibonacci[1] = 1;

            for (int i = 0; i < fibonacci.Length; i++)
                {

                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}