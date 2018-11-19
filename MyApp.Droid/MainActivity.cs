using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using MyApp.Core;

namespace MyApp.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        readonly PersonRepository _personRepository = new PersonRepository();

        TextView _txtView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            Button btnGetFirstPerson = FindViewById<Button>(Resource.Id.btnGetPerson);
            btnGetFirstPerson.Click += BtnGetPerson_Click;

            _txtView = FindViewById<TextView>(Resource.Id.txtViewPersonName);
        }

        void BtnGetPerson_Click(object sender, System.EventArgs e)
        {
            Person p = _personRepository.GetPerson();
            _txtView.Text = $"{p.FirstName} {p.LastName}";
        }
    }
}

