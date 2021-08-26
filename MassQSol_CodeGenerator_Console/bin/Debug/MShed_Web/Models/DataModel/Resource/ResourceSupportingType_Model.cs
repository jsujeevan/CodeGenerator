using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Resource
{
	public class ResourceSupportingType_Model : GenericModel
	{
		[DataBinder(DataBinderName="PK_ResourceSupportingType_i", PrimaryKey = true)]
		public int PK_ResourceSupportingType_i {get; set;}

		[DataBinder(DataBinderName="ResourceSupportingType_s")]
		public string ResourceSupportingType_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}