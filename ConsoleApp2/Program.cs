






internal class Program
{
    private static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyat = 15;
        string aciklama = "Amasya Elması";

        string[] meyveler = new string[] { };

        var urun1 = new Product();
        urun1.Adi= "Elma";
        urun1.Fiyati = 16;
        urun1.aciklama = "Amasya Elması";
        urun1.Id = 2;
        
        
        
        var urun2 = new Product();
        urun2.Adi = "karpuz";
        urun2.Fiyati = 15;
        urun2.aciklama = "Diyarbakır Karpuzu";
        urun2.Id = 1;


        Product[] products = new Product[] {urun1,urun2};

        foreach (Product product in products)
        {
                Console.WriteLine(product.Adi);
            Console.WriteLine(product.Fiyati);
            Console.WriteLine(product.aciklama);
            Console.WriteLine(product.Id);
            Console.WriteLine("-------------------- ");
            
           
            
            

        }

        Console.WriteLine("--------------Metotlar----------");


        //instane
        //encapsulation

        SepetManager sepetManager = new SepetManager();

        sepetManager.Add(urun1);
        sepetManager.Add(urun2);

        sepetManager.Add2("ARMUT", "YEŞİL ARMUT", 12);
        sepetManager.Add2("lale", "geziLaleli", 15);



    }
}











// dont rpeat your self - DRY - Clean Code - Best Practice