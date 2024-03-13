using CSV_Changer.Items;

namespace CSV_Changer.Changer
{
    public interface ICSVReader
    {
        public List<CSVFileLine> ReadCSV(string path);
    }
}
