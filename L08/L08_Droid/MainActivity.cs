using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using L08_DAL;

namespace L08_Droid
{
    [Activity(Label = "L08_Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //lab:將PCL專案dll加入參考
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            TextView resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            TextView nameTextView = FindViewById<TextView>(Resource.Id.nameTextView);
            TextView foundTextView = FindViewById<TextView>(Resource.Id.foundTextView);
            TextView telTextView = FindViewById<TextView>(Resource.Id.telTextView);
            TextView addressTextView = FindViewById<TextView>(Resource.Id.addressTextView);

            //lab:註冊MyButton的Click事件，呼叫PCL中的類別，將結果回傳並顯示於畫面

            button.Click += async (sender, e) => { 



                //Toast.MakeText(this, "API資料取得完成", ToastLength.Short).Show();
            };
        }
    }
}

