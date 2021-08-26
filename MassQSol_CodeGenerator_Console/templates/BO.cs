using System;

namespace MassQSol_CodeGenerator_Console.templates
{
    class BO
    {
        public string Header = "using System;\n" +
                                "using System.Collections.Generic;\n" +
                                "using System.Linq;\n" +
                                "using System.Data;\n" +
                                "using System.Data.SqlClient;\n" +
                                "using #PROJECTNAME#.Models;\n" +
                                "using #PROJECTNAME#.Models.DataModel.#ENTITY#;\n" +
                                "\n" +
                                "namespace #PROJECTNAME#.BOs\n" +
                                "{\n" +
                                "\tpublic class #BONAME#BO\n" +
                                "\t{\n";

        public string SelectSearch = "\t\tpublic List<#TABLENAME#_Model> Search#TABLENAME#(Dictionary<string, object> parameterList_k)\n" +
                                    "\t\t{\n" +
                                    "\t\t\tList<#TABLENAME#_Model> vl_#TABLENAME#List_o = null;\n" +
                                    "\t\t\tDataBinder_BO vl_dataBinder_o = new DataBinder_BO();\n" +
                                    "\t\t\tSQLCommandModel vl_sqlcmd_o = new SQLCommandModel();\n" +

                                    "\t\t\tList<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();\n" +
                                    "\t\t\tforeach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())\n" +
                                    "\t\t\t{\n" +
                                    "\t\t\t\tSQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };\n" +
                                    "\t\t\t\tvl_paramList.Add(tempParam_o);\n" +
                                    "\t\t\t}\n" +

                                    "\t\t\tvl_sqlcmd_o.SQL_Name = \"#TABLENAME#_SELECT\";\n" +
                                    "\t\t\tvl_sqlcmd_o.SQL_ParameterList = vl_paramList;\n" +
                                    "\t\t\tvl_#TABLENAME#List_o = vl_dataBinder_o.GetGenericModel(typeof(#TABLENAME#_Model), vl_sqlcmd_o).Cast<#TABLENAME#_Model>().ToList();\n" +
                                    "\t\t\treturn vl_#TABLENAME#List_o;\n" +
                                    "\t\t}\n";

        public string SelectSingle = "\t\tpublic #TABLENAME#_Model Get#TABLENAME#(#PRIMARY_KEY_CSHARP_TYPE# in_#PRIMARY_KEY#)\n" +
                                    "\t\t{\n" +
                                    "\t\t\t#TABLENAME#_Model vl_#TABLENAME#_Model_o = new #TABLENAME#_Model();\n" +
                                    "\t\t\tList<#TABLENAME#_Model> vl_#TABLENAME#_List_o = null;\n" +
                                    "\t\t\tDataBinder_BO vl_dataBinder_o = new DataBinder_BO();\n" +
                                    "\t\t\tSQLCommandModel vl_sqlcmd_o = new SQLCommandModel();\n" +
                                    "\t\t\tList<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()\n" +
                                    "\t\t\t{\n" +
                                    "#PRIMARY_SQL_PARAMETERS#\n" +
                                    "\t\t\t};\n" +
                                    "\t\t\tvl_sqlcmd_o.SQL_Name = \"#TABLENAME#_SELECT\";\n" +
                                    "\t\t\tvl_sqlcmd_o.SQL_ParameterList = vl_paramList;\n" +
                                    "\t\t\tvl_#TABLENAME#_List_o = vl_dataBinder_o.GetGenericModel(typeof(#TABLENAME#_Model), vl_sqlcmd_o).Cast<#TABLENAME#_Model>().ToList();\n" +
                                    "\t\t\tif (vl_#TABLENAME#_List_o.Count > 0)\n" +
                                    "\t\t\t{\n" +
                                    "\t\t\t\tvl_#TABLENAME#_Model_o = vl_#TABLENAME#_List_o.First();\n" +
                                    "\t\t\t}\n" +
                                    "\t\t\treturn vl_#TABLENAME#_Model_o;\n" +
                                    "\t\t}";

        public string SelectMulti = "\t\tpublic List<#TABLENAME#_Model> GetMulti#TABLENAME#(List<#PRIMARY_KEY_CSHARP_TYPE#> parameterList_k)\n" +
                            "\t\t{\n" +
                                    "\t\t\tList<#TABLENAME#_Model> vl_#TABLENAME#List_o = null;\n" +
                                    "\t\t\tDataBinder_BO vl_dataBinder_o = new DataBinder_BO();\n" +
                                    "\t\t\tSQLCommandModel vl_sqlcmd_o = new SQLCommandModel();\n" +

