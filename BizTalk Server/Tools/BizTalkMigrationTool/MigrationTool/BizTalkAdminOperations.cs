using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Windows.Forms;
using System.Management;
using Microsoft.BizTalk.ExplorerOM;
using Microsoft.BizTalk.Management;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Principal;
using System.ServiceProcess;
using MigrationTool;
using System.Configuration;
using Microsoft.RuleEngine;
using Microsoft.Web.Administration;
using System.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace BizTalkAdminOperations
{
    public partial class BizTalkAdminOperations : Form
    {
        #region Variables
        //operations variable
        string strWebSite, strAppPool, strCertificate, strHostInstance, strFileCopy, strBam, strHandlers, strGlobalPartyBinding, strBizTalkAssemblies, strServices;
        string strBizTalkApp, strExport;
        //flags
        readonly string strPerformOperationYes, strPerformOperationNo, strSuccess;
        string isAppPoolExecuted, isHostExecuted, isHandlerExecuted, isGlobalPartyBindingExecuted, isBizTalkAppExecuted;
        int strRoboCopySuccessCode;
        //user account will be used in WMI remoting  or PsExec remoting, while service account will be used for host instance.
        public string strUserName, strUserNameForWMI, strPassword, strDomain, strFromPanel10, strSrcNode, strDstNode, strIsUtilCopied;
        public string strUserNameForHost, strPasswordForHost; //this will act as service account, while other one will work as user account

        string fileFolderPath, vDir, machineName, exportedDataPath, appPath, msiPath, xmlPath, certPath, logPath, serviceFolderPath, brePath;
        string asmPath, customDllPath, gacUtilPath, dotNetExePath, psExecPath, serverXmlPath;
        string asmFolderName, gacUtilFolderName, certFolderName, customDllFolderName, remoteExeName, breFolderName;
        string srcSqlInstance, srcBAMSqlInstance, dstBAMSqlInstance, dstSqlInstance, loginOperationName, specFileExt, srcBRESqlInstance, dstBRESqlInstance;
        //app config
        string bizTalkAppToIgnore, bamExePath, remoteRootFolder, baseBizTalkAppCol, strCertPass, strFoldersToCopy, strFoldersToCopyNoFiles,strWebsitesFolder,strFoldersDrive,strServicesDrive;
        string strCustomDllToInclude, strToolMode, strServerType, strWindowsServiceToIgnore;

        public delegate void SetTextCallback(string strMsg);
        #endregion
        public BizTalkAdminOperations() //constructor
        {
            strWebSite = "n";
            strAppPool = "n";
            strCertificate = "n";
            strHandlers = "n";
            strGlobalPartyBinding = "n";
            strBizTalkAssemblies = "n";
            strBizTalkApp = "n";
            strFileCopy = "n";
            strPerformOperationYes = "y";
            strPerformOperationNo = "n";
            strSuccess = "1";
            strRoboCopySuccessCode = 8;
            InitializeComponent();

            appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            exportedDataPath = appPath + @"\ExportedData";

            fileFolderPath = exportedDataPath + "\\FileFolder";
            serviceFolderPath = exportedDataPath + "\\ServiceFolder";
            vDir = exportedDataPath + "\\VDir";

            msiPath = exportedDataPath + @"\MSI";
            xmlPath = exportedDataPath + @"\XMLFiles";  //xmlpath renamed to XmlBinding
            certFolderName = "\\CERT";
            certPath = exportedDataPath + certFolderName;//@"\CERT";
            breFolderName = "\\BRE";
            brePath = exportedDataPath + breFolderName;
            asmFolderName = "\\DLL";
            asmPath = exportedDataPath + asmFolderName;//@"\DLL";
            customDllFolderName = "\\CustomDLL";
            customDllPath = exportedDataPath + customDllFolderName;
            logPath = appPath + @"\Logs";
            gacUtilFolderName = "\\Util";
            gacUtilPath = appPath + gacUtilFolderName + "\\GacUtil.exe";
            psExecPath = appPath + gacUtilFolderName + "\\PsExec.exe";
            dotNetExePath = appPath + gacUtilFolderName + "\\RemoteOperations.exe";
            remoteExeName = "RemoteOperations.exe";
            serverXmlPath = xmlPath + "\\Servers.xml";

            specFileExt = "_Spec.xml";
            isAppPoolExecuted = strPerformOperationYes;
            isHostExecuted = strPerformOperationYes;
            isHandlerExecuted = strPerformOperationYes;
            isGlobalPartyBindingExecuted = strPerformOperationYes;
            isBizTalkAppExecuted = strPerformOperationYes;
            strIsUtilCopied = strPerformOperationNo;

            remoteRootFolder = System.Configuration.ConfigurationManager.AppSettings["RemoteRootFolder"].ToString();// +"\\" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            bamExePath = Environment.GetEnvironmentVariable("BTSINSTALLPATH").ToString() + @"Tracking\bm.exe";
            bizTalkAppToIgnore = System.Configuration.ConfigurationManager.AppSettings["BizTalkAppToIgnore"].ToString();
            baseBizTalkAppCol = System.Configuration.ConfigurationManager.AppSettings["AppToRefer"].ToString();
            strCertPass = System.Configuration.ConfigurationManager.AppSettings["CertPass"].ToString();
            strFoldersToCopy = System.Configuration.ConfigurationManager.AppSettings["FoldersToCopy"].ToString();
            strFoldersToCopyNoFiles = System.Configuration.ConfigurationManager.AppSettings["FoldersToCopyNoFiles"].ToString();
            strCustomDllToInclude = System.Configuration.ConfigurationManager.AppSettings["CustomDllToInclude"].ToString();
            strWindowsServiceToIgnore = System.Configuration.ConfigurationManager.AppSettings["WindowsServiceToIgnore"].ToString();
            strWebsitesFolder = System.Configuration.ConfigurationManager.AppSettings["WebSitesDriveDestination"].ToString();
            strFoldersDrive = System.Configuration.ConfigurationManager.AppSettings["FoldersDriveDestination"].ToString();
            strServicesDrive = System.Configuration.ConfigurationManager.AppSettings["ServicesDriveDestination"].ToString();

            strToolMode = "Backup";
            strServerType = "BizTalk";
            machineName = System.Environment.MachineName;
        }


        #region FileFolders

        private void btnExportFolders_Click(object sender, EventArgs e)
        {
            string strSrc = "";
            int returnCode;
            string strDst = "";
            string commandArguments = "";

            char[] chrSep = { ',' };

            try
            {
                LogInfo("Folders: Export started.");

                if (strServerType == "BizTalk" && (cmbBoxServerSrc.Items.Count == 0 || cmbBoxServerSrc.SelectedItem == null))
                {
                    LogShortErrorMsg("Please mention Src Sql Instance and select node from DropDown.");
                }
                else if (strServerType == "App" && strSrcNode == string.Empty)
                {
                    LogShortErrorMsg("Please mention Src App Server.");
                }
                else
                {
                    try
                    {
                        if (Directory.Exists(fileFolderPath))
                        {
                            Directory.Delete(fileFolderPath, true);
                            Directory.CreateDirectory(fileFolderPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error while cleaning file folder, hence aboting folder export " + ex.Message + ", " + ex.StackTrace);
                    }

                    if (strToolMode == "Backup") //if backup mode is set then copy to local.
                    {
                        try
                        {
                            if (strFoldersToCopyNoFiles != string.Empty)
                            {
                                //folders list from app.config, no files                                     
                                //Folders to copy, no files, from APP.Config                         
                                LogInfo("Exporting only folder structure with permissions, without files.");
                                string[] arrFoldersToCopyNoFiles = strFoldersToCopyNoFiles.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string folderPath in arrFoldersToCopyNoFiles)
                                {
                                    string folderPathTrimed = folderPath.Trim();
                                    string driveInfo = Path.GetPathRoot(folderPathTrimed);
                                    string driveLetter = driveInfo.Substring(0, 1);
                                    string pathWithoutDrive = folderPathTrimed.Substring(3, folderPathTrimed.Length - 3);
                                    strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                                    strDst = fileFolderPath + "\\" + folderPathTrimed.Substring(folderPath.LastIndexOf('\\'));//"\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                                    LogInfo("Copy started from:" + strSrc + " To " + strDst);
                                    commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPY:ATSOU /R:1";  //copy folders only with all permissons
                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                    if (returnCode < strRoboCopySuccessCode)
                                        LogShortSuccessMsg("Success: Exported Folders.");
                                    else
                                        LogShortErrorMsg("Failed: Exporting Folders");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogErrorInfo("Exception while copying folders as mentioned in other folder text box.");
                            LogException(ex);
                        }

                        try
                        {   //folders list from app.config                             
                            string genFolders = strFoldersToCopy;
                            if (genFolders != string.Empty)
                            {
                                LogInfo("Exporting both folder structure with permissons and files.");
                                string[] genFolderPath = genFolders.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);

                                foreach (string folderPath in genFolderPath)
                                {
                                    string folderPathTrimed = folderPath.Trim();
                                    string driveInfo = Path.GetPathRoot(folderPathTrimed);
                                    string driveLetter = driveInfo.Substring(0, 1);
                                    string pathWithoutDrive = folderPathTrimed.Substring(3, folderPathTrimed.Length - 3);
                                    strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                                    strDst = fileFolderPath + "\\" + folderPathTrimed.Substring(folderPath.LastIndexOf('\\'));
                                    LogInfo("Copy started from: " + strSrc + " To: " + strDst);
                                    commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /MIN:1 /R:1";  // /xc /xn /xo exclude existing file and folders
                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                    if (returnCode < strRoboCopySuccessCode)
                                        LogShortSuccessMsg("Success: Exported Folders/Files.");
                                    else
                                        LogShortErrorMsg("Failed: Exporting Folders/Files.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogErrorInfo("Exception while copying folders as mentioned in App.Config for FoldersToCopyWithFiles key.");
                            LogException(ex);
                        }
                    }
                    else
                    {
                        LogInfo("As Folder Copy Mode is set to Migration hence at Import Click Folders will be moved directly from Source to Destination.");
                    }
                }
                //SharePermissons
                GetSharePermission();
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void btnImportFolders_Click(object sender, EventArgs e)
        {
            string strSrc = "";
            int returnCode;
            string strDst = "";
            string commandArguments = "";

            char[] chrSep = { ',' };

            try
            {
                LogInfo("Folders: Import Started.");
                if (strServerType == "BizTalk" && (cmbBoxServerDst.Items.Count == 0 || cmbBoxServerDst.SelectedItem == null))
                {
                    LogShortErrorMsg("Please mention Dst Sql Instance and select node from DropDown.");
                }
                else if (strServerType == "App" && strDstNode == string.Empty)
                {
                    LogShortErrorMsg("Please mention Dst App Server.");
                }
                else
                {
                    if (strToolMode == "Migrate" && (strSrcNode == string.Empty || strSrcNode == null))
                        throw new Exception("Please select source node from dropdown.");

                    try
                    {
                        //folders list from app.config, no files                                     
                        //Folders to copy, no files, from APP.Config                        
                        if (strFoldersToCopyNoFiles != string.Empty)
                        {
                            LogInfo("Importing only folder strutcture with permissons, no files.");
                            string[] arrFoldersToCopyNoFiles = strFoldersToCopyNoFiles.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);

                            foreach (string folderPath in arrFoldersToCopyNoFiles)
                            {
                                string folderPathTrimed = folderPath.Trim();
                                string driveInfo = Path.GetPathRoot(folderPathTrimed);
                                string driveLetter = driveInfo.Substring(0, 1);
                                string pathWithoutDrive = folderPathTrimed.Substring(3, folderPathTrimed.Length - 3);

                                if (strToolMode == "Migrate") //if mirgration then source will be Src otherwise it will be local
                                    strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                                else
                                    strSrc = fileFolderPath + "\\" + folderPathTrimed.Substring(folderPath.LastIndexOf('\\'));
                                if(string.IsNullOrEmpty(strFoldersDrive)||string.IsNullOrWhiteSpace(strFoldersDrive))
                                strDst = "\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                                else
                                    strDst = "\\\\" + strDstNode + "\\" + strFoldersDrive.Trim().Substring(0,1) + "$\\" + pathWithoutDrive;
                                LogInfo("Copy started from: " + strSrc + " To " + strDst);
                                commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPY:ATSOU /R:1";  //copy folders only with all permissons
                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                if (returnCode < strRoboCopySuccessCode)
                                    LogShortSuccessMsg("Success: Imported Folders.");
                                else
                                    LogShortErrorMsg("Failed: Importing Folders.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LogErrorInfo("Exception while copying folders as mentioned in other folder text box.");
                        LogException(ex);
                    }


                    try
                    {   //folders list from app.config                     
                        string genFolders = strFoldersToCopy;
                        if (genFolders != string.Empty)
                        {
                            LogInfo("Importing both folder strutcture with permissons and files.");
                            string[] genFolderPath = genFolders.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);

                            foreach (string folderPath in genFolderPath)
                            {
                                string folderPathTrimed = folderPath.Trim();
                                string driveInfo = Path.GetPathRoot(folderPathTrimed);
                                string driveLetter = driveInfo.Substring(0, 1);
                                string pathWithoutDrive = folderPathTrimed.Substring(3, folderPathTrimed.Length - 3);

                                if (strToolMode == "Migrate")
                                    strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                                else
                                    strSrc = fileFolderPath + "\\" + folderPathTrimed.Substring(folderPath.LastIndexOf('\\'));

                              
                                    strDst = "\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                              
                                LogInfo("Copy started from: " + strSrc + " To " + strDst);
                                commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /MIN:1 /R:1";  // /xc /xn /xo exclude existing file and folders
                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                if (returnCode < strRoboCopySuccessCode)
                                    LogShortSuccessMsg("Success: Imported Folders/Files.");
                                else
                                    LogShortErrorMsg("Failed: Importing Folders/Files.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LogErrorInfo("Exception while copying folders as mentioned in App.Config for FoldersToCopyWithFiles key.");
                        LogException(ex);
                    }
                }

                SetSharePermission();
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        #endregion

        #region Host
        private void btnGetHost_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            XmlWriter xmlWriterApps = null; int result;
            try
            {
                LogInfo("Host Instances: Export started.");
                LogInfo("Connecting to BizTalkMgmtdb...." + txtConnectionString.Text);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SqlConnection("Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");

                sqlCmd.CommandText = "SELECT Name HostName,NTGroupName, cast(HostTracking as bit) HostTracking, cast(AuthTrusted as bit) Trusted, CASE WHEN HostType = 1 THEN 1 ELSE 0 END AS HostType, IsHost32BitOnly Is32Bit FROM adm_host";

                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAd = new SqlDataAdapter(sqlCmd);

                sqlDataAd.Fill(ds);

                ds.Tables[0].TableName = "Host";

                Hosts hosts = new Hosts();
                hosts.Host = new HostsHost[ds.Tables["Host"].Rows.Count];
                int i = 0;
                foreach (DataRow dRow in ds.Tables["Host"].Rows)
                {
                    hosts.Host[i] = new HostsHost();

                    hosts.Host[i].authenticationTrusted = Convert.ToBoolean(dRow["Trusted"]);
                    hosts.Host[i].hostTracking = Convert.ToBoolean(dRow["HostTracking"]);
                    hosts.Host[i].inProcess = Convert.ToBoolean(dRow["HostType"]);
                    hosts.Host[i].is32bit = Convert.ToBoolean(dRow["Is32Bit"]);
                    hosts.Host[i].isDefaultHost = false;
                    hosts.Host[i].name = dRow["HostName"].ToString();
                    hosts.Host[i].ntGroupName = dRow["NTGroupName"].ToString();

                    hosts.Host[i].HostInstance = new HostsHostHostInstance[1];
                    hosts.Host[i].HostInstance[0] = new HostsHostHostInstance();
                    hosts.Host[i].HostInstance[0].server = "";
                    hosts.Host[i].HostInstance[0].password = "";
                    hosts.Host[i].HostInstance[0].userName = "";

                    i++;
                }

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                //Add lib namespace with empty prefix
                ns.Add("", "");

                XmlSerializer x = new System.Xml.Serialization.XmlSerializer(hosts.GetType());
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;


                xmlWriterApps = XmlWriter.Create(xmlPath + @"\HostInstances.xml", xmlWriterSetting);
                x.Serialize(xmlWriterApps, hosts, ns);

                LogShortSuccessMsg("Success: Exported Host Instances.");
                //Exporting HostSettings
                LogInfo("Host Settings: Export started.");
                string commandArguments = "";
                string xmlPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(xmlPath);
                if (machineName == strSrcNode)
                {
                    commandArguments = "ExportSettings -Destination:\"" + xmlPathUnc + "\\" + "HostSettings.xml\"" + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                    //Create and start BTSTask.exe process                    
                    result = ExecuteCmd("BTSTask.exe", commandArguments);
                }
                else
                {
                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + " BTSTASK ExportSettings -Destination:\"" + xmlPathUnc + "\\" + "HostSettings.xml\"" + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                    result = ExecuteCmd("CMD.EXE", commandArguments);
                }

                if (result == 0)
                    LogShortSuccessMsg("Success: Exported Host Settings");
                else
                    LogShortErrorMsg("Failed: Exporting Host Settings.");
                //Exporting HostMapping Settings
                String[] files = Directory.GetFiles(xmlPath, "Src_*_HostMappings.xml");

                foreach (string file in files)
                {
                    File.Delete(file);
                }
                XmlDocument xd = new XmlDocument();
                if (machineName == strSrcNode)
                {
                    LogInfo("Host Mappings: Export started.");

                    ExportHostMapSettings();
                    LogShortSuccessMsg("Success: Exported Host Mappings.");
                }
                else//Remote
                {
                    LogInfo("Host Mappings: Export started.");
                    xd.Load(xmlPath + "\\" + "Servers.xml");
                    XmlNode srcnodeList = xd.DocumentElement.SelectSingleNode("/Servers");
                    string SrcServerList = srcnodeList.SelectSingleNode("SrcNodes").InnerText;
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                    remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportHostMapSettings\" \"" + txtConnectionString.Text.Trim() + "\" \"" + SrcServerList + "\"\"";
                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate app xml and save it back to local

                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Exported Host Mappings.");

                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Exporting Host Mappings.");

                    }

                }
                //Creating Src ServerList.xml
                xd.Load(serverXmlPath);
                if (File.Exists(xmlPath + "\\" + "SrcServers.xml"))
                    File.Delete(xmlPath + "\\" + "SrcServers.xml");
                xd.Save(xmlPath + "\\" + "SrcServers.xml");
                LogInfoInLogFile("Created SourceServerList");

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }

            // Cursor.Current = Cursors.Default;
        }

        private void btnSetHostAndHostInstances_Click(object sender, EventArgs e)
        {
            string commandArguments = "";
            int result = 0;

          //  string dstHostList = string.Empty, dstHostInstanceList = string.Empty;
            List<string> dstHostList = new List<string>();
            List<string> dstHostInstanceList = new List<string>();
            try
            {
                if (machineName == strDstNode)
                {
                    LogInfo("Host: Import started..");
                    if (!File.Exists(xmlPath + @"\HostInstances.xml"))
                        throw new Exception("HostInstances xml file does not exist.");
                    //check file is empty or not
                    XmlDocument doc = new XmlDocument();
                    doc.Load(xmlPath + "\\HostInstances.xml");
                    if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                        throw new Exception("HostInstances xml file is empty.");

                    XmlSerializer configSerializer = new XmlSerializer(typeof(Hosts));
                    Hosts input = (Hosts)configSerializer.Deserialize(new XmlTextReader(xmlPath + @"\HostInstances.xml"));

                    //get all HostInstances of 'InProcess' type.

                    ManagementObjectSearcher searchObject = null;
                    EnumerationOptions enumOptions = new EnumerationOptions();
                    enumOptions.ReturnImmediately = false;
                   

                    //Creating DestinationHostList
                    searchObject = new ManagementObjectSearcher("root\\MicrosoftBizTalkServer", "Select * from MSBTS_Host", enumOptions);
                    foreach (ManagementObject inst in searchObject.Get())
                    {
                        //dstHostList = dstHostList + inst["Name"].ToString().ToUpper() + ",";
                        dstHostList.Add(inst["Name"].ToString().ToUpper());
                    }
                    //Creating DestinationHosts
                    foreach (HostsHost host in input.Host)
                    {
                        if (!dstHostList.Contains(host.name.ToUpper()))
                        {
                            CreateHost(host.name, host.inProcess ? HostSetting.HostTypeValues.In_process : HostSetting.HostTypeValues.Isolated, host.ntGroupName, host.authenticationTrusted, host.hostTracking, host.is32bit,
                                host.isDefaultHost);
                        }
                        else
                            LogInfo("Host already exist: " + host.name);
                    }

                    int i = 0;
                    for (i = 0; i < cmbBoxServerDst.Items.Count; i++)
                    {
                        //Creating DestinationHostInstanceListForeachnode
                        dstHostInstanceList = new List<string>();
                        searchObject = new ManagementObjectSearcher("root\\MicrosoftBizTalkServer", "Select * from MSBTS_HostInstance", enumOptions);
                        foreach (ManagementObject inst in searchObject.Get())
                        {
                            if (inst["RunningServer"].ToString().ToUpper() == cmbBoxServerDst.Items[i].ToString())
                                // dstHostInstanceList = dstHostInstanceList + inst["HostName"].ToString().ToUpper() + ",";
                                dstHostInstanceList.Add(inst["HostName"].ToString().ToUpper());
                        }
                        //Create DestinationHostInstance for EachNode
                        foreach (HostsHost host in input.Host)
                        {
                            if (!dstHostInstanceList.Contains(host.name.ToUpper()))
                            {
                                CreateHostInstance(cmbBoxServerDst.Items[i].ToString(), host.name, strUserName, strPassword);
                            }
                            else
                                LogInfo("Host Instance already exist: " + host.name + " on " + cmbBoxServerDst.Items[i].ToString());
                        }
                    }

                    isHostExecuted = strPerformOperationYes;
                }
                else
                {
                   
                    string appPathUnc = ConvertPathToUncPath(appPath);

                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                    remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportHosts\" \"" + strUserNameForHost + "\" \"" + strPasswordForHost + "\"\"";
                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments); //dlls will be copied and pasted back to Local machine, hence machineName used in commandArgument.

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Imported Host and HostInstances.");
                    else
                        LogShortErrorMsg("Failed: Importing Host and HostInstances.");
                }
            }
            catch (Exception ex)
            {
                isHostExecuted = strPerformOperationNo;
                LogException(ex);
            }
            try
            {

                if (!(File.Exists(xmlPath + "\\" + "HostSettings.xml")))
                {
                    throw new Exception("Host Settings xml is not Present.");
                }

                String[] files = Directory.GetFiles(xmlPath, "Dst_*_HostMappings.xml");
                foreach (string file in files)
                {
                    File.Delete(file);
                }
                if (machineName == strDstNode)
                {
                    ImportHostMapSettings();
                }
                else
                {

                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                    remoteRootFolder + "\\" + remoteExeName + "\"  \"\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportHostMapSettings\" \"" + txtConnectionStringDst.Text.Trim() + "\"\"";
                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Created Destination Host Mapping Xml File");
                    else
                        LogShortErrorMsg("Failed: Creating Destination Host Mapping Xml File");
                }
                files = Directory.GetFiles(xmlPath, "Dst_*_HostMappings.xml");
                if (files.Length != 0)
                {
                    foreach (string file in files)
                    {
                        LogInfo("Host Settings: Import started.");
                        string xmlPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(xmlPath);
                        string filePathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(file);
                        if (machineName == strDstNode)
                        {
                            commandArguments = "ImportSettings -Source:\"" + xmlPathUnc + "\\" + "HostSettings.xml\"" + " -Map:\"" + filePathUnc + "\" -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            //Create and start BTSTask.exe process            
                            result = ExecuteCmd("BTSTask.exe", commandArguments);
                        }
                        else //Remote
                        {
                            commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + " BTSTASK ImportSettings -Source:\"" + xmlPathUnc + "\\" + "HostSettings.xml\"" + " -Map:\"" + filePathUnc + "\" -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            result = ExecuteCmd("CMD.EXE", commandArguments);
                        }

                        if (result == 0)
                            LogShortSuccessMsg("Success: Imported Host Settings on " + Path.GetFileNameWithoutExtension(file).Split('_')[1].Split('_')[0] + " Server.");
                        else
                            LogShortErrorMsg("Failed: Importing Host Settings on" + Path.GetFileNameWithoutExtension(file).Split('_')[1].Split('_')[0] + " Server.");
                    }
                }

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void CreateHost(string name, HostSetting.HostTypeValues hostType, string ntGroupName, bool authTrusted, bool hostTracking, bool is32bit, bool defaultHost)
        {
            HostSetting myHostSetting = null;
            try
            {
                if (machineName == strDstNode) //local 
                    myHostSetting = HostSetting.CreateInstance();
                else //remote
                    myHostSetting = HostSetting.CreateInstance(strDstNode, strUserNameForWMI, strPassword, strDomain);

                myHostSetting.AutoCommit = false;

                myHostSetting.Name = name;
                myHostSetting.HostType = hostType;
                myHostSetting.NTGroupName = ntGroupName;
                myHostSetting.AuthTrusted = authTrusted;
                myHostSetting.IsHost32BitOnly = is32bit;
                myHostSetting.HostTracking = hostTracking;
                myHostSetting.IsDefault = defaultHost;

                myHostSetting.CommitObject();

                LogShortSuccessMsg("Host created successfully: " + name);
            }

            catch (Exception ex)
            {
                LogShortErrorMsg("Error Creating Host: " + name);
                LogException(ex);
            }
        }

        private void CreateHostInstance(string serverName, string name, string userName, string password)
        {
            HostInstance myHostInstance = null;
            ServerHost myServerHost = null;
            try
            {
                if (machineName == strDstNode) //local 
                    myServerHost = ServerHost.CreateInstance();
                else //remote
                    myServerHost = ServerHost.CreateInstance(serverName, strUserNameForWMI, strPassword, strDomain);

                myServerHost.ServerName = serverName;
                myServerHost.HostName = name;
                myServerHost.Map();

                if (machineName == strDstNode) //local 
                    myHostInstance = HostInstance.CreateInstance();
                else
                    myHostInstance = HostInstance.CreateInstance(serverName, strUserNameForWMI, strPassword, strDomain);

                myHostInstance.Name = "Microsoft BizTalk Server " + name + " " + serverName;
                myHostInstance.Install(true, strUserNameForHost, strPasswordForHost);

                LogShortSuccessMsg("Host Instance created successfully: " + name + ", " + serverName);
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Error creating HostInstance: " + name + ", " + serverName);
                LogException(ex);
            }
        }
        #endregion

        #region Handlers
        private void btnImportAdapterHandler_Click(object sender, EventArgs e)
        {
            string Direction = "", dstRcvHandlerList = "", dstSndHandlerList = "", HostName = "", AdapterName = "";
            char[] charSeprator = { ',' };
            ManagementClass objRcvHandlerClass = null;
            ManagementClass objSndHandlerClass = null;

            try
            {
                LogInfo("Handlers: Import started");
                if (!File.Exists(xmlPath + @"\Handlers.xml"))
                    throw new Exception("Handlers xml file does not exist.");

                //check file is empty or not
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\Handlers.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("Handlers xml file is empty.");

                XmlSerializer configSerializer = new XmlSerializer(typeof(RcvSndHandlers));
                RcvSndHandlers rcvSndHandlers = (RcvSndHandlers)configSerializer.Deserialize(new XmlTextReader(xmlPath + @"\Handlers.xml"));

                ManagementObject objHandler = null;
                if (machineName == strDstNode) //local 
                {
                    objRcvHandlerClass = new ManagementClass("\\root\\MicrosoftBizTalkServer", "MSBTS_ReceiveHandler", null);
                    objSndHandlerClass = new ManagementClass("\\root\\MicrosoftBizTalkServer", "MSBTS_SendHandler2", null);
                }
                else //remote
                {
                    objRcvHandlerClass = new ManagementClass("\\\\" + strDstNode + "\\root\\MicrosoftBizTalkServer", "MSBTS_ReceiveHandler", null);
                    objSndHandlerClass = new ManagementClass("\\\\" + strDstNode + "\\root\\MicrosoftBizTalkServer", "MSBTS_SendHandler2", null);
                }
                PutOptions options = new PutOptions();
                options.Type = PutType.CreateOnly;

                //Get Rcv Handler List from Dst
                ManagementObjectSearcher searchObject = null;
                EnumerationOptions enumOptions = new EnumerationOptions();
                enumOptions.ReturnImmediately = false;
                searchObject = new ManagementObjectSearcher("root\\MicrosoftBizTalkServer", "Select * from MSBTS_ReceiveHandler", enumOptions);
                foreach (ManagementObject inst in searchObject.Get())
                {
                    dstRcvHandlerList = dstRcvHandlerList + inst["HostName"].ToString().ToUpper() + "_" + inst["AdapterName"].ToString().ToUpper() + ",";
                }
                string[] dstRcvHandlerArray = dstRcvHandlerList.Split(charSeprator, StringSplitOptions.RemoveEmptyEntries);
                //Get Snd Handler List from Dst                
                enumOptions.ReturnImmediately = false;
                searchObject = new ManagementObjectSearcher("root\\MicrosoftBizTalkServer", "Select * from MSBTS_SendHandler2", enumOptions);
                foreach (ManagementObject inst in searchObject.Get())
                {
                    dstSndHandlerList = dstSndHandlerList + inst["HostName"].ToString().ToUpper() + "_" + inst["AdapterName"].ToString().ToUpper() + ",";
                }
                string[] dstSndHandlerArray = dstSndHandlerList.Split(charSeprator, StringSplitOptions.RemoveEmptyEntries);
                //

                //create a ManagementClass object and spawn a ManagementObject instance           
                for (int i = 0; i < rcvSndHandlers.RcvSndHandler.Length; i++)
                {
                    try
                    {
                        Direction = rcvSndHandlers.RcvSndHandler[i].Direction;
                        HostName = rcvSndHandlers.RcvSndHandler[i].HostName;
                        AdapterName = rcvSndHandlers.RcvSndHandler[i].AdapterName;

                        if (Direction == "0")
                        {
                            if (Array.IndexOf(dstRcvHandlerArray, HostName.ToUpper() + "_" + AdapterName.ToUpper()) < 0)//!dstRcvHandlerList.Contains(HostName + "_" + AdapterName))
                            {
                                objHandler = objRcvHandlerClass.CreateInstance();
                                //set the properties for the Managementobject
                                objHandler["AdapterName"] = AdapterName;
                                objHandler["HostName"] = HostName;
                                //create the Managementobject
                                objHandler.Put(options);
                                LogShortSuccessMsg("Success: Receive handler created for: " + AdapterName + " and " + HostName);
                            }
                            else
                                LogInfo("Receive handler already exist for: " + AdapterName + " and " + HostName);
                        }
                        else
                        {
                            if (Array.IndexOf(dstSndHandlerArray, HostName.ToUpper() + "_" + AdapterName.ToUpper()) < 0)//if (!dstSndHandlerList.Contains(HostName.ToUpper() + "_" + AdapterName.ToUpper()))
                            {
                                objHandler = objSndHandlerClass.CreateInstance();
                                //set the properties for the Managementobject
                                objHandler["AdapterName"] = AdapterName;
                                objHandler["HostName"] = HostName;
                                //create the Managementobject
                                objHandler.Put(options);
                                LogShortSuccessMsg("Success: Send handler created for: " + AdapterName + " and " + HostName);
                            }
                            else
                                LogInfo("Send handler already exist for: " + AdapterName + " and " + HostName);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogShortErrorMsg("Error creating Handler: Adapter Name: " + AdapterName + ", HostName: " + HostName);
                        LogException(ex);
                    }
                }
                isHandlerExecuted = strPerformOperationYes;
            }
            catch (Exception ex)
            {
                isHandlerExecuted = strPerformOperationNo;
                LogException(ex);
            }

            //Cursor.Current = Cursors.WaitCursor;
        }

        private void btnExportAdapterHandlers_Click(object sender, EventArgs e)
        {
            XmlWriter xmlWriterApps = null;
            try
            {
                LogInfo("Handlers: Export started.");
                if (machineName == strSrcNode)//local
                {
                    LogInfo("Connecting to BizTalkMgmtdb...." + txtConnectionString.Text);
                    RcvSndHandlers rcvSndHandlers = new RcvSndHandlers();

                    // instantiate new instance of Explorer OM
                    BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                    // connection string to the BizTalk management database where the ports will be created
                    btsExp.ConnectionString = "Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";

                    //Get All Handlers
                    ReceiveHandlerCollection rcvHandCol = btsExp.ReceiveHandlers;
                    LogInfo("Conneceted");
                    SendHandlerCollection sndHandCol = btsExp.SendHandlers;

                    rcvSndHandlers.RcvSndHandler = new RcvSndHandlersRcvSndHandler[sndHandCol.Count + rcvHandCol.Count];

                    int i = 0;

                    foreach (ReceiveHandler rcvHandler in rcvHandCol)
                    {
                        if (rcvHandler.Host.Name != "BizTalkServerApplication" && rcvHandler.Host.Name != "BizTalkServerIsolatedHost")
                        {
                            rcvSndHandlers.RcvSndHandler[i] = new RcvSndHandlersRcvSndHandler();
                            rcvSndHandlers.RcvSndHandler[i].AdapterName = rcvHandler.TransportType.Name;
                            rcvSndHandlers.RcvSndHandler[i].Direction = "0";
                            rcvSndHandlers.RcvSndHandler[i].HostName = rcvHandler.Host.Name;
                            i++;
                        }
                    }

                    foreach (SendHandler sndHandler in sndHandCol)
                    {
                        if (sndHandler.Host.Name != "BizTalkServerApplication" && sndHandler.Host.Name != "BizTalkServerIsolatedHost")
                        {
                            rcvSndHandlers.RcvSndHandler[i] = new RcvSndHandlersRcvSndHandler();
                            rcvSndHandlers.RcvSndHandler[i].AdapterName = sndHandler.TransportType.Name;
                            rcvSndHandlers.RcvSndHandler[i].Direction = "1";
                            rcvSndHandlers.RcvSndHandler[i].HostName = sndHandler.Host.Name;
                            i++;
                        }
                    }

                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                    //Add lib namespace with empty prefix
                    ns.Add("", "");

                    XmlSerializer x = new System.Xml.Serialization.XmlSerializer(rcvSndHandlers.GetType());
                    XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                    xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;


                    xmlWriterApps = XmlWriter.Create(xmlPath + @"\Handlers.xml", xmlWriterSetting);
                    x.Serialize(xmlWriterApps, rcvSndHandlers, ns);
                    LogShortSuccessMsg("Success: Exported Handlers.");
                }
                else  //remote
                {
                    LogInfo("Getting handlers from remote machine.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                    remoteRootFolder + "\\" + remoteExeName + "\"  \"\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportHandler\" \"" + txtConnectionString.Text.Trim() + "\"\"";
                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Exported Handlers.");
                    else
                        LogShortErrorMsg("Failed: Exporting Handlers.");
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }
        }
        #endregion

        #region Log Methods

        private void LogShortSuccessMsg(string pShortMsg)
        {
            int startIndex = richTextBoxLogs.TextLength;
            richTextBoxLogs.AppendText(pShortMsg);
            int endIndex = richTextBoxLogs.TextLength;

            richTextBoxLogs.Select(startIndex, endIndex - startIndex);
            richTextBoxLogs.SelectionColor = Color.DarkGreen;
            richTextBoxLogs.AppendText(System.Environment.NewLine);

            try
            {
                using (StreamWriter writer = new StreamWriter(logPath + @"\MigrationTool_log.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + pShortMsg);
                }
            }
            catch (Exception logEx)
            {
                richTextBoxLogs.AppendText(System.Environment.NewLine);
                richTextBoxLogs.AppendText("Exception Message while writing in log file:  " + logEx.Message.ToString());
            }

        } //UI

        private void LogShortErrorMsg(string pShortErrorMsg) //UI
        {
            int startIndex = richTextBoxLogs.TextLength;
            richTextBoxLogs.AppendText(pShortErrorMsg);
            int endIndex = richTextBoxLogs.TextLength;

            richTextBoxLogs.Select(startIndex, endIndex - startIndex);
            richTextBoxLogs.SelectionColor = Color.DarkRed;

            richTextBoxLogs.AppendText(System.Environment.NewLine);

            try
            {
                using (StreamWriter writer = new StreamWriter(logPath + @"\MigrationTool_log.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + pShortErrorMsg);
                }
            }
            catch (Exception logEx)
            {
                richTextBoxLogs.AppendText(System.Environment.NewLine);
                richTextBoxLogs.AppendText("Exception Message while writing in log file:  " + logEx.Message.ToString());
            }
        }

        private void LogException(Exception ex)  //UI FILLE
        {
            int startIndex = richTextBoxLogs.TextLength;
            richTextBoxLogs.AppendText("Exception Message:  " + ex.Message.ToString());

            int endIndex = richTextBoxLogs.TextLength;

            richTextBoxLogs.Select(startIndex, endIndex - startIndex);
            richTextBoxLogs.SelectionColor = Color.DarkRed;
            richTextBoxLogs.AppendText(System.Environment.NewLine);

            richTextBoxLogs.Refresh();
            try
            {
                using (StreamWriter writer = new StreamWriter(logPath + @"\MigrationTool_log.txt", true))
                {
                    writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + "Exception Message:  " + ex.Message.ToString());
                    writer.WriteLine("Inner Exception:  " + ex.InnerException);
                    writer.WriteLine("StackTrace:  " + ex.StackTrace);
                }
            }
            catch (Exception logEx)
            {
                richTextBoxLogs.AppendText(System.Environment.NewLine);
                richTextBoxLogs.AppendText("Exception Message while writing in log file:  " + logEx.Message.ToString());
            }
        }

        public void LogInfo(string strMsg) //UI FILLE
        {
            if (!(string.IsNullOrEmpty(strMsg)) && !(string.IsNullOrWhiteSpace(strMsg)))
            {
                richTextBoxLogs.AppendText(strMsg);
                richTextBoxLogs.AppendText(System.Environment.NewLine);
                richTextBoxLogs.Refresh();

                try
                {
                    using (StreamWriter writer = new StreamWriter(logPath + @"\MigrationTool_log.txt", true))
                    {
                        writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + strMsg);
                    }
                }
                catch (Exception logEx)
                {
                    richTextBoxLogs.AppendText("Exception while writing info log file:  " + logEx.Message.ToString());
                }
            }
        }

        public void LogInfoInLogFile(string strMsg) //FILE 
        {
            if (!(string.IsNullOrEmpty(strMsg)) && !(string.IsNullOrWhiteSpace(strMsg)))
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(logPath + @"\MigrationTool_log.txt", true))
                    {
                        writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + strMsg);
                    }
                }
                catch (Exception logEx)
                {
                    richTextBoxLogs.AppendText(System.Environment.NewLine);
                    richTextBoxLogs.AppendText("Exception while writing info log file:  " + logEx.Message.ToString());
                }
            }
        }

        public void LogInfoSyncronously(string strMsg) //FILLE
        {
            try
            {
                if (!(string.IsNullOrEmpty(strMsg)) && !(string.IsNullOrWhiteSpace(strMsg)))
                {
                    using (StreamWriter writer = new StreamWriter(logPath + @"\MigrationTool_log.txt", true))
                    {
                        writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + strMsg);
                    }
                }

            }
            catch (Exception logEx)
            {
                richTextBoxLogs.AppendText(System.Environment.NewLine);
                richTextBoxLogs.AppendText("Exception while writing info in log file:  " + logEx.Message.ToString());
            }
        }

        private void LogErrorInfo(string strMsg)  //FILE
        {
            try
            {
                if (!(string.IsNullOrEmpty(strMsg)) && !(string.IsNullOrWhiteSpace(strMsg)))
                {
                    using (StreamWriter writer = new StreamWriter(logPath + @"\RemoteOperation_log.txt", true))
                    {
                        writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + strMsg);//"-------------------------------------------------------");                    
                    }
                }
            }
            catch (Exception logEx)
            {
                richTextBoxLogs.AppendText(System.Environment.NewLine);
                richTextBoxLogs.AppendText("Exception while writing info in log file:  " + logEx.Message.ToString());
            }
        }

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            LogInfoSyncronously(e.Data);
        }

        void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            LogErrorInfo(e.Data);
        }
        #endregion

        #region BizTalk App
        private int btnGetApplicationList_Click(object sender, EventArgs e)
        {
            Hashtable htApps = null;
            XmlSerializer x = null;
            XmlWriter xmlWriterApps = null;
            try
            {
                LogInfo("BizTalk App: Getting List.");
                try
                {

                    if (File.Exists(xmlPath + @"\Apps.xml"))  //delete older version
                    {
                        File.Delete(xmlPath + @"\Apps.xml");
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    throw new Exception("Error while deleting existing Apps.xml file.");
                }
                if (machineName == strSrcNode) //local
                {
                    BizTalkApplications bizTalkApps = new BizTalkApplications();

                    // instantiate new instance of Explorer OM
                    BtsCatalogExplorer btsExp = new BtsCatalogExplorer();
                    LogInfo("Connecting to BizTalkMgmtdb...." + txtConnectionString.Text);
                    // connection string to the BizTalk management database where the ports will be created
                    btsExp.ConnectionString = "Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                    //Get All Applications
                    Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol = btsExp.Applications;
                    LogInfo("Connected.");

                    htApps = new Hashtable();
                    MSIAPP(appCol, htApps);

                    int i = 0;

                    bizTalkApps.BizTalkApplication = new BizTalkApplicationsBizTalkApplication[htApps.Count];

                    foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
                    {
                        if (!bizTalkAppToIgnore.Contains(app.Name)) //ignore existing system apps
                        {
                            bizTalkApps.BizTalkApplication[i] = new BizTalkApplicationsBizTalkApplication();
                            bizTalkApps.BizTalkApplication[i].DependencyCode = htApps[app.Name].ToString();
                            bizTalkApps.BizTalkApplication[i].ApplicationName = app.Name;
                            i++;
                        }
                    }

                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                    //Add lib namespace with empty prefix
                    ns.Add("", "");

                    x = new System.Xml.Serialization.XmlSerializer(bizTalkApps.GetType());
                    XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                    xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;

                    xmlWriterApps = XmlWriter.Create(xmlPath + @"\Apps.xml", xmlWriterSetting);
                    x.Serialize(xmlWriterApps, bizTalkApps, ns);
                    LogInfo("Success: Created Apps.xml.");
                    return 0;
                }
                else //remote
                {
                    LogInfo("Getting App list from remote machine.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                    remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportAppList\" \"" + txtConnectionString.Text.Trim() + "\" \"" + bizTalkAppToIgnore + "\"\"";
                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate app xml and save it back to local

                    if (returnCode == 0)
                    {
                        LogInfo("Success: Created Apps.xml.");
                        return 0;
                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Creating Apps.xml.");
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
                return 1;
            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }
        }
        private void btnImportApps_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                LogInfo("BizTalk App: Import Started.");
                if (!File.Exists(xmlPath + @"\Apps.xml"))
                    throw new Exception("Apps xml file does not exist.");

                //check file is empty or not
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\Apps.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("Apps xml file is empty.");

                try
                {
                    if (File.Exists(xmlPath + @"\AppsToImport.xml"))  //delete older version
                    {
                        File.Delete(xmlPath + @"\AppsToImport.xml");
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    throw new Exception("Error while deleting existing AppsToImport.xml file.");
                }

                UpdateAppXmlFile();

                //check file is empty or not                
                doc.Load(xmlPath + "\\AppsToImport.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("AppsToImport xml file is empty.");

                //read new updated App List
                XElement xelement = XElement.Load(xmlPath + @"\AppsToImport.xml");

                var appList = (from element in xelement.Descendants("BizTalkApplication")
                               let dCode = (int)element.Attribute("DependencyCode")
                               orderby dCode descending
                               select new
                               {
                                   DcodeAppName = dCode.ToString() + "," + element.Attribute("ApplicationName").Value
                               })
                       .ToList();

                int appcount = appList.Count;
                string appName = string.Empty;

                char[] charSeprator = { ',' };
                string commandArguments = "";

                LogInfo("Total Apps: " + appcount.ToString());

                string msiPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(msiPath);
                for (int i = 0; i < appcount; i++)
                {
                    // instantiate new instance of Explorer OM                
                    BtsCatalogExplorer btsExp = new BtsCatalogExplorer();
                    // connection string to the BizTalk management database where the ports will be created
                    btsExp.ConnectionString = "Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";

                    appName = appList[i].DcodeAppName.Split(charSeprator)[1].ToString();

                    LogInfo(": Current Sequence:" + (i + 1).ToString() + ": App Name:" + appName);

                    if (machineName == strDstNode) //local
                    {
                        if (File.Exists(msiPath + "\\" + appName + ".msi"))
                        {
                            //Import MSI
                            commandArguments = "ImportApp -Package:\"" + msiPath + "\\" + appName + ".msi\"" + " -ApplicationName:\"" +
                                           appName + "\" -Overwrite -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            //Create and start BTSTask.exe process                    
                            result = ExecuteCmd("BTSTask.exe", commandArguments);

                            if (result == 0)
                                LogShortSuccessMsg("Success: Imported App.");
                            else
                                LogShortErrorMsg("Failed: Importing App.");
                        }
                        else
                        {
                            //Create App
                            LogInfo("MSI file does not exist for: " + appName);
                            commandArguments = "addapp -ApplicationName:\"" + appName + "\" -Description:\"BizTalk application for " + appName + "\" -Server:\"" + txtConnectionStringDst.Text.Trim()
                                + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            result = ExecuteCmd("BTSTask.exe", commandArguments);
                            if (result == 0) //success
                            {
                                LogShortSuccessMsg("Success: Created App.");
                                try
                                {
                                    //start adding dependent app Ref
                                    Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol = btsExp.Applications;
                                    foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
                                    {
                                        if (app.Name == appName)
                                        {
                                            string[] baseBizTalkApp = baseBizTalkAppCol.Split(charSeprator, StringSplitOptions.RemoveEmptyEntries);
                                            for (int baseAppCount = 0; baseAppCount < baseBizTalkApp.Length; baseAppCount++)
                                            {
                                                foreach (Microsoft.BizTalk.ExplorerOM.Application baseApp in appCol)
                                                {
                                                    if (baseApp.Name.Equals(baseBizTalkApp[baseAppCount].Trim())) //Update function for compare value//
                                                    {
                                                        app.AddReference(baseApp);
                                                        LogInfo("Success: Added reference of: " + baseApp.Name);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    btsExp.SaveChanges();
                                }
                                catch (Exception ex)
                                {
                                    LogShortErrorMsg("Failed: Adding reference of dependent Apps." + ex.Message);
                                }
                                finally
                                {
                                }
                            }
                            else
                                LogShortErrorMsg("Failed: Creating App.");
                        }

                    }
                    else //remote
                    {
                        if (File.Exists(msiPath + "\\" + appName + ".msi"))
                        {
                            //Import MSI, Set arguments for BTSTask.exe               
                            commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword
                                + "\"" + " -accepteula" + " BTSTask ImportApp -Package:\"" + msiPathUnc + "\\" + appName + ".msi\"" + " -ApplicationName:\"" +
                                           appName + "\" -Overwrite -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                            
                            //Create and start BTSTask.exe process                    
                            result = ExecuteCmd("CMD.exe", commandArguments);

                            if (result == 0)
                                LogShortSuccessMsg("Success: Imported App.");
                            else
                                LogShortErrorMsg("Failed: Importing App.");
                        }
                        else
                        {   //Create App                            
                            LogInfo("MSI file does not exist for: " + appName);
                            commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword
                                + "\"" + " -accepteula" + " BTSTask addapp -ApplicationName:\"" + appName + "\" -Description:\"BizTalk application for " + appName
                                + "\" -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                            //Create and start BTSTask.exe process                    
                            result = ExecuteCmd("CMD.exe", commandArguments);
                            if (result == 0) //success
                            {
                                LogShortSuccessMsg("Success: Created App.");
                                try
                                {
                                    Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol = btsExp.Applications;
                                    foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
                                    {
                                        if (app.Name == appName)
                                        {
                                            string[] baseBizTalkApp = baseBizTalkAppCol.Split(charSeprator, StringSplitOptions.RemoveEmptyEntries);
                                            for (int baseAppCount = 0; baseAppCount < baseBizTalkApp.Length; baseAppCount++)
                                            {
                                                foreach (Microsoft.BizTalk.ExplorerOM.Application baseApp in appCol)
                                                {
                                                    if (baseApp.Name == baseBizTalkApp[baseAppCount].Trim())
                                                    {
                                                        app.AddReference(baseApp);
                                                        LogInfo("Success: Added reffernce of: " + baseApp);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    btsExp.SaveChanges();
                                }
                                catch (Exception ex)
                                {
                                    LogShortErrorMsg("Failed: Adding reference of dependent Apps." + ex.Message);
                                }
                            }
                            else
                                LogShortErrorMsg("Failed: Creating App.");
                        }
                    }
                    if (result != 0)  //error
                    {
                        if (baseBizTalkAppCol.Contains(appName))
                        {
                            isBizTalkAppExecuted = strPerformOperationNo;
                            LogShortErrorMsg("Application: " + appName + " import failed hence remainng apps won't be imported.");
                        }
                    }
                    else //import Binding
                    {
                        if (machineName == strDstNode) //local
                        {
                            commandArguments = "ImportBindings  -Source:\"" + msiPathUnc + "\\" + appName + "_Binding.xml\"" + " -ApplicationName:\"" +
                                       appName + "\" -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            result = ExecuteCmd("BTSTask.exe", commandArguments);

                        }
                        else //remote
                        {
                            commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword
                                 + "\"" + " -accepteula" + " BTSTask ImportBindings  -Source:\"" + msiPathUnc + "\\" + appName + "_Binding.xml\"" + " -ApplicationName:\"" +
                                       appName + "\" -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                            
                            result = ExecuteCmd("CMD.exe", commandArguments);
                        }

                        if (result == 0)
                            LogShortSuccessMsg("Success: Imported Binding.");
                        else
                            LogShortErrorMsg("Failed: Importing Binding.");
                    }
                    //if there was  error while importing msi and msi is one show stopper msi then break loop, do not import other MSI. for example MSI EBIS
                    if (isBizTalkAppExecuted == strPerformOperationNo)
                    {
                        isGlobalPartyBindingExecuted = strPerformOperationNo;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                isGlobalPartyBindingExecuted = strPerformOperationNo;
                LogException(ex);
            }


        }

        private void btnExportApps_Click(object sender, EventArgs e)
        {
            string appName = string.Empty;
            char[] charSeprator = { ',' };
            string commandArguments = "";
            int result;
            string cmdName = "CMD.EXE";

            try
            {
                LogInfo("BizTalk App: Export started.");
                if (btnGetApplicationList_Click(sender, e) == 0)
                {
                    XElement xelement = XElement.Load(xmlPath + @"\Apps.xml");

                    var appList = (from element in xelement.Descendants("BizTalkApplication")
                                   let dCode = (int)element.Attribute("DependencyCode")
                                   orderby dCode descending
                                   select new
                                   {
                                       DcodeAppName = dCode.ToString() + "," + element.Attribute("ApplicationName").Value
                                   })
                           .ToList();

                    int appcount = appList.Count;

                    LogInfo("Total Apps: " + appcount.ToString());
                    string msiPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(msiPath);

                    //clean MSI directory
                    try
                    {
                        Directory.Delete(msiPath, true);
                        Directory.CreateDirectory(msiPath);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error while cleaning MSI folder, " + ex.Message + ", " + ex.StackTrace);
                    }
                    for (int i = 0; i < appcount; i++)
                    {
                        appName = appList[i].DcodeAppName.Split(charSeprator)[1].ToString();

                        LogInfo("Current Sequence:" + (i + 1).ToString() + ": App Name:" + appName);

                        //get Spec File
                        if (machineName == strSrcNode)
                        {
                            commandArguments = "ListApp -ApplicationName:\"" + appName + "\" -ResourceSpec:\"" +
                                                    msiPathUnc + "\\" + appName + specFileExt + "\"" + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            result = ExecuteCmd("BTSTASK.exe", commandArguments);
                        }
                        else
                        {
                            commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + " BTSTASK ListApp -ApplicationName:\"" + appName + "\" -ResourceSpec:\"" +
                                                    msiPathUnc + "\\" + appName + specFileExt + "\"" + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                            result = ExecuteCmd(cmdName, commandArguments);
                        }

                        if (result == 0)
                            LogShortSuccessMsg("Success: Exported Spec file.");
                        else
                            LogShortErrorMsg("Failed: Exporting Spec file.");


                        // edit resource file 
                        result = UpdateResourceSpecFile(appName);

                        //export MSI using spec file.    
                        if (machineName == strSrcNode)
                        {
                            commandArguments = "ExportApp -ApplicationName:\"" + appName + "\" -Package:\"" +
                                                msiPathUnc + "\\" + appName + ".msi\"" + " -ResourceSpec:\"" + msiPathUnc + "\\" + appName + specFileExt + "\"" + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            result = ExecuteCmd("BTSTASK.exe", commandArguments);
                        }
                        else
                        {
                            commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + " BTSTASK ExportApp -ApplicationName:\"" + appName + "\" -Package:\"" +
                                                msiPathUnc + "\\" + appName + ".msi\"" + " -ResourceSpec:\"" + msiPathUnc + "\\" + appName + specFileExt + "\"" + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                            result = ExecuteCmd(cmdName, commandArguments);
                        }

                        if (result == 0)
                            LogShortSuccessMsg("Success: Exported MSI file.");
                        else
                            LogShortErrorMsg("Failed: Exporting MSI file.");

                        //export Binding   
                        if (machineName == strSrcNode)
                        {
                            commandArguments = "ExportBindings -Destination:\"" + msiPathUnc + "\\" + appName + "_Binding.xml\"" + " -ApplicationName:\"" + appName + "\"" +
                                                      " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
                            result = ExecuteCmd("BTSTASK.exe", commandArguments);
                        }
                        else
                        {
                            commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + " BTSTASK ExportBindings -Destination:\"" + msiPathUnc + "\\" + appName + "_Binding.xml\"" + " -ApplicationName:\"" + appName + "\"" +
                                                      " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                            result = ExecuteCmd(cmdName, commandArguments);
                        }

                        if (result == 0)
                            LogShortSuccessMsg("Success: Exported Binding file.");
                        else
                            LogShortErrorMsg("Failed: Exporting Binding file.");
                        //Export BRE Policies and Vocabualries which are not Part of MSI

                    }
                }
                else
                    LogShortErrorMsg("Failed: Exporting Apps.");

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
         

        }
        #endregion

        #region GlobalPartyBinding
        private void btnExportGlobalPartyBinding_Click(object sender, EventArgs e)
        {
            string commandArguments;
            string cmdName = "CMD.exe";

            string xmlPathUnc = ConvertPathToUncPath(xmlPath);

            if (machineName == strSrcNode)//local
            {
                cmdName = "BTSTASK.exe";
                LogInfo("Global PartyBinding: Export started.");
                commandArguments = "ExportBindings -Destination:\"" + xmlPath + "\\"
                   + "GlobalPartyBinding.xml\"  -GlobalParties " + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"";
            }
            else //remote
            {
                cmdName = "CMD.EXE";
                LogInfo("Global PartyBinding: Export started from remote server.");
                commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword
                    + "\"" + " -accepteula" + " BTSTask ExportBindings -Destination:\"" + "\\\\" + machineName + "\\" + xmlPathUnc + "\\" +
                     "GlobalPartyBinding.xml\"  -GlobalParties " + " -Server:\"" + txtConnectionString.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
            }

            int returnCode;
            returnCode = ExecuteCmd(cmdName, commandArguments);
            if (returnCode == 0) //BTSTASK success code
            {
                LogShortSuccessMsg("Success: Global PartyBinding Exported.");
            }
            else
            {
                LogShortErrorMsg("Failed:  Exporting Global PartyBinding.");
            }
            try
            {
                try
                {
                    if (Directory.Exists(brePath))
                    {
                        Directory.Delete(brePath, true);
                        Directory.CreateDirectory(brePath);
                    }
                    else
                    {
                        Directory.CreateDirectory(brePath);
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error while cleaning Policies or Vocabulary folder, hence aborting  export " + ex.Message + ", " + ex.StackTrace);
                }
                if (machineName == strSrcNode)
                {
                    LogInfo("BRE: Export started.");
                    ExportBrePolicyVocabulary();
                    LogShortSuccessMsg("Success: Exported BRE.");
                }
                else
                {
                    LogInfo("BRE: Export started.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                   remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportBREList\" \"" + txtConnectionString.Text.Trim() + "\" \"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local
                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Exported BRE Polices and Vocabualaries.xml.");

                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Exporting BrePolicies and Vocabularies");

                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
          

        }

        private void btnImportGlobalPartyBinding_Click(object sender, EventArgs e)
        {
            string cmdName = "CMD.EXE";
            string commandArguments;
            int returnCode;
            string xmlPathUnc = ConvertPathToUncPath(xmlPath);

            try
            {
                LogInfo("Global Party Binding: Import started.");
                if (!File.Exists(xmlPath + @"\GlobalPartyBinding.xml"))
                    throw new Exception("GlobalPartyBinding xml file does not exist.");

                //check file is empty or not
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\GlobalPartyBinding.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("GlobalPartyBinding xml file is empty.");

                if (machineName == strDstNode)//local
                {
                    cmdName = "BTSTASK.exe";
                    commandArguments = "ImportBindings -Source:\"" + xmlPath + "\\" + "GlobalPartyBinding.xml\"" + " -Server:\"" + txtConnectionStringDst.Text.Trim() +
                        "\" -Database:\"" + "BizTalkMgmtDb\"";
                }
                else //remote
                {
                    cmdName = "CMD.EXE";
                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" +
                        " BTSTask ImportBindings -Source:\"" + "\\\\" + machineName + "\\" + xmlPathUnc + "\\" + "GlobalPartyBinding.xml\"" +
                        " -Server:\"" + txtConnectionStringDst.Text.Trim() + "\" -Database:\"" + "BizTalkMgmtDb\"\"";
                }

                returnCode = ExecuteCmd(cmdName, commandArguments);
                if (returnCode == 0)
                {
                    LogShortSuccessMsg("Success: Imported Global Party Binding.");
                }
                else
                {
                    LogShortErrorMsg("Failed: Importing Global Party Binding.");
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            try
            {
                if (machineName == strDstNode) //local
                {
                    LogInfo("BRE: Import Started.");
                    ImportBrePolicyVocabulary();
                    LogShortSuccessMsg("Success: Imported BRE.");
                }
                else
                {
                    LogInfo("BRE: Import Started.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                   remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportBREList\" \"" + txtConnectionStringDst.Text.Trim() + "\" \"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local
                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Imported BRE Polices and Vocabualaries.xml.");

                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Importing BRE Polices and Vocabularies");

                    }
                }
            }
            catch (Exception ex)
            {

                LogException(ex);
            }
         
        }
        #endregion

        #region WebSite AppPools
        private void btnExportAppPools_Click(object sender, EventArgs e)
        {
            LogInfo("App Pool: Export started.");

            if (File.Exists(xmlPath + @"\AppPools.xml")) //Create a Fresh Copy
                File.Delete(xmlPath + @"\AppPools.xml");

            string commandArguments = string.Empty;

            if (machineName == strSrcNode) //local            
                commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list apppool /config /xml /> \"" + xmlPath + "\\AppPools.xml" + "\"";
            else  //remote            
                commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                    + "  C:\\windows\\system32\\inetsrv\\appcmd.exe list apppool /config /xml /> \"" + xmlPath + "\\AppPools.xml" + "\"\"";

            int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
            if (returnCode == 0)
                LogShortSuccessMsg("Success: Exported AppPools.");
            else
                LogShortErrorMsg("Failed: Exporting AppPools.");
            try
            {
                //Encrypting Passwords
                if (File.Exists(xmlPath + @"\AppPools.xml"))
                {
                    FileInfo fileInfo = new FileInfo(xmlPath + @"\AppPools.xml");
                    fileInfo.IsReadOnly = false;
                    fileInfo.Refresh();
                    XmlDocument xmldoc = new XmlDocument();

                    xmldoc.Load(xmlPath + @"\AppPools.xml");
                    XmlNodeList nodeList = xmldoc.DocumentElement.SelectNodes("/appcmd/APPPOOL/add/processModel");
                    foreach (XmlNode node in nodeList)
                    {
                        if (node.Attributes != null && node.Attributes["password"] != null)
                        {
                            string password = node.Attributes["password"].Value;
                            node.Attributes["password"].Value = Encrypt(password);
                        }
                    }
                    xmldoc.Save(xmlPath + @"\AppPools.xml");
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void btnImportAppPools_Click(object sender, EventArgs e)
        {
            string commandArguments;
            int returnCode;
            try
            {
                LogInfo("App Pool: Import started.");
                if (!File.Exists(xmlPath + @"\AppPools.xml"))
                    throw new Exception("AppPools xml file does not exist.");

                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\AppPools.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("AppPools xml file is empty.");

                //Genrate AppPool List from Dst
                if (machineName == strDstNode) //local                
                    commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list apppool /text:APPPOOL.NAME  > \"" + xmlPath + "\\AppPoolList.txt" + "\"";
                else  //remote                
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                        + "  C:\\windows\\system32\\inetsrv\\appcmd.exe list apppool /text:APPPOOL.NAME  > \"" + xmlPath + "\\AppPoolList.txt" + "\"\"";
                //execute
                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                if (returnCode == 0)
                    LogInfo("Success: Created AppPoolList.txt.");
                else
                {
                    try
                    {
                        string[] dstAppPoolTemp = System.IO.File.ReadAllLines(xmlPath + "\\AppPoolList.txt");
                        if (dstAppPoolTemp.Length == 0)
                        {
                            //empty file, may be no web site in destination. in this case non zere error code of appcmd can be ignored.
                            //if no file is genrated in that case first line in try will genrate exception which will abort import process.
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed: Creating AppPoolList.txt from Dst." + Environment.NewLine + ex.Message, ex.InnerException);
                    }
                }
                //Delete AppPools from Xmls which alread there in Dst
                UpdateAppPoolXml();

                doc = new XmlDocument();
                doc.Load(xmlPath + "\\AppPoolToImport.xml");


                if (doc.DocumentElement.ChildNodes.Count > 0)//if file not empty.
                {
                    // Decrypting Password
                    XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/appcmd/APPPOOL/add/processModel");
                    foreach (XmlNode node in nodeList)
                    {
                        if (node.Attributes != null && node.Attributes["password"] != null)
                        {
                            string password = node.Attributes["password"].Value;
                            node.Attributes["password"].Value = Decrypt(password);
                        }
                    }
                    doc.Save(xmlPath + "\\AppPoolToImport.xml");


                    //actual AppPool Import
                    if (machineName == strDstNode) //local                
                        commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe add apppool /in /xml < \"" + xmlPath + "\\AppPoolToImport.xml" + "\"";
                    else  //remote 
                    {
                        //commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                        //    + "  C:\\windows\\system32\\inetsrv\\appcmd.exe add apppool /in /xml < \"" + xmlPath + "\\AppPoolToImport.xml" + "\"\"";
                        string appPathUnc = ConvertPathToUncPath(appPath);
                        commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                                remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"ImportAppPool\"\"";
                    }
                    //execute  
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Imported AppPools.");
                    else
                        LogShortErrorMsg("Failed: Importing AppPools.");

                    //Encrypting Back Password
                    foreach (XmlNode node in nodeList)
                    {
                        if (node.Attributes != null && node.Attributes["password"] != null)
                        {
                            string password = node.Attributes["password"].Value;
                            node.Attributes["password"].Value = Encrypt(password);
                        }
                    }
                    doc.Save(xmlPath + "\\AppPoolToImport.xml");

                }
                else
                    LogInfo("AppPoolToImport.xml is empty.");
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void btnExportWebSites_Click(object sender, EventArgs e)
        {
            string commandArguments = string.Empty;
            int returnCode;

            try
            {
                LogInfo("WebSite: Export started.");

                if (strToolMode == "Backup")
                {
                    try
                    {
                        if (Directory.Exists(vDir))
                        {
                            Directory.Delete(vDir, true);
                            Directory.CreateDirectory(vDir);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error while cleaning Virtual Directory folder, hence aborting folder export " + ex.Message + ", " + ex.StackTrace);
                    }
                }

                //export website list in txt file
                if (machineName == strSrcNode) //local
                {   //get list of Website in txt file, one line one website                
                    commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list site /text:name /> \"" + xmlPath + "\\SrcWebSiteList.txt" + "\"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                    if (returnCode == 0)
                        LogInfoInLogFile("Created SrcWebSiteList.txt.");
                    else
                    {
                        try
                        {
                            string[] srcLinesTemp = System.IO.File.ReadAllLines(xmlPath + "\\SrcWebSiteList.txt");
                            if (srcLinesTemp.Length == 0)
                            {
                                //empty file, may be no web site in destination. in this case non zere error code of appcmd can be ignored.
                                //if no file is genrated in that case first line in try will genrate exception which will abort import process.
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Failed: Creating SrcWebSiteList.txt" + Environment.NewLine + ex.Message, ex.InnerException);
                        }

                    }

                    commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list site /config /xml /> \"" + xmlPath + "\\WebSites.xml" + "\"";
                }
                else  //remote
                {
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                        + " C:\\windows\\system32\\inetsrv\\appcmd.exe list site /text:name /> \"" + xmlPath + "\\SrcWebSiteList.txt" + "\"\"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogInfoInLogFile("Created SrcWebSiteList.txt.");
                    else
                    {
                        try
                        {
                            string[] srcLinesTemp = System.IO.File.ReadAllLines(xmlPath + "\\SrcWebSiteList.txt");
                            if (srcLinesTemp.Length == 0)
                            {
                                //empty file, may be no web site in destination. in this case non zere error code of appcmd can be ignored.
                                //if no file is genrated in that case first line in try will genrate exception which will abort import process.
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Failed: Creating SrcWebSiteList.txt" + Environment.NewLine + ex.Message, ex.InnerException);
                        }
                    }
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                        + "  C:\\windows\\system32\\inetsrv\\appcmd.exe list site /config /xml /> \"" + xmlPath + "\\WebSites.xml" + "\"\"";
                }

                //execute actual WebSite export
                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                if (returnCode == 0)
                    LogShortSuccessMsg("Success: Exported WebSites.");
                else
                {
                    throw new Exception("Failed: Exporting WebSites.");
                }

                //split website xml
                UpdateSrcWebSiteXml();


                string[] srcWebSites = Directory.GetFiles(xmlPath, "WebSite_*_ToExport.xml", SearchOption.AllDirectories);
                for (int i = 0; i < srcWebSites.Length; i++)
                {
                    string webSiteFilePath = srcWebSites[i];
                    string webSiteFileName = Path.GetFileNameWithoutExtension(webSiteFilePath);
                    string webSiteName = webSiteFileName.Substring(8, webSiteFileName.Length - 17);
                    //Move vDir to Local
                    MoveWebAppFolders(webSiteFilePath, webSiteName);

                    //split and export web app per website   
                    LogInfo("Web App: Export started.");
                    if (machineName == strSrcNode) //local                         
                    {
                        commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list apps /site.name:\"" + webSiteName + "\" /config /xml /> \""
                            + xmlPath + "\\WebApps_" + webSiteName + "_ToExport.xml" + "\"";
                    }
                    else  //remote                           
                    {
                        commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                            + "  C:\\windows\\system32\\inetsrv\\appcmd.exe list apps /site.name:\"" + webSiteName + "\" /config /xml /> \""
                            + xmlPath + "\\WebApps_" + webSiteName + "_ToExport.xml" + "\"\"";
                    }

                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Exported WebApps.");
                    else
                        LogShortErrorMsg("Failed: Exporting WebApps.");
                }

                if (machineName == strSrcNode) //local  
                {
                    LogInfo("IISClientCertMappings: Export started.");
                    ExportClientCertOnetOneMappings();
                    LogShortSuccessMsg("Success: Exported IISClientCertMappings.");
                }
                else
                {
                    LogInfo("IISClientCertMappings: Export started.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                     commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                             remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"ExportIISClientCert\"\"";
                    
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local
                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Exported IISClientCertMappings.");

                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Exporting IISClientCertMappings.");

                    }
                }
                LogInfoInLogFile("SrcBTSInstallPath:Export Started.");
                //Export BTSInstallPath into txt file
                if (machineName == strSrcNode) //local  
                {
                    commandArguments = "/C SET BTSINSTALLPATH > \""+xmlPath +  "\\SrcBTSInstallPath.txt" + "\"";
                }
                else//Remote
                {
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
         remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"BTSInstallPath\" \"" + "Export" + "\" \"";
                }
                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                if (returnCode == 0)
                    LogInfoInLogFile("Success: Exported SrcBTSInstallPath.");
                else
                {
                    LogShortErrorMsg("Failed: Exporting SrcBTSInstallPath.");
                }

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }


        private void btnImportWebSites_Click(object sender, EventArgs e)
        {
            string commandArguments=string.Empty;
            int returnCode;

            try
            {
                LogInfo("Website: Import started.");
                if (!File.Exists(xmlPath + @"\WebSites.xml"))
                    throw new Exception("WebSites xml file does not exist.");

                //check file is empty or not
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\WebSites.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("WebSites xml file is empty.");

                if (strServerType == "BizTalk" && (cmbBoxServerDst.Items.Count == 0 || cmbBoxServerDst.SelectedItem == null))
                    throw new Exception("Please select Dst node.");

                if (strServerType == "App" && (txtConnectionStringDst.Text == "SERVER NAME" || txtConnectionStringDst.Text.Trim() == ""))
                    throw new Exception("Please enter Dst App server.");

                //Export Destination BTSInstallPath into txt file
                if (machineName == strDstNode) //local  
                {
                    commandArguments = "/C SET BTSINSTALLPATH > \"" + xmlPath + "\\DstBTSInstallPath.txt" + "\"";
                }
                else
                {
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
         remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"BTSInstallPath\" \"" + "Import" + "\" \"";
                }
                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                if (returnCode == 0)
                    LogInfoInLogFile("Success: Exported DstBTSInstallPath.");
                else
                {
                    throw new Exception("Failed: Exporting DstBTSInstallPath.");
                }
                //Get WebSite Name Only from Destiantion in Txt file
                if (machineName == strDstNode) //local                            
                    commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list site /text:name /> \"" + xmlPath + "\\DstWebSiteList.txt" + "\"";
                else //remote            
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                                + " C:\\windows\\system32\\inetsrv\\appcmd.exe list site /text:name /> \"" + xmlPath + "\\DstWebSiteList.txt" + "\"\"";

                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                if (returnCode == 0)
                    LogInfo("Created DstWebSiteList.txt.");
                else
                {
                    try
                    {
                        string[] dstLinesTemp = System.IO.File.ReadAllLines(xmlPath + "\\DstWebSiteList.txt");
                        if (dstLinesTemp.Length == 0)
                        {
                            //empty file, may be no web site in destination. in this case non zere error code of appcmd can be ignored.
                            //if no file is genrated in that case first line in try will genrate exception which will abort import process.
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed: Creating DstWebSiteList.txt" + Environment.NewLine + ex.Message, ex.InnerException);
                    }
                }

                //split into multiple website.
                UpdateWebSiteXml();
                LogInfo("Generated Delta of Website to be imported.");

                string[] dstLines = System.IO.File.ReadAllLines(xmlPath + "\\DstWebSiteList.txt");
                string[] srcLines = System.IO.File.ReadAllLines(xmlPath + "\\SrcWebSiteList.txt");

                for (int srcLineCount = 0; srcLineCount < srcLines.Length; srcLineCount++)
                {
                    int matches = 0;
                    for (int dstLineCount = 0; dstLineCount < dstLines.Length; dstLineCount++)
                    {
                        if (dstLines[dstLineCount] == srcLines[srcLineCount])
                            matches = 1;
                    }

                    if (!(matches == 1))  //if no match which mean website is not existing in dest then create website in dest
                    {
                        //actual web site import.
                        if (machineName == strDstNode) //local
                        {
                            MoveWebAppFolders(xmlPath + "\\WebSite_" + srcLines[srcLineCount] + "_ToImport.xml", srcLines[srcLineCount]); //while mvoing DstWebSite Folders subfolders which correspond to App folders, might also move, need to stop that
                            commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe add site /in /xml /< \"" + xmlPath + "\\WebSite_" + srcLines[srcLineCount] + "_ToImport.xml" + "\"";
                        }
                        else  //remote
                        {
                            MoveWebAppFolders(xmlPath + "\\WebSite_" + srcLines[srcLineCount] + "_ToImport.xml", srcLines[srcLineCount]);
                            //commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                            //    + "  C:\\windows\\system32\\inetsrv\\appcmd.exe add site /in /xml /< \"" + xmlPath + "\\WebSite_" + srcLines[srcLineCount] + "_ToImport.xml" + "\"\"";
                            string appPathUnc = ConvertPathToUncPath(appPath);
                            commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                 remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportWebSite\" \"" + srcLines[srcLineCount] + "\" \"";
                        }

                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                        if (returnCode == 0)
                            LogShortSuccessMsg("Success: Imported WebSite: " + srcLines[srcLineCount]);
                        else
                            LogShortErrorMsg("Failed: Importing Website: " + srcLines[srcLineCount]);

                    }
                    else
                        LogInfo("WebSite already exist: " + srcLines[srcLineCount]);

                }

                //Generate DstWebAppList
                LogInfo("WebApp: Import started.");
                if (machineName == strDstNode) //local                
                    commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe list app /text:app.name /> \"" + xmlPath + "\\DstWebAppList.txt" + "\"";
                else //remote                
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                                + " C:\\windows\\system32\\inetsrv\\appcmd.exe list app /text:app.name /> \"" + xmlPath + "\\DstWebAppList.txt" + "\"\"";

                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                if (returnCode == 0)
                    LogInfo("Created DstWebAppList.txt");
                else
                {
                    try
                    {
                        string[] dstLinesTemp = System.IO.File.ReadAllLines(xmlPath + "\\DstWebAppList.txt");
                        if (dstLinesTemp.Length == 0)
                        {
                            //empty file, may be no web site in destination. in this case non zere error code of appcmd can be ignored.
                            //if no file is genrated in that case first line in try will genrate exception which will abort import process.
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed: Creating DstWebAppList.txt" + Environment.NewLine + ex.Message, ex.InnerException);
                    }
                }

                string[] srcWebApps = Directory.GetFiles(xmlPath, "WebApps_*_ToExport.xml", SearchOption.AllDirectories);
                for (int i = 0; i < srcWebApps.Length; i++)
                {
                    string webAppFilePath = srcWebApps[i];
                    string webAppFileName = Path.GetFileNameWithoutExtension(webAppFilePath);
                    string webSiteName = webAppFileName.Substring(8, webAppFileName.Length - 17);
                    //Update WebApps xml, remove Apps which are already there in Dst
                    UpdateWebAppXml(webAppFileName + ".xml", webSiteName);
                    //WebApps_DefaultWebsite2_ToImport.xml
                    doc = new XmlDocument();
                    doc.Load(xmlPath + "\\WebApps_" + webSiteName + "_ToImport.xml");

                    if (doc.DocumentElement.ChildNodes.Count > 0) //if file not empty
                    {
                        LogInfo("Generated Delta of WebApps to be imported.");
                        //actual web app import
                        if (machineName == strDstNode) //local
                        {
                            MoveWebAppFolders(xmlPath + "\\WebApps_" + webSiteName + "_ToImport.xml", webSiteName);
                            commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe add app /in /xml /< \"" + xmlPath + "\\WebApps_" + webSiteName + "_ToImport.xml" + "\"";
                        }
                        else  //remote
                        {
                            MoveWebAppFolders(xmlPath + "\\WebApps_" + webSiteName + "_ToImport.xml", webSiteName);
                            //commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                            //    + "  C:\\windows\\system32\\inetsrv\\appcmd.exe add site /in /xml /< \"" + "\\WebApps_" + webSiteName + "_ToImport.xml" + "\"\"";
                            string appPathUnc = ConvertPathToUncPath(appPath);
                            commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                 remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportWebApp\" \"" + webSiteName + "\" \"";
                        }

                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                        if (returnCode == 0)
                            LogShortSuccessMsg("Success: Imported WebApps.");
                        else
                            LogShortErrorMsg("Failed: Importing WebApps.");
                    }
                    else
                        LogInfo("WebAppsToImport.xml is empty.");
                }

                if (machineName == strDstNode) //local
                {
                    LogInfo("IISClientCertMappings: Import started.");
                    ImportClientCertOnetOneMappings();
                    LogShortSuccessMsg("Success: Imported IISClientCertMappings.");
                }
                else
                {
                    LogInfo("IISClientCertMappings: Import Started.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                            remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"ImportIISClientCert\"\"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local
                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Imported IISClientCertMappings on "+strDstNode +" Server.");

                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Importing IISClientCertMappings on "+strDstNode +" Server.");

                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }
        #endregion

        #region Certificate
        private void btnExportCert_Click(object sender, EventArgs e)
        {
            byte[] certBytes = null;
            X509Store store = null;
            string certFileName = string.Empty, thumbPrint = string.Empty;
            string commandArguments = "";
            int returnCode;
            try
            {   //Clean Cert Folder   
                LogInfo("CERT: Export started.");
                try
                {
                    if (Directory.Exists(certPath))
                    {
                        Directory.Delete(certPath, true);
                        Directory.CreateDirectory(certPath);
                    }
                    else
                        Directory.CreateDirectory(certPath);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while cleaning cert folder, hence aborting CERT export " + ex.Message + ", " + ex.StackTrace);
                }

                if (machineName == strSrcNode)//local
                {
                    int i = 0;
                    foreach (string iStoreLocation in Enum.GetNames(typeof(StoreLocation)))
                    {
                        foreach (string iStoreName in Enum.GetNames(typeof(StoreName)))
                        {
                            StoreLocation storeLoc = (StoreLocation)Enum.Parse(typeof(StoreLocation), iStoreLocation);
                            StoreName storeNam = (StoreName)Enum.Parse(typeof(StoreName), iStoreName);
                            if (storeLoc == StoreLocation.LocalMachine || (storeLoc == StoreLocation.CurrentUser && storeNam == StoreName.My))
                            {
                                store = new X509Store(storeNam, storeLoc);

                                try

                                {
                                    store.Open(OpenFlags.ReadOnly);
                                    LogInfo(iStoreLocation + "_" + iStoreName + "_Count: " + store.Certificates.Count);
                                    foreach (X509Certificate2 certificate in store.Certificates)
                                    {
                                        // Exporting EnhancedKEyUsage and KeyUsage for Certificates
                                        string[] enhancedKeyUsage = new string[] { };

                                        foreach (X509Extension extension in certificate.Extensions)
                                        {


                                            if (extension.Oid.FriendlyName == "Enhanced Key Usage")
                                            {
                                                try
                                                {
                                                    X509EnhancedKeyUsageExtension ext = (X509EnhancedKeyUsageExtension)extension;
                                                    OidCollection oids = ext.EnhancedKeyUsages;
                                                    enhancedKeyUsage = new string[oids.Count];
                                                    for (int j = 0; j < oids.Count; j++)
                                                    {
                                                        if (string.IsNullOrEmpty(oids[j].FriendlyName) || string.IsNullOrWhiteSpace(oids[j].FriendlyName))
                                                        {
                                                            // Do Nothing
                                                        }
                                                        else

                                                            enhancedKeyUsage[j] = oids[j].FriendlyName.Trim();
                                                    }

                                                }
                                                catch (Exception ex)
                                                {
                                                    LogInfo("Exception Occured when Extracting Enhanced Key Usage: " + certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + certificate.Thumbprint);
                                                    LogException(ex);
                                                }

                                            }

                                        }

                                        if (enhancedKeyUsage.Contains("ITG Smartcard") || enhancedKeyUsage.Contains("Smart Card Logon") || certificate.Issuer.Contains("login.windows.net"))
                                        {
                                            //Do Nothing
                                        }

                                        else
                                        {
                                            try
                                            {
                                                thumbPrint = certificate.Thumbprint;
                                                int dateCompare = DateTime.Compare(certificate.NotAfter, DateTime.Now);
                                                if (dateCompare >= 0)
                                                {
                                                    if (certificate.HasPrivateKey)
                                                    {
                                                        certFileName = certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + thumbPrint + "_" + i.ToString() + ".PFX";
                                                        //certBytes = certificate.Export(X509ContentType.Pfx, strCertPass);
                                                        //File.WriteAllBytes(certFileName, certBytes);
                                                        if (iStoreLocation == "CurrentUser")
                                                            commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -exportpfx " + " -p " + "\"" + strCertPass + "\"" + " -User " + iStoreName + " " + "\"" + thumbPrint + "\"" + " " + certFileName + " " + "ExtendedProperties";
                                                        else
                                                            commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -exportpfx " + " -p " + "\"" + strCertPass + "\"" + " " + iStoreName + " " + "\"" + thumbPrint + "\"" + " " + certFileName + " " + "ExtendedProperties";
                                                        
                                                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                                        if (returnCode == 0)
                                                        {
                                                            LogInfoInLogFile("Success:Exported Cert:" + certFileName);
                                                        }
                                                        else
                                                            LogShortErrorMsg("Failed:Exporting Cert:" + certFileName);
                                                    }
                                                    else
                                                    {
                                                        certFileName = certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + thumbPrint + "_" + i.ToString() + ".CER";
                                                        certBytes = certificate.Export(X509ContentType.Cert);
                                                        File.WriteAllBytes(certFileName, certBytes);
                                                        
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                LogInfo("Exception: Cert File Name: " + certFileName);
                                                LogException(ex);
                                            }
                                            finally
                                            { i++; }
                                        }

                                    }
                                }



                                catch (Exception ex)
                                { LogException(ex); }

                                finally
                                { store.Close(); }
                            }
                        }
                    }
                    LogShortSuccessMsg("Success: Exported Cert.");
                }
                else //remote
                {
                    string strSrc = "";
                    string strDst = "";
                    

                    //export cert on remote machine, locally       
                    LogInfo("CERT: Exporting from Remote Machine.");
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strSrcNode + " -u " + "\"" + strUserNameForHost + "\"" + " -p " + "\"" + strPasswordForHost + "\"" + " -accepteula" + "  \"" +
                        remoteRootFolder + "\\" + remoteExeName + "\" \"" + remoteRootFolder + "\" \"ExportCert\" \"" + strCertPass + "\"\"";
                    
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Exported Cert.");

                        LogInfo("Moving cert files to local: " + machineName + " from remote: " + strSrcNode);
                        //bring back that cert folder to local machine                
                        string remoteRootFolderUnc = ConvertPathToUncPath(remoteRootFolder);
                        strSrc = "\\\\" + strSrcNode + "\\" + remoteRootFolderUnc + certFolderName;
                        commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + certPath + "\" " + "/MOVE /R:1";
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments); //copy Cert Folder to Remote destination server


                        strSrc = "\\\\" + strSrcNode + "\\" + remoteRootFolderUnc + "\\Logs";
                        strDst = logPath;
                        commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/MOVE /R:1";
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                        if (returnCode < strRoboCopySuccessCode)
                            LogShortSuccessMsg("Success: Copied Certificates to local.");
                        else
                            LogShortErrorMsg("Failed: Copying Certificates to local ");
                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Exporting Cert.");
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }

        }

        private void btnImportCert_Click(object sender, EventArgs e)
        {
            X509Store store = null; X509Certificate2 certificate = null;
            string thumbPrint = string.Empty;
            int returnCode;
            string[] strFiles = null;
            string commandArguments = " ";

            if (machineName == strDstNode)//local
            {
                LogInfo("CERT: Import started.");
                //BEGIN::new code for delta, get all cert name and write them in txt file,
                using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstCertList.txt", false))
                {
                    foreach (string iStoreLocation in Enum.GetNames(typeof(StoreLocation)))
                    {
                        foreach (string iStoreName in Enum.GetNames(typeof(StoreName)))
                        {
                            StoreLocation storeLoc = (StoreLocation)Enum.Parse(typeof(StoreLocation), iStoreLocation);
                            StoreName storeNam = (StoreName)Enum.Parse(typeof(StoreName), iStoreName);

                            store = new X509Store(storeNam, storeLoc);

                            try
                            {
                                store.Open(OpenFlags.ReadOnly);
                                foreach (X509Certificate2 certificateDst in store.Certificates)
                                {
                                    try
                                    {
                                        thumbPrint = certificateDst.Thumbprint;
                                        if (certificateDst.HasPrivateKey)
                                        {
                                            writer.WriteLine(iStoreLocation + "_" + iStoreName + "_" + thumbPrint);
                                        }
                                        else
                                        {
                                            writer.WriteLine(iStoreLocation + "_" + iStoreName + "_" + thumbPrint);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        LogException(ex);
                                    }
                                    finally
                                    {

                                    }
                                }
                            }
                            catch (Exception ex)
                            { LogException(ex); }

                            finally
                            { store.Close(); }
                        }
                    }
                }
                //END::new code for delta, get all cert name and write them in txt file, 

                string[] dstCertNameList = System.IO.File.ReadAllLines(xmlPath + @"\DstCertList.txt"); //read all cert of Dst
                //Creating CertificatesList with out StorLocation
                string[] dstCertList = new string[dstCertNameList.Length];
                for (int i = 0; i < dstCertNameList.Length; i++)
                {
                    dstCertList[i] = dstCertNameList[i].Substring(dstCertNameList[i].IndexOf('_') + 1);
                }
                int certsImported = 0;
                foreach (string iStoreLocation in Enum.GetNames(typeof(StoreLocation)))
                {
                    foreach (string iStoreName in Enum.GetNames(typeof(StoreName)))
                    {
                        StoreLocation storeLoc = (StoreLocation)Enum.Parse(typeof(StoreLocation), iStoreLocation);
                        StoreName storeNam = (StoreName)Enum.Parse(typeof(StoreName), iStoreName);
                        //if (storeNam == StoreName.Root && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        //if (storeNam == StoreName.Disallowed && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        //if (storeNam == StoreName.AuthRoot && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        //if (storeNam == StoreName.CertificateAuthority && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        //if (storeNam == StoreName.AddressBook && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        //if (storeNam == StoreName.TrustedPeople && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        //if (storeNam == StoreName.TrustedPublisher && storeLoc == StoreLocation.CurrentUser)
                        //    storeLoc = StoreLocation.LocalMachine;
                        store = new X509Store(storeNam, storeLoc);

                        try
                        {
                            store.Open(OpenFlags.ReadWrite);

                            strFiles = Directory.GetFiles(certPath, iStoreLocation + "_" + iStoreName + "*");

                            for (int iFile = 0; iFile < strFiles.Length; iFile++)
                            {
                                string certName = strFiles[iFile].Substring(strFiles[iFile].LastIndexOf('\\') + 1);
                                try
                                {
                                   
                                    if (storeNam == StoreName.My)
                                    {
                                        certName = certName.Substring(0, certName.LastIndexOf('_'));
                                        if (Array.IndexOf(dstCertNameList, certName) < 0)  //cert  already exists in Dst
                                        {
                                            if (Path.GetExtension(strFiles[iFile]) == ".PFX")
                                            {
                                                if (strFiles[iFile].Contains("CurrentUser"))
                                                    commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + strCertPass + "\"" + " -User " + storeNam + " " + "\"" + strFiles[iFile] + "\"" ;
                                                else
                                                    commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + strCertPass + "\"" + " " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                
                                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                                if (returnCode == 0)
                                                {
                                                    LogInfoInLogFile("Success: Imported Cert:" + certName);
                                                }
                                                else
                                                    LogShortErrorMsg("Failed Importing Cert File Name:" + certName);
                                                certsImported++;
                                            }
                                            else
                                            {
                                                if (strFiles[iFile].Contains("CurrentUser"))
                                                    certificate = new X509Certificate2(strFiles[iFile], strCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.UserKeySet);
                                                else
                                                    certificate = new X509Certificate2(strFiles[iFile], strCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.MachineKeySet);
                                                store.Add(certificate);
                                                certsImported++;
                                                LogInfoInLogFile("Imported Cert: " + certName);
                                            }
                                                
                                            
                                        }
                                    }
                                    else
                                    {
                                        string certName1 = certName.Substring(0, certName.LastIndexOf('_'));
                                        certName = certName1.Substring(certName.IndexOf('_') + 1);
                                        if (Array.IndexOf(dstCertList, certName) < 0)  //cert  already exists in Dst
                                        {
                                            if (Path.GetExtension(strFiles[iFile]) == ".PFX")
                                            {
                                                if (strFiles[iFile].Contains("CurrentUser"))
                                                    commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + strCertPass + "\"" + " -User " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                else
                                                    commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + strCertPass + "\"" + " " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                                if (returnCode == 0)
                                                {
                                                    LogInfoInLogFile("Success: Imported Cert" + certName);
                                                }
                                                else
                                                    LogShortErrorMsg("Failed Importing Cert:" + certName);
                                                certsImported++;
                                            }
                                            else
                                            {
                                                if (strFiles[iFile].Contains("CurrentUser"))
                                                    certificate = new X509Certificate2(strFiles[iFile], strCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.UserKeySet);
                                                else
                                                    certificate = new X509Certificate2(strFiles[iFile], strCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.MachineKeySet);

                                                store.Add(certificate);
                                                certsImported++;
                                                LogInfoInLogFile("Imported Cert: " + certName1);
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("Exception: Cert File Name: " + strFiles[iFile]);
                                    LogException(ex);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogException(ex);
                        }
                        finally
                        {
                            store.Close();
                        }
                    }
                }
                if (certsImported > 0)
                    LogShortSuccessMsg("Success: Imported Cert.");
                else
                    LogInfo("No new certificates to import.");
           
            }
            else  //remote
            {
                LogInfo("CERT: Import started.");
                LogInfo("Copying certificates to remote Machine: " + strDstNode);
                //copy cert from local to remote
                string strSrc = certPath;
                string remoteRootFolderUnc = ConvertPathToUncPath(remoteRootFolder);
                string strDst = "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + certFolderName;
                 commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                returnCode = ExecuteCmd("CMD.EXE", commandArguments); //copy cert Folder to Remote destination server

                if (returnCode < strRoboCopySuccessCode)
                {
                    LogShortSuccessMsg("Success: Certificates copied to remote.");
                    LogInfo("Certificate Import started on Remote Machine.");
                    //now execute .net exe on remote machine
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + strUserNameForHost + " -p " + "\"" + strPasswordForHost + "\"" + " -accepteula" + "  \"" +
                       remoteRootFolder + "\\" + remoteExeName + "\" \"" + remoteRootFolder + "\" \"ImportCert\" \"" + strCertPass + "\"\"";

                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Certificates Imported.");
                    else
                        LogShortErrorMsg("Failed: Certificates Import.");
                }
                else
                    LogShortErrorMsg("Failed: Certificate copy to remote.");

                strSrc = "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + "\\Logs";
                strDst = logPath;
                commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/MOVE /R:1";
                returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                if (returnCode < strRoboCopySuccessCode)
                    LogInfoInLogFile("Copied Certificate log to local.");
                else
                    LogShortErrorMsg("Failed: Copying Cert Logs to local ");
            }
            

        }
        #endregion

        #region Assemblies
        private int btnGetAssembliesList_Click(object sender, EventArgs e)
        {
            AssemblyList asmList = null;
            XmlSerializer x = null;
            XmlWriter xmlWriterApps = null;
            string appNameCollectionString = string.Empty;
            int returnCode;
            char[] charSeprator = { ',' };

            try
            {
                LogInfo("Assembly: Getting Assembly List.");
                if (File.Exists(xmlPath + @"\SrcBizTalkAssembly.xml")) //delete if existing, create fresh copy
                {
                    File.Delete(xmlPath + @"\SrcBizTalkAssembly.xml");
                }
                //read App.xml
                //if App.xml is not existing then create one.
                if (!File.Exists(xmlPath + @"\Apps.xml")) //if Apps.xml does not exist then create
                {
                    if (btnGetApplicationList_Click(sender, e) == 1)
                        throw new Exception("Failed: Creating Apps.xml");
                }

                XElement xelement = XElement.Load(xmlPath + @"\Apps.xml");

                var appList = (from element in xelement.Descendants("BizTalkApplication")
                               let dCode = (string)element.Attribute("DependencyCode")
                               orderby dCode descending
                               select new
                               {
                                   DcodeAppName = dCode + "," + element.Attribute("ApplicationName").Value
                               })
                       .ToList();

                int appcount = appList.Count;

                string msiPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(msiPath);

                for (int iAppCount = 0; iAppCount < appcount; iAppCount++)
                {
                    //appNameCollectionString = appNameCollectionString + ',' + appList[iAppCount].DcodeAppName.Split(charSeprator)[1].ToString();//
                    appNameCollectionString = appNameCollectionString.ToString().TrimStart(',') + ',' + appList[iAppCount].DcodeAppName.Split(charSeprator)[1].ToString();
                }


                if (machineName == strSrcNode) //local
                {
                    BizTalkApplications bizTalkApps = new BizTalkApplications();

                    // instantiate new instance of Explorer OM
                    BtsCatalogExplorer btsExp = new BtsCatalogExplorer();
                    LogInfo("Connecting to BizTalkMgmtDb..." + txtConnectionString.Text);
                    // connection string to the BizTalk management database
                    btsExp.ConnectionString = "Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                    //Get All Applications
                    Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol = btsExp.Applications;
                    LogInfo("Connected.");
                    int asmCount = 0;
                    foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
                    {
                        if (appNameCollectionString.Contains(app.Name))
                        {
                            BtsAssemblyCollection asmCol = app.Assemblies;

                            foreach (BtsAssembly btAsm in asmCol)
                            {
                                if (!btAsm.IsSystem)
                                {
                                    asmCount++;
                                }
                            }
                        }
                    }
                    asmList = new AssemblyList();
                    asmList.Assembly = new AssemblyListAssembly[asmCount];
                    int i = 0;
                    foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
                    {
                        if (appNameCollectionString.Contains(app.Name))
                        {
                            BtsAssemblyCollection asmCol = app.Assemblies;

                            foreach (BtsAssembly btAsm in asmCol)
                            {
                                if (!btAsm.IsSystem)
                                {
                                    asmList.Assembly[i] = new AssemblyListAssembly();
                                    asmList.Assembly[i].AppName = app.Name;
                                    asmList.Assembly[i].AsmName = btAsm.Name;
                                    asmList.Assembly[i].AsmVer = btAsm.Version;

                                    i++;
                                }
                            }
                        }
                    }

                    //BEGIN::asm Custom list


                    //END::asm Custom list

                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                    //Add lib namespace with empty prefix
                    ns.Add("", "");

                    x = new System.Xml.Serialization.XmlSerializer(asmList.GetType());
                    XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                    xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;

                    xmlWriterApps = XmlWriter.Create(xmlPath + @"\SrcBizTalkAssembly.xml", xmlWriterSetting);
                    x.Serialize(xmlWriterApps, asmList, ns);
                    LogInfo("Success: Created SrcBizTalkAssembly.xml.");
                    return 0;
                }
                else //remote
                {
                    LogInfo("Assembly: Getting Assembly list.");
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                    remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportAsmList\" \"" + txtConnectionString.Text.Trim() + "\" \"" + appNameCollectionString + "\"\"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local
                    if (returnCode == 0)
                    {
                        LogInfo("Success: Created SrcBizTalkAssembly.xml.");
                        return 0;
                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Creating SrcBizTalkAssembly.xml.");
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Failed: Creating Assembly.xml.");
                LogException(ex);
                return 1;
            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }
        }

        private void btnExportAssemblies_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            XmlSerializer configSerializer = null;
            AssemblyList asmList = null;
            string asmPath1, asmPath2, asmPath3, asmPath4, asmPath5;
            int returnCode;
            string[] findDLL = null; string[] customDll = null;
            string ver = string.Empty;
            string dir = string.Empty;
            int asmListCount = 0;
            int customDlls = 0;
            char[] chrSep = { ',' };

            try
            {
                LogInfo("Assemblies: Export started.");
                if (strServerType == "BizTalk")
                {
                    if (btnGetAssembliesList_Click(sender, e) == 1)
                        throw new Exception("Failed: Creating Assembly List");

                    if (!File.Exists(xmlPath + @"\SrcBizTalkAssembly.xml"))
                        throw new Exception("File: " + xmlPath + @"\SrcBizTalkAssembly.xml does not exist, Assembly Export is termintated please check logs for root cause.");

                    configSerializer = new XmlSerializer(typeof(AssemblyList));
                    asmList = (AssemblyList)configSerializer.Deserialize(new XmlTextReader(xmlPath + @"\SrcBizTalkAssembly.xml"));

                    asmListCount = asmList.Assembly.Length;

                    string appName = string.Empty;
                }
                asmPath1 = @"C:\Windows\Microsoft.NET\assembly\";
                asmPath2 = @"C:\Windows\assembly\GAC\";
                asmPath3 = @"C:\Windows\assembly\GAC_32\";
                asmPath4 = @"C:\Windows\assembly\GAC_64\";
                asmPath5 = @"C:\Windows\assembly\GAC_MSIL\";

                try
                {
                    if (Directory.Exists(asmPath))  //Recreate DLL Folder
                    {
                        Directory.Delete(asmPath, true);
                        Directory.CreateDirectory(asmPath);
                    }

                    if (Directory.Exists(customDllPath))  //Recreate Custom Dll Folder
                    {
                        Directory.Delete(customDllPath, true);
                        Directory.CreateDirectory(customDllPath);
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    throw new Exception("Error while cleaning DLL Folders.");
                }

                if (machineName == strSrcNode) //local
                {
                    if (strCustomDllToInclude != string.Empty)  //if custom Dll filter not empty
                    {
                        string[] CustomDllFilters = strCustomDllToInclude.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
                        int customDllCount = 0;
                        for (int i = 0; i < CustomDllFilters.Length; i++)
                        {
                            //BEGIN::custom asm list code                         
                            string[] customDll_1 = Directory.GetFiles(asmPath1, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_2 = Directory.GetFiles(asmPath2, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_3 = Directory.GetFiles(asmPath3, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_4 = Directory.GetFiles(asmPath4, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_5 = Directory.GetFiles(asmPath5, CustomDllFilters[i], SearchOption.AllDirectories);
                            customDllCount = customDllCount + customDll_1.Length + customDll_2.Length + customDll_3.Length + customDll_4.Length + customDll_5.Length;
                        }

                        customDll = new string[customDllCount];
                        LogInfo("Initial Custom Assembly count: " + customDll.Length.ToString());
                        int customDllLength = 0;
                        for (int i = 0; i < CustomDllFilters.Length; i++)
                        {
                            //BEGIN::custom asm list code                         
                            string[] customDll_1 = Directory.GetFiles(asmPath1, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_2 = Directory.GetFiles(asmPath2, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_3 = Directory.GetFiles(asmPath3, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_4 = Directory.GetFiles(asmPath4, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_5 = Directory.GetFiles(asmPath5, CustomDllFilters[i], SearchOption.AllDirectories);

                            customDll_1.CopyTo(customDll, customDllLength);
                            customDllLength = customDllLength + customDll_1.Length;
                            customDll_2.CopyTo(customDll, customDllLength);
                            customDllLength = customDllLength + customDll_2.Length;
                            customDll_3.CopyTo(customDll, customDllLength);
                            customDllLength = customDllLength + customDll_3.Length;
                            customDll_4.CopyTo(customDll, customDllLength);
                            customDllLength = customDllLength + customDll_4.Length;
                            customDll_5.CopyTo(customDll, customDllLength);
                            customDllLength = customDllLength + customDll_5.Length;
                        }

                        customDll = customDll.Distinct().ToArray();
                        Array.Sort(customDll);

                        //END::custom asm list code
                    }
                    if (strServerType == "BizTalk")
                    {
                        LogInfo("BizTalk Dll: Export started.");
                        List<string> bizTalkDll = new List<string>();
                        for (int i = 0; i < asmListCount; i++)
                        {
                            try
                            {
                                findDLL = Directory.GetFiles(asmPath1, asmList.Assembly[i].AsmName.ToString() + ".dll", SearchOption.AllDirectories);
                                if (findDLL.Length == 0)
                                    findDLL = Directory.GetFiles(asmPath2, asmList.Assembly[i].AsmName.ToString() + ".dll", SearchOption.AllDirectories);
                                if (findDLL.Length == 0)
                                    findDLL = Directory.GetFiles(asmPath3, asmList.Assembly[i].AsmName.ToString() + ".dll", SearchOption.AllDirectories);
                                if (findDLL.Length == 0)
                                    findDLL = Directory.GetFiles(asmPath4, asmList.Assembly[i].AsmName.ToString() + ".dll", SearchOption.AllDirectories);
                                if (findDLL.Length == 0)
                                    findDLL = Directory.GetFiles(asmPath5, asmList.Assembly[i].AsmName.ToString() + ".dll", SearchOption.AllDirectories);

                                if (findDLL.Length == 0)
                                {
                                    LogShortErrorMsg("Did not Find Assembly:" + asmList.Assembly[i].AsmName.ToString());
                                }
                                else
                                {
                                    int fileCount = 0;

                                    foreach (string filePath in findDLL)
                                    {
                                        fileCount++;
                                        try
                                        {
                                            if (strCustomDllToInclude != string.Empty) //if custom Dll fileter not empty
                                            {
                                                //BEGIN::custom asm list code
                                                while (Array.IndexOf(customDll, filePath) > -1) //if same dll is part of custom DLL then empty that entry in list.
                                                {

                                                    customDll[Array.IndexOf(customDll, filePath)] = string.Empty;
                                                    customDlls++;
                                                }
                                                //END::custom asm list code
                                            }
                                            ver = AssemblyName.GetAssemblyName(filePath).Version.ToString();
                                            dir = asmPath + "\\" + Path.GetFileNameWithoutExtension(filePath) + "_" + ver;

                                            if (!Directory.Exists(dir))
                                            {
                                                Directory.CreateDirectory(dir);
                                            }
                                            //dir = ConvertPathToUncPath(dir);
                                            File.Copy(filePath, dir + "\\" + Path.GetFileName(filePath), true);
                                            LogInfoInLogFile("Assembly copied: " + Path.GetFileName(filePath) + ", " + ver);
                                            // writer.WriteLine(Path.GetFileNameWithoutExtension(filePath) + "_" + ver);
                                            bizTalkDll.Add(Path.GetFileNameWithoutExtension(filePath) + "_" + ver);
                                            }
                                        catch (Exception ex)
                                        { LogException(ex); }
                                    }

                                }
                            }
                            catch (Exception ex)
                            { LogException(ex); }
                        }
                        string[] distinctBizTalkDll = bizTalkDll.Distinct().ToArray();
                        using (StreamWriter writer = new StreamWriter(xmlPath + @"\SrcBizTalkAssemblyList.txt", false))
                        {
                            foreach (string dll in distinctBizTalkDll)
                            {
                                writer.WriteLine(dll);
                            }
                        }
                            LogShortSuccessMsg("Success: Exported BizTalk Dll");
                    
                    }

                    if (strCustomDllToInclude != string.Empty) //if custom Dll fileter not empty
                    {
                        LogInfo("Final Custom Assembly count: " + (customDll.Length - customDlls).ToString());
                        LogInfo("Custom Dll: Export started.");
                        //write custom dll paths in txt file
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(xmlPath + @"\SrcCustomAssemblyList.txt", false))
                            {
                                //copy custom dlls in CustomDll Folder
                                foreach (string filePath in customDll)
                                {
                                    string CustomDllVer = "";
                                    try
                                    {

                                        if (!(string.IsNullOrEmpty(filePath)) && !(string.IsNullOrWhiteSpace(filePath)))
                                        {
                                            CustomDllVer = AssemblyName.GetAssemblyName(filePath).Version.ToString();
                                            dir = customDllPath + "\\" + Path.GetFileNameWithoutExtension(filePath) + "_" + CustomDllVer;

                                            if (!Directory.Exists(dir))
                                            {
                                                Directory.CreateDirectory(dir);
                                            }
                                            //dir = ConvertPathToUncPath(dir);
                                            File.Copy(filePath, dir + "\\" + Path.GetFileName(filePath), true);
                                            writer.WriteLine(Path.GetFileNameWithoutExtension(filePath) + "_" + CustomDllVer);
                                            LogInfoInLogFile("Assembly copied: " + Path.GetFileName(filePath) + ", " + CustomDllVer);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        LogShortErrorMsg("Assembly copy failed: " + Path.GetFileName(filePath) + ", " + CustomDllVer);
                                        LogException(ex);
                                    }
                                }
                            }
                            LogShortSuccessMsg("Success: Exported Custom Dll.");
                        }
                        catch (Exception ex)
                        {
                            LogException(ex);
                        }

                    }
                }
                else  //remote
                {
                    string customDllPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(customDllPath);
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string asmPathUnc = ConvertPathToUncPath(asmPath);
                    string commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                         remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"ExportDll\" \"\\\\" + machineName + "\\" + asmPathUnc + "\" \"" + strCustomDllToInclude + "\" \"" + customDllPathUnc + "\" \"" + strServerType + "\"\"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments); //dlls will be copied and pasted back to Local machine, hence machineName used in commandArgument.

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Biztalk Assemblies Exported.");
                    else
                        LogShortErrorMsg("Failed: Biztalk Assemblies Export.");
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }
        
        private void btnImportAssemblies_Click(object sender, EventArgs e)
        {
           // XmlSerializer configSerializer = null;
          //  AssemblyList asmList = null;
            string filePath = string.Empty;
            string commandArguments = string.Empty, customAssemblyVer = string.Empty;
            int returnCode = 0;
            string[] customDllDst = null;
          //  int asmListCount = 0;
            bool importBizTalkDll = true;
            char[] chrSep = { ',' };

            try
            {
                LogInfo("Assembly: Import started.");
            
                if(!File.Exists(xmlPath + @"\SrcBizTalkAssemblyList.txt"))
                    throw new Exception("SrcBizTalkAssemblyList txt file does not exist.");

         

                try
                {
                    if (File.Exists(xmlPath + @"\BizTalkAssemblyToImport.txt"))  //delete older version
                    {
                        File.Delete(xmlPath + @"\BizTalkAssemblyToImport.txt");
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    throw new Exception("Error while deleting BizTalkAssemblyToImport txt file.");
                }

                if (strServerType == "BizTalk")
                {
                    //update AssemblyList, remove those rows where App already exists in Dst
                    UpdateAssemblyFile();
                    LogInfo("Generated Delta of BizTalk Assembly list to be imported.");
                    
                }

                if (strCustomDllToInclude != string.Empty)
                {
                    // BEGIN::custom DLL Code::Get  "DstCustomAssemblyList.txt"
                    if (machineName == strDstNode) //local
                    {
                        string asmPath1 = @"C:\Windows\Microsoft.NET\assembly\";
                        string asmPath2 = @"C:\Windows\assembly\GAC\";
                        string asmPath3 = @"C:\Windows\assembly\GAC_32\";
                        string asmPath4 = @"C:\Windows\assembly\GAC_64\";
                        string asmPath5 = @"C:\Windows\assembly\GAC_MSIL\";

                        string[] CustomDllFilters = strCustomDllToInclude.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
                        int customDllCount = 0;
                        for (int i = 0; i < CustomDllFilters.Length; i++)
                        {
                            //BEGIN::custom asm list code                         
                            string[] customDll_1 = Directory.GetFiles(asmPath1, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_2 = Directory.GetFiles(asmPath2, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_3 = Directory.GetFiles(asmPath3, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_4 = Directory.GetFiles(asmPath4, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_5 = Directory.GetFiles(asmPath5, CustomDllFilters[i], SearchOption.AllDirectories);
                            customDllCount = customDllCount + customDll_1.Length + customDll_2.Length + customDll_3.Length + customDll_4.Length + customDll_5.Length;
                        }

                        customDllDst = new string[customDllCount];
                        int customDllLength = 0;
                        for (int i = 0; i < CustomDllFilters.Length; i++)
                        {
                            //BEGIN::custom asm list code                         
                            string[] customDll_1 = Directory.GetFiles(asmPath1, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_2 = Directory.GetFiles(asmPath2, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_3 = Directory.GetFiles(asmPath3, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_4 = Directory.GetFiles(asmPath4, CustomDllFilters[i], SearchOption.AllDirectories);
                            string[] customDll_5 = Directory.GetFiles(asmPath5, CustomDllFilters[i], SearchOption.AllDirectories);

                            customDll_1.CopyTo(customDllDst, customDllLength);
                            customDllLength = customDllLength + customDll_1.Length;
                            customDll_2.CopyTo(customDllDst, customDllLength);
                            customDllLength = customDllLength + customDll_2.Length;
                            customDll_3.CopyTo(customDllDst, customDllLength);
                            customDllLength = customDllLength + customDll_3.Length;
                            customDll_4.CopyTo(customDllDst, customDllLength);
                            customDllLength = customDllLength + customDll_4.Length;
                            customDll_5.CopyTo(customDllDst, customDllLength);
                            customDllLength = customDllLength + customDll_5.Length;
                        }

                        customDllDst = customDllDst.Distinct().ToArray();
                        Array.Sort(customDllDst);

                        //write custom dll paths in txt file
                        using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstCustomAssemblyList.txt", false))
                        {
                            foreach (string filePathCusDll in customDllDst)
                            {
                                if (filePathCusDll != string.Empty)
                                {
                                    string CustomDllVer = AssemblyName.GetAssemblyName(filePathCusDll).Version.ToString();
                                    writer.WriteLine(Path.GetFileNameWithoutExtension(filePathCusDll) + "_" + CustomDllVer);
                                }

                            }
                        }
                    }
                    else //remote, get list of Custom Dlls from Dst
                    {
                        string appPathUnc = ConvertPathToUncPath(appPath);
                        string asmPathUnc = ConvertPathToUncPath(asmPath);
                        commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                             remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"DstCustomDllList\" \"" + strCustomDllToInclude + "\"\"";
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments); //DstCustomAssemblyList.txt will be Generated in XML Folder

                        if (returnCode == 0)
                            LogInfo("Created DstCustomAssemblyList.txt.");
                        else
                        {
                            LogShortErrorMsg("Failed: Creating DstCustomAssemblyList.txt.");
                            LogInfoInLogFile("Remote Exe return code: " + returnCode.ToString());
                        }
                    }
                }
                //now compare both DstCustomAssemblyList.txt and SrcCustomAssemblyList.txt

                if (strCustomDllToInclude != string.Empty)
                {

                    string[] srcLines = System.IO.File.ReadAllLines(xmlPath + @"\SrcCustomAssemblyList.txt");
                    string[] dstLines = System.IO.File.ReadAllLines(xmlPath + @"\DstCustomAssemblyList.txt");

                    foreach (string srcFilePath in srcLines)
                    {
                        if (Array.IndexOf(dstLines, srcFilePath) > -1) //if same dll is part of custom DLL then empty that entry in list.                                                    
                            srcLines[Array.IndexOf(srcLines, srcFilePath)] = string.Empty;
                    }
                    using (StreamWriter writer = new StreamWriter(xmlPath + @"\CustomAssemblyToImport.txt", false))
                    {
                        foreach (string filePathDll in srcLines)
                        {
                            if (filePathDll != string.Empty)
                            {
                                //string CustomDllVer = AssemblyName.GetAssemblyName(filePathDll).Version.ToString();
                                writer.WriteLine(filePathDll);
                            }

                        }
                    }

                    //END::custom DLL Code
                }
                //actual gacing code
                //remote copy 
                if (machineName != strDstNode)  //if gacing has to be done on remote box then copy BizTalk DLL and Custom Dll folder on remote
                {
                    string strSrc, strDst, remoteRootFolderUnc = string.Empty;
                    remoteRootFolderUnc = ConvertPathToUncPath(remoteRootFolder);
                    if (strServerType == "BizTalk" && importBizTalkDll == true)
                    {
                        //copy BizTalk Dll Folder
                        strSrc = asmPath;

                        strDst = "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + asmFolderName;
                        commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments); //copy DLL Folder to Remote destination server 
                        if (returnCode < strRoboCopySuccessCode)
                            LogShortSuccessMsg("Success: Copied DLL folder to remote.");
                        else
                            LogShortErrorMsg("Failed: Copying DLL folder to remote.");
                    }
                    //custom Dll Folder
                    strSrc = customDllPath;
                    strDst = "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + customDllFolderName;
                    commandArguments = @"/C robocopy " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments); //copy Custom DLL Folder to Remote destination server 
                    if (returnCode < strRoboCopySuccessCode)
                        LogShortSuccessMsg("Success: Copied Custom DLL folder to remote.");
                    else
                        LogShortErrorMsg("Failed: Copying Custom DLL folder to remote.");
                }

                if (strCustomDllToInclude != string.Empty)
                {
                    string[] srcLines = System.IO.File.ReadAllLines(xmlPath + @"\CustomAssemblyToImport.txt");
                    int flagCustomDllExists = 0;
                    LogInfo("Custom Dll Import Started.");
                    for (int i = 0; i < srcLines.Length; i++)  //Custom DLL
                    {
                        if (srcLines[i] != string.Empty)
                        {
                            flagCustomDllExists++;
                            try
                            {
                                string dllName = srcLines[i].Substring(0, srcLines[i].LastIndexOf("_"));
                                string dllNameRemote = srcLines[i] + "\\" + dllName + ".dll";
                                filePath = customDllPath + "\\" + srcLines[i] + "\\" + dllName + ".dll";
                                customAssemblyVer = AssemblyName.GetAssemblyName(filePath).Version.ToString();
                                if (machineName == strDstNode) //local
                                {
                                    if (File.Exists(filePath))
                                    {
                                        returnCode = ExecuteCmd(gacUtilPath, String.Format("/i \"{0}\"", filePath));
                                    }
                                }
                                else //remote, Custom DLL folder already copied above, now just execute gacutil using PsExec
                                {
                                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\" " + " -accepteula" +" "+
                                        remoteRootFolder + "\\GacUtil.exe -i " + " \"" + remoteRootFolder + customDllFolderName + "\\" + dllNameRemote + "\"\"";
                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments); //gac dll remotely
                                }

                                if (returnCode == 0)
                                {
                                    LogInfo("Gaced Assembly: " + srcLines[i]);
                                    
                                }
                                else
                                    LogShortErrorMsg("Failed: Gac Assembly: " + srcLines[i]);
                                
                            }
                            catch (Exception ex)
                            {
                                LogException(ex);
                            }
                        }
                    }
                    if (flagCustomDllExists == 0)
                        LogInfo("Custom Dll list is empty.");
                    else
                        LogShortSuccessMsg("Success: Custom Assemblies Imported");
                }

               
                if(strServerType== "BizTalk")
                {
                    string[] srcLines = System.IO.File.ReadAllLines(xmlPath + @"\BizTalkAssemblyToImport.txt");
                    int flagBizTalkDllExists = 0;
                    LogInfo("BizTalk Assembly Import Started.");
                    for (int i = 0; i < srcLines.Length; i++)  
                    {
                        if (srcLines[i] != string.Empty)
                        {
                            flagBizTalkDllExists++;
                            try
                            {
                                string dllName = srcLines[i].Substring(0, srcLines[i].LastIndexOf("_"));
                                string dllNameRemote = srcLines[i] + "\\" + dllName + ".dll";
                                filePath = asmPath + "\\" + srcLines[i] + "\\" + dllName + ".dll";
                               
                                if (machineName == strDstNode) //local
                                {
                                    if (File.Exists(filePath))
                                    {
                                        returnCode = ExecuteCmd(gacUtilPath, String.Format("/i \"{0}\"", filePath));
                                    }
                                }
                                else //remote 
                                {
                                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\" " + " -accepteula" + " " +
                                        remoteRootFolder + "\\GacUtil.exe -i " + " \"" + remoteRootFolder + asmFolderName + "\\" + dllNameRemote + "\"\"";
                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments); //gac dll remotely
                                }

                                if (returnCode == 0)
                                {
                                    LogInfo("Gaced Assembly: " + srcLines[i]);

                                }
                                else
                                    LogShortErrorMsg("Failed: Gac Assembly: " + srcLines[i]);

                            }
                            catch (Exception ex)
                            {
                                LogException(ex);
                            }
                        }
                    }
                    if (flagBizTalkDllExists == 0)
                        LogInfo("BizTalk Assembly list is empty.");
                    else
                        LogShortSuccessMsg("Success: BizTalk Assemblies Imported");
                }
                if (machineName != strDstNode)
                {
                    //Delete Folders
                    try
                    {
                      string  remoteRootFolderUnc = ConvertPathToUncPath(remoteRootFolder);
                      string asmFolder=  "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + asmFolderName;
                        string customDllFolder= "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + customDllFolderName;
                        if (Directory.Exists(asmFolder))
                        {
                            Directory.Delete(asmFolder, true);
                        }
                        if (Directory.Exists(customDllFolder))
                        {
                            Directory.Delete(customDllFolder, true);
                        }
                    }
                    catch(Exception ex)
                    {
                        LogException(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        #endregion

        #region Bam

        private string btnBamExport_Click(object sender, EventArgs e)
        {
            string commandArguments;
            SqlCommand sqlCmd = null;
            int returnCode=0;
            try
            {
                LogInfo("BAM: Export started.");

                LogInfo("Cleaning already existing Bam Files.");
                try  //cleaning process before starting export.
                {
                    if (File.Exists(xmlPath + "\\BamDef.xml"))
                    {
                        File.Delete(xmlPath + "\\BamDef.xml");
                        LogInfoInLogFile("Deleted BamDef.xml.");
                    }

                    if (File.Exists(xmlPath + "\\BamDefToImport.xml"))
                    {
                        File.Delete(xmlPath + "\\BamDefToImport.xml");
                        LogInfoInLogFile("Deleted BamDefToImport.xml.");
                    }

                    if (File.Exists(xmlPath + @"\SrcBamViewsList.txt"))
                    {
                        File.Delete(xmlPath + @"\SrcBamViewsList.txt");
                        LogInfoInLogFile("Deleted SrcBamViewsList.txt.");
                    }

                    if (File.Exists(xmlPath + @"\DstBamActivitiesList.txt"))
                    {
                        File.Delete(xmlPath + @"\DstBamActivitiesList.txt");
                        LogInfoInLogFile("Deleted DstBamActivitiesList.txt.");
                    }

                    string[] bamViewFiles = Directory.GetFiles(xmlPath, "BamView_*.txt", SearchOption.AllDirectories);
                    foreach (string bamViewFile in bamViewFiles)
                    {
                        File.Delete(bamViewFile);
                        LogInfoInLogFile("Deleted " + bamViewFile);
                    }

                    string[] bttFiles = Directory.GetFiles(xmlPath, "BTT_*.xml", SearchOption.AllDirectories);
                    foreach (string bttFile in bttFiles)
                    {
                        File.Delete(bttFile);
                        LogInfoInLogFile("Deleted " + bttFile);
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error while cleaning Bam Files, please clean them manually and resume operation." + ex.Message);
                }

                SqlDataReader sqlRed = null;
                SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                sqlCon.Open();

                SqlCommand sqlcmd = new SqlCommand("SELECT [BamDBServerName] FROM [adm_Group]", sqlCon);
                sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (sqlRed.Read())
                {
                    srcBAMSqlInstance = sqlRed.GetString(0);
                }

                LogInfo("Connecting to BamPrimaryImport...." + srcBAMSqlInstance);
                if (machineName == strSrcNode)
                {
                    commandArguments = " get-defxml -FileName:\"" + xmlPath + "\\BamDef.xml\" -Server:" + srcBAMSqlInstance + " -Database:BAMPrimaryImport";
                    returnCode = ExecuteCmd(bamExePath, commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: BAM Definition Exported.");
                    else
                    {
                        throw new Exception("Failed: BAM Definition Export");
                    }
                }
                else
                {
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
         remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportBamDefinition\" \"" + srcBAMSqlInstance + "\" \"";
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Triggered BAM Defintion Export Remotely,Please Check Remote operation Log for Further Details.");
                    else
                    {
                        throw new Exception("Failed: Triggering BAM Defintion Export");
                    }
                }

                
                if (!(File.Exists(xmlPath + @"\BamDef.xml")))
                    throw new Exception("BamDef.xml is not Present");

                //Get all Views
                LogInfo("BAM: Get all views.");

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SqlConnection("Server=" + srcBAMSqlInstance + ";Initial Catalog=BamPrimaryImport;Integrated Security=SSPI");
                //two queries, one for views and second for BTT
                sqlCmd.CommandText = "SELECT ViewName FROM bam_Metadata_Views;SELECT ProfileXml, ActivityName FROM bam_Metadata_TrackingProfiles;";

                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAd = new SqlDataAdapter(sqlCmd);

                sqlDataAd.Fill(ds);

                ds.Tables[0].TableName = "BamViews";
                ds.Tables[1].TableName = "BttFiles";
                using (StreamWriter writer = new StreamWriter(xmlPath + @"\SrcBamViewsList.txt", false))
                {
                    foreach (DataRow dRow in ds.Tables["BamViews"].Rows)
                    {
                        writer.WriteLine(dRow["ViewName"].ToString());
                    }
                }
                LogInfo("Success: Created SrcBamViewsList.txt.");
                //get all accounts for each view
                foreach (DataRow dRow in ds.Tables["BamViews"].Rows)
                {
                    LogInfoInLogFile("BAM: Get Accounts for View: " + dRow["ViewName"].ToString());
                    if (machineName == strSrcNode)
                    {
                        commandArguments = "/C " + "\"\"" + bamExePath + "\"" + " get-accounts -View:\"" + dRow["ViewName"].ToString() + "\" -Server:" + srcBAMSqlInstance
                            + " -Database:BAMPrimaryImport > \"" + xmlPath + "\\BamView_" + dRow["ViewName"].ToString() + ".txt\"\"";
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                        if (returnCode == 0)
                            LogShortSuccessMsg("Success: Get BAM Accounts for View: " + dRow["ViewName"].ToString());
                        else
                            LogShortErrorMsg("Failed: Get BAM Accounts for View: " + dRow["ViewName"].ToString());
                    }
                    else
                    {
                        string appPathUnc = ConvertPathToUncPath(appPath);
                        commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                   remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ExportBAMAccounts\" \"" + srcBAMSqlInstance + "\" \"" + dRow["ViewName"].ToString() + "\"\"";

                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                        if (returnCode == 0)
                            LogShortSuccessMsg("Success:  Remotely Trigggered  BAM Accounts for View: " + dRow["ViewName"].ToString() + ",Please Check Remote operation Log for Further Details.");
                        else
                            LogShortErrorMsg("Failed: Triggering Remotely BAM Accounts for View: " + dRow["ViewName"].ToString());
                    }

                    
                }

                //BTT Files
                LogInfo("Starting BTT file export.");
                foreach (DataRow dRow in ds.Tables["BttFiles"].Rows)
                {
                    string bttXml = dRow["ProfileXml"].ToString();
                    string activityName = dRow["ActivityName"].ToString();
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.LoadXml(bttXml);
                    xDoc.Save(xmlPath + "\\BTT_" + activityName + ".xml");
                }
                LogShortSuccessMsg("Success: Exported BTT files.");

                return string.Empty;
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            finally
            {
                if (sqlCmd != null)
                    if (sqlCmd.Connection != null)
                        sqlCmd.Connection.Close();
            }
            return strSuccess;
        }

        private string btnBamImport_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = null;
            DataSet ds = null;
            SqlDataAdapter sqlDataAd = null;
            string commandArguments;
            int returnCode=0;
            try
            {
                LogInfo("BAM: Import started.");
               
                if (!File.Exists(xmlPath + @"\BamDef.xml"))
                    throw new Exception("BamDef xml file does not exist.");

                //check file is empty or not
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\BamDef.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file is empty.                
                    throw new Exception("BamDef xml file is empty.");

                LogInfo("Cleaning already existing Bam Files: BamDefToImport.xml and DstBamActivitiesList.txt.");
                try  //cleaning process before starting import, 2 files have to be deleted which are Generated anew.
                {
                    if (File.Exists(xmlPath + "\\BamDefToImport.xml"))
                    {
                        File.Delete(xmlPath + "\\BamDefToImport.xml");
                        LogInfo("Deleted BamDefToImport.xml.");
                    }

                    if (File.Exists(xmlPath + @"\DstBamActivitiesList.txt"))
                    {
                        File.Delete(xmlPath + @"\DstBamActivitiesList.txt");
                        LogInfo("Deleted DstBamActivitiesList.txt.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while cleaning Bam Files, please clean them manually and resume operation." + ex.Message);
                }

                SqlDataReader sqlRed = null;
                SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                sqlCon.Open();

                SqlCommand sqlcmd = new SqlCommand("SELECT [BamDBServerName] FROM [adm_Group]", sqlCon);
                sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (sqlRed.Read())
                {
                    dstBAMSqlInstance = sqlRed.GetString(0);
                }

                LogInfo("Connecting Dst Sql..." + dstBAMSqlInstance);
                //get existing activities from Dst machine and write into DstBamActivitiesList.txt file under XmlBinding Folder
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SqlConnection("Server=" + dstBAMSqlInstance + ";Initial Catalog=BamPrimaryImport;Integrated Security=SSPI");

                sqlCmd.CommandText = "SELECT ActivityName FROM bam_Metadata_Activities;SELECT ProfileXml, ActivityName FROM bam_Metadata_TrackingProfiles;";

                ds = new DataSet();
                sqlDataAd = new SqlDataAdapter(sqlCmd);

                sqlDataAd.Fill(ds);
                ds.Tables[0].TableName = "Activites";
                ds.Tables[1].TableName = "BttFiles";

                //create DstBamActivitiesList.txt
                using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstBamActivitiesList.txt", false))
                {
                    foreach (DataRow dRow in ds.Tables["Activites"].Rows)
                    {
                        writer.WriteLine(dRow["ActivityName"].ToString());
                    }
                }
                //create DstBamBttList.txt
                using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstBamBttList.txt", false))
                {
                    foreach (DataRow dRow in ds.Tables["BttFiles"].Rows)
                    {
                        writer.WriteLine(dRow["ActivityName"].ToString());
                    }
                }

                LogInfo("Generated BamActivities list of Dst.");
                //update BamDef File
                UpdateBamDefFile(xmlPath + "\\BamDef.xml", xmlPath + "\\DstBamActivitiesList.txt");

                //check file is empty or not
                doc = new XmlDocument();
                doc.Load(xmlPath + "\\BamDefToImport.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("BamDefToImport xml file is empty.");

                LogInfo("Generated BamActivities Delta to be imported.");


                //Now import Bam Def xml
                if (machineName == strDstNode)
                {
                    commandArguments = " deploy-all -DefinitionFile:\"" + xmlPath + "\\BamDefToImport.xml\" -Server:" + dstBAMSqlInstance
                            + " -Database:BAMPrimaryImport";
                    returnCode = ExecuteCmd(bamExePath, commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: BamDef Imported.");
                    else
                        throw new Exception("BamDef import failed, hence aborting account import.");
                }
                else
                {
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
         remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportBamDefinition\" \"" + dstBAMSqlInstance + "\" \"";
                    
                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Triggered BamDef Import Remotely,Please check Remote Operations Log for More Details.");
                    else
                        throw new Exception("Failed: Triggering BamDef Import , hence aborting account import.");
                }

              

                //read all view name from exported SrcBamViewsList.txt file
                string[] linesViewName = System.IO.File.ReadAllLines(xmlPath + @"\SrcBamViewsList.txt");

                for (int countViewName = 0; countViewName < linesViewName.Length; countViewName++)
                {
                    try
                    {
                        string[] lines = null;
                        try
                        {
                            //read file with ViewName to import Accounts
                            lines = System.IO.File.ReadAllLines(xmlPath + "\\BamView_" + linesViewName[countViewName] + ".txt");
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Could not read file: " + xmlPath + "\\" + linesViewName[countViewName] + ".txt. " + ex.Message);
                        }
                        for (int i = 6; i < lines.Length; i++)
                        {
                            if (machineName == strDstNode)
                            {
                                commandArguments = " add-account -AccountName:\"" + lines[i] + "\" -View:\"" + linesViewName[countViewName] + "\" -Server:"
                                    + dstBAMSqlInstance
                                   + " -Database:BAMPrimaryImport";
                                returnCode = ExecuteCmd(bamExePath, commandArguments);
                                if (returnCode == 0)
                                    LogShortSuccessMsg("Account: " + lines[i] + " added to view: " + linesViewName[countViewName]);
                                else
                                    LogShortErrorMsg("Account: " + lines[i] + " could not be added to view: " + linesViewName[countViewName]);
                            }
                            else
                            {
                                string appPathUnc = ConvertPathToUncPath(appPath);
                                commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                          remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"ImportBAMAccounts\" \"" + dstBAMSqlInstance + "\" \"" + lines[i] + "\" \"" + linesViewName[countViewName] + "\"\"";

                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                
                                if (returnCode == 0)
                                    LogShortSuccessMsg(" Triggered Remotely for Account: " + lines[i] + " to add to view: " + linesViewName[countViewName] + ", Please Check Remote operation Log for Further Details");
                                else
                                    LogShortErrorMsg("Account: " + lines[i] + " could not be added to view: " + linesViewName[countViewName] + " Remotely");
                            }
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        LogException(ex);
                    }
                }


            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            try
            {
                //btt import
                string bttDeployExePath = bamExePath.Substring(0, bamExePath.LastIndexOf("\\") + 1) + "bttDeploy.exe ";
                string[] bttFiles = Directory.GetFiles(xmlPath, "BTT_*.xml", SearchOption.AllDirectories);
                string[] dstBttActivities = System.IO.File.ReadAllLines(xmlPath + @"\DstBamBttList.txt");

                foreach (string bttFile in bttFiles)
                {
                    string srcActName = Path.GetFileNameWithoutExtension(bttFile);
                    srcActName = srcActName.Substring(srcActName.IndexOf('_') + 1); //remove btt_ prefix and get Src Activity Name.
                    if (!dstBttActivities.Contains(srcActName)) //if destination does not have that btt then import
                    {
                        if (machineName == strDstNode)
                        {
                            commandArguments = " /mgdb \"" + dstSqlInstance + "\\BizTalkMgmtDb" + "\" \"" + bttFile + "\"";
                            returnCode = ExecuteCmd(bttDeployExePath, commandArguments);
                            if (returnCode == 0)
                                LogInfo("Sucess: BTT File Imported " + bttFile.Substring(bttFile.LastIndexOf("\\") + 1));
                            else
                                LogShortErrorMsg("Failed: BTT File Import " + bttFile.Substring(bttFile.LastIndexOf("\\") + 1));
                        }
                        else
                        {
                            string appPathUnc = ConvertPathToUncPath(appPath);
                            string bttFileUnc = ConvertPathToUncPath(bttFile);
                            commandArguments = "/C " + "\"\"" + psExecPath + "\" -h \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                       remoteRootFolder + "\\" + remoteExeName + "\" \"" + "\\\\" + machineName + "\\" + appPathUnc + "\" \"ImportBTTList\" \"" + dstSqlInstance + "\" \"" + "\\\\" + machineName + "\\" + bttFileUnc+ "\"\"";
                            returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                            if (returnCode == 0)
                                LogInfo("Sucess: Trigerred Remotely BTT File Import " + bttFile.Substring(bttFile.LastIndexOf("\\") + 1) + ", Please Check Remote operation Log for Further Details.");
                            else
                                LogShortErrorMsg("Failed: Triggering Remotely BTT File Import " + bttFile.Substring(bttFile.LastIndexOf("\\") + 1));
                        }

                     
                    }
                }

                // return strSuccess;
            }
            catch (Exception ex)
            {
                LogException(ex);
            }

            finally
            {
                if (sqlCmd != null)
                    if (sqlCmd.Connection != null)
                        sqlCmd.Connection.Close();
            }

            return strSuccess;
        }
        #endregion        

        #region Services
        private string btnServicesExport_Click(object sender, EventArgs e)
        {
            char[] chrSep = { ',' };
            string strSrc, strDst, commandArguments;
            string[] serviceName = strWindowsServiceToIgnore.Split(chrSep);
            string userNameNoDomain = strUserNameForHost.Substring(strUserNameForHost.LastIndexOf("\\") + 1);  //userName with out domain like ectest.
            int returnCode;

            try
            {
                LogInfo("Services: Export started.");
                try
                {
                    if (Directory.Exists(serviceFolderPath))
                    {
                        Directory.Delete(serviceFolderPath, true);
                        Directory.CreateDirectory(serviceFolderPath);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while cleaning folder, hence aboting folder export " + ex.Message + ", " + ex.StackTrace);
                }

                if (machineName == strSrcNode) //local
                {
                    SelectQuery query = new System.Management.SelectQuery(string.Format(
                            "select name, startname, pathname, displayname from Win32_Service"));
                    using (StreamWriter writer = new StreamWriter(xmlPath + @"\SrcServiceList.txt", false))
                    {
                        using (ManagementObjectSearcher searcher =
                            new System.Management.ManagementObjectSearcher(query))
                        {
                            foreach (ManagementObject service in searcher.Get())
                            {
                                if (service["startname"] != null && (service["startname"].ToString().ToLower().Contains(userNameNoDomain)|| service["startname"].ToString().ToLower().Contains(userNameNoDomain.ToLower())))
                                {
                                    bool blFound = true;
                                    for (int i = 0; i < serviceName.Length; i++)
                                    {
                                        if (service["name"].ToString().Contains(serviceName[i]))
                                        {
                                            blFound = false;
                                        }
                                    }
                                    if (blFound)
                                    {
                                        string strPathName = service["pathname"].ToString();
                                        writer.WriteLine(service["name"] + "," + strPathName.ToString().Trim('"') + "," + service["displayname"]);
                                    }
                                }
                            }
                        }
                    }
                    LogShortSuccessMsg("Success: SrcServicesList Exported.");
                }
                else//remote
                {
                    string customDllPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(customDllPath);
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string asmPathUnc = ConvertPathToUncPath(asmPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                         remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"SrcServiceList\" \""
                         + strWindowsServiceToIgnore + "\" \"" + userNameNoDomain + "\"\"";

                    returnCode = ExecuteCmd("CMD.EXE", commandArguments); //dlls will be copied and pasted back to Local machine, hence machineName used in commandArgument.

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: SrcServicesList Exported.");
                    else
                        LogShortErrorMsg("Failed: SrcServicesList Export.");
                }

                if (strToolMode == "Backup")
                {
                    //read Source File and copy exe folder to local.
                    string[] srcLines = System.IO.File.ReadAllLines(xmlPath + @"\SrcServiceList.txt");

                    for (int i = 0; i < srcLines.Length; i++)
                    {
                        string[] srvDetails = srcLines[i].Split(chrSep);
                        string folderPathTrimed = srvDetails[1].Substring(0, srvDetails[1].LastIndexOf("\\")); //go one step back from exe path
                        string driveInfo = Path.GetPathRoot(folderPathTrimed);
                        string driveLetter = driveInfo.Substring(0, 1);
                        string pathWithoutDrive = folderPathTrimed.Substring(3, folderPathTrimed.Length - 3);
                        strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                        strDst = serviceFolderPath + "\\" + folderPathTrimed.Substring(folderPathTrimed.LastIndexOf('\\'));
                        LogInfo("Copy started from:" + strSrc + " To " + strDst);
                        commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /MIN:1 /R:1";  //copy folders only with all permissons
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                        if (returnCode < strRoboCopySuccessCode)
                            LogShortSuccessMsg("Success: Exported Folders.");
                        else
                            LogShortErrorMsg("Failed: Exporting Folders");
                    }
                }

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            return "";
        }

        private string btnServicesImport_Click(object sender, EventArgs e)
        {
            char[] chrSep = { ',' };
            string strSrc, strDst, commandArguments;
            string[] serviceName = strWindowsServiceToIgnore.Split(chrSep);
            string userNameNoDomain = strUserNameForHost.Substring(strUserNameForHost.LastIndexOf("\\") + 1);  //userName with out domain like ectest.
            int returnCode;

            try
            {
                if (machineName == strDstNode) //local
                {
                    try
                    {
                        SelectQuery query = new System.Management.SelectQuery(string.Format(
                                "select name, startname, pathname  from Win32_Service"));
                        using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstServiceList.txt", false))
                        {
                            using (ManagementObjectSearcher searcher =
                                new System.Management.ManagementObjectSearcher(query))
                            {
                                foreach (ManagementObject service in searcher.Get())
                                {
                                    if (service["startname"] != null && (service["startname"].ToString().ToLower().Contains(userNameNoDomain) || service["startname"].ToString().ToLower().Contains(userNameNoDomain.ToLower())))
                                    {
                                        bool blFound = true;
                                        for (int i = 0; i < serviceName.Length; i++)
                                        {
                                            if (service["name"].ToString().Contains(serviceName[i]))
                                            {
                                                blFound = false;
                                            }
                                        }
                                        if (blFound)
                                            writer.WriteLine(service["name"] + "," + service["pathname"]);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex.InnerException);
                    }
                }
                else//remote
                {
                    string customDllPathUnc = "\\\\" + machineName + "\\" + ConvertPathToUncPath(customDllPath);
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string asmPathUnc = ConvertPathToUncPath(asmPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                         remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"DstServiceList\" \""
                         + strWindowsServiceToIgnore + "\" \"" + userNameNoDomain + "\"\"";

                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: DstServicesList Exported.");
                    else
                    {
                        LogShortErrorMsg("Failed: DstServicesList Export.");
                        throw new Exception("Service Import aborted as DstServicesList.txt failed to generate.");
                    }
                }

                //compare source and destination
                string[] srcLines = System.IO.File.ReadAllLines(xmlPath + @"\SrcServiceList.txt");
                string[] dstLines = System.IO.File.ReadAllLines(xmlPath + @"\DstServiceList.txt");

                for (int i = 0; i < srcLines.Length; i++)
                {
                    bool found = false;
                    string[] srvDetails = srcLines[i].Split(chrSep);
                    for (int j = 0; j < dstLines.Length; j++)
                    {
                        if (dstLines[j].Contains(srvDetails[0]))
                            found = true;
                    }

                    if (found == false)  //not found in Destination Machine, then copy folder and create service.
                    {
                        //copy folder
                        string folderPathTrimed = srvDetails[1].Substring(0, srvDetails[1].LastIndexOf("\\"));
                        string driveInfo = Path.GetPathRoot(folderPathTrimed);
                        string driveLetter = driveInfo.Substring(0, 1);
                        string pathWithoutDrive = folderPathTrimed.Substring(3, folderPathTrimed.Length - 3);

                        if (strToolMode == "Migrate")
                            strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                        else
                            strSrc = serviceFolderPath + "\\" + folderPathTrimed.Substring(folderPathTrimed.LastIndexOf('\\'));
                        if(string.IsNullOrEmpty(strServicesDrive)||string.IsNullOrWhiteSpace(strServicesDrive))
                        strDst = "\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                        else
                            strDst = "\\\\" + strDstNode + "\\" + strServicesDrive.Trim().Substring(0,1) + "$\\" + pathWithoutDrive;
                        LogInfo("Copy started from: " + strSrc + " To " + strDst);
                        commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /MIN:1 /R:1";  // /xc /xn /xo exclude existing file and folders
                        returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                        if (returnCode < strRoboCopySuccessCode)
                        {
                            LogShortSuccessMsg("Success: Imported Service Folders/Files.");
                            //copy successful hence create Service
                            if (strDstNode == machineName) //local
                                commandArguments = @"/C sc create " + "\"" + srvDetails[0] + "\" DisplayName=\"" + srvDetails[2] + "\" binPath=\"" + srvDetails[1] + "\" start=auto obj=\"" + strUserNameForHost + "\" password=\"" + strPasswordForHost + "\"";
                            else //remote
                                commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                                + " sc create " + "\"" + srvDetails[0] + "\" DisplayName=\"" + srvDetails[2] + "\" binPath=\"" + srvDetails[1] + "\" start=auto obj=\"" + strUserNameForHost + "\" password=\"" + strPasswordForHost + "\"\"";

                            returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                            if (returnCode == 0)
                                LogShortSuccessMsg("Success: Imported Service: " + srvDetails[0]);
                            else
                                LogShortErrorMsg("Failed: Importing Service: " + srvDetails[0]);
                        }
                        else
                            LogShortErrorMsg("Failed: Importing Service Folders/Files.");
                    }
                }

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            return "";
        }
        #endregion

        #region readioButton Checked Changed Events
        private void rbWebsiteYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWebsiteYes.Checked == true)
            {
                strWebSite = strPerformOperationYes;
            }
            else
            {
                strWebSite = strPerformOperationNo;
            }
        }

        private void rbAppPoolYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAppPoolYes.Checked == true)
            {
                strAppPool = strPerformOperationYes;
            }
            else
            {
                strAppPool = strPerformOperationNo;
            }
        }

        private void rbCertificateYes_CheckedChanged(object sender, EventArgs e)
        {

            if (rbCertificateYes.Checked == true)
            {
                strCertificate = strPerformOperationYes;
            }
            else
            {
                strCertificate = strPerformOperationNo;
            }
        }

        private void rbHostInstanceYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHostInstanceYes.Checked == true)
            {
                strHostInstance = strPerformOperationYes;
            }
            else
            {
                strHostInstance = strPerformOperationNo;
            }
        }

        private void rbHandlersYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHandlersYes.Checked == true)
            {
                strHandlers = strPerformOperationYes;
            }
            else
            {
                strHandlers = strPerformOperationNo;
            }
        }

        private void rbGlobalPartyBindingYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGlobalPartyBindingYes.Checked == true)
            {
                strGlobalPartyBinding = strPerformOperationYes;
            }
            else
            {
                strGlobalPartyBinding = strPerformOperationNo;
            }
        }

        private void rbBizTalkAssembliesYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBizTalkAssembliesYes.Checked == true)
            {
                strBizTalkAssemblies = strPerformOperationYes;
            }
            else
            {
                strBizTalkAssemblies = strPerformOperationNo;
            }
        }

        private void rbBizTalkAppYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBizTalkAppYes.Checked == true)
            {
                strBizTalkApp = strPerformOperationYes;
            }
            else
            {
                strBizTalkApp = strPerformOperationNo;
            }
        }

        private void rbBamYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBamYes.Checked == true)
            {
                strBam = strPerformOperationYes;
            }
            else
            {
                strBam = strPerformOperationNo;
            }
        }

        private void rbFileCopyYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFileCopyYes.Checked == true)
            {
                strFileCopy = strPerformOperationYes;
            }
            else
            {
                strFileCopy = strPerformOperationNo;
            }
        }

        private void rbMigrate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMigrate.Checked == true)
            {
                strToolMode = "Migrate";
                LogInfo("Mode is set to Migration. Folder / VDir operation will be between Source and Destination.");
            }
            else
            {
                strToolMode = "Backup";
                LogInfo("Mode is set to Backup. Folder / VDir operation will be between Source and Local.");
            }

        }

        private void rbApp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApp.Checked == true)  //if App
            {
                strServerType = "App";
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel8.Enabled = false;
                panel9.Enabled = false;
                panel10.Enabled = false;
                cmbBoxServerDst.Visible = false;
                cmbBoxServerSrc.Visible = false;
                label2.Text = "Server  (Source)";
                label15.Text = "Server  (Destination)";
                txtConnectionString.Text = "SERVER NAME";
                txtConnectionStringDst.Text = "SERVER NAME";

                if (File.Exists(serverXmlPath)) //reloading BizTalk Connection Info
                {
                    char[] chrSep = { ',' };
                    Servers srv = null;
                    XmlSerializer configSerializer = null;

                    XmlTextReader xmlTxtRed = new XmlTextReader(serverXmlPath);
                    configSerializer = new XmlSerializer(typeof(Servers));
                    srv = (Servers)configSerializer.Deserialize(xmlTxtRed);
                    xmlTxtRed.Close();
                    configSerializer = null;

                    txtConnectionString.Text = srv.SrcAppNode;
                    txtConnectionStringDst.Text = srv.DstAppNode;
                }

                if (txtConnectionString.Text != string.Empty && txtConnectionString.Text != "SERVER NAME")
                    strSrcNode = txtConnectionString.Text;

                if (txtConnectionStringDst.Text != string.Empty && txtConnectionStringDst.Text != "SERVER NAME")
                    strDstNode = txtConnectionStringDst.Text;
            }
            else  //BizTalk
            {
                strServerType = "BizTalk";
                panel4.Enabled = true;
                panel5.Enabled = true;
                panel8.Enabled = true;
                panel9.Enabled = true;
                panel10.Enabled = true;
                cmbBoxServerDst.Visible = true;
                cmbBoxServerSrc.Visible = true;
                label2.Text = "BizTalk Mgmt Grp (Src)";
                label15.Text = "BizTalk Mgmt Grp (Dst)";
                txtConnectionString.Text = "SQL INSTANCE";
                txtConnectionStringDst.Text = "SQL INSTANCE";

                if (File.Exists(serverXmlPath)) //reloading BizTalk Connection Info
                {
                    char[] chrSep = { ',' };
                    Servers srv = null;
                    XmlSerializer configSerializer = null;

                    XmlTextReader xmlTxtRed = new XmlTextReader(serverXmlPath);
                    configSerializer = new XmlSerializer(typeof(Servers));
                    srv = (Servers)configSerializer.Deserialize(xmlTxtRed);
                    xmlTxtRed.Close();
                    configSerializer = null;
                    cmbBoxServerSrc.Items.Clear();
                    cmbBoxServerDst.Items.Clear();
                    if (srv.SrcSqlInstance != null)
                    {
                        txtConnectionString.Text = srv.SrcSqlInstance;
                        //lblServers.Text = srv.SrcNodes;
                        srcSqlInstance = srv.SrcSqlInstance;
                        string[] srcNodes = srv.SrcNodes.Split(chrSep);
                        for (int i = 0; i < srcNodes.Length; i++)
                        {
                            cmbBoxServerSrc.Items.Add(srcNodes[i]);
                        }
                        cmbBoxServerSrc.Visible = true;
                    }
                    else
                    {
                        //  LogShortErrorMsg("Source Sql Instance is missing."); 
                    }


                    if (srv.DstSqlInstance != null)
                    {
                        txtConnectionStringDst.Text = srv.DstSqlInstance;
                        string[] dstNodes = srv.DstNodes.Split(chrSep);
                        for (int i = 0; i < dstNodes.Length; i++)
                        {
                            cmbBoxServerDst.Items.Add(dstNodes[i]);
                        }
                        cmbBoxServerDst.Visible = true;
                        dstSqlInstance = srv.DstSqlInstance;
                    }
                    else
                    {
                        //  LogShortErrorMsg("Destination Sql Instance missing."); 
                    }

                }
            }
        }

        private void rbServicesYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbServicesYes.Checked == true)
            {
                strServices = strPerformOperationYes;
            }
            else
            {
                strServices = strPerformOperationNo;
            }
        }

        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            richTextBoxLogs.AppendText("Esc Pressed");
            richTextBoxLogs.Refresh();
        }
        private void richTextBoxLogs_TextChanged_1(object sender, EventArgs e)
        {
            //if(richTextBoxLogs.len)
            richTextBoxLogs.ScrollToCaret();
            richTextBoxLogs.Refresh();
        }
        private void btnExportOperations_Click(object sender, EventArgs e)
        {
            try
            {
                strExport = strPerformOperationYes;

                if (strServerType == "BizTalk" && (txtConnectionString.Text == "SQL INSTANCE" || txtConnectionString.Text.Trim() == "" || cmbBoxServerSrc.Items.Count == 0 || cmbBoxServerSrc.SelectedItem == null))
                {
                    LogShortErrorMsg("Please mention Source Sql Instance and select node from DropDown.");
                }
                else if (strServerType == "App" && (txtConnectionString.Text == "SERVER NAME" || txtConnectionString.Text.Trim() == ""))
                {
                    LogShortErrorMsg("Please mention Source App Server.");
                }
                else
                {
                    if (strFileCopy == strPerformOperationYes || strAppPool == strPerformOperationYes || strWebSite == strPerformOperationYes || strCertificate == strPerformOperationYes || strHostInstance == strPerformOperationYes || strHandlers == strPerformOperationYes || strBizTalkApp == strPerformOperationYes || strGlobalPartyBinding == strPerformOperationYes || strBizTalkAssemblies == strPerformOperationYes || strBam == strPerformOperationYes || strServices == strPerformOperationYes)
                    {
                        #region PreRequisite Check
                        if (machineName != strSrcNode && strIsUtilCopied == strPerformOperationNo) //remote, hence exe has to be copied.
                        {
                            LogInfo("Its Remote Export.");
                            string commandArguments = "/C sc.exe \\\\" + strSrcNode + " delete psexesvc";

                            LogInfo("Copying required artifacts to remote machine: " + strSrcNode);

                            string remoteRootFolderUnc = ConvertPathToUncPath(remoteRootFolder);
                            commandArguments = @"/C robocopy " + "\"" + appPath + gacUtilFolderName + "\"" + " \"" + "\\\\" + strSrcNode + "\\" + remoteRootFolderUnc + "\" " + "\"" + remoteExeName + "\"" + " /IS /R:1";

                            int returnCode;
                            returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                            if (returnCode < strRoboCopySuccessCode)  //robocopy errorcode 1 means success
                            {
                                LogShortSuccessMsg("Copy completed from: " + appPath + gacUtilFolderName + " To " + "\\\\" + strSrcNode + "\\" + remoteRootFolderUnc);
                                strIsUtilCopied = strPerformOperationYes;
                            }
                            else
                            {
                                throw new Exception("Copying required artifacts to remote machine failed: " + strSrcNode);
                            }
                        }
                        #endregion

                        EnableControls(false);

                        if ((strUserName == "" || strUserName == null) && machineName != strSrcNode) //remote operation
                        {
                            panelLoginDialog.Visible = true;
                            loginOperationName = "useraccount";
                            lblLoginDialog.Text = "For remote deployment please provide credentials which has admin rights on destination server.";
                            txtUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                            txtPassword.Text = "";
                            txtPassword.Focus();
                            goto Outer;
                        }

                        if ((strHostInstance == strPerformOperationYes  || (strCertificate == strPerformOperationYes && machineName != strSrcNode) || strServices == strPerformOperationYes) && (strUserNameForHost == "" || strUserNameForHost == null))
                        {
                            panelLoginDialog.Visible = true;
                            loginOperationName = "serviceaccount";
                            lblLoginDialog.Text = "You have selected Host/Certificate/WindowsService Please provide service account details..";
                            txtUserName.Text = ""; //redmond\ectest
                            txtPassword.Text = "";
                            txtUserName.Focus();
                            goto Outer;
                        }

                        if(strCertificate == strPerformOperationYes && machineName == strSrcNode)
                        {
                            MessageBox.Show("To Export the Service Account Certificates, Login Server with Service Account and rerun the Tool.");
                            
                        }


                        if (strServices == strPerformOperationYes)
                        { btnServicesExport_Click(sender, e); }
                        /***************************************/
                        if (strFileCopy == strPerformOperationYes)
                        { btnExportFolders_Click(sender, e); }
                        /***************************************/
                        if (strAppPool == strPerformOperationYes)
                        { btnExportAppPools_Click(sender, e); }
                        /***************************************/
                        if (strWebSite == strPerformOperationYes)
                        { btnExportWebSites_Click(sender, e); }
                        /***************************************/
                        if (strCertificate == strPerformOperationYes)
                        { btnExportCert_Click(sender, e); }
                        /***************************************/
                        if (strHostInstance == strPerformOperationYes)
                        { btnGetHost_Click(sender, e); }
                        /***************************************/
                        if (strHandlers == strPerformOperationYes)
                        { btnExportAdapterHandlers_Click(sender, e); }
                        /***************************************/
                        if (strBizTalkApp == strPerformOperationYes)
                        { btnExportApps_Click(sender, e); }
                        /***************************************/
                        if (strBizTalkAssemblies == strPerformOperationYes)
                        { btnExportAssemblies_Click(sender, e); }
                        /***************************************/
                        if (strGlobalPartyBinding == strPerformOperationYes)
                        { btnExportGlobalPartyBinding_Click(sender, e); }
                        /***************************************/
                        if (strBam == strPerformOperationYes)
                        { btnBamExport_Click(sender, e); }

                        //reset all radio buttons to know
                        rbFileCopyNo.Checked = true;
                        rbAppPoolNo.Checked = true;
                        rbBizTalkAppNo.Checked = true;
                        rbBizTalkAssembliesNo.Checked = true;
                        rbCertificateNo.Checked = true;
                        rbGlobalPartyBindingNo.Checked = true;
                        rbHandlersNo.Checked = true;
                        rbHostInstanceNo.Checked = true;
                        rbWebsiteNo.Checked = true;
                        rbBamNo.Checked = true;
                        rbServicesNo.Checked = true;
                        EnableControls(true);

                    Outer:
                        ;
                    }
                    else
                    { LogShortErrorMsg("Please select atleast one operation."); }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void btnImportOperations_Click(object sender, EventArgs e)
        {
            try
            {
                strExport = strPerformOperationNo;
                if (strServerType == "BizTalk" && (txtConnectionStringDst.Text == "SQL INSTANCE" || txtConnectionStringDst.Text.Trim() == "" || cmbBoxServerDst.Items.Count == 0 || cmbBoxServerDst.SelectedItem == null))
                {
                    LogShortErrorMsg("Please mention Destination Sql Instance and select node from Drop Down.");
                }
                else if (strServerType == "App" && (txtConnectionStringDst.Text == "SERVER NAME" || txtConnectionStringDst.Text.Trim() == ""))
                {
                    LogShortErrorMsg("Please mention Destination App Server.");
                }
                else
                {
                    if (strFileCopy == strPerformOperationYes || strAppPool == strPerformOperationYes || strWebSite == strPerformOperationYes || strCertificate == strPerformOperationYes || strHostInstance == strPerformOperationYes || strHandlers == strPerformOperationYes || strBizTalkApp == strPerformOperationYes || strGlobalPartyBinding == strPerformOperationYes || strBizTalkAssemblies == strPerformOperationYes || strBam == strPerformOperationYes || strServices == strPerformOperationYes)
                    {
                        #region PreRequisite Check
                        if (machineName != strDstNode && strIsUtilCopied == strPerformOperationNo) //remote, hence exe has to be copied.
                        {
                            LogInfo("Its Remote Import.");
                            LogInfo("Copying required artifacts to remote machine: " + strDstNode);

                            string remoteRootFolderUnc = ConvertPathToUncPath(remoteRootFolder);
                            string commandArguments = @"/C robocopy " + "\"" + appPath + gacUtilFolderName + "\"" + " \"" + "\\\\" + strDstNode + "\\" + remoteRootFolderUnc + "\" " + " /IS /R:1";

                            int returnCode;
                            returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                            if (returnCode < strRoboCopySuccessCode) //robocopy returnCode 1 means success
                            {
                                LogShortSuccessMsg("RemoteOperations EXE Copy completed from: " + appPath + gacUtilFolderName + " To " + "\\\\" + strDstNode + "\\" + remoteRootFolderUnc);
                                strIsUtilCopied = strPerformOperationYes;
                            }
                            else
                            {
                                throw new Exception("Copy encountered errors. Remote import can not be triggered.");
                            }
                        }
                        #endregion

                        EnableControls(false);

                        if ((strHostInstance == strPerformOperationYes  || (strCertificate == strPerformOperationYes && machineName != strDstNode) || strServices == strPerformOperationYes) && (strUserNameForHost == "" || strUserNameForHost == null))
                        {
                            strExport = strPerformOperationNo;
                            panelLoginDialog.Visible = true;
                            loginOperationName = "serviceaccount";
                            lblLoginDialog.Text = "You have selected Host/Certificate/WindowsService Please provide service account details..";
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                            goto Outer;
                        }

                        if(strCertificate == strPerformOperationYes && machineName == strDstNode)
                        {
                            MessageBox.Show("To Import the Service Account Certificates, Login Server with Service Account and rerun the Tool.");
                        }

                        if (machineName != strDstNode && (strUserName == "" || strUserName == null)) //remote operation
                        {
                            panelLoginDialog.Visible = true;
                            loginOperationName = "useraccount";
                            lblLoginDialog.Text = "For remote deployment please provide credentials which has admin rights on destination server.";
                            txtUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                            txtPassword.Text = "";
                            goto Outer;
                        }

                        //windows service
                        if (strServices == strPerformOperationYes)
                            btnServicesImport_Click(sender, e);

                        //FileCopy
                        if (strFileCopy == strPerformOperationYes)
                        { btnImportFolders_Click(sender, e); }

                        //appPools
                        if (strAppPool == strPerformOperationYes)
                        { btnImportAppPools_Click(sender, e); }

                        //webSites
                        if (strWebSite == strPerformOperationYes)
                        {
                            if (isAppPoolExecuted == strPerformOperationYes)
                            {
                                btnImportWebSites_Click(sender, e);
                            }
                            else
                            {
                                LogShortErrorMsg("WebApplication will be skipped as AppPool import failed.");
                            }
                        }

                        //Certificate
                        if (strCertificate == strPerformOperationYes)
                        {
                            btnImportCert_Click(sender, e);
                        }

                        //Host
                        //HostInstance:
                        if (strHostInstance == strPerformOperationYes)
                        {
                            //   strFromPanel10 = strPerformOperationNo;
                            btnSetHostAndHostInstances_Click(sender, e);
                        }

                        //Handlers
                        if (strHandlers == strPerformOperationYes)
                        {
                            if (isHostExecuted == strPerformOperationYes)
                            {
                                btnImportAdapterHandler_Click(sender, e);
                            }
                            else
                            {
                                LogShortErrorMsg("Handlers will be skipped as Host has failed.");
                            }
                        }

                        //Assemblies
                        if (strBizTalkAssemblies == strPerformOperationYes)
                        {
                            btnImportAssemblies_Click(sender, e);
                        }

                        //BizTalk Applications
                        if (strBizTalkApp == strPerformOperationYes)
                        {
                            if (isHandlerExecuted == strPerformOperationYes && isHostExecuted == strPerformOperationYes)
                            {
                                btnImportApps_Click(sender, e);
                            }
                            else
                            {
                                LogShortErrorMsg("BizTalk Applications Import will be skipped as Host/Handler has failed");
                            }
                        }

                        //Global Party Binding
                        if (strGlobalPartyBinding == strPerformOperationYes)
                        {
                            if (isHandlerExecuted == strPerformOperationYes && isHostExecuted == strPerformOperationYes && isBizTalkAppExecuted == strPerformOperationYes)
                            {
                                btnImportGlobalPartyBinding_Click(sender, e);
                            }
                            else
                            {
                                LogShortErrorMsg("Global Party Binding Import will be skipped as stleast one of Host/Handler/BizTalk App has failed");
                            }
                        }

                        //BAM
                        if (strBam == strPerformOperationYes)
                        {
                            btnBamImport_Click(sender, e);
                        }

                        rbFileCopyNo.Checked = true;
                        rbAppPoolNo.Checked = true;
                        rbBizTalkAppNo.Checked = true;
                        rbBizTalkAssembliesNo.Checked = true;
                        rbCertificateNo.Checked = true;
                        rbGlobalPartyBindingNo.Checked = true;
                        rbHandlersNo.Checked = true;
                        rbHostInstanceNo.Checked = true;
                        rbWebsiteNo.Checked = true;
                        rbBamNo.Checked = true;
                        rbServicesNo.Checked = true;
                        EnableControls(true);
                        isHostExecuted = strPerformOperationYes;
                        isHandlerExecuted = strPerformOperationYes;
                        isAppPoolExecuted = strPerformOperationYes;
                    Outer:
                        ;
                    }
                    else
                    {
                        LogShortErrorMsg("Please select atleast one operation.");
                    }
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void btnExportWebSites_Click_1(object sender, EventArgs e)
        {

        }

        private void BizTalkAdminOperations_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(exportedDataPath))
                Directory.CreateDirectory(exportedDataPath);

            if (!Directory.Exists(msiPath))
                Directory.CreateDirectory(msiPath);

            if (!Directory.Exists(xmlPath))
                Directory.CreateDirectory(xmlPath);

            if (!Directory.Exists(certPath))
                Directory.CreateDirectory(certPath);

            if (!Directory.Exists(asmPath))
                Directory.CreateDirectory(asmPath);

            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            if (!Directory.Exists(customDllPath))
                Directory.CreateDirectory(customDllPath);

            if (!Directory.Exists(vDir))
                Directory.CreateDirectory(vDir);

            if (!Directory.Exists(fileFolderPath))
                Directory.CreateDirectory(fileFolderPath);

            if (!Directory.Exists(serviceFolderPath))
                Directory.CreateDirectory(serviceFolderPath);

            if (File.Exists(serverXmlPath))
            {
                char[] chrSep = { ',' };
                Servers srv = null;
                XmlSerializer configSerializer = null;

                XmlTextReader xmlTxtRed = new XmlTextReader(serverXmlPath);
                configSerializer = new XmlSerializer(typeof(Servers));
                srv = (Servers)configSerializer.Deserialize(xmlTxtRed);
                xmlTxtRed.Close();
                configSerializer = null;

                if (srv.SrcSqlInstance != null)
                {
                    txtConnectionString.Text = srv.SrcSqlInstance;
                    //lblServers.Text = srv.SrcNodes;
                    srcSqlInstance = srv.SrcSqlInstance;
                    string[] srcNodes = srv.SrcNodes.Split(chrSep);
                    for (int i = 0; i < srcNodes.Length; i++)
                    {
                        cmbBoxServerSrc.Items.Add(srcNodes[i]);
                    }
                    cmbBoxServerSrc.Visible = true;
                }
                else
                {
                    //LogShortErrorMsg("Source Sql Instance is missing."); 
                }


                if (srv.DstSqlInstance != null)
                {
                    txtConnectionStringDst.Text = srv.DstSqlInstance;
                    string[] dstNodes = srv.DstNodes.Split(chrSep);
                    for (int i = 0; i < dstNodes.Length; i++)
                    {
                        cmbBoxServerDst.Items.Add(dstNodes[i]);
                    }
                    cmbBoxServerDst.Visible = true;
                    dstSqlInstance = srv.DstSqlInstance;
                }
                else
                {
                    // cmbBoxServerDst.Visible = true;
                    // LogShortErrorMsg("Destination Sql Instance missing."); 
                }

            }
            this.ActiveControl = txtConnectionString;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            label18.Visible = false;
            char[] chrSep = { '\\' };
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                label18.Text = "UserName or Password missing.";
                label18.Visible = true;
            }
            else
            {
                if (loginOperationName == "useraccount") //for remote WMI, remote BizTalkApp 
                {
                    strUserName = txtUserName.Text.Trim();
                    strUserNameForWMI = txtUserName.Text.Split(chrSep)[1];
                    strPassword = txtPassword.Text.Trim();
                    strDomain = txtUserName.Text.Split(chrSep)[0];
                }
                else //Host
                {
                    strUserNameForHost = txtUserName.Text.Trim();
                    strPasswordForHost = txtPassword.Text.Trim();
                }

                panelLoginDialog.Visible = false;

                if (strExport == strPerformOperationYes)
                    btnExportOperations_Click(sender, e);
                else
                    btnImportOperations_Click(sender, e);
            }
        }

        private void cmbBoxServerSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            strSrcNode = cmbBoxServerSrc.SelectedItem.ToString();
        }

        private void cmbBoxServerDst_SelectedIndexChanged(object sender, EventArgs e)
        {
            strDstNode = cmbBoxServerDst.SelectedItem.ToString();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSubmit_Click(sender, e);
        }

        private void txtConnectionString_Validating(object sender, CancelEventArgs e)
        {
            if (strServerType == "App" && strSrcNode != txtConnectionString.Text.Trim() && txtConnectionString.Text.Trim() != "SERVER NAME" && txtConnectionString.Text.Trim() != "SQL INSTANCE")
                TstSrcSqlConnection(true);

            if (strServerType == "BizTalk" && srcSqlInstance != txtConnectionString.Text.Trim() && txtConnectionString.Text.Trim() != "SERVER NAME" && txtConnectionString.Text.Trim() != "SQL INSTANCE")
                TstSrcSqlConnection(true);
        }

        private void txtConnectionStringDst_Validating(object sender, CancelEventArgs e)
        {
            if (strServerType == "App" && strDstNode != txtConnectionStringDst.Text.Trim() && txtConnectionStringDst.Text.Trim() != "SERVER NAME" && txtConnectionStringDst.Text.Trim() != "SQL INSTANCE")
                TstDstSqlConnection(true);

            if (strServerType == "BizTalk" && dstSqlInstance != txtConnectionStringDst.Text.Trim() && txtConnectionStringDst.Text.Trim() != "SERVER NAME" && txtConnectionStringDst.Text.Trim() != "SQL INSTANCE")
                TstDstSqlConnection(true);
        }

        private void BizTalkAdminOperations_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings(this);
            settingsForm.ShowDialog();
        }
        #endregion

        #region Functions

        private void GetSharePermission()
        {
            char[] chrSep = { ',' };
            string commandArguments = "";
            if (strFoldersToCopyNoFiles != string.Empty)
            {
                string[] arrFoldersToCopyNoFiles = strFoldersToCopyNoFiles.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
                foreach (string folderPath in arrFoldersToCopyNoFiles)
                {
                    string folderName = folderPath.Trim().Substring(folderPath.LastIndexOf('\\') + 1);
                    if (machineName == strSrcNode) //local
                    {
                        commandArguments = "/C net share " + "\"\"" + folderName + " > \"" + xmlPath + "\\SharePermission_" + folderName + ".txt\"\"";
                    }
                    else //remote
                    {
                        commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                    + "  net share  \"" + folderName + "\" > \"" + xmlPath + "\\SharePermission_" + folderName + ".txt\"\"";
                    }

                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Exported Shared Permissions: " + folderName);
                    else
                    {
                        LogShortErrorMsg("Failed: Exporting Shared Permissions: " + folderName);
                        if (returnCode == 2)
                            LogShortErrorMsg("This shared resource does not exist.");
                    }
                }
            }
        }


        private void SetSharePermission()
        {
            char[] chrSep = { ',' };
            char[] chrSepSpace = { ' ' };
            string commandArguments = "", grantString = "";
            string dstFolderPath = string.Empty;
            if (strFoldersToCopyNoFiles != string.Empty)
            {
                string[] arrFoldersToCopyNoFiles = strFoldersToCopyNoFiles.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
                foreach (string folderPath in arrFoldersToCopyNoFiles)
                {
                    grantString = " ";
                    string folderName = folderPath.Substring(folderPath.LastIndexOf('\\') + 1);
                    if (string.IsNullOrEmpty(strFoldersDrive) || string.IsNullOrWhiteSpace(strFoldersDrive))
                    {
                        dstFolderPath = folderPath;
                    }
                    else
                        dstFolderPath = strFoldersDrive.Trim().Substring(0, 1) + folderPath.Substring(1);
                    string[] srcLines = System.IO.File.ReadAllLines(xmlPath + "\\SharePermission_" + folderName + ".txt");
                    int permissionLineIndex = -1;
                    for (int i = 0; i < srcLines.Length; i++)
                    {
                        if (srcLines[i] == string.Empty)  //once u got empty line, u exit bcos that mean permission section is over.
                            break;

                        if (srcLines[i].Contains("Permission")) //u got the line having word Permission
                            permissionLineIndex = i;

                        if (permissionLineIndex > 0) //start reading permission from this line
                        {
                            string[] permission = srcLines[i].Split(chrSep, StringSplitOptions.RemoveEmptyEntries);

                            if (i == permissionLineIndex)
                                grantString = grantString + "\"/GRANT:" + permission[0].Substring(18).Trim() + "," + permission[1].Trim() + "\" ";
                            else        ///GRANT:Everyone, FULL
                                grantString = grantString + "\"/GRANT:" + permission[0].Trim() + "," + permission[1].Trim() + "\" ";
                        }
                    }
                    if (machineName == strDstNode) //local
                    {
                        commandArguments = "/C net share " + folderName + "=\"" + dstFolderPath.Trim() + "\"" + grantString;
                        //net share sharename=c:\temp "/GRANT:fareast\v-somish,FULL" "/GRANT:fareast\sdhar,READ"
                    }
                    else //remote
                    {
                        commandArguments = "/C " + "\"\"" + psExecPath + "\" -s \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula"
                    + " net share " + folderName + "=\"" + dstFolderPath.Trim() + "\"" + grantString.TrimEnd();
                    }

                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                    if (returnCode == 0)
                        LogShortSuccessMsg("Success: Imported Shared Permissions: " + folderName);
                    else if (returnCode == 2)
                        LogInfo("Share name already exist: " + folderName);
                    else
                        LogShortErrorMsg("Failed: Importing Shared Permissions: " + folderName);
                }
            }

        }

        private void UpdateAppPoolXml()
        {   //delete existing Apppools from Xml which are there in Dst
            try
            {
                XElement root = XElement.Load(xmlPath + "\\AppPools.xml");
                XNamespace ns = root.GetDefaultNamespace();
                string[] lines = System.IO.File.ReadAllLines(xmlPath + "\\AppPoolList.txt");

                foreach (var item in lines)
                {
                    var applicationList = from el in root.Elements(ns + "APPPOOL")
                                          where el.Attribute("APPPOOL.NAME").Value.Equals(item)
                                          select el;
                    if (applicationList != null)
                    {
                        applicationList.Remove();
                    }
                }
                root.Save(xmlPath + "\\AppPoolToImport.xml");
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception occured while genrating Delta of AppPools to be Imported, please check log file for details.");
                LogException(ex);
                throw (ex);
            }
        }

        private void UpdateWebAppXml(string pWebAppsFileName, string pWebSiteName)
        {
            string srcBTSInstallPath = string.Empty;
            string dstBTSInstallPath = string.Empty;
            string srcDrive = string.Empty;
            string dstDrive = string.Empty;
            string srcBTSInstallPath1 = string.Empty;
            //delete existing WebApps from Xml which are there in Dst
            try
            {
                //Reading the Src BTSInstallPath
                if (File.Exists(xmlPath + "\\" + "SrcBTSInstallPath.txt"))
                {
                    string[] srcBTSInstall = System.IO.File.ReadAllLines(xmlPath + @"\srcBTSInstallPath.txt");

                    for (int j = 0; j < srcBTSInstall.Length; j++)
                    {
                        srcDrive = srcBTSInstall[j].Split('=')[1].Split(':')[0];
                        srcBTSInstallPath = srcDrive.ToLower() + ":" + srcBTSInstall[j].Split('=')[1].Split(':')[1];
                        srcBTSInstallPath1 = srcDrive.ToUpper() + ":" + srcBTSInstall[j].Split('=')[1].Split(':')[1];
                    }
                }

                //Reading the Dst BTSInstallPath
                if (File.Exists(xmlPath + "\\" + "DstBTSInstallPath.txt"))
                {
                    string[] dstBTSInstall = System.IO.File.ReadAllLines(xmlPath + @"\DstBTSInstallPath.txt");

                    for (int j = 0; j < dstBTSInstall.Length; j++)
                    {
                        dstDrive = dstBTSInstall[j].Split('=')[1].Split(':')[0];
                        dstBTSInstallPath = dstDrive.ToUpper() + ":" + dstBTSInstall[j].Split('=')[1].Split(':')[1];
                    }
                }
                XElement root = XElement.Load(xmlPath + "\\" + pWebAppsFileName);
                XNamespace ns = root.GetDefaultNamespace();
                string[] lines = System.IO.File.ReadAllLines(xmlPath + "\\DstWebAppList.txt");

                foreach (var item in lines)
                {
                    var applicationList = from el in root.Elements(ns + "APP")
                                              //where el.Attribute("path").Value.Equals(item)
                                          where el.Attribute("APP.NAME").Value.Equals(item)
                                          select el;
                    if (applicationList != null)
                    {
                        applicationList.Remove();
                    }
                }
                var result = from ele in root.Elements(ns + "APP")
                             select ele;
                foreach (var element in result)
                {
                    string physicalPath = element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").Value;
                    if (physicalPath.Contains(srcBTSInstallPath))
                    {
                        physicalPath = physicalPath.Replace(srcBTSInstallPath, dstBTSInstallPath);
                        element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").SetValue(physicalPath);

                    }
                    if (physicalPath.Contains(srcBTSInstallPath1))
                    {
                        physicalPath = physicalPath.Replace(srcBTSInstallPath1, dstBTSInstallPath);
                        element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").SetValue(physicalPath);

                    }
                    if (string.IsNullOrEmpty(strWebsitesFolder) || string.IsNullOrWhiteSpace(strWebsitesFolder))
                    {

                    }
                    else
                    {
                         physicalPath = element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").Value;
                        physicalPath = strWebsitesFolder + ":" + physicalPath.Split(':')[1];
                        element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").SetValue(physicalPath);
                    }
                }
                root.Save(xmlPath + "\\WebApps_" + pWebSiteName + "_ToImport.xml");
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception occured while genrating Delta of WebApps to be Imported, please check log file for details.");
                LogException(ex);
                throw (ex);
            }
        }

        private void UpdateWebSiteXml()
        {
            //split website xml into indivudual websites with new ID value for each website.
            string[] dstLines = System.IO.File.ReadAllLines(xmlPath + "\\DstWebSiteList.txt");
            int dstSiteCount = dstLines.Length; //get count of websites existing in Dst
            int i = 1;
            string srcBTSInstallPath = string.Empty;
            string srcDrive = string.Empty;
            string dstDrive = string.Empty;
            string srcBTSInstallPath1 = string.Empty;
            string dstBTSInstallPath = string.Empty;
            try
            {

                //Reading the Src BTSInstallPath
                if (File.Exists(xmlPath + "\\" + "SrcBTSInstallPath.txt"))
                {
                    string[] srcBTSInstall = System.IO.File.ReadAllLines(xmlPath + @"\srcBTSInstallPath.txt");

                    for (int j = 0; j < srcBTSInstall.Length; j++)
                    {
                        srcDrive = srcBTSInstall[j].Split('=')[1].Split(':')[0];
                        srcBTSInstallPath = srcDrive.ToLower() + ":" + srcBTSInstall[j].Split('=')[1].Split(':')[1];
                        srcBTSInstallPath1 = srcDrive.ToUpper() + ":" + srcBTSInstall[j].Split('=')[1].Split(':')[1];
                    }
                }

                //Reading the Dst BTSInstallPath
                if (File.Exists(xmlPath + "\\" + "DstBTSInstallPath.txt"))
                {
                    string[] dstBTSInstall = System.IO.File.ReadAllLines(xmlPath + @"\DstBTSInstallPath.txt");

                    for (int j = 0; j < dstBTSInstall.Length; j++)
                    {
                        dstDrive = dstBTSInstall[j].Split('=')[1].Split(':')[0];
                        dstBTSInstallPath = dstDrive.ToUpper() + ":" + dstBTSInstall[j].Split('=')[1].Split(':')[1];
                    }
                }

                XElement root = XElement.Load(xmlPath + "\\WebSites.xml");
                XNamespace ns = root.GetDefaultNamespace();

                var applicationList = from el in root.Elements(ns + "SITE").Elements(ns + "site").Elements(ns + "application")
                                      where !el.Attribute("path").Value.Equals("/")
                                      select el;
                if (applicationList != null)
                {
                    applicationList.Remove();
                }

                var result = from ele in root.Elements(ns + "SITE")
                             select ele;
              
                    foreach (var element in result)
                {
                    element.Attribute("SITE.ID").SetValue(dstSiteCount + i);
                    element.Element(ns + "site").Attribute("id").SetValue(dstSiteCount + i);
                    string physicalPath = element.Element(ns + "site").Element(ns + "application").Element(ns + "virtualDirectory").Attribute("physicalPath").Value;
                    if(physicalPath.Contains(srcBTSInstallPath))
                    {
                        physicalPath = physicalPath.Replace(srcBTSInstallPath, dstBTSInstallPath);
                        element.Element(ns + "site").Element(ns + "application").Element(ns + "virtualDirectory").Attribute("physicalPath").SetValue(physicalPath);

                    }
                    if (physicalPath.Contains(srcBTSInstallPath1))
                    {
                        physicalPath = physicalPath.Replace(srcBTSInstallPath1, dstBTSInstallPath);
                        element.Element(ns + "site").Element(ns + "application").Element(ns + "virtualDirectory").Attribute("physicalPath").SetValue(physicalPath);

                    }
                    if (string.IsNullOrEmpty(strWebsitesFolder) || string.IsNullOrWhiteSpace(strWebsitesFolder))
                    {

                    }
                    else
                    {
                        physicalPath = element.Element(ns + "site").Element(ns + "application").Element(ns + "virtualDirectory").Attribute("physicalPath").Value;
                        physicalPath = strWebsitesFolder.Trim().Substring(0,1) + ":" + physicalPath.Split(':')[1];
                        element.Element(ns + "site").Element(ns + "application").Element(ns + "virtualDirectory").Attribute("physicalPath").SetValue(physicalPath);
                    }
                    XElement rootAppCmd = new XElement("appcmd", element);
                    rootAppCmd.Save(xmlPath + "\\WebSite_" + element.Attribute("SITE.NAME").Value + "_ToImport.xml");
                    i++;
                }
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception occured while genrating Delta for WebSites to be Imported, please check log file for details.");
                LogException(ex);
                throw (ex);
            }
        }

        private void UpdateSrcWebSiteXml()
        {
            try
            {
                XElement root = XElement.Load(xmlPath + "\\WebSites.xml");
                XNamespace ns = root.GetDefaultNamespace();

                var applicationList = from el in root.Elements(ns + "SITE").Elements(ns + "site").Elements(ns + "application")
                                      where !el.Attribute("path").Value.Equals("/")
                                      select el;

                var result = from ele in root.Elements(ns + "SITE")
                             select ele;

                foreach (var element in result)
                {
                    XElement rootAppCmd = new XElement("appcmd", element);
                    rootAppCmd.Save(xmlPath + "\\WebSite_" + element.Attribute("SITE.NAME").Value + "_ToExport.xml");
                }
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception occured while genrating Delta for WebSites to be Imported, please check log file for details.");
                LogException(ex);
                throw (ex);
            }
        }
      

        private void UpdateAppXmlFile()
        {   //this is genrating two file one is DstAppList.txt and second one is AppsToImport.xml            
            //Get all App name from Dst BizTalk Mgmt DB
            SqlCommand sqlCmd = null;
            char[] chrSep = { ',' };
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = new SqlConnection("Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                sqlCmd.CommandText = "SELECT nvcName AS AppName FROM bts_application ORDER BY nvcName ASC;";

                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAd = new SqlDataAdapter(sqlCmd);

                sqlDataAd.Fill(ds);
                ds.Tables[0].TableName = "AppNames";

                //write all apps in txt file, one app each line.
                using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstAppList.txt", false))
                {
                    foreach (DataRow dRow in ds.Tables["AppNames"].Rows)
                    {
                        writer.WriteLine(dRow["AppName"].ToString());
                    }

                    string[] arrAppsToIgnore = bizTalkAppToIgnore.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string appToIgnore in arrAppsToIgnore)
                    {
                        string find = "AppName = '" + appToIgnore.Trim() + "'";
                        DataRow[] foundRows = ds.Tables["AppNames"].Select(find);
                        if (!(foundRows.Length > 0))
                            writer.WriteLine(appToIgnore.Trim());
                    }
                }

                //remove apps which already existing in destination
                XElement root = XElement.Load(xmlPath + "\\Apps.xml");
                XNamespace ns = root.GetDefaultNamespace();
                string[] lines = System.IO.File.ReadAllLines(xmlPath + @"\DstAppList.txt");
                foreach (var item in lines)
                {
                    var ActivityList = from el in root.Elements(ns + "BizTalkApplication")
                                       where el.Attribute("ApplicationName").Value.Equals(item)
                                       select el;

                    if (ActivityList != null)
                        ActivityList.Remove();
                }
                root.Save(xmlPath + "\\AppsToImport.xml");
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception occured while genrating Delta for Assembly list to be Imported, please check log file for details.");
                LogException(ex);
                throw (ex);
            }
            finally
            {

            }
        }

        private void UpdateAssemblyFile()
        {
            try
            {
                string[] srcBizTalkDllLines = System.IO.File.ReadAllLines(xmlPath + @"\SrcBizTalkAssemblyList.txt");
                     if (machineName == strDstNode) //local
                {
                      string asmPath1 = @"C:\Windows\Microsoft.NET\assembly\";
                      string asmPath2 = @"C:\Windows\assembly\GAC\";
                      string asmPath3 = @"C:\Windows\assembly\GAC_32\";
                      string asmPath4 = @"C:\Windows\assembly\GAC_64\";
                      string asmPath5 = @"C:\Windows\assembly\GAC_MSIL\";

                    //Creating DestinationBiztalk Assembly List
                    int dllCount = 0;
                    foreach (string srcBizTalkDll in srcBizTalkDllLines)
                    {
                        string biztalkDllName = srcBizTalkDll.Substring(0, srcBizTalkDll.LastIndexOf('_'));

                        string[] assemblyDll_1 = Directory.GetFiles(asmPath1, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                        string[] assemblyDll_2 = Directory.GetFiles(asmPath2, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                       string[] assemblyDll_3 = Directory.GetFiles(asmPath3, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                       string[] assemblyDll_4 = Directory.GetFiles(asmPath4, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                        string[] assemblyDll_5 = Directory.GetFiles(asmPath5, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                      dllCount = dllCount + assemblyDll_1.Length + assemblyDll_2.Length + assemblyDll_3.Length + assemblyDll_4.Length + assemblyDll_5.Length;
                    }
                    string[] dllDst = new string[dllCount];
                    int dllLength = 0;
                    foreach (string srcBizTalkDll in srcBizTalkDllLines)
                    {
                        string biztalkDllName = srcBizTalkDll.Substring(0, srcBizTalkDll.LastIndexOf('_'));
                                             
                        string[] assemblyDll_1 = Directory.GetFiles(asmPath1, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                        string[] assemblyDll_2 = Directory.GetFiles(asmPath2, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                        string[] assemblyDll_3 = Directory.GetFiles(asmPath3, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                        string[] assemblyDll_4 = Directory.GetFiles(asmPath4, biztalkDllName + "*.dll", SearchOption.AllDirectories);
                        string[] assemblyDll_5 = Directory.GetFiles(asmPath5, biztalkDllName + "*.dll", SearchOption.AllDirectories);

                        assemblyDll_1.CopyTo(dllDst, dllLength);
                        dllLength = dllLength + assemblyDll_1.Length;
                        assemblyDll_2.CopyTo(dllDst, dllLength);
                        dllLength = dllLength + assemblyDll_2.Length;
                        assemblyDll_3.CopyTo(dllDst, dllLength);
                        dllLength = dllLength + assemblyDll_3.Length;
                        assemblyDll_4.CopyTo(dllDst, dllLength);
                        dllLength = dllLength + assemblyDll_4.Length;
                        assemblyDll_5.CopyTo(dllDst, dllLength);
                        dllLength = dllLength + assemblyDll_5.Length;
                    }
                    dllDst = dllDst.Distinct().ToArray();
                    Array.Sort(dllDst);

                    //write custom dll paths in txt file
                    using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstBizTalkAssemblyList.txt", false))
                    {
                        foreach (string filePathDll in dllDst)
                        {
                            if (filePathDll != string.Empty)
                            {
                                string DllVer = AssemblyName.GetAssemblyName(filePathDll).Version.ToString();
                                writer.WriteLine(Path.GetFileNameWithoutExtension(filePathDll) + "_" + DllVer);
                            }

                        }
                    }
                }
                     else
                {
                    string appPathUnc = ConvertPathToUncPath(appPath);
                    string commandArguments = "/C " + "\"\"" + psExecPath + "\" \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + "  \"" +
                             remoteRootFolder + "\\" + remoteExeName + "\" " + "\"\\\\" + machineName + "\\" + appPathUnc + "\"" + " \"DstDllList\" \"";

                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments);    //genrate handler xml and save it back to local
                    if (returnCode == 0)
                    {
                        LogShortSuccessMsg("Success: Exported Destination Biztalk AssemblyList.");

                    }
                    else
                    {
                        LogShortErrorMsg("Failed: Exporting Destination Biztalk AssemblyList.");

                    }
                }
                string[] dstBiztalkDllLines = System.IO.File.ReadAllLines(xmlPath + @"\DstBizTalkAssemblyList.txt");

                foreach (string srcFilePath in srcBizTalkDllLines)
                {
                    if (Array.IndexOf(dstBiztalkDllLines, srcFilePath) > -1) //if same dll is part of custom DLL then empty that entry in list.                                                    
                        srcBizTalkDllLines[Array.IndexOf(srcBizTalkDllLines, srcFilePath)] = string.Empty;
                }
                using (StreamWriter writer = new StreamWriter(xmlPath + @"\BizTalkAssemblyToImport.txt", false))
                {
                    foreach (string filePathDll in srcBizTalkDllLines)
                    {
                        if (filePathDll != string.Empty)
                        {
                            //string CustomDllVer = AssemblyName.GetAssemblyName(filePathDll).Version.ToString();
                            writer.WriteLine(filePathDll);
                        }

                    }
                }

            }
            catch (Exception ex)
           {
               LogShortErrorMsg("Exception occured while genrating Delta for Assembly list to be Imported, please check log file for details.");
               LogException(ex);
                throw (ex);
          }
            }

        


        private void UpdateBamDefFile(string pBamDefXmlFilePath, string pActivityNameTxtFilePath)
        {
            try
            {
                XElement root = XElement.Load(pBamDefXmlFilePath);
                XNamespace ns = root.GetDefaultNamespace();
                string[] lines = System.IO.File.ReadAllLines(pActivityNameTxtFilePath);
                foreach (var item in lines)
                {
                    var ActivityList = from el in root.Elements(ns + "Activity")
                                       where el.Attribute("Name").Value.Equals(item)
                                       select el;

                    foreach (var Activity in ActivityList)
                    {
                        var viewList = from el in root.Elements(ns + "View").Elements(ns + "ActivityView")
                                       where el.Attribute("ActivityRef").Value.Equals(Activity.Attribute("ID").Value)
                                       select el.Parent;

                        foreach (var view in viewList)
                        {
                            var ViewRefList = from el in root.Elements(ns + "Alerts").Elements(ns + "ViewAlert").Elements(ns + "ViewRef")
                                              where el.Value.Equals(view.Attribute("ID").Value)
                                              select el;
                            if (ViewRefList != null)
                                ViewRefList.Ancestors(ns + "ViewAlert").Remove();
                            ///////////////////////////////////////////////////////////////
                            var activityViewList = from el in view.Elements(ns + "ActivityView")
                                                   select el;

                            foreach (var activityView in activityViewList)
                            {
                                var cubeList = from el in root.Elements(ns + "Cube")
                                               where el.Attribute("ActivityViewRef").Value.Equals(activityView.Attribute("ID").Value)
                                               select el;

                                if (cubeList != null)
                                {
                                    int i = cubeList.Count();
                                    cubeList.Remove();
                                }
                            }
                        }

                        if (viewList != null)
                            viewList.Remove();
                    }
                    if (ActivityList != null)
                        ActivityList.Remove();
                }
                root.Save(xmlPath + "\\BamDefToImport.xml");
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception occured while genrating Delta for BamDef to be Imported, please check log file for details.");
                LogException(ex);
                throw (ex);
            }
        }

        private void MSIAPP(Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol, Hashtable htApps)
        {
            foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
            {
                if (!bizTalkAppToIgnore.Contains(app.Name)) //if (!(app.Name == "RosettaNet" || app.Name == "BizTalk.System" || app.Name == "BizTalk Application 1" || app.Name == "Microsoft.Practices.ESB" || app.Name == "BizTalk EDI Application"))
                {
                    if (htApps.Contains(app.Name))
                    {
                        int i = Convert.ToInt32(htApps[app.Name]);
                        i++;
                        htApps[app.Name] = i;
                    }
                    else
                    {
                        htApps.Add(app.Name, 1);
                    }
                    if (app.References.Count > 1)
                        MSIAPP(app.References, htApps);
                }
            }
        }

        private int UpdateResourceSpecFile(string pAppName)
        {
            //this will remove certain resources from spec file like certificates, web directory, and binding as they will be installed seprately
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(msiPath + "\\" + pAppName + specFileExt);
                foreach (XmlNode resources in doc.DocumentElement.ChildNodes)
                {
                    int nodeCount = resources.ChildNodes.Count;
                    for (int iNode = 0; iNode < resources.ChildNodes.Count;)
                    {
                        if (resources.ChildNodes[iNode].Attributes["Type"].Value == "System.BizTalk:BizTalkBinding" || resources.ChildNodes[iNode].Attributes["Type"].Value == "System.BizTalk:Certificate" || resources.ChildNodes[iNode].Attributes["Type"].Value == "System.BizTalk:WebDirectory")
                        {
                            resources.ChildNodes[iNode].ParentNode.RemoveChild(resources.ChildNodes[iNode]);
                            iNode--;
                        }
                        iNode++;
                    }
                }
                doc.Save(msiPath + "\\" + pAppName + specFileExt);
                return 0;
            }
            catch (Exception ex)
            {
                LogException(ex);
                return 1;
            }

        }
        private void EnableControls(bool pTrueFalse)
        {
            if (strServerType == "App" && pTrueFalse == true) //App
            {
                panel12.Enabled = pTrueFalse;
                panel13.Enabled = pTrueFalse;
                btnExportOperations.Enabled = pTrueFalse;
                btnImportOperations.Enabled = pTrueFalse;
                txtConnectionString.Enabled = pTrueFalse;
                txtConnectionStringDst.Enabled = pTrueFalse;
                panel1.Enabled = pTrueFalse;
                panel2.Enabled = pTrueFalse;
                panel3.Enabled = pTrueFalse;
                panel6.Enabled = pTrueFalse;
                panel7.Enabled = pTrueFalse;
                panel11.Enabled = pTrueFalse;
                panel14.Enabled = pTrueFalse;
            }
            else if (strServerType == "App" && pTrueFalse == false) //App
            {
                panel4.Enabled = pTrueFalse;
                panel5.Enabled = pTrueFalse;
                panel8.Enabled = pTrueFalse;
                panel9.Enabled = pTrueFalse;
                panel10.Enabled = pTrueFalse;

            }
            else if (strServerType == "BizTalk")
            {
                panel12.Enabled = pTrueFalse;
                panel13.Enabled = pTrueFalse;
                btnExportOperations.Enabled = pTrueFalse;
                btnImportOperations.Enabled = pTrueFalse;
                txtConnectionString.Enabled = pTrueFalse;
                txtConnectionStringDst.Enabled = pTrueFalse;
                panel1.Enabled = pTrueFalse;
                panel2.Enabled = pTrueFalse;
                panel3.Enabled = pTrueFalse;
                panel4.Enabled = pTrueFalse;
                panel5.Enabled = pTrueFalse;
                panel6.Enabled = pTrueFalse;
                panel7.Enabled = pTrueFalse;
                panel9.Enabled = pTrueFalse;
                panel8.Enabled = pTrueFalse;
                panel10.Enabled = pTrueFalse;
                panel14.Enabled = pTrueFalse;
                panel4.Enabled = pTrueFalse;
                panel5.Enabled = pTrueFalse;
                panel8.Enabled = pTrueFalse;
                panel9.Enabled = pTrueFalse;
                panel10.Enabled = pTrueFalse;
                cmbBoxServerDst.Enabled = pTrueFalse;
                cmbBoxServerSrc.Enabled = pTrueFalse;
            }
        }

        private string ConvertPathToUncPath(string pFolderPath)
        {
            //this will convert normal local path to unc path
            try
            {
                string driveInfo = Path.GetPathRoot(pFolderPath);
                string driveLetter = driveInfo.Substring(0, 1);
                string pathWithoutDrive = pFolderPath.Substring(3, pFolderPath.Length - 3);

                return driveLetter + "$\\" + pathWithoutDrive;
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
            return "";
        }
        private void MoveWebAppFolders(string pFileName, string pWebSite)
        {
            string strSrc = "";
            string strDst = "";
            string commandArguments = "";
            string driveInfo = string.Empty;
            string driveLetter = string.Empty;
            string pathWithoutDrive = string.Empty, folderPath = string.Empty;
            string webAppConfigFilePath = pFileName;
            char[] chrSep = { ',' };
            string srcDriveLetter = string.Empty;
            string scrFileName = string.Empty;
            string webAppName = string.Empty;
            string srcPathWithoutDrive = string.Empty;
            string physicalPath = string.Empty;
       

            try
            {
                
                XPathDocument doc = new XPathDocument(webAppConfigFilePath);
                XPathNavigator nav = doc.CreateNavigator();

                // Compile a standard XPath expression
                XPathExpression expr;
                expr = nav.Compile("//@physicalPath");
                XPathNodeIterator iterator = nav.Select(expr);

                //string[] srcServer = lblServers.Text.Split(chrSep);
                if (strToolMode == "Migrate" && strExport == strPerformOperationNo)    // migration = yes, and import = yes
                {
                    if (pFileName.Contains("WebSite"))
                    {
                        // Reading the Path From Source.xml
                        scrFileName = pFileName.Substring(0, pFileName.LastIndexOf('_')) + "_ToExport.xml";
                        XElement webRoot = XElement.Load(scrFileName);
                        XNamespace ns = webRoot.GetDefaultNamespace();
                        var webResult = from ele in webRoot.Elements(ns + "SITE").Elements(ns + "site").Elements(ns + "application")
                                     select ele;
                        foreach (var element in webResult)
                        {
                            if (element.Attribute("path").Value == "/")
                            {

                                string srcFolderPath = element.Element("virtualDirectory").Attribute("physicalPath").Value;
                                string srcDriveInfo = Path.GetPathRoot(srcFolderPath);
                                srcDriveLetter = srcDriveInfo.Substring(0, 1);
                            }
                        }
                        //XPathDocument srcDoc = new XPathDocument(scrFileName);
                        //XPathNavigator srcNav = srcDoc.CreateNavigator();
                        //XPathExpression srcExpr;
                        //srcExpr = srcNav.Compile("//@physicalPath");
                        //XPathNodeIterator srciterator = srcNav.Select(srcExpr);
                        //while (srciterator.MoveNext())
                        //{
                        //    string srcFolderPath = srciterator.Current.InnerXml;
                        //    string srcDriveInfo = Path.GetPathRoot(srcFolderPath);
                        //    srcDriveLetter = srcDriveInfo.Substring(0, 1);
                        //}
                        LogInfo("Copying Virtual directories.");
                        while (iterator.MoveNext())
                        {
                            folderPath = iterator.Current.InnerXml;
                            driveInfo = Path.GetPathRoot(folderPath);
                            driveLetter = driveInfo.Substring(0, 1);
                            pathWithoutDrive = folderPath.Substring(3, folderPath.Length - 3);
                            strSrc = "\\\\" + strSrcNode + "\\" + srcDriveLetter + "$\\" + pathWithoutDrive;
                            strDst = "\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;

                            LogInfo("Copy started from: " + strSrc + " To " + strDst);

                            commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                            int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                            if (returnCode >= strRoboCopySuccessCode)
                                LogShortErrorMsg("Failed: Importing Virtual Directory.");
                        }
                        LogShortSuccessMsg("Success: Imported Virtual Directory.");
                    }
                    if (pFileName.Contains("WebApps"))
                    {
                        // Reading the Path From Source.xml
                        scrFileName = pFileName.Substring(0, pFileName.LastIndexOf('_')) + "_ToExport.xml";
                        List<string> webAppArray = new List<string>();
                        XElement root = XElement.Load(scrFileName);
                        XNamespace ns = root.GetDefaultNamespace();


                        var result = from ele in root.Elements(ns + "APP")
                                     select ele;
                        foreach (var element in result)
                        {
                            if (element.Attribute("path").Value != "/")
                            {

                                webAppName = element.Attribute("APP.NAME").Value;
                                physicalPath = element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").Value;
                                webAppArray.Add(webAppName + "_" + physicalPath);
                            }
                        }
                        XElement importRoot = XElement.Load(webAppConfigFilePath);
                        XNamespace importns = importRoot.GetDefaultNamespace();
                        result = from ele in importRoot.Elements(importns + "APP")
                                 select ele;
                        LogInfo("Copying Virtual directories.");
                        foreach (var element in result)
                        {
                            webAppName = element.Attribute("APP.NAME").Value;
                            foreach (string srcWebApp in webAppArray)
                            {
                                if (webAppName == srcWebApp.Split('_')[0])
                                {
                                    driveInfo = Path.GetPathRoot(srcWebApp.Split('_')[1]);
                                    srcDriveLetter = driveInfo.Substring(0, 1);

                                    srcPathWithoutDrive = srcWebApp.Split('_')[1].Substring(3, srcWebApp.Split('_')[1].Length - 3);

                                }
                            }
                            physicalPath = element.Element(ns + "application").Element("virtualDirectory").Attribute("physicalPath").Value;
                            driveInfo = Path.GetPathRoot(physicalPath);
                            driveLetter = driveInfo.Substring(0, 1);
                            pathWithoutDrive = physicalPath.Substring(3, physicalPath.Length - 3);
                            strSrc = "\\\\" + strSrcNode + "\\" + srcDriveLetter + "$\\" + pathWithoutDrive;
                            strDst = "\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;

                            LogInfo("Copy started from: " + strSrc + " To " + strDst);

                            commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                            int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                            if (returnCode >= strRoboCopySuccessCode)
                                LogShortErrorMsg("Failed: Importing Virtual Directory.");

                        }
                        LogShortSuccessMsg("Success: Imported Virtual Directory.");
                    }
                }

                if (strToolMode == "Backup" && strExport == strPerformOperationNo)    // migration = no, and import = yes
                {
                    LogInfo("Copying Virtual directories.");
                    while (iterator.MoveNext())
                    {
                        folderPath = iterator.Current.InnerXml;
                        driveInfo = Path.GetPathRoot(folderPath);
                        driveLetter = driveInfo.Substring(0, 1);
                        pathWithoutDrive = folderPath.Substring(3, folderPath.Length - 3);
                        strSrc = vDir + "\\" + pWebSite + "\\" + folderPath.Substring(folderPath.LastIndexOf('\\'));
                        strDst = "\\\\" + strDstNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;

                        LogInfo("Copy started from: " + strSrc + " To " + strDst);

                        commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                        int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                        if (returnCode >= strRoboCopySuccessCode)
                            LogShortErrorMsg("Failed: Importing Virtual Directory.");
                    }
                    LogShortSuccessMsg("Success: Imported Virtual Directory.");
                }

                if (strToolMode == "Backup" && strExport == strPerformOperationYes)    // staging = yes, and export = yes  
                {
                    LogInfo("Copying Virtual directories.");
                    while (iterator.MoveNext())
                    {
                        folderPath = iterator.Current.InnerXml;
                        driveInfo = Path.GetPathRoot(folderPath);
                        driveLetter = driveInfo.Substring(0, 1);
                        pathWithoutDrive = folderPath.Substring(3, folderPath.Length - 3);
                        strSrc = "\\\\" + strSrcNode + "\\" + driveLetter + "$\\" + pathWithoutDrive;
                        strDst = vDir + "\\" + pWebSite + "\\" + folderPath.Substring(folderPath.LastIndexOf('\\'));

                        LogInfo("Copy started from: " + strSrc + " To " + strDst);

                        commandArguments = @"/C robocopy /xc /xn /xo " + "\"" + strSrc + "\"" + " \"" + strDst + "\" " + "/E /COPYALL /R:1";
                        int returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                        if (returnCode >= strRoboCopySuccessCode)
                            LogShortErrorMsg("Failed: Exporting Virtual Directory.");
                    }
                    LogShortSuccessMsg("Success: Exported Virtual Directory to local.");
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }

        }

        private int ExecuteCmd(string cmdName, string cmdArg)
        {
            string commandArguments = cmdArg;
            int exitCode;
            Process p = new Process();
            try
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = cmdName;
                p.StartInfo.Arguments = commandArguments;
                p.StartInfo.RedirectStandardError = true;
                p.ErrorDataReceived += p_ErrorDataReceived;
                p.StartInfo.RedirectStandardOutput = true;
                p.OutputDataReceived += p_OutputDataReceived;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                //Write result
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();
                exitCode = p.ExitCode;
                p.Close();                
                //return strSuccess;
            }
            catch (Exception ex)
            {
                exitCode = 1;
                LogException(ex);
            }
            finally
            {
                p.Dispose();
            }

            return exitCode;
        }

        private void SaveSrcSqlConnection()
        {
            XmlWriter xmlWriterApps = null;
            Servers srv = null;
            XmlSerializer configSerializer = null;

            try
            {
                if (File.Exists(serverXmlPath))
                {
                    XmlTextReader xmlTxtRed = new XmlTextReader(serverXmlPath);
                    configSerializer = new XmlSerializer(typeof(Servers));
                    srv = (Servers)configSerializer.Deserialize(xmlTxtRed);
                    xmlTxtRed.Close();
                }
                else
                    srv = new Servers();

                srv.SrcSqlInstance = txtConnectionString.Text.Trim();
                string strNodes = "";
                for (int i = 0; i < cmbBoxServerSrc.Items.Count; i++)
                {
                    if (i > 0)
                        strNodes = strNodes + ",";

                    strNodes = strNodes + cmbBoxServerSrc.Items[i].ToString();
                }
                srv.SrcNodes = strNodes;

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                //Add lib namespace with empty prefix
                ns.Add("", "");

                XmlSerializer x = new System.Xml.Serialization.XmlSerializer(srv.GetType());
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;

                xmlWriterApps = XmlWriter.Create(serverXmlPath, xmlWriterSetting);
                x.Serialize(xmlWriterApps, srv, ns);
            }

            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while writing / reading server xml file.  " + ex.Message);

            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }
        }

        private void SaveDstSqlConnection()
        {
            XmlWriter xmlWriterApps = null;
            Servers srv = null;
            XmlSerializer configSerializer = null;

            try
            {
                if (File.Exists(serverXmlPath))
                {
                    XmlTextReader xmlTxtRed = new XmlTextReader(serverXmlPath);
                    configSerializer = new XmlSerializer(typeof(Servers));
                    srv = (Servers)configSerializer.Deserialize(xmlTxtRed);
                    xmlTxtRed.Close();
                    configSerializer = null;
                }
                else
                    srv = new Servers();

                srv.DstSqlInstance = txtConnectionStringDst.Text.Trim();
                string strNodes = "";
                for (int i = 0; i < cmbBoxServerDst.Items.Count; i++)
                {
                    if (i > 0)
                        strNodes = strNodes + ",";

                    strNodes = strNodes + cmbBoxServerDst.Items[i].ToString();
                }
                srv.DstNodes = strNodes;
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                //Add lib namespace with empty prefix
                ns.Add("", "");

                XmlSerializer x = new System.Xml.Serialization.XmlSerializer(srv.GetType());
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;

                xmlWriterApps = XmlWriter.Create(serverXmlPath, xmlWriterSetting);
                x.Serialize(xmlWriterApps, srv, ns);
                x = null;
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while writing / reading server xml file.  " + ex.Message);

            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }
        }

        private void SaveAppServers()
        {
            XmlWriter xmlWriterApps = null;
            Servers srv = null;
            XmlSerializer configSerializer = null;

            try
            {
                if (File.Exists(serverXmlPath))
                {
                    XmlTextReader xmlTxtRed = new XmlTextReader(serverXmlPath);
                    configSerializer = new XmlSerializer(typeof(Servers));
                    srv = (Servers)configSerializer.Deserialize(xmlTxtRed);
                    xmlTxtRed.Close();
                    configSerializer = null;
                }
                else
                    srv = new Servers();


                srv.DstAppNode = txtConnectionStringDst.Text.Trim();
                srv.SrcAppNode = txtConnectionString.Text.Trim();
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                //Add lib namespace with empty prefix
                ns.Add("", "");

                XmlSerializer x = new System.Xml.Serialization.XmlSerializer(srv.GetType());
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
                xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;

                xmlWriterApps = XmlWriter.Create(serverXmlPath, xmlWriterSetting);
                x.Serialize(xmlWriterApps, srv, ns);
                x = null;
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while writing / reading server xml file.  " + ex.Message);

            }
            finally
            {
                if (xmlWriterApps != null)
                    xmlWriterApps.Close();
            }
        }
        private void TstDstSqlConnection(bool pSaveConnectionInfo)
        {
            SqlDataReader sqlRed = null;

            try
            {
                if (strServerType == "BizTalk")
                {
                    if (txtConnectionStringDst.Text != "SQL INSTANCE" && txtConnectionStringDst.Text != "" && txtConnectionStringDst.Text != dstSqlInstance)
                    {
                        EnableControls(false);
                        cmbBoxServerDst.Items.Clear();
                        cmbBoxServerDst.Text = "";
                        LogInfo("Validating Sql Instance.");
                        SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                        sqlCon.Open();

                        SqlCommand sqlcmd = new SqlCommand("SELECT [Id],[Name] FROM [adm_Server]", sqlCon);
                        sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (sqlRed.Read())
                        {
                            cmbBoxServerDst.Items.Add(sqlRed.GetString(1).ToUpper());
                        }
                        cmbBoxServerDst.Visible = true;
                        LogShortSuccessMsg("Connection Verified.");

                        dstSqlInstance = txtConnectionStringDst.Text;
                        if (pSaveConnectionInfo)
                            SaveDstSqlConnection();
                    }
                    else
                    {
                        if (txtConnectionStringDst.Text == "SQL INSTANCE" || txtConnectionStringDst.Text == "")
                        {
                            dstSqlInstance = txtConnectionStringDst.Text;
                            cmbBoxServerDst.Items.Clear();
                            cmbBoxServerDst.Text = "";
                            SaveDstSqlConnection();
                        }
                    }

                    EnableControls(true);
                }
                else //App
                {
                    if (txtConnectionStringDst.Text != "SQL INSTANCE" && txtConnectionStringDst.Text != "" && txtConnectionStringDst.Text != "SERVER NAME")
                    {
                        SaveAppServers();
                        strDstNode = txtConnectionStringDst.Text.Trim();
                    }
                    else
                    {
                        strDstNode = string.Empty;
                        SaveAppServers();
                    }
                }

            }
            catch (Exception ex)
            {
                EnableControls(true);
                dstSqlInstance = txtConnectionStringDst.Text;
                cmbBoxServerDst.Items.Clear();
                cmbBoxServerDst.Text = "";
                LogShortErrorMsg(ex.Message);
            }
            finally
            {
                if (sqlRed != null)
                    sqlRed.Close();
            }
        }

        private void TstSrcSqlConnection(bool pSaveConnectionInfo)
        {
            string serverName = "";
            SqlDataReader sqlRed = null;

            try
            {
                if (strServerType == "BizTalk")//BizTalk
                {
                    if (txtConnectionString.Text != "SQL INSTANCE" && txtConnectionString.Text != "" && txtConnectionString.Text != srcSqlInstance)
                    {
                        EnableControls(false);
                        cmbBoxServerSrc.Items.Clear();
                        cmbBoxServerSrc.Text = "";

                        LogInfo("Validating Sql Instance.");
                        SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                        sqlCon.Open();

                        SqlCommand sqlcmd = new SqlCommand("SELECT [Id],[Name] FROM [adm_Server]", sqlCon);
                        sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (sqlRed.Read())
                        {
                            cmbBoxServerSrc.Items.Add(sqlRed.GetString(1).ToUpper());
                            if (serverName == "")
                                serverName = sqlRed.GetString(1).ToUpper();
                            else
                                serverName = serverName + "," + sqlRed.GetString(1).ToUpper();
                        }
                        cmbBoxServerSrc.Visible = true;
                        LogShortSuccessMsg("Connection Verified.");

                        srcSqlInstance = txtConnectionString.Text;
                        if (pSaveConnectionInfo)
                            SaveSrcSqlConnection();
                    }
                    else
                    {
                        srcSqlInstance = txtConnectionString.Text;
                        if (txtConnectionString.Text == "SQL INSTANCE" || txtConnectionString.Text == "")
                        {
                            cmbBoxServerSrc.Items.Clear();
                            cmbBoxServerSrc.Text = "";
                            SaveSrcSqlConnection();
                        }

                    }
                    EnableControls(true);
                }
                else //App
                {
                    if (txtConnectionString.Text != "SQL INSTANCE" && txtConnectionString.Text != "" && txtConnectionString.Text != "SERVER NAME")
                    {
                        SaveAppServers();
                        strSrcNode = txtConnectionString.Text.Trim();
                    }
                    else
                    {
                        strSrcNode = string.Empty;
                        SaveAppServers();
                    }
                }
            }
            catch (Exception ex)
            {
                EnableControls(true);
                srcSqlInstance = txtConnectionString.Text;
                cmbBoxServerSrc.Items.Clear();
                cmbBoxServerSrc.Text = "";
                LogShortErrorMsg(ex.Message);
            }
            finally
            {
                if (sqlRed != null)
                    sqlRed.Close();
            }
        }

        public void UpdateSettings()
        {
            string configPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(configPath, "MigrationTool.exe.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            remoteRootFolder = config.AppSettings.Settings["RemoteRootFolder"].Value;
            bizTalkAppToIgnore = config.AppSettings.Settings["BizTalkAppToIgnore"].Value;
            baseBizTalkAppCol = config.AppSettings.Settings["AppToRefer"].Value;
            strCertPass = config.AppSettings.Settings["CertPass"].Value;
            strFoldersToCopy = config.AppSettings.Settings["FoldersToCopy"].Value;
            strFoldersToCopyNoFiles = config.AppSettings.Settings["FoldersToCopyNoFiles"].Value;
            strCustomDllToInclude = config.AppSettings.Settings["CustomDllToInclude"].Value;
            strWindowsServiceToIgnore = config.AppSettings.Settings["WindowsServiceToIgnore"].Value;
            strWebsitesFolder = config.AppSettings.Settings["WebSitesDriveDestination"].Value;
            strFoldersDrive = config.AppSettings.Settings["FoldersDriveDestination"].Value;
            strServicesDrive = config.AppSettings.Settings["ServicesDriveDestination"].Value;

        }

        private void ExportBrePolicyVocabulary()
        {
            try
            {
                //Getting the List of Policies associated to Application
                SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                sqlCon.Open();
                string sqlQuery = "Select b.nvcName As ApplicationName,a.sdmType,a.luid,a.properties,a.files From adpl_sat AS a,bts_application AS b where a.sdmType='System.BizTalk:Rules' and b.nID= a.applicationId";
                SqlDataAdapter sqlDataAd = new SqlDataAdapter(sqlQuery, sqlCon);
                DataSet ds = new DataSet();
                sqlDataAd.Fill(ds);
                string[] arrBrePolicies = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    arrBrePolicies[i] = ds.Tables[0].Rows[i].ItemArray[2].ToString().Split('/')[1].ToString() + "." + ds.Tables[0].Rows[i].ItemArray[2].ToString().Split('/')[2].Split('.')[0].ToString() + "." + ds.Tables[0].Rows[i].ItemArray[2].ToString().Split('/')[2].Split('.')[1].ToString();
                }

                //Creating BRERuleEngineDb Connection
                SqlCommand sqlcmd = new SqlCommand("SELECT [RuleEngineDBServerName] FROM [adm_Group]", sqlCon);
                SqlDataReader sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (sqlRed.Read())
                {
                    srcBRESqlInstance = sqlRed.GetString(0);
                }
                //Creating Business RuleEngineDB COnnection
                SqlConnectionStringBuilder sqlBRE = new SqlConnectionStringBuilder("Server = " + srcBRESqlInstance + "; Initial Catalog = BizTalkRuleEngineDb; Integrated Security = SSPI");
                SqlRuleStore sqlRulesStore = new SqlRuleStore(sqlBRE.ConnectionString);
                RuleSetDeploymentDriver rulesetDepDriver = new RuleSetDeploymentDriver(sqlBRE.DataSource, "BizTalkRuleEngineDb");
                RuleSetInfoCollection rulesetinfos = sqlRulesStore.GetRuleSets(RuleStore.Filter.All);
                // Creating Folders to Export Polices and Vocabualries

                foreach (RuleSetInfo ruleSetInfo in rulesetinfos)
                {
                    string policy = String.Format("{0}.{1}.{2}", ruleSetInfo.Name, ruleSetInfo.MajorRevision, ruleSetInfo.MinorRevision);

                    if (arrBrePolicies.Contains(policy))
                    {
                        //Do Nothing as Polices will be Exported By MSI
                    }
                    else
                    {
                        try
                        {
                            try
                            {
                                //Exporting Policy
                                var policyName = String.Format("{0}{1}.{2}.{3}.xml", "Policy_", ruleSetInfo.Name, ruleSetInfo.MajorRevision, ruleSetInfo.MinorRevision);
                                rulesetDepDriver.ExportRuleSetToFileRuleStore(ruleSetInfo, brePath + "/" + policyName);
                                LogInfoInLogFile(ruleSetInfo.Name + "Policy Exported");
                            }
                            catch (Exception ex)
                            {
                                LogShortErrorMsg("Exception Occured while Exporting " + ruleSetInfo.Name + "please check log file for details.");
                                LogInfoSyncronously("Exception while Exporting Policy " + ex.Message);

                            }
                            //Exporting vocabularyAssocated to Policy

                            string vocabQuery = "select A.nRuleSetID,A.strName as policyName,B.nVocabularyID,C.nVocabularyID,C.strName as VocabularyName from re_ruleset(nolock) as A,re_ruleset_to_vocabulary_links As B,re_vocabulary As C where A.nRuleSetID = B.nReferingRuleset and B.nVocabularyID = C.nVocabularyID and C.strName not in('Predicates','Functions','Common Values','Common Sets') and A.strName = @strPolicyName";
                            SqlDataAdapter sqlVocabad = new SqlDataAdapter(vocabQuery, sqlBRE.ConnectionString);
                            sqlVocabad.SelectCommand.Parameters.AddWithValue("@strPolicyName", ruleSetInfo.Name);
                            DataSet dsVocab = new DataSet();
                            sqlVocabad.Fill(dsVocab);
                            VocabularyInfoCollection vocabularyInfos = sqlRulesStore.GetVocabularies(RuleStore.Filter.All);
                            foreach (DataRow dr in dsVocab.Tables[0].Rows)
                            {
                                string vocabularyName = dr["VocabularyName"].ToString();
                                foreach (VocabularyInfo vocabularyInfo in vocabularyInfos)
                                {
                                    try
                                    {
                                        if (vocabularyName == vocabularyInfo.Name)
                                        {
                                            var VocabularyName = String.Format("{0}{1}.{2}.{3}.xml", "Vocabualary_", vocabularyInfo.Name, vocabularyInfo.MajorRevision, vocabularyInfo.MinorRevision);
                                            rulesetDepDriver.ExportVocabularyToFileRuleStore(vocabularyInfo, brePath + "/" + VocabularyName);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        LogShortErrorMsg("Exception Occured while Exporting " + vocabularyInfo.Name + "please check log file for details.");
                                        LogInfoSyncronously("Exception while Exporting Vocabulary " + ex.Message);

                                    }

                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            LogShortErrorMsg("Exception occured while Exporting Policy or Vocabualry, please check log file for details.");
                            LogException(ex);
                            throw (ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Exception Occured while Exporting BREPolicyVocabulary");
                LogInfoSyncronously("Exception Occured while Exporting BREPolicyVocabulary " + ex.Message);
                throw ex;
            }

        }

        private void ImportBrePolicyVocabulary()
        {
            String[] files;
            try
            {
                SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand("SELECT [RuleEngineDBServerName] FROM [adm_Group]", sqlCon);
                SqlDataReader sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (sqlRed.Read())
                {
                    dstBRESqlInstance = sqlRed.GetString(0);
                }
                SqlConnectionStringBuilder sqlBRE = new SqlConnectionStringBuilder("Server = " + dstBRESqlInstance + "; Initial Catalog = BizTalkRuleEngineDb; Integrated Security = SSPI");
                SqlRuleStore sqlRulesStore = new SqlRuleStore(sqlBRE.ConnectionString);
                RuleSetDeploymentDriver rulesetDepDriver = new RuleSetDeploymentDriver(sqlBRE.DataSource, "BizTalkRuleEngineDb");
                RuleSetInfoCollection dstrulesetinfos = sqlRulesStore.GetRuleSets(RuleStore.Filter.All);
                VocabularyInfoCollection dstvocabularyInfos = sqlRulesStore.GetVocabularies(RuleStore.Filter.All);

                //Importing Vocabualries
                files = Directory.GetFiles(brePath, "Vocabualary*.xml");
                if (files.Length != 0)
                {
                    string[] vocabualrySet = new string[dstvocabularyInfos.Count];
                    int i = 0;
                    //Creating a Set of Vocabularies which are Present in DstSqlInstance
                    foreach (VocabularyInfo dstvocabularyInfo in dstvocabularyInfos)
                    {
                        vocabualrySet[i] = String.Format("{0}{1}.{2}.{3}.xml", "Vocabualary_", dstvocabularyInfo.Name, dstvocabularyInfo.MajorRevision, dstvocabularyInfo.MinorRevision);
                        i++;
                    }


                    foreach (string file in files)
                    {
                        string filename = Path.GetFileName(file);
                        if (vocabualrySet.Contains(filename))
                        {
                            LogInfoInLogFile(filename + " Already Published");
                        }
                        else
                        {
                            FileRuleStore fileRuleStore = new FileRuleStore(file);
                            VocabularyInfoCollection vocabularyInfoList = fileRuleStore.GetVocabularies(RuleStore.Filter.All);


                            foreach (VocabularyInfo vocabularyInfo in vocabularyInfoList)

                            {
                                //Checking Whether its Present in DstSQLInstance

                                try
                                {
                                    VocabularyInfo vi = new VocabularyInfo(vocabularyInfo.Name, vocabularyInfo.MajorRevision, vocabularyInfo.MinorRevision);
                                    Vocabulary oVoc = fileRuleStore.GetVocabulary(vi);
                                    sqlRulesStore.Add(oVoc, true);
                                    LogInfoInLogFile(filename + " Imported");
                                }
                                catch (Exception ex)
                                {
                                    LogShortErrorMsg("Failed:Importing " + filename);
                                    LogInfoSyncronously("Exception while Importing " + filename + ":" + ex.Message);

                                }

                            }
                        }

                    }
                }
                //Importing Policies
                files = Directory.GetFiles(brePath, "Policy*.xml");
                if (files.Length != 0)
                {
                    string[] policySet = new string[dstrulesetinfos.Count];
                    int i = 0;
                    //Creating Policies Present in DestSQLInstance
                    foreach (RuleSetInfo dstruleSetInfo in dstrulesetinfos)
                    {
                        policySet[i] = String.Format("{0}{1}.{2}.{3}.xml", "Policy_", dstruleSetInfo.Name, dstruleSetInfo.MajorRevision, dstruleSetInfo.MinorRevision);
                        i++;
                    }
                    foreach (string file in files)
                    {
                        string filename = Path.GetFileName(file);

                        if (policySet.Contains(filename))
                        {
                            LogInfoInLogFile(filename + " Already Published");
                        }
                        else
                        {
                            try
                            {
                                rulesetDepDriver.ImportAndPublishFileRuleStore(file);
                                LogInfoInLogFile(filename + " Imported");
                            }
                            catch (Exception ex)
                            {
                                LogShortErrorMsg("Failed:Importing  " + filename);
                                LogInfoSyncronously("Exception while Importing " + filename + ":" + ex.Message);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogShortErrorMsg("Failed:Importing BREPolicyVocabulary.");
                LogInfoSyncronously("Exception Occured while Importing BREPolicyVocabulary " + ex.Message);
                throw ex;
            }

        }

        private void ExportClientCertOnetOneMappings()
        {
            try
            {
                using (ServerManager serverManager = new ServerManager())
                {
                    foreach (Site site in serverManager.Sites)
                    {
                        try
                        {
                            Microsoft.Web.Administration.Configuration config = serverManager.GetApplicationHostConfiguration();
                            Microsoft.Web.Administration.ConfigurationSection iisClientCertificateMappingAuthenticationSection = config.GetSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", site.Name);
                            Microsoft.Web.Administration.ConfigurationElementCollection oneToOneMappingsCollection = iisClientCertificateMappingAuthenticationSection.GetCollection("oneToOneMappings");
                            //Checking whether OneToOneCertifcationMappings are Present
                            if (oneToOneMappingsCollection.Count == 0)
                            {
                                LogInfoInLogFile(site.Name + " Website:Does not Contain OneToOneCLientCertificateMappings");
                            }
                            else
                            {
                                using (XmlWriter writer = XmlWriter.Create(xmlPath + @"\" + site.Name + "_ClientCertMappings.xml"))
                                {
                                    writer.WriteStartElement("OneToOneMappings");
                                    foreach (var onetoone in oneToOneMappingsCollection)
                                    {
                                        writer.WriteStartElement("OneToOneMapping");
                                        writer.WriteElementString("enabled", onetoone.GetAttributeValue("enabled").ToString());
                                        writer.WriteElementString("userName", onetoone.GetAttributeValue("userName").ToString());
                                        writer.WriteElementString("password", Encrypt(onetoone.GetAttributeValue("password").ToString()));
                                        writer.WriteElementString("certificate", onetoone.GetAttributeValue("certificate").ToString());
                                        writer.WriteEndElement();

                                    }
                                    writer.WriteEndElement();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogShortErrorMsg("Exception Occured for " + site.Name + ": please check log file for details.");
                            LogInfoSyncronously("Exception while Exporting IISClientCertificateOneToOneMappings for " + site.Name + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Exporting IISClientCertificateOneToOneMappings  " + ex.Message);
                throw ex;
            }
        }

        private void ImportClientCertOnetOneMappings()
        {
            try
            {
                using (ServerManager serverManager = new ServerManager())
                {
                    foreach (Site site in serverManager.Sites)
                    {
                        try {
                            string websiteMappingFile = site.Name + "_ClientCertMappings.xml";
                            DirectoryInfo di = new DirectoryInfo(xmlPath);
                            FileInfo[] files = di.GetFiles(websiteMappingFile);
                            if (files.Length == 0)
                            {
                                LogInfoInLogFile(site + "_ClientCertMappings are not Present");
                            }
                            else
                            {
                                XmlDocument xmldoc = new XmlDocument();
                                FileStream fs = new FileStream(xmlPath + @"\" + websiteMappingFile, FileMode.Open, FileAccess.Read);
                                xmldoc.Load(fs);
                                XmlNodeList nodeList = xmldoc.DocumentElement.SelectNodes("/OneToOneMappings/OneToOneMapping");
                                foreach (XmlNode node in nodeList)
                                {
                                    Microsoft.Web.Administration.Configuration config = serverManager.GetApplicationHostConfiguration();

                                    Microsoft.Web.Administration.ConfigurationSection iisClientCertificateMappingAuthenticationSection = config.GetSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", site.Name);
                                    iisClientCertificateMappingAuthenticationSection["enabled"] = true;
                                    iisClientCertificateMappingAuthenticationSection["oneToOneCertificateMappingsEnabled"] = true;
                                    Microsoft.Web.Administration.ConfigurationElementCollection oneToOneMappingsCollection = iisClientCertificateMappingAuthenticationSection.GetCollection("oneToOneMappings");
                                    string[] certificatearray = new string[oneToOneMappingsCollection.Count];
                                    int i = 0;
                                    //Getting All the Certifcates which is already Present in Destination System
                                    if (oneToOneMappingsCollection.Count != 0)
                                    {
                                        foreach (var onetoone in oneToOneMappingsCollection)
                                        {

                                            certificatearray[i] = onetoone.GetAttributeValue("certificate").ToString();
                                            i++;
                                        }
                                    }
                                    if (certificatearray.Contains(node.SelectSingleNode("certificate").InnerText))
                                    {
                                        LogInfoInLogFile(node.SelectSingleNode("certificate").InnerText + " already Exsists in Website: " + site.Name);
                                    }
                                    else
                                    {
                                        Microsoft.Web.Administration.ConfigurationElement addElement = oneToOneMappingsCollection.CreateElement("add");
                                        addElement["enabled"] = Convert.ToBoolean(node.SelectSingleNode("enabled").InnerText);
                                        addElement["userName"] = node.SelectSingleNode("userName").InnerText;
                                        addElement["password"] = Decrypt(node.SelectSingleNode("password").InnerText);
                                        addElement["certificate"] = node.SelectSingleNode("certificate").InnerText;
                                        oneToOneMappingsCollection.Add(addElement);
                                        Microsoft.Web.Administration.ConfigurationSection accessSection = config.GetSection("system.webServer/security/access", site.Name);
                                        accessSection["sslFlags"] = @"Ssl, SslNegotiateCert";
                                        LogInfoInLogFile(node.SelectSingleNode("certificate").InnerText + " added in" + site.Name);
                                    }
                                }
                                serverManager.CommitChanges();
                                LogInfoInLogFile(site.Name + " OneToOneClientCert Mappings Completed");

                            }
                        }
                        catch (Exception ex)
                        {
                            LogShortErrorMsg("Exception Occured for " + site.Name + ": please check log file for details.");
                            LogInfoSyncronously("Exception while Importing IISClientCertificateOneToOneMappings for " + site.Name + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Importing IISClientCertificateOneToOneMappings  " + ex.Message);
                throw ex;
            }
        }

        private string Encrypt(string data)
        {
            try
            {
                byte[] keyArray;
                keyArray = (UTF8Encoding.UTF8.GetBytes("M!grat!onkey1234"));
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

                DES.Mode = CipherMode.ECB;
                DES.Key = keyArray;

                DES.Padding = PaddingMode.PKCS7;
                ICryptoTransform DESEncrypt = DES.CreateEncryptor();
                Byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(data);

                return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Encrypting Credentials  " + ex.Message);
                throw ex;
            }

        }

        private string Decrypt(string data)
        {
            try
            {
                byte[] keyArray;
                keyArray = (UTF8Encoding.UTF8.GetBytes("M!grat!onkey1234"));
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

                DES.Mode = CipherMode.ECB;
                DES.Key = keyArray;

                DES.Padding = PaddingMode.PKCS7;
                ICryptoTransform DESEncrypt = DES.CreateDecryptor();
                Byte[] Buffer = Convert.FromBase64String(data.Replace(" ", "+"));

                return Encoding.UTF8.GetString(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Decrypting Credentials " + ex.Message);
                throw ex;
            }

        }

        private void ExportHostMapSettings()
        {
            try
            {

                BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                // connection string to the BizTalk management database where the ports will be created
                btsExp.ConnectionString = "Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                HostCollection hosts = btsExp.Hosts;
                for (int i = 0; i < cmbBoxServerSrc.Items.Count; i++)
                {
                    using (XmlWriter writer = XmlWriter.Create(xmlPath + @"\" + "Src_" + cmbBoxServerSrc.Items[i].ToString() + "_HostMappings.xml"))
                    {
                        writer.WriteStartElement("SettingsMap");
                        writer.WriteStartElement("HostMappings");
                        foreach (Host host in hosts)
                        {
                            writer.WriteStartElement("SourceHost");
                            writer.WriteAttributeString("Name", host.Name);
                            writer.WriteElementString("DestinationHosts", host.Name);
                            writer.WriteEndElement();

                        }
                        writer.WriteEndElement();

                        //  Get all the HostInstances of the Destination Server

                        HostInstance.HostInstanceCollection dstHostInstancesColletion = HostInstance.GetInstances();
                        string[] hostInstancesArray = new string[dstHostInstancesColletion.Count];
            
                        int j = 0;
                        foreach (HostInstance ht in dstHostInstancesColletion)
                        {
                        
                            if (ht.Name.EndsWith(cmbBoxServerSrc.Items[i].ToString())|| ht.Name.EndsWith(cmbBoxServerSrc.Items[i].ToString().ToLower()))
                            {
                                hostInstancesArray[j] = ht.Name.Split(' ')[3].ToString();
                                j++;
                            }

                        }
                        hostInstancesArray = hostInstancesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                        
                        writer.WriteStartElement("HostInstanceMappings");
                        for (j = 0; j < hostInstancesArray.Length; j++)
                        {
                            writer.WriteStartElement("SourceHostInstance");
                            writer.WriteAttributeString("Name", hostInstancesArray[j] + ":" + cmbBoxServerSrc.Items[i].ToString());
                            writer.WriteElementString("DestinationHostInstances", hostInstancesArray[j] + ":" + "{ServerName}");
                            writer.WriteEndElement();

                        }
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                }
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Exporting Export HostMapping Settings  " + ex.Message);
                throw ex;
            }
        }

        private void ImportHostMapSettings()
        {

            try
            {
                LogInfo("Host Mappings: Creating Host Mappings.");
                XmlDocument xd = new XmlDocument();
                string[] srcservers = new string[] { };
                string[] dstservers = new string[] { };
                //Getting the List of Source Servers
                if (File.Exists(xmlPath + "\\" + "SrcServers.xml"))
                {
                    xd.Load(xmlPath + "\\" + "SrcServers.xml");
                    XmlNode srcnodeList = xd.DocumentElement.SelectSingleNode("/Servers");

                    string SrcServerList = srcnodeList.SelectSingleNode("SrcNodes").InnerText;
                    srcservers = SrcServerList.Split(',');
                }
                else
                {
                    throw new Exception("SrcServers xml file is not available.");
                }
                //Getting the List of DestinationServers
                xd.Load(xmlPath + "\\" + "Servers.xml");
                XmlNode dstnodeList = xd.DocumentElement.SelectSingleNode("/Servers");

                string dstServerList = dstnodeList.SelectSingleNode("DstNodes").InnerText;
                dstservers = dstServerList.Split(',');

                String[] files = Directory.GetFiles(xmlPath, "Src_*_HostMappings.xml");
                if (files.Length == 0)
                {
                    throw new Exception(" Source HostMapping xml file is not available.");
                }
                if (dstservers.Length == srcservers.Length)
                {
                    for (int i = 0; i < dstservers.Length; i++)
                    {
                        string srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[i] + "_HostMappings.xml";
                        string dstHostMappingFile = xmlPath + @"\" + "Dst_" + dstservers[i] + "_HostMappings.xml";
                        // instantiate new instance of Explorer OM
                        BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                        // connection string to the BizTalk management database where the ports will be created
                        btsExp.ConnectionString = "Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                        //Get the Hosts Present in  Destination
                        HostCollection dsthostCollection = btsExp.Hosts;
                        string[] hostArray = new string[dsthostCollection.Count];
                        int j = 0;
                        foreach (Host ht in dsthostCollection)
                        {
                            hostArray[j] = ht.Name;

                            j++;

                        }
                        //Get all the HostInstances of the Destination Server
                        HostInstance.HostInstanceCollection dstHostInstancesColletion = HostInstance.GetInstances();
                        string[] hostInstancesArray = new string[dstHostInstancesColletion.Count];
                        j = 0;
                        foreach (HostInstance ht in dstHostInstancesColletion)
                        {
                            if (ht.HostType == HostInstance.HostTypeValues.In_process && (ht.Name.EndsWith(dstservers[i])|| ht.Name.EndsWith(dstservers[i].ToLower())))
                            {
                                hostInstancesArray[j] = ht.Name.Split(' ')[3].ToString();
                                j++;
                            }
                        }
                        hostInstancesArray = hostInstancesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                        
                        XDocument doc = XDocument.Load(srcHostMappingFile);
                        //Removing SourceHost Which are Not Present in Destination
                        var hostName = from node in doc.Descendants("SourceHost")
                                       let attr = node.Attribute("Name")
                                       where attr != null && !(hostArray.Contains(attr.Value))
                                       select node;
                        hostName.ToList().ForEach(x => x.Remove());

                        //Removing SourceHostInstances Which are Not Present in DestinationHostInstances
                        var hostInstanceNameToRemove = from node in doc.Descendants("SourceHostInstance")
                                                       let attr = node.Attribute("Name")
                                                       where attr != null && !(hostInstancesArray.Contains(attr.Value.Split(':')[0].ToString()))
                                                       select node;
                        hostInstanceNameToRemove.ToList().ForEach(x => x.Remove());

                        //Updating Host Instances of Destination with ComputerName
                        var hostInstanceName = from node in doc.Descendants("SourceHostInstance")
                                               let attr = node.Attribute("Name")
                                               where attr != null && (hostInstancesArray.Contains(attr.Value.Split(':')[0].ToString()))
                                               select node;
                        foreach (XElement itemElement in hostInstanceName)
                        {
                            
                            itemElement.Element("DestinationHostInstances").Value = itemElement.Element("DestinationHostInstances").Value.Split(':')[0] + ":" + dstservers[i];
                        }
                        doc.Save(dstHostMappingFile);
                    }
                }
                if (dstservers.Length < srcservers.Length)
                {
                    for (int i = 0; i < dstservers.Length; i++)
                    {
                        string srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[i] + "_HostMappings.xml";
                        string dstHostMappingFile = xmlPath + @"\" + "Dst_" + dstservers[i] + "_HostMappings.xml";
                        // instantiate new instance of Explorer OM
                        BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                        // connection string to the BizTalk management database where the ports will be created
                        btsExp.ConnectionString = "Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                        //Get the Hosts Present in  Destination
                        HostCollection dsthostCollection = btsExp.Hosts;
                        string[] hostArray = new string[dsthostCollection.Count];
                        int j = 0;
                        foreach (Host ht in dsthostCollection)
                        {
                            hostArray[j] = ht.Name;

                            j++;

                        }

                        //Get all the HostInstances of the Destination Server

                        HostInstance.HostInstanceCollection dstHostInstancesColletion = HostInstance.GetInstances();
                        string[] hostInstancesArray = new string[dstHostInstancesColletion.Count];
                        j = 0;
                        foreach (HostInstance ht in dstHostInstancesColletion)
                        {
                            if (ht.HostType == HostInstance.HostTypeValues.In_process && (ht.Name.EndsWith(dstservers[i]) || ht.Name.EndsWith(dstservers[i].ToLower())))
                            {
                                hostInstancesArray[j] = ht.Name.Split(' ')[3].ToString();
                                j++;
                            }
                        }
                        hostInstancesArray = hostInstancesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                   
                        XDocument doc = XDocument.Load(srcHostMappingFile);
                        //Removing SourceHost Which are Not Present in Destination
                        var hostName = from node in doc.Descendants("SourceHost")
                                       let attr = node.Attribute("Name")
                                       where attr != null && !(hostArray.Contains(attr.Value))
                                       select node;
                        hostName.ToList().ForEach(x => x.Remove());

                        //Removing SourceHostInstances Which are Not Present in DestinationHostInstances
                        var hostInstanceNameToRemove = from node in doc.Descendants("SourceHostInstance")
                                                       let attr = node.Attribute("Name")
                                                       where attr != null && !(hostInstancesArray.Contains(attr.Value.Split(':')[0].ToString()))
                                                       select node;
                        hostInstanceNameToRemove.ToList().ForEach(x => x.Remove());

                        //Updating Host Instances of Destination wiht ComputerName
                        var hostInstanceName = from node in doc.Descendants("SourceHostInstance")
                                               let attr = node.Attribute("Name")
                                               where attr != null && (hostInstancesArray.Contains(attr.Value.Split(':')[0].ToString()))
                                               select node;
                        foreach (XElement itemElement in hostInstanceName)
                        {
                           
                            itemElement.Element("DestinationHostInstances").Value = itemElement.Element("DestinationHostInstances").Value.Split(':')[0] + ":" + dstservers[i];
                        }
                        doc.Save(dstHostMappingFile);
                    }
                }
                if (dstservers.Length > srcservers.Length)
                {
                    string  srcHostMappingFile = string.Empty;
                    for (int i = 0; i < dstservers.Length; i++)
                    {
                      if(i<srcservers.Length)
                         srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[i] + "_HostMappings.xml";
                      else
                            srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[0] + "_HostMappings.xml";
                        string dstHostMappingFile = xmlPath + @"\" + "Dst_" + dstservers[i] + "_HostMappings.xml";
                        // instantiate new instance of Explorer OM
                        BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                        // connection string to the BizTalk management database where the ports will be created
                        btsExp.ConnectionString = "Server=" + txtConnectionStringDst.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                        //Get the Hosts Present in  Destination
                        HostCollection dsthostCollection = btsExp.Hosts;
                        string[] hostArray = new string[dsthostCollection.Count];
                        int j = 0;
                        foreach (Host ht in dsthostCollection)
                        {
                            hostArray[j] = ht.Name;

                            j++;

                        }

                        //Get all the HostInstances of the Destination Server

                        HostInstance.HostInstanceCollection dstHostInstancesColletion = HostInstance.GetInstances();
                        string[] hostInstancesArray = new string[dstHostInstancesColletion.Count];
                        j = 0;
                        foreach (HostInstance ht in dstHostInstancesColletion)
                        {
                            if (ht.HostType == HostInstance.HostTypeValues.In_process && (ht.Name.EndsWith(dstservers[i]) || ht.Name.EndsWith(dstservers[i].ToLower())))
                            {
                                hostInstancesArray[j] = ht.Name.Split(' ')[3].ToString();
                                j++;
                            }
                        }
                        hostInstancesArray = hostInstancesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                        

                        
                        XDocument doc = XDocument.Load(srcHostMappingFile);
                        //Removing SourceHost Which are Not Present in Destination
                        var hostName = from node in doc.Descendants("SourceHost")
                                       let attr = node.Attribute("Name")
                                       where attr != null && !(hostArray.Contains(attr.Value))
                                       select node;
                        hostName.ToList().ForEach(x => x.Remove());

                        //Removing SourceHostInstances Which are Not Present in DestinationHostInstances
                        var hostInstanceNameToRemove = from node in doc.Descendants("SourceHostInstance")
                                                       let attr = node.Attribute("Name")
                                                       where attr != null && !(hostInstancesArray.Contains(attr.Value.Split(':')[0].ToString()))
                                                       select node;
                        hostInstanceNameToRemove.ToList().ForEach(x => x.Remove());

                        //Updating Host Instances of Destination wiht ComputerName
                        var hostInstanceName = from node in doc.Descendants("SourceHostInstance")
                                               let attr = node.Attribute("Name")
                                               where attr != null && (hostInstancesArray.Contains(attr.Value.Split(':')[0].ToString()))
                                               select node;
                        foreach (XElement itemElement in hostInstanceName)
                        {
                            
                            itemElement.Element("DestinationHostInstances").Value = itemElement.Element("DestinationHostInstances").Value.Split(':')[0] + ":" + dstservers[i];
                        }
                        doc.Save(dstHostMappingFile);
                    }
                }

                LogInfo("Host Mappings: Created Host Mappings.");
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Importing HostMapping Settings  " + ex.Message);
                LogException(ex);
                throw ex;
            }
        }

        private void ExportSSOApps()
        {
            //Creating List of SSO Apps
            string fileName = @"C:\Program Files\Common Files\Enterprise Single Sign-On\ssomanage.exe";
            string commandArguments = "";
            
            int returnCode; 
            try
            {
                if (machineName == strSrcNode)//local
                {
                    commandArguments = "/C " + "\"\"" + fileName + "\"" + " -listapps />\"" + xmlPath + "\\SrcSSOAppsList.txt" + "\"";
                }
                else
                {
                    string xmlPathUNC = ConvertPathToUncPath(xmlPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + " " + "\"" + fileName + "\"" + " -listapps />\"" + "\\\\" + machineName + "\\" + xmlPathUNC + "\\SrcSSOAppsList.txt" + "\"";
         
                }

                returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                if (returnCode == 0)
                {
                    LogShortSuccessMsg("Success: Exported SSO Affiliate Application List.");

                }
                else
                {
                    LogShortErrorMsg("Failed: Exporting SSO Affiliate Application List.");

                }
                if (File.Exists(xmlPath + "\\" + "SrcSSOAppsList.txt"))
                {
                    string[] SsoAppsList = System.IO.File.ReadAllLines(xmlPath + @"\SrcSSOAppsList.txt");
                    for (int i = 0; i < SsoAppsList.Length; i++)
                    {
                        if ((string.IsNullOrEmpty(SsoAppsList[i]) || string.IsNullOrWhiteSpace(SsoAppsList[i]) || SsoAppsList[i].Contains("Using SSO server") || SsoAppsList[i].Contains("Applications available for") || SsoAppsList[i].Contains("applications available for")))

                        {
                        }
                        else
                        {

                            try
                            {
                                string SsoApp = SsoAppsList[i].Split(':')[0].Split(')')[1].Trim();
                                //DisplayInforMation of SSOApp

                                if (machineName == strSrcNode)//local
                                {
                                    commandArguments = "/C " + "\"\"" + fileName + "\"" + " -displayapp " + SsoApp + " />\"" + xmlPath + "\\SSOApp_" + SsoApp + ".txt" + "\"";

                                }
                                else
                                {
                                    string xmlPathUNC = ConvertPathToUncPath(xmlPath);
                                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + fileName + "\"" + " -displayapp " + SsoApp + " />\"" + "\\\\" + machineName + "\\" + xmlPathUNC + "\\SSOApp_" + SsoApp + ".txt" + "\"";

                                }

                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                                if (returnCode == 0)
                                {
                                    LogShortSuccessMsg("Success: Exported " + SsoApp + " Affiliate Application Information.");

                                }
                                else
                                {
                                    LogShortErrorMsg("Failed: Exporting " + SsoApp + " Affiliate Application Information.");
                                }
                                //ListMappings
                                if (machineName == strSrcNode)//local
                                {
                                    commandArguments = "/C " + "\"\"" + fileName + "\"" + " -listMappings " + SsoApp + " />\"" + xmlPath + "\\SSOMap_" + SsoApp + ".txt" + "\"";

                                }
                                else
                                {
                                    string xmlPathUNC = ConvertPathToUncPath(xmlPath);
                                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strSrcNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\""  + fileName + "\"" + " -accepteula" + " -listMappings " + SsoApp + " />\"" + "\\\\" + machineName + "\\" + xmlPathUNC + "\\SSOMap_" + SsoApp + ".txt" + "\"";

                                }

                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);
                                if (returnCode == 0)
                                {
                                    LogShortSuccessMsg("Success: Exported " + SsoApp + " Mapping File.");

                                }
                                else
                                {
                                    LogShortErrorMsg("Failed: Exporting " + SsoApp + " Mapping File.");
                                }
                                //
                            }
                            catch (Exception ex)
                            {
                                LogInfoSyncronously("Exception while Exporting SSO Affiliate Application " + ex.Message);
                                LogException(ex);
                            }
                        }

                    }
                }
                else
                {
                    throw new Exception("SSO Affiliate Application List is not Present");
                }

               
                string[] files = Directory.GetFiles(xmlPath, "SSOApp_*.txt");
                if (files.Length == 0)
                {
                    throw new Exception("SSO Information Files are not Present");
                }
                else
                {
                  
                  
                    for (int i = 0; i < files.Length; i++)
                    {
                        try
                        {
                            string[] ssoAppInformation = System.IO.File.ReadAllLines(files[i]);
                            //Extarcting Inofrmation from TextFile
                            string applicationName = string.Empty;
                            string applicationType = string.Empty;
                            string description = string.Empty;
                            string contactInfo = string.Empty;
                            string applciationUsersAccount = string.Empty;
                            string applciationAdministrators = string.Empty;
                            string ticketTimeOut = string.Empty;
                            string userID = string.Empty;
                            string password = string.Empty;
                            string groupApp = string.Empty;
                            string applicationEnabled = string.Empty;
                            string allowLocalAccounts = string.Empty;
                            string adminAccountSame = string.Empty;
                            string allowWindowsInitatedSSO = string.Empty;
                            string disableCredentialCache = string.Empty;
                            string ticketsAllowed = string.Empty;
                            string allowhostInitatedSSO = string.Empty;
                            string directPasswordSync = string.Empty;
                            string windowsCredentials = string.Empty;
                            string applicationUsersMappings = string.Empty;
                            string validateTickets = string.Empty;
                            string timeoutTickets = string.Empty;

                            foreach (string line in ssoAppInformation)
                            {
                                if (line.Contains("Application name"))
                                    applicationName = line.Split(':')[1].Trim();
                                if (line.Contains("Description"))
                                    description = line.Split(':')[1].Trim();
                                if (line.Contains("Application Users account"))
                                    applciationUsersAccount = line.Split(':')[1].Trim();
                                if (line.Contains("Application Administrators accou"))
                                    applciationAdministrators = line.Split(':')[1].Trim();
                                if (line.Contains("Contact info"))
                                    contactInfo = line.Split(':')[1].Trim();
                                if(line.Contains("Ticket timeout (in minutes)"))
                                    ticketTimeOut= line.Split(':')[1].Trim();
                                if (line.Contains("User Id"))
                                {
                                    if (line.Split(':')[1].Trim() == "(Not Masked)")
                                        userID = "no";
                                    else
                                        userID = "yes";
                                }
                                if (line.Contains("Password"))
                                {
                                    if (line.Split(':')[1].Trim() == "(Not Masked)")
                                        password = "no";
                                    else
                                        password = "yes";
                                }
                                if(line.Contains("Application type"))
                                {
                                    if (line.Split(':')[1].Trim() == "Group")
                                        groupApp = "yes";
                                    else
                                        groupApp = "no";

                                }
                                if (line.Contains("Application enabled"))
                                    applicationEnabled = line.Split(':')[1].Trim();

                                if (line.Contains("Allow local accounts"))
                                    allowLocalAccounts = line.Split(':')[1].Trim();
                                if (line.Contains("Admin account same"))
                                    adminAccountSame = line.Split(':')[1].Trim();
                                if (line.Contains("tickets allowed"))
                                    ticketsAllowed = line.Split(':')[1].Trim();
                                if(line.Contains("validate tickets"))
                                    validateTickets= line.Split(':')[1].Trim();
                                if (line.Contains("timeout tickets"))
                                    timeoutTickets = line.Split(':')[1].Trim();


                            }

                            string AppName = Path.GetFileNameWithoutExtension(files[i]).Split('_')[1];
                            //create SQL COnnection
                            SqlConnection sqlCon = new SqlConnection("Server=" + txtConnectionString.Text.Trim() + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
                            sqlCon.Open();
                            SqlCommand sqlcmd = new SqlCommand("select distinct(ServerName) from [dbo].[adm_OtherDatabases] where DefaultDatabaseName = 'SSO' and ServerName not like '%.com%'", sqlCon);
                            SqlDataReader sqlRed = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                            string srcSSOSqlInstance = string.Empty;
                            while (sqlRed.Read())
                            {
                                srcSSOSqlInstance = sqlRed.GetString(0);
                            }
                            SqlCommand sqlCmd = new SqlCommand();
                            sqlCmd.Connection = new SqlConnection("Server=" + srcSSOSqlInstance + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");

                            sqlCmd.CommandText = "SELECT  [ai_app_name],[ai_description],[ai_contact_info],[ai_user_group_name],[ai_admin_group_name],[ai_flags],[ai_num_fields],[ai_purge_id],[ai_audit_id],[ai_ticket_timeout] FROM [SSODB].[dbo].[SSOX_ApplicationInfo] where [ai_app_name] ='" + AppName + "'"; 
                            DataSet ds = new DataSet();
                            SqlDataAdapter sqlDataAd = new SqlDataAdapter(sqlCmd);

                            sqlDataAd.Fill(ds);
                     
                            using (XmlWriter writer = XmlWriter.Create(xmlPath + @"\" + "SSOApp_" + AppName +"_ToImport" + ".xml"))
                            {
                                writer.WriteStartElement("SSO");
                                writer.WriteStartElement("application");
                                writer.WriteAttributeString("name", applicationName);
                                writer.WriteElementString("description", ds.Tables[0].Rows[0].ItemArray[1].ToString());
                                writer.WriteElementString("Contact", ds.Tables[0].Rows[0].ItemArray[2].ToString());
                                writer.WriteElementString("appUserAccount", ds.Tables[0].Rows[0].ItemArray[3].ToString());
                                writer.WriteElementString("appAdminAccount", ds.Tables[0].Rows[0].ItemArray[4].ToString());
                              //  writer.WriteElementString("ticketTimeout", ticketTimeOut);
                                writer.WriteStartElement("field");
                                writer.WriteAttributeString("ordinal", "0");
                                writer.WriteAttributeString("label", "User Id");
                                writer.WriteAttributeString("masked", userID);
                                writer.WriteEndElement();
                                writer.WriteStartElement("field");
                                writer.WriteAttributeString("ordinal", "1");
                                writer.WriteAttributeString("label", "Password");
                                writer.WriteAttributeString("masked", password);
                                writer.WriteEndElement();
                                writer.WriteStartElement("flags");
                                writer.WriteAttributeString("groupApp", groupApp);
                                writer.WriteAttributeString("adminAccountSame", adminAccountSame.ToLower());
                                writer.WriteAttributeString("allowLocalAccounts", allowLocalAccounts.ToLower());
                                writer.WriteAttributeString("enableApp", applicationEnabled.ToLower());
                                writer.WriteAttributeString("allowTickets", ticketsAllowed.ToLower());
                                if (validateTickets != string.Empty)
                                    writer.WriteAttributeString("validateTickets", validateTickets.ToLower());
                                if (timeoutTickets != string.Empty)
                                    writer.WriteAttributeString("timeoutTickets", timeoutTickets.ToLower());
                                writer.WriteEndElement();
                                writer.WriteEndElement();
                                writer.WriteEndElement();
                            }


                        }
                        catch (Exception ex)
                        {
                            LogInfoSyncronously("Exception while Exporting SSO XMl: " + files[i] + ex.Message);
                            LogException(ex);
                        }

                    }
                    LogShortSuccessMsg("Success: Exported SSO Affiliate Apps Xmls");

                }
                files = Directory.GetFiles(xmlPath, "SSOMap_*.txt");
                if (files.Length == 0)
                {
                    throw new Exception("SSO Mapping Files are not Present");
                }
                else
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        string[] ssoMappingList = System.IO.File.ReadAllLines(files[i]);
                        List<string> ssoMapping = new List<string>();
                        try
                        {
                            for (int j = 0; j < ssoMappingList.Length; j++)
                            {
                                if ((string.IsNullOrEmpty(ssoMappingList[j]) || string.IsNullOrWhiteSpace(ssoMappingList[j]) || ssoMappingList[j].Contains("Using SSO server") || ssoMappingList[j].Contains("Existing mappings for application") || ssoMappingList[j].Contains("existing mappings for application")))

                                {

                                }
                                else
                                {
                                    ssoMapping.Add(ssoMappingList[j]);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogInfoSyncronously("Exception while Reading  SSO Mapping File : " + files[i] + ex.Message);
                            LogException(ex);
                        }
                        if (ssoMapping.Count > 0)
                        {
                            //Creating SSO Mapping FIle
                            string appName = Path.GetFileNameWithoutExtension(files[i]).Split('_')[1];
                            using (XmlWriter writer = XmlWriter.Create(xmlPath + @"\" + "SSOMap_" + appName +"_ToImport" + ".xml"))
                            {
                                writer.WriteStartElement("SSO");
                                foreach (string mapping in ssoMapping)
                                {
                                    try
                                    {
                                        writer.WriteStartElement("mapping");
                                        writer.WriteElementString("windowsDomain", mapping.Split(':')[0].Split(')')[1].Split('\\')[0].Trim());
                                        writer.WriteElementString("windowsUserId", mapping.Split(':')[0].Split(')')[1].Split('\\')[1].Trim());
                                        writer.WriteElementString("externalApplication", appName);
                                        writer.WriteElementString("externalUserId", mapping.Split(':')[1].Trim());
                                        writer.WriteEndElement();
                                    }
                                    catch (Exception ex)
                                    {
                                        LogInfoSyncronously("Exception while Writing into  SSO Mapping File : " + files[i] + ex.Message);
                                        LogException(ex);
                                    }
                                }
                                writer.WriteEndElement();
                            }
                        }

                        else
                        {
                            LogInfo("No Mappings are present for  " + files[i]);
                        }
                    }
                    LogShortSuccessMsg("Success: Exported SSO Mapping Xmls");
                }
            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Exporting SSO Affiliate Application " + ex.Message);
                LogException(ex);
                throw ex;
            }

        }

        private void ImportSSOApps()
        {
            string fileName = @"C:\Program Files\Common Files\Enterprise Single Sign-On\ssomanage.exe";
            string commandArguments = "";
            int returnCode;
            //Creating the DestinationAppList
            try
            {
                if (machineName == strDstNode)//local
                {
                    commandArguments = "/C " + "\"\"" + fileName + "\"" + " -listapps />\"" + xmlPath + "\\DstSSOAppsList.txt" + "\"";
                }
                else
                {
                    string xmlPathUNC = ConvertPathToUncPath(xmlPath);
                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + fileName + "\"" + " -listapps />\"" + "\\\\" + machineName + "\\" + xmlPathUNC + "\\DstSSOAppsList.txt" + "\"";

                }

                returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                if (returnCode == 0)
                {
                    LogShortSuccessMsg("Success: Created Destination SSO Affiliate Application List.");

                }
                else
                {
                    LogShortErrorMsg("Failed: Created Destination SSO Affiliate Application List.");

                }
                List<string> dstSsoApps = new List<string>();
                if (File.Exists(xmlPath + "\\" + "DstSSOAppsList.txt"))
                {
                    string[] dstSsoAppsList = System.IO.File.ReadAllLines(xmlPath + @"\DstSSOAppsList.txt");
                    
                    for (int i = 0; i < dstSsoAppsList.Length; i++)
                    {
                        if ((string.IsNullOrEmpty(dstSsoAppsList[i]) || string.IsNullOrWhiteSpace(dstSsoAppsList[i]) || dstSsoAppsList[i].Contains("Using SSO server") || dstSsoAppsList[i].Contains("Applications available for") || dstSsoAppsList[i].Contains("applications available for")))

                        {
                        }
                        else
                        {
                            dstSsoApps.Add(dstSsoAppsList[i].Split(':')[0].Split(')')[1].Trim());
                            
                        }
                    }
                }
              string[]  files = Directory.GetFiles(xmlPath, "SSOApp_*.xml");
                if (files.Length>0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        string appName = Path.GetFileNameWithoutExtension(files[i]).Split('_')[1].Split('_')[0];
                        try
                        {
                            if (dstSsoApps.Contains(appName))
                            {
                                LogInfoInLogFile(appName + " is already present");
                            }
                            else
                            {
                                //Import the App and Mappings associated to App

                                if (machineName == strDstNode)//local
                                {
                                    commandArguments = "/C " + "\"\"" + fileName + "\"" + " -createapps \"" + files[i] + "\"";
                                }
                                else
                                {
                                    string filePathUnc = ConvertPathToUncPath(files[i]);
                                    commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + fileName + "\"" + " -createapps \"" + "\\\\" + machineName + "\\" + filePathUnc + "\"";

                                }
                                returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                                if (returnCode == 0)
                                {
                                    LogInfoInLogFile("Success: Created Destination SSO Affiliate Application:"+appName);

                                }
                                else
                                {
                                    LogInfoInLogFile("Failed: Created Destination SSO Affiliate Application List:"+appName);

                                }

                                string[] mappingFiles = Directory.GetFiles(xmlPath, "SSOMap_" + appName + "_ToImport" + ".xml");
                                foreach (string mappingFile in mappingFiles)
                                {
                                    if (machineName == strDstNode)//local
                                    {
                                        commandArguments = "/C " + "\"\"" + fileName + "\"" + " -createmappings \"" + mappingFile + "\"";
                                    }
                                    else
                                    {
                                        string mappingFileUNC = ConvertPathToUncPath(mappingFile);
                                        commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + fileName + "\"" + " -createMappings />\"" + "\\\\" + machineName + "\\" + mappingFileUNC + "\"";

                                    }
                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                                    if (returnCode == 0)
                                    {
                                        LogInfoInLogFile("Success: Created Destination SSO Affiliate Application Mappings:" + mappingFile);

                                    }
                                    else
                                    {
                                        LogInfoInLogFile("Failed: Created Destination SSO Affiliate Application List:" + mappingFile);

                                    }
                                    //Enabling the Mapping
                                    XmlDocument xmldoc = new XmlDocument();
                                    FileStream fs = new FileStream(mappingFile, FileMode.Open, FileAccess.Read);
                                    xmldoc.Load(fs);
                                    XmlNodeList nodeList = xmldoc.DocumentElement.SelectNodes("/SSO/mapping");

                                    foreach (XmlNode node in nodeList)
                                    {
                                        string windowsAccount = node.SelectSingleNode("windowsDomain").InnerText + "\\" + node.SelectSingleNode("windowsUserId").InnerText;
                                        try
                                        {
                                            if (machineName == strDstNode)//local
                                            {
                                                commandArguments = "/C " + "\"\"" + fileName + "\"" + " -enablemapping \"" + windowsAccount + "\"" +" " +"\""+ appName +"\"";
                                            }
                                            else
                                            {
                                                string xmlPathUNC = ConvertPathToUncPath(xmlPath);
                                                commandArguments = "/C " + "\"\"" + psExecPath + "\"  \\\\" + strDstNode + " -u " + "\"" + strUserName + "\"" + " -p " + "\"" + strPassword + "\"" + " -accepteula" + fileName + "\"" + " -enablemapping \"" + windowsAccount + "\"" + appName + "\"";

                                            }
                                            returnCode = ExecuteCmd("CMD.EXE", commandArguments);

                                            if (returnCode == 0)
                                            {
                                                LogInfoInLogFile("Success: Enabled SSO Affiliate Application Mappings:" + mappingFile);

                                            }
                                            else
                                            {
                                                LogInfoInLogFile("Failed: Enabled SSO Affiliate Application List:" + mappingFile);

                                            }
                                        }
                                        catch(Exception ex)
                                        {
                                            LogInfoSyncronously("Exception while Enabling SSO Affiliate Application Mapping " + appName + " :" + ex.Message);
                                            LogException(ex);
                                        }
                                    }

                                }
                                LogShortSuccessMsg("Success: Created Destination SSO Affiliate Applications and Mappings.");
                            }

                        }
                        catch(Exception ex)
                        {
                            LogInfoSyncronously("Exception while Importing SSO Affiliate Application " + appName+" :" + ex.Message);
                            LogException(ex);
                        }

                    }
                }
                else
                {
                    throw new Exception("No SSO Information Files are present");
                }

            }
            catch (Exception ex)
            {
                LogInfoSyncronously("Exception while Impoting SSO Affiliate Applications " + ex.Message);
                LogException(ex);
                throw ex;
            }
        }

            #endregion

        }
}
