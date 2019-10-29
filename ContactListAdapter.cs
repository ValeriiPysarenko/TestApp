using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TestApp
{
    public class ContactListAdapter : RecyclerView.Adapter
    {
        public ContactList cntctList;
        public ContactListAdapter(ContactList contactList)

        {
            cntctList = contactList;
        }

        public override int ItemCount
        { get { return cntctList.NumberContacts; } }


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ContactViewHolder contactHolder = holder as ContactViewHolder;
            contactHolder.ContactImage.SetImageResource(cntctList.listOContacts[position].ContactImage);
            contactHolder.Name.Text = cntctList.listOContacts[position].Name;
            contactHolder.PhoneNumber.Text = cntctList.listOContacts[position].PhoneNumber;
            contactHolder.EmailAdress.Text = cntctList.listOContacts[position].EmailAdress;
        }


        public override RecyclerView.ViewHolder
           OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.ContactListView, parent, false);
            ContactViewHolder contactHolder = new ContactViewHolder(itemView);
            return contactHolder;
        }
    }
}