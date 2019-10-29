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
   public class Token
    {
       
        public string Expires { get; set; }
        public string AuthToken { get; set; }

        public Token(string expires, string authToken)
        {
            this.Expires = expires;
            this.AuthToken = authToken;
        }
    }
}