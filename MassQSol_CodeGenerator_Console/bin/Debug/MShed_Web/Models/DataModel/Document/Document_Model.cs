using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Document
{
	public class Document_Model : GenericModel
	{
		[DataBinder(DataBinderName="Created_d")]
		public DateTime Created_d {get; set;}

		[DataBinder(DataBinderName="Created_Person_ID_s")]
		public Guid Created_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="Document_ContentType_s")]
		public string Document_ContentType_s {get; set;}

		[DataBinder(DataBinderName="Document_Description_s")]
		public string Document_Description_s {get; set;}

		[DataBinder(DataBinderName="Document_Ext_s")]
		public string Document_Ext_s {get; set;}

		[DataBinder(DataBinderName="Document_Filename_s")]
		public string Document_Filename_s {get; set;}

		[DataBinder(DataBinderName="Document_Location_s")]
		public string Document_Location_s {get; set;}

		[DataBinder(DataBinderName="Document_Size_s")]
		public int Document_Size_s {get; set;}

		[DataBinder(DataBinderName="Modified_d")]
		public DateTime Modified_d {get; set;}

		[DataBinder(DataBinderName="Modified_Person_ID_s")]
		public Guid Modified_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="PK_Document_ID_s", PrimaryKey = true)]
		public Guid PK_Document_ID_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}