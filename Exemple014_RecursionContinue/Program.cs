/*
---------------------------Собрать строку с числами от a до b, a <= b
*/

// string NumbersFor(int a, int b)
// {
// 	string result = String.Empty;
// 	for (int i = a; i <= b; i++)
// 	{
// 		result += $"{i}";
// 	}
// 	return result;
// }

// string NumbersRec(int a, int b)
// {
// 	if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
// 	else return String.Empty;
// }

// string NumbersRec(int a, int b)   /// задание
// {
// 	if (a < b) return $"{a}" + NumbersRec(a + 1, b);
// 	else return $"{a}";
// }

// Console.WriteLine(NumbersFor(1, 10)); //1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); //1 2 3 4 5 6 7 8 9 10

/*
---------------------------Факториал
*/
// int FactorialFor(int n)
// {
// 	int result = 1;
// 	for (int i = 1; i <= n; i++) result *= i;
// 	return result;
// }

// int FactorialRec(int n)
// {
// 	if (n == 1) return 1;
// 	else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

/*
---------------------------Вычислить a в степени n 
*/

// int PowerFor(int a, int n)
// {
// 	int result = 1;
// 	for (int i = 1; i <= n; i++) result *= a;
// 	return result;
// }

// int PowerRec(int a, int n)
// {
// 	return (n == 0 ? 1 : PowerRec(a, n - 1) * a);
// }

// int PowerRecMath(int a, int n)
// {
// 	if (n == 0) return 1;
// 	else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
// 	else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10)); //1024
// Console.WriteLine(PowerRec(2, 10)); //1024
// Console.WriteLine(PowerRecMath(2, 10)); //1024


/*
--------------------------- Перебор слов (см. видео)
*/


/*
--------------------------- Просмотр содержимого папки
DirectiryInfo - класс позволяющий посмотреть содержимое папки
Короче и тут нужно разбираться(((( нихера не работает
*/

// string path = "../Example004_Div";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
// 	System.Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
// 	DirectoryInfo catalog = new DirectoryInfo(path);

// 	DirectoryInfo[] catalogs = catalog.GetDirectories();
// 	for (int i = 0; i < catalogs.Length; i++)
// 	{
// 		Console.WriteLine($"{indent}{catalogs[i].Name}");
// 		CatalogInfo(catalogs[i].FullName, indent + " ");
// 	}

// 	FileInfo[] files = catalog.GetFiles();
// }



/*
--------------------------- Обход рпзных структур

								
		((2 - 2)) * ((1 + 3))	/	10										
*/
// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                  0   1    2     3    4    5    6    7    8    9    10   11 
// void InOrderTraversal(int pos = 1)
// {
// 	if (pos < tree.Length)
// 	{
// 		int left = 2 * pos;
// 		int right = 2 * pos + 1;
// 		if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
// 		Console.WriteLine(tree[pos]);
// 		if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
// 	}
// }
// InOrderTraversal();

