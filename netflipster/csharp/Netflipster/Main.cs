using System;
using System.Text;
using Netflipster.Repository;

namespace Netflipster
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureConsoleToDisplayEuroSymbol();

            Console.WriteLine("Registration ---- ");
            Console.WriteLine("Identifier : ");
            var userName = Console.ReadLine();
            Console.WriteLine("Password : ");
            var password = Console.ReadLine();

            Register(userName, password);

            Console.WriteLine("Connection : ");
            Console.WriteLine("Identifier : ");
            userName = Console.ReadLine();
            Console.WriteLine("Password : ");
            password = Console.ReadLine();

            string userId = Login(userName, password);
            if (userId != "")
            {
                Console.WriteLine($"Vous êtes connecté en tant que {userId} ");
                Console.WriteLine("Films : ");

                // List VHS HERE
                // Format
                // vhsId) vhsName
                Console.WriteLine("Selection : ");
                var vhsId = Console.ReadLine();

                Console.WriteLine("Quantity : ");
                var quantity = int.Parse(Console.ReadLine());

                Booking(vhsId, quantity, userId);

                Console.WriteLine($"Number of VHS: {quantity} , final price: 8€ x {quantity} VHS = {quantity * 8}€" +
                    $", If you buy one more : 7€ x {quantity + 1} VHS = {(quantity + 1) * 7}€");
            }

            Console.ReadLine();
        }

        private static void ConfigureConsoleToDisplayEuroSymbol()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1252);
        }

        private static void Register(string name, string password)
        {
            UserDao.Register(name, password);
        }

        private static string Login(string name, string password)
        {
            throw new NotImplementedException("Code it !");
        }

        private static void Booking(string userId, int quantity, string vhsId)
        {
            throw new NotImplementedException("Code it !");
        }
    }
}
