using System;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class Requirement : BaseDeletableModel<int>
	{
		public Requirement()
		{
		}

		public int ProjectId { get; set; }

		public virtual Project Project { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }
	}
}

