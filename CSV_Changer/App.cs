using CSV_Changer.Changer;

namespace CSV_Changer
{
    public class App : IApp
    {
        string SourcePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Source\Test.csv";
        private readonly ICSVReader _reader;
        public App(ICSVReader reader) 
        {
            _reader = reader;
        }
        public void Run()
        {
            var csvfile = _reader.ReadCSV(SourcePath);
            foreach (var item in csvfile) 
            {
                Console.WriteLine(item.TOW_NAZWA);
                Console.WriteLine(item.TOW_PRO);
                Console.WriteLine(item.TOW_CEN);
            }
        }
    }
}
