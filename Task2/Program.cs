Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1   4  7  2
5  81  2  9
8   4  2  4
int[,] ConvertToSQR(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;

}

int [,] massiv = FillArray(5, 5);
PrintArray(massiv);
System.Console.WriteLine();
int [,] newmassiv = ConvertToSQR(massiv);
PrintArray(massiv);

// Задайте двумерный массив. 
// Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, 
void PrintArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
        }
        Console.WriteLine();    // Переход на следующую строку
    }
}


int[,] ConvertToSQR(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;

}
int [,] massiv = FillArray(5, 5);
PrintArray(massiv);
System.Console.WriteLine();
int [,] newmassiv = ConvertToSQR(massiv);
PrintArray(newmassiv);
