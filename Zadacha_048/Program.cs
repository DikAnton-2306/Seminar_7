// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = i + j. 
// Выведите полученный массив на экран.


int EnterNumber(string message) // Метод спрашивает пользователя ввести число
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void MatrixMplusN(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = i + j;
        }
    }
}

void ShowMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int rows = EnterNumber("Введите кол-во строк: ");
int columns = EnterNumber("Введите кол-во столбцов: ");

// int min = EnterNumber("Укажите левую границу цифр: ");
// int max = EnterNumber("Укажите правую границу цифр: ");

int [,] matrix = new int[rows, columns];

MatrixMplusN(matrix);
ShowMatrix(matrix);