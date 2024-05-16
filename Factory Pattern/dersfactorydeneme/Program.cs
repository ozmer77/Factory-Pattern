public interface ITelefon
{
    string getName();
    string getModel();
    int getInch();

}

public class Iphone11:ITelefon
{
    public string getName()
    {
        return "Apple";
    }
    public string getModel()
    {
        return "İphone 11";
    }
    public int getInch()
    {
        return 6;
    }
}

public class SamsungS24:ITelefon
{
    public string getName()
    {
        return "Samsung";
    }
    public string getModel()
    {
        return "S24";
    }
    public int getInch()
    {
        return 7;
    }
}

public abstract class TelefonFactory
{
    protected abstract ITelefon MakeProduct();

    public ITelefon createProduct()
    {
        return this.MakeProduct();
    }

}

class SamsungFactory : TelefonFactory
{
    protected override ITelefon MakeProduct()
    {
        ITelefon telefon= new SamsungS24();
        return telefon;
    }
}

class AppleFactory : TelefonFactory
{
    protected override ITelefon MakeProduct()
    {
        ITelefon telefon=new Iphone11();
        return telefon;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
       ITelefon telefon=new AppleFactory().createProduct();

        ITelefon telefon1 = new SamsungFactory().createProduct();

        Console.WriteLine("Apple telefon");
       Console.WriteLine( telefon.getName());
        telefon.getModel();
        telefon1.getInch();
        Console.WriteLine();
        Console.WriteLine("Samsung telefon");
       Console.WriteLine( telefon1.getName());
        telefon1.getModel();
        telefon1.getInch();
       
    }
}