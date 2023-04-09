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

using System;
class persegiPanjang {
    //class variable
    private static int hitungIni = 0 ;

    //instance variable
    private double panjang;
    private double lebar;

    //konstruktor
    public persegiPanjang(double p, double l){
        panjang = p;
        lebar = l;
        //menaikan nilai counter
        hitungIni ++;
    }

    //instance method
    private double rumusLuas(){
        return panjang*lebar;
    }

    //instance method
    public void tampilkanLuas (){
        Console.WriteLine("LUAS = "+rumusLuas());
    }
    
    //class method
    public static int dapatHitungan (){
        return hitungIni;
    }
}

class demoStatis {
    static void Main (){
        Console.WriteLine("Jumlah objek awal : "+ persegiPanjang.dapatHitungan());

        //membuat objek 1,2,3
        persegiPanjang perPjg1 = new persegiPanjang (4,3);
        persegiPanjang perPjg2 = new persegiPanjang (5,4);
        persegiPanjang perPjg3 = new persegiPanjang (7,6);
        
        //menghitungjumlah objek
        Console.WriteLine("Jumlah objek akhir : "+ persegiPanjang.dapatHitungan());
        }
}