bool running = true;
int counterNumbers = 0;
int counterPositives = 0;
int counterNegatives = 0;
int counterZeros = 0;

do
{
    
    Console.WriteLine("Escribe un número: ");
    int number = Convert.ToInt32(Console.ReadLine());
    counterNumbers++;

    if (number > 0)
    {
        counterPositives++;
    } else if (number < 0)
    {
        counterNegatives++;
    } else
    {
        counterZeros++;
    }

    Console.WriteLine("Continuar? S/N");
    string response = Console.ReadLine();

    if (String.Equals(response.ToLower(), "n"))
    {
        running = false;
    }

} while (running);

Console.WriteLine($"Números ingresados: {counterNumbers}");
Console.WriteLine($"Números positivos: {counterPositives}");
Console.WriteLine($"Números negativos: {counterNegatives}");
Console.WriteLine($"0's ingresados: {counterZeros}");