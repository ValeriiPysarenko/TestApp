using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using RestSharp;

namespace TestApp
{
  public  static class ResponseHandler
    {
        public static void Handle(string response)
        {
            AuthenticationResponse authenticationResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(response);
            User user = authenticationResponse.user;
            Token token = authenticationResponse.token;
        }
    }
}
