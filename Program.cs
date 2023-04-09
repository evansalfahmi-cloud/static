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

==========
KELAS STATIS
=========

dallam c#, kelas jg dapat dideklarasikan sifat statis
alasan
kita yakin bahwa kelas terseut tidak akan pernah diinstansiasi
semua anggota kelas bersifat statis

Contoh

*/

using System ; 

//mendefinisikan  kelas statis
static class Generator {
    private static int id;

    static Generator(){
        id = -1;
    }

    public static int lanjutHitung (){
        return ++id;
    }

    public static void Reset (){
        id = -1;
    }
}

class demoKelasSatis{
    static void Main (){
    
    //pemanggilan next pertama
    //akan menyebabkan konstruktor statis dipanggil
    int gen;
    gen = Generator.lanjutHitung();
    Console.Write("pemanggilan lanjut hitung pertama : ");
    Console.WriteLine(gen);

    
    gen = Generator.lanjutHitung();
    Console.Write("pemanggilan lanjut hitung kedua   : ");
    Console.WriteLine(gen);

   
    gen = Generator.lanjutHitung();
    Console.Write("pemanggilan lanjut hitung ketiga  : ");
    Console.WriteLine(gen);
    }
}