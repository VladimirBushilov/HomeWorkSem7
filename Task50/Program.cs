// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), 0, 99);
PrintMatrix(matrix);

System.Console.WriteLine("Введите позицию элемента массива в формате Х, У: ");

string input = System.Console.ReadLine();

int x = 0;
int y = 0;
bool xParsed = false;
bool yParsed = false;
for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
    {
        int j = i;

        while (j < input.Length && char.IsDigit(input[j]))

            j++;

        int num = int.Parse(input.Substring(i, j - i));

        if (!xParsed)
        {
            x = num;
            xParsed = true;
        }
        else if (!yParsed)
        {
            y = num;
            yParsed = true;
            break;
        }

        i = j;
    }
}

if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует.");
}
else
{
    Console.WriteLine("Значение элемента: " + matrix[x, y]);
}