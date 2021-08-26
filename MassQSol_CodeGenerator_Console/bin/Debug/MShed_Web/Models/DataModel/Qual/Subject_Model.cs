using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Qual
{
	public class Subject_Model : GenericModel
	{
		[DataBinder(DataBinderName="PK_Subject_i", PrimaryKey = true)]
		public int PK_Subject_i {get; set;}

		[DataBinder(DataBinderName="Subject_s")]
		public string Subject_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}