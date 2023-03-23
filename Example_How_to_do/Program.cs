using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
				.Replace("(", "")
				.Replace(")", "")
				;

Console.WriteLine(text);

var data = text.Split(" ")
				.Select(item => item.Split(","))
				//.Select(e => (int.Parse(e[0]), int.Parse(e[1]))) // переделываем, чтобы убрать Item (ниже по коду)
				.Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
				//.Where(e => e.x % 2 == 0)
				.Select(point => (point.x * 10, point.y))
				.ToArray();

for (int i = 0; i < data.Length; i++)
{
	// Console.WriteLine(data[i].Item2 * 10);  //Item1 - первый элемент, но мы переделаем и присвоим x и y
	//Console.WriteLine(data[i].x * 10);
	Console.WriteLine(data[i]);
}

/* Можно сделать и по другому  - выводя сразу переделанные уже элементы, при создании массива
Console.WriteLine(data[i]);

.Select(point => (point.x * 10, point.y))

!! Можно перед действием добавить условие, Например:
.Where(e => e.x %2 == 0)
или для y
.Where(e => e.y %2 == 0)
*/