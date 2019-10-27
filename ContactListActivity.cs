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

namespace TestApp
{
    [Activity(Label = "ContactListActivity")]
    public class ContactListActivity : AppCompatActivity
    {
        private ContactList contactList;
        private ContactListAdapter contactListAdapter;
        private RecyclerView recyclerView;
        private LinearLayoutManager linearLayoutManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.contact_list);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

           
            contactList = new ContactList();


            contactListAdapter = new ContactListAdapter(contactList);


            SetContentView(Resource.Layout.contact_list);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.contactsListView);
            linearLayoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(linearLayoutManager);

            recyclerView.SetAdapter(contactListAdapter);
        }

       
    }
}