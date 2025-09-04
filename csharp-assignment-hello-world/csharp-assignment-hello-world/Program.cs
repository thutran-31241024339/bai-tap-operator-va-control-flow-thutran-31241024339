using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1. Operators Exercises");
            Console.WriteLine("2. Control Flow (Part 1)");
            Console.WriteLine("3. Control Flow (Part 2)");
            Console.WriteLine("0. Exit");
            Console.Write("Choose section: ");
            int section = int.Parse(Console.ReadLine());

            if (section == 0) break;

            switch (section)
            {
                case 1: OperatorsMenu(); break;
                case 2: ControlFlowMenu1(); break;
                case 3: ControlFlowMenu2(); break;
                default: Console.WriteLine("Invalid section."); break;
            }
        }
    }

    // ----------------- Operators -----------------
    static void OperatorsMenu()
    {
        Console.WriteLine("\n--- Operators Exercises ---");
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Function x = y^2+2y+1");
        Console.WriteLine("3. Speed (km/h, miles/h)");
        Console.WriteLine("4. Sphere surface & volume");
        Console.WriteLine("5. Character check");
        Console.Write("Choose (1-5): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Calculator(); break;
            case 2: DisplayFunction(); break;
            case 3: CalculateSpeed(); break;
            case 4: SphereCalc(); break;
            case 5: CheckCharacter(); break;
            default: Console.WriteLine("Invalid choice."); break;
        }
    }

    static void Calculator()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter operation (+,-,*,/): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;
        bool valid = true;
        switch (op)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/': if (b != 0) result = a / b; else { valid = false; Console.WriteLine("Cannot divide by 0"); } break;
            default: valid = false; Console.WriteLine("Invalid operator"); break;
        }
        if (valid) Console.WriteLine("Result = " + result);
    }

    static void DisplayFunction()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y={y}, x={x}");
        }
    }

    static void CalculateSpeed()
    {
        Console.Write("Enter distance (km): ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter hours: ");
        int h = int.Parse(Console.ReadLine());
        Console.Write("Enter minutes: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter seconds: ");
        int s = int.Parse(Console.ReadLine());

        double hours = h + m / 60.0 + s / 3600.0;
        if (hours > 0)
        {
            double kmh = d / hours;
            double mph = kmh / 1.609;
            Console.WriteLine($"Speed: {kmh:F2} km/h = {mph:F2} miles/h");
        }
    }

    static void SphereCalc()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Surface={surface:F2}, Volume={volume:F2}");
    }

    static void CheckCharacter()
    {
        Console.Write("Enter a character: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if ("aeiouAEIOU".IndexOf(c) >= 0) Console.WriteLine("Vowel");
        else if (char.IsDigit(c)) Console.WriteLine("Digit");
        else if (char.IsLetter(c)) Console.WriteLine("Consonant");
        else Console.WriteLine("Symbol");
    }

    // ----------------- Control Flow Part 1 -----------------
    static void ControlFlowMenu1()
    {
        Console.WriteLine("\n--- Control Flow Part 1 ---");
        Console.WriteLine("1. Even/Odd check");
        Console.WriteLine("2. Largest of 3 numbers");
        Console.WriteLine("3. Quadrant of point");
        Console.Write("Choose (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: EvenOdd(); break;
            case 2: LargestOfThree(); break;
            case 3: QuadrantCheck(); break;
        }
    }

    static void EvenOdd()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
    }

    static void LargestOfThree()
    {
        Console.Write("Enter a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: "); int c = int.Parse(Console.ReadLine());
        int max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"Largest = {max}");
    }

    static void QuadrantCheck()
    {
        Console.Write("Enter X: "); int x = int.Parse(Console.ReadLine());
        Console.Write("Enter Y: "); int y = int.Parse(Console.ReadLine());
        if (x > 0 && y > 0) Console.WriteLine("First Quadrant");
        else if (x < 0 && y > 0) Console.WriteLine("Second Quadrant");
        else if (x < 0 && y < 0) Console.WriteLine("Third Quadrant");
        else if (x > 0 && y < 0) Console.WriteLine("Fourth Quadrant");
        else Console.WriteLine("On Axis or Origin");
    }

    // ----------------- Control Flow Part 2 -----------------
    static void ControlFlowMenu2()
    {
        Console.WriteLine("\n--- Control Flow Part 2 ---");
        Console.WriteLine("1. Triangle type");
        Console.WriteLine("2. Sum & average of 10 numbers");
        Console.WriteLine("3. Multiplication table");
        Console.WriteLine("4. Number triangle pattern");
        Console.WriteLine("5. Pattern (123, etc.)");
        Console.WriteLine("6. Harmonic series sum");
        Console.WriteLine("7. Perfect numbers in range");
        Console.WriteLine("8. Prime check");
        Console.Write("Choose (1-8): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: TriangleType(); break;
            case 2: SumAverage10(); break;
            case 3: MultiplicationTable(); break;
            case 4: NumberTriangle(); break;
            case 5: Pattern123(); break;
            case 6: HarmonicSeries(); break;
            case 7: PerfectNumbers(); break;
            case 8: PrimeCheck(); break;
        }
    }

    static void TriangleType()
    {
        Console.Write("Enter side a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Enter side b: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Enter side c: "); int c = int.Parse(Console.ReadLine());
        if (a == b && b == c) Console.WriteLine("Equilateral");
        else if (a == b || b == c || a == c) Console.WriteLine("Isosceles");
        else Console.WriteLine("Scalene");
    }

    static void SumAverage10()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter number {i}: ");
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Sum={sum}, Average={(sum / 10.0):F2}");
    }

    static void MultiplicationTable()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }

    static void NumberTriangle()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }
    }

    static void Pattern123()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }
    }

    static void HarmonicSeries()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
            Console.Write("1/{0} ", i);
            if (i < n) Console.Write("+ ");
        }
        Console.WriteLine($"\nSum = {sum:F4}");
    }

    static void PerfectNumbers()
    {
        Console.Write("Enter upper limit: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Perfect numbers:");
        for (int num = 2; num <= n; num++)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
                if (num % i == 0) sum += i;
            if (sum == num) Console.WriteLine(num);
        }
    }

    static void PrimeCheck()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        bool prime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) prime = false;
        Console.WriteLine(prime ? "Prime" : "Not Prime");
    }
}