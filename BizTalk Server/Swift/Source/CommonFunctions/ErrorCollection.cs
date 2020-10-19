///////////////////////////////////////////////////////////////////////////////
//
// Copyright (C) 2003 Microsoft Corporation.  All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
///////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Resources;
using System.Globalization;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Reflection;
using Microsoft.Solutions.FinancialServices.SWIFT.ValidationMessages ; //ENH045 - Namespace for ErrorLookUp dll.


namespace Microsoft.Solutions.FinancialServices.SWIFT
{	
	/// <summary>
	/// This class holds error details for a single SWIFT error
	/// </summary>
	/// <remarks>
	/// Class collects all the error details as a single unit
	/// </remarks>
	/// 
	[Serializable()]
	public sealed class ValidationError
	{
		
		private string errorCode;
		private string ruleName;
		private string policyName;
		private string messageType;
		private string sequenceName;
		private string elementName;		
		private string elementValue;
		private string conditionalRuleName;
 	    private string conditionalRuleNumber;

		public ValidationError()
		{
			messageType = null;
			errorCode = null;
			elementName = null;
			sequenceName = null;
			elementValue = null;	
	 		ruleName = null;
			policyName = null;
			conditionalRuleName = null;
			conditionalRuleNumber = null;

		}		

		public string MessageType
		{
			set
			{
				messageType = value;
			}

			get
			{
				return messageType;
			}
		}

		public string ErrorCode
		{
			set
			{
				errorCode = value;
			}

			get
			{
				return errorCode;
			}
		}

		public string ElementName
		{
			set
			{
				elementName = value;
			}

			get
			{
				return elementName;
			}
		}

		public string SequenceName
		{
			set
			{
				sequenceName = value;
			}

			get
			{
				return sequenceName;
			}
		}

		public string ElementValue
		{
			set
			{
				elementValue = value;
			}

			get
			{
				return elementValue;
			}
		}

		public string RuleName
		{
			set
			{
				ruleName = value;
			}

			get
			{
				return ruleName;
			}
		}

		public string PolicyName
		{
			set
			{
				policyName = value;
			}

			get
			{
				return policyName;
			}
		}

		public string ConditionalRuleName
		{
			set
			{
				conditionalRuleName = value;
			}

			get
			{
				return conditionalRuleName;
			}
		}

		public string ConditionalRuleNumber
		{
			set
			{
				conditionalRuleNumber = value;
			}

			get
			{
				return conditionalRuleNumber;
			}
		}
		
	}

	// Moving the error classes from A4SWIFTError.cs to here
	[Serializable()]
	public abstract class ErrorBase
	{
		string message = string.Empty;

		protected ErrorBase()
		{
		}

		protected ErrorBase(string message)
		{
			this.message = message;
		}

		public string Message
		{
			set
			{
				message = value;
			}
			get
			{
				return message;
			}
		}

		public abstract void GetXml(XmlTextWriter xmlwr);
	}

    [Serializable()]
	public sealed class ParseError : ErrorBase
	{
		private string exceptionType = string.Empty;
		private int lineNumber;
		private int linePosition;
		private bool isEmptyLineError;
		private string schemaName = string.Empty;		

		#region properties
		public string ExceptionType
		{
			get
			{
				return exceptionType;
			}
			set
			{
				exceptionType = value;
			}
		}

		public int LineNumber
		{
			get
			{
				return lineNumber;
			}
			set
			{
				lineNumber = value;
			}
		}

		public int LinePosition
		{
			get
			{
				return linePosition;
			}
			set
			{
				linePosition = value;
			}
		}

		public bool IsMultipleEmptyLines
		{
			get
			{
				return isEmptyLineError;
			}

			set
			{
				isEmptyLineError = value;
			}
		}

		public string SchemaName
		{
			get
			{
				return schemaName;
			}

			set
			{
				// NOTE: We can enforce the naming here
				schemaName = value;
			}
		}

		new public string Message
		{
			set
			{
				base.Message = value;
			}
			get
			{
				return base.Message;
			}
		}

		#endregion

		public ParseError(string exceptionType, string schemaName, string message) : base(message)
		{
			this.exceptionType = exceptionType;
			this.schemaName = schemaName;
		}

		public ParseError(string message) : base(message)
		{
		}

		public ParseError()
		{
		}

		public override void GetXml(XmlTextWriter xmlwr)
		{
            if (null == xmlwr) throw new ArgumentNullException("xmlwr");
			xmlwr.WriteStartElement("ParseError");
			xmlwr.WriteAttributeString("ExceptionType", exceptionType);
			xmlwr.WriteAttributeString("LineNumber", lineNumber.ToString(CultureInfo.InvariantCulture));
			xmlwr.WriteAttributeString("LinePosition", linePosition.ToString(CultureInfo.InvariantCulture));
			xmlwr.WriteAttributeString("MultipleEmptyLines", isEmptyLineError.ToString());
			xmlwr.WriteAttributeString("SchemaName", schemaName);
			xmlwr.WriteElementString("Message", base.Message);
			xmlwr.WriteEndElement();
		}

