using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace WpfApp6
{
    public class AppViewModel
    {
        private MathModel _model;
        private string _selectedFunction;

        public List<MathModel> ModelsList { get; set; }
        public BindingList<string> Functions { get; set; }
        public List<int> Сoefficients { get; set; }


        private RelayCommand command;
        public RelayCommand Command
        {
            get
            {
                return command ?? (command = new RelayCommand(obj =>
                System.Diagnostics.Trace.WriteLine(
                   _model.A + _model.B + _model.C)));
            }
        }

        public MathModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string SelectedFunction
        {
            get { return _selectedFunction; }
            set
            {
                _selectedFunction = value;
                System.Diagnostics.Trace.WriteLine(_selectedFunction);
            }
        }

        public AppViewModel()
        {
            ModelsList = new List<MathModel>
            {
                new MathModel()
            };

            _model = new MathModel();
            Functions = new BindingList<string> { 
                new string("Линейная"),
                new string("Квадратичная"), 
                new string("Кубическая"),
                new string("4-ой степени"),
                new string("5-ой степени")
            };

            Сoefficients = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
        }
    }
}
