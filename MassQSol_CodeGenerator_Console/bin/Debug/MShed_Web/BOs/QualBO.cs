using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Qual;

namespace MShed_Web.BOs
{
	public class QualBO
	{
		/* Qual*/

		public List<Qual_Model> SearchQual(Dictionary<string, object> parameterList_k)
		{
			List<Qual_Model> vl_QualList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Qual_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualList_o = vl_dataBinder_o.GetGenericModel(typeof(Qual_Model), vl_sqlcmd_o).Cast<Qual_Model>().ToList();
			return vl_QualList_o;
		}


		public Qual_Model GetQual(Guid in_PK_Qual_ID_s)
		{
			Qual_Model vl_Qual_Model_o = new Qual_Model();
			List<Qual_Model> vl_Qual_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Qual_ID_s", Parameter_Value = in_PK_Qual_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "Qual_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Qual_List_o = vl_dataBinder_o.GetGenericModel(typeof(Qual_Model), vl_sqlcmd_o).Cast<Qual_Model>().ToList();
			if (vl_Qual_List_o.Count > 0)
			{
				vl_Qual_Model_o = vl_Qual_List_o.First();
			}
			return vl_Qual_Model_o;
		}

		public List<Qual_Model> GetMultiQual(List<Guid> parameterList_k)
		{
			List<Qual_Model> vl_QualList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "Qual_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualList_o = vl_dataBinder_o.GetGenericModel(typeof(Qual_Model), vl_sqlcmd_o).Cast<Qual_Model>().ToList();
			return vl_QualList_o;
		}

