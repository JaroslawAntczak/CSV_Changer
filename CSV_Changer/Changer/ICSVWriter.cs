using CSV_Changer.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Changer.Changer
{
    public interface ICSVWriter
    {
        void WriteCSVFile(List<CSVFileLine> lines, string path);
    }
}
