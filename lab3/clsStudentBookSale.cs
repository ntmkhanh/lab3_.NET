using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class clsStudentBookSale : clsBookSale
    {
        bool blnStudentDisCount;
        const float sngSTUDENT_DISCOUNT_RATE = 0.15F;

        public bool StudentDiscount
        {
            get
            {
                return blnStudentDisCount;
            }
            set
            {
                blnStudentDisCount = value;
            }
        }
        public clsStudentBookSale(string title, int quatity, decimal price, bool discount, bool student):base(title, quatity, price, discount)
        {
            blnStudentDisCount = student;
        }
        public override decimal DiscountAmount()
        {
            decimal decDiscountAmount;
            decDiscountAmount = base.DiscountAmount();
            if (StudentDiscount) decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sngSTUDENT_DISCOUNT_RATE);
           
            return decDiscountAmount;
        }

    }

}
