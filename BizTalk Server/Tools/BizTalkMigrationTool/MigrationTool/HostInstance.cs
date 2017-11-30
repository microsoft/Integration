﻿namespace Microsoft.BizTalk.Management {
    using System;
    using System.ComponentModel;
    using System.Management;
    using System.Collections;
    using System.Globalization;


    // Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions use Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that an empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    // Functions Is<PropertyName>Null() are used to check if a property is NULL.
    // Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used by VS designer in property browser to set a property to NULL.
    // Every property added to the class for WMI property has attributes set to define its behavior in Visual Studio designer and also to define a TypeConverter to be used.
    // Datetime conversion functions ToDateTime and ToDmtfDateTime are added to the class to convert DMTF datetime to System.DateTime and vice-versa.
    // An Early Bound class generated for the WMI class.MSBTS_HostInstance
    public class HostInstance : Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static readonly string CreatedWmiNamespace = "\\ROOT\\MicrosoftBizTalkServer";
        
        // Private property to hold the name of WMI class which created this class.
        private static readonly string CreatedClassName = "MSBTS_HostInstance";
        
        // Private member variable to hold the ManagementScope which is used by the various methods.
        private static ManagementScope statMgmtScope = null;
        
        private ManagementSystemProperties PrivateSystemProperties;
        
        // Underlying lateBound WMI object.
        private ManagementObject PrivateLateBoundObject;
        
        // Member variable to store the 'automatic commit' behavior for the class.
        private bool AutoCommitProp;
        
        // Private variable to hold the embedded property representing the instance.
        private readonly ManagementBaseObject embeddedObj;
        
        // The current WMI object used
        private ManagementBaseObject curObj;
        
        // Flag to indicate if the instance is an embedded object.
        private bool isEmbedded;
        
        // Below are different overloads of constructors to initialize an instance of the class with a WMI object.
        public HostInstance() {
            InitializeObject(null, null, null);
        }
        
        public HostInstance(string keyMgmtDbNameOverride, string keyMgmtDbServerOverride, string keyName) {
            InitializeObject(null, new ManagementPath(ConstructPath(keyMgmtDbNameOverride, keyMgmtDbServerOverride, keyName)), null);
        }
        
        public HostInstance(ManagementScope mgmtScope, string keyMgmtDbNameOverride, string keyMgmtDbServerOverride, string keyName) {
            InitializeObject(mgmtScope, new ManagementPath(ConstructPath(keyMgmtDbNameOverride, keyMgmtDbServerOverride, keyName)), null);
        }
        
        public HostInstance(ManagementPath path, ObjectGetOptions getOptions) {
            InitializeObject(null, path, getOptions);
        }
        
        public HostInstance(ManagementScope mgmtScope, ManagementPath path) {
            InitializeObject(mgmtScope, path, null);
        }
        
        public HostInstance(ManagementPath path) {
            InitializeObject(null, path, null);
        }
        
        public HostInstance(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions) {
            InitializeObject(mgmtScope, path, getOptions);
        }
        
        public HostInstance(ManagementObject theObject) {
            Initialize();
            if (CheckIfProperClass(theObject)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new ArgumentException("Class name does not match.");
            }
        }
        
        public HostInstance(ManagementBaseObject theObject) {
            Initialize();
            if (CheckIfProperClass(theObject)) {
                embeddedObj = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(theObject);
                curObj = embeddedObj;
                isEmbedded = true;
            }
            else {
                throw new ArgumentException("Class name does not match.");
            }
        }
        
        // Property returns the namespace of the WMI class.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OriginatingNamespace {
            get {
                return "ROOT\\MicrosoftBizTalkServer";
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManagementClassName {
            get {
                string strRet = CreatedClassName;
                if (curObj != null) {
                    if (curObj.ClassPath != null) {
                        strRet = (string)curObj["__CLASS"];
                        if (strRet == null 
                            || strRet == string.Empty) {
                            strRet = CreatedClassName;
                        }
                    }
                }
                return strRet;
            }
        }
        
        // Property pointing to an embedded object to get System properties of the WMI object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementSystemProperties SystemProperties {
            get {
                return PrivateSystemProperties;
            }
        }
        
        // Property returning the underlying lateBound object.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementBaseObject LateBoundObject {
            get {
                return curObj;
            }
        }
        
        // ManagementScope of the object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementScope Scope {
            get {
                if (isEmbedded == false) {
                    return PrivateLateBoundObject.Scope;
                }
                else {
                    return null;
                }
            }
            set {
                if (isEmbedded == false) {
                    PrivateLateBoundObject.Scope = value;
                }
            }
        }
        
        // Property to show the commit behavior for the WMI object. If true, WMI object will be automatically saved after each property modification.(ie. Put() is called after modification of a property).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoCommit {
            get {
                return AutoCommitProp;
            }
            set {
                AutoCommitProp = value;
            }
        }
        
        // The ManagementPath of the underlying WMI object.
        [Browsable(true)]
        public ManagementPath Path {
            get {
                if (isEmbedded == false) {
                    return PrivateLateBoundObject.Path;
                }
                else {
                    return null;
                }
            }
            set {
                if (isEmbedded == false) {
                    if (CheckIfProperClass(null, value, null) != true) {
                        throw new ArgumentException("Class name does not match.");
                    }
                    PrivateLateBoundObject.Path = value;
                }
            }
        }
        
        // Public static scope property which is used by the various methods.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static ManagementScope StaticScope {
            get {
                return statMgmtScope;
            }
            set {
                statMgmtScope = value;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Caption property is a short description (one-line string) of the object.")]
        public string Caption {
            get {
                return (string)curObj["Caption"];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsClusterInstanceTypeNull {
            get {
                if (curObj["ClusterInstanceType"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property tells whether the BizTalk Host Instance NT service is clustered.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ClusterInstanceTypeValues ClusterInstanceType {
            get {
                if (curObj["ClusterInstanceType"] == null) {
                    return (ClusterInstanceTypeValues)Convert.ToInt32(4);
                }
                return (ClusterInstanceTypeValues)Convert.ToInt32(curObj["ClusterInstanceType"]);
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigurationStateNull {
            get {
                if (curObj["ConfigurationState"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains installation state for the given BizTalk Host instance.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ConfigurationStateValues ConfigurationState {
            get {
                if (curObj["ConfigurationState"] == null) {
                    return (ConfigurationStateValues)Convert.ToInt32(0);
                }
                return (ConfigurationStateValues)Convert.ToInt32(curObj["ConfigurationState"]);
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Description property provides a description of the object. ")]
        public string Description {
            get {
                return (string)curObj["Description"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains the name of the BizTalk Host this BizTalk Host instance be" +
            "longs to. Max length for this property is 80 characters.")]
        public string HostName {
            get {
                return (string)curObj["HostName"];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsHostTypeNull {
            get {
                if (curObj["HostType"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property tells which runtime model the instances of the BizTalk Host will be" +
            " running in.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public HostTypeValues HostType {
            get {
                if (curObj["HostType"] == null) {
                    return (HostTypeValues)Convert.ToInt32(0);
                }
                return (HostTypeValues)Convert.ToInt32(curObj["HostType"]);
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInstallDateNull {
            get {
                if (curObj["InstallDate"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InstallDate property is a datetime value indicating when the object was insta" +
            "lled. The lack of a value does not indicate that the object is not installed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public DateTime InstallDate {
            get {
                if (curObj["InstallDate"] != null) {
                    return ToDateTime((string)curObj["InstallDate"]);
                }
                else {
                    return DateTime.MinValue;
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIsDisabledNull {
            get {
                if (curObj["IsDisabled"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property is used to enable or disable the BizTalk Host instance. It can only" +
            " be changed when the BizTalk Host instance is not started.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IsDisabled {
            get {
                if (curObj["IsDisabled"] == null) {
                    return Convert.ToBoolean(0);
                }
                return (bool)curObj["IsDisabled"];
            }
            set {
                curObj["IsDisabled"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains the logon that this BizTalk Host instance is using. This l" +
            "ogon account must be a member of the Windows group specified by the NTGroupName " +
            "property. Max length for this property is 128 characters.")]
        public string Logon {
            get {
                return (string)curObj["Logon"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This optional property can be used to override the initial catalog part of the Bi" +
            "zTalk Messaging Management database connect string, and represents the database " +
            "name. Max length for this property is 123 characters.")]
        public string MgmtDbNameOverride {
            get {
                return (string)curObj["MgmtDbNameOverride"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This optional property can be used to override the data source part of the BizTal" +
            "k Messaging Management database connect string. Max length for this property is " +
            "80 characters.")]
        public string MgmtDbServerOverride {
            get {
                return (string)curObj["MgmtDbServerOverride"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains the name of the BizTalk Host instance. Max length for this" +
            " property is 128 characters.")]
        public string Name {
            get {
                return (string)curObj["Name"];
            }
            set
            {
                curObj["Name"] = value;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"This property contains the name of the Windows group. It can be either a local or a domain Windows group. This group is granted access to the BizTalk Host Queue that is created for this BizTalk Host. The account used to host these BizTalk Host instances must be a member of the group. Max length for this property is 63 characters.")]
        public string NTGroupName {
            get {
                return (string)curObj["NTGroupName"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains the name of the server this BizTalk Host instance is runni" +
            "ng on. Max length for this property is 63 characters.")]
        public string RunningServer {
            get {
                return (string)curObj["RunningServer"];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsServiceStateNull {
            get {
                if (curObj["ServiceState"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains the state of the given BizTalk Host instance.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ServiceStateValues ServiceState {
            get {
                if (curObj["ServiceState"] == null) {
                    return (ServiceStateValues)Convert.ToInt32(0);
                }
                return (ServiceStateValues)Convert.ToInt32(curObj["ServiceState"]);
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Status property is a string indicating the current status of the object. Various operational and non-operational statuses can be defined. Operational statuses are ""OK"", ""Degraded"" and ""Pred Fail"". ""Pred Fail"" indicates that an element may be functioning properly but predicting a failure in the near future. An example is a SMART-enabled hard drive. Non-operational statuses can also be specified. These are ""Error"", ""Starting"", ""Stopping"" and ""Service"". The latter, ""Service"", could apply during mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is on-line, yet the managed element is neither ""OK"" nor in one of the other states.")]
        public string Status {
            get {
                return (string)curObj["Status"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains the unique ID of the BizTalk Host instance.")]
        public string UniqueID {
            get {
                return (string)curObj["UniqueID"];
            }
        }
        
        private bool CheckIfProperClass(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions OptionsParam) {
            if (path != null 
                && string.Compare(path.ClassName, ManagementClassName, true, CultureInfo.InvariantCulture) == 0) {
                return true;
            }
            else {
                return CheckIfProperClass(new ManagementObject(mgmtScope, path, OptionsParam));
            }
        }
        
        private bool CheckIfProperClass(ManagementBaseObject theObj) {
            if (theObj != null 
                && string.Compare((string)theObj["__CLASS"], ManagementClassName, true, CultureInfo.InvariantCulture) == 0) {
                return true;
            }
            else {
                Array parentClasses = (Array)theObj["__DERIVATION"];
                if (parentClasses != null) {
                    int count = 0;
                    for (count = 0; count < parentClasses.Length; count = count + 1) {
                        if (string.Compare((string)parentClasses.GetValue(count), ManagementClassName, true, CultureInfo.InvariantCulture) == 0) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private bool ShouldSerializeClusterInstanceType() {
            if (IsClusterInstanceTypeNull == false) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigurationState() {
            if (IsConfigurationStateNull == false) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeHostType() {
            if (IsHostTypeNull == false) {
                return true;
            }
            return false;
        }
        
        // Converts a given datetime in DMTF format to System.DateTime object.
        static DateTime ToDateTime(string dmtfDate) {
            DateTime initializer = DateTime.MinValue;
            int year = initializer.Year;
            int month = initializer.Month;
            int day = initializer.Day;
            int hour = initializer.Hour;
            int minute = initializer.Minute;
            int second = initializer.Second;
            long ticks = 0;
            string dmtf = dmtfDate;
            DateTime datetime = DateTime.MinValue;
            string tempString = string.Empty;
            if (dmtf == null) {
                throw new ArgumentOutOfRangeException();
            }
            if (dmtf.Length == 0) {
                throw new ArgumentOutOfRangeException();
            }
            if (dmtf.Length != 25) {
                throw new ArgumentOutOfRangeException();
            }
            try {
                tempString = dmtf.Substring(0, 4);
                if ("****" != tempString) {
                    year = int.Parse(tempString);
                }
                tempString = dmtf.Substring(4, 2);
                if ("**" != tempString) {
                    month = int.Parse(tempString);
                }
                tempString = dmtf.Substring(6, 2);
                if ("**" != tempString) {
                    day = int.Parse(tempString);
                }
                tempString = dmtf.Substring(8, 2);
                if ("**" != tempString) {
                    hour = int.Parse(tempString);
                }
                tempString = dmtf.Substring(10, 2);
                if ("**" != tempString) {
                    minute = int.Parse(tempString);
                }
                tempString = dmtf.Substring(12, 2);
                if ("**" != tempString) {
                    second = int.Parse(tempString);
                }
                tempString = dmtf.Substring(15, 6);
                if ("******" != tempString) {
                    ticks = long.Parse(tempString) * (TimeSpan.TicksPerMillisecond / 1000);
                }
                if (year < 0 
                    || month < 0 
                    || day < 0 
                    || hour < 0 
                    || minute < 0 
                    || minute < 0 
                    || second < 0 
                    || ticks < 0) {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception e) {
                throw new ArgumentOutOfRangeException(null, e.Message);
            }
            datetime = new DateTime(year, month, day, hour, minute, second, 0);
            datetime = datetime.AddTicks(ticks);
            TimeSpan tickOffset = TimeZone.CurrentTimeZone.GetUtcOffset(datetime);
            int UTCOffset = 0;
            int OffsetToBeAdjusted = 0;
            long OffsetMins = tickOffset.Ticks / TimeSpan.TicksPerMinute;
            tempString = dmtf.Substring(22, 3);
            if (tempString != "******") {
                tempString = dmtf.Substring(21, 4);
                try {
                    UTCOffset = int.Parse(tempString);
                }
                catch (Exception e) {
                    throw new ArgumentOutOfRangeException(null, e.Message);
                }
                OffsetToBeAdjusted = (int)(OffsetMins - UTCOffset);
                datetime = datetime.AddMinutes(OffsetToBeAdjusted);
            }
            return datetime;
        }
        
        // Converts a given System.DateTime object to DMTF datetime format.
        static string ToDmtfDateTime(DateTime date) {
            string utcString = string.Empty;
            TimeSpan tickOffset = TimeZone.CurrentTimeZone.GetUtcOffset(date);
            long OffsetMins = tickOffset.Ticks / TimeSpan.TicksPerMinute;
            if (Math.Abs(OffsetMins) > 999) {
                date = date.ToUniversalTime();
                utcString = "+000";
            }
            else {
                if (tickOffset.Ticks >= 0) {
                    utcString = string.Concat("+", (tickOffset.Ticks / TimeSpan.TicksPerMinute).ToString().PadLeft(3, '0'));
                }
                else {
                    string strTemp = OffsetMins.ToString();
                    utcString = string.Concat("-", strTemp.Substring(1, strTemp.Length - 1).PadLeft(3, '0'));
                }
            }
            string dmtfDateTime = date.Year.ToString().PadLeft(4, '0');
            dmtfDateTime = string.Concat(dmtfDateTime, date.Month.ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, date.Day.ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, date.Hour.ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, date.Minute.ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, date.Second.ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ".");
            DateTime dtTemp = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
            long microsec = (date.Ticks - dtTemp.Ticks) 
                            * 1000 
                            / TimeSpan.TicksPerMillisecond;
            string strMicrosec = microsec.ToString();
            if (strMicrosec.Length > 6) {
                strMicrosec = strMicrosec.Substring(0, 6);
            }
            dmtfDateTime = string.Concat(dmtfDateTime, strMicrosec.PadLeft(6, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, utcString);
            return dmtfDateTime;
        }
        
        private bool ShouldSerializeInstallDate() {
            if (IsInstallDateNull == false) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIsDisabled() {
            if (IsIsDisabledNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetIsDisabled() {
            curObj["IsDisabled"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeServiceState() {
            if (IsServiceStateNull == false) {
                return true;
            }
            return false;
        }
        
        [Browsable(true)]
        public void CommitObject() {
            if (isEmbedded == false) {
                PrivateLateBoundObject.Put();
            }
        }
        
        [Browsable(true)]
        public void CommitObject(PutOptions putOptions) {
            if (isEmbedded == false) {
                PrivateLateBoundObject.Put(putOptions);
            }
        }
        
        private void Initialize() {
            AutoCommitProp = true;
            isEmbedded = false;
        }
        
        private static string ConstructPath(string keyMgmtDbNameOverride, string keyMgmtDbServerOverride, string keyName) {
            string strPath = "ROOT\\MicrosoftBizTalkServer:MSBTS_HostInstance";
            strPath = string.Concat(strPath, string.Concat(".MgmtDbNameOverride=", string.Concat("\"", string.Concat(keyMgmtDbNameOverride, "\""))));
            strPath = string.Concat(strPath, string.Concat(",MgmtDbServerOverride=", string.Concat("\"", string.Concat(keyMgmtDbServerOverride, "\""))));
            strPath = string.Concat(strPath, string.Concat(",Name=", string.Concat("\"", string.Concat(keyName, "\""))));
            return strPath;
        }
        
        private void InitializeObject(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions) {
            Initialize();
            if (path != null) {
                if (CheckIfProperClass(mgmtScope, path, getOptions) != true) {
                    throw new ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        // Different overloads of GetInstances() help in enumerating instances of the WMI class.
        public static HostInstanceCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static HostInstanceCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static HostInstanceCollection GetInstances(String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static HostInstanceCollection GetInstances(string condition, String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static HostInstanceCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions) {
            if (mgmtScope == null) {
                if (statMgmtScope == null) {
                    mgmtScope = new ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\MicrosoftBizTalkServer";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            ManagementPath pathObj = new ManagementPath();
            pathObj.ClassName = "MSBTS_HostInstance";
            pathObj.NamespacePath = "root\\MicrosoftBizTalkServer";
            ManagementClass clsObject = new ManagementClass(mgmtScope, pathObj, null);
            if (enumOptions == null) {
                enumOptions = new EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new HostInstanceCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static HostInstanceCollection GetInstances(ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static HostInstanceCollection GetInstances(ManagementScope mgmtScope, String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static HostInstanceCollection GetInstances(ManagementScope mgmtScope, string condition, String [] selectedProperties) {
            if (mgmtScope == null) {
                if (statMgmtScope == null) {
                    mgmtScope = new ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\MicrosoftBizTalkServer";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            ManagementObjectSearcher ObjectSearcher = new ManagementObjectSearcher(mgmtScope, new SelectQuery("MSBTS_HostInstance", condition, selectedProperties));
            EnumerationOptions enumOptions = new EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new HostInstanceCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static HostInstance CreateInstance() {
            ManagementScope mgmtScope = null;
            if (statMgmtScope == null) {
                mgmtScope = new ManagementScope();
                mgmtScope.Path.NamespacePath = CreatedWmiNamespace;
            }
            else {
                mgmtScope = statMgmtScope;
            }
            ManagementPath mgmtPath = new ManagementPath(CreatedClassName);
            ManagementClass tmpMgmtClass = new ManagementClass(mgmtScope, mgmtPath, null);
            return new HostInstance(tmpMgmtClass.CreateInstance());
        }

        [Browsable(true)]
        public static HostInstance CreateInstance(string pServer, string pUserName,string pPassword, string pDomain)
        {
            ManagementScope mgmtScope = null;
            if (statMgmtScope == null)
            {
                mgmtScope = new ManagementScope();
                mgmtScope.Path.NamespacePath = "\\\\" + pServer + CreatedWmiNamespace;

                ConnectionOptions connection = new ConnectionOptions();
                connection.Username = pUserName;
                connection.Password = pPassword;
                connection.Authority = "ntlmdomain:" + pDomain;
                mgmtScope.Options = connection;
            }
            else
            {
                mgmtScope = statMgmtScope;
            }
            ManagementPath mgmtPath = new ManagementPath(CreatedClassName);
            ManagementClass tmpMgmtClass = new ManagementClass(mgmtScope, mgmtPath, null);
            return new HostInstance(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        public uint GetState(out uint State) {
            if (isEmbedded == false) {
                ManagementBaseObject inParams = null;
                ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("GetState", inParams, null);
                State = Convert.ToUInt32(outParams.Properties["State"].Value);
                return Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                State = Convert.ToUInt32(0);
                return Convert.ToUInt32(0);
            }
        }
        
        public uint Install(bool grantLogOnAsService, string logon, string password) {
            if (isEmbedded == false) {
                ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("Install");
                inParams["GrantLogOnAsService"] = grantLogOnAsService;
                inParams["Logon"] = logon;
                inParams["Password"] = password;
                ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Install", inParams, null);
                return Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return Convert.ToUInt32(0);
            }
        }
        
        public uint Start() {
            if (isEmbedded == false) {
                ManagementBaseObject inParams = null;
                ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Start", inParams, null);
                return Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return Convert.ToUInt32(0);
            }
        }
        
        public uint Stop() {
            if (isEmbedded == false) {
                ManagementBaseObject inParams = null;
                ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Stop", inParams, null);
                return Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return Convert.ToUInt32(0);
            }
        }
        
        public uint Uninstall() {
            if (isEmbedded == false) {
                ManagementBaseObject inParams = null;
                ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Uninstall", inParams, null);
                return Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return Convert.ToUInt32(0);
            }
        }
        
        public enum ClusterInstanceTypeValues {
            
            UnClusteredInstance = 0,
            
            ClusteredInstance = 1,
            
            ClusteredInstanceActive = 2,
            
            ClusteredVirtualInstance = 3,
            
            NULL_ENUM_VALUE = 4,
        }
        
        public enum ConfigurationStateValues {
            
            Installed = 1,
            
            Installation_failed = 2,
            
            Uninstallation_failed = 3,
            
            Update_failed = 4,
            
            Not_installed = 5,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum HostTypeValues {
            
            In_process = 1,
            
            Isolated = 2,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum ServiceStateValues {
            
            Stopped = 1,
            
            Start_pending = 2,
            
            Stop_pending = 3,
            
            Running = 4,
            
            Continue_pending = 5,
            
            Pause_pending = 6,
            
            Paused = 7,
            
            Unknown0 = 8,
            
            NULL_ENUM_VALUE = 0,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class HostInstanceCollection : object, ICollection {
            
            private readonly ManagementObjectCollection privColObj;
            
            public HostInstanceCollection(ManagementObjectCollection objCollection) {
                privColObj = objCollection;
            }
            
            public virtual int Count {
                get {
                    return privColObj.Count;
                }
            }
            
            public virtual bool IsSynchronized {
                get {
                    return privColObj.IsSynchronized;
                }
            }
            
            public virtual object SyncRoot {
                get {
                    return this;
                }
            }
            
            public virtual void CopyTo(Array array, int index) {
                privColObj.CopyTo(array, index);
                int nCtr;
                for (nCtr = 0; nCtr < array.Length; nCtr = nCtr + 1) {
                    array.SetValue(new HostInstance((ManagementObject)array.GetValue(nCtr)), nCtr);
                }
            }
            
            public virtual IEnumerator GetEnumerator() {
                return new HostInstanceEnumerator(privColObj.GetEnumerator());
            }
            
            public class HostInstanceEnumerator : object, IEnumerator {
                
                private readonly ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public HostInstanceEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new HostInstance((ManagementObject)privObjEnum.Current);
                    }
                }
                
                public virtual bool MoveNext() {
                    return privObjEnum.MoveNext();
                }
                
                public virtual void Reset() {
                    privObjEnum.Reset();
                }
            }
        }
        
        // TypeConverter to handle null values for ValueType properties
        public class WMIValueTypeConverter : TypeConverter {
            
            private readonly TypeConverter baseConverter;
            
            private readonly Type baseType;
            
            public WMIValueTypeConverter(Type inBaseType) {
                baseConverter = TypeDescriptor.GetConverter(inBaseType);
                baseType = inBaseType;
            }
            
            public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType) {
                return baseConverter.CanConvertFrom(context, srcType);
            }
            
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
                return baseConverter.CanConvertTo(context, destinationType);
            }
            
            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
                return baseConverter.ConvertFrom(context, culture, value);
            }
            
            public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary) {
                return baseConverter.CreateInstance(context, dictionary);
            }
            
            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) {
                return baseConverter.GetCreateInstanceSupported(context);
            }
            
            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar) {
                return baseConverter.GetProperties(context, value, attributeVar);
            }
            
            public override bool GetPropertiesSupported(ITypeDescriptorContext context) {
                return baseConverter.GetPropertiesSupported(context);
            }
            
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) {
                return baseConverter.GetStandardValues(context);
            }
            
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesExclusive(context);
            }
            
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesSupported(context);
            }
            
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) {
                if (baseType.BaseType == typeof(Enum)) {
                    if (value.GetType() == destinationType) {
                        return value;
                    }
                    if (value == null 
                        && context != null 
                        && context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false) {
                        return  "NULL_ENUM_VALUE" ;
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (baseType == typeof(bool) 
                    && baseType.BaseType == typeof(ValueType)) {
                    if (value == null 
                        && context != null 
                        && context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false) {
                        return "";
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (context != null 
                    && context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false) {
                    return "";
                }
                return baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }
        
        // Embedded class to represent WMI system Properties.
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ManagementSystemProperties {
            
            private readonly ManagementBaseObject PrivateLateBoundObject;
            
            public ManagementSystemProperties(ManagementBaseObject ManagedObject) {
                PrivateLateBoundObject = ManagedObject;
            }
            
            [Browsable(true)]
            public int GENUS {
                get {
                    return (int)PrivateLateBoundObject["__GENUS"];
                }
            }
            
            [Browsable(true)]
            public string CLASS {
                get {
                    return (string)PrivateLateBoundObject["__CLASS"];
                }
            }
            
            [Browsable(true)]
            public string SUPERCLASS {
                get {
                    return (string)PrivateLateBoundObject["__SUPERCLASS"];
                }
            }
            
            [Browsable(true)]
            public string DYNASTY {
                get {
                    return (string)PrivateLateBoundObject["__DYNASTY"];
                }
            }
            
            [Browsable(true)]
            public string RELPATH {
                get {
                    return (string)PrivateLateBoundObject["__RELPATH"];
                }
            }
            
            [Browsable(true)]
            public int PROPERTY_COUNT {
                get {
                    return (int)PrivateLateBoundObject["__PROPERTY_COUNT"];
                }
            }
            
            [Browsable(true)]
            public string[] DERIVATION {
                get {
                    return (string[])PrivateLateBoundObject["__DERIVATION"];
                }
            }
            
            [Browsable(true)]
            public string SERVER {
                get {
                    return (string)PrivateLateBoundObject["__SERVER"];
                }
            }
            
            [Browsable(true)]
            public string NAMESPACE {
                get {
                    return (string)PrivateLateBoundObject["__NAMESPACE"];
                }
            }
            
            [Browsable(true)]
            public string PATH {
                get {
                    return (string)PrivateLateBoundObject["__PATH"];
                }
            }
        }
    }
}
