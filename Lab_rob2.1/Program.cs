class Equal
{
    private double A, B; // Поле A і В

    // Властивість, в якій виконується присвоювання значення поля А
    public double a
    {
        get { return A; }
        set { A = value; }
    }

    // Властивість, в якій виконується присвоювання значення поля B
    public double b
    {
        get { return B; }
        set { B = value; }
    }

    // Метод для обчислення функції y = Ax + B при заданому x.
    public double Func(double x)
    {
        return A * x + B;
    }

    // Метод для вирішення лінійного рівняння Ax = B, який повертає значення кореня
    // або повідомляє про те, що коренів у рівняння безліч або воно не має жодного.
    public string Root()
    {
        if (A == 0)
        {
            if (B == 0)
                return "Безліч коренів"; // У випадку якщо А і В = 0
            else
                return "Немає кореня"; // Якщо лише А = 0
        }
        else
        {
            double x = B / A;
            return "Корінь: " + x; // Якщо А не = 0
        }
    }

    // Метод для виведення значень полів на екран.
    public void Print()
    {
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            Equal equal = new Equal(); // Створення об'єкту

            Console.Write("Введіть значення A: ");
            equal.a = double.Parse(Console.ReadLine()); // Присвоєння значення А за допомогою властивості

            Console.Write("Введіть значення B: ");
            equal.b = double.Parse(Console.ReadLine()); // Присвоєння значення B за допомогою властивості

            Console.WriteLine("Значення полів класу:");
            equal.Print(); // Виведення значень полів на екран

            Console.Write("Введіть значення X: ");
            double x = double.Parse(Console.ReadLine());

            double result1 = equal.Func(x); // Застосування методу Func для виведення результату
            Console.WriteLine($"Результат обчистення рівняння Ax + B при x = {x}: {result1}"); ;

            string result2 = equal.Root(); // Застосування методу Root для вирішення рівняння
            Console.WriteLine("Результат вирішення рівняння Ax = B: " + result2);
        }
        catch // Усі інші можливі помилки    
        {
            Console.WriteLine("Помилка!!!");
        }
    }
}

