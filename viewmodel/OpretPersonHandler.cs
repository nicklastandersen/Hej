using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMVVMPersonUdenNotification.model;

namespace DemoMVVMPersonUdenNotification.viewmodel
{
    public class OpretPersonHandler
    {
        private String _navn;
        private String _adresse;
        private String _telefon;

        private ObservableCollection<Person> _personer;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public OpretPersonHandler(ObservableCollection<Person> personer)
        {
            _personer = personer;
        }

        public void OpretPerson()
        {
            Person p = new Person(_navn,_telefon,_adresse);
            _personer.Add(p);

        }
    }
}
