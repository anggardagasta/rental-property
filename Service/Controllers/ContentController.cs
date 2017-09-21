using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Service.Controllers
{
	public class ContentController : ApiController
	{
		Content[] contents = new Content[]
		{
			new Content { Id = 1, Title = "HIDEOUT BALI - Eco Bamboo Home", Type = "Entire bungalow", Location = "Indonesia", Bed = 2 },
			new Content { Id = 2, Title = "Stunning All Bamboo House by River", Type = "Entire house", Location = "Indonesia", Bed = 3 },
			new Content { Id = 3, Title = "Ocean Beachfront Luxury Design Villa @ Lovina", Type = "Entire villa", Location = "Indonesia", Bed = 2 },
			new Content { Id = 4, Title = "Korean Traditional Hanok", Type = "Entire house", Location = "South Korea", Bed = 4 },
			new Content { Id = 5, Title = "Middle of Gangnam_ Stay", Type = "Private Room", Location = "South Korea", Bed = 1 },
			new Content { Id = 6, Title = "off-grid tiny cottage in nature", Type = "Entire Cabin", Location = "Japan", Bed = 2 },
			new Content { Id = 7, Title = "ANTIQUE HOUSE KYOTO", Type = "Entire House", Location = "Japan", Bed = 4 },
			new Content { Id = 8, Title = "Superb location, Heian Shrine, Bus Stop in front - Apartments for Rent in Kyōto-shi, Kyōto-fu, Japan", Type = "Entire apartment", Location = "Japan", Bed = 1 },
			new Content { Id = 9, Title = "Nomo Times You Apartment Opens in new window", Type = "Entire apartment", Location = "China", Bed = 2 },
			new Content { Id = 10, Title = "Chengdu Flipflop Lounge Hostel Opens in new window", Type = "Entire House", Location = "China", Bed = 3 },
		};

		public IEnumerable<Content> GetAllContents()
		{
			return contents;
		}

		public Content GetContentById(int id)
		{
			var content = contents.FirstOrDefault((p) => p.Id == id);
			if (content == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return content;
		}
	}
}
