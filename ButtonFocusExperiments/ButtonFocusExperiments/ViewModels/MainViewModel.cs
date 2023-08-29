using Avalonia.Input;
using ReactiveUI;
using System.Diagnostics;
using System.Reactive;

namespace ButtonFocusExperiments.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ReactiveCommand<Unit, Unit> TestCommand { get; }

        public MainViewModel() 
        {

            TestCommand = ReactiveCommand.Create(() =>
            {
                Debug.WriteLine("Command based button pressed");
            });
        }

    }
}