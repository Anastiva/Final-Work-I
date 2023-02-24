string[] A;
Console.Write("Введите массив строк через запятую: ");
string array = Console.ReadLine();
A = array.Split(',');
var result = new string[A .Length];
var Size = 0;
foreach (var value in A )
{
    if (value.Length <= 3)
    {
        result[Size] = value;
        Size++;
    }
}
Console.Write(string.Join(Environment.NewLine, result, 0, Size));
Console.ReadKey(true);
