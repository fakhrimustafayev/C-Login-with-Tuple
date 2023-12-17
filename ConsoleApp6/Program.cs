
var tuple = Tuple.Create("admin7", "World135");

string entusername;
string entpassword;
do
{
    Console.WriteLine("Enter your username");
    entusername = Console.ReadLine();
    Console.WriteLine("Enter your password");
    entpassword = Console.ReadLine();

    if (tuple.Item1 != entusername || tuple.Item2 != entpassword)
    {
        Console.WriteLine("Your entered username or password is not correct.Try again!");

    }
   else
    {
        Console.WriteLine("You signed in successfully");
        break;
    }
}
while (tuple.Item1 != entusername || tuple.Item2 != entpassword);



