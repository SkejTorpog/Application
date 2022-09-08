using App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using Application;

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

        private RelayCommand test;
        public RelayCommand Test
        {
            get
            {
                return test ?? (test = new RelayCommand(obj =>
                {
                    var textbox = (TextBox)(((TextChangedEventArgs)obj).Source);
                    int a;
                    if (!Int32.TryParse(textbox.Text, out a) && textbox.Text.Length != 0) 
                    {
                        var currentCaretIndex = textbox.CaretIndex;
                        textbox.Text = testMethod(textbox.Name);
                        textbox.CaretIndex = currentCaretIndex;
                    }    
                }));
            }
        }

        private string testMethod(string textBoxName)
        {
            switch(textBoxName)
            {
                case "A":
                    return SelectedModel.SelectedFunction.A.ToString();
                case "B":
                    return SelectedModel.SelectedFunction.B.ToString();
                case "X":
                    return SelectedModel.SelectedFunction.X.ToString();
                case "Y":
                    return SelectedModel.SelectedFunction.Y.ToString();
            }
            return "";
        }
    }
}
