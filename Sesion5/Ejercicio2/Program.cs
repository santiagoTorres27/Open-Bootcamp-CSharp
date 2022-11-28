List<String> programmingLanguages = new List<string> { "Java", "C#", "JavaScript" };

Console.WriteLine("Lenguajes de programación: ");
for (int i = 0; i < programmingLanguages.Count; i++)
{
    Console.WriteLine($"{i + 1}: {programmingLanguages[i]}");
}

Console.WriteLine("Selecciona un lenguaje: ");
int option = Convert.ToInt32(Console.ReadLine());
string languageSelected = "";

switch (option)
{
    case 1:
        languageSelected = programmingLanguages[0];
        break;

    case 2:
        languageSelected = programmingLanguages[1];
        break;

    case 3:
        languageSelected = programmingLanguages[2];
        break;
    default:
        languageSelected = "Ninguno";
        break;
}

Console.WriteLine($"Has seleccionado: {languageSelected}");