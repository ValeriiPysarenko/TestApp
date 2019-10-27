using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private string login;
        private string password;
        private Button loginButton;
        private RestRequester restRequester;
        private string client;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.login_activity);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
        
            TextInputLayout loginInput = FindViewById<TextInputLayout>(Resource.Id.input_login);
            TextInputLayout passwordInput = FindViewById<TextInputLayout>(Resource.Id.input_password);
            EditText loginText = FindViewById<EditText>(Resource.Id.edit_login);
            EditText passwordText = FindViewById<EditText>(Resource.Id.edit_pass);
            this.loginButton = FindViewById<Button>(Resource.Id.login_button);
            this.loginButton.Enabled = false;
            this.login = loginText.Text;
            this.password = passwordText.Text;
            loginButton.Click += loginButton_Click;

            loginText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                if (loginText.Text != string.Empty && passwordText.Text != string.Empty)
                    this.loginButton.Enabled = true;
            };
            passwordText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                if (loginText.Text != string.Empty && passwordText.Text != string.Empty)
                    this.loginButton.Enabled = true;
            };
            this.restRequester = new RestRequester();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(this.login!=null && this.password!=null && this.client != null)
            {
                this.restRequester.SendRestRequest(login, password, client);
            }
          


            Intent intent = new Intent(this, typeof(ContactListActivity));
            StartActivity(intent);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            // if (id == Resource.Id.actions+)
            {
                return true;
            }

           // return base.OnOptionsItemSelected(item);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

