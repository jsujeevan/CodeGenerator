using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Resource
{
	public class ResourceSupporting_Model : GenericModel
	{
		[DataBinder(DataBinderName="Content_s")]
		public string Content_s {get; set;}

		[DataBinder(DataBinderName="Created_d")]
		public DateTime Created_d {get; set;}

		[DataBinder(DataBinderName="Created_Person_ID_s")]
		public Guid Created_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_ContentType_i")]
		public int FK_ContentType_i {get; set;}

		[DataBinder(DataBinderName="FK_Document_ID_s")]
		public Guid FK_Document_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_Resource_ID_s")]
		public Guid FK_Resource_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_ResourceSupportingType_i")]
		public int FK_ResourceSupportingType_i {get; set;}

		[DataBinder(DataBinderName="Modified_d")]
		public DateTime Modified_d {get; set;}

		[DataBinder(DataBinderName="Modified_Person_ID_s")]
		public Guid Modified_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="Name_s")]
		public string Name_s {get; set;}

		[DataBinder(DataBinderName="PK_ResourceSupporting_ID_s", PrimaryKey = true)]
		public Guid PK_ResourceSupporting_ID_s {get; set;}

		[DataBinder(DataBinderName="ResourceSupporting_Archive_b")]
		public bool ResourceSupporting_Archive_b {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}