using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalSqliteDemo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new LocalSqliteDemoPage();
		}

		public void CreateAllTables()
		{
			var db = DependencyService.Get<ISQLite>().GetConnection();

			db.CreateTable<tblEmployee>();
		}

		public async Task CreateAllTablesAsync()
		{
			var db = DependencyService.Get<ISQLite>().GetAsyncConnection();

			await db.CreateTableAsync<tblEmployee>().ConfigureAwait(false);
		}

		/// <summary>
		/// Dropping tables ONLY works using the synchronous DB connection
		/// For some reason, dropping asynchronously fails miserably
		/// </summary>
		public void DropAllTables()
		{
			var db = DependencyService.Get<ISQLite>().GetConnection();

			db.DropTable<tblEmployee>();
		}

	}
}