		public bool InsertQual(Qual_Model in_Qual_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Qual_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Qual_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateQual(Qual_Model in_Qual_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Qual_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Qual_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteQual(Qual_Model in_Qual_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Qual_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Qual_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* QualSubject*/

		public List<QualSubject_Model> SearchQualSubject(Dictionary<string, object> parameterList_k)
		{
			List<QualSubject_Model> vl_QualSubjectList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "QualSubject_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualSubjectList_o = vl_dataBinder_o.GetGenericModel(typeof(QualSubject_Model), vl_sqlcmd_o).Cast<QualSubject_Model>().ToList();
			return vl_QualSubjectList_o;
		}


		public QualSubject_Model GetQualSubject(Guid in_PK_QualSubject_ID_s)
		{
			QualSubject_Model vl_QualSubject_Model_o = new QualSubject_Model();
			List<QualSubject_Model> vl_QualSubject_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_QualSubject_ID_s", Parameter_Value = in_PK_QualSubject_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "QualSubject_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualSubject_List_o = vl_dataBinder_o.GetGenericModel(typeof(QualSubject_Model), vl_sqlcmd_o).Cast<QualSubject_Model>().ToList();
			if (vl_QualSubject_List_o.Count > 0)
			{
				vl_QualSubject_Model_o = vl_QualSubject_List_o.First();
			}
			return vl_QualSubject_Model_o;
		}

		public List<QualSubject_Model> GetMultiQualSubject(List<Guid> parameterList_k)
		{
			List<QualSubject_Model> vl_QualSubjectList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "QualSubject_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualSubjectList_o = vl_dataBinder_o.GetGenericModel(typeof(QualSubject_Model), vl_sqlcmd_o).Cast<QualSubject_Model>().ToList();
			return vl_QualSubjectList_o;
		}

		public bool InsertQualSubject(QualSubject_Model in_QualSubject_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualSubject_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualSubject_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateQualSubject(QualSubject_Model in_QualSubject_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualSubject_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualSubject_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteQualSubject(QualSubject_Model in_QualSubject_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualSubject_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualSubject_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* QualSubjectResource*/

		public List<QualSubjectResource_Model> SearchQualSubjectResource(Dictionary<string, object> parameterList_k)
		{
			List<QualSubjectResource_Model> vl_QualSubjectResourceList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "QualSubjectResource_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualSubjectResourceList_o = vl_dataBinder_o.GetGenericModel(typeof(QualSubjectResource_Model), vl_sqlcmd_o).Cast<QualSubjectResource_Model>().ToList();
			return vl_QualSubjectResourceList_o;
		}


		public QualSubjectResource_Model GetQualSubjectResource(Guid in_PK_QualSubjectResource_ID_s)
		{
			QualSubjectResource_Model vl_QualSubjectResource_Model_o = new QualSubjectResource_Model();
			List<QualSubjectResource_Model> vl_QualSubjectResource_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_QualSubjectResource_ID_s", Parameter_Value = in_PK_QualSubjectResource_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "QualSubjectResource_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualSubjectResource_List_o = vl_dataBinder_o.GetGenericModel(typeof(QualSubjectResource_Model), vl_sqlcmd_o).Cast<QualSubjectResource_Model>().ToList();
			if (vl_QualSubjectResource_List_o.Count > 0)
			{
				vl_QualSubjectResource_Model_o = vl_QualSubjectResource_List_o.First();
			}
			return vl_QualSubjectResource_Model_o;
		}

		public List<QualSubjectResource_Model> GetMultiQualSubjectResource(List<Guid> parameterList_k)
		{
			List<QualSubjectResource_Model> vl_QualSubjectResourceList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "QualSubjectResource_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualSubjectResourceList_o = vl_dataBinder_o.GetGenericModel(typeof(QualSubjectResource_Model), vl_sqlcmd_o).Cast<QualSubjectResource_Model>().ToList();
			return vl_QualSubjectResourceList_o;
		}

		public bool InsertQualSubjectResource(QualSubjectResource_Model in_QualSubjectResource_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualSubjectResource_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualSubjectResource_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateQualSubjectResource(QualSubjectResource_Model in_QualSubjectResource_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualSubjectResource_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualSubjectResource_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteQualSubjectResource(QualSubjectResource_Model in_QualSubjectResource_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualSubjectResource_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualSubjectResource_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* QualType*/

		public List<QualType_Model> SearchQualType(Dictionary<string, object> parameterList_k)
		{
			List<QualType_Model> vl_QualTypeList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "QualType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(QualType_Model), vl_sqlcmd_o).Cast<QualType_Model>().ToList();
			return vl_QualTypeList_o;
		}


		public QualType_Model GetQualType(int in_PK_QualType_i)
		{
			QualType_Model vl_QualType_Model_o = new QualType_Model();
			List<QualType_Model> vl_QualType_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_QualType_i", Parameter_Value = in_PK_QualType_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "QualType_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualType_List_o = vl_dataBinder_o.GetGenericModel(typeof(QualType_Model), vl_sqlcmd_o).Cast<QualType_Model>().ToList();
			if (vl_QualType_List_o.Count > 0)
			{
				vl_QualType_Model_o = vl_QualType_List_o.First();
			}
			return vl_QualType_Model_o;
		}

		public List<QualType_Model> GetMultiQualType(List<int> parameterList_k)
		{
			List<QualType_Model> vl_QualTypeList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "QualType_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_QualTypeList_o = vl_dataBinder_o.GetGenericModel(typeof(QualType_Model), vl_sqlcmd_o).Cast<QualType_Model>().ToList();
			return vl_QualTypeList_o;
		}

		public bool InsertQualType(QualType_Model in_QualType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualType_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateQualType(QualType_Model in_QualType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualType_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteQualType(QualType_Model in_QualType_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "QualType_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_QualType_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* Subject*/

		public List<Subject_Model> SearchSubject(Dictionary<string, object> parameterList_k)
		{
			List<Subject_Model> vl_SubjectList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Subject_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_SubjectList_o = vl_dataBinder_o.GetGenericModel(typeof(Subject_Model), vl_sqlcmd_o).Cast<Subject_Model>().ToList();
			return vl_SubjectList_o;
		}


		public Subject_Model GetSubject(int in_PK_Subject_i)
		{
			Subject_Model vl_Subject_Model_o = new Subject_Model();
			List<Subject_Model> vl_Subject_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Subject_i", Parameter_Value = in_PK_Subject_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "Subject_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Subject_List_o = vl_dataBinder_o.GetGenericModel(typeof(Subject_Model), vl_sqlcmd_o).Cast<Subject_Model>().ToList();
			if (vl_Subject_List_o.Count > 0)
			{
				vl_Subject_Model_o = vl_Subject_List_o.First();
			}
			return vl_Subject_Model_o;
		}

		public List<Subject_Model> GetMultiSubject(List<int> parameterList_k)
		{
			List<Subject_Model> vl_SubjectList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "Subject_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_SubjectList_o = vl_dataBinder_o.GetGenericModel(typeof(Subject_Model), vl_sqlcmd_o).Cast<Subject_Model>().ToList();
			return vl_SubjectList_o;
		}

		public bool InsertSubject(Subject_Model in_Subject_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Subject_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Subject_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdateSubject(Subject_Model in_Subject_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Subject_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Subject_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeleteSubject(Subject_Model in_Subject_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Subject_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Subject_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}