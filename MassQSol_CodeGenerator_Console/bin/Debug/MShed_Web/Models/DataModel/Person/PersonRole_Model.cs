using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Person
{
	public class PersonRole_Model : GenericModel
	{
		[DataBinder(DataBinderName="PersonRole_s")]
		public string PersonRole_s {get; set;}

		[DataBinder(DataBinderName="PK_PersonRole_i", PrimaryKey = true)]
		public int PK_PersonRole_i {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}