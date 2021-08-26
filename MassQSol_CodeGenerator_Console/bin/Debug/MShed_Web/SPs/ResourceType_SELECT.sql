CREATE PROCEDURE dbo.ResourceType_SELECT
@PK_ResourceType_i			INT = NULL,
@ResourceType_s			NVARCHAR(255) = NULL,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

SELECT
	PK_ResourceType_i,
	ResourceType_s
FROM
	dbo.ResourceType
WHERE
	(@PK_ResourceType_i			IS NULL			OR			(ResourceType.PK_ResourceType_i=@PK_ResourceType_i))
	AND
	(@ResourceType_s			IS NULL			OR			(ResourceType.ResourceType_s=@ResourceType_s))


END