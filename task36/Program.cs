// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] CreateNewArray (int arraySize)
{
    int [] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {   
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray (int [] arrayPrint)
{
    Console.Write("Your random array is: ");
    for (int i = 0; i < arrayPrint.Length; i++)
        Console.Write(arrayPrint[i] + " ");
}

int PrintSumOddInElem (int [] arraySumPrint)
{
    int sumArrayOddInd = 0;
    if (arraySumPrint.Length % 2 == 0)
    {
        for (int i = 1; i <= arraySumPrint.Length - 1; i = i + 2)
        {
        sumArrayOddInd = sumArrayOddInd + arraySumPrint[i];
        }
    }
    else
    {
        for (int i = 1; i < arraySumPrint.Length; i = i + 2)
        {
        sumArrayOddInd = sumArrayOddInd + arraySumPrint[i];
        }
    }
    return sumArrayOddInd;
}

Console.Write("Set the length of your array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateNewArray(size);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"The sum of elements with odd indexes is: {PrintSumOddInElem(myArray)}");