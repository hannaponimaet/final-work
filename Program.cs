//объявляем и инициализируем  заданный массив 
// метод, который печетает изначальный массив 
// метод, который ищет массив с длиной строк меньше либо равно 3 символа
// содаем новый массив с полученной длиной строк
// метод, который печатает полученный массив 

int rangeArray = 0; 
string [] Search (string[] inputArray) // метод, который ищет кол-во элементов с размером меньше либо равно 3 символа
{
    int j = 0;
    string [] tempArray = new string [inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            tempArray[j] = inputArray[i];
            j++;
        }
    }
    rangeArray = j;
    return tempArray;
}

void PrintArray (string [] array) //метод, который печатает массив на консоль
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]\n");
}


string[] inputArray  = {"Hello", "2", ":-)", "world"};
Console.WriteLine("Исходный массив: ");
PrintArray(inputArray);
Console.WriteLine();
 

string [] tempArray = new string [inputArray.Length]; 
tempArray = Search(inputArray);

 string [] outputArray = new string [rangeArray]; // создаем новый массив с полученной длиной строк
    for (int i = 0; i < rangeArray; i++)
    {
        outputArray[i] = tempArray[i];
    }

Console.WriteLine("Полученный массив: ");
PrintArray(outputArray);
