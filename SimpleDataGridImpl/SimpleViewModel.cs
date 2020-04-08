using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.Generic;
using System.Linq;

namespace SimpleDataGridImpl
{
    public class SimpleViewModel
    {
        public SimpleViewModel()
        {
            PersonList = new List<Person>(){
                new Person(){Name ="علي"},
                new Person(){Name ="محمود"},
                new Person(){Name ="مرتضي"},
                new Person(){Name ="حامد"},
            };
        }

        public List<Person> PersonList { get; set; }

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
                        PersonList.Add(new Person() { Name = "شخص جديد" });
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