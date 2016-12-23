using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace L08_DAL
{
    public class APIService
    {
        //lab:確認加入Json.net套件
        //lab:確認加入httpClient套件
        //lab:http://xamarinclassdemo.azurewebsites.net/api/values/

        //lab:呼叫API並轉換為物件回傳

        public string Json { get; set; }

        public async Task<Info> CallAPI()
        {
            HttpClient request = new HttpClient();
            var result = await request.GetStringAsync("http://xamarinclassdemo.azurewebsites.net/api/values/");
            
            Json = result;

            var info = Newtonsoft.Json.JsonConvert.DeserializeObject<Info>(result.Trim('\"'));
            return info;
        }
    }

    public class Info
    {
        public string Name { get; set; }
        public int Found { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
    }
}
