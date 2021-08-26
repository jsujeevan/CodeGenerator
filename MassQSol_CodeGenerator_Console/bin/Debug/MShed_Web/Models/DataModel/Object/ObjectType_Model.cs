using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Object
{
	public class ObjectType_Model : GenericModel
	{
		[DataBinder(DataBinderName="ObjectType_s")]
		public string ObjectType_s {get; set;}

		[DataBinder(DataBinderName="PK_ObjectType_ID_i", PrimaryKey = true)]
		public int PK_ObjectType_ID_i {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}