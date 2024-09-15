using System;
using System.Text;

public class Program
{
    public class Tipy
    {

        public static void a()
        {
            // a. Примитивные типы

            Console.WriteLine("*** Примитивные типы ***");

            // Целочисленные типы
            sbyte mySbyte = 10;
            byte myByte = 255;
            short myShort = 32767;
            ushort myUShort = 65535;
            int myInt = 2147483647;
            uint myUInt = 4294967295;
            long myLong = 9223372036854775807;
            ulong myULong = 18446744073709551615;

            // Дробные типы
            float myFloat = 3.14f;
            double myDouble = 3.14159265358979323846;
            decimal myDecimal = 3.14159265358979323846m;

            // Логический тип
            bool myBool = true;

            // Символьный тип
            char myChar = 'A';

            // Строковый тип
            string myString = "Hello, World!";

            // Ввод и вывод значений
            Console.WriteLine($"sbyte: {mySbyte}");
            Console.WriteLine($"byte: {myByte}");
            Console.WriteLine($"short: {myShort}");
            Console.WriteLine($"ushort: {myUShort}");
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine($"uint: {myUInt}");
            Console.WriteLine($"long: {myLong}");
            Console.WriteLine($"ulong: {myULong}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"decimal: {myDecimal}");
            Console.WriteLine($"bool: {myBool}");
            Console.WriteLine($"char: {myChar}");
            Console.WriteLine($"string: {myString}");

            Console.WriteLine();

            Console.Write("Введите значение для sbyte: ");
            mySbyte = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine($"sbyte: {mySbyte}");

            Console.Write("Введите значение для byte: ");
            myByte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"byte: {myByte}");

            Console.Write("Введите значение для short: ");
            myShort = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"short: {myShort}");

            Console.Write("Введите значение для ushort: ");
            myUShort = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"ushort: {myUShort}");

