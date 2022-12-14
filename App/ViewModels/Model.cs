using Application;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace App.Models
{
    /// <summary>
    /// Класс представляющий модель, которая хранит коллекцию 
    /// доступных функций, а также доступный список коэффициентов.
    /// </summary>
    public class Model
    {
        private Function _selectedFunction;

        /// <summary>
        /// Возвращает и задает коллекцию доступных функций.
        /// </summary>
        public ObservableCollection<Function> Functions { get; set; }

        /// <summary>
        /// Возвращает и задает коллекцию доступных коэффициентов.
        /// </summary>
        public ObservableCollection<int> Coefficients { get; set; }

        /// <summary>
        /// Возвращает и задает выбранную функцию. При изменении данного поля, 
        /// также обновляется коллекция доступных коэффициентов.
        /// </summary>
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

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
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

        /// <summary>
        /// Обновляет коллекцию доступных коэффициентов.
        /// </summary>
        /// <param name="collection">Коллекция для изменения</param>
        /// <param name="power">Степень числа</param>
        private void UpdateCoefficients(ObservableCollection<int> collection, int power)
        {
            var value = (int)Math.Pow(10, power - 1);
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = (i + 1) * value;
            }
        }

        /// <summary>
        /// При некорректном вводе, возвращает в TextBox последнее корректно введеное значение.
        /// </summary>
        private RelayCommand validateTextBoxCommand;
        public RelayCommand ValidateTextBoxCommand
        {
            get
            {
                return validateTextBoxCommand ?? (validateTextBoxCommand = new RelayCommand(obj =>
                {
                    var textbox = (TextBox)(((TextChangedEventArgs)obj).Source);
                    var a = 0;
                    if (!Int32.TryParse(textbox.Text, out a) && textbox.Text.Length != 0)
                    {
                        var currentCaretIndex = textbox.CaretIndex;
                        textbox.Text = GetTextBoxValue(textbox.Name);
                        textbox.CaretIndex = currentCaretIndex;
                    }
                }));
            }
        }

        /// <summary>
        /// Возвращает значение параметра привязанное к TextBox'у, в зависимости от имени TextBox'а.
        /// </summary>
        /// <param name="textBoxName">Имя TextBox'a</param>
        private string GetTextBoxValue(string textBoxName)
        {
            switch (textBoxName)
            {
                case "A":
                    return SelectedFunction.A.ToString();
                case "B":
                    return SelectedFunction.B.ToString();
                case "X":
                    return SelectedFunction.X.ToString();
                case "Y":
                    return SelectedFunction.Y.ToString();
            }
            return "";
        }
    }
}
