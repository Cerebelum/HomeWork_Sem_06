// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++; 
        }
    }
    return count;
}

int[] FillArrayByUser(int sizeArray)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = PromptNumber($"Введите {i + 1}-е число: ");
    }
    return array;
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// int size = PromptNumber("Введите размер массива: ");
int[] mas = FillArrayByUser(PromptNumber("Введите размер массива: "));
Console.WriteLine($"Вы ввели числа: [{String.Join(", ", mas)}]");
Console.WriteLine($"Количество чисел больше 0 в данном массиве равно: {CountPositiveNumbers(mas)}");
