int FirstDimension = 5; // число строк
int SecondDimension = 6; // число столбцов
int lowerLimitOfRandom = 0;
int upperLimitOfRandom = 50;
int [,] Array = new int [FirstDimension,SecondDimension];
int Line = 0;
int Column = 0;
for (int i = 0; i < Array.GetLength (0); i ++)
    {    
         for (int j = 0; j < Array.GetLength (1); j ++)
            {
                Array [i,j] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }
Console.WriteLine ("Введите номер строки");
Line = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите номер столбца");
Column = Convert.ToInt32 (Console.ReadLine ());
if (Line < Array.GetLength(0) && Column < Array.GetLength(1)) Console.WriteLine (Array[Line,Column]);
else Console.WriteLine ("такого элемента нет");
