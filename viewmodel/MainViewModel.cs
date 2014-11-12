using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DemoMVVMPersonUdenNotification.Annotations;
using DemoMVVMPersonUdenNotification.model;

namespace DemoMVVMPersonUdenNotification.viewmodel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<Person> _personer;
        private Person _selectedPerson;

        private OpretPersonHandler _opretPersonHandler;
        private RelayCommand _opretPersonCommand;

        public ObservableCollection<Person> Personer
        {
            get { return _personer; }
            set { _personer = value; }
        }

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }


        public OpretPersonHandler OpretPersonHandler
        {
            get { return _opretPersonHandler; }
            set { _opretPersonHandler = value; }
        }

        public RelayCommand OpretPersonCommand
        {
            get { return _opretPersonCommand; }
            set { _opretPersonCommand = value; }
        }

        public MainViewModel()
        {
            _personer = new ObservableCollection<Person>();
            _personer.Add(new Person("Peter", "22334455", "Sorø"));
            _personer.Add(new Person("Henrik", "98765432", "Lille Karleby"));

            _opretPersonHandler = new OpretPersonHandler(_personer);
            _opretPersonCommand = new RelayCommand(_opretPersonHandler.OpretPerson);

        }

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
