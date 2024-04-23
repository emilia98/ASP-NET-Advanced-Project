using System;
using Microsoft.AspNetCore.Identity;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class ApplicationUser : IdentityUser<int>, IAuditInfo, IDeletableEntity
	{
		public ApplicationUser()
		{
            this.UserRoles = new HashSet<ApplicationUserRole>();
            this.Claims = new HashSet<IdentityUserClaim<int>>();
            this.Logins = new HashSet<IdentityUserLogin<int>>();
		}

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }

        public virtual ICollection<IdentityUserClaim<int>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<int>> Logins { get; set; }
    }
}

