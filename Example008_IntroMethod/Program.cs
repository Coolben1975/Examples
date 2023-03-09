Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
	int result = arg1;
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result;
}

int a1 = 12;
int a2 = 10;
int a3 = 22;
int b1 = 1012;
int b2 = 8;
int b3 = 31;
int c1 = 90;
int c2 = 222;
int c3 = 312;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3); //далее упростим (функция в функции) ***1

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // ***1


Console.Write(max);


