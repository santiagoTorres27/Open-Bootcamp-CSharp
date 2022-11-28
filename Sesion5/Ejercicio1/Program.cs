
Console.WriteLine("Nombre: ");
string name = Console.ReadLine();

Console.WriteLine("Email: ");
string email = Console.ReadLine();

Console.WriteLine("Tiene descuento? S/N: ");
string discountStr = Console.ReadLine();
bool discount = (discountStr.ToLower() == "s") ? true : false;

Client c = new Client();
c.Name = name;
c.Email = email;
c.Coupon = discount;

double price = 24.43;
Console.WriteLine("Cliente: ");
Console.WriteLine(c);

double finalPrice = (c.Coupon) ? price - (price * 0.5) : price;
Console.WriteLine("Precio final: " + finalPrice);

public struct Client
{
    private string name;
    private string email;
    private bool coupon;

    public Client(string name, string email, bool coupon) : this()
    {
        Name = name;
        Email = email;
        Coupon = coupon;
    }

    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public bool Coupon { get => coupon; set => coupon = value; }

    public override string? ToString()
    {
        return $"{name}, {email}, {coupon}";
    }
}