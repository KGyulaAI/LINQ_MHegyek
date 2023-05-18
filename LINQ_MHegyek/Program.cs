namespace LINQ_MHegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hegyek hegyek = new Hegyek("hegyekMo.txt");
            Console.WriteLine($"3. feladat: {hegyek.GetNev.Count}");

            Console.WriteLine($"4. feladat: {hegyek.GetMagassag.Average()}");

            double legnagyobbHegyMagassaga = 0;
            int legnagyobbHegyMagasságIndexe = 0;
            for (int index = 0; index < hegyek.GetMagassag.Count; index++)
            {
                if (hegyek.GetMagassag[index] > legnagyobbHegyMagassaga)
                {
                    legnagyobbHegyMagassaga = hegyek.GetMagassag[index];
                    legnagyobbHegyMagasságIndexe = index;
                }
            }
            Console.WriteLine($"5. feladat: {hegyek.GetNev[legnagyobbHegyMagasságIndexe]}, {hegyek.GetHegyseg[legnagyobbHegyMagasságIndexe]}, {hegyek.GetMagassag[legnagyobbHegyMagasságIndexe]}");
            
            Console.WriteLine("6. feladat: Kérek egy magasságot: ");
            double hegymagassagBekeres = Convert.ToDouble(Console.ReadLine());
            for (int index = 0; index < hegyek.GetHegyseg.Count; index++)
            {
                if (hegyek.GetHegyseg[index] == "Börzsöny" && hegyek.GetMagassag[index] > hegymagassagBekeres)
                {
                    Console.WriteLine("Van nagyobb!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Nincs {hegymagassagBekeres}-nél nagyobb hegycsúcs!");
                }
            }
        }
    }
}