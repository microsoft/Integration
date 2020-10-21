// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

#region Namespaces

using System;
using System.Resources;
using System.Globalization;
using System.Reflection;
using System.Drawing;

#endregion

namespace Microsoft.Solutions.FinancialServices.SWIFT
{
    //=========================================================================
	/// <summary>
	/// StringResources class.
	/// </summary>
    //=========================================================================

	sealed public class StringResources
	{
		//
		//  Public string declarations.
		//


		//=========================================================================
		// Declare commonly used strings for all assemblies here..
		//=========================================================================
		/// <summary>
		/// static or constant string
		/// </summary>
		/// 
		//=========================================================================
		//
		//  Internal class members. The ResourceStrings class makes an assumption that
		//  the resource files (RESX) are compilied into the same assembly (Shared.dll)
		//  as it (ResourceStrings). If the resx files are moved to another assembly 
		//  this will not work.
		//
		//=========================================================================

		private static  ResourceManager resxManager = null;

		//=====================================================================
		/// <summary>
		/// Note: Static class constructor - called ONLY once by the CLR
		/// </summary>
		//=====================================================================

		static StringResources()
		{
			StringResources.resxManager = StringResources.LoadResourceManager("A4SWIFTResources");
		}

		public static ResourceManager ResManager
		{
			get
			{
				return resxManager;
			}
		}
		

        //=====================================================================
		/// <summary>
		/// Retrieves the localized resource string frim the .resx file. 
		/// </summary>
		/// <param name="resourceKey"></param>
		/// <returns></returns>
        //=====================================================================

		public static string GetString(string resourceKey)
        {
            return StringResources.resxManager.GetString( resourceKey, CultureInfo.CurrentUICulture );
        }

		public static Bitmap GetResourceBitmap(string resourcekey)
		{
			object obj = StringResources.resxManager.GetObject(resourcekey);
			Bitmap bitmap = (Bitmap)obj;

			return bitmap;
		}
        //=====================================================================
        //	Method: LoadResourceManager
        //
        /// <summary>
        /// 
        /// This method loads up an instacne of the resource manager for our assembly.
        /// 
        /// <param name="resourceFilename"></param>
        /// <returns></returns>
        /// </summary>
        //=====================================================================

		private static ResourceManager LoadResourceManager(string resourceFilename)
        {
            ResourceManager localResMan = null;

            //
            //  Load up our resource manager object. This code makes the assumption
            //  the resources (RESX) files are in the same assembly as this class.
            //

            Assembly assembly = Assembly.GetAssembly(typeof(StringResources));
			localResMan = new ResourceManager(resourceFilename, assembly);
			if (localResMan == null)
			{
				//
				// NOTE: this error message cannot be localized since it is to notify loading of resource manager itself!!
				//
				throw new ApplicationException("Cannot initialize Resource Manager for Microsoft.Solutions.FinancialServices.SWIFT.Shared assembly.");
			}

            return localResMan;
        }
    }
}
