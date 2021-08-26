using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Qual
{
	public class QualType_Model : GenericModel
	{
		[DataBinder(DataBinderName="PK_QualType_i", PrimaryKey = true)]
		public int PK_QualType_i {get; set;}

		[DataBinder(DataBinderName="QualType_s")]
		public string QualType_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}