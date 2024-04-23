using System;
using System.ComponentModel.DataAnnotations;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class Request : BaseDeletableModel<int>
	{
		public Request()
		{
			this.Offers = new HashSet<Offer>();
		}

		[Required]
		public int ClientId { get; set; }

		public virtual ApplicationUser Client { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Title { get; set; }

		// StartDate
		public DateTime? StartDate { get; set; }

		// End Date
		public DateTime? EndDate { get; set; }

		// Budget (decimal)
		[Required]
		public decimal Budget { get; set; }

		// virtual Hashset<Offer> Offers
		public virtual ICollection<Offer> Offers { get; set; }
	}
}

