CREATE PROCEDURE dbo.QualSubjectResource_DELETE
@PK_QualSubjectResource_ID_s			UNIQUEIDENTIFIER,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

DELETE dbo.QualSubjectResource
	WHERE
		PK_QualSubjectResource_ID_s = @PK_QualSubjectResource_ID_s


END