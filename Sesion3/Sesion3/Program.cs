Client c1 = new Client("Santiago", "Torres", "987654", "Madrid", "santiago@gmail.com", false);
Console.WriteLine(c1);

public struct Client
{
    public string name;
    public string lastname;
    public string phone;
    public string address;
    public string email;
    public bool isNewClient;

    public Client(string name, string lastname, string phone, string address, string email, bool isNewClient)
    {
        this.name = name;
        this.lastname = lastname;
        this.phone = phone;
        this.address = address;
        this.email = email;
        this.isNewClient = isNewClient;
    }

    public override string? ToString()
    {
        return $"({name}, {lastname}, {phone}, {address}, {email}, New client = {isNewClient})";
    }
}