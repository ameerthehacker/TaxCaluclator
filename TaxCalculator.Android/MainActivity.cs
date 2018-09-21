using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Java.Interop;
using TaxCalculator.Shared;
using System;

namespace TaxCalculator.Android
{
    [Activity(Label = "TaxCalculator.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
           
        }

        [Export("OnBtnCalculateClick")]
        public void OnBtnCalculateClick(View v) {
            EditText txtAmount = (EditText)FindViewById(Resource.Id.txtAmount);
            TextView lblResult = (TextView)FindViewById(Resource.Id.lblResult);

            int amount = 0;
            Int32.TryParse(txtAmount.Text, out amount);

            double result = TaxFinder.CalculateTax(amount);

            lblResult.Text = result.ToString();
        }
    }
}

