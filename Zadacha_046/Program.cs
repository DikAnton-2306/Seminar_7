// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int EnterNumber(string message) // Метод спрашивает пользователя ввести число
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void ArrayWithRundomNumbers(int[,] arr, int leftRange, int rightRange) // Методо заполняет массив рандомно
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(leftRange, rightRange);
        }
    }
}

void ShowMatrix(int [,] arr) // Метод вывода массива в терминал
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

int min = EnterNumber("Укажите левую границу цифр: ");
int max = EnterNumber("Укажите правую границу цифр: ");

int [,] matrix = new int[rows, columns];
ArrayWithRundomNumbers(matrix, min, max);
ShowMatrix(matrix);