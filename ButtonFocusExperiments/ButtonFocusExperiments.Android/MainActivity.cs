using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace ButtonFocusExperiments.Android
{
    [Activity(Label = "ButtonFocusExperiments.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : AvaloniaMainActivity<App>
    {
    }
}