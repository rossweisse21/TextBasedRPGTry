using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TextBased.Uzuvlar;


namespace TextBased.Karakterler.Insan
{
    internal class Insan : Silahlar.Silahlar, Uzuvlar.Uzuvlar, Inventory.Zırh

    {
        Silah slh = Silah.Gun;
        Inventory.Zırh.Zırhlar zirh;

        Uzuvlar.Uzuvlar.Uzuv kafa = Uzuvlar.Uzuvlar.Uzuv.Kafa;
        Uzuvlar.Uzuvlar.Uzuv govde = Uzuvlar.Uzuvlar.Uzuv.Govde;
        Uzuvlar.Uzuvlar.Uzuv kol = Uzuvlar.Uzuvlar.Uzuv.Kol;
        Uzuvlar.Uzuvlar.Uzuv bacak = Uzuvlar.Uzuvlar.Uzuv.Bacak;

        zirh = null; 




    }
}
