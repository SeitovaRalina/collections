using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class Dictionary1
    {
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        public void Print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Текущий словарь: ");
            foreach (var el in dict)
            {
                Console.WriteLine($"{el.Key} :\t {el.Value}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public void End()
        {
            Console.Write("Нажмите любую клавишу, чтобы выйти : ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Vvod()
        {
            Console.WriteLine("\t\t\t - Создать Dictionary | Добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Введите пары ключ-значение через пробел. Чтобы прекратить заполнение, введите '.'");
            string element = null;
            while (element != ".")
            {
                element = Console.ReadLine();
                if (element != ".")
                {
                    string[] a = element.Split();
                    dict.Add(a[0], a[1]);
                }
            }
            End();
        }
        public void ContainsKey()
        {
            Console.WriteLine("\t\t\t\t - Наличие ключа -");
            Console.WriteLine();
            Console.WriteLine("Проверим, содержит ли введенный словарь элемент с указанным ключом");
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();
            Console.WriteLine("Ключ \"{0}\" {1}.", key, dict.ContainsKey(key) ? "находится в словаре" : "НЕ находится в словаре");
            Console.WriteLine();
            End();
        }
        public void ContainsValue()
        {
            Console.WriteLine("\t\t\t\t - Наличие значения -");
            Console.WriteLine();
            Console.WriteLine("Проверим, содержит ли введенный словарь элемент с указанным значением");
            Console.Write("Введите значение: ");
            string value = Console.ReadLine();
            Console.WriteLine("Значение \"{0}\" {1}.", value, dict.ContainsValue(value) ? "находится в словаре" : "НЕ находится в словаре");
            Console.WriteLine();
            End();
        }
        public void Remove()
        {
            Console.WriteLine("\t\t\t\t - Удаление элемента по ключу -");
            Console.Write("Введите ключ, который нужно удалить: ");
            string k = Console.ReadLine();
            string value;
            dict.Remove(k, out value);
            if (value != null)
            {
                Console.WriteLine($"Элемент со значением \"{value}\" удален из словаря.");
            }
            else
            {
                Console.WriteLine("Такого ключа нет в словаре.");
            }
            End();
        }
        public void TryGetValue()
        {
            Console.WriteLine("\t\t\t - Получение значения по ключу -");
            Console.Write("Введите ключ: ");
            string k = Console.ReadLine();
            string value = "";
            if (dict.TryGetValue(k, out value))
            {
                Console.WriteLine($"Для ключа = \"{k}\" значение словаря = \"{value}\"");
            }
            else
            {
                Console.WriteLine($"Ключ \"{k}\" не найден.");
            }
            End();
        }
        public void TryAdd()
        {
            Console.WriteLine("\t\t\t - Попытка добавить новый элемент в словарь -");
            Console.Write("Ключ: ");
            string k = Console.ReadLine();
            Console.Write("Значение: ");
            string v = Console.ReadLine();
            if (dict.TryAdd(k, v))
            {
                Console.WriteLine("Пара ключ/значение была успешно добавлена");
            }
            else
            {
                Console.WriteLine($"Пара \"{k}\" - \"{v}\" уже есть в словаре");
            }
            End();
        }
        public void FirstLast()
        {
            Console.WriteLine("\t\t\t - Первый и последний элемент словаря -");
            Console.WriteLine();
            Console.WriteLine("Первый элемент словаря: {0}",dict.First());
            Console.WriteLine("Последний элемент словаря: {0}", dict.Last());
            End();
        }
        public void Clear()
        {
            dict.Clear();
        }
    }
}
