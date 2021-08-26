using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Person
{
	public class Person_Model : GenericModel
	{
		[DataBinder(DataBinderName="Created_d")]
		public DateTime Created_d {get; set;}

		[DataBinder(DataBinderName="Created_Person_ID_s")]
		public Guid Created_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_Person_Role_i")]
		public int FK_Person_Role_i {get; set;}

		[DataBinder(DataBinderName="FK_Person_Status_i")]
		public int FK_Person_Status_i {get; set;}

		[DataBinder(DataBinderName="Modified_d")]
		public DateTime Modified_d {get; set;}

		[DataBinder(DataBinderName="Modified_Person_ID_s")]
		public Guid Modified_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="Person_Archive_b")]
		public bool Person_Archive_b {get; set;}

		[DataBinder(DataBinderName="Person_Email_s")]
		public string Person_Email_s {get; set;}

		[DataBinder(DataBinderName="Person_Firstname_s")]
		public string Person_Firstname_s {get; set;}

		[DataBinder(DataBinderName="Person_Lastname_s")]
		public string Person_Lastname_s {get; set;}

		[DataBinder(DataBinderName="Person_Telephone_s")]
		public string Person_Telephone_s {get; set;}

		[DataBinder(DataBinderName="PK_Person_ID_s", PrimaryKey = true)]
		public Guid PK_Person_ID_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}