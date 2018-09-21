using System;
using TaxCalculator.Shared;

using UIKit;

namespace TaxCalculator.IOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        partial void BtnCalculate_TouchUpInside(UIButton sender)
        {
            int amount = 0;
            Int32.TryParse(txtAmount.Text, out amount);
            double result = TaxFinder.CalculateTax(amount);

            lblResult.Text = result.ToString();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
