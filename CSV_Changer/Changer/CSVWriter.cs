using CSV_Changer.Items;
using CsvHelper;
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
        public void WriteCSVFile(List<CSVFileLine> lines, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(lines);
            }
        }
    }
}
