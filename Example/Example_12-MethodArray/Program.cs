int[] array = { 25, 69, 53, 28, 9, 71, 60, 96, 81, 9, 56, 14, 9, 54, 87 };

int n = array.Length;

int find = 9;

int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}