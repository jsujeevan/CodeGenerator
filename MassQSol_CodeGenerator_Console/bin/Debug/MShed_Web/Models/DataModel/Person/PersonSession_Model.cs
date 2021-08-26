using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Person
{
	public class PersonSession_Model : GenericModel
	{
		[DataBinder(DataBinderName="FK_PersonLogin_ID_s")]
		public Guid FK_PersonLogin_ID_s {get; set;}

		[DataBinder(DataBinderName="PersonSession_Action_s")]
		public string PersonSession_Action_s {get; set;}

		[DataBinder(DataBinderName="PersonSession_Controller_s")]
		public string PersonSession_Controller_s {get; set;}

		[DataBinder(DataBinderName="PersonSession_Created_d")]
		public DateTime PersonSession_Created_d {get; set;}

		[DataBinder(DataBinderName="PersonSession_Parameter_s")]
		public string PersonSession_Parameter_s {get; set;}

		[DataBinder(DataBinderName="PK_PersonSession_ID_s", PrimaryKey = true)]
		public Guid PK_PersonSession_ID_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}