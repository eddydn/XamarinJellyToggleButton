using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Com.Nightonke.Jellytogglebutton;
using Com.Nightonke.Jellytogglebutton.JellyTypes;

namespace XamarinJellyToggleButtonDemo
{
    [Activity(Label = "XamarinJellyToggleButtonDemo", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {

        Toast lastToast;
        JellyToggleButton jellyToggleButton;

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch(item.ItemId)
            {
                case Resource.Id.itself:
                    jellyToggleButton.Jelly = Jelly.Itself;
                    break;
                case Resource.Id.lazy1:
                    jellyToggleButton.Jelly = Jelly.LazyTrembleHeadSlimJim;
                    break;
                case Resource.Id.lazy2:
                    jellyToggleButton.Jelly = Jelly.LazyTrembleTailFatty;
                    break;
            }
            return true;
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.myToolbar);
            SetSupportActionBar(toolbar);

            jellyToggleButton = FindViewById<JellyToggleButton>(Resource.Id.jellyButton);

            jellyToggleButton.StateChange += JellyToggleButton_StateChange;
        }

        private void JellyToggleButton_StateChange(object sender, JellyToggleButton.StateChangeEventArgs e)
        {
            if(e.P1.Equals(State.Left))
            {
                if (lastToast != null) lastToast.Cancel();
                lastToast = Toast.MakeText(this, "Left!", ToastLength.Short);
                lastToast.Show();
            }
            else if (e.P1.Equals(State.Right))
            {
                if (lastToast != null) lastToast.Cancel();
                lastToast = Toast.MakeText(this, "Right!", ToastLength.Short);
                lastToast.Show();
            }
        }
    }
}

