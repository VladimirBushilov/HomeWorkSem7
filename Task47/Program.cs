// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadText(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMass(int row, int col, double leftRange, double rightRange)
{
    double[,] mass = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = Math.Round(rand.NextDouble() * 99, 3);
        }
    }

    return mass;
}

void ShowMass(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            System.Console.Write(mass[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] matrix = FillMass(ReadText("Введите количество строк: "), ReadText("Введите количество столбцов: "), 0, 99);
ShowMass(matrix);