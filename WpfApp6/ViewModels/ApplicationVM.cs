using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp6
{
    /// <summary>
    /// View Model
    /// </summary>
    public class ApplicationVM
    {
        private Model _selectedModel;

        /// <summary>
        /// Возвращает и задает выбранную модель.
        /// </summary>
        public Model SelectedModel
        {
            get { return _selectedModel; }
            set
            {
                _selectedModel = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает список моделей.
        /// </summary>
        public List<Model> Models { get; set; }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public ApplicationVM()
        {
            Models = new List<Model>() { new Model() };
            _selectedModel = Models[0];
        }        
    }
}
