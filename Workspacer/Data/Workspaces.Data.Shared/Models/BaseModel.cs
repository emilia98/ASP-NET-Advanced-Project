﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Workspaces.Data.Shared.Models
{
	public abstract class BaseModel<TKey> : IAuditInfo
	{
		[Key]
		public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}

