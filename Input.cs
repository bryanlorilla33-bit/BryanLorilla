namespace ConsoleApp1
{
    public class Task3
    {
        static void Main(string[] args)
        {
            // 1. Declare and initialize the array
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            // 2. Ask the user for input
            Console.Write("Enter a number to search for: ");
            string input = Console.ReadLine();
            
            // Convert input string to integer
            if (int.TryParse(input, out int target))
            {
                bool found = false; // Flag to track if the number was found

                // 3. Use a for loop to iterate through the array
                for (int i = 0; i < numbers.Length; i++)
                {
                    // 4. Compare user input to current element
                    if (numbers[i] == target)
                    {
                        Console.WriteLine($"Number found at position {i}!");
                        found = true;
                        
                        // 5. Break statement to stop the loop immediately
                        break; 
                    }
                }

                // 6. Check if loop finished without finding the match
                if (!found)
                {
                    Console.WriteLine("Number not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }
        }
    }
}
