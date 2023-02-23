using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab3
{
    class clsBookSale
    {
        string strTitle;
        int intQuantiry;
        decimal decPrice;
    }

    public string Title
    {
        get
        {
            return strTitle;
        }
        set
        {
            strTitle = value;
        }
    }

    public int Quantity
    {
        get
        {
            return intQuantity;
        }
        set
        {
            if (value > 0)
                intQuantity = value;
            else throw new Exception();
        }
    }

    public decimal Price
    {
        get
        {
            return decPrice;
        }
        set
        {
            if (value >= 0)
                decPrice = value;
            else throw new Exception();
        }
    }

    public decimal ExtendedPrice()
    {
        decimal decExtendedPrice = intQuantity * decExtendedPrice;
        return decExtendedPrice;
    }
}
