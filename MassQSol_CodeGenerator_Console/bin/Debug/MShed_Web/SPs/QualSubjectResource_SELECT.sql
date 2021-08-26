CREATE PROCEDURE dbo.QualSubjectResource_SELECT
@FK_QualSubject_ID_s			UNIQUEIDENTIFIER = NULL,
@FK_Resource_ID_s			UNIQUEIDENTIFIER = NULL,
@PK_QualSubjectResource_ID_s			UNIQUEIDENTIFIER = NULL,
@QualSubjectResource_Archive_b			BIT = NULL,
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
	(@FK_QualSubject_ID_s			IS NULL			OR			(QualSubjectResource.FK_QualSubject_ID_s=@FK_QualSubject_ID_s))
	AND
	(@FK_Resource_ID_s			IS NULL			OR			(QualSubjectResource.FK_Resource_ID_s=@FK_Resource_ID_s))
	AND
	(@PK_QualSubjectResource_ID_s			IS NULL			OR			(QualSubjectResource.PK_QualSubjectResource_ID_s=@PK_QualSubjectResource_ID_s))
	AND
	(@QualSubjectResource_Archive_b			IS NULL			OR			(QualSubjectResource.QualSubjectResource_Archive_b=@QualSubjectResource_Archive_b))


END