// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.



int ArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] Less3Symbhol(string[] array, int userlength, int arraylength)
{
    string[] result = new string[arraylength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= userlength)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        System.Console.Write(item + " ");
    }
}


System.Console.WriteLine("Введите данные через пробел");
string userdata = Console.ReadLine();
System.Console.WriteLine("Укажите количество символов");
int userlength = Convert.ToInt32(Console.ReadLine());

string[] splitdata = userdata!.Split(' ');
int arraylength = ArrayLength(splitdata);

PrintArray(Less3Symbhol(splitdata, userlength, arraylength));