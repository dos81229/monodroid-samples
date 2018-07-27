using Android.App;
using Android.OS;

namespace SimpleMapDemo
{
    [Activity(Label = "@string/activity_label_axml")]
    public class BasicDemoActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.BasicDemo);
        }
    }
}
