using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    public class MathModel: INotifyPropertyChanged
    {
        private int _a;
        private int _b;
        private int _c;
        private int _x;
        private int _y;
        private int _fxy;

        public int A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged("A");
                System.Diagnostics.Trace.WriteLine(_a);
            }
        }

        public int B
        {
            get { return _b; }
            set
            {
                _b = value;
                OnPropertyChanged("B");
            }
        }

        public int C
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged("C");
                System.Diagnostics.Trace.WriteLine(_c);
            }
        }

        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged("X");
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
            }
        }
        
        public int Fxy
        {
            get { return _fxy; }
            set
            {
                _fxy = value;
                OnPropertyChanged("Fxy");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
