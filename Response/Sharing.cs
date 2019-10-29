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
  public  class Sharing
    {
       

        public enum Entity
        {
            TEAM,
            USER,
            ORGANIZATION,
            UPWARDS_ORGANIZATION,
            DOWNWARDS_ORGANIZATION
        }
        public string id { get; set; }
        public Entity entity { get; set; }

        public Sharing(string id, Entity entity)
        {
            this.id = id;
            this.entity = entity;
        }

    }
}