                                    "\t\t\tDataTable dataTable_o = new DataTable(\"_PK_\");\n" +
                                    "\t\t\tDataColumn tableColumn_o = new DataColumn();\n" +
                                    "\t\t\ttableColumn_o.DataType = System.Type.GetType(\"#GetTypeString#\");\n" +
                                    "\t\t\ttableColumn_o.ColumnName = \"_PK_\";\n" +
                                    "\t\t\tdataTable_o.Columns.Add(tableColumn_o);\n" +
                                    "\t\t\tforeach (#PRIMARY_KEY_CSHARP_TYPE# temp_o in parameterList_k ?? new List<#PRIMARY_KEY_CSHARP_TYPE#>())\n" +
                                    "\t\t\t{\n" +
                                    "\t\t\t\tDataRow row_o = dataTable_o.NewRow();\n" +
                                    "\t\t\t\trow_o[\"_PK_\"] = temp_o;\n" +
                                    "\t\t\t\tdataTable_o.Rows.Add(row_o);\n" +
                                    "\t\t\t}\n" +
                                    "\t\t\tList<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();\n" +
                                    "\t\t\tSQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = \"_PK_\", Parameter_Value = dataTable_o, SqlDbType = SqlDbType.Structured, TypeName = \"#PARAM_TABLE#\" };\n" +
                                    "\t\t\tvl_paramList.Add(tempParam_o);\n" +

                                    "\t\t\tvl_sqlcmd_o.SQL_Name = \"#TABLENAME#_SELECT_COLLECTION\";\n" +
                                    "\t\t\tvl_sqlcmd_o.SQL_ParameterList = vl_paramList;\n" +
                                    "\t\t\tvl_#TABLENAME#List_o = vl_dataBinder_o.GetGenericModel(typeof(#TABLENAME#_Model), vl_sqlcmd_o).Cast<#TABLENAME#_Model>().ToList();\n" +
                                    "\t\t\treturn vl_#TABLENAME#List_o;\n" +
                            "\t\t}";


        public string InsertSingle = "\t\tpublic bool Insert#TABLENAME#(#TABLENAME#_Model in_#TABLENAME#_Model_o)\n" +
                                     "\t\t{\n" +
                                     "\t\t\tbool vl_success_z = false;\n" +
                                     "\t\t\tDataBinder_BO vl_dataBinder_o = new DataBinder_BO();\n" +
                                     "\t\t\tSQLCommandModel vl_sqlcmd_o = new SQLCommandModel();\n" +
                                     "\t\t\tList<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();\n" +
                                     //"\t\t\t{\n" +
                                     //"#ALL_SQL_PARAMETERS# \n" +
                                     //"\t\t\t};\n" +
                                     "\t\t\tvl_sqlcmd_o.SQL_Name = \"#TABLENAME#_INSERT\";\n" +
                                     "\t\t\tvl_sqlcmd_o.SQL_ParameterList = vl_paramList;\n" +
                                     "\t\t\tvl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_#TABLENAME#_Model_o, vl_sqlcmd_o);\n" +
                                     "\t\t\treturn vl_success_z;\n" +
                                     "\t\t}\n";

        public string UpdateSingle = "\t\tpublic bool Update#TABLENAME#(#TABLENAME#_Model in_#TABLENAME#_Model_o)\n" +
                                     "\t\t{\n" +
                                     "\t\t\tbool vl_success_z = false;\n" +
                                     "\t\t\tDataBinder_BO vl_dataBinder_o = new DataBinder_BO();\n" +
                                     "\t\t\tSQLCommandModel vl_sqlcmd_o = new SQLCommandModel();\n" +
                                     "\t\t\tList<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();\n" +
                                     //"\t\t\t{\n" +
                                     //"#ALL_SQL_PARAMETERS# \n" +
                                     //"\t\t\t};\n" +
                                     "\t\t\tvl_sqlcmd_o.SQL_Name = \"#TABLENAME#_UPDATE\";\n" +
                                     "\t\t\tvl_sqlcmd_o.SQL_ParameterList = vl_paramList;\n" +
                                     "\t\t\tvl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_#TABLENAME#_Model_o, vl_sqlcmd_o);\n" +
                                     "\t\t\treturn vl_success_z;\n" +
                                     "\t\t}\n";

        public string DeleteSingle = "\t\tpublic bool Delete#TABLENAME#(#TABLENAME#_Model in_#TABLENAME#_Model_o)\n" +
                                     "\t\t{\n" +
                                     "\t\t\tbool vl_success_z = false;\n" +
                                     "\t\t\tDataBinder_BO vl_dataBinder_o = new DataBinder_BO();\n" +
                                     "\t\t\tSQLCommandModel vl_sqlcmd_o = new SQLCommandModel();\n" +
                                     "\t\t\tList<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();\n" +
                                     //"\t\t\t{\n" +
                                     //"#DELETE_SQL_PARAMETERS# \n" +
                                     //"\t\t\t};\n" +
                                     "\t\t\tvl_sqlcmd_o.SQL_Name = \"#TABLENAME#_DELETE\";\n" +
                                     "\t\t\tvl_sqlcmd_o.SQL_ParameterList = vl_paramList;\n" +
                                     "\t\t\tvl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_#TABLENAME#_Model_o, vl_sqlcmd_o);\n" +
                                     "\t\t\treturn vl_success_z;\n" +
                                     "\t\t}\n";


        public string Footer =  "\t}\n" + 
                                "}";

    }
}