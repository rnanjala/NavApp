using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Synergetic.Fragments
{
    public class Home : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static Home NewInstance()
        {
            var frag2 = new Home { Arguments = new Bundle() };
            return frag2;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            View view =  inflater.Inflate(Resource.Layout.home, null);

        

            // Set the Text to try this out
          //  TextView t = (TextView)view.FindViewById(Resource.Id.Text1);
        //    t.Text = "dynamic text";


            //    view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "This is the home page";

            return view;
        }
    }
}