int FirstDimension = 5; // число строк
int SecondDimension = 6; // число столбцов
double [,] Array = new double [FirstDimension,SecondDimension];
for (int i = 0; i < Array.GetLength (0); i ++)
    {    
         for (int j = 0; j < Array.GetLength (1); j ++)
            {
                Array [i,j] = new Random().NextDouble();
                Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }

