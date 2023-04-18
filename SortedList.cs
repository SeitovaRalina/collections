using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class SortedList1
    {
        SortedList slist = new SortedList();
        public void End()
        {
            Console.Write("Нажмите любую клавишу, чтобы выйти : ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Текущий SortedList: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", slist.GetKey(i), slist.GetByIndex(i));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public void Vvod()
        {
            Console.WriteLine("\t\t\t - Создать SortedList | Добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Введите пары ключ-значение через пробел. Чтобы прекратить заполнение, введите '.'");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ключ должен быть числом");
            Console.ForegroundColor = ConsoleColor.White;
            string element = null;
            while (element != ".")
            {
                element = Console.ReadLine();
                if (element != ".")
                {
                    string[] a = element.Split();
                    slist.Add(int.Parse(a[0]), a[1]);
                }
            }
            End();
        }
        public void ContainsKey()
        {
            Console.WriteLine("\t\t\t\t - Наличие ключа -");
            Console.WriteLine();
            Console.WriteLine("Проверим, содержит ли введенный SortedList элемент с указанным ключом");
            Console.Write("Введите ключ: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Ключ \"{0}\" {1}.", key, slist.ContainsKey(key) ? "находится в сортированном списке" : "НЕ находится в сортированном списке");
            Console.WriteLine();
            End();
        }
        public void ContainsValue()
        {
            Console.WriteLine("\t\t\t\t - Наличие значения -");
            Console.WriteLine();
            Console.WriteLine("Проверим, содержит ли введенный SortedList элемент с указанным значением");
            Console.Write("Введите значение: ");
            string value = Console.ReadLine();
            Console.WriteLine("Значение \"{0}\" {1}.", value, slist.ContainsValue(value) ? "находится в сортированном списке" : "НЕ находится в сортированном списке");
            Console.WriteLine();
            End();
        }
        public void GetKey()
        {
            Console.WriteLine("\t\t\t\t - Ключ по индексу -");
            Console.WriteLine($"Размерность : {slist.Count}");
            Console.Write("Введите индекс: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение ключа: {0}", slist.GetKey(index));
            End();
        }
        public void GetKeyList()
        {
            Console.WriteLine("\t\t\t - Все ключи коллекции SortedList -");
            Console.WriteLine();
            for (int i = 0; i < slist.Count - 1; i++)
            {
                Console.Write("{0}, ", slist.GetKeyList()[i]);
            }
            Console.WriteLine(slist.GetKeyList()[slist.Count - 1]);
            End();
        }
        public void GetValue()
        {
            Console.WriteLine("\t\t\t\t - Значение по индексу -");
            Console.WriteLine($"Размерность : {slist.Count}");
            Console.Write("Введите индекс: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение : {0}", slist.GetByIndex(index));
            End();
        }
        public void GetValueList()
        {
            Console.WriteLine("\t\t\t - Все значения коллекции SortedList -");
            Console.WriteLine();
            for (int i = 0; i < slist.Count - 1; i++)
            {
                Console.Write("{0}, ", slist.GetValueList()[i]);
            }
            Console.WriteLine(slist.GetValueList()[slist.Count - 1]);
            End();
        }
        public void SetByIndex()
        {
            Console.WriteLine("\t\t\t - Замена значения по указанному индексу -");
            Console.Write("Введите индекс: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Введите значение: ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("SortedList до изменений: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", slist.GetKey(i), slist.GetByIndex(i));
            }
            Console.ForegroundColor = ConsoleColor.White;
            slist.SetByIndex(index, s);
            Print();
            End();
        }
        public void Index()
        {
            Console.WriteLine("\t\t\t - Поиск индекса ключа/значения -");
            Console.WriteLine($"Размерность : {slist.Count}");
            Console.Write("Индекс чего будем искать? (1)-ключ, (2)-значение ");
            int chto = int.Parse(Console.ReadLine());
            if (chto == 1)
            {
                Console.Write("Введите ключ: ");
                int key = int.Parse(Console.ReadLine());
                if (slist.IndexOfKey(key) < 0)
                {
                    Console.WriteLine($"Элемента с ключом '{key}' нет в SortedList");
                }
                else
                {
                    Console.WriteLine($"Ключ '{key}' имеет индекс: {slist.IndexOfKey(key)}");
                }

            }
            else if (chto == 2)
            {
                Console.Write("Введите значение: ");
                string value = Console.ReadLine();
                if (slist.IndexOfValue(value) < 0)
                {
                    Console.WriteLine($"Элемента со значением '{value}' нет в SortedList");
                }
                else
                {
                    Console.WriteLine($"Значение '{value}' имеет индекс: {slist.IndexOfValue(value)}");
                }
            }
            End();
        }
        public void Clear()
        {
            slist.Clear();
        }
    }
}
