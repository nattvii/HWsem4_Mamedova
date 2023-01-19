// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь,
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Fill in a number of elements with comma: ");
string Numbers = Console.ReadLine();

Numbers = Numbers + ", ";

int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j = 0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = ", ";

    while (seriesNew[i] = ", " && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

