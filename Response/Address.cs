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
    public class Address
    {


        public string fullAddress { get; set; }
        public string street { get; set; }
        public string neighborhood { get; set; }
        public string poBox { get; set; }
        public string postCode { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string type { get; set; }

        public Address(string fullAddress, string street, string neighborhood, string poBox, string postCode, string city, string region, string country, string type)
        {
            this.fullAddress = fullAddress;
            this.street = street;
            this.neighborhood = neighborhood;
            this.poBox = poBox;
            this.postCode = postCode;
            this.city = city;
            this.region = region;
            this.country = country;
            this.type = type;
        }








    }
}