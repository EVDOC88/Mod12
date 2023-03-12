using System.Security.Cryptography.X509Certificates;

namespace Mod12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User()
                {
                    Login = "log1",
                    Name= "Владимир",
                    IsPremium= true
                },
                new User()
                {
                    Login = "log2",
                    Name= "Михаил",
                    IsPremium= false
                }
            };

            Console.WriteLine("Введите ваш логин!");
            string login = Console.ReadLine();

            //User user=  users.Find ( delegate (User user) { return user.Login.Contains(login); }); - иное представление делегата

            User user = users.Find(user => user.Login.Contains(login));

            if (user != null)
            {
                Console.WriteLine($"Привет {user.Name}!");

                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }
            else
            {
                Console.WriteLine($"Такого пользователя с логином {login} не найдено");
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

        public class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }
    }

}