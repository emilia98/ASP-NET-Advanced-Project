using System;
using Microsoft.AspNetCore.Identity;
using Workspaces.Data.Shared.Models;

namespace Workspacer.Data.Models
{
	public class ApplicationRole : IdentityRole<int>, IAuditInfo, IDeletableEntity
	{
		public ApplicationRole()
            : this(null)
		{
		}

        public ApplicationRole(string? name)
            : base(name)
        {
            this.UserRoles = new HashSet<ApplicationUserRole>();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}