		internal static ParseError FromXml(XmlTextReader xmlr)
		{
			// This may be a redundant check if you are calling from Deserializer 
			// but this is needed if some body calls this as an API
			if (xmlr == null)
			{
				Debug.WriteLine("[ParseError.FromXml()] The argument XmlTextReader is null");
				throw new ArgumentNullException("xmlr");
			}

			bool bContinue = true;
			ParseError pError = new ParseError();


			if (xmlr.HasAttributes == true)
			{
				for (int indx = 0; indx < xmlr.AttributeCount; indx++)
				{
					xmlr.MoveToAttribute(indx);
					if (xmlr.Name == "ExceptionType")
					{
						pError.ExceptionType = xmlr.Value;
					}
					else if (xmlr.Name == "LineNumber")
					{
                        pError.LineNumber = Int32.Parse(xmlr.Value, CultureInfo.InvariantCulture);
					}
					else if (xmlr.Name == "LinePosition")
					{
                        pError.LinePosition = Int32.Parse(xmlr.Value, CultureInfo.InvariantCulture);
					}
					else if (xmlr.Name == "MultipleEmptyLines")
					{
						pError.IsMultipleEmptyLines = bool.Parse(xmlr.Value);
					}
					else if (xmlr.Name == "SchemaName")
					{
						pError.SchemaName = xmlr.Value;
					}
				}
			}

			try
			{
				while (bContinue && (xmlr.Read() != false))
				{
					switch (xmlr.NodeType)
					{
						case XmlNodeType.Element:
							if (xmlr.Name == "Message")
							{
								pError.Message = xmlr.ReadString();
							}
							break;
						case XmlNodeType.EndElement:
							if (xmlr.Name == "ParseError")
							{
								bContinue = false;
							}
							break;
					}
				}
			}
			catch(XmlException e)
			{
				Debug.WriteLine("[ParseError.FromXml()] Xml Parsing error");
				pError = null;
				throw e;
			}

			return pError;
		}
	}

	[Serializable()]
	public sealed class XmlValidationError : ErrorBase
	{
		private string exceptionType = string.Empty;
		private int lineNumber;
		private int linePosition;
		private string schemaName = string.Empty;		
		private XmlSeverityType severity;
		

		public XmlValidationError(string type, string schemaName, string message) : base(message)
		{
			exceptionType = type;
			this.schemaName = schemaName;
		}

		public XmlValidationError(string message) : base(message)
		{
		}

		public XmlValidationError()
		{
		}

		#region properties
		public string ExceptionType
		{
			get
			{
				return exceptionType;
			}
			set
			{
				exceptionType = value;
			}
		}

		public int LineNumber
		{
			get
			{
				return lineNumber;
			}
			set
			{
				lineNumber = value;
			}
		}

		public int LinePosition
		{
			get
			{
				return linePosition;
			}
			set
			{
				linePosition = value;
			}
		}

		public string SchemaName
		{
			get
			{
				return schemaName;
			}

			set
			{
				// NOTE: We can enforce the naming here
				schemaName = value;
			}
		}

		public XmlSeverityType Severity
		{
			get
			{
				return severity;
			}
			set
			{
				severity = value;
			}
		}

		new public string Message
		{
			set
			{
				base.Message = value;
			}
			get
			{
				return base.Message;
			}
		}

		#endregion

		public override void GetXml(XmlTextWriter xmlwr)
		{
            if (null == xmlwr) throw new ArgumentNullException("xmlwr");
			xmlwr.WriteStartElement("XmlValidationError");
			xmlwr.WriteAttributeString("ExceptionType", exceptionType);
			xmlwr.WriteAttributeString("LineNumber", lineNumber.ToString(CultureInfo.InvariantCulture));			
			xmlwr.WriteAttributeString("LinePosition", linePosition.ToString(CultureInfo.InvariantCulture));
			xmlwr.WriteAttributeString("SchemaName", schemaName);
			xmlwr.WriteAttributeString("Severity", 
				(severity == XmlSeverityType.Error) ? "Error" : "Warning");
			xmlwr.WriteElementString("Message", base.Message);
			xmlwr.WriteEndElement();
		}

