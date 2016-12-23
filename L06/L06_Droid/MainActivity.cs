using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using L06_Share;
using System.Collections.Generic;

namespace L06_droid
{
    [Activity(Label = "L06_droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        MyService myService;
        MyAdapter myAdapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var listView = this.FindViewById<ListView>(Resource.Id.listView);
            var nameEditText = this.FindViewById<EditText>(Resource.Id.nameEditText);
            var searchButton = this.FindViewById<Button>(Resource.Id.button1);

            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            //lab:使用Share File所設計的使用MyService來操作Sqlite，呼叫其QueryAll方法查詢資料展示在ListView

            searchButton.Click += (sender, e) =>
            {
                //lab:使用MyService，呼叫其Query方法查詢資料展示在ListView
            };

            //lab:增加ListView項目點選事件程式
        }

        public class MyAdapter : BaseAdapter<Info>
        {
            public List<Info> Items { get; set; }
            public Activity Context { get; set; }


            public override Info this[int position]
            {
                get { return Items[position]; }
            }

            public override int Count
            {
                get { return Items.Count; }
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                if (convertView == null)
                {
                    convertView = this.Context.LayoutInflater.Inflate(Resource.Layout.RowItem, null);
                }

                var item = this.Items[position];
                convertView.FindViewById<TextView>(Resource.Id.titleTextView).Text = item.Name;
                convertView.FindViewById<TextView>(Resource.Id.subTitleTextView).Text = item.Age;

                return convertView;
            }
        }
    }
}

