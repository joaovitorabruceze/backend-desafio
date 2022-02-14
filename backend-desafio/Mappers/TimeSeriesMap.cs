using backend_desafio.models;
using CsvHelper.Configuration;

namespace backend_desafio.Mappers
{
    public class TimeSeriesMap : ClassMap<TimeSeries>
    {
        public TimeSeriesMap()
        {
            Map(m => m.Date).Name("Data");
            Map(m => m.Serie1).Name("50ZI001/COTA-DIF - Displacement (mm)");
            Map(m => m.Serie2).Name("50ZI002/COTA-DIF - Displacement (mm)");
            Map(m => m.Serie3).Name("50ZI003/COTA-DIF - Displacement (mm)");
        }
    }
}
