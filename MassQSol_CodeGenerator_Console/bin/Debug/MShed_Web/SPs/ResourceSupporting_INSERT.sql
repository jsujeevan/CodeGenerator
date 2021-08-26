CREATE PROCEDURE dbo.ResourceSupporting_INSERT
@Content_s			NVARCHAR(MAX),
@Created_d			DATETIME,
@Created_Person_ID_s			UNIQUEIDENTIFIER,
@FK_ContentType_i			INT,
@FK_Document_ID_s			UNIQUEIDENTIFIER,
@FK_Resource_ID_s			UNIQUEIDENTIFIER,
@FK_ResourceSupportingType_i			INT,
@Modified_d			DATETIME,
@Modified_Person_ID_s			UNIQUEIDENTIFIER,
@Name_s			NVARCHAR(255),
@PK_ResourceSupporting_ID_s			UNIQUEIDENTIFIER,
@ResourceSupporting_Archive_b			BIT,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

INSERT INTO dbo.ResourceSupporting
	(
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
	)
VALUES
	(
		@Content_s,
		@Created_d,
		@Created_Person_ID_s,
		@FK_ContentType_i,
		@FK_Document_ID_s,
		@FK_Resource_ID_s,
		@FK_ResourceSupportingType_i,
		@Modified_d,
		@Modified_Person_ID_s,
		@Name_s,
		@PK_ResourceSupporting_ID_s,
		@ResourceSupporting_Archive_b

	)

END