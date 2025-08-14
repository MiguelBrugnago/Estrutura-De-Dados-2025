// JaggedArrays
// São Arrays de Arrays

int [][] numbers = 
    new int [4][];
numbers[0] = 
    new int [] {1, 2, 3};
numbers[1] =
    new int [] { 4 };
numbers[2] =
    new int [] { 5, 6 ,7, 8, 9};
numbers[3] =
    new int [] { 6, 5, 4 };

// outra forma de inicializar

int [] [] nembers2 =
{
    new int [] {1},
    new int [] {2},
    new int [] {3},
    new int [] {4},
};

// para percorrer um jagged array substiuimos laços de repetiçao encadeados 
//Nested loop

for (int i = 0; i < numbers.Length; i++)
{ 
    Console.Write("[");
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]} ");
    }
    Console.Write("]");

}
Console.WriteLine();
// 