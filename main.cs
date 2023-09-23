using System;

class Program {
    public static void Main()
    {
        int minLimit = 0;
        int maxLimit = 100;
        int integerToTest = 1;
      
        Console.WriteLine("Choose the minimum limit : ");
        minLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose the maximum limit : ");
        maxLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose the integer you want to test : ");
        integerToTest = Convert.ToInt32(Console.ReadLine());

        if (integerToTest < minLimit) {
            Console.WriteLine("You have entered " + integerToTest + " which is lower than the minimum : " + minLimit + ".");
            Console.WriteLine("Your result is " + minLimit);
        } else if (integerToTest > maxLimit) {
            Console.WriteLine("You have entered " + integerToTest + " which is greater than the maximum : " + maxLimit + ".");
        } else {
            Console.WriteLine("You have entered " + integerToTest + " which is your result.");
        }

      Main();
    }
}
