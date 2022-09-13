int rows= Convert.ToInt32(Console.ReadLine());
int columns= Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,columns];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]= new Random().Next(0,11);
                
        Console.Write(matrix[i,j]+"\t");          
   
    }    
    Console.WriteLine(); 
      }

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.WriteLine($"{ sum / matrix.GetLength(0)} ");
}