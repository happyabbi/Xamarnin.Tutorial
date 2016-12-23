using System;
using CoreGraphics;

using Foundation;
using UIKit;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace L05
{
    public partial class L05ViewController : UIViewController
    {
        public L05ViewController(IntPtr handle)
            : base(handle)
        {
        }




        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string data = File.ReadAllText("Data/data.txt");
            var items = data.Split(';').Select(c => new Data() { ShowValue = c.Split(',')[0].Replace("\r\n",""), ImageName = c.Split(',')[1] }).ToList();

            MyTable.Source = new MySource() { Items = items };
            //lab:為Cell建立ID和Class
            //lab:為Cell加入控制項Image和Label並命名
            //lab:實作UITableViewSource，建立Cell並給予資料    //Image=UIImage.FromBundle(xxx.jpg)
        }


    }

    public class MySource :UITableViewSource
    {
        public List<Data> Items { get; set; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if(indexPath.Row == 0)
            {

            }
        }

        public override float GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 180;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            throw new NotImplementedException();
        }
    }

    public class Data
    {
        public string ImageName { get; set; }
        public string ShowValue { get; set; }
    }

}