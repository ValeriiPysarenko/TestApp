using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TestApp
{
    public class ContactViewHolder : RecyclerView.ViewHolder

    {
        public ImageView ContactImage { get; set; }
        public TextView Name { get; private set; }
        public TextView PhoneNumber { get; private set; }
        public TextView EmailAdress { get; private set; }

        public ContactViewHolder(View itemView) : base(itemView)
        {
            // Locate and cache view references:
            ContactImage = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            Name = itemView.FindViewById<TextView>(Resource.Id.nameView);
            PhoneNumber = itemView.FindViewById<TextView>(Resource.Id.phoneNumberView);
            EmailAdress = itemView.FindViewById<TextView>(Resource.Id.emailAdressView);
        }

    }
}