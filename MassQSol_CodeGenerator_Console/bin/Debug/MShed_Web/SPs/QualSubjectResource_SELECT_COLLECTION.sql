CREATE PROCEDURE dbo.QualSubjectResource_SELECT_COLLECTION
	@_PK_			UNIQUEIDENTIFIER_COLLECTION			READONLY,
	@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

SELECT
	FK_QualSubject_ID_s,
	FK_Resource_ID_s,
	PK_QualSubjectResource_ID_s,
	QualSubjectResource_Archive_b
FROM
	dbo.QualSubjectResource
WHERE
	EXISTS	(	SELECT 1	FROM	@_PK_ PKs	WHERE	QualSubjectResource.PK_QualSubjectResource_ID_s = PKs._PK_	)
END