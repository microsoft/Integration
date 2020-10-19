using System;
using System.Reflection;
using System.Resources;

namespace Microsoft.Solutions.FinancialServices.SWIFT.ValidationMessages
{
	/// <summary>
	/// Summary description for ErrorResources.
	/// </summary>
	public sealed class ErrorResources
	{
		private static ResourceManager m_resManager = null;

		#region Private Constructor
		private ErrorResources()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static ResourceManager ResourceMgr
		{
			get
			{
				if(m_resManager == null)
				{
					Assembly assembly = Assembly.GetAssembly(typeof(ErrorResources));
					m_resManager =  new ResourceManager("ErrorResources",assembly);
				}
				
				return m_resManager;
			}
		}
	}
}
