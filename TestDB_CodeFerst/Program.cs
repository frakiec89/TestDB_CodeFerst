using System;

namespace TestDB_CodeFerst
{
    internal class Program // это view
    {
        static string getRead = "get"; // команды
        static string addRead = "add";
        static string exit = "exit";

        static void Main(string[] args)  // ссылка на  гит  https://github.com/frakiec89/TestDB_CodeFerst
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
            Console.WriteLine("Добавление новой записи:");
            string content = GetStringContentConsole("Введи контент");
            string status = GetStringContentConsole("укажите статус  сообщения");

            try
            {
                RecordService.AddRecord(content, status);
                Console.WriteLine("Запись добавлена - ура");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string GetStringContentConsole(string message)
        {
            Console.WriteLine(message);
            string content = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Не корректный ввод");
                Console.WriteLine("Попробуйте еще раз");
                return GetStringContentConsole(message);
            }
            return content.TrimStart().TrimEnd();
        }

        private static void GetRead()
        {
            Console.WriteLine("Список активных записей:");
            try
            {
                RecordService.GetRecord().ForEach(x => Console.WriteLine(x));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
