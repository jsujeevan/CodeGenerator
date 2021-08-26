using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Resource
{
	public class ResourceType_Model : GenericModel
	{
		[DataBinder(DataBinderName="PK_ResourceType_i", PrimaryKey = true)]
		public int PK_ResourceType_i {get; set;}

		[DataBinder(DataBinderName="ResourceType_s")]
		public string ResourceType_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}