using System;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class Offer : BaseDeletableModel<int>
	{
		public Offer()
		{
		}

		public int InitiatorId { get; set; }

		// virtual Initiator
		public virtual ApplicationUser Initiator { get; set; }

		// RequestId
		public int RequestId { get; set; }

		// Request
		public Request Request { get; set; }

		// Start Date
		public DateTime? StartDate { get; set; }

		// End Date
		public DateTime? EndDate { get; set; }

		// Budget (decimal)
		public decimal Budget { get; set; }

		// IsApproved (approved -> true, disapproved -> false, null -> pending)
		public bool? IsApproved { get; set; }
	}
}

