using System;
using SQLite.Net.Attributes;

namespace LocalSqliteDemo
{
	public class tblEmployee
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
	}
}
