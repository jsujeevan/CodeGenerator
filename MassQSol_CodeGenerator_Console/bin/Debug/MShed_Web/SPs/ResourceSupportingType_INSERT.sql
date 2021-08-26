CREATE PROCEDURE dbo.ResourceSupportingType_INSERT
@PK_ResourceSupportingType_i			INT,
@ResourceSupportingType_s			NVARCHAR(255),
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

INSERT INTO dbo.ResourceSupportingType
	(
		PK_ResourceSupportingType_i,
		ResourceSupportingType_s
	)
VALUES
	(
		@PK_ResourceSupportingType_i,
		@ResourceSupportingType_s

	)

END