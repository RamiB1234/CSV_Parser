using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CSV_Parser.Infrastructure;
using CSV_Parser.Models.Entities;
using CsvHelper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSV_Parser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpPost]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult> Post(IFormFile file)
        {

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            // Create a NULL reference to product
            Product topProduct = null;

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);

                stream.Position = 0;
                TextReader textReader = new StreamReader(stream);

                using (var csv = new CsvReader(textReader, CultureInfo.InvariantCulture))
                {
                    var products = csv.GetRecords<Product>().ToList();
                    topProduct = ProductEvaluator.Evaluate(products);
                }
            }

            return new OkObjectResult(new { top_product = topProduct.ProductName, product_rating = topProduct.Rating });
        }
    }
}
