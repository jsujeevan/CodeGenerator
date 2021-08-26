using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Account
{
	public class AspNetUserRoles_Model : GenericModel
	{
		[DataBinder(DataBinderName="RoleId", PrimaryKey = true)]
		public string RoleId {get; set;}

		[DataBinder(DataBinderName="UserId", PrimaryKey = true)]
		public string UserId {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}