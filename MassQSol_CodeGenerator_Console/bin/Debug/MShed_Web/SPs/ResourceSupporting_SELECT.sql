CREATE PROCEDURE dbo.ResourceSupporting_SELECT
@Content_s			NVARCHAR(MAX) = NULL,
@Created_d			DATETIME = NULL,
@Created_Person_ID_s			UNIQUEIDENTIFIER = NULL,
@FK_ContentType_i			INT = NULL,
@FK_Document_ID_s			UNIQUEIDENTIFIER = NULL,
@FK_Resource_ID_s			UNIQUEIDENTIFIER = NULL,
@FK_ResourceSupportingType_i			INT = NULL,
@Modified_d			DATETIME = NULL,
@Modified_Person_ID_s			UNIQUEIDENTIFIER = NULL,
@Name_s			NVARCHAR(255) = NULL,
@PK_ResourceSupporting_ID_s			UNIQUEIDENTIFIER = NULL,
@ResourceSupporting_Archive_b			BIT = NULL,
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
	(@Content_s			IS NULL			OR			(ResourceSupporting.Content_s=@Content_s))
	AND
	(@Created_d			IS NULL			OR			(ResourceSupporting.Created_d=@Created_d))
	AND
	(@Created_Person_ID_s			IS NULL			OR			(ResourceSupporting.Created_Person_ID_s=@Created_Person_ID_s))
	AND
	(@FK_ContentType_i			IS NULL			OR			(ResourceSupporting.FK_ContentType_i=@FK_ContentType_i))
	AND
	(@FK_Document_ID_s			IS NULL			OR			(ResourceSupporting.FK_Document_ID_s=@FK_Document_ID_s))
	AND
	(@FK_Resource_ID_s			IS NULL			OR			(ResourceSupporting.FK_Resource_ID_s=@FK_Resource_ID_s))
	AND
	(@FK_ResourceSupportingType_i			IS NULL			OR			(ResourceSupporting.FK_ResourceSupportingType_i=@FK_ResourceSupportingType_i))
	AND
	(@Modified_d			IS NULL			OR			(ResourceSupporting.Modified_d=@Modified_d))
	AND
	(@Modified_Person_ID_s			IS NULL			OR			(ResourceSupporting.Modified_Person_ID_s=@Modified_Person_ID_s))
	AND
	(@Name_s			IS NULL			OR			(ResourceSupporting.Name_s=@Name_s))
	AND
	(@PK_ResourceSupporting_ID_s			IS NULL			OR			(ResourceSupporting.PK_ResourceSupporting_ID_s=@PK_ResourceSupporting_ID_s))
	AND
	(@ResourceSupporting_Archive_b			IS NULL			OR			(ResourceSupporting.ResourceSupporting_Archive_b=@ResourceSupporting_Archive_b))


END