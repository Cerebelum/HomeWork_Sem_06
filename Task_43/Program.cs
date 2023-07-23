// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решаем систему уравнений
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

double PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = PromptNumber("Введите значение b1: ");
double k1 = PromptNumber("Введите значение k1: ");
double b2 = PromptNumber("Введите значение b2: ");
double k2 = PromptNumber("Введите значение k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"Точка пересечения прямых имеет координаты ({x}; {y})");