		internal static XmlValidationError FromXml(XmlTextReader xmlr)
		{
			// This may be a redundant check if you are calling from Deserializer 
			// but this is needed if some body calls this as an API
			if (xmlr == null)
			{
				Debug.WriteLine("[XmlValidationError.FromXml()] The argument XmlTextReader is null");
				throw new ArgumentNullException("xmlr");
			}

			bool bContinue = true;
			XmlValidationError vError = new XmlValidationError();

			if (xmlr.HasAttributes == true)
			{
				for (int indx = 0; indx < xmlr.AttributeCount; indx++)
				{
					xmlr.MoveToAttribute(indx);
					if (xmlr.Name == "ExceptionType")
					{
						vError.ExceptionType = xmlr.Value;
					}
					else if (xmlr.Name == "LineNumber")
					{
                        vError.LineNumber = Int32.Parse(xmlr.Value, CultureInfo.InvariantCulture);
					}
					else if (xmlr.Name == "LinePosition")
					{
                        vError.LinePosition = Int32.Parse(xmlr.Value, CultureInfo.InvariantCulture);
					}
					else if (xmlr.Name == "Severity")
					{
						vError.Severity = 
							(xmlr.Value == "Error") ? XmlSeverityType.Error : XmlSeverityType.Warning;
					}
					else if (xmlr.Name == "SchemaName")
					{
						vError.SchemaName = xmlr.Value;
					}
				}
			}

			try
			{
				while (bContinue && (xmlr.Read() != false))
				{
					switch (xmlr.NodeType)
					{
						case XmlNodeType.Element:
							if (xmlr.Name == "Message")
							{
								vError.Message = xmlr.ReadString();
							}
							break;

						case XmlNodeType.EndElement:
							if (xmlr.Name == "XmlValidationError")
							{
								bContinue = false;
							}
							break;
					}
				}
			}
			catch(XmlException e)
			{
				Debug.WriteLine("[XmlValidationError.FromXml()] Xml Parsing error");
				vError = null;
				throw e;
			}

			return vError;
		}
	}

    [Serializable()]
	public sealed class BreValidationError : ErrorBase
	{				
		private string errorCode;
		private string ruleName;
		private string policyName;
		private string messageType;
		private string sequenceName;
		private string elementName;		
		private string elementValue;
		private string conditionalRuleName;
		private string conditionalRuleNumber;		
		private string errorMessage;//ENH045 - to store BRE error messages

		public string MessageType
		{
			set
			{
				messageType = value;
			}

			get
			{
				return messageType;
			}
		}

		public string ErrorCode
		{
			set
			{
				errorCode = value;
			}

			get
			{
				return errorCode;
			}
		}

		public string ElementName
		{
			set
			{
				elementName = value;
			}

			get
			{
				return elementName;
			}
		}

		public string SequenceName
		{
			set
			{
				sequenceName = value;
			}

			get
			{
				return sequenceName;
			}
		}

		public string ElementValue
		{
			set
			{
				elementValue = value;
			}

			get
			{
				return elementValue;
			}
		}

		public string RuleName
		{
			set
			{
				ruleName = value;
			}

			get
			{
				return ruleName;
			}
		}

		public string PolicyName
		{
			set
			{
				policyName = value;
			}

			get
			{
				return policyName;
			}
		}

		public string ConditionalRuleName
		{
			set
			{
				conditionalRuleName = value;
			}

			get
			{
				return conditionalRuleName;
			}
		}

		public string ConditionalRuleNumber
		{
			set
			{
				conditionalRuleNumber = value;
			}

			get
			{
				return conditionalRuleNumber;
			}
		}	
		
		//ENH045
		public string ErrorMessage
		{
			set
			{
				errorMessage = value;
			}

			get
			{
				return errorMessage;
			}
		}
		//END - ENH045			


		public void AddError(ValidationError err)
		{
			if (err != null)
			{
				//ENH045
				// Instantiate the ErrorLookupKey class for BRE Error key
				ErrorLookupKey errLookupKey = new ErrorLookupKey(err.ErrorCode);
				
				//gets the key from ErrorLookup key class as 'B_ErrorCode'
				string key = errLookupKey.GenerateKey(true);

				//gets the error message from lookup class
				string errorMsg = ErrorLookupMessage.LookupBREValidationError(key);

				//Sets the error message
				errorMessage = errorMsg;
				//END - ENH045
					
				messageType = err.MessageType;
				errorCode = err.ErrorCode;
				elementName = err.ElementName;
				sequenceName = err.SequenceName;
				elementValue = err.ElementValue;	
				ruleName = err.RuleName;
				policyName = err.PolicyName;
				conditionalRuleName = err.ConditionalRuleName;
				conditionalRuleNumber = err.ConditionalRuleNumber;				
				//reassignment for specific codes "A4SWIFT001" & "A4SWIFT002"
				if (errorCode == "A4SWIFT001" || errorCode == "A4SWIFT002")
				{
					if (null == elementName)
						errorMessage = "'" + conditionalRuleName + "', " + errorMessage;
					else
						errorMessage = "'" + elementName + "', " + errorMessage;
				}				
			}					
		}


