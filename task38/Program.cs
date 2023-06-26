// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] CreateNewArray ()
{
    int sizeArray = 5;
    double [] array = new double[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {   
        array[i] = Convert.ToDouble(new Random().Next(0, 999)) / 100;
    }
    return array;
}

void PrintArray (double [] arrayPrint)
{
    Console.Write("Your array is: ");
    for (int i = 0; i < arrayPrint.Length; i++)
        Console.Write(arrayPrint[i] + " ");
    Console.WriteLine();
}

double ArrayMaxElem (double [] myArray)
{
    double maxElem = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        if (myArray[i] > maxElem)
        {
            maxElem = myArray[i];
        }
    }
    return maxElem;
}

double ArrayMinElem (double [] myArray1)
{
    double minElem = myArray1[0];
    for (int i = 1; i < myArray1.Length; i++)
    {
        if (myArray1[i] < minElem)
        {
            minElem = myArray1[i];
        }
    }
    return minElem;
}


double [] myArray2 = CreateNewArray();
PrintArray(myArray2);
Console.WriteLine($"{ArrayMaxElem(myArray2)} is MAX");
Console.WriteLine($"{ArrayMinElem(myArray2)} is MIN");
Console.WriteLine($"The diff max and min is {ArrayMaxElem(myArray2) - ArrayMinElem(myArray2)}");