using System.Collections.Generic;
using Xamarin.Forms;

namespace LocalSqliteDemo
{
	public partial class LocalSqliteDemoPage : ContentPage
	{
		private static IEmployeeService employeeService { get; } = DependencyService.Get<IEmployeeService>();

		public LocalSqliteDemoPage()
		{
			InitializeComponent();

			//Create Tables
			var db = DependencyService.Get<ISQLite>().GetConnection();
			db.CreateTable<tblEmployee>();


			btnSave.Clicked += (sender, e) =>
			 {
				var employee = new List<tblEmployee>(); 
				employee.Add(new tblEmployee {Name=txtName.Text,Address=txtAddress.Text });
				employeeService.AddEmployees(employee);
			 };

			btnGet.Clicked += (sender, e) =>
			 {
				var empList=  employeeService.GetEmployees();
			};

		}
	}
}
