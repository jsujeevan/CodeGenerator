using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Resource
{
	public class ContentType_Model : GenericModel
	{
		[DataBinder(DataBinderName="ContentType_s")]
		public string ContentType_s {get; set;}

		[DataBinder(DataBinderName="PK_ContentType_i", PrimaryKey = true)]
		public int PK_ContentType_i {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}