using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    public class ApplicationVM
    {
        private Model _selectedModel;

        public Model SelectedModel
        {
            get { return _selectedModel; }
            set
            {
                _selectedModel = value;
            }
        }
        
        public List<Model> Models { get; set; }

        public ApplicationVM()
        {
            Models = new List<Model>() { new Model() };
            _selectedModel = Models[0];
        }        
    }
}
