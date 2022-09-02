int FirstDimension = 5; // число строк
int SecondDimension = 6; // число столбцов
int lowerLimitOfRandom = 0;
int upperLimitOfRandom = 10;
int [,] Array = new int [FirstDimension,SecondDimension];
double summ = 0;
for (int i = 0; i < Array.GetLength (0); i ++)
    {    
         for (int j = 0; j < Array.GetLength (1); j ++)
            {
                Array [i,j] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }
for (int i = 0; i < Array.GetLength (0); i ++)
    {    
         for (int j = 0; j < Array.GetLength (1); j ++)
            {
                summ += Array[i,j];
            }
        Console.WriteLine (summ/Array.GetLength(1));
        summ = 0;
    }