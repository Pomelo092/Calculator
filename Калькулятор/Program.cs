while (true)
{
    Console.WriteLine("Введите первое число:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите знак действия(+, -, *, /, !, sqrt):");
    string znak = Console.ReadLine();

    switch (znak)
    {
        case "+":
            Console.WriteLine(a + b);
            break;
        case "-":
            Console.WriteLine(a - b);
            break;
        case "*":
            Console.WriteLine(a * b);
            break;
        case "/":
            Console.WriteLine(a / b);
            break;
        case "!":
            Console.WriteLine("Факториал какого числа - первого, или второго(1 или 2)?");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo == 1)
            {
                chislo = a;
            }
            else if (chislo == 2)
            {
                chislo = b;
            }
            else
            {
                Console.WriteLine("Неверное значение!");
                break;
            }

            long fact = 1;
            for (int i = 1; i <= chislo; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            break;
        case "sqrt":
            Console.WriteLine("Квадратный корень какого числа - первого, или второго(1 или 2)?");
            int chislo2 = int.Parse(Console.ReadLine());
            if (chislo2 == 1)
            {
                chislo2 = a;
            }
            else if (chislo2 == 2)
            {
                chislo2 = b;
            }
            else
            {
                Console.WriteLine("Неверное значение!");
                break;
            }
            Console.WriteLine(Math.Sqrt(chislo2));
            break;

        default:
            Console.WriteLine("Невозможное действие!");
            break;
    }
}
