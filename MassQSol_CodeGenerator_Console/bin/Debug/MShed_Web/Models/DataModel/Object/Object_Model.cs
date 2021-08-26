using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Object
{
	public class Object_Model : GenericModel
	{
		[DataBinder(DataBinderName="FK_Object_Parent_ID_s")]
		public Guid FK_Object_Parent_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_ObjectType_ID_i")]
		public int FK_ObjectType_ID_i {get; set;}

		[DataBinder(DataBinderName="Object_Action_s")]
		public string Object_Action_s {get; set;}

		[DataBinder(DataBinderName="Object_Controller_s")]
		public string Object_Controller_s {get; set;}

		[DataBinder(DataBinderName="Object_Label_s")]
		public string Object_Label_s {get; set;}

		[DataBinder(DataBinderName="Object_Order_i")]
		public int Object_Order_i {get; set;}

		[DataBinder(DataBinderName="Object_s")]
		public string Object_s {get; set;}

		[DataBinder(DataBinderName="Object_Thumbnail_s")]
		public string Object_Thumbnail_s {get; set;}

		[DataBinder(DataBinderName="PK_Object_ID_s", PrimaryKey = true)]
		public Guid PK_Object_ID_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}