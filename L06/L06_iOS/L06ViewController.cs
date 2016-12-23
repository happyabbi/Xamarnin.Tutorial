using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SQLite;
using System.IO;
using System.Collections.Generic;
using L06_Share;


namespace L06
{
    public partial class L06ViewController : UIViewController
    {
        public L06ViewController(IntPtr handle)
            : base(handle)
        {
        }


        MyService myService;
        MyTableViewSource myTableViewSource;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            //lab:使用Share File所設計的使用MyService來操作Sqlite，呼叫其QueryAll方法查詢資料展示在TableView
            Console.WriteLine(path);
            myService = new MyService(path);
            myTableViewSource = new MyTableViewSource() { Items = myService.QueryAll() };
        }



        partial void btnQuery_TouchUpInside(UIButton sender)
        {
            myTableViewSource.Items = myService.Query(lblName.Text);
            //lab:使用MyService，呼叫其Query方法查詢資料展示在TableView
        }
    }

    public class MyTableViewSource : UITableViewSource
    {
        public List<Info> Items { get; set; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
          var cell=  tableView.DequeueReusableCell("ID");
          var item = Items[indexPath.Row];
          if (cell == null)
              cell = new UITableViewCell(UITableViewCellStyle.Value1, "ID");
          cell.TextLabel.Text = item.Name;
          cell.DetailTextLabel.Text = item.Age;
          return cell;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return Items.Count;
        }
    }


   
}