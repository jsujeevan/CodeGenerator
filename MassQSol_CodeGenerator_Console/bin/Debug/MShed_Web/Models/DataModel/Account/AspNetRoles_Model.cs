using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Account
{
	public class AspNetRoles_Model : GenericModel
	{
		[DataBinder(DataBinderName="Id", PrimaryKey = true)]
		public string Id {get; set;}

		[DataBinder(DataBinderName="Name")]
		public string Name {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}