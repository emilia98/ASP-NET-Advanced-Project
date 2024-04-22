using System;
namespace Workspaces.Data.Shared
{
	public interface IDbQueryRunner : IDisposable
	{
		Task RunQueryAsync(string query, params object[] parameters);
	}
}

