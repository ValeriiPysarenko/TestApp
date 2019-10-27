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
using Newtonsoft.Json;
using RestSharp;

namespace TestApp
{
    public class RestRequester
    {
        RestClient restClient = new RestClient("https://internal-api-staging-lb.interact.io/v2");
        public void SendAuthenticateRequest(string login, string password, string client, Action<AuthenticationResponse> successCallback)
        {

            RestRequest restRequest = new RestRequest("/login", Method.POST);
            // AuthenticaterRequest authenticaterRequest = new AuthenticaterRequest(login, password, client);
            // restRequest.AddJsonBody(authenticaterRequest);
            var content = new string(JsonConvert.SerializeObject(new { username = login, password = password, client = client }));
            restRequest.AddJsonBody(content);

            restClient.ExecuteAsync(restRequest, response =>
            {
                ResponseHandler.Handle(response, successCallback);
            });
        }

        public void SendGetContactsRequest(string listId, Action<GetContactListResponse> successCallback)
        {
            RestRequest restRequest = new RestRequest("/lists/"+listId+"/contacts", Method.GET);
          
            var content = new string(JsonConvert.SerializeObject(new { listId = listId }));
            restRequest.AddJsonBody(content);

            restClient.ExecuteAsync(restRequest, response =>
            {
                ResponseHandler.Handle(response, successCallback);
            });
        }


        public void SendLogOutRequest(string authToken)
        {
            RestRequest restRequest = new RestRequest("/logout", Method.POST);


            var content = new string(JsonConvert.SerializeObject(new { authToken = authToken }));
            restRequest.AddJsonBody(content);

            restClient.ExecuteAsync(restRequest, response =>
            {
                ResponseHandler.Handle(response);
            });
        }

    }
}