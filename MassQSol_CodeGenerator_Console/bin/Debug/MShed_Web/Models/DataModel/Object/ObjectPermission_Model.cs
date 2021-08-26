using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Object
{
	public class ObjectPermission_Model : GenericModel
	{
		[DataBinder(DataBinderName="FK_Object_ID_s")]
		public Guid FK_Object_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_ObjectRole_ID_i")]
		public int FK_ObjectRole_ID_i {get; set;}

		[DataBinder(DataBinderName="PK_ObjectPermission_ID_s", PrimaryKey = true)]
		public Guid PK_ObjectPermission_ID_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}