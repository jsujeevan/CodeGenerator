using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Account
{
	public class AspNetUsers_Model : GenericModel
	{
		[DataBinder(DataBinderName="AccessFailedCount")]
		public int AccessFailedCount {get; set;}

		[DataBinder(DataBinderName="Email")]
		public string Email {get; set;}

		[DataBinder(DataBinderName="EmailConfirmed")]
		public bool EmailConfirmed {get; set;}

		[DataBinder(DataBinderName="Id", PrimaryKey = true)]
		public string Id {get; set;}

		[DataBinder(DataBinderName="LockoutEnabled")]
		public bool LockoutEnabled {get; set;}

		[DataBinder(DataBinderName="LockoutEndDateUtc")]
		public DateTime LockoutEndDateUtc {get; set;}

		[DataBinder(DataBinderName="PasswordHash")]
		public string PasswordHash {get; set;}

		[DataBinder(DataBinderName="PhoneNumber")]
		public string PhoneNumber {get; set;}

		[DataBinder(DataBinderName="PhoneNumberConfirmed")]
		public bool PhoneNumberConfirmed {get; set;}

		[DataBinder(DataBinderName="SecurityStamp")]
		public string SecurityStamp {get; set;}

		[DataBinder(DataBinderName="TwoFactorEnabled")]
		public bool TwoFactorEnabled {get; set;}

		[DataBinder(DataBinderName="UserName")]
		public string UserName {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}