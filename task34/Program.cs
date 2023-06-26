// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2]

int [] CreateNewArray ()
{
    int arraySize = 5;
    int [] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {   
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (int [] arrayToPrint)
{
    Console.Write("Your array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " ");
    Console.WriteLine();
}

int EvenElemArray (int [] arrayE)
{
    int evenNumbers = 0;
    for (int i = 0; i < arrayE.Length; i++)
    {
        if (arrayE[i] % 2 == 0)
            evenNumbers = evenNumbers + 1;
    }
    return evenNumbers;
}

int [] myArray = CreateNewArray();
PrintArray(myArray);
Console.WriteLine($"Count of even numbers in your array is: {EvenElemArray(myArray)}");