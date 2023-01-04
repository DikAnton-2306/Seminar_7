// Задача 51: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void ShowsDioganalSum(int [,] arr) // 4. Высчитывает сумму элементов главной диагонали
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }
    System.Console.WriteLine("Сумма элементов главной диагонали равна " + sum);    
}

void ShowMatrix(int [,] arr) // 3. Метод вывода массива в терминал
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

void ArrayWithRundomNumbers(int[,] arr, int leftRange, int rightRange) // 2. Метод заполняет массив рандомно
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
}

int EnterNumber(string message) // 1. Метод спрашивает пользователя ввести число
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// ================================================================================================

// 1. Пользователь вводит размер массива и границы цифр
int rows = EnterNumber("Введите кол-во строк: ");
int columns = EnterNumber("Введите кол-во столбцов: ");

int min = EnterNumber("Укажите левую границу цифр: ");
int max = EnterNumber("Укажите правую границу цифр: ");

// 2. Создаётся двумерный массив
int [,] matrix = new int[rows, columns];
ArrayWithRundomNumbers(matrix, min, max);

// 3. Вывод массива в терминал 
ShowMatrix(matrix);

// 4. Вывод суммы элементов главной диагонали в терминал 
ShowsDioganalSum(matrix);