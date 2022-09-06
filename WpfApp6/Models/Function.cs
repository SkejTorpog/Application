using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    public class Function: INotifyPropertyChanged
    {
        private string _name;
        private int _a;
        private int _b;
        private int _c;
        private int _x;
        private int _y;
        private int _fxy;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                CalculateFunction();
            }
        }

        public int A
        {
            get { return _a; }
            set
            {
                _a = value;
                CalculateFunction();
            }
        }
        public int B
        {
            get { return _b; }
            set
            {
                _b = value;
                CalculateFunction();
            }
        }
        public int C
        {
            get { return _c; }
            set
            {
                _c = value;
                CalculateFunction();
            }
        }
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
                CalculateFunction();
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
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

        private void CalculateFunction()
        {
            switch (_name)
            {
                case "Линейная":
                    Fxy = A * X + B * 1 + C;
                    break;
                case "Квадратичная":
                    Fxy = A * (int)Math.Pow(X, 2) + B * Y + C;
                    break;
                case "Кубическая":
                    Fxy = A * (int)Math.Pow(X, 3) + B * (int)Math.Pow(Y, 2) + C;
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
