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
*/

using System ; 
class Generator {
    //data statis
    private static int id = 0 ;
    //metode statis
    public static int hitungID(){
        return ++id;
    }
}

class demoStatis2 {
    static void Main (){
        string idBarang = "BRG-";
        int gen;

        //pemanggilan hitung iD
        gen = Generator.hitungID ();
        Console.Write(idBarang + gen);
        Console.WriteLine (": Televisi");

        //pemanggilan hitungID 2
        gen = Generator.hitungID ();
        Console.Write(idBarang + gen);
        Console.WriteLine(": Radio");

        //pemanggilan hitungID 3
        gen = Generator.hitungID ();
        Console.Write (idBarang + gen);
        Console.WriteLine(": Handphone");
        
    }
}