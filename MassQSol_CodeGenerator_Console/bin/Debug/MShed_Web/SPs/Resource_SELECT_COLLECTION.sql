CREATE PROCEDURE dbo.Resource_SELECT_COLLECTION
	@_PK_			UNIQUEIDENTIFIER_COLLECTION			READONLY,
	@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

SELECT
	Content_s,
	Created_d,
	Created_Person_ID_s,
	FK_ContentType_i,
	FK_Document_ID_s,
	FK_ResourceType_i,
	Modified_d,
	Modified_Person_ID_s,
	Name_s,
	PK_Resource_ID_s,
	Resource_Archive_b
FROM
	dbo.Resource
WHERE
	EXISTS	(	SELECT 1	FROM	@_PK_ PKs	WHERE	Resource.PK_Resource_ID_s = PKs._PK_	)
END