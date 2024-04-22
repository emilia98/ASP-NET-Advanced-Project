using System;
using Workspaces.Data.Shared.Models;

namespace Workspaces.Data.Shared.Repositories
{
	public interface IDeletableRepository<TEntity> : IRepository<TEntity>
		where TEntity : class, IDeletableEntity
	{
		IQueryable<TEntity> AllWithDeleted();

		IQueryable<TEntity> AllAsNoTrackingWithDeleted();

		void HardDelete(TEntity entity);

		void Undelete(TEntity entity);
	}
}

