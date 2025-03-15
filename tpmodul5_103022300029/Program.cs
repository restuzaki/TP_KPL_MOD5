class main
{
    static void Main(string[] args)
    {
        HaloGeneric nama = new HaloGeneric();
        nama.sapaUser<string>("Damai");
        DataGeneric<string> nim = new DataGeneric<string>("103022300029");
        nim.printData();
    }
}

class DataGeneric<T>
{
    T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class HaloGeneric()
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine($"Halo User {user}");
    }
}