using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class ContactListActivity : AppCompatActivity
    {
        private ContactList contactList;
        private ContactListAdapter contactListAdapter;
        private RecyclerView recyclerView;
        private LinearLayoutManager linearLayoutManager;
        private Button logoutButton;
        private RestRequester restRequester;
        private static string authToken;
        public static List<ContactItem> someList = new List<ContactItem>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.contact_list);
            someList = JsonConvert.DeserializeObject<List<ContactItem>>(Intent.GetStringExtra("array"));


            contactList = new ContactList
            {
                listOContacts = someList
            };

            contactListAdapter = new ContactListAdapter(contactList);
     
            recyclerView = FindViewById<RecyclerView>(Resource.Id.contactsListView);
            linearLayoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(linearLayoutManager);

            recyclerView.SetAdapter(contactListAdapter);
            this.logoutButton = FindViewById<Button>(Resource.Id.logout_button);
            this.logoutButton.Click += LogOutButton_Click;
            this.restRequester = new RestRequester();
            authToken = Intent.Extras.GetString("authToken");

        }

      

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.restRequester.SendLogOutRequest(authToken);
            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        
            Finish();

        }
    }
}