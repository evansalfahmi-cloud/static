/*
KATA KUNCI STATIC

pada kasus tertentu terkadang kita memerlukan satu data di dalam kelas yang nilainya dapat dibagi untuk setiap objek
dari kelas tersebut. dengan kata lain data ini adalah milik kelas, bukan milik objek
masing masing objek dari kelas tidak akan mempunyai salinan dari data tersebut
data semacam ini disebut data statis

atau disebut variabel milik nya kelas
pengaksesan data satis harus dilakukan menggunakan nama kelas, bukan melalui referensi eke objek
oleh karena itu untuk mengakses data statis kita tidak perlu membuat objek dari kelas terlebih dahulu
selain untuk data, sifat statis ini juga dapat diterapkan terhadap metode

batasan
metode statis hanya dapat memanggil metode lain yang bersifat statis
metode statis hanya dapat mengakses data yang bersifat statis
metode statsi tidak dapat diacu melalui referensi this

Konstruktor statis
dalam c# konstruktor dapat bersifat statis seperti layaknya metode
Konstruktor statis pada umumnya digunakan untuk melakukan inisialisasi terhadap data statis
misal untuk memuat nilai kongfigurasi program dari suatu file
maupun untuk melakukan tugas lain sesuai dengan kebutuhan program
perbedaan konstruktor statis dengan normal
adalah terletak pada proses pemanggilannnya

konstruktor statis akan dipanggil secara otomatis oleh CLR.NET (.NET RUNTIME) pada saat pertama kali kelas 
tersebut digunakan, sebelum konstruktor normal dipanggil

konstruktor statis tidak memiliki tipe ases pada proses pedefinisiann 
sehingga kita tidak dapat memanggilnya secara eksplisit melalui program

bentuk umum

class namaKelas {
    //konstruktor statis
    static namaKelas(){
        //kode konstruktor statis
    }
}
CONTOH
*/

using System ;
class Contoh {
    //data statis
    public static int a;

    //data non-statis
    public int b;

    //konstruktor statis
    static Contoh(){
        a = 10;
        Console.WriteLine ("Konstruktor statis dipanggil");
    }

    //konstruktor non statis
    public Contoh (int b){
        this.b = b;
        Console.WriteLine("Konstruktor Normal dipanggil");

    }
}

class demoKonkstruktorStatis1{
    static void Main (){
        //mengaksses data statis a
        //akan menyebabkan konstruktor statis dipanggil
        Console.WriteLine("contoh.a = "+ Contoh.a);
        Console.WriteLine();

        //buat objek pertama
        //akan menyebabkan konstruktor normal dipanggil
        Contoh obj1 = new Contoh(1000);
        Console.WriteLine("obj1.b = "+ obj1.b);
        Console.WriteLine();

        //buat objek kedua
        //akan menyebabkan konstruktor normal dipanggil
        Contoh obj2 = new Contoh(1500);
        Console.WriteLine("obj2.b = "+ obj2.b);
        Console.WriteLine();

        //buat objek ketiga
        //akan menyebabkan konstruktor normal dipanggil
        Contoh obj3 = new Contoh(1500);
        Console.WriteLine("obj3.b = "+ obj3.b);
        Console.WriteLine();
    }
}