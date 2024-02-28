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
        public DateTime _BookingDate;
        public bool _DiscountYN;
        public int _DiscountPercent;
        public int _CustomerNum;
        public int _CustomerQuantity;
        
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
        public DateTime BookingDate
        { 
            get { return _BookingDate; }           
            set { _BookingDate = value; } 
        }
        public bool DiscountYN
        { 
            get { return _DiscountYN; }
            set { _DiscountYN = value; }
        }
        public int DiscountPercent
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

        public BookingModel() 
        {

        }
        public BookingModel(int BookingID, int CourseID, DateTime BookingDate, bool Discount, int DiscountPercent, int CustomerNum, int Quantity )
        {
            // WITH ID
            this.BookingID = BookingID;
            this.CourseID = CourseID;
            this.BookingDate = BookingDate;
            this.DiscountYN = Discount;
            this.DiscountPercent = DiscountPercent;
            this.CustomerNum = CustomerNum;
            this.CustomerQuantity = Quantity;
        }
        public BookingModel(int CourseID, DateTime BookingDate, bool Discount, int DiscountPercent, int CustomerNum, int Quantity)
        {
            //WITHOUT ID
            this.BookingDate = BookingDate;
            this.CourseID = CourseID;
            this.DiscountYN = Discount;
            this.DiscountPercent = DiscountPercent;
            this.CustomerNum = CustomerNum;
            this.CustomerQuantity = Quantity;
            
        }
    }
}
