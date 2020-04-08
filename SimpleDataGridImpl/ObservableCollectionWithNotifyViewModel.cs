using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleDataGridImpl
{
    public class ObservableCollectionWithNotifyViewModel
    {
        public ObservableCollectionWithNotifyViewModel()
        {
            PersonList = new ObservableCollection<Person_notify>(){
                new Person_notify(){Name ="علي"},
                new Person_notify(){Name ="محمود"},
                new Person_notify(){Name ="مرتضي"},
                new Person_notify(){Name ="حامد"},
            };
        }

        public ObservableCollection<Person_notify> PersonList { get; set; }

        private RelayCommand _Delete;

        public RelayCommand Delete
        {
            get
            {
                return _Delete ?? (_Delete = new RelayCommand(
                    () =>
                    {
                        PersonList.Remove(PersonList.First());
                    }));
            }
        }

        private RelayCommand _Add;

        public RelayCommand Add
        {
            get
            {
                return _Add ?? (_Add = new RelayCommand(
                    () =>
                    {
                        PersonList.Add(new Person_notify() { Name = "شخص جديد" });
                    }));
            }
        }

        private RelayCommand _Edit;

        public RelayCommand Edit
        {
            get
            {
                return _Edit ?? (_Edit = new RelayCommand(
                    () =>
                    {
                        PersonList.First().Name = "يه اسم ديگه";
                    }));
            }
        }
    }
}