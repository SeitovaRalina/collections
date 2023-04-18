using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class HashTable1
    {
        private Hashtable hashtable = new Hashtable();
        public void End()
        {
            Console.Write("Нажмите любую клавишу, чтобы выйти : ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Текущая таблица: ");
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("{0}\t:  {1}", de.Key, de.Value);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Vvod()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Создать HashTable | Добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Введите пары ключ-значение через пробел. Чтобы прекратить заполнение, введите '.'");
            string element = null;
            while (element != ".")
            {
                element = Console.ReadLine();
                if (element != ".")
                {
                    string[] a = element.Split();
                    hashtable.Add(a[0], a[1]);
                }
            }
            End();
        }
        public void ContainsKey()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t - Наличие ключа -");
            Console.WriteLine();
            Console.WriteLine("Проверим, содержит ли введенная хэш-таблица элемент с указанным ключом");
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();
            Console.WriteLine("Ключ \"{0}\" {1}.", key, hashtable.ContainsKey(key) ? "находится в Hashtable" : "НЕ находится в Hashtable");
            Console.WriteLine();
            End();
        }
        public void ContainsValue()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t - Наличие значения -");
            Console.WriteLine();
            Console.WriteLine("Проверим, содержит ли введенная хэш-таблица элемент с указанным значением");
            Console.Write("Введите значение: ");
            string value = Console.ReadLine();
            Console.WriteLine("Значение \"{0}\" {1}.", value, hashtable.ContainsValue(value) ? "находится в Hashtable" : "НЕ находится в Hashtable");
            Console.WriteLine();
            End();
        }
        public void Values()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Все значения из таблицы Hashtable -");
            Console.Write("Значения: ");
            foreach (string value in hashtable.Values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            End();
        }
        public void Keys()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Все ключи из таблицы Hashtable -");
            Console.Write("Ключи: ");
            foreach (string key in hashtable.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            End();
        }
        public void Remove()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Удаление элемента по ключу -");
            Console.Write("Введите ключ, который нужно удалить: ");
            string k = Console.ReadLine();
            hashtable.Remove(k);
            Console.Write("Проверка с помощью метода ContainsKey: ");
            Console.WriteLine("Ключ \"{0}\" {1}.", k, hashtable.ContainsKey(k) ? "в Hashtable" : "НЕ в Hashtable");
            Console.WriteLine();
            End();
        }
        public void Clear()
        {
            hashtable.Clear();
        }
    }
}
