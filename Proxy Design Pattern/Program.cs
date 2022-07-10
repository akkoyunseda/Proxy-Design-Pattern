using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();

            Console.WriteLine("Ne sipariş etmek istersiniz?");
            string sipariş = Console.ReadLine();
            proxy.SiparişAl(sipariş);
            Console.WriteLine("Tabii! Buyurun " + proxy.SiparişTeslim() + " . \n");
            Console.WriteLine("Nasıl ödemek istersiniz?");
            string ödeme = Console.ReadLine();
            proxy.OdemeAl(ödeme);

            Console.ReadKey();

        }
    }
}
