using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace hom.DataAccess.Biz
{
    public class StockPull
    {
        public static void PullCurrent(string Code)
        {
            string Url = "";
            System.Net.WebRequest wReq = System.Net.WebRequest.Create(Url);
            // Get the response instance.
            System.Net.WebResponse wResp = wReq.GetResponse();
            System.IO.Stream respStream = wResp.GetResponseStream();
            using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream, Encoding.GetEncoding("UTF-8")))
            {
                 reader.ReadToEnd();
            }
        }
        public static void PullHistory(string Code)
        {

        }
    }
}
