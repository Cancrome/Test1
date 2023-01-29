Console.WriteLine ("weather," + "sun," + "rain," + "air," + "wind." + "\n" +"Слова состоящие из 3 и менее символов:" );

//Вводим массив
string[] array = new string[5] {"weather", "sun", "rain", "air", "wind"};

//Создаем строку такого же размера
string[] array3 = new string[array.Length];

//Проверяем длинну каждого слова
void ShortArray(string[] array, string[] array3)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

    //Если слово <=3, то

    if(array[i].Length <= 3)
        {

        //Запоминаем данные в array3
        array3[count] = array[i];
        count++;
        }
    }
}

//Выводим данные
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ShortArray(array, array3);
PrintArray(array3);