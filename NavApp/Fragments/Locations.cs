using System;
using System.Collections.Generic;
using System.Linq;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Gms.Maps;
namespace Synergetic.Fragments
{
    class Locations : Fragment, IOnMapReadyCallback
    {
        private GoogleMap gmap;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
          
        }

        private void SetUpMap()
        {
            if (gmap == null)
            {
                //SupportMapFragment mfrag = FragmentManager.FindFragmentById(Resource.Id.map) as SupportMapFragment;
                //mfrag.GetMapAsync(this);

            }

        }
       

        public static Locations NewInstance()
        {
            var frag2 = new Locations { Arguments = new Bundle() };
            return frag2;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
           
            View locview = inflater.Inflate(Resource.Layout.locations, null);

            SetUpMap();

            return locview;
        }

        void IOnMapReadyCallback.OnMapReady(GoogleMap googleMap)
        {
            gmap = googleMap;
        }
    }
}