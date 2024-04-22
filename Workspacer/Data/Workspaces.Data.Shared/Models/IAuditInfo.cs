using System;
namespace Workspaces.Data.Shared.Models
{
	public interface IAuditInfo
	{
		DateTime CreatedOn { get; set; }

		DateTime? ModifiedOn { get; set; }
	}
}

