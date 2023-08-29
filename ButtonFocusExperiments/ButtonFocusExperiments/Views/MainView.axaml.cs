using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace ButtonFocusExperiments.Views
{
    public partial class MainView : UserControl
    {
        
        public MainView()
        {
            InitializeComponent();
            
        }

        protected override void OnGotFocus(GotFocusEventArgs e)
        {
            base.OnGotFocus(e);
            Debug.WriteLine($"GotFocus: {(e.Source is Button b? b.Name : e.Source)}");
        }

        protected override void OnLostFocus(RoutedEventArgs e)
        {
            base.OnLostFocus(e);
            Debug.WriteLine($"LostFocus: {(e.Source is Button b ? b.Name : e.Source)}");
            Debug.WriteLine($"Focused Element: {TopLevel.GetTopLevel(this)?.FocusManager?.GetFocusedElement()}");
           
        }

        private void OnButtonClick(object? sender, RoutedEventArgs routedEventArgs)
        {
            Debug.WriteLine("Click handler button clicked.");
        }

        
    }
}