            Console.Write("Введите значение для int: ");
            myInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"int: {myInt}");

            Console.Write("Введите значение для uint: ");
            myUInt = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"uint: {myUInt}");

            Console.Write("Введите значение для long: ");
            myLong = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"long: {myLong}");

            Console.Write("Введите значение для ulong: ");
            myULong = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"ulong: {myULong}");

            // Дробные типы
            Console.Write("Введите значение для float: ");
            myFloat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"float: {myFloat}");

            Console.Write("Введите значение для double: ");
            myDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"double: {myDouble}");

            Console.Write("Введите значение для decimal: ");
            myDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"decimal: {myDecimal}");

            // Логический тип
            Console.Write("Введите значение для bool (true/false): ");
            myBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"bool: {myBool}");

            // Символьный тип
            Console.Write("Введите значение для char: ");
            myChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"char: {myChar}");

            // Строковый тип
            Console.Write("Введите значение для string: ");
            myString = Console.ReadLine();
            Console.WriteLine($"string: {myString}");
        }
        public static void b()
        {
            // b. Приведение типов
            Console.WriteLine("*** Приведение типов ***");

            // Явное приведение
            Console.WriteLine("Явное приведение:");
            double d = 10.5;
            int i = (int)d; // Явное приведение double к int
            Console.WriteLine($"double: {d}, int: {i}");

            // Неявное приведение
            Console.WriteLine("Неявное приведение:");
            int i2 = 10;
            double d2 = i2; // Неявное приведение int к double
            Console.WriteLine($"int: {i2}, double: {d2}");

            // Класс Convert
            Console.WriteLine("Класс Convert:");
            string str = "123";
            int i3 = Convert.ToInt32(str); // Преобразование строки в целое число
            Console.WriteLine($"string: {str}, int: {i3}");

            Console.WriteLine();
        }
        public static void c()
        {
            // c. Упаковка и распаковка
            Console.WriteLine("*** Упаковка и распаковка ***");

            int i4 = 10;
            object obj = i4; // Упаковка
            int i5 = (int)obj; // Распаковка

            Console.WriteLine($"int: {i4}, object: {obj}, int: {i5}");

            Console.WriteLine();
        }
        public static void d()
        {
            // d. Неявно типизированная переменная
            Console.WriteLine("*** Неявно типизированная переменная ***");
            var myVar = 10; // Тип myVar будет определен как int
            Console.WriteLine($"myVar: {myVar}");
        }

        public static void e()
        {
            // e. Nullable переменные
            Console.WriteLine("*** Nullable переменные ***");

            int? myNullableInt = null; // Nullable int

            if (myNullableInt.HasValue)
            {
                Console.WriteLine($"myNullableInt: {myNullableInt.Value}");
            }
            else
            {
                Console.WriteLine("myNullableInt is null.");
            }

            myNullableInt = 15;
            Console.WriteLine($"myNullableInt: {myNullableInt}");

            Console.WriteLine();
        }
        public static void f()
        {
            // f. Переменная var
            Console.WriteLine("*** Переменная var ***");
            var myVar2 = 10; // Тип myVar2 будет определен как int
            Console.WriteLine($"myVar2: {myVar2}");

            //myVar2 = "Hello"; // Ошибка! Невозможно присвоить строку переменной типа int
            //Console.WriteLine($"myVar2: {myVar2}");

            Console.WriteLine("Ошибка: 'var' переменные должны быть инициализированы один раз, и их тип фиксируется при инициализации.");
            Console.WriteLine("Попытка присвоить значение другого типа после инициализации приводит к ошибке компиляции.");
        }

    }

    public class Str
    {
        public static void a()
        {
            // a. Строковые литералы
            string str1 = "Hello, world!";
            string str2 = "Hello, world!";
            string str3 = "Hello, World!";

            Console.WriteLine($"str1 == str2: {str1 == str2}"); // True
            Console.WriteLine($"str1 == str3: {str1 == str3}"); // False (регистрозависимое сравнение)
        }
        public static void b() 
        {
            // b. String: создание, операции
            string str4 = "This is a string.";
            string str5 = "Another string";

            // Сцепление
            string str6 = str4 + " " + str5;
            Console.WriteLine(str6); // This is a string. Another string

            // Копирование
            string str7 = str4.Substring(0, 6);
            Console.WriteLine(str7); // This i

            // Выделение подстроки
            string str8 = str4.Substring(5);
            Console.WriteLine(str8); // is a string.

            // Разделение на слова
            string[] words = str4.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка подстроки
            string str9 = str4.Insert(5, "awesome ");
            Console.WriteLine(str9); // This is awesome a string.

            // Удаление подстроки
            string str10 = str4.Remove(5, 5);
            Console.WriteLine(str10); // This a string.

            // Интерполирование строк
            string name = "John";
            int age = 30;
            string greeting = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(greeting);
        }
        public static void c()
        {
            // c. Пустые и null строки
            string emptyString = "";
            string nullString = null;

            Console.WriteLine($"emptyString: {emptyString}"); // ""
            Console.WriteLine($"nullString: {nullString}"); // Null

            Console.WriteLine($"IsNullOrEmpty(emptyString): {string.IsNullOrEmpty(emptyString)}"); // True
            Console.WriteLine($"IsNullOrEmpty(nullString): {string.IsNullOrEmpty(nullString)}"); // True

            // Можно выполнить:
            // - сравнение с другими строками
            // - проверка на пустоту с помощью string.IsNullOrEmpty или string.IsNullOrWhiteSpace
            // - преобразование в другие типы данных (если позволяет контекст)
        }
        public static void d()
        {
            // d. StringBuilder
            StringBuilder sb = new StringBuilder("Hello");

            // Удаление символов
            sb.Remove(1, 2); // Удаляет "el"
            Console.WriteLine(sb); // Ho

            // Добавление символов в начало и конец
            sb.Insert(0, "W");
            sb.Append("!");
            Console.WriteLine(sb); // WHo! 
        }
    }

    public class Array
    {
        public static void a()
        {
            // a. Двумерный массив
            int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Двумерный массив (матрица):");
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void b()
        {
            // b. Одномерный массив строк
            string[] strArray = { "Первый", "Второй", "Третий" };
            Console.Write("Одномерный массив строк: ");
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Длина массива: " + strArray.Length);

            Console.Write("Введите позицию элемента для изменения (от 0 до " + (strArray.Length - 1) + "): ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите новое значение: ");
            string newValue = Console.ReadLine();
            strArray[index] = newValue;
            Console.Write("Измененный массив: ");
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void c()
        {
            // c. Ступечатый массив вещественных чисел
            double[][] doubleArray = new double[3][];
            doubleArray[0] = new double[2];
            doubleArray[1] = new double[3];
            doubleArray[2] = new double[4];

            Console.WriteLine("Ступечатый массив (не выровненный):");
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                Console.Write("Введите " + doubleArray[i].Length + " вещественных чисел для строки " + (i + 1) + ": ");
                for (int j = 0; j < doubleArray[i].Length; j++)
                {
                    doubleArray[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray[i].Length; j++)
                {
                    Console.Write(doubleArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void d()
        {
            // d. Неявно типизированные переменные
            var intArray2 = new int[] { 10, 20, 30 };
            var str = "Это строка";
            Console.WriteLine("Неявно типизированные переменные:");
            Console.WriteLine("Массив: " + string.Join(", ", intArray2));
            Console.WriteLine("Строка: " + str);
        }
    }

    public static void Tuple()
    {
        // a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
        (int, string, char, string, ulong) myTuple = (10, "Hello", 'A', "World", 1234567890);

        // b. Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4  элементы)
        Console.WriteLine($"Кортеж целиком: {myTuple}");
        Console.WriteLine($"1-й элемент: {myTuple.Item1}");
        Console.WriteLine($"3-й элемент: {myTuple.Item3}");
        Console.WriteLine($"4-й элемент: {myTuple.Item4}");

        // c. Выполните распаковку кортежа в переменные. Продемонстрируйте различные способы распаковки кортежа. Продемонстрируйте использование переменной ( _ ).
        (int first, string second, char third, string fourth, ulong fifth) = myTuple;
        Console.WriteLine($"first: {first}, second: {second}, third: {third}, fourth: {fourth}, fifth: {fifth}");

        // Распаковка с использованием _ для игнорирования некоторых элементов
        (int _, string _, char Third, string _, ulong Fifth) = myTuple;
        Console.WriteLine($"third: {Third}, fifth: {Fifth}");

        // Распаковка с использованием именованных элементов
        (int number, string greeting, char letter, string message, ulong bigNumber) = myTuple;
        Console.WriteLine($"number: {number}, greeting: {greeting}, letter: {letter}, message: {message}, bigNumber: {bigNumber}");

        // d. Сравните два кортежа
        (int, string, char, string, ulong) anotherTuple = (20, "Bye", 'B', "Universe", 9876543210);
        Console.WriteLine($"myTuple == anotherTuple: {myTuple == anotherTuple}");

        // Сравнение по элементам
        bool areEqual = myTuple.Item1 == anotherTuple.Item1 &&
                      myTuple.Item2 == anotherTuple.Item2 &&
                      myTuple.Item3 == anotherTuple.Item3 &&
                      myTuple.Item4 == anotherTuple.Item4 &&
                      myTuple.Item5 == anotherTuple.Item5;
        Console.WriteLine($"myTuple равен anotherTuple по элементам: {areEqual}");
    }

    public static void Local()
    {
        // Исходные данные
        int[] numbers = { 5, 2, 9, 1, 7 };
        string text = "Hello";

        // Вызов локальной функции
        (int max, int min, int sum, char firstLetter) = ProcessData(numbers, text);

        // Вывод результатов
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");
        Console.WriteLine($"Сумма элементов: {sum}");
        Console.WriteLine($"Первая буква строки: {firstLetter}");


        // Локальная функция
        static (int, int, int, char) ProcessData(int[] arr, string str)
        {
            // Находим максимальное и минимальное значения в массиве
            int max = arr[0];
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            // Считаем сумму элементов массива
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            // Извлекаем первую букву строки
            char firstLetter = str[0];

            // Возвращаем кортеж с результатами
            return (max, min, sum, firstLetter);
        }

    }
    public static void Main(string[] args)
    {
        // 1
        //Tipy.a();
        //Tipy.b();
        //Tipy.c();
        //Tipy.d();
        //Tipy.e();
        //Tipy.f();

        //// 2
        //Str.a();
        //Str.b();
        //Str.c();
        //Str.d();

        // 3
        //Array.a();
        //Array.b();
        //Array.c();
        //Array.d();

        //// 4
        //Tuple();

        //// 5
        //Local();

        //// 6
        CheckedFunction();
        UncheckedFunction();
    }

    static void CheckedFunction()
    {
        try
        {
            checked
            {
                int maxInt = int.MaxValue;
                Console.WriteLine("Checked: maxInt + 1 = " + (maxInt + 1));
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Checked: " + ex.Message);
        }
    }

    static void UncheckedFunction()
    {
        try
        {
            unchecked
            {
                int maxInt = int.MaxValue;
                Console.WriteLine("Unchecked: maxInt + 1 = " + (maxInt + 1));
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Unchecked: " + ex.Message);
        }
    }
}

