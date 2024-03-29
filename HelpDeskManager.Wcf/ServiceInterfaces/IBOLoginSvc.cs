/*************************************************************
** Class generated by CodeTrigger, Version 4.8.6.1
** This class was generated on 9/16/2016 11:50:03 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HelpDeskManager.Business;

namespace HelpDeskManager.Wcf
{
	#region BOLoginSvc Interface
	[ServiceContract]
	public partial interface IBOLoginSvc
	{
		///<Summary>
		///GetBOLogin
		///This method returns one BOLogin object by primary key
		///</Summary>
		///<returns>
		///BOLogin
		///</returns>
		///<parameters>
		///Int32 id
		///</parameters>
		[OperationContract]
		BOLogin GetLogin(Int32 id);

		///<Summary>
		///SaveNewLogin
		///This method saves one Login record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		[OperationContract]
		void SaveNewLogin(BOLogin boLogin);

		///<Summary>
		///Update
		///This method updates one Login record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOLogin
		///</parameters>
		[OperationContract]
		void UpdateLogin(BOLogin boLogin);

		///<Summary>
		///Delete
		///This method deletes one Login record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		[OperationContract]
		void DeleteLogin(Int32 id);

		///<Summary>
		///LoginCollection
		///This method returns the population of BOLogin objects
		///</Summary>
		///<returns>
		///IList[BOLogin]
		///</returns>
		///<parameters>
		///BOLogin
		///</parameters>
		[OperationContract]
		IList<BOLogin> LoginCollection();
		
		///<Summary>
		///LoginCollectionCount
		///This method returns a count of the population of BOLogin objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		[OperationContract]
		Int32 LoginCollectionCount();
		
		///<Summary>
		///LoginCollectionFromSearchFields
		///This method returns a collection of BOLogin objects, based on search fields
		///</Summary>
		///<returns>
		///IList[BOLogin]
		///</returns>
		///<parameters>
		///BOLogin
		///</parameters>
		[OperationContract]
		IList<BOLogin> LoginCollectionFromSearchFields(BOLogin boLogin);
		
		///<Summary>
		///LoginCollectionFromSearchFieldsCount
		///This method returns a count of its collection of BOLogin objects, based on search fields
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///BOLogin
		///</parameters>
		[OperationContract]
		Int32 LoginCollectionFromSearchFieldsCount(BOLogin boLogin);
		

	}
	#endregion

}
