using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9320RyanMillerDatabase
{
    public class BookingModel
    {
        public int _BookingID;
        public int _CourseID;
        public string _BookingDate;
        public string _DiscountYN;
        public decimal _DiscountPercent;
        public int _CustomerNum;
        public int _CustomerQuantity;
        public int _Paid;
        
        public int BookingID
        {
            get { return _BookingID; }
            set { _BookingID = value; }
        }
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        public string BookingDate
        { 
            get { return _BookingDate; }           
            set { _BookingDate = value; } 
        }
        public string DiscountYN
        { 
            get { return _DiscountYN; }
            set { _DiscountYN = value; }
        }
        public decimal DiscountPercent
        {
            get { return _DiscountPercent; }
            set { _DiscountPercent = value; }
        }
        public int CustomerNum
        {
            get { return _CustomerNum; }
            set { _CustomerNum = value; }
        }
        public int CustomerQuantity
        {
            get { return _CustomerQuantity; }
            set { _CustomerQuantity = value; }
        }
        public int Paid
        {
            get { return _Paid; }
            set { _Paid = value; }
        }
        public BookingModel() 
        {

        }
        public BookingModel(int BookingID, int CourseID, string BookingDate, string Discount, decimal DiscountPercent, int CustomerNum, int Quantity, int Paid )
        {
            // WITH ID
            this.BookingID = BookingID;
            this.CourseID = CourseID;
            this.BookingDate = BookingDate;
            this.DiscountYN = Discount;
            this.DiscountPercent = DiscountPercent;
            this.CustomerNum = CustomerNum;
            this.CustomerQuantity = Quantity;
            this.Paid = Paid;
        }
        public BookingModel(int CourseID, string BookingDate, string Discount, decimal DiscountPercent, int CustomerNum, int Quantity, int Paid)
        {
            //WITHOUT ID
            this.CourseID = CourseID;
            this.BookingDate = BookingDate;
            this.DiscountYN = Discount;
            this.DiscountPercent = DiscountPercent;
            this.CustomerNum = CustomerNum;
            this.CustomerQuantity = Quantity;
            this.Paid = Paid;
            
        }
    }
}
