using System;

class TumakovDz
{
    public static void Main(string[] args)
    {
        TumakovDz tumakovDz = new TumakovDz();

        Print("Упражнение 2.1 Написать программу, которая спрашивает имя\r\nпользователя, и затем приветствует пользователя по имени. (Создать\r\nконсольное приложение.)\n\n");
        Print(tumakovDz.AskUserName()); // печатаем текст, который возвращается методом


        Print("Упражнение 2.2 Написать программу, которой на вход подается два\r\nцелых числа, на выходе – результат деления одного числа на другое.\r\nПредусмотреть обработку исключительной ситуации, возникающей при\r\nделении числа на ноль.\n\n");
        
        Print("Введите число a: ");
        int num1 = int.Parse(Console.ReadLine()); // получаем первое число от пользователя
        Print("Введите число b: ");
        int num2 = int.Parse(Console.ReadLine()); // получаем второе число от пользователя

        if (num2 == 0)
        {
            Print("Делить на ноль нельзя!\n\n"); // можно было выбрасывать и ловить ошибку DivideByZeroException, но можно обойтись и обычным условием
        } else
        {
            Print($"Результат от деления: {num1 / num2}\n\n"); // выводим результат деления первого числа на другое
        }


        Print("Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать\r\nследующую за ней букву в алфавитном порядке.\n\n");
        tumakovDz.Alphabet(); // вызов метода с алфавитом

        Print("Домашнее задание 2.2 Написать программу, которая решает квадратное\r\nуравнение. Входные данные – коэффициенты уравнения, выходные –\r\nнайденные корни.\n\n");
        tumakovDz.QuadraticEquation();
    }

    string AskUserName()
    {
        Print("Введите свое имя: ");
        
        string name = Console.ReadLine(); // получаем имя пользователя 

        return $"Привет, {name}\n\n"; // возращаем строку с приветствием 
    }

    void Alphabet()
    {
        Print("Введите букву в En: ");
        string[] alphabetEn = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]; // список ENG алфавита
        string letter = Console.ReadLine().ToLower(); // храним букву от пользователя

        for (int i = 0; i < alphabetEn.Length; i++)
        {
            if (alphabetEn[i].Equals(letter))
            {
                if (i == (alphabetEn.Length - 1)) // на случай, чтобы не выйти за пределы массива я его зациклил, чтобы при вводе буквы Z выводилась следующей A
                {
                    Print(alphabetEn[0]);
                }
                else
                {
                    Print("Буква: " + alphabetEn[i + 1] + "\n");  // выводим следующую букву по алфавиту
                }

            }
        }
    }

    void QuadraticEquation()
    {
        // уравнение вида Ax^2 + Bx + C = 0, где A, B, C - задаются пользователям

        Print("Введите коэфф. А: ");
        double a = double.Parse(Console.ReadLine()); // коэфф A

        Print("Введите коэфф. B: ");
        double b = double.Parse(Console.ReadLine()); // коэфф B

        Print("Введите коэфф. C: ");
        double c = double.Parse(Console.ReadLine()); // коэфф C

        double D = Math.Pow(b, 2) - 4 * a * c; // по формуле дискриминанта D = b^2 - 4ac

        if (D > 0)
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a); // первый корень квадрат. уравнения
            double x2 = (-b + Math.Sqrt(D)) / (2 * a); // второй корень квадрат. уравнения

            Print($"Первый корень уравнения: {Math.Round(x1, 2)}\nВторой корень уравнения:{Math.Round(x2, 2)}");

        } else if (D == 0)
        {
            double x = -b / (2 * a); // единственный корень квадратного уравнения
            Print($"Дискриминант равен 0, единственный корень: {x}");
        }
        else // в единственном случае, если D < 0
        {
            Print("Корней нет!");
        }
    }


    static void Print(string text) // метод для удобной печати текста
    {
        Console.Write(text);
    }
}