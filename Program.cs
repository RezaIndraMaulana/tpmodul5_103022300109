// See https://aka.ms/new-console-template for more information
using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Masukkan Nama Anda: ");
        string nama = Console.ReadLine();

        halo.SapaUser(nama);
    }
}