		public BreValidationError() : base("Error during Bre Validation")
		{			
			messageType = string.Empty;
			errorCode = string.Empty;
			elementName = string.Empty;
			sequenceName = string.Empty;
			elementValue = string.Empty;	
			ruleName = string.Empty;
			policyName = string.Empty;
			conditionalRuleName = string.Empty;
			conditionalRuleNumber = string.Empty;
		}

		public BreValidationError(ValidationError err) : base("Error during Bre Validation")
		{			
			if (err != null)
			{
				AddError(err);
			}
		}

		public override void GetXml(XmlTextWriter xmlwr)
		{
            if (null == xmlwr) throw new ArgumentNullException("xmlwr");

			xmlwr.WriteStartElement("BreValidationError");
			xmlwr.WriteAttributeString("MessageType", messageType);
			xmlwr.WriteAttributeString("ErrorCode", errorCode);			
			xmlwr.WriteStartElement("ElementName");
			xmlwr.WriteAttributeString("Name", elementName);
			xmlwr.WriteEndElement();

			xmlwr.WriteStartElement("SequenceName");
			xmlwr.WriteAttributeString("Name", sequenceName);
			xmlwr.WriteEndElement();

			xmlwr.WriteStartElement("ElementValue");
			xmlwr.WriteAttributeString("Value", elementValue);
			xmlwr.WriteEndElement();

			xmlwr.WriteStartElement("RuleName");
			xmlwr.WriteAttributeString("Name", ruleName);
			xmlwr.WriteEndElement();

			xmlwr.WriteStartElement("PolicyName");
			xmlwr.WriteAttributeString("Name", policyName);
			xmlwr.WriteEndElement();

			xmlwr.WriteStartElement("ConditionalRuleName");
			xmlwr.WriteAttributeString("RuleName", conditionalRuleName);
			xmlwr.WriteEndElement();

			xmlwr.WriteStartElement("ConditionalRuleNumber");
			xmlwr.WriteAttributeString("RuleNumber", conditionalRuleNumber);
			xmlwr.WriteEndElement();
			
			//ENH045 - Adding the error message in errors XML.
			xmlwr.WriteStartElement("ErrorMessage");
			xmlwr.WriteAttributeString("Message", errorMessage);
			xmlwr.WriteEndElement();
			//END - ENH045

			xmlwr.WriteEndElement();							
		}

