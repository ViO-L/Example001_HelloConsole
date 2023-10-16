Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "yana")
{
    Console.WriteLine("Ура, это же Яна!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}