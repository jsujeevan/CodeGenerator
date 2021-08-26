using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Person
{
	public class PersonLogin_Model : GenericModel
	{
		[DataBinder(DataBinderName="FK_Person_ID_s")]
		public Guid FK_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Attempt_i")]
		public int PersonLogin_Attempt_i {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Browser_s")]
		public string PersonLogin_Browser_s {get; set;}

		[DataBinder(DataBinderName="PersonLogin_BrowserDetails_s")]
		public string PersonLogin_BrowserDetails_s {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Impersonate_b")]
		public bool PersonLogin_Impersonate_b {get; set;}

		[DataBinder(DataBinderName="PersonLogin_IP_s")]
		public string PersonLogin_IP_s {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Login_d")]
		public DateTime PersonLogin_Login_d {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Logout_d")]
		public DateTime PersonLogin_Logout_d {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Success_b")]
		public bool PersonLogin_Success_b {get; set;}

		[DataBinder(DataBinderName="PersonLogin_Username_s")]
		public string PersonLogin_Username_s {get; set;}

		[DataBinder(DataBinderName="PK_PersonLogin_ID_s", PrimaryKey = true)]
		public Guid PK_PersonLogin_ID_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}