using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5)"
				.Replace("(", "")
				.Replace(")", "")
				;
var data = text.Split(" ")
				.Select(item => item.Split(","))
				.Select(e => (int.Parse(e[0]), int.Parse(e[1])))
				.ToArray();

for (int i = 0; i < data.Length; i++)
{
	Console.WriteLine(data[i]);
	Console.WriteLine();
}
