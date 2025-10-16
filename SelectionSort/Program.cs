int[] integerValues =
    {-11, 12, -42, 0, 1, 90, 68, 6, -9};

SelectionSort.SelectionSort.Sort(integerValues);
Console.WriteLine(
    string.Join(",", integerValues)
);

Console.WriteLine("*********************");

Console.WriteLine("Vetor de nomes");
string[] stringValues =
    { "Bolsonaro", "Kléber", "Putin", "Pica-Pau", "matuê", "Barack Hussein Obama", "Taís Carla"};

SelectionSort.SelectionSort.Sort(stringValues);
Console.WriteLine(string.Join(",", stringValues));
string.Join(",", stringValues);