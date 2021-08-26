using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Object
{
	public class ObjectRole_Model : GenericModel
	{
		[DataBinder(DataBinderName="ObjectRole_s")]
		public string ObjectRole_s {get; set;}

		[DataBinder(DataBinderName="PK_ObjectRole_ID_i", PrimaryKey = true)]
		public int PK_ObjectRole_ID_i {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}