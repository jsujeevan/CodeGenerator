using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using MShed_Web.Models;
using MShed_Web.Models.DataModel.Person;

namespace MShed_Web.BOs
{
	public class PersonBO
	{
		/* Person*/

		public List<Person_Model> SearchPerson(Dictionary<string, object> parameterList_k)
		{
			List<Person_Model> vl_PersonList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "Person_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonList_o = vl_dataBinder_o.GetGenericModel(typeof(Person_Model), vl_sqlcmd_o).Cast<Person_Model>().ToList();
			return vl_PersonList_o;
		}


		public Person_Model GetPerson(Guid in_PK_Person_ID_s)
		{
			Person_Model vl_Person_Model_o = new Person_Model();
			List<Person_Model> vl_Person_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_Person_ID_s", Parameter_Value = in_PK_Person_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "Person_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_Person_List_o = vl_dataBinder_o.GetGenericModel(typeof(Person_Model), vl_sqlcmd_o).Cast<Person_Model>().ToList();
			if (vl_Person_List_o.Count > 0)
			{
				vl_Person_Model_o = vl_Person_List_o.First();
			}
			return vl_Person_Model_o;
		}

		public List<Person_Model> GetMultiPerson(List<Guid> parameterList_k)
		{
			List<Person_Model> vl_PersonList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "Person_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonList_o = vl_dataBinder_o.GetGenericModel(typeof(Person_Model), vl_sqlcmd_o).Cast<Person_Model>().ToList();
			return vl_PersonList_o;
		}

