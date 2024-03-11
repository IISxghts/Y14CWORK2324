using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9320RyanMillerDatabase
{
    public class CustomerModel
    {
        public  int _id;
        public string _fname;
        public string _sname;
        public string _pcode;
        public string _address;
        public string _town;
        public string _phone;
        public DateTime _dob;
        public string _specialreqs;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _fname; }            
            set { _fname = value; }
        }

        public string Surname
        {
            get { return _sname; }
            set { _sname = value; }
        }
        public string PostalCode
        {
            get { return _pcode; }
            set { 
                _pcode = value; }
        }
        public string Address
        {
            get { return _address; }
             set {_address = value; }
        }
        public string Town
        {
            get { return _town;  }
            set { _town = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set {  _phone = value; }
        }
        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string SpecialReqs
        {
            get { return _specialreqs; }
            set { _specialreqs = value; }
        }
        public CustomerModel()
        {

        }
        
        public CustomerModel(int custID, string firstname, string surname, string postcode, string address, string town, string phone, DateTime dob, string specialreqs)
        {
            // WITH ID for editing an existing customer
            
            this._id = custID;
            this._fname = firstname;
            this._sname = surname;
            this._pcode = postcode;
            this._address = address;
            this._town = town;
            this._phone = phone;
            this._dob = dob;
            this._specialreqs = specialreqs;
        }
        public CustomerModel(string firstname, string surname, string postcode, string address, string town, string phone, DateTime dob, string specialreqs)
        {
            // NO ID for creating a new customer

            //Validation

            if (ValidationClass.GenericLength(firstname) != true)
            {
                throw new ArgumentException("First name invalid");
            }
            else if (ValidationClass.GenericLength(surname) != true)
            {
                throw new ArgumentException("Surname invalid");
            }
            else if (ValidationClass.PhoneLength(phone) != true)
            {
                throw new ArgumentException("Phone number invalid");
            }
            else if (ValidationClass.PostcodeChecker(postcode) != true)
            {
                throw new ArgumentException("Postcode invalid");
            }

            
            this._fname = firstname;
            this._sname = surname;
            this._pcode = postcode;
            this._address = address;
            this._town = town;
            this._phone = phone;
            this._dob = dob;
            this._specialreqs = specialreqs;
        }
    }
}
