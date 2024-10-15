//simple calculator
Console.WriteLine("hello this is a simple calculator app!!!");
Console.WriteLine("Enter your first number:");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number:");
int num2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("what type of operation would you like to do?");
Console.WriteLine("enter 'a' for addition, 's' for subraction, 'm' for multiplication, 'd' for division");
string c = Console.ReadLine();
double d = 0;
switch (c)
{
    case "a":
        d=(num1 + num2); break;
    case "s":
        d=(num1 - num2); break;
    case "m":
        d=(num1 * num2); break;
    case "d":
        d=(num1 / num2); break;
    default:
        Console.WriteLine("ENTER A CORRECT VALUE"); break;
}
Console.WriteLine($"the answer is {d}");
