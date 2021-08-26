using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Qual
{
	public class Qual_Model : GenericModel
	{
		[DataBinder(DataBinderName="Created_d")]
		public DateTime Created_d {get; set;}

		[DataBinder(DataBinderName="Created_Person_ID_s")]
		public Guid Created_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_Qual_Type_i")]
		public int FK_Qual_Type_i {get; set;}

		[DataBinder(DataBinderName="Modified_d")]
		public DateTime Modified_d {get; set;}

		[DataBinder(DataBinderName="Modified_Person_ID_s")]
		public Guid Modified_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="PK_Qual_ID_s", PrimaryKey = true)]
		public Guid PK_Qual_ID_s {get; set;}

		[DataBinder(DataBinderName="Qual_AgeGroup_s")]
		public string Qual_AgeGroup_s {get; set;}

		[DataBinder(DataBinderName="Qual_Description_s")]
		public string Qual_Description_s {get; set;}

		[DataBinder(DataBinderName="Qual_Duration_s")]
		public string Qual_Duration_s {get; set;}

		[DataBinder(DataBinderName="Qual_s")]
		public string Qual_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}