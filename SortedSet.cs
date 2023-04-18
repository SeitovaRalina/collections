using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class SortedSet1    
    {
        SortedSet<int> set1 = new SortedSet<int>();
        SortedSet<int> set2 = new SortedSet<int>();
        public void End1()
        {
            Console.WriteLine("Множество set1: \t[" + String.Join(", ", set1.ToArray()) + "]");
            set1.Clear();
            for (int i = 0; i < 10; i++)
            {
                set1.Add(i);
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("SET1: \t[" + String.Join(", ", set1.ToArray()) + "]");
            Console.WriteLine("SET2: \t[" + String.Join(", ", set2.ToArray()) + "]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Vvod()
        {
            Console.WriteLine("\t\t\t - Создать Set | добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + set2.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Учтите, что вы вольны вводить только символы!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Для остановки ввода введите '.' ");
            string a = "";
            while (a != ".")
            {
                a = Console.ReadLine();
                if (a != ".") { set2.Add(int.Parse(a)); }
            }
            for (int i = 0; i < 10; i++)
            {
                set1.Add(i);
            }
            End();
        }
        public void IntersectWith()
        {
            Console.WriteLine("\t\t\t - Пересечение set1 и set2 -");
            Console.WriteLine();
            set1.IntersectWith(set2);
            End1();
        }
        public void IsProperSubset()
        {
            Console.WriteLine("\t\t\t - Является ли объект set1 строгим подмножеством указанной коллекции set2? -");
            Console.WriteLine("{0}", set1.IsProperSubsetOf(set2) ? "Да, set1 - подмножество set2" : "Нет, set1 не является подмножеством set2");
            End();
        }
        public void SymmetricExceptWith()
        {
            Console.WriteLine("\t\t\t - Симметрическая разность set1 и set2 -");
            Console.WriteLine("Т.е. изменение set1 так, чтобы он только элементы, которые имеются либо в set1, либо в set2, но не одновременно в них обоих множествах.");
            set1.SymmetricExceptWith(set2);
            End1();
        }
        public void UnionWith()
        {
            Console.WriteLine("\t\t\t - Объединение множеств set1 и set2 -");
            Console.WriteLine("Т.е. изменение set1 так, чтобы он содержал все элементы, имеющиеся в нем или в указанной коллекции set2 либо как в нем, так и в указанной коллекции set2");
            set1.UnionWith(set2);
            End1();
        }
        public void GetViewBetween()
        {
            Console.WriteLine("\t\t\t - Представление подмножества в наборе set1 -");
            Console.Write("Нижняя граница: ");
            int lowerValue = int.Parse(Console.ReadLine());
            Console.Write("Верхняя граница: ");
            int uppervalue = int.Parse(Console.ReadLine());
            set1.GetViewBetween(lowerValue,uppervalue);       
            End1();
        }
        public void Remove()
        {
            Console.WriteLine("\t\t\t - Удаление элементов во множестве set2 -");
            Console.Write("Введите элемент, который хотите удалить: ");
            int element = int.Parse(Console.ReadLine());
            if (set2.Contains(element))
            {
                set2.Remove(element);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Элемент '{element}' успешно удален");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Элемент '{element}' не найден");
                Console.ForegroundColor = ConsoleColor.White;
            }
            End();
        }
        public void Clear()
        {
            set2.Clear();
        }

    }
}
