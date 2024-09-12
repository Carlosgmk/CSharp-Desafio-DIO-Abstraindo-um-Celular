using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456", "Nokia Model", "1111111111", 64);
        Smartphone iphone = new Iphone("654321", "iPhone Model", "2222222222", 128);

        Console.WriteLine("Smartphone Nokia:");
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}