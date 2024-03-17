using CSV_Changer.Items;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Changer.Changer
{
    public class CSVWriter : ICSVWriter
    {
        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };
        public void WriteCSVFile(List<CSVFileLine> lines, string path)
        {
            using (var writer = new StreamWriter($"{path}Wholesale_Pricing_{DateTime.Today.ToString("MM-dd-yyyy")}.csv"))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(lines);
            }
        }
    }
}
