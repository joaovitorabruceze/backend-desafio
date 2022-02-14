using backend_desafio.models;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace backend_desafio.Controllers
{
    public class TimeSeriesController : ControllerBase
    {
        private readonly ILogger<TimeSeriesController> _logger;

        public TimeSeriesController (ILogger<TimeSeriesController> logger) { _logger = logger; }

        [HttpPost("process-csv-file")]
        public async Task<ActionResult> ProcessCsvFile(IFormFile file)
        {
            var memoryStream = new MemoryStream(new byte[file.Length]);
            await file.CopyToAsync(memoryStream);
            memoryStream.Position = 0;
            var reader = new StreamReader(memoryStream);
            var config = new CsvConfiguration(CultureInfo.GetCultureInfo("pt-BR"))
            {
                Delimiter = ";"

            };
            var csvFile = new CsvReader(reader, config);

            csvFile.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.Add("null");

            var records = csvFile.GetRecords<TimeSeries>().ToList();

            return Ok(records);
        }
    }
}
