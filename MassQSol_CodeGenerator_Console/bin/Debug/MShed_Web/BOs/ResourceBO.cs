using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Resource;

namespace MShed_Web.BOs
{
	public class ResourceBO
	{
		/* Resource*/

		public List<Resource_Model> SearchResource(Dictionary<string, object> parameterList_k)
		{
			List<Resource_Model> vl_ResourceList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Resource_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceList_o = vl_dataBinder_o.GetGenericModel(typeof(Resource_Model), vl_sqlcmd_o).Cast<Resource_Model>().ToList();
			return vl_ResourceList_o;
		}


		public Resource_Model GetResource(Guid in_PK_Resource_ID_s)
		{
			Resource_Model vl_Resource_Model_o = new Resource_Model();
			List<Resource_Model> vl_Resource_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Resource_ID_s", Parameter_Value = in_PK_Resource_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "Resource_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Resource_List_o = vl_dataBinder_o.GetGenericModel(typeof(Resource_Model), vl_sqlcmd_o).Cast<Resource_Model>().ToList();
			if (vl_Resource_List_o.Count > 0)
			{
				vl_Resource_Model_o = vl_Resource_List_o.First();
			}
			return vl_Resource_Model_o;
		}

		public List<Resource_Model> GetMultiResource(List<Guid> parameterList_k)
		{
			List<Resource_Model> vl_ResourceList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "Resource_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceList_o = vl_dataBinder_o.GetGenericModel(typeof(Resource_Model), vl_sqlcmd_o).Cast<Resource_Model>().ToList();
			return vl_ResourceList_o;
		}

		public bool InsertResource(Resource_Model in_Resource_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Resource_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Resource_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateResource(Resource_Model in_Resource_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Resource_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Resource_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteResource(Resource_Model in_Resource_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Resource_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Resource_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ResourceSupporting*/

		public List<ResourceSupporting_Model> SearchResourceSupporting(Dictionary<string, object> parameterList_k)
		{
			List<ResourceSupporting_Model> vl_ResourceSupportingList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ResourceSupporting_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceSupportingList_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceSupporting_Model), vl_sqlcmd_o).Cast<ResourceSupporting_Model>().ToList();
			return vl_ResourceSupportingList_o;
		}


		public ResourceSupporting_Model GetResourceSupporting(Guid in_PK_ResourceSupporting_ID_s)
		{
			ResourceSupporting_Model vl_ResourceSupporting_Model_o = new ResourceSupporting_Model();
			List<ResourceSupporting_Model> vl_ResourceSupporting_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ResourceSupporting_ID_s", Parameter_Value = in_PK_ResourceSupporting_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "ResourceSupporting_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceSupporting_List_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceSupporting_Model), vl_sqlcmd_o).Cast<ResourceSupporting_Model>().ToList();
			if (vl_ResourceSupporting_List_o.Count > 0)
			{
				vl_ResourceSupporting_Model_o = vl_ResourceSupporting_List_o.First();
			}
			return vl_ResourceSupporting_Model_o;
		}

