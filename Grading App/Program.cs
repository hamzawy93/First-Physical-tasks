// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Enter Your score from 0 to 100");
decimal score = decimal.Parse (Console.ReadLine());
if (score >= 90)
{
    Console.WriteLine("Your Grade is ( A )");
}
else if (score >= 80)
{
    Console.WriteLine("Your Grade is ( B )");
}
else if (score >=70 )
{
    Console.WriteLine("Your Grade is ( C )");
}
else if (score >=60)
{
    Console.WriteLine ("Your Grade is ( D )");
}
else if (score <60)
{
    Console.WriteLine("Your Grade is ( F )");
}


