using BubbleSort;
Console.WriteLine("Ordenando com Bubble Sort");


string[] arrNumbers = new string[] { "ana", "paulo", "miguel", "camelo", "trembolona" };

foreach (var number in arrNumbers)
{
    Console.Write($" [{number}]");
}
var arrOrdered = BubbleSortOrder.Sort<string>(arrNumbers);
Console.WriteLine("");
Console.WriteLine("********");
Console.WriteLine("Vetor Ordenado");
Console.WriteLine("");
foreach (var number in arrOrdered)
{
    Console.Write($" [{number}]");
}

