
//using System.Text.RegularExpressions;

//PrintTab(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Math.Cos);
//PrintTab(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Function);
//PrintTab(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x => (-Math.Pow((x / Math.PI), 2)) - 2 * x + 5 * Math.PI);
//PrintTab(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Cicle);
//PrintTab(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Function2);


//static double Function(double x)
//{
//    return 2*Math.Sqrt(Math.Abs(x - 1)) + 1;
//}

//static double Cicle(double x)
//{
//    double y = 0;
//    for (int i = 1; i < 101; i++)
//    {
//        y += Math.Pow(((x / Math.PI * i) - 1), 2);
//    }

//    return y;
//}

//static double Function2(double x)
//{
//    if (x < 0)
//    {
//        return 1 / 4 * Math.Pow(Math.Sin(x), 2) + 1;
//    }

//    else
//    {
//        return 1 / 2 * Math.Cos(x) - 1;
//    }
//}

//static int CountFunction(double a, double b, double step, Predicate<double> condition, Tabulate del)
//{
//    int count = 0;
//    for (double x = a; x <= b; x += step)
//    {
//        if (condition(del(x)))
//        {
//            count++;
//        }
//    }
//    return count;
//}

//Tabulate[] funcs = { Math.Cos, Function, x => (-Math.Pow((x / Math.PI), 2)) - 2 * x + 5 * Math.PI, Cicle, Function2 };
//double a = -2 * Math.PI;
//double b = Math.PI * 2;
//double step = Math.PI / 6;
//int minusCount = 0;
//int rangeCount = 0;
//foreach (var del in funcs)
//{
//    PrintTab(a, b, step, del);
//    minusCount += CountFunction(a, b, step, x => x < 0, del);
//    rangeCount += CountFunction(a, b, step, x => x >= -1 && x <= 1, del);
//}
//
//Console.WriteLine($"Общее количество отрицательных значений функций: {minusCount}");
//Console.WriteLine($"Общее количество значений из [-1; 1]: {rangeCount}");
//static void PrintTab(double a, double b, double dx, Tabulate del)
//{
//    for (double x = a; x <= b; x+=dx)
//    {
//        Console.WriteLine($"{x}, {del(x)}");
//    }
//}

//public delegate double Tabulate(double x);

////Задание 2

//using System.Text.RegularExpressions;

//string[] strings = { "car", "person", "water", "c-enjoyer", "VISUAL", "1234567890" };

//int CountNoUpper = strings.Count(s => Regex.IsMatch(s, "[a-z]"));
//Console.WriteLine($"Количество строк без заглавных букв: {CountNoUpper}");

//int CountTenChar = strings.Count(s => Regex.IsMatch(s, "^.{10}$"));
//Console.WriteLine($"Количество десятибуквенных строк: {CountTenChar}");

//int CountFiveLetter = strings.Count(s => Regex.IsMatch(s, "\\b\\w{5}\\b"));
//Console.WriteLine($"Количество пятибуквенных слов: {CountFiveLetter}");

//List<string> wWords = strings.Where(s => Regex.IsMatch(s, @"\b[Ww]\w*\b")).ToList();
//Console.WriteLine($"Слова, начинающиеся на 'W': {string.Join(", ", wWords)}");

//List<string> defis = strings.Where(s => Regex.IsMatch(s, @"\b\w+-\w+\b")).ToList();
//Console.WriteLine($"Слова с дефисом: {string.Join(", ", defis)}");