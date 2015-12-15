using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RxPropertyAndCommand.ViewModels
{
   public class ReactivePropertyViewModel
    {  public ReactiveProperty<double> FirstValue { get; private set; }
        public ReactiveProperty<double> SecondValue { get; private set; }
        public ReactiveProperty<double> Output { get; private set; }
        public ReactiveProperty<bool> Add { get; private set; }
        public ReactiveProperty<bool> Substract { get; private set; }
        public ReactiveProperty<bool> Multiply { get; private set; }
        public ReactiveProperty<bool> Divide { get; private set; }
        public ReactivePropertyViewModel()
        {
            FirstValue = new ReactiveProperty<double>(0.0);
            SecondValue = new ReactiveProperty<double>();
            Output = new ReactiveProperty<double>();
            Add = new ReactiveProperty<bool>();
            Substract = new ReactiveProperty<bool>();
            Multiply = new ReactiveProperty<bool>();
            Divide = new ReactiveProperty<bool>();
            Add.Subscribe(x =>
            {
                if (x == true)
                {
                    FirstValue.Subscribe(y => { Output.Value = FirstValue.Value + SecondValue.Value; });
                    SecondValue.Subscribe(y => { Output.Value = FirstValue.Value + SecondValue.Value; });
                }
            });

            Substract.Subscribe(x =>
            {
                if (x == true)
                {
                    FirstValue.Subscribe(y => { Output.Value = FirstValue.Value - SecondValue.Value; });
                    SecondValue.Subscribe(y => { Output.Value = FirstValue.Value - SecondValue.Value; });
                }
            });
            Multiply.Subscribe(x =>
            {
                if (x == true)
                {
                    FirstValue.Subscribe(y => { Output.Value = FirstValue.Value * SecondValue.Value; });
                    SecondValue.Subscribe(y => { Output.Value = FirstValue.Value * SecondValue.Value; });
                }
            });
           Divide.Subscribe(x =>
            {
                if (x == true)
                {
                    FirstValue.Subscribe(y => { Output.Value = FirstValue.Value / SecondValue.Value; });
                    SecondValue.Subscribe(y => { Output.Value = FirstValue.Value / SecondValue.Value; });
                }
            });

        }

        
    }
}
