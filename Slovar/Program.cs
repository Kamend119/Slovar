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
    class Dictionary
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




    static public void Main(string[] args)
    {
        Dictionary dict = new Dictionary();

        dict.DictionaryPrint();

        Console.WriteLine();

        dict.DictionaryKey();

        Console.WriteLine();

        dict.DictionaryPrint();

        Console.WriteLine();

        dict.DictionaryRemove();
    }
}