using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class Queue1
    {
        Queue queue = new Queue();
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Текущая коллекция: \t[" + String.Join(", ", queue.ToArray()) + "]");
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
            Console.Clear();
            Console.WriteLine("\t\t\t - Создать Queue | добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Количество элементов в очереди: " + queue.Count);
            Console.WriteLine("Для остановки введите символ '.'");
            string el = "";
            while (el != ".")
            {
                el = Console.ReadLine();
                if (el != ".") queue.Enqueue(el);
            }
            End();
        }
        public void Contains()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Наличие объекта в очереди -");
            Console.Write("Введите элемент: ");
            string q = Console.ReadLine();
            Console.WriteLine("Элемент \"{0}\" {1}",q, queue.Contains(q)? "входит в коллекцию Queue" : "НЕ входит в коллекцию Queue");
            End();
        }
        public void Dequeue()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Удаление объекта в начале очереди -");
            Console.WriteLine();
            Console.WriteLine("Удаленный элемент\t{0}", queue.Dequeue());
            End();
        }
        public void Peek()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Объект, находящийся в начале очереди Queue -");
            Console.WriteLine();
            Console.WriteLine($"Элемент в начале очереди: {queue.Peek()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Очередь не изменилась");
            Console.ForegroundColor = ConsoleColor.White;
            End();
        }
        public void Clear()
        {
            queue.Clear();
        }
    }
}
