CREATE PROCEDURE dbo.Resource_SELECT
@Content_s			NVARCHAR(MAX) = NULL,
@Created_d			DATETIME = NULL,
@Created_Person_ID_s			UNIQUEIDENTIFIER = NULL,
@FK_ContentType_i			INT = NULL,
@FK_Document_ID_s			UNIQUEIDENTIFIER = NULL,
@FK_ResourceType_i			INT = NULL,
@Modified_d			DATETIME = NULL,
@Modified_Person_ID_s			UNIQUEIDENTIFIER = NULL,
@Name_s			NVARCHAR(255) = NULL,
@PK_Resource_ID_s			UNIQUEIDENTIFIER = NULL,
@Resource_Archive_b			BIT = NULL,
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
	(@Content_s			IS NULL			OR			(Resource.Content_s=@Content_s))
	AND
	(@Created_d			IS NULL			OR			(Resource.Created_d=@Created_d))
	AND
	(@Created_Person_ID_s			IS NULL			OR			(Resource.Created_Person_ID_s=@Created_Person_ID_s))
	AND
	(@FK_ContentType_i			IS NULL			OR			(Resource.FK_ContentType_i=@FK_ContentType_i))
	AND
	(@FK_Document_ID_s			IS NULL			OR			(Resource.FK_Document_ID_s=@FK_Document_ID_s))
	AND
	(@FK_ResourceType_i			IS NULL			OR			(Resource.FK_ResourceType_i=@FK_ResourceType_i))
	AND
	(@Modified_d			IS NULL			OR			(Resource.Modified_d=@Modified_d))
	AND
	(@Modified_Person_ID_s			IS NULL			OR			(Resource.Modified_Person_ID_s=@Modified_Person_ID_s))
	AND
	(@Name_s			IS NULL			OR			(Resource.Name_s=@Name_s))
	AND
	(@PK_Resource_ID_s			IS NULL			OR			(Resource.PK_Resource_ID_s=@PK_Resource_ID_s))
	AND
	(@Resource_Archive_b			IS NULL			OR			(Resource.Resource_Archive_b=@Resource_Archive_b))


END