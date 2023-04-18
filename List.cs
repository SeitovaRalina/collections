using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class List1
    {
        List<int> list = new List<int>();
        public void Print(List<int> copy, List<int> list)
        {
            Console.WriteLine();
            Console.WriteLine("Список до: \t[" + String.Join(", ", copy.ToArray()) + "]");
            Console.WriteLine("Список после: \t[" + String.Join(", ", list.ToArray()) + "]");
            Console.WriteLine();
        }
        public void Check(List<int> list)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!Проверка!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" Отсортированная коллекция : [{String.Join(", ", list.ToArray())}]");
            Console.WriteLine();
        }
        public void End(List<int> copy)
        {
            Console.Write("Сохранить изменения? ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[да - Enter] ");
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key != ConsoleKey.Enter)
            {
                list = copy;
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
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Текущая коллекция: \t[" + String.Join(", ", list.ToArray()) + "]");
            Console.WriteLine();
        }
        public void Vvod()
        {
            Console.WriteLine("\t\t\t - Создать List | добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + list.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Учтите, что вы вольны вводить только целые числа!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Для остановки ввода введите '.' ");
            string a = "";
            while (a != ".")
            {
                a = Console.ReadLine();
                if (a != ".") { list.Add(int.Parse(a)); }
            }
            End();
        }

        public void Reverse()
        {
            Console.WriteLine("\t\t\t - Изменение порядка List - ");
            Console.WriteLine($"Размерность : {list.Count}");
            Console.Write($"Индекс, с которого начать изменение : ");
            int index = int.Parse(Console.ReadLine());
            Console.Write($"Для скольких элементов изменить порядок? (max = {list.Count - index}) ");
            int cnt = int.Parse(Console.ReadLine());
            List<int> copy = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                copy.Add(list[i]);
            }
            list.Reverse(index, cnt);
            Print(copy, list);
            End(copy);
        }
        public void BinarySearch()
        {
            Console.WriteLine("\t\t\t - Бинарный поиск -");
            Console.Write("Какой объект найти? ");
            int element = int.Parse(Console.ReadLine());
            List<int> sort = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                sort.Add(list[i]);
            }
            sort.Sort();
            int index = list.BinarySearch(element);
            if (index < 0)
            {
                Console.WriteLine($"Объект \"{element}\" в результате поиска не найден.");
            }
            else
            {
                Console.WriteLine(" Объект \"{0}\" находится по индексу {1}.", element, index);
            }
            Check(sort);
            End();
        }
        public void GetRange()
        {
            Console.WriteLine("\t\t\t - Подмножество элементов исходного списка - ");
            Console.WriteLine($"Размерность : {list.Count}");
            Console.Write("Индекс, с которого начинается диапазон : ");
            int index = int.Parse(Console.ReadLine());
            Console.Write($"Сколько элементов в диапазоне? (max = {list.Count - index}) ");
            int cnt = int.Parse(Console.ReadLine());
            List<int> copy = list.GetRange(index, cnt);
            Print(copy, list);
            End();
        }
        public void Exists()
        {
            Console.WriteLine("\t\t\t - Наличие элемента, удовлетворяющего условию - ");
            Console.Write("Есть ли числа больше (введите значение) ");
            int cnt = int.Parse(Console.ReadLine());
            if (list.Exists(x => x > cnt))
            {
                Console.WriteLine("Да, такие числа есть");
            }
            else
            {
                Console.WriteLine("Нет, таких чисел нет");
            }
            End();
        }
        public void Find()
        {
            Console.WriteLine("\t\t\t - Поиск двузначных чисел в списке -");
            Console.WriteLine();
            if (list.Exists(x => (x > 99 && x < 1000)))
            { 
                Console.WriteLine("Первое вхождение двузначного числа: {0}",list.Find(x => (x > 99 && x < 1000)));
                Console.WriteLine("Последнее вхождение двузначного числа: {0}",list.FindLast(x => (x > 99 && x < 1000)));
                Console.WriteLine("Все двузначные числа: {0}", String.Join(", ", list.FindAll(x => (x > 99 && x < 1000)).ToArray()));
            }
            else
            {
                Console.WriteLine("В списке нет двузначных чисел.");
            }
            Print();
            End();
        }
        public void IndexOf()
        {
            Console.WriteLine("\t\t\t - Поиск индекса элемента -");
            Print();
            Console.WriteLine($"Размерность : {list.Count}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Желательно, что бы в массиве были повторяющиеся элементы :)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите элемент : ");
            int el = int.Parse(Console.ReadLine());
            Console.Write($"Диапазон, по которому производится поиск объекта (через пробел): ");
            string[] range = Console.ReadLine().Split();
            int index = int.Parse(range[0]);
            int cnt = index + int.Parse(range[1]) - 1;
            if (list.IndexOf(el, index, cnt) < 0)
            {
                Console.WriteLine("Элемент не найден в указанном диапазоне");
            }
            else
            {
                Console.WriteLine($"Индекс первого вхождения '{el}': {list.IndexOf(el, index, cnt)}");
                Console.WriteLine($"Индекс последнего вхождения '{el}': {list.LastIndexOf(el, index)}");
            }
            Console.WriteLine();
            End();
        }
        public void Insert()
        {
            Console.WriteLine("\t\t\t - Вставка элемента в список ArrayList по указанному индексу -");
            Console.Write("Введите индекс: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Список для вставки (через пробел): ");
            string[] array = Console.ReadLine().Split();
            int[] l = Array.ConvertAll(array, s => int.Parse(s));

            List<int> copy = new List<int>();
            for (int i = 0; i < list.Count; i++) { copy.Add(list[i]); }

            if (index <= list.Count)
            {
                list.InsertRange(index,l);
                Print(copy, list);
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
        public void Remove()
        {
            Console.WriteLine("\t\t\t - Удаление элементов, которые соответстуют делегату -");
            Console.WriteLine("Удалить четные(0) или нечетные(1) элементы? ");
            Console.Write("Введите 0 или 1: ");
            int cnt = int.Parse(Console.ReadLine());
            List<int> copy = new List<int>();
            for (int i = 0; i < list.Count; i++) { copy.Add(list[i]); }
            if (cnt == 0)
            {
                cnt = list.RemoveAll(x => x % 2 == 0);
            }
            else
            {
                cnt = list.RemoveAll(x => x % 2 != 0);
            }
            Console.WriteLine($"Элементов удалено: {cnt}");
            Print(copy, list);
            End(copy);
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
