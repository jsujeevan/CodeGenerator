using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Account
{
	public class __MigrationHistory_Model : GenericModel
	{
		[DataBinder(DataBinderName="ContextKey", PrimaryKey = true)]
		public string ContextKey {get; set;}

		[DataBinder(DataBinderName="MigrationId", PrimaryKey = true)]
		public string MigrationId {get; set;}

		[DataBinder(DataBinderName="Model")]
		public string Model {get; set;}

		[DataBinder(DataBinderName="ProductVersion")]
		public string ProductVersion {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}