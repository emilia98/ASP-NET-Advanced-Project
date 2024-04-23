using System;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class ProjectTask : BaseDeletableModel<int>
	{
		public ProjectTask()
		{
		}

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime? EndDate { get; set; }

		public int ProjectId { get; set; }

		public virtual Project Project { get; set; }

	}
}

