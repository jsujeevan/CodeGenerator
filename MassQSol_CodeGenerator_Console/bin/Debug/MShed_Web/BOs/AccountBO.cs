using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Account;

namespace MShed_Web.BOs
{
	public class AccountBO
	{
		/* __MigrationHistory*/

		public List<__MigrationHistory_Model> Search__MigrationHistory(Dictionary<string, object> parameterList_k)
		{
			List<__MigrationHistory_Model> vl___MigrationHistoryList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "__MigrationHistory_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl___MigrationHistoryList_o = vl_dataBinder_o.GetGenericModel(typeof(__MigrationHistory_Model), vl_sqlcmd_o).Cast<__MigrationHistory_Model>().ToList();
			return vl___MigrationHistoryList_o;
		}


		public __MigrationHistory_Model Get__MigrationHistory(string in_MigrationId)
		{
			__MigrationHistory_Model vl___MigrationHistory_Model_o = new __MigrationHistory_Model();
			List<__MigrationHistory_Model> vl___MigrationHistory_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "MigrationId", Parameter_Value = in_MigrationId , SqlDbType = SqlDbType.VarChar }
			};
			vl_sqlcmd_o.SQL_Name = "__MigrationHistory_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl___MigrationHistory_List_o = vl_dataBinder_o.GetGenericModel(typeof(__MigrationHistory_Model), vl_sqlcmd_o).Cast<__MigrationHistory_Model>().ToList();
			if (vl___MigrationHistory_List_o.Count > 0)
			{
				vl___MigrationHistory_Model_o = vl___MigrationHistory_List_o.First();
			}
			return vl___MigrationHistory_Model_o;
		}

		public List<__MigrationHistory_Model> GetMulti__MigrationHistory(List<string> parameterList_k)
		{
			List<__MigrationHistory_Model> vl___MigrationHistoryList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "__MigrationHistory_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl___MigrationHistoryList_o = vl_dataBinder_o.GetGenericModel(typeof(__MigrationHistory_Model), vl_sqlcmd_o).Cast<__MigrationHistory_Model>().ToList();
			return vl___MigrationHistoryList_o;
		}

		public bool Insert__MigrationHistory(__MigrationHistory_Model in___MigrationHistory_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "__MigrationHistory_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in___MigrationHistory_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool Update__MigrationHistory(__MigrationHistory_Model in___MigrationHistory_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "__MigrationHistory_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in___MigrationHistory_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool Delete__MigrationHistory(__MigrationHistory_Model in___MigrationHistory_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "__MigrationHistory_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in___MigrationHistory_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* AspNetRoles*/

		public List<AspNetRoles_Model> SearchAspNetRoles(Dictionary<string, object> parameterList_k)
		{
			List<AspNetRoles_Model> vl_AspNetRolesList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "AspNetRoles_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetRolesList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetRoles_Model), vl_sqlcmd_o).Cast<AspNetRoles_Model>().ToList();
			return vl_AspNetRolesList_o;
		}


		public AspNetRoles_Model GetAspNetRoles(string in_Id)
		{
			AspNetRoles_Model vl_AspNetRoles_Model_o = new AspNetRoles_Model();
			List<AspNetRoles_Model> vl_AspNetRoles_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "Id", Parameter_Value = in_Id , SqlDbType = SqlDbType.VarChar }
			};
			vl_sqlcmd_o.SQL_Name = "AspNetRoles_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetRoles_List_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetRoles_Model), vl_sqlcmd_o).Cast<AspNetRoles_Model>().ToList();
			if (vl_AspNetRoles_List_o.Count > 0)
			{
				vl_AspNetRoles_Model_o = vl_AspNetRoles_List_o.First();
			}
			return vl_AspNetRoles_Model_o;
		}

		public List<AspNetRoles_Model> GetMultiAspNetRoles(List<string> parameterList_k)
		{
			List<AspNetRoles_Model> vl_AspNetRolesList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "AspNetRoles_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetRolesList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetRoles_Model), vl_sqlcmd_o).Cast<AspNetRoles_Model>().ToList();
			return vl_AspNetRolesList_o;
		}

		public bool InsertAspNetRoles(AspNetRoles_Model in_AspNetRoles_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetRoles_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetRoles_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateAspNetRoles(AspNetRoles_Model in_AspNetRoles_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetRoles_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetRoles_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteAspNetRoles(AspNetRoles_Model in_AspNetRoles_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetRoles_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetRoles_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* AspNetUserClaims*/

		public List<AspNetUserClaims_Model> SearchAspNetUserClaims(Dictionary<string, object> parameterList_k)
		{
			List<AspNetUserClaims_Model> vl_AspNetUserClaimsList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "AspNetUserClaims_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserClaimsList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserClaims_Model), vl_sqlcmd_o).Cast<AspNetUserClaims_Model>().ToList();
			return vl_AspNetUserClaimsList_o;
		}


		public AspNetUserClaims_Model GetAspNetUserClaims(int in_Id)
		{
			AspNetUserClaims_Model vl_AspNetUserClaims_Model_o = new AspNetUserClaims_Model();
			List<AspNetUserClaims_Model> vl_AspNetUserClaims_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "Id", Parameter_Value = in_Id , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "AspNetUserClaims_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserClaims_List_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserClaims_Model), vl_sqlcmd_o).Cast<AspNetUserClaims_Model>().ToList();
			if (vl_AspNetUserClaims_List_o.Count > 0)
			{
				vl_AspNetUserClaims_Model_o = vl_AspNetUserClaims_List_o.First();
			}
			return vl_AspNetUserClaims_Model_o;
		}

		public List<AspNetUserClaims_Model> GetMultiAspNetUserClaims(List<int> parameterList_k)
		{
			List<AspNetUserClaims_Model> vl_AspNetUserClaimsList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			DataTable dataTable_o = new DataTable("_PK_");
			DataColumn tableColumn_o = new DataColumn();
			tableColumn_o.DataType = System.Type.GetType("System.Int32");
			tableColumn_o.ColumnName = "_PK_";
			dataTable_o.Columns.Add(tableColumn_o);
			foreach (int temp_o in parameterList_k ?? new List<int>())
			{
				DataRow row_o = dataTable_o.NewRow();
				row_o["_PK_"] = temp_o;
				dataTable_o.Rows.Add(row_o);
			}
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = "_PK_", Parameter_Value = dataTable_o, SqlDbType = SqlDbType.Structured, TypeName = "dbo.INT_COLLECTION" };
			vl_paramList.Add(tempParam_o);
			vl_sqlcmd_o.SQL_Name = "AspNetUserClaims_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserClaimsList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserClaims_Model), vl_sqlcmd_o).Cast<AspNetUserClaims_Model>().ToList();
			return vl_AspNetUserClaimsList_o;
		}

		public bool InsertAspNetUserClaims(AspNetUserClaims_Model in_AspNetUserClaims_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserClaims_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserClaims_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateAspNetUserClaims(AspNetUserClaims_Model in_AspNetUserClaims_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserClaims_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserClaims_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteAspNetUserClaims(AspNetUserClaims_Model in_AspNetUserClaims_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserClaims_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserClaims_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* AspNetUserLogins*/

		public List<AspNetUserLogins_Model> SearchAspNetUserLogins(Dictionary<string, object> parameterList_k)
		{
			List<AspNetUserLogins_Model> vl_AspNetUserLoginsList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "AspNetUserLogins_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserLoginsList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserLogins_Model), vl_sqlcmd_o).Cast<AspNetUserLogins_Model>().ToList();
			return vl_AspNetUserLoginsList_o;
		}


		public AspNetUserLogins_Model GetAspNetUserLogins(string in_UserId)
		{
			AspNetUserLogins_Model vl_AspNetUserLogins_Model_o = new AspNetUserLogins_Model();
			List<AspNetUserLogins_Model> vl_AspNetUserLogins_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "UserId", Parameter_Value = in_UserId , SqlDbType = SqlDbType.VarChar }
			};
			vl_sqlcmd_o.SQL_Name = "AspNetUserLogins_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserLogins_List_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserLogins_Model), vl_sqlcmd_o).Cast<AspNetUserLogins_Model>().ToList();
			if (vl_AspNetUserLogins_List_o.Count > 0)
			{
				vl_AspNetUserLogins_Model_o = vl_AspNetUserLogins_List_o.First();
			}
			return vl_AspNetUserLogins_Model_o;
		}

		public List<AspNetUserLogins_Model> GetMultiAspNetUserLogins(List<string> parameterList_k)
		{
			List<AspNetUserLogins_Model> vl_AspNetUserLoginsList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "AspNetUserLogins_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserLoginsList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserLogins_Model), vl_sqlcmd_o).Cast<AspNetUserLogins_Model>().ToList();
			return vl_AspNetUserLoginsList_o;
		}

		public bool InsertAspNetUserLogins(AspNetUserLogins_Model in_AspNetUserLogins_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserLogins_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserLogins_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateAspNetUserLogins(AspNetUserLogins_Model in_AspNetUserLogins_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserLogins_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserLogins_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteAspNetUserLogins(AspNetUserLogins_Model in_AspNetUserLogins_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserLogins_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserLogins_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* AspNetUserRoles*/

		public List<AspNetUserRoles_Model> SearchAspNetUserRoles(Dictionary<string, object> parameterList_k)
		{
			List<AspNetUserRoles_Model> vl_AspNetUserRolesList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "AspNetUserRoles_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserRolesList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserRoles_Model), vl_sqlcmd_o).Cast<AspNetUserRoles_Model>().ToList();
			return vl_AspNetUserRolesList_o;
		}


		public AspNetUserRoles_Model GetAspNetUserRoles(string in_UserId)
		{
			AspNetUserRoles_Model vl_AspNetUserRoles_Model_o = new AspNetUserRoles_Model();
			List<AspNetUserRoles_Model> vl_AspNetUserRoles_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "UserId", Parameter_Value = in_UserId , SqlDbType = SqlDbType.VarChar }
			};
			vl_sqlcmd_o.SQL_Name = "AspNetUserRoles_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserRoles_List_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserRoles_Model), vl_sqlcmd_o).Cast<AspNetUserRoles_Model>().ToList();
			if (vl_AspNetUserRoles_List_o.Count > 0)
			{
				vl_AspNetUserRoles_Model_o = vl_AspNetUserRoles_List_o.First();
			}
			return vl_AspNetUserRoles_Model_o;
		}

		public List<AspNetUserRoles_Model> GetMultiAspNetUserRoles(List<string> parameterList_k)
		{
			List<AspNetUserRoles_Model> vl_AspNetUserRolesList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "AspNetUserRoles_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUserRolesList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUserRoles_Model), vl_sqlcmd_o).Cast<AspNetUserRoles_Model>().ToList();
			return vl_AspNetUserRolesList_o;
		}

		public bool InsertAspNetUserRoles(AspNetUserRoles_Model in_AspNetUserRoles_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserRoles_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserRoles_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateAspNetUserRoles(AspNetUserRoles_Model in_AspNetUserRoles_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserRoles_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserRoles_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteAspNetUserRoles(AspNetUserRoles_Model in_AspNetUserRoles_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUserRoles_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUserRoles_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* AspNetUsers*/

		public List<AspNetUsers_Model> SearchAspNetUsers(Dictionary<string, object> parameterList_k)
		{
			List<AspNetUsers_Model> vl_AspNetUsersList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "AspNetUsers_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUsersList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUsers_Model), vl_sqlcmd_o).Cast<AspNetUsers_Model>().ToList();
			return vl_AspNetUsersList_o;
		}


		public AspNetUsers_Model GetAspNetUsers(string in_Id)
		{
			AspNetUsers_Model vl_AspNetUsers_Model_o = new AspNetUsers_Model();
			List<AspNetUsers_Model> vl_AspNetUsers_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "Id", Parameter_Value = in_Id , SqlDbType = SqlDbType.VarChar }
			};
			vl_sqlcmd_o.SQL_Name = "AspNetUsers_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUsers_List_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUsers_Model), vl_sqlcmd_o).Cast<AspNetUsers_Model>().ToList();
			if (vl_AspNetUsers_List_o.Count > 0)
			{
				vl_AspNetUsers_Model_o = vl_AspNetUsers_List_o.First();
			}
			return vl_AspNetUsers_Model_o;
		}

		public List<AspNetUsers_Model> GetMultiAspNetUsers(List<string> parameterList_k)
		{
			List<AspNetUsers_Model> vl_AspNetUsersList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "AspNetUsers_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_AspNetUsersList_o = vl_dataBinder_o.GetGenericModel(typeof(AspNetUsers_Model), vl_sqlcmd_o).Cast<AspNetUsers_Model>().ToList();
			return vl_AspNetUsersList_o;
		}

		public bool InsertAspNetUsers(AspNetUsers_Model in_AspNetUsers_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUsers_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUsers_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateAspNetUsers(AspNetUsers_Model in_AspNetUsers_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUsers_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUsers_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteAspNetUsers(AspNetUsers_Model in_AspNetUsers_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "AspNetUsers_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_AspNetUsers_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}