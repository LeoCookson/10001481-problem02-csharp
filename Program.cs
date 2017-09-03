using System;

namespace _10001481_Csharp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Clear();
            //Variables
			 var input = 0;
             var count = 12;
           
           //Print what program is about, Enter number
            Console.WriteLine("This program will display the division tables of 1 to 12 based on input");
            Console.WriteLine("Please enter a number less then 100");
            //Check number
            var isNumber = int.TryParse(Console.ReadLine(), out input);
            //If over 100 print
            if(input > 100){
                Console.WriteLine("The number is greater then 100");
            }
             else{
            //For number is less then 12 print
            for(var i = 0; i < count; i++){
                
            Console.WriteLine($"{(double) input / count}");
           
            }
             }
            
           
          
           




			Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
