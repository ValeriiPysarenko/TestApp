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
  public class AppContexWrapper
    {
        private static Context aContext;



        public static void SetAContext(Context context) 
        {
            aContext = context;

        }

        public static Context GetContext()
        {
            return aContext;
        }

       
    }
}
