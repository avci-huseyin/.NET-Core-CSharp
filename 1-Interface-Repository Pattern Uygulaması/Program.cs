using System;
namespace ConsoleApp
{

    interface IKisi
    {
        string adSoyad {get;set;}
        string adres {get;set;}
        string departman { get; set; }
        double maas { get; set; }
        
    }
    interface IPersonel
    {       
        string departman { get; set; }
        void bilgi();

    }

    class Yonetici : IPersonel,IKisi
    {
        public Yonetici(string _adsoyad,string _adres,string _departman)
        {
            this.adSoyad = _adsoyad;
            this.adres = _adres;
            this.departman =_departman;
        }
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public double maas{ get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde yöneticidir.");
        }
    }

    class Isci: IPersonel,IKisi
    {
        public Isci(string _adsoyad,string _adres,string _departman)
        {
            this.adSoyad = _adsoyad;
            this.adres = _adres;
            this.departman =_departman;
        }
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public double maas { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde işçidir.");
        }
    }

    class Robot : IPersonel
    {
        public Robot(string _departman)
        {
            this.departman = _departman;
        }
        public string departman { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.departman} bölümünde bir robot.");            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {           
           // Interface

            // IPersonel y = new Yonetici();
            // IPersonel i = new Isci();

            var personeller = new IPersonel[3];

            personeller[0] = new Yonetici("ali yılmaz","istanbul","finans");
            personeller[1] = new Isci("ahmet cengiz","kocaeli","üretim");
            personeller[2] = new Robot("üretim");

            foreach (var personel in personeller)
            {
                personel.bilgi();
            }

        }
    }
}
