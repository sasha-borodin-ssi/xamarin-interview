using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace XamarinInterview.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class StoreLocationsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.store_locations);

            // TODO: perform search when "search" button is tapped, if zip code entered;
            // or, display a message that no zip code has bee been entered

            // TODO: update result RecyclerView with new RecyclerView.Adapter created from search results (if any);
            // or, display a message that no results were found;
            // or, display a message that an error has been encountered
        }
    }
}
