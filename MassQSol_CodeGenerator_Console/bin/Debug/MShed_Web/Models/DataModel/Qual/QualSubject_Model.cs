using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Qual
{
	public class QualSubject_Model : GenericModel
	{
		[DataBinder(DataBinderName="Created_d")]
		public DateTime Created_d {get; set;}

		[DataBinder(DataBinderName="Created_Person_ID_s")]
		public Guid Created_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_Qual_ID_s")]
		public Guid FK_Qual_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_Subject_i")]
		public int FK_Subject_i {get; set;}

		[DataBinder(DataBinderName="Modified_d")]
		public DateTime Modified_d {get; set;}

		[DataBinder(DataBinderName="Modified_Person_ID_s")]
		public Guid Modified_Person_ID_s {get; set;}

		[DataBinder(DataBinderName="PK_QualSubject_ID_s", PrimaryKey = true)]
		public Guid PK_QualSubject_ID_s {get; set;}

		[DataBinder(DataBinderName="QualSubject_Archive_b")]
		public bool QualSubject_Archive_b {get; set;}

		[DataBinder(DataBinderName="QualSubject_Description_s")]
		public string QualSubject_Description_s {get; set;}

		[DataBinder(DataBinderName="QualSubject_s")]
		public string QualSubject_s {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}