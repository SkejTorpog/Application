using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    public class ApplicationVM //: INotifyPropertyChanged
    {
        private RealModel _selectedRealModel;

        public RealModel SelectedRealModel
        {
            get { return _selectedRealModel; }
            set
            {
                _selectedRealModel = value;
                //OnPropertyChanged("SelectedRealModel");
            }
        }
        
        public List<RealModel> RealModelsList { get; set; }
        
        public ApplicationVM()
        {
            RealModelsList = new List<RealModel>() { new RealModel() };
            _selectedRealModel = RealModelsList[0];
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //    }
        //}
    }
}
