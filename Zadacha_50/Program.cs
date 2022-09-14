
Console.WriteLine("Введите размеры массива");
int rows= Convert.ToInt32(Console.ReadLine());
int columns= Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {    
        matrix [i, j] = Convert.ToInt32(new Random().Next(0,21)); 
        Console.Write(matrix[i,j] + "\t  "); 
}
Console.WriteLine();
}
  
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>rows || b>columns)
 { 
    Console.WriteLine("такого числа нет");}
 else
 { 
    Console.WriteLine(matrix[a-1,b-1]);}
