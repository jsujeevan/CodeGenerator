CREATE PROCEDURE dbo.ResourceSupporting_DELETE
@PK_ResourceSupporting_ID_s			UNIQUEIDENTIFIER,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

DELETE dbo.ResourceSupporting
	WHERE
		PK_ResourceSupporting_ID_s = @PK_ResourceSupporting_ID_s


END