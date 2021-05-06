using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppModul12_algoritm
{
    class Program
     {
       static void Main(string[] args)
        {
            List<User> listUser = new List<User>();

            Console.WriteLine("Создайте список пользователей.");
            var Str = "";
            do
            {   var user = new User();
                Console.WriteLine("\r\nВведите Login пользователя.  Для завершения списка введите stop.");
                Str = Console.ReadLine();

                if (Str != "stop")
                { 
                    user.Login = Str;

                    Console.WriteLine("Введите Name");
                    user.Name = Console.ReadLine();

                    Console.WriteLine("Если пользователь имеет премиум-подписки введите ДА");
                    var prem = Console.ReadLine();
                    if (prem.ToLower() == "да")
                    {
                        user.IsPremium = true;
                    }
                    else
                    {
                        user.IsPremium = false;
                    }

                    listUser.Add(user);
                }
            }
            while (Str.ToLower() != "stop");

            foreach (User u in listUser)
            {
                Console.WriteLine($"\r\nДобрый день, {u.Name}");
                if (u.IsPremium == false)
                {
                    ShowAds();
                }
            }         
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
