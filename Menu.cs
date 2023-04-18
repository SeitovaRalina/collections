using System.Collections;
namespace ArrayList_и_HashTable
{
    internal class Menu
    {
        static int Move(int i, int n, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                i = (n + i - 1) % n;
            }

            if (key.Key == ConsoleKey.DownArrow)
            {
                i = (i + 1) % n;
            }

            return i;
        }
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t\t\t\t - Лабораторная работа № 3 -");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(" - ArrayList");
                Console.WriteLine(" - Hashtable");
                Console.WriteLine(" - Queue");
                Console.WriteLine(" - Stack");
                Console.WriteLine(" - Dictionary");
                Console.WriteLine(" - List");
                Console.WriteLine(" - SortedList");
                Console.WriteLine(" - HashSet");
                Console.WriteLine(" - SortedSet");
                Console.SetCursorPosition(25, i + 2);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    int j;
                    if (i == 0)
                    { 
                        ArrayList1 a = new ArrayList1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t - ArrayList - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            a.Print();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов");
                            Console.WriteLine("2. Сортировка"); // Sort (части массива)
                            Console.WriteLine("3. Изменение порядка элементов"); //Reverse (сколько элементов начиная с какого индекса)
                            Console.WriteLine("4. Бинарный поиск"); //BinarySearch
                            Console.WriteLine("5. Подмножество элементов исходного списка"); //GetRange()
                            Console.WriteLine("6. Копирование элементов коллекции в диапазон списка"); //SetRange
                            Console.WriteLine("7. Поиск индекса элемента"); //IndexOf()
                            Console.WriteLine("8. Вставка элемента в коллекцию"); // insert()
                            Console.WriteLine("9. Удаление элементов по индексу"); // remove() removeAt() removeRange()
                            Console.WriteLine("10. Очищение списка"); // Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(55, j + 4);
                            ConsoleKeyInfo key1 = Console.ReadKey();
                            if (key1.Key == ConsoleKey.Enter)
                            {
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.Sort(); break;
                                    case 2: a.Reverse(); break;
                                    case 3: a.BinarySearch(); break;
                                    case 4: a.GetRange(); break;
                                    case 5: a.SetRange(); break;
                                    case 6: a.IndexOf(); break;
                                    case 7: a.Insert(); break;
                                    case 8: a.RemoveAt(); break;
                                    case 9: a.Clear(); break;
                                    case 10: break;
                                }
                                if (j == 11)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 12, key1);
                        }
                    }
                    if (i == 1)
                    {
                        HashTable1 a = new HashTable1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t - HashTable - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов");
                            Console.WriteLine("2. Наличие ключа"); //ContainsKey
                            Console.WriteLine("3. Наличие значения"); //ContainsValue
                            Console.WriteLine("4. Все ключи хэш-таблицы"); //Values
                            Console.WriteLine("5. Все значения из хэш-таблицы"); //Keys
                            Console.WriteLine("6. Удаление объекта по ключу"); //Remove
                            Console.WriteLine("7. Очищение хэш-таблицы"); //Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            a.Print();
                            Console.SetCursorPosition(55, j + 2);
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            if (key2.Key == ConsoleKey.Enter)
                            {
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.ContainsKey(); break;
                                    case 2: a.ContainsValue(); break;
                                    case 3: a.Keys(); break;
                                    case 4: a.Values(); break;
                                    case 5: a.Remove(); break;
                                    case 6: a.Clear(); break;
                                    case 7: break;
                                }
                                if (j == 8)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 9, key2);
                        }
                    }
                    if (i == 2)
                    {
                        Queue1 a = new Queue1();
                        j = 0;
                        while(true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t - Queue - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            a.Print();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов"); //Enqueue()
                            Console.WriteLine("2. Наличие объекта"); //Contains
                            Console.WriteLine("3. Удаление объекта в начале очереди"); //Dequeue
                            Console.WriteLine("4. Объект в начале очереди"); //Peek
                            Console.WriteLine("5. Очистить очередь"); //Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(55, j + 4);
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            if (key2.Key == ConsoleKey.Enter)
                            {
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.Contains(); break;
                                    case 2: a.Dequeue(); break;
                                    case 3: a.Peek(); break;
                                    case 4: a.Clear(); break;
                                    case 5: break;
                                }
                                if (j == 6)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 7, key2);
                        }
                    }
                    if (i == 3)
                    {
                        Stack1 a = new Stack1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t - Stack - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            a.Print();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов"); //Push
                            Console.WriteLine("2. Наличие объекта"); //Contains
                            Console.WriteLine("3. Верхний объект в стеке"); // Peek
                            Console.WriteLine("4. Удаление элемента в начале стека"); // Pop
                            Console.WriteLine("5. Очистить стек"); // Clear
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("6. Задача");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(55, j + 4);
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            if (key2.Key == ConsoleKey.Enter)
                            {
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.Contains(); break;
                                    case 2: a.Peek(); break;
                                    case 3: a.Pop(); break;
                                    case 4: a.Clear(); break;
                                    case 5: a.Task(); break;
                                }
                                if (j == 7)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 8, key2);
                        }
                    }
                    if (i == 4)
                    {
                        Dictionary1 a = new Dictionary1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t - Dictionary - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("1. Заполнение элементов"); //Add
                            Console.WriteLine("2. Добавление пары ключ-значение"); //TryAdd
                            Console.WriteLine("3. Наличие ключа"); //ContainsKey
                            Console.WriteLine("4. Наличие значения"); //ContainsValue
                            Console.WriteLine("5. Удаление элемента по ключу"); //Remove
                            Console.WriteLine("6. Получение значения по ключу"); //TryGetValue
                            Console.WriteLine("7. Первый и последний элемент словаря"); //First Last
                            Console.WriteLine("8. Очищение словаря"); //Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            a.Print();
                            Console.SetCursorPosition(40, j + 2);
                            ConsoleKeyInfo key2 = Console.ReadKey();
                            if (key2.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.TryAdd(); break;
                                    case 2: a.ContainsKey(); break;
                                    case 3: a.ContainsValue(); break;
                                    case 4: a.Remove(); break;
                                    case 5: a.TryGetValue(); break;
                                    case 6: a.FirstLast(); break;
                                    case 7: a.Clear(); break;
                                    case 8: break;
                                }
                                if (j == 9)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 10, key2);
                        }
                    }
                    if (i == 5)
                    {
                        List1 a = new List1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t\t\t - List - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            a.Print();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов");
                            Console.WriteLine("2. Изменение порядка элементов"); //Reverse (сколько элементов начиная с какого индекса)
                            Console.WriteLine("3. Бинарный поиск"); //BinarySearch
                            Console.WriteLine("4. Подмножество элементов исходного списка"); //GetRange()
                            Console.WriteLine("5. Наличие элемента, удовлетворяющего условию"); // Exists(predicate<> match)
                            Console.WriteLine("6. Поиск элемента(ов),удовл. условию "); //Find FindLast FindAll
                            Console.WriteLine("7. Поиск индекса элемента"); //IndexOf() LastIndexOf
                            Console.WriteLine("8. Вставка коллекции в текущий список"); // insertRange()
                            Console.WriteLine("9. Удаление элементов "); // remove() removeAt() removeAll()
                            Console.WriteLine("10. Очищение списка"); // Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(55, j + 4);
                            ConsoleKeyInfo key1 = Console.ReadKey();
                            if (key1.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.Reverse(); break;
                                    case 2: a.BinarySearch(); break;
                                    case 3: a.GetRange(); break;
                                    case 4: a.Exists(); break;
                                    case 5: a.Find(); break;
                                    case 6: a.IndexOf(); break;
                                    case 7: a.Insert(); break;
                                    case 8: a.Remove(); break;
                                    case 9: a.Clear(); break;
                                    case 10: break;
                                }
                                if (j == 11)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 12, key1);
                        }
                    }
                    if (i == 6)
                    {
                        SortedList1 a = new SortedList1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t\t - SortedList - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("1. Заполнение/добавление элементов");
                            Console.WriteLine("2. Наличие ключа"); // ContainsKey
                            Console.WriteLine("3. Наличие значения"); //ContainsValue
                            Console.WriteLine("4. Ключ по индексу"); // GetKey
                            Console.WriteLine("5. Все ключи коллекции"); //GetKeyList
                            Console.WriteLine("6. Значение по индексу"); //GetByIndex
                            Console.WriteLine("7. Все значения коллекции"); //GetValueList
                            Console.WriteLine("8. Замена значения по индексу"); // SetByIndex
                            Console.WriteLine("9. Поиск индекса ключа/значения"); // IndexOfValue IndexOfKey
                            Console.WriteLine("10. Очищение списка"); // Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            a.Print();
                            Console.SetCursorPosition(40, j + 2);
                            ConsoleKeyInfo key1 = Console.ReadKey();
                            if (key1.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.ContainsKey(); break;
                                    case 2: a.ContainsValue(); break;
                                    case 3: a.GetKey(); break;
                                    case 4: a.GetKeyList(); break;
                                    case 5: a.GetValue(); break;
                                    case 6: a.GetValueList(); break;
                                    case 7: a.SetByIndex(); break;
                                    case 8: a.Index(); break;
                                    case 9: a.Clear(); break;
                                    case 10: break;
                                }
                                if (j == 11)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 12, key1);
                        }
                    }
                    if (i == 7)
                    {
                        HashSet1 a = new HashSet1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t\t\t - HashSet - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            a.Print();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов множества set2");
                            Console.WriteLine("2. Содержимое set1 после вычитания set2");
                            Console.WriteLine("3. Пересечение set1 и set2");
                            Console.WriteLine("4. set1 - подмножество set2 ???");
                            Console.WriteLine("5. Имеются ли в set1 и set2 общие элементы?");
                            Console.WriteLine("6. set1 = set2 ???");
                            Console.WriteLine("7. Симметрическая разность set1 и set2");
                            Console.WriteLine("8. Объединение set1 с set2");
                            Console.WriteLine("9. Удаление элементов в set2");
                            Console.WriteLine("10. Очищение set2"); // Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(55, j + 5);
                            ConsoleKeyInfo key1 = Console.ReadKey();
                            if (key1.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.ExceptWith(); break;
                                    case 2: a.IntersectWith(); break;
                                    case 3: a.IsSubsetOf(); break;
                                    case 4: a.Overlaps(); break;
                                    case 5: a.SetEquals(); break;
                                    case 6: a.SymmetricExceptWith(); break;
                                    case 7: a.UnionWith(); break;
                                    case 8: a.Remove(); break;
                                    case 9: a.Clear(); break;
                                    case 10: break;
                                }
                                if (j == 11)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 12, key1);
                        }
                    }
                    if (i == 8)
                    {
                        SortedSet1 a = new SortedSet1();
                        j = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\t\t\t\t\t\t\t - HashSet - ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            a.Print();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1. Заполнение/добавление элементов set2");
                            Console.WriteLine("2. Объединение множеств");
                            Console.WriteLine("3. Пересечение множеств");
                            Console.WriteLine("4. Исключение разноименности множеств");
                            Console.WriteLine("5. set1 - строгое подмножество set2 ???");
                            Console.WriteLine("6. Подмножество между двумя значениями"); //GetViewBetween
                            Console.WriteLine("7. Удаление элементов в set2");
                            Console.WriteLine("8. Очищение списка"); // Clear
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("Вернуться в меню? (да - Enter)"); 
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(55, j + 5);
                            ConsoleKeyInfo key1 = Console.ReadKey();
                            if (key1.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                switch (j)
                                {
                                    case 0: a.Vvod(); break;
                                    case 1: a.UnionWith(); break;
                                    case 2: a.IntersectWith(); break;
                                    case 3: a.SymmetricExceptWith(); break;
                                    case 4: a.IsProperSubset(); break;
                                    case 5: a.GetViewBetween(); break;
                                    case 6: a.Remove(); break;
                                    case 7: a.Clear(); break;
                                    case 8: break;
                                }
                                if (j == 9)
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            j = Move(j, 10, key1);
                        }
                    }
                }
                i = Move(i, 9, key);
            }
        }
    }
}