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
   public class AllertDialoger
    {
       
        public  void ShowErrorMessage(string errorMessage)
        {

            AlertDialog.Builder dialog = new AlertDialog.Builder(AppContexWrapper.GetContext());
            AlertDialog alert = dialog.Create();
            alert.SetTitle("Error Message");
            alert.SetMessage("errorMessage");
            alert.SetButton("OK", (c, ev) =>
            {

            });
            alert.Show();
        }
    }
}