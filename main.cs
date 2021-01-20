using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Musteri musteri1 = new Musteri();
    musteri1.musteriId = "12345678910";
    musteri1.musteriAdi = "Hamidin";
    musteri1.musteriSoyadi = "Küçükoğlu";
    musteri1.hesaptakiPara = 1500;

    Musteri musteri2 = new Musteri();
    musteri2.musteriId = "13579111317";
    musteri2.musteriAdi = "Gizem";
    musteri2.musteriSoyadi = "Kurtulmuş";
    musteri2.hesaptakiPara = 5000;

    Musteri musteri3 = new Musteri();
    musteri3.musteriId = "32154586900";
    musteri3.musteriAdi = "Zülfü";
    musteri3.musteriSoyadi = "Livaneli";
    musteri3.hesaptakiPara = 2500000;

    MusteriManager musteriManager = new MusteriManager();
    musteriManager.YeniMusteri(musteri1);

    Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};
    
    musteriManager.MusterileriSirala(musteriler);

    musteriManager.MusteriSil(musteri2);


  }
}

class Musteri
{
  public string musteriId { get; set; }
  public string musteriAdi { get; set; }
  public string musteriSoyadi { get; set; }
  public double hesaptakiPara { get; set; }
}

class MusteriManager
{
  public void YeniMusteri(Musteri musteri)
  {
    Console.WriteLine("{0} müşterisi başarıyla eklendi \n", musteri.musteriAdi);
  }

  public void MusterileriSirala(Musteri[] musteriler)
  {
    foreach (Musteri musteri in musteriler)
    {
      Console.WriteLine(musteri.musteriId);
      Console.WriteLine(musteri.musteriAdi);
      Console.WriteLine(musteri.musteriSoyadi);
      Console.WriteLine(musteri.hesaptakiPara);
      Console.WriteLine("\n");
    }
  }

  public void MusteriSil(Musteri musteri)
  {
    Console.WriteLine("{0} müşterisi başarıyla silindi \n", musteri.musteriAdi);
  }
}