		internal static BreValidationError FromXml(XmlTextReader xmlr)
		{			
			// This may be a redundant check if you are calling from Deserializer 
			// but this is needed if some body calls this as an API
			if (xmlr == null)
			{
				Debug.WriteLine("[BreValidationError.FromXml()] The argument XmlTextReader is null");
				throw new ArgumentNullException("xmlr");
			}

			bool bContinue = true;
			BreValidationError bError = new BreValidationError();			

			if (xmlr.HasAttributes == true)
			{
				for (int indx = 0; indx < xmlr.AttributeCount; indx++)
				{
					xmlr.MoveToAttribute(indx);
					if (xmlr.Name == "MessageType")
					{
						bError.MessageType = xmlr.Value;
					}
					else if (xmlr.Name == "ErrorCode")
					{
						bError.ErrorCode = xmlr.Value;
					}
				}
			}

			while (bContinue && (xmlr.Read() != false))
			{
				switch (xmlr.NodeType)
				{
					case XmlNodeType.Element:
						if (xmlr.Name == "ElementName")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "Name")
									{
										bError.ElementName = xmlr.Value;
									}
								}
							}
						}
						else if (xmlr.Name == "SequenceName")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "Name")
									{
										bError.SequenceName = xmlr.Value;
									}
								}
							}
						}
						else if (xmlr.Name == "ElementValue")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "Value")
									{
										bError.ElementValue = xmlr.Value;
									}
								}
							}
						}
						if (xmlr.Name == "RuleName")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "Name")
									{
										bError.RuleName = xmlr.Value;
									}
								}
							}
						}
						if (xmlr.Name == "PolicyName")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "Name")
									{
										bError.PolicyName = xmlr.Value;
									}
								}
							}
						}						
						else if (xmlr.Name == "ConditionalRuleName")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "RuleName")
									{
										bError.ConditionalRuleName = xmlr.Value;
									}
								}
							}
						}
						else if (xmlr.Name == "ConditionalRuleNumber")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "RuleNumber")
									{
										bError.ConditionalRuleNumber = xmlr.Value;
									}
								}
							}
						}
						//ENH045 - Getting the error message from ErrorXML.
						else if (xmlr.Name == "ErrorMessage")
						{
							if (xmlr.HasAttributes)
							{								
								for (int indx = 0; indx < xmlr.AttributeCount; indx++)
								{
									xmlr.MoveToAttribute(indx);
									if (xmlr.Name == "Message")
									{
										bError.ErrorMessage = xmlr.Value;
									}
								}
							}
						}
						//END - ENH045
						break;

					case XmlNodeType.EndElement:
						if (xmlr.Name == "BreValidationError")
						{
							bContinue = false;
						}
						break;
				}
			}
           			
			return bError;
		}
	}

	/// <summary>
	/// Summary description for ErrorCollector object.
	/// </summary>
	/// <remarks>
	/// Class collects all the errors and returns a collection object 
	/// containing all the errors
	/// </remarks>
	
	[Serializable()]
	public sealed class ErrorCollection : ICollection,ISerializable
	{			
		private readonly ArrayList errorList;				

		// Serializer functionality
		private ArrayList swiftErrorList;

		private int mParseErrors = 0;
		private int mXmlValidationErrors = 0;
		private int mBreValidationErrors = 0;

        // Deserializer functionality		
		private readonly ArrayList xmlValidationErrors;
		private readonly ArrayList parseErrors;
		private readonly ArrayList breValidationErrors;		
		
		private ResourceManager resManager;

		private string mMessageType = String.Empty;

		#region properties

		public int ParseErrorsCount
		{
			get
			{
				return mParseErrors;
			}
		}

		public int XmlValidationErrorsCount
		{
			get
			{
				return mXmlValidationErrors;
			}
		}

		public int BreValidationErrorsCount
		{
			get
			{
				return mBreValidationErrors;
			}
		}

		// Getter property to return a readonly ArrayList
		// with all the error packets
		internal ArrayList ErrorList
		{
			get
			{				
				return this.errorList;
			}
		}		

		// Property to get the count of Bre Validation errors
		internal int ErrorCount
		{
			get
			{
				return this.errorList.Count;				
			}
		}

		// ICollection properties
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		public int Count
		{
			get
			{
				return (mParseErrors +
					mXmlValidationErrors +
					mBreValidationErrors
					);
			}
		}

		public string MessageType
		{
			get
			{
				return mMessageType;
			}
			set
			{
				mMessageType = value;
			}
		}
		#endregion


		// Ctor to create a readonly array list
		public ErrorCollection()
		{
			// Original ValidationError list
			this.errorList = new ArrayList();	

			swiftErrorList = new ArrayList(10);

			parseErrors = new ArrayList(10);
			xmlValidationErrors = new ArrayList(10);
			breValidationErrors = new ArrayList(10);	

			resManager = new 
				ResourceManager("Microsoft.Solutions.FinancialServices.SWIFT.A4SWIFTResources", 
				Assembly.GetAssembly(
				typeof(Microsoft.Solutions.FinancialServices.SWIFT.StringResources)));
		}				

		// Constructor to take messageType
		public ErrorCollection(string messageType)
		{
			//if (messageType == null || messageType.Length == 0)
            //Fixing presharp errors
            if (string.IsNullOrEmpty(messageType))
			{
				throw new ArgumentNullException("messageType");
			}

			this.mMessageType = messageType;
			// Original ValidationError list
			this.errorList = new ArrayList();	

			swiftErrorList = new ArrayList(10);

			parseErrors = new ArrayList(10);
			xmlValidationErrors = new ArrayList(10);
			breValidationErrors = new ArrayList(10);	

			resManager = new 
				ResourceManager("Microsoft.Solutions.FinancialServices.SWIFT.A4SWIFTResources", 
				Assembly.GetAssembly(
				typeof(Microsoft.Solutions.FinancialServices.SWIFT.StringResources)));

		}

		// Constructor for the ISerializable interface
		// This is called during de-serialization
		private ErrorCollection(SerializationInfo si, StreamingContext context)
		{
            errorList            = (ArrayList)si.GetValue("EL", errorList.GetType());
			swiftErrorList       = (ArrayList)si.GetValue("SE", swiftErrorList.GetType());
			xmlValidationErrors  = (ArrayList)si.GetValue("XE", xmlValidationErrors.GetType());
			parseErrors          = (ArrayList)si.GetValue("PE", parseErrors.GetType());
			breValidationErrors  = (ArrayList)si.GetValue("BE", breValidationErrors.GetType());

			mXmlValidationErrors = si.GetInt32("XEC");
			mParseErrors         = si.GetInt32("PEC");
			mBreValidationErrors = si.GetInt32("BEC");

			mMessageType          = si.GetString("MT");
		}

		[SecurityPermissionAttribute(SecurityAction.Demand,SerializationFormatter =true)]
		public void GetObjectData(SerializationInfo si, StreamingContext context)
		{
            if (null == si) throw new ArgumentNullException("si");
			si.AddValue("EL", errorList);
			si.AddValue("SE", swiftErrorList);
			si.AddValue("XE", xmlValidationErrors);
			si.AddValue("PE", parseErrors);
			si.AddValue("BE", breValidationErrors);
			si.AddValue("XEC", mXmlValidationErrors);
			si.AddValue("PEC", mParseErrors);
			si.AddValue("BEC", mBreValidationErrors);
			si.AddValue("MT", mMessageType);
		}

		// Serializer methods start
		public void AddError(ErrorBase error)
		{
			if (error == null)
			{
				Debug.WriteLine("[SwiftErrorSerializer::AddError()] The argument ErrorBase is null");
				throw new ArgumentNullException("error");
			}
			
			if (error is ParseError)
			{
				parseErrors.Add(error);
				mParseErrors++;
			}
			else if (error is XmlValidationError)
			{
				xmlValidationErrors.Add(error);
				mXmlValidationErrors++;
			}
			else if (error is BreValidationError)
			{
				breValidationErrors.Add(error);
				mBreValidationErrors++;
			}
			else
			{
				// Invalid
				
				throw new ArgumentException(
					resManager.GetString("Ec_Invalid_Error")
					);
					
			}

			swiftErrorList.Add(error);
		}

		public void AddRange(ArrayList errorList)
		{
			// Removed the count check. Now an errorcollection with no 
			// errors can also be created. This was required for the 
			// validator component
			if (errorList == null)
			{
				Debug.WriteLine("[SwiftErrorSerializer::AddRange()] The argument ArrayList is null or has no elements in it");
				throw new ArgumentNullException("error");
			}

			ErrorBase err = null;
			for (int indx = 0; indx < errorList.Count; indx++)
			{
                err = (ErrorBase)errorList[indx];
				AddError(err);
			}			
		}
		
		public void GetXml(ref MemoryStream Stm, Encoding encoding)
		{
			if (Stm == null)
			{
				Debug.WriteLine("[SwiftErrorSerializer::Serialize()]Null stream passed");
				throw new ArgumentNullException("Stm");
			}

			XmlTextWriter xmlwr = new XmlTextWriter(Stm, encoding);

			xmlwr.WriteStartDocument();
			xmlwr.WriteStartElement("SWIFT_ERROR");
			// Write the messageType attribute
            xmlwr.WriteAttributeString("MessageType", mMessageType);
			foreach ( ErrorBase error in swiftErrorList)
			{
				// Removed the counting of errors here
				// as it was duplicating the count done during addition
				error.GetXml(xmlwr);
			}          
			xmlwr.WriteEndElement();
			xmlwr.WriteEndDocument();

			xmlwr.Flush();
	
			// Rewind the stream
			Stm.Seek(0, SeekOrigin.Begin);
		}

		public string GetFormattedErrorMessage(string errprolog, string messageType,
			string batchId, string interchangeId, long posInBatch)
		{
			StringBuilder sb;

			if (batchId == "-1")
			{
				// Single message i.e no batch scenario
				
				sb = new StringBuilder(
					string.Format(CultureInfo.InvariantCulture,resManager.GetString("Ec_Single_FormatError"),
					messageType, interchangeId, errprolog));
					
			}
			else
			{
				
				sb = new StringBuilder(
					string.Format(CultureInfo.InvariantCulture,resManager.GetString("Ec_Batch_FormatError"),
					interchangeId, posInBatch.ToString(CultureInfo.InvariantCulture), batchId, errprolog));
			}

			sb.Append("\r\n");
			sb.Append(string.Format(CultureInfo.InvariantCulture,resManager.GetString("Ec_FormatErrorCounts"), mParseErrors,
				mXmlValidationErrors, mBreValidationErrors));
            sb.Append("\r\n");
			sb.Append(resManager.GetString("Ec_FormatErrorSubscribe"));
			
			PrintErrors(sb.ToString());

			return sb.ToString();
		}

        public string GetFormattedErrorMessage(string errprolog, string messageType,
            string interchangeId)
        {
            StringBuilder sb;

                // Single message i.e no batch scenario

                sb = new StringBuilder(
                    string.Format(CultureInfo.InvariantCulture, resManager.GetString("Ec_Single_MXFormatError"),
                    messageType, interchangeId, errprolog));


            sb.Append("\r\n");
            sb.Append(string.Format(CultureInfo.InvariantCulture, resManager.GetString("Ec_FormatErrorCounts"), mParseErrors,
                mXmlValidationErrors, mBreValidationErrors));
            sb.Append("\r\n");
            sb.Append(resManager.GetString("Ec_FormatMXErrorSubscribe"));

            PrintErrors(sb.ToString());

            return sb.ToString();
        }

		[Conditional("DEBUG")]
		private void PrintErrors(string msg)
		{
			MemoryStream errorStream = new MemoryStream(50);
			this.GetXml(ref errorStream, Encoding.ASCII);
			errorStream.Seek(0, SeekOrigin.Begin);
            using (StreamReader sr = new StreamReader(errorStream))
            {
                string s = sr.ReadToEnd();
                Debug.WriteLine(msg + "\r\n" + s);
            }
		}
		// Serializer methods end
		
		// Des-Serializer methods start
		public static ErrorCollection GetErrorCollection(MemoryStream stm)
		{
			if (stm == null)
			{
				Debug.WriteLine("[ErrorCollection.GetErrorCollection()] The argument MemoryStream is null");
				throw new ArgumentNullException("stm");
			}

			XmlTextReader xmlr = new XmlTextReader(stm);
			return ErrorCollection.GetErrorCollection(xmlr);
		}

		// static factory method to return an errorcollection from the 
		// XML. Clients will need to use this to de-serialize the error XML
		public static ErrorCollection GetErrorCollection(XmlTextReader xmlr)
		{
			if (xmlr == null)
			{
				Debug.WriteLine("[ErrorCollection.GetErrorCollection()] The argument XmlTextReader is null");
				throw new ArgumentNullException("xmlr");
			}

			ErrorCollection errCollection = new ErrorCollection();
            ErrorBase err = null;
			try
			{
				while (xmlr.Read())
				{
					switch (xmlr.NodeType)
					{                    
						case XmlNodeType.Element:
							if (xmlr.Name == "ParseError")								  
							{
								err = ParseError.FromXml(xmlr);
								if (null != err)
								{									
									// Add this error to the ErrorCollection
									errCollection.AddError(err);
								}
							}
							else if (xmlr.Name == "XmlValidationError")
							{
								err = XmlValidationError.FromXml(xmlr);
								if (null != err)
								{								
									// Add this error to the ErrorCollection
									errCollection.AddError(err);
								}
							}
							else if (xmlr.Name == "BreValidationError")
							{
								err = BreValidationError.FromXml(xmlr);
								if (null != err)
								{								
									// Add this error to the ErrorCollection
									errCollection.AddError(err);
								}
							}
							else if (xmlr.Name == "SWIFT_ERROR")
							{
								if (xmlr.HasAttributes == true)
								{
									for (int indx = 0; indx < xmlr.AttributeCount; indx++)
									{
										xmlr.MoveToAttribute(indx);
										if (xmlr.Name == "MessageType")
										{
											errCollection.MessageType = xmlr.Value;
										}
									}
								}
							}
							break;

						default:
							Debug.WriteLine("Wrong error type");
							break;
					}
				}
			}
			catch (XmlException e)
			{
				Debug.WriteLine("[ErrorCollection.GetErrorCollection()] Xml parsing error");
				throw e;
			}
            
			return errCollection;
		}

		// End De-Serializer methods


		// Method that returns the ArrayList enumerators
		public IEnumerator GetEnumerator()
		{
			return swiftErrorList.GetEnumerator();
			
		}

		// ICollection method
		public void CopyTo(Array inArr, int index)
		{
			if (inArr == null)
			{
				Debug.WriteLine("[ErrorCollection::CopyTo()] The argument inArr is null");
				throw new ArgumentNullException("inArr");
			}
			
			foreach (ErrorBase err in swiftErrorList)
			{
				inArr.SetValue(err, index);
				index++;
			}
		}

		// new
		public IEnumerator GetParseErrorEnumerator()
		{
			return parseErrors.GetEnumerator();
		}

		public IEnumerator GetXmlValidationErrorEnumerator()
		{
			return xmlValidationErrors.GetEnumerator();
		}

		public IEnumerator GetBreValidationErrorEnumerator()
		{
			return breValidationErrors.GetEnumerator();
		}

		/// <summary>
		/// Adds an error to the ArrayList object that is a member
		/// of this class. Each entry to the ArrayList is an object of 
		/// type ValidateError 
		/// </summary>
		/// <param name="errorCode">Error Code</param>
		/// <param name="policyName">Policy Name</param>
		/// <param name="ruleName">Rule Name</param>
		/// <param name="elementName">Element Name</param>
		/// <param name="elementValue">Element Value</param>
		/// <returns>Boolean - indicating whether error was added to the
		/// collection or not.</returns>
		public void AddError(string errorCode, 
							 string policyName, 
							 string ruleName, 						
							 string elementName,
							 string elementValue)
		{
            //if(errorCode != null || 				
            //    elementName != null || 				
            //    elementValue != null ||
            //    policyName != null ||
            //    ruleName != null)
            //Fixing presharp errors
            if (!string.IsNullOrEmpty(errorCode) ||
                !string.IsNullOrEmpty(elementName) ||
                !string.IsNullOrEmpty(elementValue) ||
                !string.IsNullOrEmpty(policyName) ||
                !string.IsNullOrEmpty(ruleName))				
			{
				// Create a new ValidateError object
				ValidationError errorPacket = new ValidationError();						

				// Fill in the details..				
				errorPacket.ErrorCode = errorCode;		// Add Error COde
				errorPacket.PolicyName = policyName;	// Add Policy Name
				errorPacket.RuleName = ruleName;		// Add Rule Name
				errorPacket.ElementName = elementName;	// Add Element Name
				errorPacket.ElementValue = elementValue;// Add Element Value	
					
				// Add it to the ArrayList object
				errorList.Add(errorPacket);
	
				BreValidationError err = new BreValidationError(errorPacket);
				breValidationErrors.Add(err);
				mBreValidationErrors++;	
				
				return;
			}	

			else
			{
				
				throw new ApplicationException(
					resManager.GetString("Ec_ApplicationErrorException")
					);									
			}			
		}
		
		
		/// <summary>
		/// Overloaded variation of the function that adds an error to 
		/// the ArrayList object.Each entry to the ArrayList is an object of 
		/// type ValidationError.
		/// </summary>
		/// <param name="errorCode">Error Code</param>
		/// <param name="policyName">Policy Name</param>
		/// <param name="ruleName">Rule Name</param>
		/// <param name="messageType">Message Type</param>
		/// <param name="sequenceName">Sequence Name</param>
		/// <param name="elementName">Element Name</param>
		/// <param name="elementValue">Element Value</param>
		/// <returns>Boolean - indicating whether error was added to the
		/// collection or not.</returns>
		public void AddError(string errorCode, 							 
			string policyName, 
			string ruleName, 
			string messageType,
			string sequenceName,
			string elementName,
			string elementValue)
		{
            //if(errorCode != null ||				
            //    elementName != null || 				
            //    elementValue != null ||
            //    policyName != null ||
            //    ruleName != null ||
            //    messageType != null ||
            //    sequenceName != null)
            //Fixing presharp errors
            if (!string.IsNullOrEmpty(errorCode) ||
                !string.IsNullOrEmpty(elementName) ||
                !string.IsNullOrEmpty(elementValue) ||
                !string.IsNullOrEmpty(policyName) ||
                !string.IsNullOrEmpty(ruleName) ||
                !string.IsNullOrEmpty(messageType) ||
                !string.IsNullOrEmpty(sequenceName))
			{
				// Create a new SWIFT Error Packet	
				ValidationError errorPacket = new ValidationError();						

				errorPacket.ErrorCode = errorCode;	
				errorPacket.MessageType = messageType;	
				errorPacket.SequenceName = sequenceName;	
				errorPacket.PolicyName = policyName;	
				errorPacket.RuleName = ruleName;	
				errorPacket.ElementName = elementName;	
				errorPacket.ElementValue = elementValue;	
					
				errorList.Add(errorPacket);			

				BreValidationError err = new BreValidationError(errorPacket);
				breValidationErrors.Add(err);
				mBreValidationErrors++;	

				return;
			}		

			else
			{
				throw new ApplicationException("One or more error parameters have null values");
			}
			
		}



		/// <summary>
		/// Overloaded variation of the function that adds an error to 
		/// the ArrayList object.Each entry to the ArrayList is an object of 
		/// type ValidationError.
		/// This overloaded method has been added to accomodate the errors
		/// for Conditional Rules.
		/// </summary>
		/// <param name="errorCode">Error Code</param>
		/// <param name="policyName">Policy Name</param>
		/// <param name="ruleName">Rule Name</param>
		/// <param name="messageType">Message Type</param>
		/// <param name="elementName">conditionalRuleName</param>
		/// <param name="elementValue">conditionalRuleNumber</param>
		/// <returns>Boolean - indicating whether error was added to the
		/// collection or not.</returns>
		public void AddError(string errorCode, 							 
			string policyName, 
			string ruleName, 
			string messageType,
			string conditionalRuleName,
			string conditionalRuleNumber)
							 
		{
            //if(errorCode != null ||				
            //    conditionalRuleName != null || 	
            //    conditionalRuleNumber != null || 	
            //    policyName != null ||
            //    ruleName != null ||
            //    messageType != null)
            //Fixing presharp errors
            if (!string.IsNullOrEmpty(errorCode) ||
                !string.IsNullOrEmpty(conditionalRuleName) ||
                !string.IsNullOrEmpty(conditionalRuleNumber) ||
                !string.IsNullOrEmpty(policyName) ||
                !string.IsNullOrEmpty(ruleName) ||
                !string.IsNullOrEmpty(messageType))
			{
				// Create a new SWIFT Error Packet	
				ValidationError errorPacket = new ValidationError();						

				errorPacket.ErrorCode = errorCode;	
				errorPacket.MessageType = messageType;	
				errorPacket.PolicyName = policyName;	
				errorPacket.RuleName = ruleName;	
				errorPacket.ConditionalRuleName = conditionalRuleName;
				errorPacket.ConditionalRuleNumber = conditionalRuleNumber;
									
				errorList.Add(errorPacket);	
		
				BreValidationError err = new BreValidationError(errorPacket);
				breValidationErrors.Add(err);
				mBreValidationErrors++;	

				return;
			}		

			else
			{
				
				throw new ApplicationException(
					resManager.GetString("Ec_ApplicationErrorException")
					);
			}
			
		}

	}
}
