CREATE PROCEDURE dbo.ResourceType_INSERT
@PK_ResourceType_i			INT,
@ResourceType_s			NVARCHAR(255),
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

INSERT INTO dbo.ResourceType
	(
		PK_ResourceType_i,
		ResourceType_s
	)
VALUES
	(
		@PK_ResourceType_i,
		@ResourceType_s

	)

END