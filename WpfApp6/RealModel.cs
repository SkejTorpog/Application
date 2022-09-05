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
        public ModelTemplate SelectedTemplate
        {
            get { return _selectedTemplate; }
            set
            {
                _selectedTemplate = value;
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
        }
    }
}
