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
using RestSharp;

namespace TestApp
{
  public  class RestRequester
    {
        private int StatusCode { get => StatusCode; set => StatusCode = value; }

        public void SendRestRequest(string login, string password, string client)
        {
            var restClient = new RestClient("https://internal-api-staging-lb.interact.io/v2");
            RestRequest restRequest = new RestRequest("/login", Method.POST);

            AuthenticaterRequest authenticaterRequest = new AuthenticaterRequest(login, password, client);
            
                 restRequest.AddJsonBody(authenticaterRequest);
            restClient.ExecuteAsync(restRequest, response =>
            {
                ResponseHandler.Handle(response.Content);

                this.StatusCode = (int)response.StatusCode;
            });


            
        }

    }
}