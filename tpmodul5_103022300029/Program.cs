class main
{
    static void Main(string[] args)
    {
        HaloGeneric nama = new HaloGeneric();
        nama.sapaUser<string>("Damai");
    }
}

class HaloGeneric()
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine($"Halo User {user}");
    }
}