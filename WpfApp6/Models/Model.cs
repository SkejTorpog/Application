using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfApp6
{
    public class Model
    {
        private Function _selectedFunction;

        public ObservableCollection<Function> Functions { get; set; }

        public ObservableCollection<int> Coefficients { get; set; }

        public Function SelectedFunction
        {
            get { return _selectedFunction; }
            set
            {
                _selectedFunction = value;

                switch (SelectedFunction?.Name)
                {
                    case "Линейная":
                        UpdateCoefficients(Coefficients, 1);
                        break;
                    case "Квадратичная":
                        UpdateCoefficients(Coefficients, 2);
                        break;
                    case "Кубическая":
                        UpdateCoefficients(Coefficients, 3);
                        break;
                    case "4-ой степени":
                        UpdateCoefficients(Coefficients, 4);
                        break;
                    case "5-ой степени":
                        UpdateCoefficients(Coefficients, 5);
                        break;
                }
            }
        }

        public Model()
        {
            Functions = new ObservableCollection<Function>()
            {
                new Function { Name = "Линейная" },
                new Function { Name = "Квадратичная" },
                new Function { Name = "Кубическая" },
                new Function { Name = "4-ой степени" },
                new Function { Name = "5-ой степени" },
            };

            Coefficients = new ObservableCollection<int>
            {
                1,2,3,4,5
            };

            SelectedFunction = Functions[0];
        }

        private void UpdateCoefficients(ObservableCollection<int> list, int power)
        {
            int value = (int)Math.Pow(10, power - 1);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (i + 1) * value;
            }
        }
    }
}
