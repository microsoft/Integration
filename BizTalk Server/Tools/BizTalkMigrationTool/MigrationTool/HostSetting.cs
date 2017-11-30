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
    // An Early Bound class generated for the WMI class.MSBTS_HostSetting
    public class HostSetting : Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static readonly string CreatedWmiNamespace = "\\ROOT\\MicrosoftBizTalkServer";
        
        // Private property to hold the name of WMI class which created this class.
        private static readonly string CreatedClassName = "MSBTS_HostSetting";
        
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
        public HostSetting() {
            InitializeObject(null, null, null);
        }
        
        public HostSetting(string keyMgmtDbNameOverride, string keyMgmtDbServerOverride, string keyName) {
            InitializeObject(null, new ManagementPath(ConstructPath(keyMgmtDbNameOverride, keyMgmtDbServerOverride, keyName)), null);
        }
        
        public HostSetting(ManagementScope mgmtScope, string keyMgmtDbNameOverride, string keyMgmtDbServerOverride, string keyName) {
            InitializeObject(mgmtScope, new ManagementPath(ConstructPath(keyMgmtDbNameOverride, keyMgmtDbServerOverride, keyName)), null);
        }
        
        public HostSetting(ManagementPath path, ObjectGetOptions getOptions) {
            InitializeObject(null, path, getOptions);
        }
        
        public HostSetting(ManagementScope mgmtScope, ManagementPath path) {
            InitializeObject(mgmtScope, path, null);
        }
        
        public HostSetting(ManagementPath path) {
            InitializeObject(null, path, null);
        }
        
        public HostSetting(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions) {
            InitializeObject(mgmtScope, path, getOptions);
        }
        
        public HostSetting(ManagementObject theObject) {
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
        
        public HostSetting(ManagementBaseObject theObject) {
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
                if (curObj?.ClassPath != null) {
                    strRet = (string)curObj["__CLASS"];
                    if (string.IsNullOrEmpty(strRet)) {
                        strRet = CreatedClassName;
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
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAuthTrustedNull {
            get {
                if (curObj["AuthTrusted"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property indicates whether the BizTalk Host is trusted to collect authentica" +
            "tion information.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool AuthTrusted {
            get {
                if (curObj["AuthTrusted"] == null) {
                    return Convert.ToBoolean(0);
                }
                return (bool)curObj["AuthTrusted"];
            }
            set {
                curObj["AuthTrusted"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A short description (one-line string) of the CIM_Setting object.")]
        public string Caption {
            get {
                return (string)curObj["Caption"];
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("When the host instances of this host are clustered, this property contains the cl" +
            "uster resource group name set by the Administrator.")]
        public string ClusterResourceGroupName {
            get {
                return (string)curObj["ClusterResourceGroupName"];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDBQueueSizeThresholdNull {
            get {
                if (curObj["DBQueueSizeThreshold"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum number of items in the Database.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DBQueueSizeThreshold {
            get {
                if (curObj["DBQueueSizeThreshold"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["DBQueueSizeThreshold"];
            }
            set {
                curObj["DBQueueSizeThreshold"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDBSessionThresholdNull {
            get {
                if (curObj["DBSessionThreshold"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum number of DB Sessions (per CPU) allowed before throttling begins.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DBSessionThreshold {
            get {
                if (curObj["DBSessionThreshold"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["DBSessionThreshold"];
            }
            set {
                curObj["DBSessionThreshold"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This is a comment field that allows to associate some friendly name with a decryp" +
            "tion certificate. Max length for this property is 256 characters.")]
        public string DecryptCertComment {
            get {
                return (string)curObj["DecryptCertComment"];
            }
            set {
                curObj["DecryptCertComment"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"ThumbPrint of the Decryption certificate. The Certificate Thumbprint is a digest of the certificate data and is found in the Certificate Details, and is expressed as a hexadecimal value. Example: 'FD36 90F0 EB49 F7B8 D3AB 1C69 8E02 ED84 5738 7868'. Max length for this property is 80 characters.")]
        public string DecryptCertThumbprint {
            get {
                return (string)curObj["DecryptCertThumbprint"];
            }
            set {
                curObj["DecryptCertThumbprint"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDeliveryQueueSizeNull {
            get {
                if (curObj["DeliveryQueueSize"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Size of the in-memory Queue that the host maintains as a temporary placeholder fo" +
            "r delivering messages.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DeliveryQueueSize {
            get {
                if (curObj["DeliveryQueueSize"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["DeliveryQueueSize"];
            }
            set {
                curObj["DeliveryQueueSize"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A description of the CIM_Setting object.")]
        public string Description {
            get {
                return (string)curObj["Description"];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsGlobalMemoryThresholdNull {
            get {
                if (curObj["GlobalMemoryThreshold"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum System-wide Virtual Memory (in percent) usage allowed before throttling b" +
            "egins.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint GlobalMemoryThreshold {
            get {
                if (curObj["GlobalMemoryThreshold"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["GlobalMemoryThreshold"];
            }
            set {
                curObj["GlobalMemoryThreshold"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsHostTrackingNull {
            get {
                if (curObj["HostTracking"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property indicates whether instances of this BizTalk Host will host the trac" +
            "king sub service.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool HostTracking {
            get {
                if (curObj["HostTracking"] == null) {
                    return Convert.ToBoolean(0);
                }
                return (bool)curObj["HostTracking"];
            }
            set {
                curObj["HostTracking"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
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
        [Description("This property indicates which runtime model the instances of the BizTalk Host wil" +
            "l be running in.  This property is required for instance creation.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public HostTypeValues HostType {
            get {
                if (curObj["HostType"] == null) {
                    return (HostTypeValues)Convert.ToInt32(0);
                }
                return (HostTypeValues)Convert.ToInt32(curObj["HostType"]);
            }

            set
            {
                curObj["HostType"] = Convert.ToInt32(value);
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInflightMessageThresholdNull {
            get {
                if (curObj["InflightMessageThreshold"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum number of in-memory in-flight messages allowed before throttling Message " +
            "Delivery begins.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint InflightMessageThreshold {
            get {
                if (curObj["InflightMessageThreshold"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["InflightMessageThreshold"];
            }
            set {
                curObj["InflightMessageThreshold"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIsDefaultNull {
            get {
                if (curObj["IsDefault"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property indicates whether the BizTalk Host represented by this WMI instance" +
            " is the default BizTalk Host in the BizTalk group.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IsDefault {
            get {
                if (curObj["IsDefault"] == null) {
                    return Convert.ToBoolean(0);
                }
                return (bool)curObj["IsDefault"];
            }
            set {
                curObj["IsDefault"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIsHost32BitOnlyNull {
            get {
                if (curObj["IsHost32BitOnly"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property indicates whether the host instance process should be created as 32" +
            "-bit on both 32-bit and 64-bit servers.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IsHost32BitOnly {
            get {
                if (curObj["IsHost32BitOnly"] == null) {
                    return Convert.ToBoolean(0);
                }
                return (bool)curObj["IsHost32BitOnly"];
            }
            set {
                curObj["IsHost32BitOnly"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property contains a default logon for the BizTalk Host instance creation UI." +
            " Max length for this property is 128 characters.")]
        public string LastUsedLogon {
            get {
                return (string)curObj["LastUsedLogon"];
            }
            set {
                curObj["LastUsedLogon"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessageDeliveryMaximumDelayNull {
            get {
                if (curObj["MessageDeliveryMaximumDelay"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum Delay (in milliseconds) imposed for Message Delivery Throttling. Zero ind" +
            "icates disable Message Delivery Throttling.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessageDeliveryMaximumDelay {
            get {
                if (curObj["MessageDeliveryMaximumDelay"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessageDeliveryMaximumDelay"];
            }
            set {
                curObj["MessageDeliveryMaximumDelay"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessageDeliveryOverdriveFactorNull {
            get {
                if (curObj["MessageDeliveryOverdriveFactor"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Percent factor by which the system will overdrive the Input rate for Message Deli" +
            "very Throttling.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessageDeliveryOverdriveFactor {
            get {
                if (curObj["MessageDeliveryOverdriveFactor"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessageDeliveryOverdriveFactor"];
            }
            set {
                curObj["MessageDeliveryOverdriveFactor"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessageDeliverySampleSpaceSizeNull {
            get {
                if (curObj["MessageDeliverySampleSpaceSize"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("This property indicates the number of samples that are used for determining the r" +
            "ate of the Message Delivery to all Service Classes of the Host.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessageDeliverySampleSpaceSize {
            get {
                if (curObj["MessageDeliverySampleSpaceSize"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessageDeliverySampleSpaceSize"];
            }
            set {
                curObj["MessageDeliverySampleSpaceSize"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessageDeliverySampleSpaceWindowNull {
            get {
                if (curObj["MessageDeliverySampleSpaceWindow"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Time-window (in milliseconds) beyond which samples will be deemed invalid for con" +
            "sideration.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessageDeliverySampleSpaceWindow {
            get {
                if (curObj["MessageDeliverySampleSpaceWindow"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessageDeliverySampleSpaceWindow"];
            }
            set {
                curObj["MessageDeliverySampleSpaceWindow"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessagePublishMaximumDelayNull {
            get {
                if (curObj["MessagePublishMaximumDelay"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum Delay (in milliseconds) imposed for Message Publishing Throttling. Zero i" +
            "ndicates disable Message Publishing Throttling.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessagePublishMaximumDelay {
            get {
                if (curObj["MessagePublishMaximumDelay"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessagePublishMaximumDelay"];
            }
            set {
                curObj["MessagePublishMaximumDelay"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessagePublishOverdriveFactorNull {
            get {
                if (curObj["MessagePublishOverdriveFactor"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Percent Factor by which the system will overdrive the Input rate.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessagePublishOverdriveFactor {
            get {
                if (curObj["MessagePublishOverdriveFactor"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessagePublishOverdriveFactor"];
            }
            set {
                curObj["MessagePublishOverdriveFactor"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessagePublishSampleSpaceSizeNull {
            get {
                if (curObj["MessagePublishSampleSpaceSize"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of samples that are used for determining the rate of the Message Publishin" +
            "g by the Service Classes.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessagePublishSampleSpaceSize {
            get {
                if (curObj["MessagePublishSampleSpaceSize"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessagePublishSampleSpaceSize"];
            }
            set {
                curObj["MessagePublishSampleSpaceSize"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMessagePublishSampleSpaceWindowNull {
            get {
                if (curObj["MessagePublishSampleSpaceWindow"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Time-window (in milliseconds) beyond which samples will be deemed invalid for con" +
            "sideration.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MessagePublishSampleSpaceWindow {
            get {
                if (curObj["MessagePublishSampleSpaceWindow"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["MessagePublishSampleSpaceWindow"];
            }
            set {
                curObj["MessagePublishSampleSpaceWindow"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
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
        [Description("This property contains the name of the BizTalk Host.  This property is required f" +
            "or instance creation. Max length for this property is 80 characters.")]
        public string Name {
            get {
                return (string)curObj["Name"];
                }

            set { curObj["Name"] = value;
                }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"This property contains the name of the Windows group. It can be either a local or a domain Windows group. This group is granted access to the BizTalk Host Queue that is created for this BizTalk Host. All accounts used to host BizTalk Host instances of this type must be members of this group.  This property is required for instance creation. Max length for this property is 63 characters.")]
        public string NTGroupName {
            get {
                return (string)curObj["NTGroupName"];
            }

            set
            {
                curObj["NTGroupName"] = value;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsProcessMemoryThresholdNull {
            get {
                if (curObj["ProcessMemoryThreshold"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum Process Memory (in percent) allowed before throttling begins.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ProcessMemoryThreshold {
            get {
                if (curObj["ProcessMemoryThreshold"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["ProcessMemoryThreshold"];
            }
            set {
                curObj["ProcessMemoryThreshold"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The identifier by which the CIM_Setting object is known.")]
        public string SettingID {
            get {
                return (string)curObj["SettingID"];
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsThreadPoolSizeNull {
            get {
                if (curObj["ThreadPoolSize"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum number of messaging engine threads per CPU.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ThreadPoolSize {
            get {
                if (curObj["ThreadPoolSize"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["ThreadPoolSize"];
            }
            set {
                curObj["ThreadPoolSize"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsThreadThresholdNull {
            get {
                if (curObj["ThreadThreshold"] == null) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum number of threads in the process (per CPU) allowed before throttling begi" +
            "ns.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ThreadThreshold {
            get {
                if (curObj["ThreadThreshold"] == null) {
                    return Convert.ToUInt32(0);
                }
                return (uint)curObj["ThreadThreshold"];
            }
            set {
                curObj["ThreadThreshold"] = value;
                if (isEmbedded == false 
                    && AutoCommitProp) {
                    PrivateLateBoundObject.Put();
                }
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
        
        private bool ShouldSerializeAuthTrusted() {
            if (IsAuthTrustedNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetAuthTrusted() {
            curObj["AuthTrusted"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDBQueueSizeThreshold() {
            if (IsDBQueueSizeThresholdNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetDBQueueSizeThreshold() {
            curObj["DBQueueSizeThreshold"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDBSessionThreshold() {
            if (IsDBSessionThresholdNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetDBSessionThreshold() {
            curObj["DBSessionThreshold"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetDecryptCertComment() {
            curObj["DecryptCertComment"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetDecryptCertThumbprint() {
            curObj["DecryptCertThumbprint"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDeliveryQueueSize() {
            if (IsDeliveryQueueSizeNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetDeliveryQueueSize() {
            curObj["DeliveryQueueSize"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeGlobalMemoryThreshold() {
            if (IsGlobalMemoryThresholdNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetGlobalMemoryThreshold() {
            curObj["GlobalMemoryThreshold"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeHostTracking() {
            if (IsHostTrackingNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetHostTracking() {
            curObj["HostTracking"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeHostType() {
            if (IsHostTypeNull == false) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeInflightMessageThreshold() {
            if (IsInflightMessageThresholdNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetInflightMessageThreshold() {
            curObj["InflightMessageThreshold"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeIsDefault() {
            if (IsIsDefaultNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetIsDefault() {
            curObj["IsDefault"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeIsHost32BitOnly() {
            if (IsIsHost32BitOnlyNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetIsHost32BitOnly() {
            curObj["IsHost32BitOnly"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetLastUsedLogon() {
            curObj["LastUsedLogon"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessageDeliveryMaximumDelay() {
            if (IsMessageDeliveryMaximumDelayNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessageDeliveryMaximumDelay() {
            curObj["MessageDeliveryMaximumDelay"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessageDeliveryOverdriveFactor() {
            if (IsMessageDeliveryOverdriveFactorNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessageDeliveryOverdriveFactor() {
            curObj["MessageDeliveryOverdriveFactor"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessageDeliverySampleSpaceSize() {
            if (IsMessageDeliverySampleSpaceSizeNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessageDeliverySampleSpaceSize() {
            curObj["MessageDeliverySampleSpaceSize"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessageDeliverySampleSpaceWindow() {
            if (IsMessageDeliverySampleSpaceWindowNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessageDeliverySampleSpaceWindow() {
            curObj["MessageDeliverySampleSpaceWindow"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessagePublishMaximumDelay() {
            if (IsMessagePublishMaximumDelayNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessagePublishMaximumDelay() {
            curObj["MessagePublishMaximumDelay"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessagePublishOverdriveFactor() {
            if (IsMessagePublishOverdriveFactorNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessagePublishOverdriveFactor() {
            curObj["MessagePublishOverdriveFactor"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessagePublishSampleSpaceSize() {
            if (IsMessagePublishSampleSpaceSizeNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessagePublishSampleSpaceSize() {
            curObj["MessagePublishSampleSpaceSize"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMessagePublishSampleSpaceWindow() {
            if (IsMessagePublishSampleSpaceWindowNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetMessagePublishSampleSpaceWindow() {
            curObj["MessagePublishSampleSpaceWindow"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeProcessMemoryThreshold() {
            if (IsProcessMemoryThresholdNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetProcessMemoryThreshold() {
            curObj["ProcessMemoryThreshold"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeThreadPoolSize() {
            if (IsThreadPoolSizeNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetThreadPoolSize() {
            curObj["ThreadPoolSize"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeThreadThreshold() {
            if (IsThreadThresholdNull == false) {
                return true;
            }
            return false;
        }
        
        private void ResetThreadThreshold() {
            curObj["ThreadThreshold"] = null;
            if (isEmbedded == false 
                && AutoCommitProp) {
                PrivateLateBoundObject.Put();
            }
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
            string strPath = "ROOT\\MicrosoftBizTalkServer:MSBTS_HostSetting";
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
        public static HostSettingCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static HostSettingCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static HostSettingCollection GetInstances(String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static HostSettingCollection GetInstances(string condition, String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static HostSettingCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions) {
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
            pathObj.ClassName = "MSBTS_HostSetting";
            pathObj.NamespacePath = "root\\MicrosoftBizTalkServer";
            ManagementClass clsObject = new ManagementClass(mgmtScope, pathObj, null);
            if (enumOptions == null) {
                enumOptions = new EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new HostSettingCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static HostSettingCollection GetInstances(ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static HostSettingCollection GetInstances(ManagementScope mgmtScope, String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static HostSettingCollection GetInstances(ManagementScope mgmtScope, string condition, String [] selectedProperties) {
            if (mgmtScope == null) {
                if (statMgmtScope == null) {
                    mgmtScope = new ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\MicrosoftBizTalkServer";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            ManagementObjectSearcher ObjectSearcher = new ManagementObjectSearcher(mgmtScope, new SelectQuery("MSBTS_HostSetting", condition, selectedProperties));
            EnumerationOptions enumOptions = new EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new HostSettingCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static HostSetting CreateInstance() {
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
            return new HostSetting(tmpMgmtClass.CreateInstance());
        }
        [Browsable(true)]
        public static HostSetting CreateInstance(string pServer, string pUserName,string pPassword, string pDomain)
        {
            ManagementScope mgmtScope = null;
            if (statMgmtScope == null)
            {
                mgmtScope = new ManagementScope();
                mgmtScope.Path.NamespacePath = "\\\\" + pServer +  CreatedWmiNamespace;

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
            return new HostSetting(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        public enum HostTypeValues {
            
            In_process = 1,
            
            Isolated = 2,
            
            NULL_ENUM_VALUE = 0,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class HostSettingCollection : object, ICollection {
            
            private readonly ManagementObjectCollection privColObj;
            
            public HostSettingCollection(ManagementObjectCollection objCollection) {
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
                    array.SetValue(new HostSetting((ManagementObject)array.GetValue(nCtr)), nCtr);
                }
            }
            
            public virtual IEnumerator GetEnumerator() {
                return new HostSettingEnumerator(privColObj.GetEnumerator());
            }
            
            public class HostSettingEnumerator : object, IEnumerator {
                
                private readonly ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public HostSettingEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new HostSetting((ManagementObject)privObjEnum.Current);
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
