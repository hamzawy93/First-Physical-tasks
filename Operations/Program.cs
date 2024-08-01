// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Please enter your first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter your Second number");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("The following operations are Available { Addition : + ,   Subtraction - , Multiplication * , Division / , Percentage % }");
Console.WriteLine("Please Choose your Operation From { = - * / % } ");
string oper =  Console.ReadLine();

    switch (oper)
    {
        case "+":
            Console.WriteLine(num1 + num2);
            break;
        case "-":
            Console.WriteLine(num1 - num2);
            break;
        case "*":
            Console.WriteLine(num1 * num2);
            break;
        case "/":
            Console.WriteLine(num1 / num2);
            break;
        case "%":
            Console.WriteLine(num1 % num2);
            break;
    
}


   
   
    

 
    
        

        

        
            


        