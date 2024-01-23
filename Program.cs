string[] array = InputArray();
int sizeResult = GetSizeResultArray(array);
string[] resultArray = GetResultArray(array, sizeResult);
PrintResultArray(resultArray);

string[] InputArray()
{
    Console.Write("Введите количество элементов: ");//Вывести сообщение 
    string value = Console.ReadLine();//Считать с консоли строку
    int sizeArray = Convert.ToInt32(value);// Преобразовать строку в целое число
    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i += 1)
    {
        Console.Write("Введите элемент массива: ");//Вывести сообщение 
        string item = Console.ReadLine();//Считать с консоли строку
        array[i] = item;
    }
    return array;
}

int GetSizeResultArray(string[] array)
{
    int sizeResult = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        int length = array[i].Length;
        if (length <= 3)
        {
            sizeResult += 1;
        }
    }
    return sizeResult;
}

string[] GetResultArray(string[] array, int sizeResult)
{
    string[] arrayResult = new string[sizeResult];
    int j = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        int length = array[i].Length;
        if (length <= 3)
        {
            arrayResult[j] = array[i];
            j += 1;
        }
    }
    return arrayResult;
}

void PrintResultArray(string[] resultArray)
{
    Console.WriteLine("Итоговый масссив: ");
    for (int i = 0; i < resultArray.Length; i += 1)
    {
        Console.WriteLine(resultArray[i]);
    }
}