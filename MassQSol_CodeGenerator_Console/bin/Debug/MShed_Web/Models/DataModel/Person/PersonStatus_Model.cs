using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Person
{
	public class PersonStatus_Model : GenericModel
	{
		[DataBinder(DataBinderName="PersonStatus_s")]
		public string PersonStatus_s {get; set;}

		[DataBinder(DataBinderName="PK_PersonStatus_i", PrimaryKey = true)]
		public int PK_PersonStatus_i {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}