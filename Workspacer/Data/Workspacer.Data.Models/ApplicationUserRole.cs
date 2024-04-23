using System;
using Microsoft.AspNetCore.Identity;

namespace Workspacer.Data.Models
{
	public class ApplicationUserRole : IdentityUserRole<int>
	{
		public ApplicationUser User { get; set; }

		public ApplicationRole Role { get; set; }
	}
}

