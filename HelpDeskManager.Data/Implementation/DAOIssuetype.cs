/*************************************************************
** Class generated by CodeTrigger, Version 4.8.6.1
** This class was generated on 9/16/2016 11:50:03 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace HelpDeskManager.Data
{
	public partial class DAOIssuetype : HelpDesk_BaseData
	{
		#region member variables
		protected Int32? _id;
		protected string _name;
		#endregion

		#region class methods
		public DAOIssuetype()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table Issuetype based on the primary key(s)
		///</Summary>
		///<returns>
		///DAOIssuetype
		///</returns>
		///<parameters>
		///Int32? id
		///</parameters>
		public static DAOIssuetype SelectOne(Int32? id)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Issuetype");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				DAOIssuetype retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOIssuetype();
					retObj._id					 = Convert.IsDBNull(dt.Rows[0]["id"]) ? (Int32?)null : (Int32?)dt.Rows[0]["id"];
					retObj._name					 = Convert.IsDBNull(dt.Rows[0]["name"]) ? null : (string)dt.Rows[0]["name"];
				}
				return retObj;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table Issuetype based on its primary key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_DeleteOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));

				command.ExecuteNonQuery();

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Insert a new row
		///This method saves a new object to the table Issuetype
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Insert()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_name?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_id					 = Convert.IsDBNull(command.Parameters["@id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@id"].Value;
				_name					 = Convert.IsDBNull(command.Parameters["@name"].Value) ? null : (string)command.Parameters["@name"].Value;

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows
		///This method returns all data rows in the table Issuetype
		///</Summary>
		///<returns>
		///IList-DAOIssuetype.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<DAOIssuetype> SelectAll()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Issuetype");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAOIssuetype> objList = new List<DAOIssuetype>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIssuetype retObj = new DAOIssuetype();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? (Int32?)null : (Int32?)row["id"];
						retObj._name					 = Convert.IsDBNull(row["name"]) ? null : (string)row["name"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 SelectAllCount()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_SelectAllCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();

				return retCount;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///IList-DAOIssuetype.
		///</returns>
		///<parameters>
		///DAOIssuetype daoIssuetype
		///</parameters>
		public static IList<DAOIssuetype> SelectAllBySearchFields(DAOIssuetype daoIssuetype)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_SelectAllBySearchFields;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Issuetype");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)daoIssuetype.Id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoIssuetype.Name?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAOIssuetype> objList = new List<DAOIssuetype>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOIssuetype retObj = new DAOIssuetype();
						retObj._id					 = Convert.IsDBNull(row["id"]) ? (Int32?)null : (Int32?)row["id"];
						retObj._name					 = Convert.IsDBNull(row["name"]) ? null : (string)row["name"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///DAOIssuetype daoIssuetype
		///</parameters>
		public static Int32 SelectAllBySearchFieldsCount(DAOIssuetype daoIssuetype)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_SelectAllBySearchFieldsCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)daoIssuetype.Id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, (object)daoIssuetype.Name?? (object)DBNull.Value));

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();

				return retCount;
			}
			catch
			{
				throw;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table Issuetype based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Update()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprIssuetype_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_name?? (object)DBNull.Value));

				command.ExecuteNonQuery();

				_id					 = Convert.IsDBNull(command.Parameters["@id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@id"].Value;
				_name					 = Convert.IsDBNull(command.Parameters["@name"].Value) ? null : (string)command.Parameters["@name"].Value;

			}
			catch
			{
				throw;
			}
			finally
			{
				command.Dispose();
			}
		}

		#endregion

		#region member properties

		public Int32? Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		#endregion
	}
}

#region inline sql procs
namespace HelpDeskManager.Data
{
	public partial class InlineProcs
	{
		internal static string ctprIssuetype_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[id]
			,[name]
			FROM [dbo].[Issuetype]
			WHERE 
			[id] = @id
			";

		internal static string ctprIssuetype_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[Issuetype]
			WHERE 
			[id] = @id
			";

		internal static string ctprIssuetype_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[Issuetype]
			(
			[name]
			)
			VALUES
			(
			@name
			)
			SELECT 
			@id = [id]
			,@name = [name]
			FROM [dbo].[Issuetype]
			WHERE 
			id = SCOPE_IDENTITY()
			";

		internal static string ctprIssuetype_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[id]
			,[name]
			FROM [dbo].[Issuetype]
			";

		internal static string ctprIssuetype_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Issuetype]
			";

		internal static string ctprIssuetype_SelectAllBySearchFields = @"
			
			-- selects all rows from the table according to search criteria
			SELECT 
			[id],
			[name]
			FROM [dbo].[Issuetype]
			WHERE 
			([id] LIKE @id OR @id is null)
			AND ([name] LIKE @name OR @name is null)
			";

		internal static string ctprIssuetype_SelectAllBySearchFieldsCount = @"
			-- Get count of rows returnable by this query
			-- selects count of all rows from the table according to search criteria
			SELECT COUNT(*)
			FROM [dbo].[Issuetype]
			WHERE 
			([id] LIKE @id OR @id is null)
			AND ([name] LIKE @name OR @name is null)
			";

		internal static string ctprIssuetype_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			UPDATE [dbo].[Issuetype]
			SET
			[name] = @name
			WHERE 
			[id] = @id
			SELECT 
			@id = [id]
			,@name = [name]
			FROM [dbo].[Issuetype]
			WHERE 
			[id] = @id
			";

	}
}
#endregion
