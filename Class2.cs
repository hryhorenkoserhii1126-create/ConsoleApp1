using System;

class Class2
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());

        // 1. Обчислюємо чисельник: кубічний корінь з (x^2 + 5x + 1)
        double numerator = Math.Pow(x * x + 5 * x + 1, 1.0 / 3.0);


        double innerNumerator = Math.Abs(6 * Math.Pow(x, 5) - 6) + 7;

        // Знаменник внутрішнього дробу: 4x^2 + 3x - 4
        double innerDenominator = 4 * x * x + 3 * x - 4;

        // Ліва частина знаменника (дріб)
        double leftFraction = innerNumerator / innerDenominator;

        // Права частина знаменника: |x - 6|
        double rightPart = Math.Abs(x - 6);

        // Повний знаменник
        double denominator = leftFraction - rightPart;

        // 3. Обчислюємо підсумкове значення та виводимо його
        double result = numerator / denominator;
        Console.WriteLine(result);
    }
}