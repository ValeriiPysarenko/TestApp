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
    public class TelephoneContact
 {
     

        public enum Status
        {
            OK, 
            INVALID,
            VERIFIED
        }
        public bool primary { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public Status status{ get; set; }
        public TelephoneContact(bool primary, string type, string number, Status status)
        {
            this.primary = primary;
            this.type = type;
            this.number = number;
            this.status = status;
        }

    }
}