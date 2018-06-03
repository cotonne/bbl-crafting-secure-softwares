using System;
using System.Text;

namespace Netflix2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureConsoleToDisplayEuroSymbol();

            Console.WriteLine("Registration ---- ");
            Console.WriteLine("Identifier : ");
            var userId = Console.ReadLine();
            Console.WriteLine("Password : ");
            var password = Console.ReadLine();

            Register(userId, password);

            Console.WriteLine("Connection : ");
            Console.WriteLine("Identifier : ");
            userId = Console.ReadLine();
            Console.WriteLine("Password : ");
            password = Console.ReadLine();

            if (Login(userId, password))
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

                Console.WriteLine($"Nombre de VHS : {quantity} , prix final: 8€ x {quantity} VHS = {quantity * 8}€" +
                    $", Si vous en prenez un de plus : 7€ x {quantity + 1} VHS = {(quantity + 1) * 7}€");
            }

            Console.ReadLine();
        }

        private static void ConfigureConsoleToDisplayEuroSymbol()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1252);
        }

        private static void Register(string userId, string password)
        {
        }

        private static bool Login(string userId, string password)
        {
            return true;
        }

        private static void Booking(string userId, int quantity, string vhsId)
        {
        }
    }
}
