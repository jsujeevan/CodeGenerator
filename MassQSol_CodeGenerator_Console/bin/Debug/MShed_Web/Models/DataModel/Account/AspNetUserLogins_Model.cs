using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Account
{
	public class AspNetUserLogins_Model : GenericModel
	{
		[DataBinder(DataBinderName="LoginProvider", PrimaryKey = true)]
		public string LoginProvider {get; set;}

		[DataBinder(DataBinderName="ProviderKey", PrimaryKey = true)]
		public string ProviderKey {get; set;}

		[DataBinder(DataBinderName="UserId", PrimaryKey = true)]
		public string UserId {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}