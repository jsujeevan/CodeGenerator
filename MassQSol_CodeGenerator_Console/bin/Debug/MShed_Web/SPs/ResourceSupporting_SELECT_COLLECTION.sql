CREATE PROCEDURE dbo.ResourceSupporting_SELECT_COLLECTION
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
	FK_Resource_ID_s,
	FK_ResourceSupportingType_i,
	Modified_d,
	Modified_Person_ID_s,
	Name_s,
	PK_ResourceSupporting_ID_s,
	ResourceSupporting_Archive_b
FROM
	dbo.ResourceSupporting
WHERE
	EXISTS	(	SELECT 1	FROM	@_PK_ PKs	WHERE	ResourceSupporting.PK_ResourceSupporting_ID_s = PKs._PK_	)
END