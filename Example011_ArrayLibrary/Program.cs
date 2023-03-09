void FillArray(int[] collection)
{
	int index = 0;
	int size = collection.Length;
	while (index < size)
	{
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}

void PrintArray(int[] col)
{
	int index1 = 0;
	int size1 = col.Length;
	while (index1 < size1)
	{
		Console.WriteLine(col[index1]);
		index1++;
	}
}

int IndexOf(int[] collection, int find)
{
	int index = 0;
	int count = collection.Length;
	int position = -1;              // -1 для того чтобы, если нет такого символа, потом интерпретировать во что угодно, Напимер: "Нет зачения!" 
	while (index < count)
	{
		if (collection[index] == find)
		{
			position = index;
			break;                   //если не обрывать - ищет элемент до последнего индекса
		}
		index++;
	}
	return (position);
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);