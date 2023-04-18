using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_и_HashTable
{
    internal class Stack1
    {
        private Stack stack = new Stack();
        private Stack stack_task = new Stack();
        public void Print()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Текущая коллекция: \t[" + String.Join(", ", stack_task.ToArray()) + "]");
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
            Console.Clear();
            Console.WriteLine("\t\t\t - Создать Stack | добавить элементы в коллекцию -");
            Console.WriteLine();
            Console.WriteLine("Количество элементов в стеке: " + stack.Count);
            Console.WriteLine("Для остановки введите символ '.'");
            string el = "";
            while (el != ".")
            {
                el = Console.ReadLine();
                if (el != ".") stack.Push(el);
            }
            End();
        }
        public void Contains()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Наличие объекта в стеке -");
            Console.Write("Введите элемент: ");
            string q = Console.ReadLine();
            Console.WriteLine("Элемент \"{0}\" {1}", q, stack.Contains(q) ? "входит в коллекцию Stack" : "НЕ входит в коллекцию Stack");
            End();
        }
        public void Peek()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Верхний объект в стеке -");
            Console.WriteLine($"Элемент: {stack.Peek()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Очередь не изменилась");
            Console.ForegroundColor = ConsoleColor.White;
            End();

        }
        public void Pop()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Удаление объекта в начале стека -");
            Console.WriteLine();
            Console.WriteLine("Удаленный элемент\t{0}", stack.Pop());
            End();
        }
        public void Clear()
        {
            stack.Clear();
        }
        public void Task()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t - Проверка расстановки скобок -");
            Console.Write("Введите строку со скобками: ");
            stack_task.Clear();
            string str = Console.ReadLine();
            bool flag = true;
            bool f = true;
            foreach (char s in str)
            {
                if (s == '[' || s == '{' || s == '(')
                { 
                    stack_task.Push(s);
                    flag = false;
                }
                if (s == ']' || s == '}' || s == ')')
                {
                    if (stack_task.Count == 0)
                    {
                        flag = false;
                        break;
                    }
                    string skobki = stack_task.Peek().ToString() + s.ToString();
                    Console.WriteLine(skobki);
                    if (skobki == "[]" || skobki == "{}" || skobki == "()")
                    {
                        stack_task.Pop();
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine(flag? "Скобки расставлены правильно" : "Скобки расставлены неправильно");
            End();
        }
    }
}
