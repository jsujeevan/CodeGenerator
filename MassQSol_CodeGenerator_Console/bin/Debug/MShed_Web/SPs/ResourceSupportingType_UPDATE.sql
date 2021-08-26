CREATE PROCEDURE dbo.ResourceSupportingType_UPDATE
@PK_ResourceSupportingType_i			INT,
@ResourceSupportingType_s			NVARCHAR(255),
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

UPDATE dbo.ResourceSupportingType
	SET
		PK_ResourceSupportingType_i = @PK_ResourceSupportingType_i,
		ResourceSupportingType_s = @ResourceSupportingType_s
	WHERE
		PK_ResourceSupportingType_i = @PK_ResourceSupportingType_i


END