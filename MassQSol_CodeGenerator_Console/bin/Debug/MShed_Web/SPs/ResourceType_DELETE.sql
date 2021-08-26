CREATE PROCEDURE dbo.ResourceType_DELETE
@PK_ResourceType_i			INT,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

DELETE dbo.ResourceType
	WHERE
		PK_ResourceType_i = @PK_ResourceType_i


END