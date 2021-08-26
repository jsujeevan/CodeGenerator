using System;
using MShed_Web.BOs;

namespace MShed_Web.Models.DataModel.Qual
{
	public class QualSubjectResource_Model : GenericModel
	{
		[DataBinder(DataBinderName="FK_QualSubject_ID_s")]
		public Guid FK_QualSubject_ID_s {get; set;}

		[DataBinder(DataBinderName="FK_Resource_ID_s")]
		public Guid FK_Resource_ID_s {get; set;}

		[DataBinder(DataBinderName="PK_QualSubjectResource_ID_s", PrimaryKey = true)]
		public Guid PK_QualSubjectResource_ID_s {get; set;}

		[DataBinder(DataBinderName="QualSubjectResource_Archive_b")]
		public bool QualSubjectResource_Archive_b {get; set;}

		public Guid FK_Session_Person_ID_s { get; set; }
	}
}