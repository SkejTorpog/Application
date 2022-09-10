using App.Models;
using System.Collections.Generic;

namespace App.ViewModels
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
            //Models = new List<Model>() { new Model() };
            Models = new List<Model>() { new Model() };
            _selectedModel = Models[0];
        }
    }
}
