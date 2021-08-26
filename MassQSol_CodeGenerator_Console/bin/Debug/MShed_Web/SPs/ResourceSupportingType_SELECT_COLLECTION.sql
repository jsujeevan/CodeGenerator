CREATE PROCEDURE dbo.ResourceSupportingType_SELECT_COLLECTION
	@_PK_			INT_COLLECTION			READONLY,
	@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

SELECT
	PK_ResourceSupportingType_i,
	ResourceSupportingType_s
FROM
	dbo.ResourceSupportingType
WHERE
	EXISTS	(	SELECT 1	FROM	@_PK_ PKs	WHERE	ResourceSupportingType.PK_ResourceSupportingType_i = PKs._PK_	)
END