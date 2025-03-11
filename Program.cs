// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
public class KodeProduk
{
    private static Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
    {
        {"Laptop",  "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor", "E107"},
        {"Smartwatch", "E108"},
        {"Kamera", "E109"}
    };
    public static string getKodeProduk(string produk)
    {
        if (kodeProdukTable.ContainsKey(produk))
        {
            return kodeProdukTable[produk];
        }
        else
        {
            return "Kode Produk Tidak Ditemukan.";
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Masukkan nama produk: ");
        string produk = Console.ReadLine();

        string kodeProduk = KodeProduk.getKodeProduk(produk);
        Console.WriteLine($"Kode Produk untuk {kodeProduk} adalah {kodeProduk}");
    }
}
