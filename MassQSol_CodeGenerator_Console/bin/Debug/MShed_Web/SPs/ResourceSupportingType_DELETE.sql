CREATE PROCEDURE dbo.ResourceSupportingType_DELETE
@PK_ResourceSupportingType_i			INT,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

DELETE dbo.ResourceSupportingType
	WHERE
		PK_ResourceSupportingType_i = @PK_ResourceSupportingType_i


END