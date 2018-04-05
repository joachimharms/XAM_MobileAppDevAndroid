using Android.App;
using Android.Widget;
using Android.OS;

namespace POIApp_C04_ListView
{
    [Activity(Label = "POIApp_C04_ListView", MainLauncher = true)]
    public class POIListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.POIList);

        }
    }
}

