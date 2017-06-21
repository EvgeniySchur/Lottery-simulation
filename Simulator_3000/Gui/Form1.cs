using System;
using System.Windows.Forms;
using Simulator.Service;
using System.Diagnostics;

namespace Gui
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CB_SelectFile_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        void GetFiles(object sender, EventArgs e)
        {
            CB_SelectFile.Items.Clear();
            foreach (var item in Files.FindFiles())
            {
                CB_SelectFile.Items.Add(item);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var mgr = new Manager();
            mgr.SimulateStart(CB_SelectFile.Text, Int32.Parse(CB_CycleCount.Text));
            dataGridView.Rows.Clear();
            for (int i = dataGridViewID.Rows.Count-2; i > -1; i--)
            {
                dataGridViewID.Rows.RemoveAt(i);
            }
            dataGridView.Rows.Add("Exp ", Statistic.ExpCounter, Statistic.SumExpCounter);
            dataGridView.Rows.Add("Silver ", Statistic.SilverCounter, Statistic.SumSilverCounter);
            dataGridView.Rows.Add("Gold ", Statistic.GoldCounter, Statistic.SumGoldCounter);
            dataGridView.Rows.Add("Blueprint ", Statistic.BlueprintCounter, Statistic.SumBlueprintCounter);

            for (int i = 0; i < Statistic.expId.Count; i++)
            {
                dataGridViewID.Rows.Add();
                dataGridViewID.Rows[i].Cells["dataGridViewIDExp"].Value = Statistic.expId[i];
            }
            for (int i = 0; i < Statistic.silvId.Count; i++)
            {
                dataGridViewID.Rows.Add();
                dataGridViewID.Rows[i].Cells["dataGridViewIDSilver"].Value = Statistic.silvId[i];
            }
            for (int i = 0; i < Statistic.goldId.Count; i++)
            {
                dataGridViewID.Rows.Add();
                dataGridViewID.Rows[i].Cells["dataGridViewIDGold"].Value = Statistic.goldId[i];
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@"Content");
        }

        private void dataGridViewID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_saveResult_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString();
            var pair = date.Split(':');
            var dateToPrint = string.Empty;
            foreach (var item in pair)
            {
                dateToPrint += item + ".";
            }

            Files.SaveDataGridViewToCSV(@"Content\Result " + CB_SelectFile.Text + "_" + dateToPrint + ".xls",dataGridView,dataGridViewID);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Files.ClearDirection();
        }
    }
}
