Console.WriteLine("Введите имя самой прекрасной девушки : ");
string username = Console.ReadLine();

if (username.ToLower() == "оляша")
{
    Console.WriteLine("Ура, это же оляша, любимая я так сокучился");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}