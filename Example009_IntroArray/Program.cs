Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
	int result = arg1;
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result;
}

// int a1 = 12;   сделаем массив ***2
// int a2 = 10;
// int a3 = 22;
// int b1 = 1012;
// int b2 = 8;
// int b3 = 31;
// int c1 = 90;
// int c2 = 222;
// int c3 = 312;
//               0   1   2    3   4   5   6   7    8 
int[] array = { 12, 10, 22, 1012, 8, 31, 90, 222, 312 };    // ***2
															//int lenght = array.lenght;

// int max1 = Max(a1, b1, c1);    	//далее упростим (функция в функции) ***1
// int max2 = Max(a2, b2, c2);		//
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3); 

// int max = Max(Max(a1, b1, c1),  // ***1
// 		Max(a2, b2, c2),		// переделаем выборку данных из массива  ***3
// 		Max(a3, b3, c3)); 

int max = Max(                                   //  ***3
		Max(array[0], array[1], array[2]),
		Max(array[3], array[4], array[5]),
		Max(array[6], array[7], array[8])
);
Console.Write(max);