		public List<ResourceSupporting_Model> GetMultiResourceSupporting(List<Guid> parameterList_k)
		{
			List<ResourceSupporting_Model> vl_ResourceSupportingList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ResourceSupporting_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceSupportingList_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceSupporting_Model), vl_sqlcmd_o).Cast<ResourceSupporting_Model>().ToList();
			return vl_ResourceSupportingList_o;
		}

		public bool InsertResourceSupporting(ResourceSupporting_Model in_ResourceSupporting_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceSupporting_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceSupporting_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateResourceSupporting(ResourceSupporting_Model in_ResourceSupporting_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceSupporting_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceSupporting_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteResourceSupporting(ResourceSupporting_Model in_ResourceSupporting_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceSupporting_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceSupporting_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ResourceSupportingType*/

		public List<ResourceSupportingType_Model> SearchResourceSupportingType(Dictionary<string, object> parameterList_k)
		{
			List<ResourceSupportingType_Model> vl_ResourceSupportingTypeList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ResourceSupportingType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceSupportingTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceSupportingType_Model), vl_sqlcmd_o).Cast<ResourceSupportingType_Model>().ToList();
			return vl_ResourceSupportingTypeList_o;
		}


		public ResourceSupportingType_Model GetResourceSupportingType(int in_PK_ResourceSupportingType_i)
		{
			ResourceSupportingType_Model vl_ResourceSupportingType_Model_o = new ResourceSupportingType_Model();
			List<ResourceSupportingType_Model> vl_ResourceSupportingType_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ResourceSupportingType_i", Parameter_Value = in_PK_ResourceSupportingType_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "ResourceSupportingType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceSupportingType_List_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceSupportingType_Model), vl_sqlcmd_o).Cast<ResourceSupportingType_Model>().ToList();
			if (vl_ResourceSupportingType_List_o.Count > 0)
			{
				vl_ResourceSupportingType_Model_o = vl_ResourceSupportingType_List_o.First();
			}
			return vl_ResourceSupportingType_Model_o;
		}

		public List<ResourceSupportingType_Model> GetMultiResourceSupportingType(List<int> parameterList_k)
		{
			List<ResourceSupportingType_Model> vl_ResourceSupportingTypeList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ResourceSupportingType_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceSupportingTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceSupportingType_Model), vl_sqlcmd_o).Cast<ResourceSupportingType_Model>().ToList();
			return vl_ResourceSupportingTypeList_o;
		}

		public bool InsertResourceSupportingType(ResourceSupportingType_Model in_ResourceSupportingType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceSupportingType_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceSupportingType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateResourceSupportingType(ResourceSupportingType_Model in_ResourceSupportingType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceSupportingType_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceSupportingType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteResourceSupportingType(ResourceSupportingType_Model in_ResourceSupportingType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceSupportingType_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceSupportingType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ResourceType*/

		public List<ResourceType_Model> SearchResourceType(Dictionary<string, object> parameterList_k)
		{
			List<ResourceType_Model> vl_ResourceTypeList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ResourceType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceType_Model), vl_sqlcmd_o).Cast<ResourceType_Model>().ToList();
			return vl_ResourceTypeList_o;
		}


		public ResourceType_Model GetResourceType(int in_PK_ResourceType_i)
		{
			ResourceType_Model vl_ResourceType_Model_o = new ResourceType_Model();
			List<ResourceType_Model> vl_ResourceType_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ResourceType_i", Parameter_Value = in_PK_ResourceType_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "ResourceType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceType_List_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceType_Model), vl_sqlcmd_o).Cast<ResourceType_Model>().ToList();
			if (vl_ResourceType_List_o.Count > 0)
			{
				vl_ResourceType_Model_o = vl_ResourceType_List_o.First();
			}
			return vl_ResourceType_Model_o;
		}

		public List<ResourceType_Model> GetMultiResourceType(List<int> parameterList_k)
		{
			List<ResourceType_Model> vl_ResourceTypeList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ResourceType_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ResourceTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ResourceType_Model), vl_sqlcmd_o).Cast<ResourceType_Model>().ToList();
			return vl_ResourceTypeList_o;
		}

		public bool InsertResourceType(ResourceType_Model in_ResourceType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceType_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateResourceType(ResourceType_Model in_ResourceType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceType_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteResourceType(ResourceType_Model in_ResourceType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ResourceType_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ResourceType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* ContentType*/

		public List<ContentType_Model> SearchContentType(Dictionary<string, object> parameterList_k)
		{
			List<ContentType_Model> vl_ContentTypeList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "ContentType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ContentTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ContentType_Model), vl_sqlcmd_o).Cast<ContentType_Model>().ToList();
			return vl_ContentTypeList_o;
		}


		public ContentType_Model GetContentType(int in_PK_ContentType_i)
		{
			ContentType_Model vl_ContentType_Model_o = new ContentType_Model();
			List<ContentType_Model> vl_ContentType_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_ContentType_i", Parameter_Value = in_PK_ContentType_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "ContentType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ContentType_List_o = vl_dataBinder_o.GetGenericModel(typeof(ContentType_Model), vl_sqlcmd_o).Cast<ContentType_Model>().ToList();
			if (vl_ContentType_List_o.Count > 0)
			{
				vl_ContentType_Model_o = vl_ContentType_List_o.First();
			}
			return vl_ContentType_Model_o;
		}

		public List<ContentType_Model> GetMultiContentType(List<int> parameterList_k)
		{
			List<ContentType_Model> vl_ContentTypeList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "ContentType_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_ContentTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(ContentType_Model), vl_sqlcmd_o).Cast<ContentType_Model>().ToList();
			return vl_ContentTypeList_o;
		}

		public bool InsertContentType(ContentType_Model in_ContentType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ContentType_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ContentType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateContentType(ContentType_Model in_ContentType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ContentType_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ContentType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteContentType(ContentType_Model in_ContentType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "ContentType_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_ContentType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}