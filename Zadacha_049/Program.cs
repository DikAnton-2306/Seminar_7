// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] Squ(int[,] array) // Цифры на чётных ячейках массива возводятся в квадрат
{
    for (int i = 2; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 2; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

void ShowMatrix(int[,] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($" {arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] ArrayWithRundomNumbers(int rows, int columns, int leftRange, int rightRange) // Метод заполняет массив рандомно
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message) // Метод спрашивает пользователя ввести число
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Пользователь вводит размер массива и границы цифр
int rows = EnterNumber("Введите кол-во строк: ");
int columns = EnterNumber("Введите кол-во столбцов: ");

int min = EnterNumber("Укажите левую границу цифр: ");
int max = EnterNumber("Укажите правую границу цифр: ");

// Создаётся двумерный массив
int[,] matrix = ArrayWithRundomNumbers(rows, columns, min, max);
ShowMatrix(matrix);

// Цифры на чётных ячейках массива возводятся в квадрат
int[,] matrixSquare = Squ(matrix); 

// вывод массива в терминал 
System.Console.WriteLine();
ShowMatrix(matrixSquare);
