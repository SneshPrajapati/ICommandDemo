using RxPropertyAndCommand.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RxPropertyAndCommand.ViewModels
{
    public class WpfPropertyCommandViewModel : ViewModelBase
    {
        #region Private Fields

        private double firstValue;
        private double secondValue;
        private double output;
        #endregion

        #region Public Properties
        public double FirstValue
        {
            get { return firstValue; }

            set
            {
                firstValue = value;
                OnPropertyChanged("FirstValue");
                PerformOperation(null);
            }
        }


        public double SecondValue
        {
            get { return secondValue; }
            set
            {
                secondValue = value;
                OnPropertyChanged("SecondValue");
                PerformOperation(null);
            }
        }
        public double Output
        {

            get { return output; }

            set
            {
                output = value;
                OnPropertyChanged("Output");

            }
        }

        //private bool isAddChecked;
        //public bool IsAddChecked
        //{
        //    get { return isAddChecked; }

        //    set
        //    {
        //        isAddChecked = value;

        //    }
        //}

        //private bool isMinusChecked;
        //public bool IsMinusChecked
        //{
        //    get { return isMinusChecked; }

        //    set
        //    {
        //        isMinusChecked = value;

        //    }
        //}

        //private bool isMultiplyChecked;
        //public bool IsMultiplyChecked
        //{
        //    get { return isMultiplyChecked; }

        //    set
        //    {
        //        isMultiplyChecked = value;

        //    }
        //}

        //private bool isDivideChecked;
        //public bool IsDivideChecked
        //{
        //    get { return isDivideChecked; }

        //    set
        //    {
        //        isDivideChecked = value;

        //    }
        //}


        #endregion

        #region Commands


        public ICommand OperationCommand
        {
            get
            {

                return new RelayCommand<string>(param => this.PerformOperation(param));
            }
        }

        private string operationGiven = null;
        internal void PerformOperation(string param)
        {


            if (param != null) operationGiven = param;
            switch (operationGiven)
            {
                case "Add":
                    Add(); break;
                case "Minus":
                    Substract(); break;
                case "Multiply":
                    Multiply(); break;
                case "Divide":
                    Divide(); break;
            }

        }

        #endregion


        #region Methods

        internal void Add()
        {
            Output = firstValue + secondValue;

        }

        internal void Substract()
        {
            Output = firstValue - secondValue;
        }

        internal void Multiply()
        {
            Output = firstValue * secondValue;
        }

        internal void Divide()
        {
            Output = firstValue / secondValue;
        }

        #endregion


    }
}
