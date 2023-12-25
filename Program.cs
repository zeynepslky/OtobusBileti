using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti
{
    class Program
    {
        static void Main(string[] args)
        {

            Otobus otobus = new Otobus("Metro", 40, "Pazartesi", "15:00", "34 ABC 123", "Düzce - İstanbul", "Berceste Dinlenme Tesisleri", 400, 600);

            Console.WriteLine("Otobüs Firması: " + otobus.FirmaAdi);
            Console.WriteLine("Otobüs Güzergahı: " + otobus.Guzergah);
            Console.WriteLine("Otobüs Kalkış Saati: " + otobus.Saat);
            Console.WriteLine("Mola Yeri: " + otobus.MolaYeri);

            otobus.BiletSat(true);
            otobus.BiletSat(true);
            otobus.BiletSat(false);
            otobus.BiletSat(true);
            otobus.BiletSat(false);
            otobus.BiletSat(false);
            otobus.BiletSat(true);

            otobus.BosKoltukOgren();

            otobus.KazancOgren();

            otobus.MolaYeri = "Türsan Dinlenme Tesisleri"; // Mola yeri değiştirdik
            Console.WriteLine("Mola Yeri: " + otobus.MolaYeri);

            otobus.BiletIptal(true);
            otobus.BiletIptal(false);
            otobus.BiletIptal(true);

            otobus.IptalSayisiOgren(); 

            otobus.BosKoltukOgren();

            otobus.KazancOgren();


        }
    }
}
