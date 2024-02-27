using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _9320RyanMillerDatabase
{
    public class CourseModel
    {
        public int _Courseid;
        public int _Managerid;
        public string _Coursename;
        public string _StartDate;
        public string _EndDate;
        public string _Timing;
        public decimal _Price;
        public string _Managername;
        public int _Capacity;

        public int CourseId
        {
            get { return _Courseid; }
            set { _Courseid = value; }
        }

        public int ManagerId
        {
            get { return _Managerid; }
            set { _Managerid = value; }
        }


        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }

        public string Coursename
        {
            get { return _Coursename; }
            set { _Coursename = value; }
        }

        public string Startdate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public string Enddate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public string Timing
        {
            get { return _Timing; }
            set { _Timing = value; }
        }
        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public string ManagerName
        {
            get { return _Managername; }
            set { _Managername = value; }
        }

        public CourseModel(int courseID, int managerID, string courseName, string courseSD, string courseED, decimal Price, string time, int capacity)
        {
            // WITH ID
            this._Courseid = courseID;
            this._Managerid = managerID;
            this._Coursename = courseName;
            this._StartDate = courseSD;
            this._EndDate = courseED;
            this._Capacity = capacity;
            this._Price = Price;
            this._Timing = time;
        }
        public CourseModel(string courseName, string courseSD, string courseED, string timing, decimal Price, int capacity, string ManagerName)
        {
            // NO ID

            this._Coursename = courseName;
            this._StartDate = courseSD;
            this._EndDate = courseED;
            this._Capacity = capacity;
            this._Price = Price;
            this._Timing = timing;
            this._Managername = ManagerName;
        }
        public CourseModel()
        {

        }
            
    }
}
