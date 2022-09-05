using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    public class MathModel: INotifyPropertyChanged
    {
        private string _func;
        private int _a;
        private int _b;
        private int _c;
        private int _x;
        private int _y;
        private int _fxy;
        
        public string Func
        {
            get { return _func; }
            set
            {
                _func = value;
                OnPropertyChanged("Func");
            }
        }

        public int A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged("A");
                CalculateFunction();
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
                CalculateFunction();
            }
        }

        public int C
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged("C");
                CalculateFunction();
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
                CalculateFunction();
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
                CalculateFunction();
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

        private void Sum(int power = 1)
        {
            //Fxy = A*X + B*(int)Math.Pow(Y,power) + C;
            Fxy = A + B + C + X + Y;
        }

        private void CalculateFunction()
        {
            switch (_func)
            {
                case "Линейная":
                    Fxy = A * X + B * 1 + C;
                    break;
                case "Квадратичная":
                    Fxy = A * (int)Math.Pow(X,2) + B * Y + C;
                    break;
                case "Кубическая":
                    Fxy = A * (int)Math.Pow(X, 3) + B * (int)Math.Pow(Y,2) + C;
                    break;
                case "4-ой степени":
                    Fxy = A * (int)Math.Pow(X, 4) + B * (int)Math.Pow(Y, 3) + C;
                    break;
                case "5-ой степени":
                    Fxy = A * (int)Math.Pow(X, 5) + B * (int)Math.Pow(Y, 4) + C;
                    break;
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
