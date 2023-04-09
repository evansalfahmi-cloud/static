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

====================
KELAS DI DALAM KELAS
====================

Kelas bagian dalam akan mengenali semua data maupun metode yang di deklarasikan di dalam kelas bagian luar, meskipun private
tapi metode tipe akses private yang di deklarasikan di kelas bagian dalam tidak bisa diakses atau dikenal oleh kelas bagian luar


Contoh

*/

using System;

//KELAS BAGIAN LUAR
class persegiPanjang {
    private double panjang;
    private double lebar;

    //konstruktor kelas bagian luar
    public persegiPanjang(double panjang, double lebar){
        this.panjang = panjang;
        this.lebar = lebar;
    }

    public void tampilData (){
        Console.WriteLine ("Panjang = "+ panjang);
        Console.WriteLine ("Lebar   = "+ lebar);
    } 

    // metode untuk menghasilkan objek persagipanjang berwarna
    public persegiPanjangBerwarna Salin (string warna){
        persegiPanjangBerwarna temp = new persegiPanjangBerwarna(this, warna);
        return temp;
    }

    //KELAS BAGIAN DALAM
    public class persegiPanjangBerwarna {
        private persegiPanjang obj;
        private string warna;

        //konstruktor bagian kelas dalam
        public persegiPanjangBerwarna (persegiPanjang obj, string warna){
            this.obj = obj;
            this.warna = warna;
        }

        //mengubah sifat dari tampilData pada kelas persegi panjang
        public void tampilData(){
            //memanggil persegipanjang.tampildata
            obj.tampilData();
            //menampbah sifat baru
            Console.WriteLine("Warna   = "+ warna);
        }
    }
    //akhir kelas dalam
} // akhir kelas luar

class demoKelasBersarang
{
    static void Main(){
        //membuat objek dari kelas bagian luar
        Console.WriteLine ("Objek Persegi Panjang");
        persegiPanjang perPjg1 = new persegiPanjang (9,8);
        perPjg1.tampilData();

        //membuat objek dari kelas bagian dalam
        Console.WriteLine("\nObjek Persegi Panjang Berwarna");
        persegiPanjang.persegiPanjangBerwarna perPjg2 = perPjg1.Salin ("mearah");
        perPjg2.tampilData();
    }
}