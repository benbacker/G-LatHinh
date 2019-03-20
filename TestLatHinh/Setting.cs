using DevComponents.DotNetBar;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    dataGridView1.Rows.Clear();

        //    HtmlWeb htmlWeb = new HtmlWeb()
        //    {
        //        AutoDetectEncoding = false,
        //        OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
        //    };

        //    //Load trang web, nạp html vào document
        //    HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://www.nhaccuatui.com/tim-nang-cao?title="+tbSearch.Text+"&singer=&user=&type=1&kbit=0&sort=0&direction=2");

        //    //Load các tag li trong tag ul
        //    var threadItems = document.DocumentNode.SelectNodes("//ul[@class='search_returns_list']/li").ToList();

        //    var items = new List<object>();
            
        //    foreach (var item in threadItems)
        //    {   
                
        //        //Extract các giá trị từ các tag con của tag li
        //        var linkNode = item.SelectSingleNode(".//div[@class='item_content']");
        //        var linkNode1 = linkNode.SelectSingleNode(".//a");

        //        var link = linkNode1.Attributes["href"].Value;
        //        var text = linkNode.InnerText;

        //        dataGridView1.Rows.Add(text, link);
                
        //    }
        //}

        //private void btnRemove_Click(object sender, EventArgs e)
        //{   try
        //    {
        //        foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
        //        {
        //            if (oneCell.Selected)
        //                dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    int index = dataGridView1.CurrentCell.RowIndex;
        //    //DataTable dttemp = dataGridView2.DataSource as DataTable;
        //    dataGridView2.Rows.Add(dataGridView1.Rows[index].Cells[0].Value.ToString(),dataGridView1.Rows[index].Cells[1].Value.ToString());
        //    //dataGridView2.DataSource = dttemp;
        //}
        //private void readDgvFromTextFile()
        //{
        //    string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
        //    string FileName = string.Format("{0}Resources\\playlist.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
        //    dataGridView2.DataSource = Helper.DataTableFromTextFile(FileName);
        //}

        private void Setting_Shown(object sender, EventArgs e)
        {
            //readDgvFromTextFile();
            if (ConfigurationManager.AppSettings["IsSoundOn"] == "true")
            {
                rbSon.Checked = true;
            }
            else rbSoff.Checked = true;
            if (ConfigurationManager.AppSettings["IsMusicOn"] == "true")
            {
                rbMBon.Checked = true;
            }
            else rbMBoff.Checked = true;
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //writeDgwToFile();
            //addSongToAppConfig();
            

            if (rbMBon.Checked) Helper.EditAppSetting("IsMusicOn", "true");
            else Helper.EditAppSetting("IsMusicOn", "false");

            if (rbSon.Checked) Helper.EditAppSetting("IsSoundOn", "true");
            else Helper.EditAppSetting("IsSoundOn", "false");
            

            MessageBoxEx.Show("Save successfull! Please restart the game to apply the new setting!");
            Application.Restart();
        }
        //void addSongToAppConfig()
        //{
        //    int rownum = dataGridView2.Rows.Count;
        //    for (int i = 0; i < rownum - 1 && i < 10; i++)
        //    {
        //        Helper.EditAppSetting("MB" + (i + 1), dataGridView1.Rows[i].Cells[1].Value.ToString());
        //        Helper.EditAppSetting("MB" + (i + 1) + "name", dataGridView1.Rows[i].Cells[0].Value.ToString());
        //    }
        //}
        //void writeDgwToFile()
        //{
        //    string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
        //    string FileName = string.Format("{0}Resources\\playlist.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
        //    File.WriteAllText(FileName, String.Empty);

        //    int rownum = dataGridView2.Rows.Count;
        //    try
        //    {

        //        StringCollection line = new StringCollection();
        //        for (int i = 0; i < rownum - 1; i++)
        //        {
        //            line.Add(dataGridView1.Rows[i].Cells[0].Value.ToString().Replace("  ", string.Empty) + ", " + dataGridView1.Rows[i].Cells[1].Value.ToString());
        //        }

        //        string[] strArr = line.Cast<string>().ToArray<string>();

        //        using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName, true))
        //        {
        //            file.WriteLine("Ten Bai, Link");
        //            foreach (string _line in strArr)
        //            {

        //                {
        //                    file.WriteLine(_line.Replace("\n", string.Empty));
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }

        //}
    }
}
