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
       public static  Contact[] listOContacts = {
                   new Contact { ContactImage = Resource.Drawable.first,
                         Name = "Buckingham Palace",
                   PhoneNumber ="dadsasdsadasd",
                   EmailAdress ="dad3dsd"},
                     new Contact { ContactImage = Resource.Drawable.second,
                         Name = "Buckingham Palace",
                   PhoneNumber ="dadsasdsadasd",
                   EmailAdress ="dad3dsd"},
                       new Contact { ContactImage = Resource.Drawable.third,
                         Name = "Buckingham Palace",
                   PhoneNumber ="dadsasdsadasd",
                   EmailAdress ="dad3dsd"},
                        new Contact { ContactImage = Resource.Drawable.fourth,
                         Name = "Buckingham Palace",
                   PhoneNumber ="dadsasdsadasd",
                   EmailAdress ="dad3dsd"},
                         new Contact { ContactImage = Resource.Drawable.fiveth,
                         Name = "Buckingham Palace",
                   PhoneNumber ="dadsasdsadasd",
                   EmailAdress ="dad3dsd"},
        };

        public int NumberContacts
        {
            get { return listOContacts.Length; }
        }
    }

    public class Contact
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