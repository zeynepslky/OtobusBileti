using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti
{
    public class Otobus
    {
        public string FirmaAdi;
        public int ToplamKoltukSayisi;
        public int BosKoltukSayisi;
        public string Gun;
        public string Saat;
        public string Plaka;
        public string Guzergah;
        public string MolaYeri;
        public int Indirimli;
        public int Tam;
        public int Kazanc = 0;
        public int IptalSayisi = 0;


        public Otobus(string FirmaAdi, int KoltukSayisi, string Gun, string Saat, string Plaka, 
            string Guzergah, string MolaYeri, int Indirimli, int Tam)
        {
            this.FirmaAdi = FirmaAdi;
            this.ToplamKoltukSayisi = KoltukSayisi;
            this.BosKoltukSayisi = KoltukSayisi;
            this.Gun = Gun;
            this.Saat = Saat;
            this.Plaka = Plaka;
            this.Guzergah = Guzergah;
            this.MolaYeri = MolaYeri;
            this.Indirimli = Indirimli;
            this.Tam = Tam;

        }

        
        public void BiletSat(bool indirimliMi)
        {
            if (BosKoltukSayisi > 0 )
            {
                BosKoltukSayisi--;

                if (indirimliMi) // İndirimli bilet satışı
                {
                    Kazanc = Kazanc + Indirimli;
                    Console.WriteLine("Bir adet indirimli bilet satıldı.");
                }
                else // İndirimsiz bilet satışı
                {
                    Kazanc = Kazanc + Tam;
                    Console.WriteLine("Bir adet tam bilet satıldı.");
                }
            }

            else
            {
                Console.WriteLine("Boş koltuk yoktur.");
            }
        }


        public void BiletIptal(bool indirimliMi)
        {
            IptalSayisi++;
            BosKoltukSayisi++;
            if (indirimliMi)
            {
                Kazanc = Kazanc - Indirimli;
            }
            else
            {
                Kazanc = Kazanc - Tam;
            }

        }


        public void BosKoltukOgren()
        {
            Console.WriteLine("Toplam satılan bilet sayısı:" + (ToplamKoltukSayisi - BosKoltukSayisi));
            Console.WriteLine("Boş koltuk sayısı: " + BosKoltukSayisi);

        }


        public void KazancOgren()
        {
            Console.WriteLine("Kazanç: " + Kazanc);

        }

        public void IptalSayisiOgren()
        {
            Console.WriteLine("İptal edilen bilet sayısı: " + IptalSayisi);
        }
       


    }
}
