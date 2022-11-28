Console.WriteLine("Ancho: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Alto: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Relleno: s/n");
string filledStr = Console.ReadLine();
bool filled = (String.Equals(filledStr.ToLower(), "s")) ? true : false;

Console.WriteLine("Número de figuras a imprimir: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    for (int k = 0; k < num; k++)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    Console.Write("*");
                }
                else if (filled)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("");
    }
} else
{
    Console.WriteLine("No se puede imprimir el número de repeticiones que has ingresado");
}



