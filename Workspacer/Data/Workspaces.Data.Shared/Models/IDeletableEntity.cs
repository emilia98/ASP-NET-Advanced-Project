using System;
namespace Workspaces.Data.Shared.Models
{
	public interface IDeletableEntity
	{
		bool IsDeleted { get; set; }

		DateTime? DeletedOn { get; set; }
	}
}

