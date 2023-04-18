using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using System.Buffers;
using System.Runtime.InteropServices;

namespace ArrayList_и_HashTable
{
    public class ReversClass : IComparer
    {
        // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }
    internal class ArrayList1
    {
        private ArrayList array = new ArrayList();
        private int chislo = 0;
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Текущая коллекция: \t[" + String.Join(", ", array.ToArray()) + "]");
            Console.WriteLine();
        }
        public void Print(ArrayList copy, ArrayList array)
        {
            Console.WriteLine();
            Console.WriteLine("Массив до: \t[" + String.Join(", ", copy.ToArray()) + "]");
            Console.WriteLine("Массив после: \t[" + String.Join(", ", array.ToArray()) + "]");
            Console.WriteLine();
        }
        public void Check(ArrayList array)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!Проверка!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" Отсортированная коллекция : [{String.Join(", ", array.ToArray())}]");
            Console.WriteLine();
        }
        public void End(ArrayList copy)
        {
            Console.Write("Сохранить изменения? ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[да - Enter] ");
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key != ConsoleKey.Enter)
            {
                array = copy;
            }
            Console.Write("Нажмите любую клавишу, чтобы выйти : ");
            Console.ReadKey();
            Console.Clear();
        }
        public void End()
        {
            Console.Write("Нажмите любую клавишу, чтобы выйти : ");
            Console.ReadKey();
            Console.Clear();
        }
        public void Vvod()
        {

            Console.Clear();
            Console.WriteLine("\t\t\t - Создать ArrayList | добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + array.Count);
            Console.WriteLine("Для остановки ввода введите \"stop\"");
            string a_2 = "";
            int a_1 = 0;
            while (a_2 != "stop")
            {
                a_2 = Console.ReadLine();
                bool a = int.TryParse(a_2, out a_1);
                if (a)
                {
                    array.Add(a_1);
                    chislo++;
                }
                else
                {
                    if (a_2 != "stop") array.Add(a_2);
                }
            }
            End();
        }
        public void Sort()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Отсортировать часть ArrayList по убыванию -");
            if (chislo == 0 || chislo == array.Count)
            {
                Console.WriteLine($"Размерность : {array.Count}");
                Console.Write($"Индекс, с которого начать сортировку : ");
                int index = int.Parse(Console.ReadLine());
                Console.Write($"Сколько элементов сортировать? (max = {array.Count - index}) ");
                int cnt = int.Parse(Console.ReadLine());
                IComparer comparer = new ReversClass();
                ArrayList copy = new ArrayList();
                for (int i = 0; i < array.Count; i++)
                {
                    copy.Add(array[i]);
                }
                array.Sort(index, cnt, comparer);
                Print(copy, array);
                End(copy);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Коллекция содержит элементы разного типа, дурашка :)");
                Console.WriteLine();
                Print();
                Console.WriteLine();
                End();
            }
            
        }
        public void Reverse()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Изменение порядка ArrayList - ");
            Console.WriteLine($"Размерность : {array.Count}");
            Console.Write($"Индекс, с которого начать изменение : ");
            int index = int.Parse(Console.ReadLine());
            Console.Write($"Для скольких элементов изменить порядок? (max = {array.Count - index}) ");
            int cnt = int.Parse(Console.ReadLine());
            ArrayList copy = new ArrayList();
            for (int i = 0; i < array.Count; i++)
            {
                copy.Add(array[i]);
            }
            array.Reverse(index, cnt);
            Print(copy, array);
            End(copy);
        }
        public void BinarySearch()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Бинарный поиск - ");
            if (chislo == 0 || chislo == array.Count)
            {
                ArrayList sort = new ArrayList();
                for (int i = 0; i < array.Count; i++)
                {
                    sort.Add(array[i]);
                }
                sort.Sort();
                Console.Write($"Какой объект найти? ");
                Object o;
                int puk1 = 0;
                string puk2 = Console.ReadLine();
                bool a = int.TryParse(puk2, out puk1);
                if (a)
                {
                    o = puk1;
                }
                else
                {
                    o = puk2;
                    o.ToString();
                }

                int index = array.BinarySearch(o);
                if (index < 0)
                {
                    Console.WriteLine($"Объект \"{o}\" в результате поиска не найден.");
                }
                else
                {
                    Console.WriteLine(" Объект \"{0}\" находится по индексу {1}.", o, index);
                }
                Check(sort);
                End();
            }
            else
            {
                Console.WriteLine("Коллекция содержит элементы разных типов.");
            }
        }
        public void GetRange()
        { 
            Console.Clear();
            Console.WriteLine("\t\t\t - Подмножество элементов исходного списка - ");
            Console.WriteLine($"Размерность : {array.Count}");
            Console.Write("Индекс, с которого начинается диапазон : ");
            int index = int.Parse(Console.ReadLine());
            Console.Write($"Сколько элементов в диапазоне? (max = {array.Count - index}) ");
            int cnt = int.Parse(Console.ReadLine());
            ArrayList copy = array.GetRange(index, cnt);
            Print(copy, array);
            End();
        }
        public void SetRange()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Копирование элементов коллекции в диапазон списка ArrayList");
            Console.WriteLine();
            ArrayList copy = new ArrayList();
            for (int i = 0; i < array.Count; i++) { copy.Add(array[i]); }
            System.Collections.Queue queue = new System.Collections.Queue();
            Console.Write("Индекс, с которого начинается диапазон: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write($"Сколько элементов в коллекции, которую вы хотетите добавить? (max = {array.Count - index}) ");
            int cnt = int.Parse(Console.ReadLine());
            string str;
            int num;
            bool isNum;
            for (int i = 0; i < cnt; i++)
            {
                str = Console.ReadLine();
                isNum = int.TryParse(str, out num);
                if (isNum)
                {
                    queue.Enqueue(num);
                }
                else
                {
                    queue.Enqueue(str);
                }
            }
            array.SetRange(index, queue);
            Console.WriteLine();
            Print(copy, array);
            Console.WriteLine();
            End(copy);
        }
        public void IndexOf()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Поиск индекса элемента -");
            Print();
            Console.WriteLine($"Размерность : {array.Count}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Желательно, что бы в массиве были повторяющиеся элементы :)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите элемент : ");
            Object o;
            int puk1 = 0;
            string puk2 = Console.ReadLine();
            bool a = int.TryParse(puk2, out puk1);
            if (a)
            {
                o = puk1;
            }
            else
            {
                o = puk2;
                o.ToString();
            }
            Console.Write($"Диапазон, по которому производится поиск объекта (через пробел): ");
            string[] range = Console.ReadLine().Split();
            int index = int.Parse(range[0]);
            int cnt = index + int.Parse(range[1]) - 1;
            Console.WriteLine($"Индекс первого вхождения '{o}': {array.IndexOf(o, index, cnt)}");
            Console.WriteLine($"Индекс последнего вхождения '{o}': {array.LastIndexOf(o, index)}");
            End();
        }
        public void Insert()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Вставка элемента в список ArrayList по указанному индексу -");
            Console.Write("Введите индекс: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Элемент для вставки: ");
            object o;
            string el = Console.ReadLine();
            int c;
            bool a = int.TryParse(el, out c);
            if (a) {o = c;}
            else { o = el; }
            ArrayList copy = new ArrayList();
            for (int i = 0; i < array.Count; i++) { copy.Add(array[i]); }
            if (index <= array.Count)
            {
                array.Insert(index, o);
                Print(copy, array);
                Console.WriteLine();
                End(copy);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Индекс больше количества элементов коллекции");
                Console.WriteLine();
                End();
            }
        }
        public void RemoveAt()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Удаление элементов по индексу -");
            Console.Write("Индекс элемента, который нужно удалить: ");
            int cnt = int.Parse(Console.ReadLine());
            ArrayList copy = new ArrayList();
            for (int i = 0; i < array.Count; i++) { copy.Add(array[i]); }
            array.RemoveAt(cnt);
            Print(copy, array);
            Console.WriteLine(); 
            End(copy);
        }
        public void Clear()
        {
            array.Clear();
        }
    }
}