		public bool InsertPerson(Person_Model in_Person_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Person_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Person_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdatePerson(Person_Model in_Person_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Person_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Person_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeletePerson(Person_Model in_Person_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "Person_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_Person_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* PersonLogin*/

		public List<PersonLogin_Model> SearchPersonLogin(Dictionary<string, object> parameterList_k)
		{
			List<PersonLogin_Model> vl_PersonLoginList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "PersonLogin_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonLoginList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonLogin_Model), vl_sqlcmd_o).Cast<PersonLogin_Model>().ToList();
			return vl_PersonLoginList_o;
		}


		public PersonLogin_Model GetPersonLogin(Guid in_PK_PersonLogin_ID_s)
		{
			PersonLogin_Model vl_PersonLogin_Model_o = new PersonLogin_Model();
			List<PersonLogin_Model> vl_PersonLogin_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_PersonLogin_ID_s", Parameter_Value = in_PK_PersonLogin_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "PersonLogin_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonLogin_List_o = vl_dataBinder_o.GetGenericModel(typeof(PersonLogin_Model), vl_sqlcmd_o).Cast<PersonLogin_Model>().ToList();
			if (vl_PersonLogin_List_o.Count > 0)
			{
				vl_PersonLogin_Model_o = vl_PersonLogin_List_o.First();
			}
			return vl_PersonLogin_Model_o;
		}

		public List<PersonLogin_Model> GetMultiPersonLogin(List<Guid> parameterList_k)
		{
			List<PersonLogin_Model> vl_PersonLoginList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "PersonLogin_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonLoginList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonLogin_Model), vl_sqlcmd_o).Cast<PersonLogin_Model>().ToList();
			return vl_PersonLoginList_o;
		}

		public bool InsertPersonLogin(PersonLogin_Model in_PersonLogin_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonLogin_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonLogin_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdatePersonLogin(PersonLogin_Model in_PersonLogin_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonLogin_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonLogin_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeletePersonLogin(PersonLogin_Model in_PersonLogin_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonLogin_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonLogin_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* PersonRole*/

		public List<PersonRole_Model> SearchPersonRole(Dictionary<string, object> parameterList_k)
		{
			List<PersonRole_Model> vl_PersonRoleList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "PersonRole_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonRoleList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonRole_Model), vl_sqlcmd_o).Cast<PersonRole_Model>().ToList();
			return vl_PersonRoleList_o;
		}


		public PersonRole_Model GetPersonRole(int in_PK_PersonRole_i)
		{
			PersonRole_Model vl_PersonRole_Model_o = new PersonRole_Model();
			List<PersonRole_Model> vl_PersonRole_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_PersonRole_i", Parameter_Value = in_PK_PersonRole_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "PersonRole_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonRole_List_o = vl_dataBinder_o.GetGenericModel(typeof(PersonRole_Model), vl_sqlcmd_o).Cast<PersonRole_Model>().ToList();
			if (vl_PersonRole_List_o.Count > 0)
			{
				vl_PersonRole_Model_o = vl_PersonRole_List_o.First();
			}
			return vl_PersonRole_Model_o;
		}

		public List<PersonRole_Model> GetMultiPersonRole(List<int> parameterList_k)
		{
			List<PersonRole_Model> vl_PersonRoleList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "PersonRole_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonRoleList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonRole_Model), vl_sqlcmd_o).Cast<PersonRole_Model>().ToList();
			return vl_PersonRoleList_o;
		}

		public bool InsertPersonRole(PersonRole_Model in_PersonRole_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonRole_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonRole_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdatePersonRole(PersonRole_Model in_PersonRole_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonRole_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonRole_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeletePersonRole(PersonRole_Model in_PersonRole_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonRole_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonRole_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* PersonStatus*/

		public List<PersonStatus_Model> SearchPersonStatus(Dictionary<string, object> parameterList_k)
		{
			List<PersonStatus_Model> vl_PersonStatusList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "PersonStatus_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonStatusList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonStatus_Model), vl_sqlcmd_o).Cast<PersonStatus_Model>().ToList();
			return vl_PersonStatusList_o;
		}


		public PersonStatus_Model GetPersonStatus(int in_PK_PersonStatus_i)
		{
			PersonStatus_Model vl_PersonStatus_Model_o = new PersonStatus_Model();
			List<PersonStatus_Model> vl_PersonStatus_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_PersonStatus_i", Parameter_Value = in_PK_PersonStatus_i , SqlDbType = SqlDbType.Int }
			};
			vl_sqlcmd_o.SQL_Name = "PersonStatus_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonStatus_List_o = vl_dataBinder_o.GetGenericModel(typeof(PersonStatus_Model), vl_sqlcmd_o).Cast<PersonStatus_Model>().ToList();
			if (vl_PersonStatus_List_o.Count > 0)
			{
				vl_PersonStatus_Model_o = vl_PersonStatus_List_o.First();
			}
			return vl_PersonStatus_Model_o;
		}

		public List<PersonStatus_Model> GetMultiPersonStatus(List<int> parameterList_k)
		{
			List<PersonStatus_Model> vl_PersonStatusList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "PersonStatus_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonStatusList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonStatus_Model), vl_sqlcmd_o).Cast<PersonStatus_Model>().ToList();
			return vl_PersonStatusList_o;
		}

		public bool InsertPersonStatus(PersonStatus_Model in_PersonStatus_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonStatus_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonStatus_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdatePersonStatus(PersonStatus_Model in_PersonStatus_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonStatus_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonStatus_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeletePersonStatus(PersonStatus_Model in_PersonStatus_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonStatus_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonStatus_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		/* PersonSession*/

		public List<PersonSession_Model> SearchPersonSession(Dictionary<string, object> parameterList_k)
		{
			List<PersonSession_Model> vl_PersonSessionList_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			foreach (KeyValuePair<string, object> parameter_o in parameterList_k ?? new Dictionary<string, object>())
			{
				SQLParameterModel tempParam_o = new SQLParameterModel { Parameter_Name = parameter_o.Key, Parameter_Value = parameter_o.Value };
				vl_paramList.Add(tempParam_o);
			}
			vl_sqlcmd_o.SQL_Name = "PersonSession_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonSessionList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonSession_Model), vl_sqlcmd_o).Cast<PersonSession_Model>().ToList();
			return vl_PersonSessionList_o;
		}


		public PersonSession_Model GetPersonSession(Guid in_PK_PersonSession_ID_s)
		{
			PersonSession_Model vl_PersonSession_Model_o = new PersonSession_Model();
			List<PersonSession_Model> vl_PersonSession_List_o = null;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>()
			{
				new SQLParameterModel { Parameter_Name = "PK_PersonSession_ID_s", Parameter_Value = in_PK_PersonSession_ID_s , SqlDbType = SqlDbType.UniqueIdentifier }
			};
			vl_sqlcmd_o.SQL_Name = "PersonSession_SELECT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonSession_List_o = vl_dataBinder_o.GetGenericModel(typeof(PersonSession_Model), vl_sqlcmd_o).Cast<PersonSession_Model>().ToList();
			if (vl_PersonSession_List_o.Count > 0)
			{
				vl_PersonSession_Model_o = vl_PersonSession_List_o.First();
			}
			return vl_PersonSession_Model_o;
		}

		public List<PersonSession_Model> GetMultiPersonSession(List<Guid> parameterList_k)
		{
			List<PersonSession_Model> vl_PersonSessionList_o = null;
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
			vl_sqlcmd_o.SQL_Name = "PersonSession_SELECT_COLLECTION";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_PersonSessionList_o = vl_dataBinder_o.GetGenericModel(typeof(PersonSession_Model), vl_sqlcmd_o).Cast<PersonSession_Model>().ToList();
			return vl_PersonSessionList_o;
		}

		public bool InsertPersonSession(PersonSession_Model in_PersonSession_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonSession_INSERT";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonSession_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool UpdatePersonSession(PersonSession_Model in_PersonSession_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonSession_UPDATE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonSession_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


		public bool DeletePersonSession(PersonSession_Model in_PersonSession_Model_o)
		{
			bool vl_success_z = false;
			DataBinder_BO vl_dataBinder_o = new DataBinder_BO();
			SQLCommandModel vl_sqlcmd_o = new SQLCommandModel();
			List<SQLParameterModel> vl_paramList = new List<SQLParameterModel>();
			vl_sqlcmd_o.SQL_Name = "PersonSession_DELETE";
			vl_sqlcmd_o.SQL_ParameterList = vl_paramList;
			vl_success_z = vl_dataBinder_o.InsertOrUpdateGenericModel(in_PersonSession_Model_o, vl_sqlcmd_o);
			return vl_success_z;
		}


	}
}