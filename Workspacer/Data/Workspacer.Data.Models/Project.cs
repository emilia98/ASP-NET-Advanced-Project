using System;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class Project : BaseDeletableModel<int>
	{
		public Project()
		{
			this.Requirements = new HashSet<Requirement>();
			this.Tasks = new HashSet<Task>();
		}

		// OwnerId
		public int OwnerId { get; set; }

		// Owner
		public virtual ApplicationUser Owner { get; set; }

		// Start Date
		public DateTime StartDate { get; set; }

		// End Date
		public DateTime? EndDate { get; set; }

		// Requirements
		public virtual ICollection<Requirement> Requirements { get; set; }

		// Tasks (HashSet)
		public virtual ICollection<Task> Tasks { get; set; }

	}
}

