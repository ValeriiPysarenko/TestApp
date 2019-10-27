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
    public class AuthenticaterRequest
    {
        private string username { get; set; }
        private string password { get; set; }
        private string client { get; set; }

        public AuthenticaterRequest(string Username, string Password, string Client)
        {
            this.username = Username;
            this.password = Password;
            this.client = Client;
        }
    }
}