using System;
using System.Reflection;
using System.Resources;
using System.Diagnostics;

namespace Microsoft.Solutions.FinancialServices.SWIFT.ValidationMessages
{
	/// <summary>
	/// Summary description for ErrorLookupMessage.
	/// </summary>
	public sealed class ErrorLookupMessage
	{
		#region private constructor
		private ErrorLookupMessage()
		{
		}
		#endregion

		/// <summary>
		/// gets the XML Validation error message from resource lookup
		/// </summary>
		/// <param name="key">Key as a combination of message type,
		/// parent tag name & field name</param>
		/// <returns>the error message from lookup</returns>
		public static string LookupXmlValidationError(string key)
		{
			string err = string.Empty;
			try
			{
				err = ErrorResources.ResourceMgr.GetString(key);
			}
			catch(Exception e)
			{
				Debug.WriteLine("[LookUpErrorMsg] Error While Fetching the XML Validation Error Message from lookup " + e.Message);
			}
			return err;
		}
	
		/// <summary>
		/// gets the BRE Error message from the resource lookup
		/// </summary>
		/// <param name="errorCode">the BRE error's code</param>
		/// <returns>the error message from lookup</returns>
		public static string LookupBREValidationError(string key)
		{
			string err = string.Empty;
			try
			{
				err = ErrorResources.ResourceMgr.GetString(key);
			}
			catch(Exception e)
			{
				Debug.WriteLine("[LookUpErrorMsg] Error While Fetching the BRE Error Message from lookup" + e.Message);
			}
			return err;
		}
	}


}
