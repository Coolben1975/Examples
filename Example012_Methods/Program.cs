//Правила хорошего тона не работать с более 5 агрументами

//Вид - 1    //ничего не принимает, ничего не отдает
/*
void Method1()
{
	Console.WriteLine("Просто вывод текста...");
}

Method1();
*/

//Вид - 2    //ничего не возвращает, но принимает агрументы
/*
void Method2(string msg)
{
	Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
	int i = 0;
	while (i < count)
	{
		Console.WriteLine(msg);
		i++;
	}

}

Method2("Текст сообщения");
Method21(msg: "Текст2", count: 4);
*/

// Вид - 3     // ничего не принимает, но возвращает

/*
int Method3()
{
	return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Вид - 4 		// принимает и возвращает
/*
string Method4(int count, string str)
{
	int i = 0;
	string res = String.Empty; //пустая строка
	while (i < count)
	{
		res = res + str;
		i++;
	}

	return (res);
}

string res = Method4(5, "txt-");
Console.WriteLine(res);
*/

//------------ Method4 в Цикле For  
/*
string Method5(int count, string text)
{
	string res = String.Empty; //пустая строка

	for (int i = 0; i < count; i++)
	{
		res = res + text;
	}

	return (res);
}

string res = Method5(5, "txt-");
Console.WriteLine(res);
*/

// For - Цикл в цикле на примере таблицы умножения
/*
void Method6()
{
	for (int i = 2; i < 10; i++)
	{
		for (int j = 2; j < 10; j++)
			Console.WriteLine($"{i} x {j} = {i * j}");
		Console.WriteLine();
	}
}
Method6();
*/

//=====Работа с текстом // Дан текст. В тексте нужно все пробелы заменить чёрточками, // маленькие буквы “к” заменить большими “К”, // а большие “С” маленькими “с”. // Ясна ли задача?
/*
string text = "Я думаю, — сказал князь, улыбаясь, — что,"
			+ "ежели бы вас послали вместо нашего милого Винценгероде,"
			+ "вы бы взяли приступом согласие прусского короля."
			+ "Вы так красноречивы. Вы дадите мне чаю?";

string ReplaceText(string text, char oldValue, char newValue)
{
	string result = String.Empty;
	int lenght = text.Length;
	for (int i = 0; i < lenght; i++)
	{
		if (text[i] == oldValue) result = result + newValue;
		else result = result + text[i];
	}

	return result;
}

string newText = ReplaceText(text, ' ', '|');
Console.WriteLine(newText);
newText = ReplaceText(newText, 'к', 'К');
Console.WriteLine(newText);
newText = ReplaceText(newText, 'С', 'с');
Console.WriteLine(newText);
*/

// Массивы
// Отсортировать. Было: 1 8 3 2 6 4 5 7
// Стало: 1 2 3 8 6 4 5 7

/*
int[] array = { 1, 8, 3, 2, 6, 4, 5, 7 };
int[] newArray = new int[8];

int[] SortArray(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[minPosition]) minPosition = j;
		}

		int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
	return newArray;
}

void PrintArray(int[] newArray)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

SortArray(array);
PrintArray(newArray);
*/

/* Отсортировать Было: 1 8 3 2 6 4 5 7
Стало: 8 7 6 5 4 3 2 1
*/

int[] array = { 1, 8, 3, 2, 6, 4, 5, 7 };
int[] newArray = new int[8];

int[] SortArray(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int maxPosition = i;
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] > array[maxPosition]) maxPosition = j;
		}

		int temporary = array[i];
		array[i] = array[maxPosition];
		array[maxPosition] = temporary;
	}
	return newArray;
}

void PrintArray(int[] newArray)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

SortArray(array);
PrintArray(newArray);
