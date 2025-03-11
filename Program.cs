// See https://aka.ms/new-console-template for more information
//using System;
//using System.Collections.Generic;
//public class KodeProduk
//{
//    private static Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
//    {
//        {"Laptop",  "E100"},
//        {"Smartphone", "E101"},
//        {"Tablet", "E102"},
//        {"Headset", "E103"},
//        {"Keyboard", "E104"},
//        {"Mouse", "E105"},
//        {"Printer", "E106"},
//        {"Monitor", "E107"},
//        {"Smartwatch", "E108"},
//        {"Kamera", "E109"}
//    };
//    public static string getKodeProduk(string produk)
//    {
//        if (kodeProdukTable.ContainsKey(produk))
//        {
//            return kodeProdukTable[produk];
//        }
//        else
//        {
//            return "Kode Produk Tidak Ditemukan.";
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.Write("Masukkan nama produk: ");
//        string produk = Console.ReadLine();

//        string kodeProduk = KodeProduk.getKodeProduk(produk);
//        Console.WriteLine($"Kode Produk untuk {kodeProduk} adalah {kodeProduk}");
//    }
//}

using System;
public class Fanlaptop
{
    public enum State { Quiet, Turbo, Balanced, Performance}
    private State currentState;
    public Fanlaptop() { 
        currentState = State.Quiet;
        Console.WriteLine("Fan Quiet berubah menjadi Quiet");
    }
    public void HandleCommand(string command)
    {
        switch (currentState)
        {
            case State.Quiet:
                if (command == "Mode Up")
                {
                    currentState = State.Balanced;
                    Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                }
                else if (command == "Turbo Shortcut")
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                }
                break;
            case State.Turbo:
                if (command == "Turbo Shortcut")
                {
                    currentState = State.Quiet;
                    Console.WriteLine("Fan Quiet berubah menjadi Quiet");
                }
                else if (command == "Mode Down")
                {
                    currentState = State.Performance;
                    Console.WriteLine("Fan Quiet berubah menjadi Performance");
                }
                break;
            case State.Balanced:
                if (command == "Mode Up")
                {
                    currentState = State.Performance;
                    Console.WriteLine("“Fan Quiet berubah menjadi Performance");
                }
                else if (command == "Mode Down")
                {
                    currentState = State.Quiet;
                    Console.WriteLine("Fan Quiet berubah menjadi Quiet");
                }
                break;
            case State.Performance:
                if (command == "Mode Down")
                {
                    currentState = State.Balanced;
                    Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                }
                else
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                }
                break;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Fanlaptop fanlaptop = new Fanlaptop();
        while (true)
        {
            Console.Write("Masukkan command: ");
            string command = Console.ReadLine();
            if (command == "quit") break;
            fanlaptop.HandleCommand(command);
        }
        Console.WriteLine("Program selesai.");
    }
}