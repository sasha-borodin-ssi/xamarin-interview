using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;

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
            // or, display a message that no zip code has been entered

            // TODO: update result RecyclerView with new RecyclerView.Adapter created from search results (if any);
            // or, display a message that no results were found;
            // or, display a message that an error has been encountered
        }
    }
}
