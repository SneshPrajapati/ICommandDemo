using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RxPropertyAndCommand.ViewModels
{
  public  class ReactiveCommandViewModel
    { public ReactiveProperty<double> FirstValue { get; private set; }
        public ReactiveProperty<double> SecondValue { get; private set; }
        public ReactiveProperty<double> Output { get; private set; }

        public ReactiveProperty<bool> Add { get; private set; }
        public ReactiveProperty<bool> Substract { get; private set; }
        public ReactiveProperty<bool> Multiply { get; private set; }
        public ReactiveProperty<bool> Divide { get; private set; }



        public ReactiveCommand OperationCommand { get; set; }


        public ReactiveCommandViewModel()
        {
            FirstValue = new ReactiveProperty<double>(0.0);
            SecondValue = new ReactiveProperty<double>();
            Output = new ReactiveProperty<double>();

            OperationCommand = new ReactiveCommand();

            OperationCommand.Subscribe(operation =>
            {
                var action = operation.ToString();
                switch (action)
                {
                    case "Add":
                        {
                            FirstValue.Subscribe(y => { Output.Value = FirstValue.Value + SecondValue.Value; });
                            SecondValue.Subscribe(y => { Output.Value = FirstValue.Value + SecondValue.Value; });
                            break;
                        }
                    case "Minus":
                        {
                            FirstValue.Subscribe(y => { Output.Value = FirstValue.Value - SecondValue.Value; });
                            SecondValue.Subscribe(y => { Output.Value = FirstValue.Value - SecondValue.Value; });
                            break;
                        }
                    case "Multiply":
                        {
                            FirstValue.Subscribe(y => { Output.Value = FirstValue.Value * SecondValue.Value; });
                            SecondValue.Subscribe(y => { Output.Value = FirstValue.Value * SecondValue.Value; });
                            break;
                        }
                    case "Divide":
                        {
                            FirstValue.Subscribe(y => { Output.Value = FirstValue.Value / SecondValue.Value; });
                            SecondValue.Subscribe(y => { Output.Value = FirstValue.Value / SecondValue.Value; });
                            break;
                        }
                }
               
            });

            //var CustomMode = ReactivePropertyMode.RaiseLatestValueOnSubscribe | ReactivePropertyMode.DistinctUntilChanged;

            //IsChecked1 = new ReactiveProperty<bool>(mode: CustomMode);
            //IsChecked2 = new ReactiveProperty<bool>(mode: CustomMode);

            //CurrentText = new ReactiveProperty<string>(initialValue: "Hi", mode: CustomMode);

            //ExecCommand = IsChecked1.CombineLatest(IsChecked1, CurrentText, (a, b, txt) => a && b && txt != "")
            //                     .ToReactiveCommand();

            //ExecCommand.Subscribe(x => { Output.Value = FirstValue.Value + SecondValue.Value; });

            //IsChecked1 = new ReactiveProperty<bool>();
            //IsChecked2 = new ReactiveProperty<bool>();

            //IsChecked1.Subscribe(x =>
            //{
            //    if (x == true)
            //    {
            //        FirstValue.Subscribe(y => { Output.Value = FirstValue.Value + SecondValue.Value; });
            //        SecondValue.Subscribe(y => { Output.Value = FirstValue.Value + SecondValue.Value; });
            //    }
            //});

            //IsChecked2.Subscribe(x =>
            //{
            //    if (x == true)
            //    {
            //        FirstValue.Subscribe(y => { Output.Value = FirstValue.Value - SecondValue.Value; });
            //        SecondValue.Subscribe(y => { Output.Value = FirstValue.Value - SecondValue.Value; });
            //    }
            //});

        }

        
    }
}
