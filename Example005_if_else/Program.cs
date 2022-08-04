Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Наташа")
{
    Console.WriteLine("Ура, это же Наташа!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}