int rows= Convert.ToInt32(Console.ReadLine());
int columns= Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows,columns];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]= new Random().Next(-100,100)/10.0;
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
