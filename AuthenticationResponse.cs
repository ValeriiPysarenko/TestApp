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
   public class AuthenticationResponse
    {
        public User user { get; set; }
        public object integrations { get; set; }
        public string firebaseAuthToken { get; set; }
        public Token token { get; set; }
    }
}