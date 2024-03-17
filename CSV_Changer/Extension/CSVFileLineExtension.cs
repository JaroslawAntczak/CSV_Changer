using CSV_Changer.Items;

namespace CSV_Changer.Extension
{
    public static class CSVFileLineExtension
    {
        public static char TrimChar = '"';
        public static IEnumerable<CSVFileLine> ToCToCSVFileLine(this IEnumerable<string> source)
        {
            foreach (string line in source) 
            {
                var colums = line.Split(';');

                yield return new CSVFileLine
                {
                    TOW_KOD = colums[0].Trim(TrimChar),
                    SUM_PRICE = colums[1].Trim(TrimChar),
                    IC_INDEX = colums[4].Trim(TrimChar),
                    TEC_DOC = colums[4].Trim(TrimChar),
                    CORE_INDEX = $"#{colums[4].Trim(TrimChar)}",
                    TEC_DOC_PROD = "",
                    WHOLESALE_NET_PRICE = "",
                    CORE_PRICE = ""
                };
            }
        }
    }
}
