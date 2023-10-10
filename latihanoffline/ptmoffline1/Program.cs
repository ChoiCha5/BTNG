using System;

namespace aaaaa{
    class Program{
        static void Main(string[]args){
            Console.WriteLine("Hello, World!");
        
        Console.WriteLine("~~~~~~~~~~~~~~");

        //Kata Kunci Var
        var div = "Game";
        var nomor = 1;
        Console.WriteLine(div);
        Console.WriteLine(nomor);
        Console.WriteLine("~~~~~~~~~~~~~~");

        //Kata Kunci Const
        const float phi = 3.14f;
        Console.WriteLine(phi);
        Console.WriteLine("~~~~~~~~~~~~~~");
            
        //Tipe Data
        //Int
        int angkaint = 08888;
        float berat = 59.7777f;
        double brt = 59.7777777;
        Console.WriteLine(angkaint);
        Console.WriteLine(berat);
        Console.WriteLine(brt);
        Console.WriteLine("~~~~~~~~~~~~~~");

        //String
        string nama = "Savira";
        string nim = "A14.2021.03608";
        Console.WriteLine(nama);
        Console.WriteLine(nim);
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //Backlash
        string bulan = "Januari \tFebruari \tMaret";
        string hari = "Senin \tSelasa \tRabu";
        Console.WriteLine(bulan);
        Console.WriteLine(hari);
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //Manipulasi String
        string txt1 = "Ini teks";
        string txt2 = "ini juga teks";
        Console.WriteLine(txt1.ToLower());
        Console.WriteLine(txt2.ToUpper());
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //String Interpolation
        string firstName = "Savira";
        string lastName = "Fatimah Zulfa";
        Console.WriteLine($"Nama saya {firstName} {lastName}, salam kenal!");
        Console.WriteLine("~~~~~~~~~~~~~~");
            
        //Boolean
        bool jawaban = true;
        if (jawaban == false) {Console.Write("Jawaban salah");}
            else
        Console.WriteLine("Jawaban benar");
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //Knversi Float ke Int
        float desimal = 1.5f;
        int convert = (int)desimal;
        Console.WriteLine(convert);
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //KONVER NUMBER KE STRING
        int angka1 = 1;
        float angka2 = 1.5f;
        Console.WriteLine($"{angka1.ToString()} - {angka2.ToString()}");
            
        //String ke Int
        string pertama = "1";
        string kedua = "2";
        int sum = int.Parse(pertama) - int.Parse(kedua);
        Console.WriteLine(sum);
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //Operator Aritmatika
        var hasil1 = 1 + 3;
        var hasil2 = 3 - 1;
        var hasil3 = 1 * 3;
        var hasil4 = 4 / 2;
        var hasil5 = 9 % 2;
        var hasil6 = -5;
        
        Console.WriteLine(hasil1);
        Console.WriteLine(hasil2);
        Console.WriteLine(hasil3);
        Console.WriteLine(hasil4);
        Console.WriteLine(hasil5);
        Console.WriteLine(hasil6);
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        //Operator Penugasan
        //Incersent
        int k = 3;
        Console.WriteLine("\r" + k);
        Console.WriteLine(k++);
        Console.WriteLine(k);
        
        int l = 5;
        Console.WriteLine(l);
        Console.WriteLine(++l);
        Console.WriteLine(l);
        Console.WriteLine("~~~~~~~~~~~~~~");
        
        
        //Array
        int [] angka = new int [3];
        angka [0] = 11;
        angka [1] = 22;
        angka [2] = 33;
        
        Console.WriteLine();
        Console.WriteLine(angka[0]);
        Console.WriteLine(angka[1]);
        Console.WriteLine(angka[2]);
        Console.WriteLine("~~~~~~~~~~~~~~");

        // Perbandingan Operator
        int aa = 10;
        int bb = 5;

        Console.WriteLine(aa != bb);
        Console.WriteLine(aa == bb);
        Console.WriteLine(aa > bb);
        Console.WriteLine(aa < bb);
        Console.WriteLine(aa <= bb);
        Console.WriteLine(aa >= bb);

        Console.WriteLine("~~~~~~~~~~~~~~");

        // Operator Logika
        int aaa = 10;
        string name = "joni";

        if (aaa == 10 || name == "jon")
        {
            Console.WriteLine("Benar");
        }
        else
        {
            Console.WriteLine("Salah");
        }

        Console.WriteLine("~~~~~~~~~~~~~~");

        // Arrays
        string[] divisidncc = { "game", "web", "mobile", "jaringan", "data", "mulmed" };

        for (int i = 0; i < divisidncc.Length; i++)
        {
            Console.WriteLine(divisidncc[i]);
        }

        int[,] numbers = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine(numbers[0, 1]);
        Console.WriteLine(numbers[1, 0]);

        int[,,] arr = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        Console.WriteLine(arr[0, 1, 1]);

        Console.WriteLine("~~~~~~~~~~~~~~");

        // List
        var names = new List<string> { "Game", "Mobile", "Web" };
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i] + " ");
        }

        Console.WriteLine("~~~~~~~~~~~~~~");

        // If-Else & ElseIf
        int nilai = 75;
        if (nilai >= 90)
        {
            Console.WriteLine("Mendapatkan A");
        }
        else if (nilai >= 80)
        {
            Console.WriteLine("Mendapatkan B");
        }
        else if (nilai >= 70)
        {
            Console.WriteLine("Mendapatkan C");
        }
        else
        {
            Console.WriteLine("Mendapatkan D atau E");
        }

        Console.WriteLine("~~~~~~~~~~~~~~");

        // Switch
        int nilais = 75;
        switch (nilais)
        {
            case > 95:
                Console.WriteLine("Memuaskan");
                break;
            case > 80:
                Console.WriteLine("Baik");
                break;
            case > 75:
                Console.WriteLine("Cukup");
                break;
            default:
                Console.WriteLine("Kurang");
                break;
        }

        Console.WriteLine("~~~~~~~~~~~~~~");

        // For loop & While loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Perulangan ke " + i);
        }

        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("Perulangan ke " + j);
            j++;
        }

        Console.ReadLine();
    }
}
}


