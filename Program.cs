using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("This is a simple calculator");
            // Console.Write("This is your first number: ");
            // int firstNumber = int.Parse(Console.ReadLine());
            // Console.Write("This is your second number: ");
            // int secondNumber = int.Parse(Console.ReadLine());
            // int result = firstNumber + secondNumber;
            // Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is " + result );
            
            Console.WriteLine("To Check Prime Number");

            int num = 0;  
            int i = 0;  
            int p = 0;  	
	
            Console.Write("Input  a Number: ");
            num= Convert.ToInt32(Console.ReadLine());	
            for(i=2;i<=num/2;i++){
            if(num % i==0){
            p++;
            break;
                 }
            } 
           if(p==0 && num!= 1)
          Console.Write("{0} is a Prime Number.\n",num);
           else
           Console.Write("{0} is not a Prime Number\n",num);
	    } 

        
    }
}
