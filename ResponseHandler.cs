using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    public class ResponseHandler
    {
        public static void Handle(IRestResponse response, Action<AuthenticationResponse> successCallback)
        {
            new Thread(() =>
            {
                bool responseCodeOk = CheckResponseCode(response);
                if (responseCodeOk && response != null)
                {
                    
                    AuthenticationResponse authenticationResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(response.Content);
                    successCallback?.Invoke(authenticationResponse);
                   
                }

            }).Start();
        }

        public static void Handle(IRestResponse response, Action<GetContactListResponse> successCallback)
        {
            new Thread(() =>
            {
                bool responseCodeOk = CheckResponseCode(response);
                if (responseCodeOk && response != null)
                {

                    AuthenticationResponse authenticationResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(response.Content);
                    successCallback?.Invoke(authenticationResponse);

                }

            }).Start();
        }
        public static void Handle(IRestResponse response)
        {

        }


        private static bool CheckResponseCode(IRestResponse response)
        {
            if (response.Content.Length == 0)
            {
                new AllertDialoger().ShowErrorMessage("ServerError");
                return false;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                new AllertDialoger().ShowErrorMessage("Bad Request:" + response.Content);
                return false;
            }


            return false;
        }

     



    }
}

