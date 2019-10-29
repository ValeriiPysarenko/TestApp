using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private string login;
        private string password;
        private Button loginButton;
        private RestRequester restRequester;
        private string client = string.Empty;
        private static Context mContext;
        private static string authToken;
        private Action<AuthenticationResponse> successCallback = (authenticationResponse) => OnSucessAuthentication(authenticationResponse);
        public static List<ContactItem> someList = new List<ContactItem>();


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
            authToken = authenticationResponse.token.AuthToken.ToString();


            RestRequester restRequester = new RestRequester();
            Action<List<GetActiveListRequestResponse>> successActiveListCallback = (getActiveListRequestResponse) => OnSucessActiveListRequest(getActiveListRequestResponse);
            restRequester.GetActiveListRequest(authToken, successActiveListCallback);

        }

        private static void OnSucessActiveListRequest(List<GetActiveListRequestResponse> getActiveListRequestResponse)
        {
            int id = getActiveListRequestResponse[0].id;

            RestRequester restRequester = new RestRequester();
            Action<GetContactListResponse> successContactListCallback = (getContactListResponse) => OnSucessGetContactListResponse(getContactListResponse);
            restRequester.SendGetContactsRequest(id.ToString(), authToken, successContactListCallback);
        }

        private static void OnSucessGetContactListResponse(GetContactListResponse getContactListResponse)
        {
            int contactCount = getContactListResponse.count;
            for (int i = 0; i < contactCount; i++)
            {
                ContactItem item = new ContactItem();
                item.ContactImage = Resource.Drawable.first;
                item.Name = getContactListResponse.data[i].firstName + " " + getContactListResponse.data[i].lastName;
                item.EmailAdress = getContactListResponse.data[i].emails[0].email;
                item.PhoneNumber = getContactListResponse.data[i].phoneNumbers[0].number;
                someList.Add(item);
            }

            Intent intent = new Intent(mContext, typeof(ContactListActivity));
            intent.PutExtra("array", JsonConvert.SerializeObject(someList));
            someList.Clear();
            intent.PutExtra("authToken", authToken);
            intent.AddFlags( ActivityFlags.ClearTask | ActivityFlags.ClearTop);
            mContext.StartActivity(intent);
            

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.login != null && this.password != null)
            {

                this.restRequester.SendAuthenticateRequest(login, password, client, successCallback);
            }

        }


    }
}

