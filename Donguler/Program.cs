string kurs1 = "yazılım kursu 1";
string kurs2 = "c#";
string kurs3 = "java";



Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);

Console.WriteLine("---------------------------------------------------------------------------------");



//array
string[] kurslar = new string[] {"c#","java","yazılımGeliştirme" };





for (int i = 1; i < kurslar.Length; i++)
{
    
    Console.WriteLine(kurslar[i]);
}


Console.WriteLine("for Bitti");



foreach ( string kurs in kurslar)
{
    Console.WriteLine(kurs);
}













Console.WriteLine("SayfaSonu");
