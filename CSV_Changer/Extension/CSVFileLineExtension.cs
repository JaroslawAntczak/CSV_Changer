using CSV_Changer.Items;

namespace CSV_Changer.Extension
{
    public static class CSVFileLineExtension
    {
        public static IEnumerable<CSVFileLine> ToCToCSVFileLine(this IEnumerable<string> source)
        {
            foreach (string line in source) 
            {
                var colums = line.Split(',');

                yield return new CSVFileLine
                {
                    TOW_NAZWA = colums[0],
                    TOW_PRO = colums[1],
                    TOW_CEN = decimal.Parse(colums[2])
                };
            }
        }
    }
}
