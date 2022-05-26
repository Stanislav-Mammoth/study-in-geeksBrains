Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "юля")
{
    Console.WriteLine("Ура! Это же, Юлька!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}