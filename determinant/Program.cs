using Matrix;
Console.WriteLine("enter length of matrix between 1 to 4");
Console.Write("length = ");
byte length = byte.Parse(Console.ReadLine());
int[,] matrix = new int[length, length];
Console.WriteLine("enter matrix elements");
Matrix.Matrix.EnterMatrix(matrix, length);
Console.WriteLine("your matrix");
Matrix.Matrix.PrintMatrix(matrix, length);
Console.Write("Determinant = ");
Matrix.Matrix.FindDeterminant(matrix, length);



