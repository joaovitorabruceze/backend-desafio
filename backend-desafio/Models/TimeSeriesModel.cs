using CsvHelper.Configuration.Attributes;

namespace backend_desafio.models
{
    public class TimeSeriesModel
    {
        [Name("Data")]
        public DateTime Date { get; set; }
        [Name("50ZI001/COTA-DIF - Displacement (mm)")]
        public double? Serie1 { get; set; }
        [Name("50ZI002/COTA-DIF - Displacement (mm)")]
        public double? Serie2 { get; set; }
        [Name("50ZI003/COTA-DIF - Displacement (mm)")]
        public double? Serie3 { get; set; }
    }
}
