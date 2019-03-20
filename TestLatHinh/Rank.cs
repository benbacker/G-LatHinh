using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLatHinh
{
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Cursor = CreateCursor.cur;
        }

        private void Rank_Load(object sender, EventArgs e)
        {
            DataSet scoresDataSet = new DataSet();
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = string.Format("{0}Resources\\score.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            scoresDataSet.ReadXml(xmlPath);
            DataTable scoresDataTable = scoresDataSet.Tables["score"];
            dataGridView1.DataSource = scoresDataTable;
            dataGridView1.Columns["playerName"].HeaderText = "Player";
            dataGridView1.Columns["points"].HeaderText = "Score";
            dataGridView1.Sort(dataGridView1.Columns["points"], ListSortDirection.Descending);

        }
    }
}
