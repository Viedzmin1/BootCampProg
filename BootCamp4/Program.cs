// Алгоритм сортировки выбором
// Выбирается опорный элемент, обычно первый, принимается за самый меньший, потом смотрится оставшийся 
// массив, из него отбирается самый меньший. Опорный элемент и найденный меньший меняются местами.
// Потом первый элемент нового получившегося после перестановки массива не трогается, берем оставшуюся часть,
// снова берем первый элемент как опорный и повторяем то же самое, и так до конца, пока не пробежим и не 
// отсортируем весь массив.
// Сложность данного алгорится О(n^2), где n - количество элементов массива

int[] SortSelection(int[] collection)
{
    int size = collection.Lenght;
    for (int i = 0; i < size-1; i++)
    {
        int pos = i;
        for (int j = i+1; j < size; j++)
        {
            if (collection[i] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}

var arr = new int[] {9, 3, 5, 6, 1, 3, 2, 7, 4};
System.Console.WriteLine(string.Join(' ', arr));
SortSelection(arr);
System.Console.WriteLine(string.Join(' ', arr));
