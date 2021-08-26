CREATE PROCEDURE dbo.ResourceSupportingType_SELECT
@PK_ResourceSupportingType_i			INT = NULL,
@ResourceSupportingType_s			NVARCHAR(255) = NULL,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

SELECT
	PK_ResourceSupportingType_i,
	ResourceSupportingType_s
FROM
	dbo.ResourceSupportingType
WHERE
	(@PK_ResourceSupportingType_i			IS NULL			OR			(ResourceSupportingType.PK_ResourceSupportingType_i=@PK_ResourceSupportingType_i))
	AND
	(@ResourceSupportingType_s			IS NULL			OR			(ResourceSupportingType.ResourceSupportingType_s=@ResourceSupportingType_s))


END