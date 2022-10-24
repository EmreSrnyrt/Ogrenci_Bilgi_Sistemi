using System.Drawing;

internal class Program
{
    public static string[,] ogrenci_liste = new string[10,5];
    private static void Main(string[] args)
    {
        //string y = dondurme();
        //Console.WriteLine(y);
        //double ma = urme(5, 10);
        //Console.WriteLine(ma);

        ogrenci_liste[0, 0] = "Cihan";
        ogrenci_liste[0, 1] = "Geldi";
        ogrenci_liste[0, 2] = "60";
        ogrenci_liste[0, 3] = "75";
        ogrenci_liste[0, 4] = "80";
        ogrenci_liste[1, 0] = "Emre";
        ogrenci_liste[1, 1] = "Şirin";
        ogrenci_liste[1, 2] = "80";
        ogrenci_liste[1, 3] = "45";
        ogrenci_liste[1, 4] = "40";
        for (int i = 0; ; i++)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("---Öğrenci Not Sistemi---");
            Console.WriteLine("*************************\n");
            Console.WriteLine("----Öğrenci İşlemleri----");
            Console.WriteLine("Öğrenci Listele\t[1]");
            Console.WriteLine("Öğrenci Ekle\t[2]");
            Console.WriteLine("Öğrenci Düzenle\t[3]");
            Console.WriteLine("Öğrenci Notu Gör[4]");
            Console.WriteLine("Öğrenci Sil\t[5]");
            Console.WriteLine("Sistemi Kapat\t[0]");
            Console.WriteLine("\n\n----- İşlemi Seçiniz ----");
            Console.Write("Seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim >0)
            {
                switch(secim)
                {
                    case 1:
                        liste();
                       break;
                    case 2:
                        Console.Write("Öğrenci Adı Giriniz: ");
                        string ad = Console.ReadLine();
                        Console.Write("Öğrenci Soyad Giriniz: ");
                        string soyad = Console.ReadLine();
                        Console.Write("Öğrenci Vize Notu Giriniz: ");
                        double vize = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Öğrenci Final Notu Giriniz: ");
                        double final = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Öğrenci Proje Notu Giriniz: ");
                        double pnotu = Convert.ToDouble(Console.ReadLine());
                        listeEkle(ad, soyad, vize, final, pnotu);
                        break;
                    case 3:
                        listeDuzenle();
                        break;
                    case 4:
                        listeNotGor();
                        break;
                    case 5:
                        listeSil();
                        break;
                }
            }
            else if (secim == 0)
            {
                Console.WriteLine("Çıkış yapıldı");
                break;
            }
        }
        Console.ReadKey();
    }
    public static void liste()
    {
        for (int i = 0; i < ogrenci_liste.GetLength(0);i++)
        {
            for (int j = 0; j < ogrenci_liste.GetLength(1); j++)
            {
                Console.Write(ogrenci_liste[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static void listeEkle(string ad,string soyad,double not1, double not2, double pnot)
    {
        for (int i = 0; i < ogrenci_liste.GetLength(0); i++)
        {
            if (string.IsNullOrEmpty(ogrenci_liste[i,0]))
            {
                ogrenci_liste[i, 0] = ad;
                ogrenci_liste[i, 1] = soyad;
                ogrenci_liste[i, 2] = not1.ToString();
                ogrenci_liste[i, 3] = not2.ToString();
                ogrenci_liste[i,4] = pnot.ToString();
                break;
            }
        }
    }
    public static void listeDuzenle()
    {
        Console.Write("Düzenlenecek Öğrencinin İndeks Numarasını Giriniz: ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Öğrenci Adı Giriniz: ");
        string ad = Console.ReadLine();
        Console.Write("Öğrenci Soyad Giriniz: ");
        string soyad = Console.ReadLine();
        Console.Write("Öğrenci Vize Notu Giriniz: ");
        double vize = Convert.ToDouble(Console.ReadLine());
        Console.Write("Öğrenci Final Notu Giriniz: ");
        double final = Convert.ToDouble(Console.ReadLine());
        Console.Write("Öğrenci Proje Notu Giriniz: ");
        double pnotu = Convert.ToDouble(Console.ReadLine());
        ogrenci_liste[i, 0] = ad;
        ogrenci_liste[i, 1] = soyad;
        ogrenci_liste[i, 2] = vize.ToString();
        ogrenci_liste[i, 3] = final.ToString();
        ogrenci_liste[i, 4] = pnotu.ToString();
    }
    public static void listeNotGor() 
    {
        Console.Write("Notu Gösterilecek Öğrencinin İndeks Numarasını Giriniz: ");
        int i = Convert.ToInt32(Console.ReadLine());
        for (int j =0; j < ogrenci_liste.GetLength(1);j++)
        {
            Console.Write(ogrenci_liste[i, j] + " ");
        }
        Console.WriteLine();
    }
    public static void listeSil()
    {
        Console.Write("Silinecek Öğrencinin İndeks Numarasını Giriniz: ");
        int i = Convert.ToInt32(Console.ReadLine());
        for (int s = 0; s < 5; s++)
        {
            ogrenci_liste[i, s] = null;
        }
        //ogrenci_liste[i, 0] = null;
        //ogrenci_liste[i, 1] = null;
        //ogrenci_liste[i, 2] = null;
        //ogrenci_liste[i, 3] = null;
        //ogrenci_liste[i, 4] = null;
    }
    //public static string dondurme()
    //{
    //    string x = "selam";
    //    return x;
    //}
    //public static double urme(double i,double j)
    //{
    //    double onuc = (i + j)/2;
    //    return onuc;
    //}
}