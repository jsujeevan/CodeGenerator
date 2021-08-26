using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Document;

namespace MShed_Web.BOs
{
	public class DocumentBO
	{
		/* Document*/

		public List<Document_Model> SearchDocument(Dictionary<string, object> parameterList_k)
		{
			List<Document_Model> vl_DocumentList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Document_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_DocumentList_o = vl_dataBinder_o.GetGenericModel(typeof(Document_Model), vl_sqlcmd_o).Cast<Document_Model>().ToList();
			return vl_DocumentList_o;
		}


		public Document_Model GetDocument(Guid in_PK_Document_ID_s)
		{
			Document_Model vl_Document_Model_o = new Document_Model();
			List<Document_Model> vl_Document_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Document_ID_s", Parameter_Value = in_PK_Document_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "Document_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Document_List_o = vl_dataBinder_o.GetGenericModel(typeof(Document_Model), vl_sqlcmd_o).Cast<Document_Model>().ToList();
			if (vl_Document_List_o.Count > 0)
			{
				vl_Document_Model_o = vl_Document_List_o.First();
			}
			return vl_Document_Model_o;
		}

		public List<Document_Model> GetMultiDocument(List<Guid> parameterList_k)
		{
			List<Document_Model> vl_DocumentList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			DataTable dataTable_o = new DataTable("_PK_");
			DataColumn tableColumn_o = new DataColumn();
			tableColumn_o.DataType = System.Type.GetType("System.Guid");
			tableColumn_o.ColumnName = "_PK_";
			dataTable_o.Columns.Add(tableColumn_o);
			foreach (Guid temp_o in parameterList_k ?? new List<Guid>())
			{
				DataRow row_o = dataTable_o.NewRow();
				row_o["_PK_"] = temp_o;
				dataTable_o.Rows.Add(row_o);
			}
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = "_PK_", Parameter_Value = dataTable_o, SqlDbType = SqlDbType.Structured, TypeName = "dbo.UNIQUEIDENTIFIER_COLLECTION" };
			vl_paramList.Add(tempParam_o);
			vl_sqlcmd_o.SQL_Name = "Document_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_DocumentList_o = vl_dataBinder_o.GetGenericModel(typeof(Document_Model), vl_sqlcmd_o).Cast<Document_Model>().ToList();
			return vl_DocumentList_o;
		}

		public bool InsertDocument(Document_Model in_Document_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Document_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Document_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateDocument(Document_Model in_Document_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Document_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Document_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteDocument(Document_Model in_Document_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Document_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Document_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}