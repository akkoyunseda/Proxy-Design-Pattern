using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy1
{   
    /// <summary>
    /// Real concrete ve proxy sınıflarının kalıtım alacağı interface
    /// </summary>
    public interface ISunucu
    {
        void SiparişAl(string sipariş);
        string SiparişTeslim();
        void OdemeAl(string odeme);
    }


    /// <summary>
    /// Real concrate sınıfı
    /// </summary>
    class Servis : ISunucu
    {
        private string Sipariş;
        public void SiparişAl(string sipariş)
        {
            Console.WriteLine("Sunucu " + sipariş + " için sipariş oluşturuyor .\n");
            Sipariş = sipariş;
        }
        
        public string SiparişTeslim()
        {
            return Sipariş;
        }

        public void OdemeAl(string odeme)
        {
            Console.WriteLine("Sipariş için ödeme (" + odeme + ") oluşturuldu.");
        }
    }
    
    /// <summary>
    /// Proxy sınıfı
    /// </summary>
    class Proxy : ISunucu
    {
        private string Sipariş;
        private Servis _servis = new Servis();

        public void SiparişAl(string sipariş)
        {
            Console.WriteLine("(Sunucu " + sipariş + " için sipariş alıyor...)");
            Sipariş = sipariş;
            System.Threading.Thread.Sleep(2000);
        }

        public string SiparişTeslim()
        {
            return Sipariş;
        }

        public void OdemeAl(string odeme)
        {
            Console.WriteLine("(Sunucu ödemeyi işliyor lütfen bekleyin!)\n");
            System.Threading.Thread.Sleep(2000);
            _servis.OdemeAl(odeme);
        }
    }
}
