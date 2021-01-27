using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace PayaTest
{
    class DataReader
    {
        public string ReadData(string Url)
        {
            string stJson = string.Empty;
            try
            {
                System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.CreateHttp(Url);
                req.ContentType = "application/json";
                req.Timeout = 600 * 1000;
                req.Method = "GET";
                req.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                Stream stream = res.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                stJson = sr.ReadToEnd();
                sr.Close();
            }
            catch (System.Net.WebException wex)
            {
                Console.WriteLine(wex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return stJson;
        }


    }
}
