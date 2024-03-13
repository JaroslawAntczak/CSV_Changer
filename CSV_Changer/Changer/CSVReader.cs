using CSV_Changer.Extension;
using CSV_Changer.Items;

namespace CSV_Changer.Changer
{
    public class CSVReader : ICSVReader
    {
        public List<CSVFileLine> ReadCSV(string path)
        {
            if(!File.Exists(path)) 
            {
                return new List<CSVFileLine>(); 
            }
            else
            {
                var CSVFile = File.ReadAllLines(path)
                    .Where(line => line.Length > 0)
                    .ToCToCSVFileLine();

                return CSVFile.ToList();
            }
        }
    }
}
