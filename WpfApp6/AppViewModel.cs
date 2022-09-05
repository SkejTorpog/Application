using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    public class AppViewModel
    {
        private MathModel _selectedModel;
        private string _selectedFunction;
        private ObservableCollection<int> _coefficients;

        public List<MathModel> ModelsList { get; set; }
        public ObservableCollection<string> Functions { get; set; }
        public ObservableCollection<int> Сoefficients
        {
            get
            {
                return _coefficients;
            }
            set
            {
                _coefficients = value;
            }
        }

        public MathModel SelectedModel
        {
            get
            {
                return _selectedModel;
            }
            set
            {
                _selectedModel = value;
            }
        }

        public string SelectedFunction
        {
            get
            {
                return SelectedModel.Func;
            }
            set
            {
                SelectedModel.Func = value;
                
                System.Diagnostics.Trace.WriteLine(SelectedModel.Func);
                switch (SelectedModel.Func)
                {
                    case "Линейная":
                        UpdateCoefficients(Сoefficients, 1);
                        break;
                    case "Квадратичная":
                        UpdateCoefficients(Сoefficients, 2);
                        break;
                    case "Кубическая":
                        UpdateCoefficients(Сoefficients, 3);
                        break;
                    case "4-ой степени":
                        UpdateCoefficients(Сoefficients, 4);
                        break;
                    case "5-ой степени":
                        UpdateCoefficients(Сoefficients, 5);
                        break;
                }

                OnPropertyChanged("SelectedFunction");
                //System.Diagnostics.Trace.WriteLine(_coefficients[1]);
            }
        }

        public AppViewModel()
        {
            ModelsList = new List<MathModel>
            {
                new MathModel()
            };

            _selectedModel = ModelsList[0];
            Functions = new ObservableCollection<string> {
                new string("Линейная"),
                new string("Квадратичная"),
                new string("Кубическая"),
                new string("4-ой степени"),
                new string("5-ой степени")
            };
            
            Сoefficients = new ObservableCollection<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            SelectedFunction = Functions[0];
        }

        private void UpdateCoefficients(ObservableCollection<int> list, int power)
        {
            int value = (int)Math.Pow(10,power-1);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (i + 1) * value;
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
