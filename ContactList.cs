using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TestApp
{
    public class ContactList
    {
        public List<ContactItem> listOContacts;

        public int NumberContacts
        {
            get { return listOContacts.Count; }
        }
    }

    public class ContactItem
    {
        public int ContactImage
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }

        public string PhoneNumber
        {
            get; set;
        }

        public string EmailAdress
        {
            get; set;
        }
    }




}