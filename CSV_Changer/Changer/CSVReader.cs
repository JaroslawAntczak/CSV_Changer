using CSV_Changer.Extension;
using CSV_Changer.Items;
using System.IO;

namespace CSV_Changer.Changer
{
    public class CSVReader : ICSVReader
    {
        public IEnumerable<CSVFileLine> Lines;
        public List<CSVFileLine> ReadCSV(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                return new List<CSVFileLine>();
            }
            else
            {
                string[] files = Directory.GetFiles(folderPath);

                foreach (string filePath in files)
                {
                    Lines = File.ReadAllLines(filePath)
                    .Where(line => line.Length > 0)
                    .ToCToCSVFileLine();
                }
                return Lines.ToList();
            }
        }
    }
}
