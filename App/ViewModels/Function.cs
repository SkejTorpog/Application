using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App.Models
{
    /// <summary>
    /// Класс, хранящий информацию о функции: название, коэффициенты, а также значение F(x,y).
    /// </summary>
    public class Function : INotifyPropertyChanged
    {
        private string _name;
        private int _a;
        private int _b;
        private int _c;
        private int _x;
        private int _y;
        private long _fxy;

        /// <summary>
        /// Возвращает и задает название функции. При изменении данного поля также пересчитывается значение F(x,y).
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                CalculateFunction();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент А. При изменении данного поля также пересчитывается значение F(x,y).
        /// </summary>
        public int A
        {
            get { return _a; }
            set
            {
                _a = value;
                CalculateFunction();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент B. При изменении данного поля также пересчитывается значение F(x,y).
        /// </summary>
        public int B
        {
            get { return _b; }
            set
            {
                _b = value;
                CalculateFunction();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент C. При изменении данного поля также пересчитывается значение F(x,y).
        /// </summary>
        public int C
        {
            get { return _c; }
            set
            {
                _c = value;
                CalculateFunction();
            }
        }

        /// <summary>
        /// Возвращает и задает значение X. При изменении данного поля также пересчитывается значение F(x,y).
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
                CalculateFunction();
            }
        }

        /// <summary>
        /// Возвращает и задает значение Y. При изменении данного поля также пересчитывается значение F(x,y).
        /// </summary>
        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
                CalculateFunction();
            }
        }

        /// <summary>
        /// Возвращает и задает значение Fxy.
        /// </summary>
        public long Fxy
        {
            get { return _fxy; }
            set
            {
                _fxy = value;
                OnPropertyChanged("Fxy");
            }
        }

        /// <summary>
        /// Вычисляет значение Fxy, в зависимости от названия функции.
        /// </summary>
        public void CalculateFunction()
        {
            switch (_name)
            {
                case "Линейная":
                    Fxy = A * X + B * 1 + C;
                    break;
                case "Квадратичная":
                    Fxy = A * (long)Math.Pow(X, 2) + B * Y + C;
                    break;
                case "Кубическая":
                    Fxy = A * (long)Math.Pow(X, 3) + B * (long)Math.Pow(Y, 2) + C;
                    break;
                case "4-ой степени":
                    Fxy = A * (long)Math.Pow(X, 4) + B * (long)Math.Pow(Y, 3) + C;
                    break;
                case "5-ой степени":
                    Fxy = A * (long)Math.Pow(X, 5) + B * (long)Math.Pow(Y, 4) + C;
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
