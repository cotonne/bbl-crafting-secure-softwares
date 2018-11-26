using Netflipster.Repository;
using System;
using System.Collections.Generic;

namespace Netflipster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Registration ----");
            Console.WriteLine("Identifier:");
            var userName = Console.ReadLine();
            Console.WriteLine("Password:");
            var password = Console.ReadLine();

            Register(userName, password);

            Console.WriteLine("Connection:");
            Console.WriteLine("Identifier:");
            userName = Console.ReadLine();
            Console.WriteLine("Password:");
            password = Console.ReadLine();

            string userId = Login(userName, password);
            if (userId != "")
            {
                Console.WriteLine($"Vous êtes connecté en tant que {userName}");
                Console.WriteLine("Films:");

                var identifiers = VhsDao.GetIdentifiers();
                foreach (var vhdId in identifiers)
                {                    
                    String name = VhsDao.GetVhsNameById(vhdId);
                    Console.WriteLine(vhdId + ") " + name);
                }

                Console.WriteLine("Selection:");
                var id = Console.ReadLine();
                //System.out.println(readDescription(id));
                Console.WriteLine(ReadDescription(id));

                Console.WriteLine("Quantity:");
                var qty = int.Parse(Console.ReadLine());

                Booking(id, qty, userId);

                Console.WriteLine($"Number of VHS: {qty} , final price: 8€ x {qty} VHS = {qty * 8}€" +
                    $", If you buy one more : 7€ x {qty + 1} VHS = {(qty + 1) * 7}€");
            }

            Console.ReadLine();
        }

        private static String ReadDescription(String id)
        {
            return FileDao.Read(id);
        }

        private static void Register(string name, string password)
        {
            UserDao.Register(name, password);
        }

        private static string Login(string name, string password)
        {
            return UserDao.FindId(name, password);
        }

        private static void Booking(string userId, int quantity, string vhsId)
        {
            BookingDao.Book(userId, quantity, vhsId);
        }
    }
}
