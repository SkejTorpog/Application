using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfApp6
{
    public class RealModel
    {
        private ModelTemplate _selectedTemplate;

        public ObservableCollection<ModelTemplate> ModelTemplates { get; set; }

        public ObservableCollection<int> Coefficients { get; set; }

        public ModelTemplate SelectedTemplate
        {
            get { return _selectedTemplate; }
            set
            {
                _selectedTemplate = value;

                switch (SelectedTemplate?.Name)
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
                System.Diagnostics.Trace.WriteLine(SelectedTemplate?.Name);
                System.Diagnostics.Trace.WriteLine(_selectedTemplate.Name);
            }
        }

        public RealModel()
        {
            ModelTemplates = new ObservableCollection<ModelTemplate>()
            {
                new ModelTemplate { Name = "Линейная" },
                new ModelTemplate { Name = "Квадратичная" },
                new ModelTemplate { Name = "Кубическая" },
                new ModelTemplate { Name = "4-ой степени" },
                new ModelTemplate { Name = "5-ой степени" },
            };

            Coefficients = new ObservableCollection<int>
            {
                1,2,3,4,5
            };
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
