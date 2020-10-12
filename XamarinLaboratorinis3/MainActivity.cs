using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Lang;
using Java.Util;

namespace XamarinLaboratorinis3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            AutoCompleteTextView autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.fakultetasInput);
            var autoCompleteOptions = new string[] { "Fundamentinių mokslų fakultetas" };
            ArrayAdapter autoCompleteAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, autoCompleteOptions);
            autoCompleteTextView.Adapter = autoCompleteAdapter;
            Button button = FindViewById<Button>(Resource.Id.saugojimas);
            button.Click += Button_Click;

            Spinner spinner = FindViewById<Spinner>(Resource.Id.dienosInput);
            var spinnerOptions = new string[] { "Pirmadienis", "Antradienis", "Trečiadienis", "Ketvirtadienis", "Penktadienis", "Šeštadienis", "Sekmadienis" };
            ArrayAdapter spinnerOptionsAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, spinnerOptions);
            spinner.Adapter = spinnerOptionsAdapter;

            TimePicker timePicker = FindViewById<TimePicker>(Resource.Id.laikasInput);
            timePicker.SetIs24HourView(Java.Lang.Boolean.False);
          
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Sup", ToastLength.Short).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}