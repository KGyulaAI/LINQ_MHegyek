using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_MHegyek
{
    internal class Hegyek
    {
        List<string> nev = new List<string>();
        List<string> hegyseg = new List<string>();
        List<double> magassag = new List<double>();
        public Hegyek(string fajlnev)
        {
            StreamReader streamReader = new StreamReader(fajlnev);
            streamReader.ReadLine();
            string sor;
            while ((sor = streamReader.ReadLine()) != null)
            {
                nev.Add(sor.Split(';')[0]);
                hegyseg.Add(sor.Split(";")[1]);
                magassag.Add(Convert.ToDouble(sor.Split(";")[2]));
            }
            streamReader.Close();
        }

        public List<string> GetNev { get => nev; }
        public List<string> GetHegyseg { get => hegyseg; }
        public List<double> GetMagassag { get => magassag; }
    }
}
