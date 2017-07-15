using System;
using SQLite.Net;
using SQLite.Net.Async;

namespace LocalSqliteDemo
{
/// <summary>
/// SQLite.Net-PCL
/// 
/// https://github.com/oysteinkrog/SQLite.Net-PCL
/// http://www.xamarinhelp.com/local-storage-day-10/
/// </summary>
public interface ISQLite
{
	void CloseConnection();
	SQLiteConnection GetConnection();
	SQLiteAsyncConnection GetAsyncConnection();
	void DeleteDatabase();
}
}

