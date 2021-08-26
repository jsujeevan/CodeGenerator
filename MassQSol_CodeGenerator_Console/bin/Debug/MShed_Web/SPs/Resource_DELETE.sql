CREATE PROCEDURE dbo.Resource_DELETE
@PK_Resource_ID_s			UNIQUEIDENTIFIER,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

DELETE dbo.Resource
	WHERE
		PK_Resource_ID_s = @PK_Resource_ID_s


END