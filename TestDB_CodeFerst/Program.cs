using System;

namespace TestDB_CodeFerst
{
    internal class Program // это view
    {
        static string getRead = "get"; // команды
        static string addRead = "add";
        static string exit = "exit";

        static void Main(string[] args)
        {
            Console.WriteLine("Программа -- мои  записки --- ");

            while (true)
            {
                Console.WriteLine($"для того что  бы  получит  список  записей введите \"{getRead}\"");
                Console.WriteLine($"для того что  бы  добавить  запись введите \"{addRead}\"");
                Console.WriteLine($"для того что  бы  выйти из программы введите \"{exit}\"");

                switch (Console.ReadLine().ToLower().TrimStart().TrimEnd())
                {   
                    case "get":  GetRead() ; break;
                    case "add":  AddRead(); break;
                    case "exit":; return;
                    default:  Console.WriteLine("не корректная команда");
                        break;
                }
            }
        }

        private static void AddRead()
        {
            throw new NotImplementedException();
        }

        private static void GetRead()
        {
            throw new NotImplementedException();
        }
    }
}
