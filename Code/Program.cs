Console.Write("Введите количество элементов массива: "); // Определение длины входного массива
int size = int.Parse(Console.ReadLine());

string[] inputArray = new string[size]; // Создание и заполнение исходного массива
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент {i + 1}: "); // i + 1, потому что индексы массива нумеруются с нуля
    inputArray[i] = Console.ReadLine();
}

string[] resultArray = new string[size]; // Создаем результирующий массив такого же размера
int index = 0; // Вводим переменную для подсчета количества элементов, у которых длина <= 3

for (int i = 0; i < size; i++)
{
    if (inputArray[i].Length <= 3)
    {
        resultArray[i] = inputArray[i]; // Если в входном массиве размер элемента <= 3, то добавляем его в результирующий. И инкрементируем index
        index++;
    }
}
resultArray = resultArray.Where(x => x != null).ToArray(); // Удаляем все null элементы из результирующего элемента
string output = "[" + string.Join(", ", resultArray) + "]"; // Формируем строку для красивого вывода

Console.WriteLine("Результирующий массив строк длиной <= 3 символа: " + output);