/*
Console.WriteLine("EJERCICIO 1");
Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine("Ingresa tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sabes programar? si/no");
string esProgramadorStr = Console.ReadLine();
string esProgramadorMsg = "";

if(String.Equals(esProgramadorStr.ToLower(), "si"))
{
    esProgramadorMsg = "Si sabes programar";
} else
{
    esProgramadorMsg = "No sabes programar";
}

string mensaje = "Tu nombre es " + nombre + " " + apellido + ", tienes " + edad + " años. " + esProgramadorMsg;

Console.WriteLine(mensaje);
*/

/*
Console.WriteLine("EJERCICIO 2");
int puertas = 4;
int ruedas = 4;
string marca = "Toyota";
bool itvVigente = false;
string coche1 = "COCHE | Puertas: " + puertas + ", Ruedas: " + ruedas + ", Marca: " + marca + ", ITV: " + itvVigente;

double pesoKg = 2.45;
int largoCms = 120;
string material = "madera";
string color = "negro";
string mesa1 = "MESA | Peso Kg.: " + pesoKg + ", Largo (cms): " + largoCms + ", Material: " + material + ", Color: " + color;

Console.WriteLine(coche1);
Console.WriteLine(mesa1);
*/

Console.WriteLine("EJERCICIO 3");
int num = 23;
bool numMayor18 = num > 18;
Console.WriteLine(num + " > 18 = " + numMayor18);

char c = 's';
bool charEsA = (c == 'a');
Console.WriteLine(c + " es 'a' = " + charEsA);

int edadCandidato = 19;
bool carnetConducir = false;
bool contratado = (edadCandidato >= 18 && carnetConducir);
Console.WriteLine("Contratado = " + contratado);

int aniosExperiencia = 3;
bool educacionSuperior = false;
bool contratado2 = (aniosExperiencia > 1 || educacionSuperior);
Console.WriteLine("Contratado = " + contratado2);