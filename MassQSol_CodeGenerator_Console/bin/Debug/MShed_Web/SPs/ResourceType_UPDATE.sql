CREATE PROCEDURE dbo.ResourceType_UPDATE
@PK_ResourceType_i			INT,
@ResourceType_s			NVARCHAR(255),
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

UPDATE dbo.ResourceType
	SET
		PK_ResourceType_i = @PK_ResourceType_i,
		ResourceType_s = @ResourceType_s
	WHERE
		PK_ResourceType_i = @PK_ResourceType_i


END