using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        TextView T1tv, T2tv, finaltv;
        SeekBar T1sb, T2sb, T3sb;
        Button totalBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            T1tv = (TextView)FindViewById(Resource.Id.tvText1);
            T2tv = (TextView)FindViewById(Resource.Id.tvText2);
            finaltv = (TextView)FindViewById(Resource.Id.tvFinal);
            T1sb = (SeekBar)FindViewById(Resource.Id.seekBar1);
            T2sb = (SeekBar)FindViewById(Resource.Id.seekBar2);
            T3sb = (SeekBar)FindViewById(Resource.Id.seekBar3);
            totalBtn = (Button)FindViewById(Resource.Id.tvFinal);


            T1sb.ProgressChanged += delegate
            {
                T1tv.Text = T1sb.Progress.ToString();
            };

            T2sb.ProgressChanged += delegate
            {
                T2tv.Text = T2sb.Progress.ToString();
            };

            finaltv.ProgressChanged += delegate
            {
                T1tv.Text = T1sb.Progress.ToString();
            };


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

