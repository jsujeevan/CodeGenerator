using System;
using System.IO;
using System.Xml;


namespace MassQSol_CodeGenerator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string vl_project_s = "MShed_Web";

            if (!Directory.Exists(vl_project_s + "/SPs"))
            {
                Directory.CreateDirectory(vl_project_s + "/SPs");
            }

            if (!Directory.Exists(vl_project_s + "/Models"))
            {
                Directory.CreateDirectory(vl_project_s + "/Models");
            }

            if (!Directory.Exists(vl_project_s + "/BOs"))
            {
                Directory.CreateDirectory(vl_project_s + "/BOs");
            }

            XmlDocument vl_dataDefinition_o = new XmlDocument();
            vl_dataDefinition_o.Load(@"Data.xml");

            // Create Sps
            XmlNodeList vl_TableNodes_o = vl_dataDefinition_o.SelectNodes("//db/tables/table");
            foreach (XmlNode vl_TableNode_o in vl_TableNodes_o)
            {
                // Get values from XML node
                string vl_TableName_s = vl_TableNode_o.Attributes["name"].Value;
                string vl_EntityPath_s = vl_TableNode_o.Attributes["entity_path"].Value;

                Console.WriteLine(@"Creating SPs for ... " + vl_TableName_s);
                string vl_select_s = createSelectSPFromNode(vl_dataDefinition_o, vl_TableNode_o);
                System.IO.File.WriteAllText(vl_project_s + "/SPs/" + vl_TableName_s + "_SELECT.sql", vl_select_s);


                string vl_selectcol_s = createSelectSPCollectionFromNode(vl_dataDefinition_o, vl_TableNode_o);
                System.IO.File.WriteAllText(vl_project_s + "/SPs/" + vl_TableName_s + "_SELECT_COLLECTION.sql", vl_selectcol_s);


                string vl_insert_s = createInsertSPFromNode(vl_dataDefinition_o, vl_TableNode_o);
                System.IO.File.WriteAllText(vl_project_s + "/SPs/" + vl_TableName_s + "_INSERT.sql", vl_insert_s);


                string vl_update_s = createUpdateSPFromNode(vl_dataDefinition_o, vl_TableNode_o);
                System.IO.File.WriteAllText(vl_project_s + "/SPs/" + vl_TableName_s + "_UPDATE.sql", vl_update_s);


                string vl_delete_s = createDeleteSPFromNode(vl_dataDefinition_o, vl_TableNode_o);
                System.IO.File.WriteAllText(vl_project_s + "/SPs/" + vl_TableName_s + "_DELETE.sql", vl_delete_s);

                Console.WriteLine(@"Creating Model for ... " + vl_TableName_s);
                string vl_ModelOutput_s = createModelFromNode(vl_dataDefinition_o, vl_TableNode_o, vl_project_s);

                string vl_ModelFilePath_s = vl_EntityPath_s.Replace(".","/");
                if (!Directory.Exists(vl_project_s + "/Models/" + vl_ModelFilePath_s))
                {
                    Directory.CreateDirectory(vl_project_s + "/Models/" + vl_ModelFilePath_s);
                }

                System.IO.File.WriteAllText(vl_project_s + "/Models/" + vl_ModelFilePath_s + "/" + vl_TableName_s + "_Model.cs", vl_ModelOutput_s);
            }

            //Create BOs
            XmlNodeList vl_EntityGroupNodes_o = vl_dataDefinition_o.SelectNodes("//db/entities/entity_group");
            foreach (XmlNode vl_EntityGroup_o in vl_EntityGroupNodes_o)
            {
                string vl_EntityGroupName_o = vl_EntityGroup_o.Attributes["name"].Value;
                Console.WriteLine(@"Creating BO for ... " + vl_EntityGroupName_o);
                string vl_BOOutput_s = createBOFromNode(vl_dataDefinition_o, vl_EntityGroup_o, vl_project_s);        
                System.IO.File.WriteAllText(vl_project_s + "/BOs/" + vl_EntityGroupName_o + "BO.cs", vl_BOOutput_s);
            }

            Console.ReadLine();

            /*
            string vl_project_s = "LondonDegree";
            //string vl_folder_s = "@models.xml";

            // **************************************************************************
            // Create file structure for BO and Models
            // **************************************************************************
            if (!Directory.Exists(vl_project_s + "/BusinessObjects"))
            {
                Directory.CreateDirectory(vl_project_s + "/BusinessObjects");
            }

            if (!Directory.Exists(vl_project_s + "/Models"))
            {
                Directory.CreateDirectory(vl_project_s + "/Models");
            }

            // **************************************************************************
            //Load the XML definition file
            // **************************************************************************
            XmlDocument vl_Definition_x = new XmlDocument();
            vl_Definition_x.Load(@"models.xml");

            // **************************************************************************
            // Create the Models
            // **************************************************************************

            // Loop through all the models
            XmlNodeList vl_ModelNodes_n = vl_Definition_x.SelectNodes("//LondonDegree/Models/model");
            foreach (XmlNode vl_SingleModel_n in vl_ModelNodes_n)
            {
                // Get values from XML node
                string vl_ModelName_s = vl_SingleModel_n.Attributes["name"].Value;
                string vl_ModelNamespace_s = vl_SingleModel_n.Attributes["namespace"].Value;

                // Generate Model text
                Console.WriteLine(@"Creating Model for ... " + vl_ModelName_s);
                string vl_ModelOutput_s = createModelFromNode(vl_Definition_x, vl_SingleModel_n);

                // Convert namespace to file path
                string vl_prefix_s = vl_ModelNamespace_s.Split(".".ToCharArray())[0];
                string vl_postfix = vl_ModelNamespace_s.Split(".".ToCharArray())[1];

                string vl_ModelFilePath_s = vl_prefix_s + "/" + vl_postfix;

                // Output result File
                if (!Directory.Exists(vl_project_s + "/Models/" + vl_ModelFilePath_s))
                {
                    Directory.CreateDirectory(vl_project_s + "/Models/" + vl_ModelFilePath_s);
                }

                System.IO.File.WriteAllText(vl_project_s + "/Models/" + vl_ModelFilePath_s + "/" + vl_ModelName_s + "Model.cs", vl_ModelOutput_s);


            }

            // **************************************************************************
            // Create the BO
            // **************************************************************************
            // Loop through all the BO
            XmlNodeList vl_BONodes_n = vl_Definition_x.SelectNodes("//LondonDegree/businessobjects/bo");
            foreach (XmlNode vl_SingleBO_n in vl_BONodes_n)
            {
                // Get values from XML node
                string vl_BOName_s = vl_SingleBO_n.Attributes["name"].Value;

                // Generate Model text
                Console.WriteLine(@"Creating BO for ... " + vl_BOName_s);
                string vl_BOOutput_s = createBOFromNode(vl_Definition_x, vl_SingleBO_n);

                // Output result File           
                System.IO.File.WriteAllText(vl_project_s + "/BusinessObjects/" + vl_BOName_s + "BO.cs", vl_BOOutput_s);


            }
            */

        }


        /*
        private static string createBOFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleBO_n)
        {

            string vl_BOName_s = cp_SingleBO_n.Attributes["name"].Value;

            string vl_Properties_s = "";
            string vl_PrivateMethods_s = "";
            string vl_Header_s = "";

            templates.BO vl_Template_o = new templates.BO();
            vl_Properties_s = vl_Template_o.Header;


            // Loop through all models associated with this BO
            XmlNodeList vl_BOSchema_n = cp_SingleBO_n.SelectNodes("schema");
            foreach (XmlNode vl_SingleSchema_n in vl_BOSchema_n)
            {
                string vl_SchemaName_s = vl_SingleSchema_n.InnerText;
                vl_Header_s += "using LondonDegree_Web.Models.DataModel." + vl_SchemaName_s + ";\n";

                XmlNodeList vl_SchemaModels_n = cp_Definition_x.SelectNodes("//LondonDegree/Models/model[@namespace='DataModel." + vl_SchemaName_s + "']");
                foreach (XmlNode vl_SingleModel_n in vl_SchemaModels_n)
                {


                    string vl_SingleSection_s = "";
                    string vl_SinglePrivateSection_s = "";

                    vl_SingleSection_s += "\t\t// ***********************************************************************\n";
                    vl_SingleSection_s += "\t\t// " + vl_SingleModel_n.Attributes["name"].Value + "\n";
                    vl_SingleSection_s += "\t\t// ***********************************************************************\n\n";

                    // Output Select Single
                    vl_SingleSection_s += vl_Template_o.SelectSingle;
                    vl_SingleSection_s += "\n\n";

                    // Output Select Single
                    vl_SingleSection_s += vl_Template_o.SelectMulti;
                    vl_SingleSection_s += "\n\n";

                    // Output Select Filter
                    vl_SingleSection_s += vl_Template_o.SelectList;
                    vl_SingleSection_s += "\n\n";

                    // Output Insert
                    vl_SingleSection_s += vl_Template_o.Create;
                    vl_SingleSection_s += "\n\n";

                    // Output Update                    
                    vl_SingleSection_s += vl_Template_o.Update;
                    vl_SingleSection_s += "\n\n";

                    // Output Delete                    
                    vl_SingleSection_s += vl_Template_o.Delete;
                    vl_SingleSection_s += "\n\n";

                    // Get the primary Key field
                    XmlNode vl_PKfield_n = cp_Definition_x.SelectSingleNode("//LondonDegree/Fields/field[model='" + vl_SingleModel_n.Attributes["name"].Value + "' and pk='true']");
                    string vl_PKFIeldName_s = vl_PKfield_n.Attributes["name"].Value;

                    string vl_PKType_s = vl_PKfield_n.SelectSingleNode("type").InnerText;

                    string vl_PKAppType_s = "";
                    string vl_PKsuffix_s = "";
                    switch (vl_PKType_s)
                    {
                        case "uniqueidentifier":
                            vl_PKAppType_s = "Guid";
                            vl_PKsuffix_s = "g";
                            break;

                        case "int":
                            vl_PKAppType_s = "int";
                            vl_PKsuffix_s = "i";
                            break;

                        case "bit":
                            vl_PKAppType_s = "bool";
                            vl_PKsuffix_s = "z";
                            break;

                        case "datetime":
                            vl_PKAppType_s = "DateTime";
                            vl_PKsuffix_s = "d";
                            break;

                        default:
                            vl_PKAppType_s = "string";
                            vl_PKsuffix_s = "s";
                            break;
                    }


                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELPK$$", vl_PKFIeldName_s);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELITEM$$", vl_SingleModel_n.Attributes["name"].Value);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELPKTYPE$$", vl_PKAppType_s);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELPKSUFFIX$$", vl_PKsuffix_s);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELITEMFIELDTYPE$$", vl_PKAppType_s);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELUPDATESQL$$", convertNametoSQLTable(vl_SingleModel_n.Attributes["name"].Value) + "__UP");
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELINSERTSQL$$", convertNametoSQLTable(vl_SingleModel_n.Attributes["name"].Value) + "__IN");
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELDELETESQL$$", convertNametoSQLTable(vl_SingleModel_n.Attributes["name"].Value) + "__DEL");
                    vl_SingleSection_s = vl_SingleSection_s.Replace("$$MODELSELECTSQL$$", convertNametoSQLTable(vl_SingleModel_n.Attributes["name"].Value) + "__SEL");



                    vl_Properties_s += vl_SingleSection_s;

                    // Private Methods
                    vl_SinglePrivateSection_s += vl_Template_o.ValidateModel;
                    vl_SinglePrivateSection_s += "\n\n";
                    vl_SinglePrivateSection_s += vl_Template_o.CheckPermission;
                    vl_SinglePrivateSection_s += "\n\n";

                    vl_SinglePrivateSection_s = vl_SinglePrivateSection_s.Replace("$$MODELITEM$$", vl_SingleModel_n.Attributes["name"].Value);
                    vl_PrivateMethods_s += vl_SinglePrivateSection_s;
                }
            }

            vl_Properties_s += "\t\t// ***********************************************************************\n";
            vl_Properties_s += "\t\t// PRIVATE METHODS\n";
            vl_Properties_s += "\t\t// ***********************************************************************\n\n";
            vl_Properties_s += vl_PrivateMethods_s;

            vl_Properties_s += vl_Template_o.Footer;

            vl_Properties_s = vl_Properties_s.Replace("$$NAMESPACE$$", "LondonDegree_Web.BusinessObjects");
            vl_Properties_s = vl_Properties_s.Replace("$$BONAME$$", vl_BOName_s + "BO");
            vl_Properties_s = vl_Properties_s.Replace("$$USING$$", vl_Header_s);


            return vl_Properties_s;
        }

        private static string createModelFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleModel_n)
        {
            string vl_Properties_s = "";
            templates.Model vl_Template_o = new templates.Model();
            vl_Properties_s = vl_Template_o.Header;

            // Convert namespace to file path
            string vl_ModelName_s = cp_SingleModel_n.Attributes["name"].Value;
            string vl_ModelNamespace_s = cp_SingleModel_n.Attributes["namespace"].Value;
            string vl_prefix_s = vl_ModelNamespace_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_ModelNamespace_s.Split(".".ToCharArray())[1];

            // Build the Properties by looping through each field            
            XmlNodeList vl_ModelFields_n = cp_Definition_x.SelectNodes("//LondonDegree/Fields/field[model='" + cp_SingleModel_n.Attributes["name"].Value + "']");
            foreach (XmlNode vl_SingleField_n in vl_ModelFields_n)
            {
                string vl_FieldName_s = vl_SingleField_n.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleField_n.SelectSingleNode("type").InnerText;


                string vl_TempProperty = "";
                bool vl_PrimaryKey_z;
                Boolean.TryParse(vl_SingleField_n.SelectSingleNode("pk").InnerText, out vl_PrimaryKey_z);

                if (vl_PrimaryKey_z)
                {
                    vl_TempProperty = "\t\t[DataBinder(DataBinderName=\"" + vl_FieldName_s + "\", PrimaryKey = true)]\n";
                }
                else
                {
                    vl_TempProperty = "\t\t[DataBinder(DataBinderName=\"" + vl_FieldName_s + "\")]\n";
                }


                vl_TempProperty += "\t\tpublic ";

                switch (vl_FieldType_s)
                {
                    case "uniqueidentifier":
                        vl_TempProperty += "Guid";
                        break;

                    case "int":
                        vl_TempProperty += "int";
                        break;

                    case "bit":
                        vl_TempProperty += "bool";
                        break;

                    case "datetime":
                        vl_TempProperty += "DateTime";
                        break;
                    case "float":
                        vl_TempProperty += "double";
                        break;

                    default:
                        vl_TempProperty += "string";
                        break;
                }

                vl_TempProperty += " " + vl_FieldName_s + " ";
                vl_TempProperty += "{get; set;}";
                vl_Properties_s += vl_TempProperty + "\n\n";
            }

            vl_Properties_s += vl_Template_o.Footer;

            vl_Properties_s = vl_Properties_s.Replace("$$NAMESPACE$$", "LondonDegree_Web.Models." + vl_prefix_s + "." + vl_postfix);
            vl_Properties_s = vl_Properties_s.Replace("$$MODELNAME$$", vl_ModelName_s + "Model");

            return vl_Properties_s;
        }

        private static string convertNametoSQLTable(string cp_Name_s)
        {
            string vl_Converted_s = "";

            vl_Converted_s = cp_Name_s.Substring(0, 1);

            for (int i = 1; i < cp_Name_s.Length; i++)
            {
                char vl_Current_c = cp_Name_s.Substring(i, 1).ToCharArray()[0];

                if (Char.IsUpper(vl_Current_c))
                {
                    vl_Converted_s += "_" + cp_Name_s.Substring(i, 1);
                }
                else
                {
                    vl_Converted_s += cp_Name_s.Substring(i, 1);
                }
            }


            return vl_Converted_s;
        }

    */

        private static string createSelectSPFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleModel_n)
        {
            string vl_parameters_s = "";
            string vl_select_s = "";
            string vl_where_s = "";
            string vl_spTemplate_s = "";
            templates.SP vl_Template_o = new templates.SP();
            vl_spTemplate_s = vl_Template_o.SelectSp;

            // Convert namespace to file path
            string vl_TableName_s = cp_SingleModel_n.Attributes["name"].Value;
            string vl_TableEntitly_s = cp_SingleModel_n.Attributes["entity_path"].Value;
            string vl_prefix_s = vl_TableEntitly_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_TableEntitly_s.Split(".".ToCharArray())[1];

            // Build the Properties by looping through each field            
            XmlNodeList vl_SPColumns_o = cp_Definition_x.SelectNodes("//db/columns/column[table='" + cp_SingleModel_n.Attributes["name"].Value + "']");
            int vl_columnCounter_i = 1;
            foreach (XmlNode vl_SingleColumn_o in vl_SPColumns_o)
            {
                string vl_FieldName_s = vl_SingleColumn_o.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleColumn_o.SelectSingleNode("type").InnerText;
                string vl_maxLen_s = vl_SingleColumn_o.SelectSingleNode("maxLen").InnerText;
                if (vl_FieldType_s.Equals("nvarchar", StringComparison.InvariantCultureIgnoreCase) | vl_FieldType_s.Equals("nchar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(vl_maxLen_s))
                    {
                        if (vl_maxLen_s.Equals("-1"))
                        {
                            vl_maxLen_s = "MAX";
                        }
                        vl_FieldType_s = vl_FieldType_s + "(" + vl_maxLen_s + ")";
                    }
                }
                vl_parameters_s += "@" + vl_FieldName_s + "\t\t\t" + vl_FieldType_s.ToUpper() + " = NULL,\n";
                if (vl_columnCounter_i < vl_SPColumns_o.Count)
                {
                    //vl_parameters_s += "@" + vl_FieldName_s + "\t\t\t" + vl_FieldType_s.ToUpper() + " = NULL,\n";
                    vl_select_s += "\t" + vl_FieldName_s + ",\n";
                    if (vl_FieldType_s.Equals("nvarchar", StringComparison.InvariantCultureIgnoreCase) | vl_FieldType_s.Equals("nchar", StringComparison.InvariantCultureIgnoreCase))
                    {
                        vl_where_s += "\t(@" + vl_FieldName_s + "\t\t\tIS NULL\t\t\tOR \t\t\t(" + vl_TableName_s + "." + vl_FieldName_s + " LIKE @" + vl_FieldName_s + " + '%'))\n\tAND\n";
                    }
                    else
                    {
                        vl_where_s += "\t(@" + vl_FieldName_s + "\t\t\tIS NULL\t\t\tOR\t\t\t(" + vl_TableName_s + "." + vl_FieldName_s + "=@" + vl_FieldName_s + "))\n\tAND\n";
                    }
                }
                else
                {
                    //vl_parameters_s += "@" + vl_FieldName_s + "\t\t\t" + vl_FieldType_s.ToUpper() + " = NULL,\n";
                    vl_select_s += "\t" + vl_FieldName_s + "\n";
                    if (vl_FieldType_s.Equals("nvarchar", StringComparison.InvariantCultureIgnoreCase) | vl_FieldType_s.Equals("nchar", StringComparison.InvariantCultureIgnoreCase))
                    {
                        vl_where_s += "\t(@" + vl_FieldName_s + "\t\t\tIS NULL\t\t\tOR \t\t\t(" + vl_TableName_s + "." + vl_FieldName_s + " LIKE @" + vl_FieldName_s + " + '%'))\n";
                    }
                    else
                    {
                        vl_where_s += "\t(@" + vl_FieldName_s + "\t\t\tIS NULL\t\t\tOR\t\t\t(" + vl_TableName_s + "." + vl_FieldName_s + "=@" + vl_FieldName_s + "))\n\n";
                    }
                }
                vl_columnCounter_i = vl_columnCounter_i + 1;
            }
            vl_parameters_s += "@FK_Session_Person_ID_s\t\t\tUNIQUEIDENTIFIER = NULL\n";
            vl_spTemplate_s = vl_spTemplate_s.Replace("#TABLENAME#", vl_TableName_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#PARAMETERS#", vl_parameters_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#SELECT#", vl_select_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#WHERE#", vl_where_s);
            return vl_spTemplate_s;
        }

        private static string createSelectSPCollectionFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleModel_n)
        {
            string vl_parameters_s = "";
            string vl_select_s = "";
            string vl_primary_s = "";
            string vl_spTemplate_s = "";
            templates.SP vl_Template_o = new templates.SP();
            vl_spTemplate_s = vl_Template_o.SelectSpCollection;

            // Convert namespace to file path
            string vl_TableName_s = cp_SingleModel_n.Attributes["name"].Value;
            string vl_TableEntitly_s = cp_SingleModel_n.Attributes["entity_path"].Value;
            string vl_prefix_s = vl_TableEntitly_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_TableEntitly_s.Split(".".ToCharArray())[1];

            // Build the Properties by looping through each field            
            XmlNodeList vl_SPColumns_o = cp_Definition_x.SelectNodes("//db/columns/column[table='" + cp_SingleModel_n.Attributes["name"].Value + "']");
            int vl_columnCounter_i = 1;
            foreach (XmlNode vl_SingleColumn_o in vl_SPColumns_o)
            {
                string vl_FieldName_s = vl_SingleColumn_o.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleColumn_o.SelectSingleNode("type").InnerText;

                if (vl_columnCounter_i < vl_SPColumns_o.Count)
                {
                    vl_select_s += "\t" + vl_FieldName_s + ",\n";
                }
                else
                {
                    vl_select_s += "\t" + vl_FieldName_s + "\n";
                }
                bool vl_PrimaryKey_z;
                Boolean.TryParse(vl_SingleColumn_o.SelectSingleNode("pk").InnerText, out vl_PrimaryKey_z);
                if (vl_PrimaryKey_z)
                {
                    vl_primary_s = vl_FieldName_s;
                    if (vl_FieldType_s.Equals("uniqueidentifier", StringComparison.InvariantCultureIgnoreCase))
                    {
                        vl_parameters_s = "\t@_PK_\t\t\tUNIQUEIDENTIFIER_COLLECTION\t\t\tREADONLY,\n";
                    }else
                    {
                        vl_parameters_s = "\t@_PK_\t\t\tINT_COLLECTION\t\t\tREADONLY,\n";
                    }

                }

                vl_columnCounter_i = vl_columnCounter_i + 1;
            }
            vl_parameters_s += "\t@FK_Session_Person_ID_s\t\t\tUNIQUEIDENTIFIER = NULL\n";
            vl_spTemplate_s = vl_spTemplate_s.Replace("#TABLENAME#", vl_TableName_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#PARAMETERS#", vl_parameters_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#SELECT#", vl_select_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#PK#", vl_primary_s);
            return vl_spTemplate_s;
        }

        private static string createInsertSPFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleModel_n)
        {
            string vl_parameters_s = "";
            string vl_columns_s = "";
            string vl_values_s = "";
            string vl_spTemplate_s = "";
            templates.SP vl_Template_o = new templates.SP();
            vl_spTemplate_s = vl_Template_o.InsertSp;

            // Convert namespace to file path
            string vl_TableName_s = cp_SingleModel_n.Attributes["name"].Value;
            string vl_TableEntitly_s = cp_SingleModel_n.Attributes["entity_path"].Value;
            string vl_prefix_s = vl_TableEntitly_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_TableEntitly_s.Split(".".ToCharArray())[1];

            // Build the Properties by looping through each field            
            XmlNodeList vl_SPColumns_o = cp_Definition_x.SelectNodes("//db/columns/column[table='" + cp_SingleModel_n.Attributes["name"].Value + "']");
            int vl_columnCounter_i = 1;
            foreach (XmlNode vl_SingleColumn_o in vl_SPColumns_o)
            {
                string vl_FieldName_s = vl_SingleColumn_o.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleColumn_o.SelectSingleNode("type").InnerText;
                string vl_maxLen_s = vl_SingleColumn_o.SelectSingleNode("maxLen").InnerText;
                if (vl_FieldType_s.Equals("nvarchar", StringComparison.InvariantCultureIgnoreCase) | vl_FieldType_s.Equals("nchar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(vl_maxLen_s))
                    {
                        if (vl_maxLen_s.Equals("-1"))
                        {
                            vl_maxLen_s = "MAX";
                        }
                        vl_FieldType_s = vl_FieldType_s + "(" + vl_maxLen_s + ")";
                    }
                }
                vl_parameters_s += "@" + vl_FieldName_s + "\t\t\t" + vl_FieldType_s.ToUpper() + ",\n";
                if (vl_columnCounter_i < vl_SPColumns_o.Count)
                {                   
                    vl_columns_s += "\t\t" + vl_FieldName_s + ",\n";
                    vl_values_s += "\t\t@" + vl_FieldName_s + ",\n";
                }
                else
                {
                    vl_columns_s += "\t\t" + vl_FieldName_s + "\n";
                    vl_values_s += "\t\t@" + vl_FieldName_s + "\n";
                }
                vl_columnCounter_i = vl_columnCounter_i + 1;
            }
            vl_parameters_s += "@FK_Session_Person_ID_s\t\t\tUNIQUEIDENTIFIER = NULL\n";
            vl_spTemplate_s = vl_spTemplate_s.Replace("#TABLENAME#", vl_TableName_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#PARAMETERS#", vl_parameters_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#COLUMNS#", vl_columns_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#VALUES#", vl_values_s);

            return vl_spTemplate_s;
        }

        private static string createUpdateSPFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleModel_n)
        {
            string vl_parameters_s = "";
            string vl_set_s = "";
            string vl_where_s = "";
            string vl_spTemplate_s = "";
            templates.SP vl_Template_o = new templates.SP();
            vl_spTemplate_s = vl_Template_o.UpdateSp;

            // Convert namespace to file path
            string vl_TableName_s = cp_SingleModel_n.Attributes["name"].Value;
            string vl_TableEntitly_s = cp_SingleModel_n.Attributes["entity_path"].Value;
            string vl_prefix_s = vl_TableEntitly_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_TableEntitly_s.Split(".".ToCharArray())[1];

            // Build the Properties by looping through each field            
            XmlNodeList vl_SPColumns_o = cp_Definition_x.SelectNodes("//db/columns/column[table='" + cp_SingleModel_n.Attributes["name"].Value + "']");
            int vl_columnCounter_i = 1;
            foreach (XmlNode vl_SingleColumn_o in vl_SPColumns_o)
            {
                string vl_FieldName_s = vl_SingleColumn_o.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleColumn_o.SelectSingleNode("type").InnerText;
                string vl_maxLen_s = vl_SingleColumn_o.SelectSingleNode("maxLen").InnerText;
                if (vl_FieldType_s.Equals("nvarchar", StringComparison.InvariantCultureIgnoreCase) | vl_FieldType_s.Equals("nchar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(vl_maxLen_s))
                    {
                        if (vl_maxLen_s.Equals("-1"))
                        {
                            vl_maxLen_s = "MAX";
                        }
                        vl_FieldType_s = vl_FieldType_s + "(" + vl_maxLen_s + ")";
                    }
                }
                vl_parameters_s += "@" + vl_FieldName_s + "\t\t\t" + vl_FieldType_s.ToUpper() + ",\n";
                if (vl_columnCounter_i < vl_SPColumns_o.Count)
                {                    
                    vl_set_s += "\t\t" + vl_FieldName_s + " = @" + vl_FieldName_s + ",\n";
                }
                else
                {
                    vl_set_s += "\t\t" + vl_FieldName_s + " = @" + vl_FieldName_s + "\n";
                }

                bool vl_PrimaryKey_z;
                Boolean.TryParse(vl_SingleColumn_o.SelectSingleNode("pk").InnerText, out vl_PrimaryKey_z);
                if (vl_PrimaryKey_z)
                {
                    vl_where_s = "\t\t" + vl_FieldName_s + " = @" + vl_FieldName_s + "\n";
                }
                vl_columnCounter_i = vl_columnCounter_i + 1;
            }
            vl_parameters_s += "@FK_Session_Person_ID_s\t\t\tUNIQUEIDENTIFIER = NULL\n";
            vl_spTemplate_s = vl_spTemplate_s.Replace("#TABLENAME#", vl_TableName_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#PARAMETERS#", vl_parameters_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#SET#", vl_set_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#WHERE#", vl_where_s);

            return vl_spTemplate_s;
        }

        private static string createDeleteSPFromNode(XmlDocument cp_Definition_x, XmlNode cp_SingleModel_n)
        {
            string vl_parameters_s = "";
            string vl_where_s = "";
            string vl_spTemplate_s = "";
            templates.SP vl_Template_o = new templates.SP();
            vl_spTemplate_s = vl_Template_o.DeleteSp;

            // Convert namespace to file path
            string vl_TableName_s = cp_SingleModel_n.Attributes["name"].Value;
            string vl_TableEntitly_s = cp_SingleModel_n.Attributes["entity_path"].Value;
            string vl_prefix_s = vl_TableEntitly_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_TableEntitly_s.Split(".".ToCharArray())[1];

            // Build the Properties by looping through each field            
            XmlNodeList vl_SPColumns_o = cp_Definition_x.SelectNodes("//db/columns/column[table='" + cp_SingleModel_n.Attributes["name"].Value + "']");
            int vl_columnCounter_i = 1;
            foreach (XmlNode vl_SingleColumn_o in vl_SPColumns_o)
            {
                string vl_FieldName_s = vl_SingleColumn_o.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleColumn_o.SelectSingleNode("type").InnerText;
                string vl_maxLen_s = vl_SingleColumn_o.SelectSingleNode("maxLen").InnerText;
                if (vl_FieldType_s.Equals("nvarchar", StringComparison.InvariantCultureIgnoreCase) | vl_FieldType_s.Equals("nchar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(vl_maxLen_s))
                    {
                        if (vl_maxLen_s.Equals("-1"))
                        {
                            vl_maxLen_s = "MAX";
                        }
                        vl_FieldType_s = vl_FieldType_s + "(" + vl_maxLen_s + ")";
                    }
                }
                bool vl_PrimaryKey_z;
                Boolean.TryParse(vl_SingleColumn_o.SelectSingleNode("pk").InnerText, out vl_PrimaryKey_z);
                if (vl_PrimaryKey_z)
                {
                    vl_parameters_s += "@" + vl_FieldName_s + "\t\t\t" + vl_FieldType_s.ToUpper() + ",\n";
                    vl_where_s = "\t\t" + vl_FieldName_s + " = @" + vl_FieldName_s + "\n";
                }
                vl_columnCounter_i = vl_columnCounter_i + 1;
            }
            vl_parameters_s += "@FK_Session_Person_ID_s\t\t\tUNIQUEIDENTIFIER = NULL\n";
            vl_spTemplate_s = vl_spTemplate_s.Replace("#TABLENAME#", vl_TableName_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#PARAMETERS#", vl_parameters_s);
            vl_spTemplate_s = vl_spTemplate_s.Replace("#WHERE#", vl_where_s);

            return vl_spTemplate_s;
        }

        private static string createModelFromNode(XmlDocument in_DataDefinition_o, XmlNode in_TableModel_o, string in_project_s)
        {
            string vl_modelTemplate_s = "";
            templates.Model vl_Template_o = new templates.Model();
            vl_modelTemplate_s = vl_Template_o.Header;

            string vl_ModelName_s = in_TableModel_o.Attributes["name"].Value;
            string vl_ModelNamespace_s = in_TableModel_o.Attributes["entity_path"].Value;
            string vl_prefix_s = vl_ModelNamespace_s.Split(".".ToCharArray())[0];
            string vl_postfix = vl_ModelNamespace_s.Split(".".ToCharArray())[1];
           
            XmlNodeList vl_ModelFields_n = in_DataDefinition_o.SelectNodes("//db/columns/column[table='" + in_TableModel_o.Attributes["name"].Value + "']");
            foreach (XmlNode vl_SingleField_n in vl_ModelFields_n)
            {
                string vl_FieldName_s = vl_SingleField_n.Attributes["name"].Value;
                string vl_FieldType_s = vl_SingleField_n.SelectSingleNode("type").InnerText;

                string vl_TempProperty = "";
                bool vl_PrimaryKey_z;
                Boolean.TryParse(vl_SingleField_n.SelectSingleNode("pk").InnerText, out vl_PrimaryKey_z);

                if (vl_PrimaryKey_z)
                {
                    vl_TempProperty = "\t\t[DataBinder(DataBinderName=\"" + vl_FieldName_s + "\", PrimaryKey = true)]\n";
                }
                else
                {
                    vl_TempProperty = "\t\t[DataBinder(DataBinderName=\"" + vl_FieldName_s + "\")]\n";
                }


                vl_TempProperty += "\t\tpublic ";

                switch (vl_FieldType_s)
                {
                    case "uniqueidentifier":
                        vl_TempProperty += "Guid";
                        break;

                    case "int":
                        vl_TempProperty += "int";
                        break;

                    case "bit":
                        vl_TempProperty += "bool";
                        break;

                    case "datetime":
                        vl_TempProperty += "DateTime";
                        break;
                    case "float":
                        vl_TempProperty += "double";
                        break;

                    default:
                        vl_TempProperty += "string";
                        break;
                }

                vl_TempProperty += " " + vl_FieldName_s + " ";
                vl_TempProperty += "{get; set;}";
                vl_modelTemplate_s += vl_TempProperty + "\n\n";
            }
            vl_modelTemplate_s += "\t\tpublic Guid FK_Session_Person_ID_s { get; set; }\n";

            vl_modelTemplate_s += vl_Template_o.Footer;
            vl_modelTemplate_s = vl_modelTemplate_s.Replace("#PROJECTNAME#", in_project_s);
            vl_modelTemplate_s = vl_modelTemplate_s.Replace("#MODELTYPE#", vl_prefix_s + "." + vl_postfix);
            vl_modelTemplate_s = vl_modelTemplate_s.Replace("#MODELNAME#", vl_ModelName_s + "_Model");

            return vl_modelTemplate_s;
        }

        private static string createBOFromNode(XmlDocument in_DataDefinition_o, XmlNode in_EntityGroup_o, string in_project_s)
        {
            string vl_BOName_s = in_EntityGroup_o.Attributes["name"].Value;
            string vl_Properties_s = "";

            templates.BO vl_Template_o = new templates.BO();
            vl_Properties_s = vl_Template_o.Header;

            XmlNodeList vl_entityList_o = in_EntityGroup_o.SelectNodes("entity");
            foreach (XmlNode vl_entity_o in vl_entityList_o)
            {
                string vl_EntityName_s = vl_entity_o.InnerText;
                XmlNodeList vl_TableModels_o = in_DataDefinition_o.SelectNodes("//db/tables/table[@name='" + vl_EntityName_s + "']");
                foreach (XmlNode vl_TableModel_o in vl_TableModels_o)
                {
                    string vl_SearchSection_s = "";
                    string vl_SingleSection_s = "";
                    string vl_MultiSection_s = "";
                    string vl_SingleInsert_s = "";
                    string vl_SingleUpdate_s = "";
                    string vl_SingleDelete_s = "";

                    string vl_PrimaryParameterList_s = "";
                    string vl_NonPrimaryParameterList_s = "";
                    string vl_AllParameterList_s = "";
                    string vl_DeleteParameterList_s = "";
                    string vl_CurrentUserWithModelValParameter_s = "";
                    string vl_CurrentUserParameter_s = "";

                    vl_SearchSection_s += "\t\t/* " + vl_TableModel_o.Attributes["name"].Value + "*/\n\n";
                    vl_SearchSection_s += vl_Template_o.SelectSearch;
                    vl_SearchSection_s += "\n\n";

                    vl_SingleSection_s += vl_Template_o.SelectSingle;
                    vl_SingleSection_s += "\n\n";

                    vl_MultiSection_s += vl_Template_o.SelectMulti;
                    vl_MultiSection_s += "\n\n";

                    vl_SingleInsert_s += vl_Template_o.InsertSingle;
                    vl_SingleInsert_s += "\n\n";

                    vl_SingleUpdate_s += vl_Template_o.UpdateSingle;
                    vl_SingleUpdate_s += "\n\n";

                    vl_SingleDelete_s += vl_Template_o.DeleteSingle;
                    vl_SingleDelete_s += "\n\n";

                    XmlNodeList vl_NonPrimaryTableColumns_o = in_DataDefinition_o.SelectNodes("//db/columns/column[table='" + vl_TableModel_o.Attributes["name"].Value + "' and pk='false']");
                    XmlNodeList vl_TableColumns_o = in_DataDefinition_o.SelectNodes("//db/columns/column[table='" + vl_TableModel_o.Attributes["name"].Value + "']");
                    string vl_primaryCsharpType_s = "";
                    string vl_primaryColumn_s = "";
                    string primaryTypeString_s = "";
                    string primaryParamTable_s = "";
                    foreach (XmlNode vl_TableColumn_o in vl_TableColumns_o)
                    {
                        string vl_columnName_s = vl_TableColumn_o.Attributes["name"].Value;
                        string vl_columnType_s = vl_TableColumn_o.SelectSingleNode("type").InnerText;
                        bool vl_PrimaryType_b = bool.Parse(vl_TableColumn_o.SelectSingleNode("pk").InnerText);

                        string vl_SQLType_s = "";
                        string vl_csharpType_s = "";
                        string typeString_s = "";
                        string paramTable_s = "";
                        switch (vl_columnType_s)
                        {
                            case "uniqueidentifier":
                                vl_SQLType_s = "UniqueIdentifier";
                                vl_csharpType_s = "Guid";
                                typeString_s = "System.Guid";
                                paramTable_s = "dbo.UNIQUEIDENTIFIER_COLLECTION";
                                break;
                            case "int":
                                vl_SQLType_s = "Int";
                                vl_csharpType_s = "int";
                                typeString_s = "System.Int32";
                                paramTable_s = "dbo.INT_COLLECTION";
                                break;
                            case "bit":
                                vl_SQLType_s = "Bit";
                                vl_csharpType_s = "bool";
                                typeString_s = "";
                                paramTable_s = "";
                                break;
                            case "datetime":
                                vl_SQLType_s = "DateTime";
                                vl_csharpType_s = "datetime";
                                typeString_s = "";
                                paramTable_s = "";
                                break;
                            default:
                                vl_SQLType_s = "VarChar";
                                vl_csharpType_s = "string";
                                typeString_s = "System.String";
                                paramTable_s = "dbo.VARCHAR_COLLECTION";
                                break;
                        }

                        if (vl_PrimaryType_b)
                        {
                            vl_primaryCsharpType_s = vl_csharpType_s;
                            vl_primaryColumn_s = vl_columnName_s;
                            primaryTypeString_s = typeString_s;
                            primaryParamTable_s = paramTable_s;
                            vl_PrimaryParameterList_s = "\t\t\t\tnew SQLParameterModel { Parameter_Name = \"" + vl_columnName_s + "\", Parameter_Value = in_" + vl_columnName_s + " , SqlDbType = SqlDbType." + vl_SQLType_s + " }";
                            vl_DeleteParameterList_s = "\t\t\t\tnew SQLParameterModel { Parameter_Name = \"@" + vl_columnName_s + "\", Parameter_Value = in_" + vl_TableModel_o.Attributes["name"].Value + "_Model_o." + vl_columnName_s + " , SqlDbType = SqlDbType." + vl_SQLType_s + " },\n";
                        }

                        if (!vl_PrimaryType_b)
                        {
                             vl_NonPrimaryParameterList_s += "\t\t\t\tnew SQLParameterModel { Parameter_Name = \"@" + vl_columnName_s + "\", Parameter_Value = in_" + vl_TableModel_o.Attributes["name"].Value + "_Model_o." + vl_columnName_s + " , SqlDbType = SqlDbType." + vl_SQLType_s + " },\n";
                        }

                        vl_AllParameterList_s += "\t\t\t\tnew SQLParameterModel { Parameter_Name = \"@" + vl_columnName_s + "\", SqlDbType = SqlDbType." + vl_SQLType_s + " },\n";
                    }

                    vl_CurrentUserWithModelValParameter_s = "\t\t\t\tnew SQLParameterModel { Parameter_Name = \"@FK_Session_Person_ID_s\",Parameter_Value = in_" + vl_TableModel_o.Attributes["name"].Value + "_Model_o.FK_Session_Person_ID_s, SqlDbType = SqlDbType.UniqueIdentifier }";
                    vl_CurrentUserParameter_s = "\t\t\t\tnew SQLParameterModel { Parameter_Name = \"@FK_Session_Person_ID_s\", SqlDbType = SqlDbType.UniqueIdentifier }";
                    vl_AllParameterList_s += vl_CurrentUserParameter_s;
                    vl_NonPrimaryParameterList_s += vl_CurrentUserWithModelValParameter_s;
                    vl_DeleteParameterList_s = vl_DeleteParameterList_s  + vl_CurrentUserWithModelValParameter_s;

                    //SINGLE_SQL_PARAMETERS
                    vl_SearchSection_s = vl_SearchSection_s.Replace("#SEARCH_SQL_PARAMETERS#", vl_NonPrimaryParameterList_s);
                    
                    vl_SingleSection_s = vl_SingleSection_s.Replace("#PRIMARY_KEY_CSHARP_TYPE#", vl_primaryCsharpType_s);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("#PRIMARY_KEY#", vl_primaryColumn_s);
                    vl_SingleSection_s = vl_SingleSection_s.Replace("#PRIMARY_SQL_PARAMETERS#", vl_PrimaryParameterList_s);

                    vl_MultiSection_s = vl_MultiSection_s.Replace("#PRIMARY_KEY_CSHARP_TYPE#", vl_primaryCsharpType_s);
                    vl_MultiSection_s = vl_MultiSection_s.Replace("#GetTypeString#", primaryTypeString_s);
                    vl_MultiSection_s = vl_MultiSection_s.Replace("#PARAM_TABLE#", primaryParamTable_s);

                    vl_SingleInsert_s = vl_SingleInsert_s.Replace("#ALL_SQL_PARAMETERS#", vl_AllParameterList_s);
                    vl_SingleUpdate_s = vl_SingleUpdate_s.Replace("#ALL_SQL_PARAMETERS#", vl_AllParameterList_s);

                    vl_SingleDelete_s = vl_SingleDelete_s.Replace("#DELETE_SQL_PARAMETERS#", vl_DeleteParameterList_s);

                    vl_Properties_s += vl_SearchSection_s;
                    vl_Properties_s += vl_SingleSection_s;
                    vl_Properties_s += vl_MultiSection_s;
                    vl_Properties_s += vl_SingleInsert_s;
                    vl_Properties_s += vl_SingleUpdate_s;
                    vl_Properties_s += vl_SingleDelete_s;

                    vl_Properties_s = vl_Properties_s.Replace("#TABLENAME#", vl_TableModel_o.Attributes["name"].Value);
                }


                vl_Properties_s = vl_Properties_s.Replace("#ENTITY#", vl_BOName_s);
            }

            vl_Properties_s += vl_Template_o.Footer;
            vl_Properties_s = vl_Properties_s.Replace("#PROJECTNAME#", in_project_s);            
            vl_Properties_s = vl_Properties_s.Replace("#BONAME#", vl_BOName_s);
            return vl_Properties_s;
        }

    }

}