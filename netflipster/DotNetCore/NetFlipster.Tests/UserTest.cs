using Netflipster;
using NFluent;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace NetFlipster.Tests
{
    public class UserTest
    {
        [Fact]
        public void Be_able_to_register()
        {
            StringWriter memoryStream = DefineScenario("john\r\npassword\r\njack\r\npassword\r\n");
            Program.Main(null);
            String data = memoryStream.GetStringBuilder().ToString();
            Check.That(data).IsEqualTo("Registration ----\r\nIdentifier:\r\nPassword:\r\nConnection:\r\nIdentifier:\r\nPassword:\r\n");
        }

        [Fact]
        public void Be_able_to_connect()
        {
            StringWriter memoryStream = DefineScenario("john\r\npassword\r\njohn\r\npassword\r\n0\r\n1\r\n");
            Program.Main(null);
            String data = memoryStream.GetStringBuilder().ToString();
            Check.That(data).IsEqualTo(
                "Registration ----\r\nIdentifier:\r\nPassword:\r\nConnection:\r\nIdentifier:\r\nPassword:\r\n" +
                "Vous êtes connecté en tant que john\r\n" +
                "Films:\r\n" +
                "1) Harry Potter and the Philosophers Stone (2001)\r\n" +
                "2) Harry Potter and the Chamber of Secrets (2002)\r\n" +
                "3) Harry Potter and the Prisoner of Azkaban (2004)\r\n" +
                "4) Harry Potter and the Goblet of Fire (2005)\r\n" +
                "5) Harry Potter and the Order of the Phoenix (2007)\r\n" +
                "6) Harry Potter and the Half-Blood Prince (2009)\r\n" +
                "7) Harry Potter and the Deathly Hallows – Part 1 (2010)\r\n" +
                "8) Harry Potter and the Deathly Hallows – Part 2 (2011)\r\n" +
                "Selection:\r\n" +
                "No description available\r\n" +
                "Quantity:\r\n" +
                "Number of VHS: 1 , final price: 8€ x 1 VHS = 8€, If you buy one more : 7€ x 2 VHS = 14€\r\n");
        }

        private StringWriter DefineScenario(String initialString)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var bytes = Encoding.ASCII.GetBytes(initialString);
            TextReader inConsole = new StreamReader(new MemoryStream(bytes), Encoding.UTF8);
            Console.SetIn(inConsole);

            return stringWriter;
        }
    }
}
