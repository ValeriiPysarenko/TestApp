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
    public class GetActiveListRequestResponse
    {

        public enum Mode
        {
            REVIEW,
            INTERACT,
            INTERACT_AND_QUALIFY

        }

        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string mode { get; set; }
        public bool dynamic { get; set; }
        public bool emailDistributionList { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int contactsCount { get; set; }
        public IList<string> activeStatuses { get; set; }
        public IList<string> inactiveStatuses { get; set; }
        public IList<Contact> contacts { get; set; }
        public IList<BaseInteraction> lastInteraction { get; set; }
        public string completion { get; set; }
        public string ownerId { get; set; }
        public IList<string> reviewers { get; set; }
        public IList<string> participants { get; set; }
        public IList<ContactListSharing> sharing { get; set; }
        public IList<ListDestinationTrigger> listTriggers { get; set; }



    }
}