using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Application;

namespace MShed_Web.BOs
{
	public class ApplicationBO
	{
		/* Config*/

		public List<Config_Model> SearchConfig(Dictionary<string, object> parameterList_k)
		{
			List<Config_Model> vl_ConfigList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Config_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ConfigList_o = vl_dataBinder_o.GetGenericModel(typeof(Config_Model), vl_sqlcmd_o).Cast<Config_Model>().ToList();
			return vl_ConfigList_o;
		}


		public Config_Model GetConfig(string in_PK_Key_s)
		{
			Config_Model vl_Config_Model_o = new Config_Model();
			List<Config_Model> vl_Config_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Key_s", Parameter_Value = in_PK_Key_s , SqlDbType = SqlDbType.VarChar }
			};
			vl_sqlcmd_o.SQL_Name = "Config_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Config_List_o = vl_dataBinder_o.GetGenericModel(typeof(Config_Model), vl_sqlcmd_o).Cast<Config_Model>().ToList();
			if (vl_Config_List_o.Count > 0)
			{
				vl_Config_Model_o = vl_Config_List_o.First();
			}
			return vl_Config_Model_o;
		}

		public List<Config_Model> GetMultiConfig(List<string> parameterList_k)
		{
			List<Config_Model> vl_ConfigList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			DataTable dataTable_o = new DataTable("_PK_");
			DataColumn tableColumn_o = new DataColumn();
			tableColumn_o.DataType = System.Type.GetType("System.String");
			tableColumn_o.ColumnName = "_PK_";
			dataTable_o.Columns.Add(tableColumn_o);
			foreach (string temp_o in parameterList_k ?? new List<string>())
			{
				DataRow row_o = dataTable_o.NewRow();
				row_o["_PK_"] = temp_o;
				dataTable_o.Rows.Add(row_o);
			}
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = "_PK_", Parameter_Value = dataTable_o, SqlDbType = SqlDbType.Structured, TypeName = "dbo.VARCHAR_COLLECTION" };
			vl_paramList.Add(tempParam_o);
			vl_sqlcmd_o.SQL_Name = "Config_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ConfigList_o = vl_dataBinder_o.GetGenericModel(typeof(Config_Model), vl_sqlcmd_o).Cast<Config_Model>().ToList();
			return vl_ConfigList_o;
		}

		public bool InsertConfig(Config_Model in_Config_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Config_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Config_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateConfig(Config_Model in_Config_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Config_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Config_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteConfig(Config_Model in_Config_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Config_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Config_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}