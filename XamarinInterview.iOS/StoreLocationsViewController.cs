using Foundation;
using System;
using UIKit;

namespace XamarinInterview.iOS
{
    public partial class StoreLocationsViewController : UIViewController
    {
        public StoreLocationsViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // TODO: perform search when "search" button is tapped, if zip code entered;
            // or, display a message that no zip code has bee been entered

            // TODO: update result UITableView.Source with new UITableViewSource created from search results (if any);
            // or, display a message that no results were found;
            // or, display a message that an error has been encountered
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
