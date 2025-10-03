using System;

class Dz
{
    public static void Main(string[] args)
    {
        Dz dz = new Dz();

        //////////////////////////////
        Console.WriteLine("Задание 1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.");
        Console.WriteLine($"Число e = {Math.Round(Math.E, 1)}\n\n");
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("Задание 2. Вывести на экран числа 50 и 10 одно под другим");
        Console.WriteLine(50);
        Console.WriteLine(10);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 3. Составить программу вывода на экран «столбиком» четырех случайных чисел.");
        dz.PrintRandomNums();
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 4. Пользователь вводит число. Выведите на экран число, которое больше\r\nвведенного на 10.");
        Console.Write("Введите число: ");
        int.TryParse(Console.ReadLine(), out int num);
        Console.WriteLine($"Число большее исходного на 10: {num + 10}");
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 5. Найти значение y=cos(x)");
        Console.Write("Введите значение x: ");
        int.TryParse(Console.ReadLine(), out int x);
        Console.WriteLine($"Косинус равен: {Math.Cos(x)}");
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 6. Даны основания и высота равнобедренной трапеции. Найти ее периметр.");
        Console.WriteLine($"Периметр равен: {dz.CalculatePerimetr()}");
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 7. Напишите программу, выводит на экран три строки \"Мир\", \"Труд\" и \"Май\"\r\n(кавычки не нужны). ");
        Console.WriteLine("Мир Труд Май");
        Console.WriteLine("Мир\n\tТруд\n\t\tМай");
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 8. Программа просит пользователя ввести 2 числовые переменные. А после она\r\nменяет их местами и выводит результат на экран.");
        dz.ChangeValuesOfTwoVariables();
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 9. Составить программу вывода на экран числа, вводимого с клавиатуры.\r\nВводимому числу должно предшествовать сообщение «Вы ввели число».\r\n");
        Console.Write($"Вы ввели число: ");
        int.TryParse(Console.ReadLine(), out int digit);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 10.  Найти корни квадратного уравнения(коэффициента задаются пользователем с\r\nклавиатуры)\r\n");
        dz.QuadraticEquation();
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 11. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее\r\nгеометрическое.\r\n");
        dz.CalculateArithmeticMeanAndGeometricMean(1, 5);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 12. Известны координаты на плоскости двух точек. Составить программу\r\nвычисления расстояния между ними.\r\n");
        dz.CalculateDistanceBetweenTwoPoints(4, 1, 0, 2);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 13. Составить программу обмена значениями трех переменных величин а, b, c по\r\nследующим двум схемам:\r\nа) b присвоить значение c, а присвоить значение b, с присвоить значение а;\r\nб) b присвоить значение а, с присвоить значение b, а присвоить значение с.");
        dz.AssignValues(4, 2, 1);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 14. С начала суток прошло n секунд. Определить:\r\nа) сколько полных часов прошло с начала суток;\r\nб) сколько полных минут прошло с начала очередного часа;\r\nв) сколько полных секунд прошло с начала очередной минуты");
        dz.CalculateHoursMinutesSeconds(1000);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 15. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной\r\n130 мм можно отрезать от него?\r\n");
        dz.CalculateSquaresFromRectangle(543, 130, 130);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 16. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и\r\nприписали ее в начале. Найти полученное число.\r\n");
        dz.FindNewNum(321);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 17. Дано натуральное число n (n > 999). Найти:\r\nа) число сотен в нем;\r\nб) число тысяч в нем.");
        dz.FindHundredAndThousandsInNum(1424);
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 18.  Составить программу, которая:\r\nа) запрашивает имя человека и повторяет его на экране;\r\nб) запрашивает имя человека и повторяет его на экране с приветствием.");
        dz.Echo();
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 19. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь\r\nздоровается с консолью. Консоль спрашивает, как зовут пользователя.\r\nПользователь называет имя. Консоль пишет: привет, <имя пользователя>. После\r\nэтого пользователь спрашивает, знает ли консоль что-то о тайной комнате.\r\nКонсоль отвечает «Да». После этого пользователь спрашивает, может ли\r\nрассказать. Консоль отвечает «Нет». Спустя 5 секунд консоль дополняет «но\r\nмогу показать». Консоль меняет цвет на любой случайный цвет.\n");
        dz.PrintConversationWithTomRiddle();
        //////////////////////////////

        //////////////////////////////
        Console.WriteLine("\nЗадание 20. Вычислить контрольную цифру штрихкода(EAN13).\r\na. 12 цифр определяются случайным образом.\r\nb. 12 цифр вводит пользователь");
        dz.CalculateControlDigit();
        //////////////////////////////


    }

    void PrintRandomNums() // метод для вывода 4 рандомных чисел
    {
        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(random.Next(-1000, 1000));
        }
    }

    double CalculatePerimetr() // метод, который вычисляет периметр равнобедренной трапеции
    {
        Console.Write("Введите нижнее основание: ");
        double.TryParse(Console.ReadLine(), out double baseDown); // baseDown хранит в себе значение нижнего основания

        Console.Write("Введите верхнее основание: ");
        double.TryParse(Console.ReadLine(), out double baseUp); // baseUp хранит в себе значение верхнего основания

        Console.Write("Введите высоту: ");
        double.TryParse(Console.ReadLine(), out double h); // h хранит в себе высоту 

        double temp = (baseDown - baseUp) / 2; 
        double side = Math.Round(Math.Sqrt(temp * temp + h * h), 2); // сторона равнобедренной трапеции

        return side * 2 + baseDown + baseUp; 
    }

    void ChangeValuesOfTwoVariables() // метод, который меняет местами значения двух переменных
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); //Получаем 1 число от пользователя

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // Получаем 2 число от пользователя

        double numAdditional = num2; // Создал промежуточную переменную для того, чтобы поместить в нее значение num1

        num2 = num1; // Передал num2 значение num1
        num1 = numAdditional; // передал num1 значение промежуточной переменной

        Console.WriteLine("Первое число(num1) = " + num1 + "\nВторое число(num2) = " + num2);
    }

    void QuadraticEquation() // метод, который решает квадратное уравнение
    {
        // уравнение вида Ax^2 + Bx + C = 0, где A, B, C - задаются пользователям

        Console.Write("Введите коэфф. А: ");
        double a = double.Parse(Console.ReadLine()); // коэфф A

        Console.Write("Введите коэфф. B: ");
        double b = double.Parse(Console.ReadLine()); // коэфф B

        Console.Write("Введите коэфф. C: ");
        double c = double.Parse(Console.ReadLine()); // коэфф C

        double D = Math.Pow(b, 2) - 4 * a * c; // по формуле дискриминанта D = b^2 - 4ac

        if (D > 0)
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a); // первый корень квадрат. уравнения
            double x2 = (-b + Math.Sqrt(D)) / (2 * a); // второй корень квадрат. уравнения

            Console.WriteLine($"Первый корень уравнения: {Math.Round(x1, 2)}\nВторой корень уравнения:{Math.Round(x2, 2)}");

        }
        else if (D == 0)
        {
            double x = -b / (2 * a); // единственный корень квадратного уравнения
            Console.WriteLine($"Дискриминант равен 0, единственный корень: {x}");
        }
        else // в единственном случае, если D < 0
        {
            Console.WriteLine("Корней нет!");
        }
    }

    void CalculateArithmeticMeanAndGeometricMean(double a, double b) // метод, который считает среднее арифметическое и геометрическое двух чисел
    {
        Console.WriteLine("Среднее арифметическое: " + (Math.Round(a + b) / 2));
        Console.WriteLine("Среднее геометрическое: " + (Math.Round(Math.Sqrt(a * b))));
    }

    void CalculateDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2) // метод, который считает расстояние между двумя точками
    {
        Console.Write("Расстояние между двумя точками: " + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
    }

    void AssignValues(int a, int b, int c) // метод, который переобозначает значения переменных
    {
        Console.Write("Введите номер схемы(a/b): ");
        if (Console.ReadLine().ToLower().Equals("a"))
        {
            b = c;
            a = b;
            c = a;
            Console.WriteLine("a = " + a + "\nb = " + b + "\nc = " + c);
        }
        else
        {
            b = a;
            c = b;
            a = c;
            Console.WriteLine("a = " + a + "\nb = " + b + "\nc = " + c);
        }
    }

    void CalculateHoursMinutesSeconds(int n) // метод, который считает сколько полных часов, полных минут и полных секунд прошло по заданному количеству секунд
    {
        Console.WriteLine("Полных часов: " + n / 3600); // Взяли целое число в результате деления

        double seconds = n % 3600; // Сколько секунд осталось после последнего часа
        Console.WriteLine("Полных минут:  " + Math.Floor(seconds / 60));

        Console.WriteLine("Полных секунд: " + seconds % 60);

    }

    void CalculateSquaresFromRectangle(int width, int heigth, int side)
    {
        int areaOfRectangle = width * heigth; // площадь прямоугольника
        int areaOfSquare = side * side; // площадь квадрата

        Console.WriteLine("Можно отрезать " + areaOfRectangle / areaOfSquare + " квадрата");
    }

    void FindNewNum(int num)
    {
        string stringNum = Convert.ToString(num);
        char lastNumChar = stringNum[stringNum.Length - 1]; // Сохраняем последнюю цифру

        stringNum = stringNum.Remove(stringNum.Length - 1); // Удаляем последнюю цифру из строки

        Console.WriteLine(Convert.ToInt32(lastNumChar + stringNum)); // Склеиваем строки и конвертируем в число
    }
    void FindHundredAndThousandsInNum(int num)
    {
        Console.WriteLine("В этом числе сотен: " + num / 100 + ", а тысяч: " + num / 1000);
    }
    void Echo()
    {
        Console.Write("Введите свое имя: ");
        string name = Console.ReadLine();

        Console.WriteLine(name);

        Console.WriteLine($"Привет! {name}");
    }


    /*
     Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь
    здоровается с консолью. Консоль спрашивает, как зовут пользователя.
    Пользователь называет имя. Консоль пишет: привет, <имя пользователя>. После
    этого пользователь спрашивает, знает ли консоль что-то о тайной комнате.
    Консоль отвечает «Да». После этого пользователь спрашивает, может ли
    рассказать. Консоль отвечает «Нет». Спустя 5 секунд консоль дополняет «но
    могу показать». Консоль меняет цвет на любой случайный цвет.
     */
    void PrintConversationWithTomRiddle()
    {
        Random random = new Random();
        Console.WriteLine("Пользователь: Привет, консоль!");
        Console.WriteLine("Консоль: Как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Консоль: Привет, {name}");
        Console.WriteLine("Пользователь: Знаешь ли ты что-то о тайной комнате?");
        Console.WriteLine("Консоль: Да");
        Console.WriteLine("Пользователь: Можешь рассказать?");
        Console.WriteLine("Консоль: Нет");
        Thread.Sleep(5000);
        Console.WriteLine("Консоль: Но могу показать");
        Console.ForegroundColor = (ConsoleColor)random.Next(0, 15);
        Console.WriteLine("Смена цвета;)");
        Console.ResetColor(); 
    }


    /*
    Алгоритм расчёта контрольной цифры:
        Сложить все цифры на нечётных позициях(1-я, 3-я, 5-я и т.д.).
        Сложить все цифры на чётных позициях, умножить сумму на 3.
        Сложить полученные результаты.
        Найти ближайшее большее число, кратное 10.
        Контрольная цифра — разность между этим числом и суммой.
     */
    private void CalculateControlDigit()
    {
        int[] barcode = new int[12]; // массив для хранения цифр штрихкода
        int digit; // переменная, в которой будет храниться контрольная цифра
        Console.WriteLine("Введите по цифрам штрихкод");

        for (int i = 0; i < barcode.Length; i++)
        {
            barcode[i] = Convert.ToInt32(Console.ReadLine()); // Заполняем массив цифрами от пользователя
        }

        int sum1 = 0; // промежуточная переменная, необходимая для сложения нечетных позиций
        int sum2 = 0; // промежуточная переменная, необходимая для сложения четных позиций

        for (int i = 0; i < barcode.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum1 += barcode[i];
            }
            else if (i != 0)
            {
                sum2 += barcode[i];
            }
        }

        //Console.WriteLine(sum2); // для отладки
        sum2 = sum2 * 3;

        //Console.WriteLine(sum2); // для отладки

        int sum = sum2 + sum1; // переменная для суммы нечетных и четных сумм

        //Console.WriteLine(sum); // для отладки

        int tempVar = Convert.ToInt32(Math.Floor((double)(sum + 9) / 10) * 10); // Танец с бубном и мы получаем ближайшее верхнее число, кратное 10

        //Console.WriteLine(tempVar); // для отладки

        Console.WriteLine($"Контрольная цифра: {tempVar - sum}");
    }
}