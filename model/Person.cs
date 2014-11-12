using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVMPersonUdenNotification.model
{
    public class Person
    {

        private String _name;
        private String _phone;
        private String _address;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Person(string name, string phone, string address)
        {
            _name = name;
            _phone = phone;
            _address = address;
        }

        public override string ToString()
        {
            return _name;
            //return string.Format("Name: {0}, Phone: {1}, Address: {2}", _name, _phone, _address);
        }
    }
}
