//zadanie 1
// PrintLine();
// System.Console.WriteLine("privet");
// PrintLine();
//zadanie 2.1
// System.Console.WriteLine(sum(20, 10));
// System.Console.WriteLine(sum(15, 30));
//zadanie 2.2
// System.Console.WriteLine(IsEven(12));
// System.Console.WriteLine(IsEven(21));
//zadanie 3
// int[] marks = { 5, 3, 2, 1, 6 };
// System.Console.WriteLine(Average(marks));
// int[] qwe = { 120, 45, 300, 80, 15, 210 };
// System.Console.WriteLine(CountGreater(qwe, 100));
// System.Console.WriteLine(Average(qwe));
//zadanie 4
// System.Console.WriteLine(ToFahrenheit(0));
// System.Console.WriteLine(ToFahrenheit(100));
// System.Console.WriteLine(ToFahrenheit(37));
//zadanie 5
// System.Console.WriteLine(Factorial(5));

// Итоговая задача. Меню-калькулятор

while (true)
{
    Console.WriteLine("Меню:");
    Console.WriteLine("1 — сумма двух чисел");
    Console.WriteLine("2 — большее из двух чисел");
    Console.WriteLine("3 — факториал");
    Console.WriteLine("0 — выход");
    Console.Write("Выберите пункт: ");
    string choice = Console.ReadLine();

    if (choice == "0")
    {
        Console.WriteLine("Выход из программы.");
        break;
    }

    switch (choice)
    {
        case "1":
        {
            int a = ReadPositive("Введите первое число: ");
            int b = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Сумма = {Sum(a, b)}");
            break;
        }
        case "2":
        {
            int a = ReadPositive("Введите первое число: ");
            int b = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Большее = {Max(a, b)}");
            break;
        }
        case "3":
        {
            int n = ReadPositive("Введите число для факториала: ");
            Console.WriteLine($"{n}! = {Factorial(n)}");
            break;
        }
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}


static int ReadPositive(string message)
{
    int value;
    do
    {
        Console.Write(message);
        value = int.Parse(Console.ReadLine());
    } while (value <= 0);

    return value;
}
static long Factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}
static int CountGreater(int[] arr, int limit)
{
    int t = 0;
    foreach (int i in arr)
    {
        if (i > limit)
        {
            t++;
        }
    }
    return t;
}
static double Average(int[] arr)
{
    double sum = 0.0;
    double total = 0.0;
    foreach (int x in arr)
    {
        sum += x;
        total++;
    }
    return sum / total;
}
static bool IsEven(int n)
{
    return n % 2 == 0;
}

static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
static int Sum(int a, int b)
{
    return a + b;
}
