namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {                                                                            // Display a description of the program   
            Console.Write("How many numbers to print: ");
            int numtoPrint = Convert.ToInt32(Console.ReadLine());                                   // Read the user input for the count of numbers
                                                                                                   
            printNatural(10, numtoPrint);

        }                                                                       //start at 1 ten numbers to print              
        static int printNatural(int startingValue, int numtoPrint)
        {                                                                                
            if (numtoPrint < 1)                                                         // If the counter becomes less than 1, return the starting value  
            {
                return startingValue;
            }                                                                   
            Console.Write($" {startingValue} ");                              
            numtoPrint--;                                                            // Decrement the counter               
            return printNatural(startingValue - 1, numtoPrint);
        }
        
    }
}
