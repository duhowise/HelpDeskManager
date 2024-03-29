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
	public partial class DAORole : HelpDesk_BaseData
	{
		#region member variables
		protected Int32? _id;
		protected string _name;
		#endregion

		#region class methods
		public DAORole()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table role based on the primary key(s)
		///</Summary>
		///<returns>
		///DAORole
		///</returns>
		///<parameters>
		///Int32? id
		///</parameters>
		public static DAORole SelectOne(Int32? id)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprrole_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("role");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				DAORole retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAORole();
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
		///this method allows the object to delete itself from the table role based on its primary key
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
			command.CommandText = InlineProcs.ctprrole_DeleteOne;
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
		///This method saves a new object to the table role
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
			command.CommandText = InlineProcs.ctprrole_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_name?? (object)DBNull.Value));

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
		///This method returns all data rows in the table role
		///</Summary>
		///<returns>
		///IList-DAORole.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<DAORole> SelectAll()
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprrole_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("role");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAORole> objList = new List<DAORole>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAORole retObj = new DAORole();
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
			command.CommandText = InlineProcs.ctprrole_SelectAllCount;
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
		///IList-DAORole.
		///</returns>
		///<parameters>
		///DAORole daoRole
		///</parameters>
		public static IList<DAORole> SelectAllBySearchFields(DAORole daoRole)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprrole_SelectAllBySearchFields;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("role");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)daoRole.Id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)daoRole.Name?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);

				List<DAORole> objList = new List<DAORole>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAORole retObj = new DAORole();
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
		///DAORole daoRole
		///</parameters>
		public static Int32 SelectAllBySearchFieldsCount(DAORole daoRole)
		{
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprrole_SelectAllBySearchFieldsCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)daoRole.Id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, (object)daoRole.Name?? (object)DBNull.Value));

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
		///This method allows the object to update itself in the table role based on its primary key(s)
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
			command.CommandText = InlineProcs.ctprrole_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 255, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_name?? (object)DBNull.Value));

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
		internal static string ctprrole_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[id]
			,[name]
			FROM [dbo].[role]
			WHERE 
			[id] = @id
			";

		internal static string ctprrole_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[role]
			WHERE 
			[id] = @id
			";

		internal static string ctprrole_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[role]
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
			FROM [dbo].[role]
			WHERE 
			id = SCOPE_IDENTITY()
			";

		internal static string ctprrole_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[id]
			,[name]
			FROM [dbo].[role]
			";

		internal static string ctprrole_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[role]
			";

		internal static string ctprrole_SelectAllBySearchFields = @"
			
			-- selects all rows from the table according to search criteria
			SELECT 
			[id],
			[name]
			FROM [dbo].[role]
			WHERE 
			([id] LIKE @id OR @id is null)
			AND ([name] LIKE @name OR @name is null)
			";

		internal static string ctprrole_SelectAllBySearchFieldsCount = @"
			-- Get count of rows returnable by this query
			-- selects count of all rows from the table according to search criteria
			SELECT COUNT(*)
			FROM [dbo].[role]
			WHERE 
			([id] LIKE @id OR @id is null)
			AND ([name] LIKE @name OR @name is null)
			";

		internal static string ctprrole_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			UPDATE [dbo].[role]
			SET
			[name] = @name
			WHERE 
			[id] = @id
			SELECT 
			@id = [id]
			,@name = [name]
			FROM [dbo].[role]
			WHERE 
			[id] = @id
			";

	}
}
#endregion
