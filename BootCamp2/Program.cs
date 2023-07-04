// Время работы алгоритмов
// найти указанный элемент массива
// int[] array = new int[5];
// for (int i = 0; i < 5; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// System.Console.WriteLine(array[2]);
// Сложность алгоритма О(1), то есть чтобы узнать какой  элемент стоит на указанной позиции надо одно действие


// Узнать сумму элементов массива
// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");

// int summ = 0;
// for (int i = 0; i < n; i++)
// {
//     summ += array[i];
// }
// System.Console.WriteLine(summ);
// Сложность алгоритма равна О(n), то есть требуется n действий для получения результата


// Таблица умножения
// Например вводим число 5, и выводится таблица умножений 5х5
// Сложность О(n^2), n в квадрате

// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= n; i++)
// {
//     for (int j = 0; j <= n; j++)
//     {
//         System.Console.Write(i * j);
//         System.Console.Write("\t");  //табуляция для красивого вывода
//     }
//     System.Console.WriteLine();
// }

// Второй вариант решения задачи, сложность алгоритма в 2 раза меньше,  т.к значения повторяются через гланую диагональ
// Нам нужно посичтать только половину значений
// Сложность будет О((n^2)/2)
int n = Convert.ToInt32(Console.ReadLine());
int [ , ] matrix = new int [n,n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i,j] = (i+1)*(j+1);
        matrix[j,i] = (i+1)*(j+1);
        
    }
    System.Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        System.Console.Write(matrix[i,j]);
        System.Console.Write("\t");  //табуляция для красивого вывода
    }
    System.Console.WriteLine();
}