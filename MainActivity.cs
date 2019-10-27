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
        private string client =string.Empty;
        private static Context mContext;
        private Action<AuthenticationResponse> successCallback = (authenticationResponse) => OnSucessAuthentication(authenticationResponse);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.login_activity);

        
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
                this.login = loginText.Text;
                if (loginText.Text != string.Empty && passwordText.Text != string.Empty)
                    this.loginButton.Enabled = true;
            };
            passwordText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                this.password = passwordText.Text;
                if (loginText.Text != string.Empty && passwordText.Text != string.Empty)
                    this.loginButton.Enabled = true;
            };
            this.restRequester = new RestRequester();
            AppContexWrapper.SetAContext(this);
            mContext = this;


        }
        private static void OnSucessAuthentication(AuthenticationResponse authenticationResponse)
        {
            User user = authenticationResponse.user;
            Token token = authenticationResponse.token;

       
      
            Intent intent = new Intent(mContext, typeof(ContactListActivity));
            intent.PutExtra("authToken", token.AuthToken); 
            mContext.StartActivity(intent);


        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            if(this.login!=null && this.password!=null )
            {
           
                this.restRequester.SendAuthenticateRequest(login, password, client, successCallback);
            }

        }

     
    }
}

