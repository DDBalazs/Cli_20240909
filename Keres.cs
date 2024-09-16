using System.Globalization;

namespace Cli_20240909
{
    internal class Keres
    {
        public string Cim { get; set; }
        public DateTime Ido { get; set; }
        public string Kep { get; set; }
        public int Kod { get; set; }
        public int? Meret { get; set; }
        public bool Domain => !char.IsNumber(Cim[^1]);
        public Keres(string beolvasottSor)
        {
            string[] darabok = beolvasottSor.Split('*');
            Cim = darabok[0];
            Ido = DateTime.ParseExact(darabok[1], "dd/MMM/yyyy:HH:mm:ss",CultureInfo.InvariantCulture);
            Kep = darabok[2];
            string[] kodmeret = darabok[3].Split(' ');
            Kod = int.Parse(kodmeret[0]);
            Meret = kodmeret[1] == "-" ? null : int.Parse(kodmeret[1]);

        }
    }
}
