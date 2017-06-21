using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Simulator.Service
{
    public static class Files
    {
        public static List<string> FindFiles()
        {
            var dir = new DirectoryInfo("Content");
            var files = dir.GetFiles("*.csv");
            var items = new List<string>();

            foreach (FileInfo file in files)
            {
                items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
            return items;
        }
        public static void SaveDataGridViewToCSV(string filename, DataGridView dataGridView, DataGridView dataGridViewID)
        {
            
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewID.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
           
            dataGridViewID.SelectAll();
            DataObject dataObject = dataGridView.GetClipboardContent();
            DataObject dataObjectID = dataGridViewID.GetClipboardContent();
           
            File.WriteAllText(filename, (dataObject.GetText(TextDataFormat.CommaSeparatedValue) + dataObjectID.GetText(TextDataFormat.CommaSeparatedValue)));
        }
        public static void ClearDirection()
        {
            var dir = new DirectoryInfo("Content");
            var files = dir.GetFiles()
                .Where(c => c.Extension != ".csv")
                ;
            foreach (var item in files)
            {
                File.Delete(item.FullName);
            }
        }

    }
}
