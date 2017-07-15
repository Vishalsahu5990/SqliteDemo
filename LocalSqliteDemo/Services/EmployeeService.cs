using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LocalSqliteDemo;
using SQLite.Net.Async;
using Xamarin.Forms;

[assembly: Dependency(typeof(EmployeeService))]
namespace LocalSqliteDemo
{
	public class EmployeeService:IEmployeeService
	{
private static readonly AsyncLock Locker = new AsyncLock();

private SQLiteAsyncConnection Database { get; } = DependencyService.Get<ISQLite>().GetAsyncConnection();

public async Task AddEmployees(IList<tblEmployee> movies)
{
	using (await Locker.LockAsync())
	{
		await Database.InsertAllAsync(movies);
	}
}

		public async Task<IList<tblEmployee>> GetEmployees()
{
	using (await Locker.LockAsync())
	{
		return await Database.Table<tblEmployee>().Where(x => x.Id > 0).ToListAsync();
	}
}
    }
}

