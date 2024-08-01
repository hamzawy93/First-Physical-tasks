// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your age");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
    Console.WriteLine("You are eligible to vote.");
else Console.WriteLine("You are not eligible to vote.");
