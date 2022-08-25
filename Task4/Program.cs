/* Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. Затем из первой суммы 
(с максимумами) вычтите вторую сумму(с минимумами)
*/

/* Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

Введенный элемент 2, результат: [1, 4]

Введенный элемент 6, результат: такого элемента нет.
*/

Random rand = new Random();

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintArray(matrix);


int findElem (int[,] matrix, int element)
{
int sum =0;
for (int i = matrixGet0; i <(0) matrixGetlength(0); i++)matrixGet
{
   (0) 
}

Random rand = new Random();

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintArray(matrix);


