CREATE PROCEDURE dbo.QualSubjectResource_INSERT
@FK_QualSubject_ID_s			UNIQUEIDENTIFIER,
@FK_Resource_ID_s			UNIQUEIDENTIFIER,
@PK_QualSubjectResource_ID_s			UNIQUEIDENTIFIER,
@QualSubjectResource_Archive_b			BIT,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

INSERT INTO dbo.QualSubjectResource
	(
		FK_QualSubject_ID_s,
		FK_Resource_ID_s,
		PK_QualSubjectResource_ID_s,
		QualSubjectResource_Archive_b
	)
VALUES
	(
		@FK_QualSubject_ID_s,
		@FK_Resource_ID_s,
		@PK_QualSubjectResource_ID_s,
		@QualSubjectResource_Archive_b

	)

END