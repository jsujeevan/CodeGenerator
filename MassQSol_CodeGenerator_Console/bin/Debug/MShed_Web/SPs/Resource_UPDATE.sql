CREATE PROCEDURE dbo.Resource_UPDATE
@Content_s			NVARCHAR(MAX),
@Created_d			DATETIME,
@Created_Person_ID_s			UNIQUEIDENTIFIER,
@FK_ContentType_i			INT,
@FK_Document_ID_s			UNIQUEIDENTIFIER,
@FK_ResourceType_i			INT,
@Modified_d			DATETIME,
@Modified_Person_ID_s			UNIQUEIDENTIFIER,
@Name_s			NVARCHAR(255),
@PK_Resource_ID_s			UNIQUEIDENTIFIER,
@Resource_Archive_b			BIT,
@FK_Session_Person_ID_s			UNIQUEIDENTIFIER = NULL

AS

BEGIN

UPDATE dbo.Resource
	SET
		Content_s = @Content_s,
		Created_d = @Created_d,
		Created_Person_ID_s = @Created_Person_ID_s,
		FK_ContentType_i = @FK_ContentType_i,
		FK_Document_ID_s = @FK_Document_ID_s,
		FK_ResourceType_i = @FK_ResourceType_i,
		Modified_d = @Modified_d,
		Modified_Person_ID_s = @Modified_Person_ID_s,
		Name_s = @Name_s,
		PK_Resource_ID_s = @PK_Resource_ID_s,
		Resource_Archive_b = @Resource_Archive_b
	WHERE
		PK_Resource_ID_s = @PK_Resource_ID_s


END