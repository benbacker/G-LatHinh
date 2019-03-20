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
    public partial class PhaDao : Form
    {
        int score = 0;
        public PhaDao(int _score)
        {
            InitializeComponent();
            score = _score;
            lbScore.Text = score.ToString();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataSet scoresDataSet = new DataSet();
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = string.Format("{0}Resources\\score.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            
            scoresDataSet.ReadXml(xmlPath);
            DataTable scoresDataTable = scoresDataSet.Tables["score"];
            scoresDataTable.Rows.Add();
            scoresDataTable.Rows[scoresDataTable.Rows.Count - 1]["playerName"] = tbPlayerName.Text;
            scoresDataTable.Rows[scoresDataTable.Rows.Count - 1]["points"] = score.ToString();
            scoresDataSet.WriteXml(xmlPath);

            Rank frmrank = new Rank();
            frmrank.Show();
            this.Hide();
            
        }
    }
}
