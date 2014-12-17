using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Security.Cryptography;

using System.Net;
using System.Threading;

using Jayrock;
using Jayrock.Json;
using Jayrock.Json.Conversion;
using Jayrock.Json.Conversion.Converters;
using Jayrock.Collections;
using Jayrock.Configuration;
using Jayrock.Diagnostics;



namespace SMS8080Helper
{
    public class AppConfig
    {
        

        public string ServerAdd { get; set; }
        public string ServerPort { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string DataBase { get; set; }
        public string ProductTableName { get; set; }

        public  int IsPost;
        public  int IsSale;
        public  string dtBegin;
        public  string dtFinish;
        public  string cateID;

        public string ReadConfig(string fileName)
        {
            string hr = string.Empty;
            try
            {
                string lines = string.Empty;
                using(StreamReader sr=new StreamReader(fileName,Encoding.Default))
                {
                    lines = sr.ReadToEnd();
                    sr.Close();
                }
                AppConfig iac = JsonConvert.Import(typeof(AppConfig), lines) as AppConfig;

                this.ServerAdd = iac.ServerAdd;
                this.ServerPort = iac.ServerPort; this.UserID = iac.UserID; this.Password = iac.Password; this.DataBase = iac.DataBase; this.ProductTableName = iac.ProductTableName;

            }
            catch (System.Exception e)
            {
                hr = e.Message;
            }
            return hr;
        }

        public string SaveConfig(string fileName)
        {
            string hr = string.Empty;
            try
            {
                using(StreamWriter sw=new StreamWriter(fileName,false,Encoding.Default))
                {
                    sw.WriteLine(JsonConvert.ExportToString(this));
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (System.Exception e)
            {
                hr = e.Message;
            }
            return hr;
        }
    }
}
