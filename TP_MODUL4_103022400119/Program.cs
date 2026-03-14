using System;
using System.Collections.Generic;

public class KodePos
{
    public string getKodePos(string kelurahan)
    {
        Dictionary<string, string> tabelKodePos = new Dictionary<string, string>()
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" }
        };
        return tabelKodePos[kelurahan];
    }

    public static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Masukkan nama kelurahan:");
        string kelurahan = Console.ReadLine();

        string result = kode.getKodePos(kelurahan);
        Console.WriteLine("Kode Pos " + kelurahan + " adalah: " + result);
    }
}


public class DoorMachine
{
    public enum DoorState { Terkunci, Terbuka };
    private DoorState currentState = DoorState.Terkunci;

    public DoorMachine()
    {
        Console.WriteLine("Pintu terkunci");
    }
    public void KunciPintu()
    {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
    }  
    public void BukaPintu()
    {
        currentState = DoorState.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }
       
    public static void Main(string[] args)
    {
        DoorMachine pintu = new DoorMachine();
        Console.WriteLine("\nMulai perubahan state");
            
        pintu.BukaPintu();  
        pintu.KunciPintu();
        pintu.KunciPintu(); 
        pintu.BukaPintu();  
    }
}

    