using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Object;

namespace MShed_Web.BOs
{
	public class ObjectBO
	{
		/* Object*/

		public List<Object_Model> SearchObject(Dictionary<string, object> parameterList_k)
		{
			List<Object_Model> vl_ObjectList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Object_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectList_o = vl_dataBinder_o.GetGenericModel(typeof(Object_Model), vl_sqlcmd_o).Cast<Object_Model>().ToList();
			return vl_ObjectList_o;
		}


		public Object_Model GetObject(Guid in_PK_Object_ID_s)
		{
			Object_Model vl_Object_Model_o = new Object_Model();
			List<Object_Model> vl_Object_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Object_ID_s", Parameter_Value = in_PK_Object_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "Object_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Object_List_o = vl_dataBinder_o.GetGenericModel(typeof(Object_Model), vl_sqlcmd_o).Cast<Object_Model>().ToList();
			if (vl_Object_List_o.Count > 0)
			{
				vl_Object_Model_o = vl_Object_List_o.First();
			}
			return vl_Object_Model_o;
		}

		public List<Object_Model> GetMultiObject(List<Guid> parameterList_k)
		{
			List<Object_Model> vl_ObjectList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "Object_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectList_o = vl_dataBinder_o.GetGenericModel(typeof(Object_Model), vl_sqlcmd_o).Cast<Object_Model>().ToList();
			return vl_ObjectList_o;
		}

		public bool InsertObject(Object_Model in_Object_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Object_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Object_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateObject(Object_Model in_Object_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Object_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Object_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteObject(Object_Model in_Object_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Object_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Object_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ObjectPermission*/

		public List<ObjectPermission_Model> SearchObjectPermission(Dictionary<string, object> parameterList_k)
		{
			List<ObjectPermission_Model> vl_ObjectPermissionList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ObjectPermission_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectPermissionList_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectPermission_Model), vl_sqlcmd_o).Cast<ObjectPermission_Model>().ToList();
			return vl_ObjectPermissionList_o;
		}


		public ObjectPermission_Model GetObjectPermission(Guid in_PK_ObjectPermission_ID_s)
		{
			ObjectPermission_Model vl_ObjectPermission_Model_o = new ObjectPermission_Model();
			List<ObjectPermission_Model> vl_ObjectPermission_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ObjectPermission_ID_s", Parameter_Value = in_PK_ObjectPermission_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "ObjectPermission_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectPermission_List_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectPermission_Model), vl_sqlcmd_o).Cast<ObjectPermission_Model>().ToList();
			if (vl_ObjectPermission_List_o.Count > 0)
			{
				vl_ObjectPermission_Model_o = vl_ObjectPermission_List_o.First();
			}
			return vl_ObjectPermission_Model_o;
		}

		public List<ObjectPermission_Model> GetMultiObjectPermission(List<Guid> parameterList_k)
		{
			List<ObjectPermission_Model> vl_ObjectPermissionList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ObjectPermission_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectPermissionList_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectPermission_Model), vl_sqlcmd_o).Cast<ObjectPermission_Model>().ToList();
			return vl_ObjectPermissionList_o;
		}

		public bool InsertObjectPermission(ObjectPermission_Model in_ObjectPermission_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectPermission_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectPermission_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateObjectPermission(ObjectPermission_Model in_ObjectPermission_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectPermission_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectPermission_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteObjectPermission(ObjectPermission_Model in_ObjectPermission_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectPermission_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectPermission_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ObjectRole*/

		public List<ObjectRole_Model> SearchObjectRole(Dictionary<string, object> parameterList_k)
		{
			List<ObjectRole_Model> vl_ObjectRoleList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ObjectRole_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectRoleList_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectRole_Model), vl_sqlcmd_o).Cast<ObjectRole_Model>().ToList();
			return vl_ObjectRoleList_o;
		}


		public ObjectRole_Model GetObjectRole(int in_PK_ObjectRole_ID_i)
		{
			ObjectRole_Model vl_ObjectRole_Model_o = new ObjectRole_Model();
			List<ObjectRole_Model> vl_ObjectRole_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ObjectRole_ID_i", Parameter_Value = in_PK_ObjectRole_ID_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "ObjectRole_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectRole_List_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectRole_Model), vl_sqlcmd_o).Cast<ObjectRole_Model>().ToList();
			if (vl_ObjectRole_List_o.Count > 0)
			{
				vl_ObjectRole_Model_o = vl_ObjectRole_List_o.First();
			}
			return vl_ObjectRole_Model_o;
		}

		public List<ObjectRole_Model> GetMultiObjectRole(List<int> parameterList_k)
		{
			List<ObjectRole_Model> vl_ObjectRoleList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ObjectRole_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectRoleList_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectRole_Model), vl_sqlcmd_o).Cast<ObjectRole_Model>().ToList();
			return vl_ObjectRoleList_o;
		}

		public bool InsertObjectRole(ObjectRole_Model in_ObjectRole_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectRole_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectRole_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateObjectRole(ObjectRole_Model in_ObjectRole_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectRole_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectRole_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteObjectRole(ObjectRole_Model in_ObjectRole_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectRole_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectRole_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ObjectType*/

		public List<ObjectType_Model> SearchObjectType(Dictionary<string, object> parameterList_k)
		{
			List<ObjectType_Model> vl_ObjectTypeList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ObjectType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectType_Model), vl_sqlcmd_o).Cast<ObjectType_Model>().ToList();
			return vl_ObjectTypeList_o;
		}


		public ObjectType_Model GetObjectType(int in_PK_ObjectType_ID_i)
		{
			ObjectType_Model vl_ObjectType_Model_o = new ObjectType_Model();
			List<ObjectType_Model> vl_ObjectType_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ObjectType_ID_i", Parameter_Value = in_PK_ObjectType_ID_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "ObjectType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectType_List_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectType_Model), vl_sqlcmd_o).Cast<ObjectType_Model>().ToList();
			if (vl_ObjectType_List_o.Count > 0)
			{
				vl_ObjectType_Model_o = vl_ObjectType_List_o.First();
			}
			return vl_ObjectType_Model_o;
		}

		public List<ObjectType_Model> GetMultiObjectType(List<int> parameterList_k)
		{
			List<ObjectType_Model> vl_ObjectTypeList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ObjectType_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ObjectTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ObjectType_Model), vl_sqlcmd_o).Cast<ObjectType_Model>().ToList();
			return vl_ObjectTypeList_o;
		}

		public bool InsertObjectType(ObjectType_Model in_ObjectType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectType_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateObjectType(ObjectType_Model in_ObjectType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectType_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteObjectType(ObjectType_Model in_ObjectType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ObjectType_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ObjectType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}