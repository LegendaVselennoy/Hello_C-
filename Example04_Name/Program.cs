Console.WriteLine("What's your name user: ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("Hooray, this Masha");
}
else
{
    Console.Write("Hi, ");
    Console.Write(username);
}