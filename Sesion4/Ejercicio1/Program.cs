Console.WriteLine("Escribe un número: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;

while(counter <= 10)
{
    Console.WriteLine($"{number} x {counter} = {number * counter}");
    counter++;
}