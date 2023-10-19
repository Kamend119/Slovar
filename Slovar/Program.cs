using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Linq;

/*
1.	//Создать набор типа словарь ключ-значение содержащий 10 ключ-значение.
    Программа - разработчик.

2.	//В консольном приложении осуществить запрос у пользователя ввода ключа.

3.	//Осуществить поиск значения в соответствии с введенным ключом, 
    //если такой есть то вывести его значение на экран, если отсутствует, 
    //то вывести соответствующее сообщение.

*   Удалить из набора найденный элемент.
•	//Вывести на экран все оставшиеся элементы.
•	//Удалить все элементы набора.

*/

class Program
{
    class Dictionary1
    {
        // Словарь
        Dictionary<string, string> programm_Programmer = new Dictionary<string, string>()
        {
            {"Дуров", "Telegram" },
            {"Google", "YouTube" },
            {"Стоун", "Twiter" },
            {"Сайбель", "Twitch" },
            {"Систром", "Instagram" },
            {"Quantic Dream", "Detroit: Become Human" },
            {"Mundfish", "Atomic Heart" },
            {"2K Games", "The Quarry" },
            {"Supermassive Games", "Little Nightmares III" },
            {"QLOC", "Mortal Kombat 1" }
        };

        private string KeyPl = "";

        //Получение ключа у пользователя
        public void DictionaryKey()
        {
            string Key = "";

            Console.WriteLine("Задайте ключ для удаления значения по ключу: ");

            Key = Convert.ToString(Console.ReadLine());

            DictionaryKeyValue(Key);
        }

        //Поиск значения по полученному ключу
        private void DictionaryKeyValue(string KeyPl)
        {
            this.KeyPl = KeyPl;

            var KeyPl1 = programm_Programmer.ContainsKey(KeyPl);

            if (KeyPl1 == true)
            {
                Console.WriteLine($"Ключ [{KeyPl}]: Значение [{programm_Programmer[KeyPl]}]");

                programm_Programmer.Remove(KeyPl);

                Console.WriteLine("Значение удалено!");
            }

            else
                Console.WriteLine("Такого ключа в словаре нет");
         
        }

        //Вывод словаря
        public void DictionaryPrint()
        {
            Console.WriteLine("Словарь: ");

            foreach (var i in programm_Programmer)
                Console.WriteLine($"Ключ: [{i.Key}] Значение: [{i.Value}]");

        }

        //Удаление всего словаря
        public void DictionaryRemove()
        {
            programm_Programmer.Clear();

            if (programm_Programmer.Count() == 0)
                Console.WriteLine("Словарь удален!");

            else
                Console.WriteLine("Словарь не удален");
        }
    }

    class Dictionary2
    {
        // Словарь
        Dictionary<string, string> book_avtor = new Dictionary<string, string>()
        {
            ["Мастер и Маргарита"] = "Михаил Булгаков",
            ["Евгений Онегин"] = "Александр Пушкин",
            ["Преступление и наказание"] = "Федор Достоевский",
            ["Война и мир"] = "Толстой",
            ["Маленький принц"] = "Антуан де Сент-Экзюпери",
            ["Герой нашего времени"] = "Михаил Лермонтов",
            ["1984"] = "Джордж Оруэлл",
            ["Сто лет одиночества"] = "Габриэль Гарсиа Маркес",
            ["Гарри Поттер"] = "Джоан Роулинг",
            ["Мертвые души"] = "Николай Гоголь"
        };

        private string KeyPl = "";

        //Получение ключа у пользователя
        public void DictionaryKey()
        {
            string Key = "";

            Console.WriteLine("Задайте ключ для удаления значения по ключу: ");

            Key = Convert.ToString(Console.ReadLine());

            DictionaryKeyValue(Key);
        }

        //Поиск значения по полученному ключу
        private void DictionaryKeyValue(string KeyPl)
        {
            this.KeyPl = KeyPl;

            var KeyPl1 = book_avtor.ContainsKey(KeyPl);

            if (KeyPl1 == true)
            {
                Console.WriteLine($"Ключ [{KeyPl}]: Значение [{book_avtor[KeyPl]}]");

                book_avtor.Remove(KeyPl);

                Console.WriteLine("Значение удалено!");
            }

            else
                Console.WriteLine("Такого ключа в словаре нет");

        }

        //Вывод словаря
        public void DictionaryPrint()
        {
            Console.WriteLine("Словарь: ");

            foreach (var i in book_avtor)
                Console.WriteLine($"Ключ: [{i.Key}] Значение: [{i.Value}]");

        }

        //Удаление всего словаря
        public void DictionaryRemove()
        {
            book_avtor.Clear();

            if (book_avtor.Count() == 0)
                Console.WriteLine("Словарь удален!");

            else
                Console.WriteLine("Словарь не удален");
        }
    }

    static void Task16()
    {
        Dictionary1 dict = new Dictionary1();

        dict.DictionaryPrint();

        Console.WriteLine();

        dict.DictionaryKey();

        Console.WriteLine();

        dict.DictionaryPrint();

        Console.WriteLine();

        dict.DictionaryRemove();
    }

    static void Task1()
    {
        Dictionary2 dict = new Dictionary2();

        dict.DictionaryPrint();

        Console.WriteLine();

        dict.DictionaryKey();

        Console.WriteLine();

        dict.DictionaryPrint();

        Console.WriteLine();

        dict.DictionaryRemove();
    }

    static public void Main(string[] args)
    {
        //Task16();

        Task1();
    }
}