using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Service.Controllers
{
	public class PriceController : ApiController
	{
		Price[] pricing = new Price[]
		{
			new Price { Id = 1, Daily = 93, Weekend = 98, Weekly = 90 },
			new Price { Id = 2, Daily = 87, Weekend = 87, Weekly = 87 },
			new Price { Id = 3, Daily = 85, Weekend = 85, Weekly = 85 },
			new Price { Id = 4, Daily = 77, Weekend = 77, Weekly = 77 },
			new Price { Id = 5, Daily = 68, Weekend = 70, Weekly = 60 },
			new Price { Id = 6, Daily = 80, Weekend = 80, Weekly = 80 },
			new Price { Id = 7, Daily = 100, Weekend = 110, Weekly = 96 },
			new Price { Id = 8, Daily = 93, Weekend = 100, Weekly = 90 },
			new Price { Id = 9, Daily = 80, Weekend = 80, Weekly = 80 },
			new Price { Id = 10, Daily = 95, Weekend = 95, Weekly = 85 },
		};

		public IEnumerable<Price> GetAllPricing()
		{
			return pricing;
		}

		public Price GetContentById(int id)
		{
			var price = pricing.FirstOrDefault((p) => p.Id == id);
			if (price == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return price;
		}
	}
}
