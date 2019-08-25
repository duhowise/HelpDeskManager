/*************************************************************
** Class generated by CodeTrigger, Version 4.8.6.1
** This class was generated on 9/16/2016 11:50:03 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using HelpDeskManager.Data;

namespace HelpDeskManager.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BORole.
	///It maintains a collection of BOTechnician objects.
	///</Summary>
	[DataContract]
	public partial class BORole : HelpDesk_BaseBusiness
	{
		#region member variables
		protected Int32? _id;
		protected string _name;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<BOTechnician> _boTechnicianCollection;
		/*********************************************/
		#endregion

		#region class methods
		///<Summary>
		///Constructor
		///This is the default constructor
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public BORole()
		{
		}

		///<Summary>
		///Constructor
		///Constructor using primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///Int32 id
		///</parameters>
		public BORole(Int32 id)
		{
			try
			{
				DAORole daoRole = DAORole.SelectOne(id);
				_id = daoRole.Id;
				_name = daoRole.Name;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///Constructor
		///This constructor initializes the business object from its respective data object
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///DAORole
		///</parameters>
		protected internal BORole(DAORole daoRole)
		{
			try
			{
				_id = daoRole.Id;
				_name = daoRole.Name;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Role record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void SaveNew()
		{
			DAORole daoRole = new DAORole();
			RegisterDataObject(daoRole);
			BeginTransaction("savenewBORole");
			try
			{
				daoRole.Name = _name;
				daoRole.Insert();
				CommitTransaction();
				
				_id = daoRole.Id;
				_name = daoRole.Name;
				_isDirty = false;
			}
			catch
			{
				RollbackTransaction("savenewBORole");
				throw;
			}
		}
		
		///<Summary>
		///Update
		///This method updates one Role record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BORole
		///</parameters>
		public virtual void Update()
		{
			DAORole daoRole = new DAORole();
			RegisterDataObject(daoRole);
			BeginTransaction("updateBORole");
			try
			{
				daoRole.Id = _id;
				daoRole.Name = _name;
				daoRole.Update();
				CommitTransaction();
				
				_id = daoRole.Id;
				_name = daoRole.Name;
				_isDirty = false;
			}
			catch
			{
				RollbackTransaction("updateBORole");
				throw;
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Role record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			DAORole daoRole = new DAORole();
			RegisterDataObject(daoRole);
			BeginTransaction("deleteBORole");
			try
			{
				daoRole.Id = _id;
				daoRole.Delete();
				CommitTransaction();
			}
			catch
			{
				RollbackTransaction("deleteBORole");
				throw;
			}
		}
		
		///<Summary>
		///RoleCollection
		///This method returns the collection of BORole objects
		///</Summary>
		///<returns>
		///List[BORole]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<BORole> RoleCollection()
		{
			try
			{
				IList<BORole> boRoleCollection = new List<BORole>();
				IList<DAORole> daoRoleCollection = DAORole.SelectAll();
			
				foreach(DAORole daoRole in daoRoleCollection)
					boRoleCollection.Add(new BORole(daoRole));
			
				return boRoleCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///RoleCollectionCount
		///This method returns the collection count of BORole objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 RoleCollectionCount()
		{
			try
			{
				Int32 objCount = DAORole.SelectAllCount();
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///RoleCollectionFromSearchFields
		///This method returns the collection of BORole objects, filtered by a search object
		///</Summary>
		///<returns>
		///List<BORole>
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<BORole> RoleCollectionFromSearchFields(BORole boRole)
		{
			try
			{
				IList<BORole> boRoleCollection = new List<BORole>();
				DAORole daoRole = new DAORole();
				daoRole.Id = boRole.Id;
				daoRole.Name = boRole.Name;
				IList<DAORole> daoRoleCollection = DAORole.SelectAllBySearchFields(daoRole);
			
				foreach(DAORole resdaoRole in daoRoleCollection)
					boRoleCollection.Add(new BORole(resdaoRole));
			
				return boRoleCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///RoleCollectionFromSearchFieldsCount
		///This method returns the collection count of BORole objects, filtered by a search object
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 RoleCollectionFromSearchFieldsCount(BORole boRole)
		{
			try
			{
				DAORole daoRole = new DAORole();
				daoRole.Id = boRole.Id;
				daoRole.Name = boRole.Name;
				Int32 objCount = DAORole.SelectAllBySearchFieldsCount(daoRole);
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		///<Summary>
		///TechnicianCollection
		///This method returns its collection of BOTechnician objects
		///</Summary>
		///<returns>
		///IList[BOTechnician]
		///</returns>
		///<parameters>
		///BORole
		///</parameters>
		public virtual IList<BOTechnician> TechnicianCollection()
		{
			try
			{
				if(_boTechnicianCollection == null)
					LoadTechnicianCollection();
				
				return _boTechnicianCollection.AsReadOnly();
			}
			catch
			{
				throw;
			}
		}
		
		///<Summary>
		///LoadTechnicianCollection
		///This method loads the internal collection of BOTechnician objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadTechnicianCollection()
		{
			try
			{
				_boTechnicianCollection = new List<BOTechnician>();
				IList<DAOTechnician> daoTechnicianCollection = DAOTechnician.SelectAllByRoleid(_id.Value);
				
				foreach(DAOTechnician daoTechnician in daoTechnicianCollection)
					_boTechnicianCollection.Add(new BOTechnician(daoTechnician));
			}
			catch
			{
				throw;
			}
		}
		
		///<Summary>
		///AddTechnician
		///This method persists a BOTechnician object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOTechnician
		///</parameters>
		public virtual void AddTechnician(BOTechnician boTechnician)
		{
			DAOTechnician daoTechnician = new DAOTechnician();
			RegisterDataObject(daoTechnician);
			BeginTransaction("addTechnician");
			try
			{
				daoTechnician.Id = boTechnician.Id;
				daoTechnician.Name = boTechnician.Name;
				daoTechnician.Designationid = boTechnician.Designationid;
				daoTechnician.Roleid = _id.Value;
				daoTechnician.Insert();
				CommitTransaction();
				
				/*pick up any primary keys, computed values etc*/
				boTechnician = new BOTechnician(daoTechnician);
				if(_boTechnicianCollection != null)
					_boTechnicianCollection.Add(boTechnician);
			}
			catch
			{
				RollbackTransaction("addTechnician");
				throw;
			}
		}
		
		///<Summary>
		///DeleteAllTechnician
		///This method deletes all BOTechnician objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllTechnician()
		{
			RegisterDataObject(null);
			BeginTransaction("deleteAllTechnician");
			try
			{
				DAOTechnician.DeleteAllByRoleid(ConnectionProvider, _id.Value);
				CommitTransaction();
				if(_boTechnicianCollection != null)
				{
					_boTechnicianCollection.Clear();
					_boTechnicianCollection = null;
				}
			}
			catch
			{
				RollbackTransaction("deleteAllTechnician");
				throw;
			}
		}
		
		#endregion

		#region member properties
		
		[DataMember]
		public virtual Int32? Id
		{
			get
			{
				 return _id;
			}
			set
			{
				_id = value;
				_isDirty = true;
			}
		}
		
		[DataMember]
		public virtual string Name
		{
			get
			{
				 return _name;
			}
			set
			{
				_name = value;
				_isDirty = true;
			}
		}
		
		[DataMember]
		public virtual object Repository
		{
			get {	return null;	}
			set	{	}
		}
		
		[DataMember]
		public virtual bool IsDirty
		{
			get
			{
				 return _isDirty;
			}
			set
			{
				_isDirty = value;
			}
		}
		#endregion
	}
}