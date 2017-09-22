using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Service.Controllers
{
	public class AvailabilitiesController : ApiController
	{
		int[] ids = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

		public List<Availabilities> GetAvailabilities()
		{
			List<Availability> availabilities = new List<Availability>();
			availabilities.Add(new Availability() { StartDate = "2017-10-01", EndDate = "2017-10-04" });
			availabilities.Add(new Availability() { StartDate = "2017-10-21", EndDate = "2017-10-23" });

			List<Availabilities> avails = new List<Availabilities>();
			foreach (var id in ids)
			{
				avails.Add(new Availabilities()
				{
					Id = id,
					Availability = availabilities
						
				});
			}
			return avails;
		}

		public List<Availabilities> GetAvailabilityById(int id)
		{
			List<Availability> availabilities = new List<Availability>();
			availabilities.Add(new Availability() { StartDate = "2017-10-01", EndDate = "2017-10-04" });
			availabilities.Add(new Availability() { StartDate = "2017-10-21", EndDate = "2017-10-23" });

			List<Availabilities> avails = new List<Availabilities>();
			avails.Add(new Availabilities()
			{
				Id = id,
				Availability = availabilities

			});
			return avails;
		}
	}
}
