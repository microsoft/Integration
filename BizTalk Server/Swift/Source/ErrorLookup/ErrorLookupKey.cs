// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace Microsoft.Solutions.FinancialServices.SWIFT.ValidationMessages
{
	//ENH045
	public sealed class ErrorLookupKey
	{
		private string errorSource;
		private string messageType;
		private string swiftTagName;
		private string swiftFieldName;
		private string swiftErrorCode;

		private const char seperator = '_';
		private const string xmlKeyPrefix = "X_";			// Prefix all XML validation error's key with X_
		private const string breKeyPrefix = "B_";			// Prefix all XML validation error's key with B_
		private const string genericKeyindicator = "MTXXX";

		// constructor for xml validation errors...
		public ErrorLookupKey(string msgType, string swiftTag, string swiftField)
		{
			errorSource = xmlKeyPrefix;
			messageType = msgType;
			swiftTagName = swiftTag;
			swiftFieldName = swiftField;
			swiftErrorCode = null;
		}

		// constructor for BRE validation errors...
		public ErrorLookupKey(string errorCode)
		{
			errorSource = breKeyPrefix;
			swiftErrorCode = errorCode;
			swiftTagName = null;
			swiftFieldName = null;
			messageType = null;
			
		}
		
		public string GenerateKey(bool isForSpecificMessageType)
		{
			if (errorSource == xmlKeyPrefix)
			{
				if (isForSpecificMessageType)
				{
					//Returns the key for specific message type for XML Validation error
					return xmlKeyPrefix + messageType + seperator + swiftTagName + seperator + swiftFieldName;
				}
				else
				{
					//returns the generalized key for XML Validation error
					return xmlKeyPrefix + genericKeyindicator + seperator + swiftTagName + seperator + swiftFieldName;
				}
			}
			else
			{
				//returns the key for BRE error for XML Validation error
				return breKeyPrefix + swiftErrorCode;
			}
		}
	}
	//END - ENH045
}
