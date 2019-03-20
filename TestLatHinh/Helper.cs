using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestLatHinh
{
    public class Helper
    {
        

        public static DataTable DataTableFromTextFile(string location, char delimiter = ',')
        {
            DataTable result;

            string[] LineArray = File.ReadAllLines(location);

            result = FormDataTable(LineArray, delimiter);

            return result;
        }

        private static DataTable FormDataTable(string[] LineArray, char delimiter)
        {
            DataTable dt = new DataTable();

            AddColumnToTable(LineArray, delimiter, ref dt);

            AddRowToTable(LineArray, delimiter, ref dt);

            return dt;
        }

        private static void AddRowToTable(string[] valueCollection, char delimiter, ref DataTable dt)
        {

            for (int i = 1; i < valueCollection.Length; i++)
            {
                string[] values = valueCollection[i].Split(delimiter);
                DataRow dr = dt.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    dr[j] = values[j];
                }
                dt.Rows.Add(dr);
            }
        }

        private static void AddColumnToTable(string[] columnCollection, char delimiter, ref DataTable dt)
        {   

            string[] columns = columnCollection[0].Split(delimiter);
            foreach (string columnName in columns)
            {
                DataColumn dc = new DataColumn(columnName, typeof(string));
                dt.Columns.Add(dc);
            }
        }
        public static string getlinkmp3(string url)
        {
            string htmlCode;
            String URLString = url;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(URLString);
                htmlCode = htmlCode.Replace("\n", "");
                htmlCode = htmlCode.Replace(" ", "");

            }
            int pFrom = htmlCode.IndexOf("player.peConfig.xmlURL=");
            int pTo = htmlCode.LastIndexOf("player.peConfig.defaultIndex");

            String temp = htmlCode.Substring(pFrom+24, pTo - pFrom-26);

            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(temp);
                htmlCode = htmlCode.Replace("\n", "");
                htmlCode = htmlCode.Replace(" ", "");

            }
            pFrom = htmlCode.IndexOf("</creator><location><![CDATA[");
            pTo = htmlCode.LastIndexOf("]]></location>");

            String result = htmlCode.Substring(pFrom + 29, pTo - pFrom - 29);
            return result;
            
        }
        public static void EditAppSetting(string key, string value)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static void AddAppSetting(string key, string value)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static void RemoveAppSetting(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
