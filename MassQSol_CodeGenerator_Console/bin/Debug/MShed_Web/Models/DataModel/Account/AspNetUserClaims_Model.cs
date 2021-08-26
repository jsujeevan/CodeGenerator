using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Account
{
	public class AspNetUserClaims_Model : GenericModel
	{
		[DataBinder(DataBinderName="ClaimType")]
		public string ClaimType {get; set;}

		[DataBinder(DataBinderName="ClaimValue")]
		public string ClaimValue {get; set;}

		[DataBinder(DataBinderName="Id", PrimaryKey = true)]
		public int Id {get; set;}

		[DataBinder(DataBinderName="UserId")]
		public string UserId {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}