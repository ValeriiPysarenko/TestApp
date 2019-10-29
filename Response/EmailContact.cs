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
   public class EmailContact
    {
      

        public enum Status
        {
            OK, 
            BOUNCED,
            VERIFIED
        }
        public bool primary { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public ConsentDetails consentDetails { get; set; }
        public EmailContact(bool primary, string type, string email, ConsentDetails consentDetails)
        {
            this.primary = primary;
            this.type = type;
            this.email = email;
            this.consentDetails = consentDetails;
        }


    }
}