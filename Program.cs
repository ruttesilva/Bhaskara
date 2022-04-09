double a, b, c, delta, x1, x2;

Console.WriteLine("-- Equação do segundo grau --");

Console.Write("(a): ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("(b): ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c): ");
c = Convert.ToDouble(Console.ReadLine());

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine ("Não é uma equação de segundo grau!");
}

else
{
    delta = Math.Pow(b,2) - 4 * a * c;

    if (delta<0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
    }

    else
    {
        x1 = (-b + Math.Sqrt(delta) / (2 * a));
        x2 = (-b - Math.Sqrt(delta) / (2 * a));

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"x1 = {x1:N2}, x2 = {x2:N2}");
    }
}

Console.ResetColor();