using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Share
{
    public class MyService
    {
        private SQLiteConnection _conn;
        public  MyService(string path)
        {

            string dbName = string.Empty;

#if __ANDROID1__
            dbName="droid.db";
#endif

#if __IOS__
            dbName="ios.db";
#endif
            string dbPath=Path.Combine(path, dbName);
            //lab:將此檔使用"加入作為連結"的方式到ios、android project


            //lab:建立SQLiteConnection連線與建立Table
            _conn = new SQLiteConnection(dbPath);
            _conn.CreateTable<Info>();

            if (_conn.Table<Info>().Count() == 0)
            {
                List<Info> items = new List<Info>();
                items.Add(new Info() { Age = "12", Name = "Eco" });
                items.Add(new Info() { Age = "13", Name = "Lydia" });
                items.Add(new Info() { Age = "14", Name = "Steven" });
                items.Add(new Info() { Age = "15", Name = "Ben" });
                items.Add(new Info() { Age = "17", Name = "Terry" });
                items.Add(new Info() { Age = "18", Name = "KFC" });
                items.Add(new Info() { Age = "92", Name = "Moss" });
                items.Add(new Info() { Age = "53", Name = "Toyota" });
                items.Add(new Info() { Age = "122", Name = "BMW" });
                items.Add(new Info() { Age = "12", Name = "Zent" });
                _conn.InsertAll(items);
                //lab:新增初始化資料到Table
            }
        }


        public List<Info> Query(string Name)
        {
            if (Name == string.Empty)
                return this.QueryAll();

            var query = from item in _conn.Table<Info>()
                        where item.Name.Contains(Name)
                        select item;
            return query.ToList();
                
            //lab:撰寫Query Name

        }

        public void Add(Info info)
        {
            //lab:撰寫Insert
        }

        public List<Info> QueryAll()
        {
           return _conn.Table<Info>().ToList();
            //lab:撰寫select *
        }

    }

    public class Info
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
