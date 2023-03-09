/*Имеется массив array из n элементов, требуется
найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array[index]=find, алгоритм завершил работу успешно
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2 иначе алгоритм 
завершил работу безуспешно. */

int[] array = { 2, 4, 6, 8, 33, 55, 4, 66, 4, 78, 19, 21 };
int find = 4;
int index = 0;
int n = array.Length;

while (index < n)
{
	if (find == array[index])
	{
		Console.WriteLine(index);
		break;                          //без него выведем все индексы
	}
	index++;
}