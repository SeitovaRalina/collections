using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class HashSet1
    {
        HashSet<char> set1 = new HashSet<char>() { 'A', 'B', 'C', 'D','E'};
        HashSet<char> set2 = new HashSet<char>();
        HashSet<char> izm = new HashSet<char>() { 'A', 'B', 'C', 'D', 'E' };
        public void End1()
        {
            Console.WriteLine("Множество set1: \t[" + String.Join(", ", izm.ToArray()) + "]");
            izm.Clear();
            foreach (char i in set1) { izm.Add(i); };
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
                if (a != ".") { set2.Add(char.Parse(a)); }
            }
            End();
        }
        public void ExceptWith()
        {
            Console.WriteLine("\t\t\t - Содержимое множества set1 после вычитания из множества set2 -");
            Console.WriteLine();
            izm.ExceptWith(set2);
            End1();
        }
        public void IntersectWith()
        {
            Console.WriteLine("\t\t\t - Пересечение set1 и set2 -");
            Console.WriteLine();
            izm.IntersectWith(set2);
            End1();
        }
        public void IsSubsetOf()
        {
            Console.WriteLine("\t\t\t - Является ли объект set1 подмножеством указанной коллекции set2? -");
            Console.WriteLine("{0}", set1.IsSubsetOf(set2) ? "Да, set1 - подмножество set2":"Нет, set1 не является подмножеством set2");
            End();
        }
        public void Overlaps()
        {
            Console.WriteLine("\t\t\t - Имеются ли общие элементы в текущем объекте set1 и коллекции set2 -");
            Console.WriteLine(set1.Overlaps(set2) ? "Да, имеются":"Нет, не имеются");
            End();
        }
        public void SetEquals()
        {
            Console.WriteLine("\t\t\t - Содержит ли объект set1 и коллекция set2 одни и те же элементы -");
            Console.WriteLine(set1.SetEquals(set2) ? "Да, set1 = set2":"Нет, set1 != set2");
            End();
        }
        public void SymmetricExceptWith()
        {
            Console.WriteLine("\t\t\t - Симметрическая разность set1 и set2 -");
            Console.WriteLine("Т.е. изменение set1 так, чтобы он только элементы, которые имеются либо в set1, либо в set2, но не одновременно в них обоих множествах.");
            izm.SymmetricExceptWith(set2);
            End1();
        }
        public void UnionWith()
        {
            Console.WriteLine("\t\t\t - Объединение множеств set1 и set2 -");
            Console.WriteLine("Т.е. изменение set1 так, чтобы он содержал все элементы, имеющиеся в нем или в указанной коллекции set2 либо как в нем, так и в указанной коллекции set2");
            izm.UnionWith(set2);
            End1();
        }
        public void Remove()
        {
            Console.WriteLine("\t\t\t - Удаление элементов во множестве set2 -");
            Console.Write("Введите элемент, который хотите удалить: ");
            char element = char.Parse(Console.ReadLine());
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
