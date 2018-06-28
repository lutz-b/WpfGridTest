using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Prism.Mvvm;
using WpfGridTest.Classes;

namespace WpfGridTest
{
    public class ViewModel : BindableBase
    {
        public string TestString => "Copy";

        public IEnumerable<DataModel> DataModels => new List<DataModel>
        {
            new DataModel(1,"1234234234523423"),
            new DataModel(2,"werfw34523fe445"),
            new DataModel(3,"werfw34523fe445"),
            new DataModel(4,"werfw34523fe445")
        };



        public ViewModel()
        {
            Things = new ObservableCollection<object>();
            Things.Add(new Thing1());
            Things.Add(new Thing2());
        }


        public ObservableCollection<Object> Things { get; set; }
        private Object _selectedThing;
        private DateTime _testDateTime = DateTime.Today;

        public Object SelectedThing
        {
            get
            {
                return _selectedThing;
            }
            set
            {
                if (value != _selectedThing)
                {
                    SetProperty(ref _selectedThing , value);
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedThing)));
                }
            }
        }

        public DateTime TestDateTime
        {
            get => _testDateTime;
            set => SetProperty(ref _testDateTime, value);
        }
    }
}