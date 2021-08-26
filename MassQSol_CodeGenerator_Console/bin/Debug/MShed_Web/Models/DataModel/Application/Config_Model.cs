using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Application
{
	public class Config_Model : GenericModel
	{
		[DataBinder(DataBinderName="Config_Value_s")]
		public string Config_Value_s {get; set;}

		[DataBinder(DataBinderName="PK_Key_s", PrimaryKey = true)]
		public string PK_Key_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}