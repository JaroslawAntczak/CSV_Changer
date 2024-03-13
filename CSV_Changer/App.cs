using CSV_Changer.Changer;

namespace CSV_Changer
{
    public class App : IApp
    {
        string SourcePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Source\Test.csv";
        string ResaultPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Resault\Test_Resault.csv";

        private readonly ICSVReader _reader;
        private readonly ICSVWriter _writer;
        public App(ICSVReader reader, ICSVWriter writer) 
        {
            _reader = reader;
            _writer = writer;
        }
        public void Run()
        {
            var csvfile = _reader.ReadCSV(SourcePath);
            _writer.WriteCSVFile(csvfile, ResaultPath);
        }
    }
}
