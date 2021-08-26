CREATE PROCEDURE dbo.ResourceType_SELECT_COLLECTION
	@_PK_			INT_COLLECTION			READONLY,
	@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

SELECT
	PK_ResourceType_i,
	ResourceType_s
FROM
	dbo.ResourceType
WHERE
	EXISTS	(	SELECT 1	FROM	@_PK_ PKs	WHERE	ResourceType.PK_ResourceType_i = PKs._PK_	)
END