using System;
using CoreGraphics;

using Foundation;
using UIKit;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace L04
{
    public partial class L04ViewController : UIViewController
    {
        public L04ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            string data = File.ReadAllText("Data/data.txt");
            var items = data.Split(',').ToList();
            var datas = items.Select(c => new
            {
                Name = c.Split('-')[1],
                Type = c.Split('-')[0] 
            }).GroupBy(c => c.Type)
            .Select(c => new GroupData()
            {
                Name = c.Select(x => x.Name).ToList(),
                Type = c.Key
            }).ToList();


            //建立MySource給予TableView
            MySource source = new MySource() { Items = items,Datas=datas };
            MyTable.Source = source;
      
        }

  

    }

    //lab:實作UITableViewSource
    //lab:實作GetCell使用UITableViewCellStyle.Default
    //lab:加入Accessory並複寫Accessory點擊事件- AccessoryButtonTapped
    //lab:實作滑動刪除方法-CanEditRow,CommitEditingStyle
    //lab:實作Row被選擇時的方法-RowSelected
    //lab:用List<GroupData> 實作群組

    public class MySource : UITableViewSource
    {
        //Cell用的ID
        private string _cellID = "cellid";

        //非群組資料
        public List<string> Items { get; set; }

        //群組資料
        public List<GroupData> Datas { get; set; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(_cellID);
            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, _cellID);
                cell.Accessory = UITableViewCellAccessory.DetailButton;
            }
            cell.TextLabel.Text = Datas[indexPath.Section].Name[indexPath.Row];
            
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {

            return Datas[(int)section].Name.Count;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return Datas.Count;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return Datas[(int)section].Type;
        }


        public override void AccessoryButtonTapped(UITableView tableView, NSIndexPath indexPath)
        {
           
            new UIAlertView("Accessory", Datas[indexPath.Section].Name[indexPath.Row], null, "OK", null).Show();
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            new UIAlertView("RowSelected", Datas[indexPath.Section].Name[indexPath.Row], null, "OK", null).Show();
        }




        //lab:AccessoryButtonTapped    
        // new UIAlertView("Accessory", Items[indexPath.Row], null, "OK", null).Show();


        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            Datas[indexPath.Section].Name.RemoveAt(indexPath.Row);
            tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
        }

        //lab:CommitEditingStyle
        //Items.RemoveAt(indexPath.Row);
        // tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return true;
        }

        public override string TitleForDeleteConfirmation(UITableView tableView, NSIndexPath indexPath)
        {
            return "Delete";
        }


        //lab:RowSelected
        // new UIAlertView("RowSelected", Items[indexPath.Row], null, "OK", null).Show();



    }




    public class GroupData
    {
        public string Type { get; set; }
        public List<string>Name { get; set; }
    }
}