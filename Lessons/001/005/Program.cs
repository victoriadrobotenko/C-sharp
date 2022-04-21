Console.Write("Type your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "danny")
{
    Console.WriteLine("I'm glad!");
}

else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}