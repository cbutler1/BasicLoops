//string input;

//do
//{
//    Console.WriteLine("Hello, World!");
//    Console.WriteLine("Would you like to continue (y/n)?");
//    input = Console.ReadLine().ToLower();
//} while (input == "y");

//needs to count up as well 
//Console.WriteLine("Enter a number: ");
//int i = int.Parse(Console.ReadLine());
//for (int j = i; j >= 0; j--)
//{
//    Console.Write(j + " ");
//    if (j == 0)
//    {
//        break;
//    }
//}
//Console.WriteLine();
//for (int x = 0; x <= i; x++)
//{
//    Console.Write(x + " ");
//    if (i == x)
//    {
//        break;
//    }
//}

//while loop keypad 
//int attempt = 0;
//while (attempt < 6)
//{

//    Console.WriteLine("Enter Code");
//    int code = int.Parse(Console.ReadLine());
//    attempt++;
//    if (code == 13579)
//    {
//        Console.WriteLine("Welcome Home!");
//        break;
//    }
//    if (attempt == 5)
//    {
//        Console.WriteLine("Sorry, please wait to try again.  Too many incorrect attempts.");
//        break;
//    }

//}

//do while loop keypad
int attempts = 0;
do
{
    Console.WriteLine("Enter Code");
    int code = int.Parse(Console.ReadLine());
    attempts++;
    if (code == 13579)
    {
        Console.WriteLine("Welcome Home!");
        break;
    }
} while (attempts < 5);

if (attempts == 5)
Console.WriteLine("Too any unsuccessful attempts, please try again later.");




