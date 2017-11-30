using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.BizTalk.ExplorerOM;
using System.Reflection;
using System.Security.Principal;
using System.Management;
using System.Data.SqlClient;
using System.Data;
using Microsoft.RuleEngine;
using Microsoft.Web.Administration;
using System.Security.Cryptography;
using System.Xml.Linq;
using Microsoft.BizTalk.Management;

namespace RemoteOperations
{
   
    class Program
    {
        
        static int Main(string[] args)
        {
            //args 0 : rootPAth --- place of invocation, path of directroy from where this exe invoked
            //args 1 : operation --- ExportCert, ImportCert, ExportDll
            //args 2 : target machine Export Folder

            string rootPath = args[0].ToString();
            string appPath;
            string certPath;
            
            try
            {
                appPath = rootPath;
               
                certPath = appPath + @"\CERT";
                RemoteExportImportFunctions expo = new RemoteExportImportFunctions();

                if (args[1].ToString() == "ExportCert")
                {
                    if (!Directory.Exists(appPath + "\\Logs"))
                    {
                        //recreate
                        Directory.CreateDirectory(appPath + "\\Logs");
                        expo.LogInfo("Created log folder", rootPath);
                    }

                    if (!Directory.Exists(certPath))
                    {   //recreate                                            
                        Directory.CreateDirectory(certPath);
                        expo.LogInfo("Created cert folder", rootPath);
                    }
                    
                    expo.btnExportCert_Click(rootPath, args[2].ToString());
                }

                if (args[1].ToString() == "ImportCert")
                {
                    if (!Directory.Exists(appPath + "\\Logs"))
                    {
                        //recreate
                        Directory.CreateDirectory(appPath + "\\Logs");
                        expo.LogInfo("Created log folder", rootPath);
                    }

                    if (!Directory.Exists(certPath))
                    {   //recreate                                            
                        Directory.CreateDirectory(certPath);
                        expo.LogInfo("Created cert folder", rootPath);
                    }
                    
                    expo.btnImportCert_Click(rootPath, args[2].ToString());
                }

                if (args[1].ToString() == "ExportDll")
                {
                    string pDLLPath = args[2].ToString();
                    string strCustomDllFilter = args[3].ToString();
                    string strCustomDllPath = args[4].ToString();
                    expo.btnExportAssemblies_Click(rootPath, pDLLPath, strCustomDllFilter, strCustomDllPath, args[5].ToString());
                }

                //0 unc path, 1 Operation Name , 2 SqlInstance
                if (args[1].ToString() == "ExportHandler")
                {
                    string sqlInstance = args[2].ToString();
                    expo.btnExportAdapterHandlers_Click(rootPath, sqlInstance);
                }

                //0 unc path, 1 Operation Name , 2 SqlInstance
                if (args[1].ToString() == "ExportAsmList")
                {
                    string sqlInstance = args[2].ToString();
                    string appNameCollection = args[3].ToString();
                    expo.btnGetAssembliesList_Click(rootPath, sqlInstance, appNameCollection);
                }

                //0 unc path, 1 Operation Name , 2 SqlInstance
                if (args[1].ToString() == "ExportAppList")
                {
                    string sqlInstance = args[2].ToString();
                    string bizTalkAppToIgnore = args[3].ToString();
                    expo.btnGetApplicationList_Click(rootPath, sqlInstance, bizTalkAppToIgnore);
                }


                if (args[1].ToString() == "DstCustomDllList")
                {
                    string customDllFilter = args[2].ToString();
                    expo.btnDstCustomDllList_Click(rootPath, customDllFilter);
                }
                if (args[1].ToString() == "DstDllList")
                {
                    
                    expo.btnDstDllList_Click(rootPath);
                }


                if (args[1].ToString() == "SrcServiceList" || args[1].ToString() == "DstServiceList")
                {
                    string userNameNoDomain = args[3].ToString();
                    string windowsServiceToIgnore = args[2].ToString();
                    string fileName = args[1].ToString();
                    expo.btnGetServices_Click(rootPath, windowsServiceToIgnore, userNameNoDomain, fileName);
                }
                if (args[1].ToString() == "ExportBREList")
                {
                    string sqlInstance = args[2].ToString();
                    expo.ExportBrePolicyVocabulary(rootPath, sqlInstance);
                }
                if (args[1].ToString() == "ImportBREList")
                {
                    string sqlInstance = args[2].ToString();
                    expo.ImportBrePolicyVocabulary(rootPath, sqlInstance);
                }
                if (args[1].ToString() == "ExportIISClientCert")
                {
                  
                    expo.ExportClientCertOnetOneMappings(rootPath);
                }
                if (args[1].ToString() == "ImportHosts")
                {
                     
                    string usernameForHost = args[2].ToString();
                    string passwordForHost= args[3].ToString();
                    expo.ImportHostAndHostInstances(rootPath,  usernameForHost, passwordForHost);
                }
                if (args[1].ToString() == "ImportIISClientCert")
                {

                    expo.ImportClientCertOnetOneMappings(rootPath);
                }
                if (args[1].ToString() == "ImportAppPool")
                {

                    expo.ImportAppPools(rootPath);
                }
                if (args[1].ToString() == "ImportWebSite")
                {
                    string WebsiteName = args[2].ToString();
                    expo.ImportWebsites(rootPath, WebsiteName);
                }
                if (args[1].ToString() == "ImportWebApp")
                {
                    string WebsiteName = args[2].ToString();
                    expo.ImportWebApps(rootPath, WebsiteName);
                }
                if (args[1].ToString() == "BTSInstallPath")
                {
                    string operation = args[2].ToString();
                    expo.BtsInstallPath(rootPath, operation);
                }
                if (args[1].ToString() == "ExportBamDefinition")
                {
                    string sqlInstance = args[2].ToString();
                    expo.ExportBAMDefnition(rootPath, sqlInstance);
                }
                if (args[1].ToString() == "ImportBamDefinition")
                {
                    string sqlInstance = args[2].ToString();
                    expo.ImportBAMDefinition(rootPath, sqlInstance);
                }
                if (args[1].ToString() == "ExportBAMAccounts")
                {
                    string sqlInstance = args[2].ToString();
                    string viewName = args[3].ToString();
                    expo.ExportBAMAccounts(rootPath, sqlInstance, viewName);
                }
                if (args[1].ToString() == "ImportBAMAccounts")
                {
                    string sqlInstance = args[2].ToString();
                    string accountName= args[3].ToString();
                    string viewName = args[4].ToString();
                    expo.AddBAMAccounts(rootPath, sqlInstance,accountName, viewName);
                }
                if (args[1].ToString() == "ImportBTTList")
                {
                    string sqlInstance = args[2].ToString();
                    string bttList = args[3].ToString();
                    expo.ImportBTTDefiniton(rootPath, sqlInstance, bttList);
                }
                if (args[1].ToString() == "ExportHostMapSettings")
                {
                    string sqlInstance = args[2].ToString();
                    string srcServerList = args[3].ToString();
                    expo.ExportHostMapSettings(rootPath, sqlInstance, srcServerList);
                }
                if (args[1].ToString() == "ImportHostMapSettings")
                {
                    string sqlInstance = args[2].ToString();
                    expo.ImportHostMapSettings(rootPath, sqlInstance);
                }

                return 0;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public class RemoteExportImportFunctions
        {
            string machineName = System.Environment.MachineName;
            public void btnExportCert_Click(string pRootPath, string pCertPass)
            {
                string appPath;
                string certPath;
                string thumbPrint = string.Empty, certFileName = string.Empty;
                byte[] certBytes = null;
                X509Store store = null;
                string commandArguments = "";
                int returnCode;
                appPath = pRootPath;
                certPath = appPath + @"\CERT";

                try
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
                                    LogInfo(iStoreLocation + "_" + iStoreName + "_Count:" + store.Certificates.Count, pRootPath);
                                    foreach (X509Certificate2 certificate in store.Certificates)
                                    {
                                        // Exporting EnhancedKEyUsage for Certificates
                                        string[] enhancedKeyUsage = new string[] { };
                                        foreach (X509Extension extension in certificate.Extensions)
                                        {
                                            //Console.WriteLine(ex.Oid.FriendlyName + "(" + ex.Oid.Value + ")");
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
                                                    LogInfo("Exception Occured when Extracting Enhanced Key Usage: " + certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + certificate.Thumbprint, pRootPath);
                                                    LogException(ex, pRootPath);
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
                                                LogInfo("File Name: " + certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + thumbPrint + "_" + i.ToString(), pRootPath);
                                                int dateCompare = DateTime.Compare(certificate.NotAfter, DateTime.Now);
                                                if (dateCompare >= 0)
                                                {
                                                    if (certificate.HasPrivateKey)
                                                    {
                                                        certFileName = certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + thumbPrint + "_" + i.ToString() + ".PFX";
                                                        //certBytes = certificate.Export(X509ContentType.Pfx, strCertPass);
                                                        //File.WriteAllBytes(certFileName, certBytes);
                                                        if (iStoreLocation == "CurrentUser")
                                                            commandArguments = " -f -exportpfx " + " -p " + "\"" + pCertPass + "\"" + " -User " + iStoreName + " " + "\"" + thumbPrint + "\"" + " " + certFileName + " " + "ExtendedProperties";
                                                        else
                                                            commandArguments = " -f -exportpfx " + " -p " + "\"" + pCertPass + "\"" + " " + iStoreName + " " + "\"" + thumbPrint + "\"" + " " + certFileName + " " + "ExtendedProperties";
                                                        returnCode = ExecuteCmd("certutil.exe", commandArguments, pRootPath);
                                                        if (returnCode == 0)
                                                        {
                                                            LogInfo("Success: Exported Cert:" + certFileName, pRootPath);
                                                        }
                                                        else
                                                            LogInfo("Failed Exporting Cert:" + certFileName, pRootPath);
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
                                                LogInfo("File Name: " + certPath + @"\" + iStoreLocation + "_" + iStoreName + "_" + thumbPrint + "_" + i.ToString(), pRootPath);
                                                LogInfo("Exception in Cert: " + certFileName, pRootPath);
                                                LogException(ex, pRootPath);
                                            }
                                            finally
                                            {
                                                i++;
                                            }
                                            
                                        }
                                    }
                                    
                                }
                                catch (Exception ex)
                                {
                                    LogException(ex, pRootPath);
                                }
                                finally
                                {
                                    store.Close();
                                }
                            }
                        }
                    }
                    LogInfo("Exported Certificates from Server: " + machineName, pRootPath);

                    if (File.Exists(pRootPath + "\\Logs\\Cert_log.txt")) //if already exist then delete
                        File.Delete(pRootPath + "\\Logs\\Cert_log.txt");
                    File.Move(pRootPath + "\\Logs\\RemoteOperation_log.txt", pRootPath + "\\Logs\\Cert_log.txt");//rename 
                }
                catch (Exception ex)
                {
                    LogInfo("Certificate Export Failed on Server: " + machineName, pRootPath);
                    LogException(ex, pRootPath);

                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void btnImportCert_Click(string pRootPath, string pCertPass)
            {
                string appPath, thumbPrint;
                string certPath;
                appPath = pRootPath;
                certPath = appPath + @"\CERT";
                string commandArguments = " ";
                int returnCode;

                X509Store store = null; X509Certificate2 certificate = null;

                try
                {
                    //BEGIN::new code for delta, get all cert name and write them in txt file,
                    using (StreamWriter writer = new StreamWriter(appPath + @"\DstCertList.txt", false))
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
                                            writer.WriteLine(iStoreLocation + "_" + iStoreName + "_" + thumbPrint);
                                        }
                                        catch (Exception ex)
                                        {
                                            LogException(ex, pRootPath);
                                        }
                                        finally
                                        {

                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogException(ex, pRootPath);
                                }

                                finally
                                { store.Close(); }
                            }
                        }
                    }
                    //END::new code for delta, get all cert name and write them in txt file, 

                    string[] dstCertNameList = System.IO.File.ReadAllLines(appPath + @"\DstCertList.txt"); //read all cert of Dst
                                                                                                           //Creating CertificatesList with out StorLocation
                    string[] dstCertList = new string[dstCertNameList.Length];
                    for (int i = 0; i < dstCertNameList.Length; i++)
                    {
                        dstCertList[i] = dstCertNameList[i].Substring(dstCertNameList[i].IndexOf('_') + 1);
                    }
                    int certsImported = 0;
                    LogInfo("Calling Import Cert Function.", pRootPath);
                    string[] strFiles = null;

                    foreach (string iStoreLocation in Enum.GetNames(typeof(StoreLocation)))
                    {
                        foreach (string iStoreName in Enum.GetNames(typeof(StoreName)))
                        {
                            LogInfo("Inside Cert Loop: StoreLocation: " + iStoreLocation + ", StoreName: " + iStoreName, pRootPath);
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
                                    try
                                    {
                                        string certName = strFiles[iFile].Substring(strFiles[iFile].LastIndexOf('\\') + 1);
                                     
                                        if (storeNam == StoreName.My)
                                        {
                                            certName = certName.Substring(0, certName.LastIndexOf('_'));
                                            if (Array.IndexOf(dstCertNameList, certName) < 0)  //cert  already exists in Dst
                                            {
                                                if (Path.GetExtension(strFiles[iFile]) == ".PFX")
                                                {
                                                    if (strFiles[iFile].Contains("CurrentUser"))
                                                        commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + pCertPass + "\"" + " -User " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                    else
                                                        commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + pCertPass + "\"" + " " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                    
                                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments, pRootPath);
                                                    if (returnCode == 0)
                                                    {
                                                        LogInfo("Imported Cert: " + certName,pRootPath);
                                                    }
                                                    else
                                                        LogInfo("Failed Importing Cert:" + certName,pRootPath);
                                                    certsImported++;
                                                }
                                                else
                                                {
                                                    if (strFiles[iFile].Contains("CurrentUser"))
                                                        certificate = new X509Certificate2(strFiles[iFile], pCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.UserKeySet);
                                                    else
                                                        certificate = new X509Certificate2(strFiles[iFile], pCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.MachineKeySet);
                                                    store.Add(certificate);
                                                    certsImported++;
                                                    LogInfo("Imported Cert: " + certName,pRootPath);
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
                                                        commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + pCertPass + "\"" + " -User " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                    else
                                                        commandArguments = "/C C:\\windows\\system32\\certutil.exe -f -importpfx " + " -p " + "\"" + pCertPass + "\"" + " " + storeNam + " " + "\"" + strFiles[iFile] + "\"";
                                                    returnCode = ExecuteCmd("CMD.EXE", commandArguments,pRootPath);
                                                    if (returnCode == 0)
                                                    {
                                                        LogInfo("Imported Cert: " + certName1,pRootPath);
                                                    }
                                                    else
                                                        LogInfo("Failed Importing Cert:" + certName1,pRootPath);
                                                    certsImported++;
                                                }
                                                else
                                                {
                                                    if (strFiles[iFile].Contains("CurrentUser"))
                                                        certificate = new X509Certificate2(strFiles[iFile], pCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.UserKeySet);
                                                    else
                                                        certificate = new X509Certificate2(strFiles[iFile], pCertPass, X509KeyStorageFlags.Exportable & X509KeyStorageFlags.PersistKeySet & X509KeyStorageFlags.MachineKeySet);

                                                    store.Add(certificate);
                                                    certsImported++;
                                                    LogInfo("Imported Cert: " + certName1,pRootPath);
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        LogInfo("Exception in cert:" + strFiles[iFile], pRootPath);
                                        LogException(ex, pRootPath);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                LogException(ex, pRootPath);
                            }
                            finally
                            {
                                store.Close();
                            }
                        }
                    }

                    if (certsImported > 0)
                        LogInfo("Success: Imported Cert.", pRootPath);
                    else
                        LogInfo("No new certificates to import.", pRootPath);

                    try
                    {
                        if (Directory.Exists(certPath))
                        {
                            Directory.Delete(certPath, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogException(ex, pRootPath);
                    }
                    LogInfo("Imported Certificates to Server: " + machineName, pRootPath);
                    if (File.Exists(pRootPath + "\\Logs\\Cert_log.txt")) //if already exist then delete
                        File.Delete(pRootPath + "\\Logs\\Cert_log.txt");
                    File.Move(pRootPath + "\\Logs\\RemoteOperation_log.txt", pRootPath + "\\Logs\\Cert_log.txt");//rename
                }
                catch (Exception ex)
                {
                    LogInfo("Certificate Import Failed on Server: " + machineName, pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void btnExportAssemblies_Click(string pRootPath, string pDllPath, string pCustomDllToInclude, string pCustomDllPath, string pServerType)
            {
                XmlSerializer configSerializer = null;
                AssemblyList asmList = null;
                string asmPath1;
                string asmPath2, asmPath3, asmPath4, asmPath5;
                string[] findDLL = null; string[] customDll = null;
                string ver = string.Empty;
                string dir = string.Empty;
                string appPath = pRootPath;
                string asmPath = appPath + "\\ExportedData\\DLL";
                string xmlPath = appPath + "\\ExportedData\\XMLFiles";
                int asmListCount = 0;
                int customDlls = 0;
                char[] chrSep = { ',' };
                try
                {
                    if (pServerType == "BizTalk")
                    {
                        configSerializer = new XmlSerializer(typeof(AssemblyList));
                        asmList = (AssemblyList)configSerializer.Deserialize(new XmlTextReader(xmlPath + @"\SrcBizTalkAssembly.xml"));
                        asmListCount = asmList.Assembly.Length;
                        LogInfo("Total Biztalk Assemblies: " + asmListCount.ToString(), pRootPath);
                    }
                    LogInfo("Custom DLL Filter:" + pCustomDllToInclude, pRootPath);

                    string appName = string.Empty;

                    asmPath1 = @"C:\Windows\Microsoft.NET\assembly\";
                    asmPath2 = @"C:\Windows\assembly\GAC\";
                    asmPath3 = @"C:\Windows\assembly\GAC_32\";
                    asmPath4 = @"C:\Windows\assembly\GAC_64\";
                    asmPath5 = @"C:\Windows\assembly\GAC_MSIL\";

                    if (pCustomDllToInclude != string.Empty)
                    {
                        string[] CustomDllFilters = pCustomDllToInclude.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
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
                        LogInfo("Initial Custom Dll count: " + customDll.Length.ToString(), pRootPath);
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
                    if (pServerType == "BizTalk")
                    {
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
                                    LogInfo("Did not Find Assembly:" + asmList.Assembly[i].AsmName.ToString(), pRootPath);
                                }
                                else
                                {
                                    int fileCount = 0;

                                    foreach (string filePath in findDLL)
                                    {
                                        fileCount++;
                                        try
                                        {
                                            if (pCustomDllToInclude != string.Empty)
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
                                            dir = pDllPath + "\\" + Path.GetFileNameWithoutExtension(filePath) + "_" + ver;
                                            LogInfo(dir, pRootPath);
                                            if (!Directory.Exists(dir))
                                            {
                                                Directory.CreateDirectory(dir);
                                            }
                                            File.Copy(filePath, dir + "\\" + Path.GetFileName(filePath), true);
                                            LogInfo("Assembly copied from : " + filePath + "...to..." + dir, pRootPath);
                                            bizTalkDll.Add(Path.GetFileNameWithoutExtension(filePath) + "_" + ver);

                                        }
                                        catch (Exception ex)
                                        { LogException(ex, pRootPath); }
                                    }
                                }
                            }
                            catch (Exception ex)
                            { LogException(ex, pRootPath); }
                        }
                        string[] distinctBizTalkDll = bizTalkDll.Distinct().ToArray();
                        using (StreamWriter writer = new StreamWriter(xmlPath + @"\SrcBizTalkAssemblyList.txt", false))
                        {
                            foreach (string dll in distinctBizTalkDll)
                            {
                                writer.WriteLine(dll);
                            }
                        }

                    }
                   
                    if (pCustomDllToInclude != string.Empty)
                    {
                        LogInfo("Final Custom Dll count: " + (customDll.Length - customDlls).ToString(), pRootPath);
                        LogInfo("writing Src custom DLL File  : ", pRootPath);

                        using (StreamWriter writer = new StreamWriter(xmlPath + @"\SrcCustomAssemblyList.txt", false))
                        {

                            //copy custom dlls in CustomDll Folder

                            LogInfo("Copying Dlls back to : " + pCustomDllPath, pRootPath);
                            foreach (string filePath in customDll)
                            {
                                try
                                {
                                 
                                    if (!(string.IsNullOrEmpty(filePath))&&!(string.IsNullOrWhiteSpace(filePath)))
                                    {
                                        string CustomDllVer = AssemblyName.GetAssemblyName(filePath).Version.ToString();
                                        dir = pCustomDllPath + "\\" + Path.GetFileNameWithoutExtension(filePath) + "_" + CustomDllVer;

                                        if (!Directory.Exists(dir))
                                        {
                                            Directory.CreateDirectory(dir);
                                        }
                                        File.Copy(filePath, dir + "\\" + Path.GetFileName(filePath), true);
                                        writer.WriteLine(Path.GetFileNameWithoutExtension(filePath) + "_" + CustomDllVer);
                                        //writer.WriteLine(filePath);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("Assembly copy failed: " + Path.GetFileName(filePath),pRootPath);
                                    LogException(ex, pRootPath);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void btnDstCustomDllList_Click(string pRootPath, string pCustomDllToInclude)
            {
                string asmPath1;
                string asmPath2, asmPath3, asmPath4, asmPath5;

                string ver = string.Empty;
                string dir = string.Empty;
                string appPath = pRootPath;
                string asmPath = appPath + "\\ExportedData\\DLL";
                string xmlPath = appPath + "\\ExportedData\\XMLFiles";
                char[] chrSep = { ',' };
                string[] customDllDst = null;
                try
                {
                    LogInfo("Inside btnDstCustomDllList_Click.", pRootPath);
                    asmPath1 = @"C:\Windows\Microsoft.NET\assembly\";
                    asmPath2 = @"C:\Windows\assembly\GAC\";
                    asmPath3 = @"C:\Windows\assembly\GAC_32\";
                    asmPath4 = @"C:\Windows\assembly\GAC_64\";
                    asmPath5 = @"C:\Windows\assembly\GAC_MSIL\";

                    ///////////////////////////////////////////////////////
                    string[] CustomDllFilters = pCustomDllToInclude.Split(chrSep, StringSplitOptions.RemoveEmptyEntries);
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
                    LogInfo("Custom Dll Count Dst: " + customDllDst.Length.ToString(), pRootPath);
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
                    ///////////////////////////////////////////////////////                                                        
                    //write custom dll paths in txt file
                    using (StreamWriter writer = new StreamWriter(xmlPath + @"\DstCustomAssemblyList.txt", false))
                    {
                        foreach (string filePath in customDllDst)
                        {
                            if (filePath != string.Empty)
                            {
                                string CustomDllVer = "";
                                try
                                {
                                    CustomDllVer = AssemblyName.GetAssemblyName(filePath).Version.ToString();                                  
                                    writer.WriteLine(Path.GetFileNameWithoutExtension(filePath) + "_" + CustomDllVer);                                    
                                }
                                catch (Exception ex)
                                {
                                    LogException(ex,pRootPath);
                                }
                            }
                            //writer.WriteLine(filePath);
                        }               
                    }   
                }
                catch (Exception ex)
                {
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void btnDstDllList_Click(string pRootPath)
            {
                
                string asmPath1;
                string asmPath2, asmPath3, asmPath4, asmPath5;
                string appPath = pRootPath;
                string xmlPath = appPath + "\\ExportedData\\XMLFiles";
                try
                {
                    LogInfo("Inside btnDstDllList_Click.", pRootPath);
                    string[] srcBizTalkDllLines = System.IO.File.ReadAllLines(xmlPath + @"\SrcBizTalkAssemblyList.txt");
                    asmPath1 = @"C:\Windows\Microsoft.NET\assembly\";
                     asmPath2 = @"C:\Windows\assembly\GAC\";
                     asmPath3 = @"C:\Windows\assembly\GAC_32\";
                     asmPath4 = @"C:\Windows\assembly\GAC_64\";
                     asmPath5 = @"C:\Windows\assembly\GAC_MSIL\";

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
                catch(Exception ex)
                {
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }

            }
            public void btnExportAdapterHandlers_Click(string pRootPath, string pSqlServerInstanceName)
{
    string appPath = pRootPath;
    string xmlPath = appPath + "\\ExportedData\\XMLFiles";
    XmlWriter xmlWriterApps = null;
    try
    {

        LogInfo("Connecting to BizTalkMgmtdb...." + pSqlServerInstanceName, pRootPath);
        RcvSndHandlers rcvSndHandlers = new RcvSndHandlers();

        // instantiate new instance of Explorer OM
        BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

        // connection string to the BizTalk management database where the ports will be created
        btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";

        //Get All Handlers
        ReceiveHandlerCollection rcvHandCol = btsExp.ReceiveHandlers;
        LogInfo("Conneceted", pRootPath);
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

        LogInfo("Handlers list genrated, please check XML folder", pRootPath);
    }
    catch (Exception ex)
    {
        LogInfo("Adapter Handlers Export:: some Exception, pls check log.", pRootPath);
        LogException(ex, pRootPath);
        throw new Exception(ex.Message, ex.InnerException);
    }
    finally
    {
        if (xmlWriterApps != null)
            xmlWriterApps.Close();
    }
}

public void btnGetAssembliesList_Click(string pRootPath, string pSqlServerInstanceName, string pAppNameCollection)
{
    AssemblyList asmList = null;
    XmlSerializer x = null;
    XmlWriter xmlWriterApps = null;
    string appPath = pRootPath;
    string xmlPath = appPath + "\\ExportedData\\XMLFiles";
    try
    {
        BizTalkApplications bizTalkApps = new BizTalkApplications();

        // instantiate new instance of Explorer OM
        BtsCatalogExplorer btsExp = new BtsCatalogExplorer();
        LogInfo("Connecting to BizTalkMgmtDb..." + pSqlServerInstanceName, pRootPath);
        // connection string to the BizTalk management database where the ports will be created
        btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                    //Get All Applications
                    Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol = btsExp.Applications;
        LogInfo("Connected.", pRootPath);
        int asmCount = 0;
        foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
        {
            if (pAppNameCollection.Contains(app.Name))
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
            if (pAppNameCollection.Contains(app.Name))
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

        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

        //Add lib namespace with empty prefix
        ns.Add("", "");

        x = new System.Xml.Serialization.XmlSerializer(asmList.GetType());
        XmlWriterSettings xmlWriterSetting = new XmlWriterSettings();
        xmlWriterSetting.NamespaceHandling = NamespaceHandling.OmitDuplicates;

        xmlWriterApps = XmlWriter.Create(xmlPath + @"\SrcBizTalkAssembly.xml", xmlWriterSetting);
        x.Serialize(xmlWriterApps, asmList, ns);
        LogInfo("Asm list genrated in XML folder.", pRootPath);
    }
    catch (Exception ex)
    {
        LogInfo("Exception occured, please check log file for details.", pRootPath);
        LogException(ex, pRootPath);
        throw new Exception(ex.Message, ex.InnerException);
    }
    finally
    {
        if (xmlWriterApps != null)
            xmlWriterApps.Close();
    }
}

public void btnGetApplicationList_Click(string pRootPath, string pSqlServerInstanceName, string pBizTalkAppToIgnore)
{
    Hashtable htApps = null;
    XmlSerializer x = null;
    XmlWriter xmlWriterApps = null;

    string appPath = pRootPath;
    string xmlPath = appPath + "\\ExportedData\\XMLFiles";

    try
    {
        BizTalkApplications bizTalkApps = new BizTalkApplications();

        // instantiate new instance of Explorer OM
        BtsCatalogExplorer btsExp = new BtsCatalogExplorer();
        LogInfo("Connecting to BizTalkMgmtdb...." + pSqlServerInstanceName, pRootPath);
        // connection string to the BizTalk management database where the ports will be created
        btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                    //Get All Applications
                    Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol = btsExp.Applications;
        LogInfo("Connected.", pRootPath);

        htApps = new Hashtable();
        MSIAPP(appCol, htApps, pBizTalkAppToIgnore);

        int i = 0;

        bizTalkApps.BizTalkApplication = new BizTalkApplicationsBizTalkApplication[htApps.Count];

        foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
        {
            if (!pBizTalkAppToIgnore.Contains(app.Name)) //if (!(app.Name == "BizTalk.System" || app.Name == "BizTalk Application 1" || app.Name == "Microsoft.Practices.ESB" || app.Name == "BizTalk EDI Application"))
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
        LogInfo("App list with dependency code genrated in XML folder.", pRootPath);
    }
    catch (Exception ex)
    {
        LogException(ex, pRootPath);
        throw new Exception(ex.Message, ex.InnerException);
    }
    finally
    {
        if (xmlWriterApps != null)
            xmlWriterApps.Close();
    }
}

private void MSIAPP(Microsoft.BizTalk.ExplorerOM.ApplicationCollection appCol, Hashtable htApps, string pBizTalkAppToIgnore)
{
    foreach (Microsoft.BizTalk.ExplorerOM.Application app in appCol)
    {
        if (!pBizTalkAppToIgnore.Contains(app.Name)) //if (!(app.Name == "RosettaNet" || app.Name == "BizTalk.System" || app.Name == "BizTalk Application 1" || app.Name == "Microsoft.Practices.ESB" || app.Name == "BizTalk EDI Application"))
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
                MSIAPP(app.References, htApps, pBizTalkAppToIgnore);
        }
    }
}

public void btnGetServices_Click(string pRootPath, string pWindowsServiceToIgnore, string pUserNameNoDomain, string pFileName)
{
    try
    {
        char[] chrSep = { ',' };
        string appPath = pRootPath;
        string xmlPath = appPath + "\\ExportedData\\XMLFiles";
        string[] serviceName = pWindowsServiceToIgnore.Split(chrSep);

        LogInfo("Starting WMI query to get list of services from remote server.", pRootPath);

        SelectQuery query = new System.Management.SelectQuery(string.Format(
                                "select name,startname,pathname,displayname from Win32_Service"));

        using (StreamWriter writer = new StreamWriter(xmlPath + "\\" + pFileName + ".txt", false))
        {
            using (ManagementObjectSearcher searcher =
                new System.Management.ManagementObjectSearcher(query))
            {
                foreach (var service in searcher.Get())
                {
                    if (service["startname"] != null && (service["startname"].ToString().ToLower().Contains(pUserNameNoDomain)|| service["startname"].ToString().ToLower().Contains(pUserNameNoDomain.ToLower())))
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
        LogInfo("ServiceList Created:" + pFileName, pRootPath);
    }
    catch (Exception ex)
    {
        LogException(ex, pRootPath);
        throw new Exception(ex.Message, ex.InnerException);
    }
}

 public void ExportBrePolicyVocabulary(string pRootPath, string pSqlServerInstanceName)
  {
                string srcBRESqlInstance=null;
                string brePath = pRootPath + "\\ExportedData\\BRE";
                try
                {
                    //Getting the List of Policies associated to Application
                    SqlConnection sqlCon = new SqlConnection("Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
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
                                    LogInfo(ruleSetInfo.Name + "Policy Exported", pRootPath);
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                                    LogException(ex, pRootPath);

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
                                            LogInfo("Exception occured, please check log file for details.", pRootPath);
                                            LogException(ex, pRootPath);

                                        }

                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                LogInfo("Exception occured, please check log file for details.", pRootPath);
                                LogException(ex, pRootPath);
                          
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }

            }

 public void ImportBrePolicyVocabulary(string pRootPath, string pSqlServerInstanceName)
            {
                string dstBRESqlInstance = null;
                string brePath = pRootPath + "\\ExportedData\\BRE";
                String[] files;
                try
                {
                    SqlConnection sqlCon = new SqlConnection("Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI");
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
                            //Checking Whether its Present in DstSQLInstance
                            string filename = Path.GetFileName(file);
                            if (vocabualrySet.Contains(filename))
                            {
                                LogInfo(file + "Already Published", pRootPath);
                            }
                            else
                            {
                                FileRuleStore fileRuleStore = new FileRuleStore(file);
                                VocabularyInfoCollection vocabularyInfoList = fileRuleStore.GetVocabularies(RuleStore.Filter.All);

                                foreach (VocabularyInfo vocabularyInfo in vocabularyInfoList)

                                {

                                    try
                                    {
                                        VocabularyInfo vi = new VocabularyInfo(vocabularyInfo.Name, vocabularyInfo.MajorRevision, vocabularyInfo.MinorRevision);
                                        Vocabulary oVoc = fileRuleStore.GetVocabulary(vi);
                                        sqlRulesStore.Add(oVoc, true);
                                        LogInfo(file + "Imported", pRootPath);
                                    }
                                    catch (Exception ex)
                                    {
                                        LogInfo("Exception occured, please check log file for details.", pRootPath);
                                        LogException(ex, pRootPath);

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
                                LogInfo(file + "Already Published", pRootPath);
                            }
                            else
                            {
                                try
                                {
                                    rulesetDepDriver.ImportAndPublishFileRuleStore(file);
                                    LogInfo(file + "Imported", pRootPath);
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                                    LogException(ex, pRootPath);

                                }
                            }



                        }

                    }
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }

            }

 public void ExportHostMapSettings(string pRootPath, string pSqlServerInstanceName,string srcServerList)
 {
             
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                try
                {

                    BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                    // connection string to the BizTalk management database where the ports will be created
                    btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
                    HostCollection hosts = btsExp.Hosts;
                  string[]  srcServers = srcServerList.Split(',');
                    for (int i = 0; i < srcServers.Length; i++)
                    {
                        using (XmlWriter writer = XmlWriter.Create(xmlPath + @"\" + "Src_" + srcServers[i] + "_HostMappings.xml"))
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
                                if (ht.Name.EndsWith(srcServers[i])|| ht.Name.EndsWith(srcServers[i].ToLower()))
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
                                writer.WriteAttributeString("Name", hostInstancesArray[j] + ":" + srcServers[i]);
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
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void ImportHostMapSettings(string pRootPath, string pSqlServerInstanceName)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                try
                {
                    LogInfo("Host Mappings: Creating Host Mappings.", pRootPath);
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
                            btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
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

                    if (dstservers.Length < srcservers.Length)
                    {
                        for (int i = 0; i < dstservers.Length; i++)
                        {
                            string srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[i] + "_HostMappings.xml";
                            string dstHostMappingFile = xmlPath + @"\" + "Dst_" + dstservers[i] + "_HostMappings.xml";
                            // instantiate new instance of Explorer OM
                            BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                            // connection string to the BizTalk management database where the ports will be created
                            btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
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
                        string srcHostMappingFile = string.Empty;
                        for (int i = 0; i < dstservers.Length; i++)
                        {
                            if (i < srcservers.Length)
                                 srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[i] + "_HostMappings.xml";
                            else
                                srcHostMappingFile = xmlPath + @"\" + "Src_" + srcservers[0] + "_HostMappings.xml";
                            string dstHostMappingFile = xmlPath + @"\" + "Dst_" + dstservers[i] + "_HostMappings.xml";
                            // instantiate new instance of Explorer OM
                            BtsCatalogExplorer btsExp = new BtsCatalogExplorer();

                            // connection string to the BizTalk management database where the ports will be created
                            btsExp.ConnectionString = "Server=" + pSqlServerInstanceName + ";Initial Catalog=BizTalkMgmtDb;Integrated Security=SSPI";
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
                    LogInfo("Host Mappings: Created Host Mappings.", pRootPath);
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void ExportClientCertOnetOneMappings(string pRootPath)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                
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
                                    LogInfo(site.Name + " Website:Does not Contain  OneToOneCLientCertificateMappings", pRootPath);
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
                                LogInfo("Exception occured, please check log file for details.", pRootPath);
                                LogException(ex, pRootPath);
                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void ImportClientCertOnetOneMappings(string pRootPath)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
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
                                    LogInfo(site + "_ClientCertMappings are not Present", pRootPath);
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
                                            LogInfo(node.SelectSingleNode("certificate").InnerText + " already Exsists in Website: " + site.Name, pRootPath);
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
                                            LogInfo(node.SelectSingleNode("certificate").InnerText + " added in" + site.Name, pRootPath);
                                        }
                                    }
                                    serverManager.CommitChanges();
                                    LogInfo(site.Name + "OneToOneClientCert Mappings Completed", pRootPath);

                                }

                            }
                            catch (Exception ex)
                            {
                                LogInfo("Exception occured, please check log file for details.", pRootPath);
                                LogException(ex, pRootPath);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public void ImportHostAndHostInstances(string pRootPath,string strUserNameForHost, string strPasswordForHost)
            {
             
                //string dstHostList = string.Empty, dstHostInstanceList = string.Empty;
                List<string> dstHostList = new List<string>();
                List<string> dstHostInstanceList = new List<string>();
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                LogInfo("Host: Import started..", pRootPath);
                if (!File.Exists(xmlPath + @"\HostInstances.xml"))
                    throw new Exception("HostInstances xml file does not exist.");
                //check file is empty or not
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath + "\\HostInstances.xml");
                if (doc.DocumentElement.ChildNodes.Count == 0)//if file not empty.                
                    throw new Exception("HostInstances xml file is empty.");

                //Getting the List of DestinationServers
                XmlDocument xd = new XmlDocument();

                string[] dstservers = new string[] { };
                xd.Load(xmlPath + "\\" + "Servers.xml");
                XmlNode dstnodeList = xd.DocumentElement.SelectSingleNode("/Servers");

                string dstServerList = dstnodeList.SelectSingleNode("DstNodes").InnerText;
                dstservers = dstServerList.Split(',');
                XmlSerializer configSerializer = new XmlSerializer(typeof(Hosts));
                Hosts input = (Hosts)configSerializer.Deserialize(new XmlTextReader(xmlPath + @"\HostInstances.xml"));

                //get all HostInstances of 'InProcess' type.

                ManagementObjectSearcher searchObject = null;
                EnumerationOptions enumOptions = new EnumerationOptions();
                enumOptions.ReturnImmediately = false;

                //Creating DestinationHostList
                searchObject = new ManagementObjectSearcher("root\\MicrosoftBizTalkServer", "Select * from MSBTS_Host", enumOptions);
                foreach (var inst in searchObject.Get())
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
                            host.isDefaultHost, pRootPath);
                    }
                    else
                        LogInfo("Host already exist: " + host.name, pRootPath);
                }

                int i = 0;
                for (i = 0; i < dstservers.Length; i++)
                {
                    //Creating DestinationHostInstanceListForeachnode
                    dstHostInstanceList = new List<string>();
                    searchObject = new ManagementObjectSearcher("root\\MicrosoftBizTalkServer", "Select * from MSBTS_HostInstance", enumOptions);
                    foreach (var inst in searchObject.Get())
                    {
                        if (inst["RunningServer"].ToString().ToUpper() == dstservers[i].ToString())
                            // dstHostInstanceList = dstHostInstanceList + inst["HostName"].ToString().ToUpper() + ",";
                            dstHostInstanceList.Add(inst["HostName"].ToString().ToUpper());
                    }
                    //Create DestinationHostInstance for EachNode
                    foreach (HostsHost host in input.Host)
                    {
                        if (!dstHostInstanceList.Contains(host.name.ToUpper()))
                        {
                            CreateHostInstance(dstservers[i].ToString(), host.name, strUserNameForHost, strPasswordForHost,  pRootPath);
                        }
                        else
                            LogInfo("Host Instance already exist: " + host.name + " on " + dstservers[i].ToString(), pRootPath);
                    }
                }
            }

            private void CreateHost(string name, HostSetting.HostTypeValues hostType, string ntGroupName, bool authTrusted, bool hostTracking, bool is32bit, bool defaultHost, string pRootPath)
            {
                HostSetting myHostSetting = null;
                try
                {

                    myHostSetting = HostSetting.CreateInstance();

                    myHostSetting.AutoCommit = false;

                    myHostSetting.Name = name;
                    myHostSetting.HostType = hostType;
                    myHostSetting.NTGroupName = ntGroupName;
                    myHostSetting.AuthTrusted = authTrusted;
                    myHostSetting.IsHost32BitOnly = is32bit;
                    myHostSetting.HostTracking = hostTracking;
                    myHostSetting.IsDefault = defaultHost;

                    myHostSetting.CommitObject();

                    LogInfo("Host created successfully: " + name,pRootPath);
                }

                catch (Exception ex)
                {
                    LogInfo("Error Creating Host: " + name,pRootPath);
                    LogException(ex,pRootPath);
                }
            }

            private void CreateHostInstance(string serverName, string name, string strUserNameForHost, string strPasswordForHost, string pRootPath)
            {
                HostInstance myHostInstance = null;
                ServerHost myServerHost = null;
                try
                {

                    myServerHost = ServerHost.CreateInstance();

                    myServerHost.ServerName = serverName;
                    myServerHost.HostName = name;
                    myServerHost.Map();


                    myHostInstance = HostInstance.CreateInstance();

                    myHostInstance.Name = "Microsoft BizTalk Server " + name + " " + serverName;
                    myHostInstance.Install(true, strUserNameForHost, strPasswordForHost);

                    LogInfo("Host Instance created successfully: " + name + ", " + serverName,pRootPath);
                }
                catch (Exception ex)
                {
                    LogInfo("Error creating HostInstance: " + name + ", " + serverName,pRootPath);
                    LogException(ex,pRootPath);
                }
            }

            public void ImportAppPools(string pRootPath)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
               string  commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe add apppool /in /xml < \"" + xmlPath + "\\AppPoolToImport.xml" + "\"";
                
                int returnCode = ExecuteCmd("CMD.EXE", commandArguments,pRootPath);
                if (returnCode == 0)
                    LogInfo("Success: Imported AppPools on Server "+ machineName,pRootPath);
                else
                    LogInfo("Failed: Importing AppPools on Server "+ machineName,pRootPath);


            }

            public void ImportWebsites(string pRootPath,string webSiteName)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                string commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe add site /in /xml /< \"" + xmlPath + "\\WebSite_" + webSiteName + "_ToImport.xml" + "\"";
                
                int returnCode = ExecuteCmd("CMD.EXE", commandArguments, pRootPath);
                if (returnCode == 0)
                    LogInfo("Success: Imported Website "+ webSiteName, pRootPath);
                else
                    LogInfo("Failed: Importing Website " + webSiteName, pRootPath);
            }
            public void ImportWebApps(string pRootPath, string webSiteName)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                string commandArguments = "/C C:\\windows\\system32\\inetsrv\\appcmd.exe add app /in /xml /< \"" + xmlPath + "\\WebApps_" + webSiteName + "_ToImport.xml" + "\"";
                
                int returnCode = ExecuteCmd("CMD.EXE", commandArguments, pRootPath);
                if (returnCode == 0)
                    LogInfo("Success: Imported WebApps for Website " + webSiteName, pRootPath);
                else
                    LogInfo("Failed: Importing WebApps for Website " + webSiteName, pRootPath);
            }

            public void BtsInstallPath(string pRootPath,string Operation)
            {
                string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                string commandArguments = string.Empty;
                try
                {
                    if(Operation=="Export")
                        commandArguments = "/C SET BTSINSTALLPATH > \"" + xmlPath + "\\SrcBTSInstallPath.txt" + "\"";
                    else
                        commandArguments = "/C SET BTSINSTALLPATH > \"" + xmlPath + "\\DstBTSInstallPath.txt" + "\"";

                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments, pRootPath);
                    if (returnCode == 0)
                        LogInfo("Success:Created BTSInstallPath.txt.",pRootPath );
                    else
                        LogInfo("Failed: Creating BTSInstallPath.txt.", pRootPath);
                }
                catch(Exception ex)
                {
                    LogInfo("Error creating BTSInstallPath",pRootPath);
                    LogException(ex, pRootPath);
                }
            }

            public void ExportBAMDefnition(string pRootPath, string pSqlServerInstanceName)
            {
                try
                {
                    string bamExePath = Environment.GetEnvironmentVariable("BTSINSTALLPATH").ToString() + @"Tracking\bm.exe";
                    string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                    string commandArguments = " get-defxml -FileName:\"" + xmlPath + "\\BamDef.xml\" -Server:" + pSqlServerInstanceName + " -Database:BAMPrimaryImport";
                    int returnCode = ExecuteCmd(bamExePath, commandArguments,pRootPath);
                    if (returnCode == 0)
                        LogInfo("Success: BAM Definition Exported.", pRootPath);
                    else
                        throw new Exception("Failed: BAM Definition Export");
                }
                catch(Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                }

            }
            public void ImportBAMDefinition(string pRootPath, string pSqlServerInstanceName)
            {
                try
                {
                    
                    string bamExePath = Environment.GetEnvironmentVariable("BTSINSTALLPATH").ToString() + @"Tracking\bm.exe";
                    string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                    string commandArguments = " deploy-all -DefinitionFile:\"" + xmlPath + "\\BamDefToImport.xml\" -Server:" + pSqlServerInstanceName
                        + " -Database:BAMPrimaryImport";
                    int returnCode = ExecuteCmd(bamExePath, commandArguments, pRootPath);
                    if (returnCode == 0)
                        LogInfo("Success: BamDef Imported.",pRootPath);
                    else
                        throw new Exception("BamDef import failed, hence aborting account import.");
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                }
            }

            public void AddBAMAccounts(string pRootPath, string pSqlServerInstanceName,string accountName,string viewName)
            {
                try
                {
                    string bamExePath = Environment.GetEnvironmentVariable("BTSINSTALLPATH").ToString() + @"Tracking\bm.exe";
                    string commandArguments = " add-account -AccountName:\"" + accountName + "\" -View:\"" + viewName + "\" -Server:"
                                   + pSqlServerInstanceName
                                  + " -Database:BAMPrimaryImport";
                   int returnCode = ExecuteCmd(bamExePath, commandArguments,pRootPath);
                    if (returnCode == 0)
                        LogInfo("Account: " + accountName + " added to view: " + viewName, pRootPath);
                    else
                        LogInfo("Account: " + accountName + " could not be added to view: " + viewName, pRootPath);
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                }
            }

            public void ImportBTTDefiniton(string pRootPath, string pSqlServerInstanceName,string bttFile)
            {
                try
                {
                    string bamExePath = Environment.GetEnvironmentVariable("BTSINSTALLPATH").ToString() + @"Tracking\bm.exe";
                    string bttDeployExePath = bamExePath.Substring(0, bamExePath.LastIndexOf("\\") + 1) + "bttDeploy.exe ";
                    string commandArguments = " /mgdb \"" + pSqlServerInstanceName + "\\BizTalkMgmtDb" + "\" \"" + bttFile + "\"";
                   int returnCode = ExecuteCmd(bttDeployExePath, commandArguments,pRootPath);
                    if (returnCode == 0)
                        LogInfo("Sucess: BTT File Imported " + bttFile.Substring(bttFile.LastIndexOf("\\") + 1),pRootPath);
                    else
                        LogInfo("Failed: BTT File Import " + bttFile.Substring(bttFile.LastIndexOf("\\") + 1),pRootPath);
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                }
            }
            public void ExportBAMAccounts(string pRootPath, string pSqlServerInstanceName,string viewName)
            {
                try
                {
                    string bamExePath = Environment.GetEnvironmentVariable("BTSINSTALLPATH").ToString() + @"Tracking\bm.exe";
                    string xmlPath = pRootPath + "\\ExportedData\\XMLFiles";
                    string commandArguments = "/C " + "\"\"" + bamExePath + "\"" + " get-accounts -View:\"" + viewName + "\" -Server:" + pSqlServerInstanceName
                               + " -Database:BAMPrimaryImport > \"" + xmlPath + "\\BamView_" + viewName + ".txt\"\"";
                    int returnCode = ExecuteCmd("CMD.EXE", commandArguments, pRootPath);
                    if (returnCode == 0)
                        LogInfo("Success: Get BAM Accounts for View: " + viewName,pRootPath);
                    else
                        LogInfo("Failed: Get BAM Accounts for View: " + viewName,pRootPath);
                }
                catch (Exception ex)
                {
                    LogInfo("Exception occured, please check log file for details.", pRootPath);
                    LogException(ex, pRootPath);
                }
            }

            private string Encrypt(string data)
            {
                try
                {
                    byte[] keyArray;
                    keyArray = (Encoding.UTF8.GetBytes("M!grat!onkey1234"));
                    TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

                    DES.Mode = CipherMode.ECB;
                    DES.Key = keyArray;

                    DES.Padding = PaddingMode.PKCS7;
                    ICryptoTransform DESEncrypt = DES.CreateEncryptor();
                    Byte[] Buffer = Encoding.ASCII.GetBytes(data);

                    return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
                }
                catch (Exception ex)
                {
                   
                    throw new Exception(ex.Message, ex.InnerException);
                }

            }

            private string Decrypt(string data)
            {
                try
                {
                    byte[] keyArray;
                    keyArray = (Encoding.UTF8.GetBytes("M!grat!onkey1234"));
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
                    
                    throw new Exception(ex.Message, ex.InnerException);
                }

            }
            public void LogInfo(string strMsg, string pPath)
{
    string appPath = pPath;
    string logPath = appPath + @"\Logs";

    if (strMsg != "")
    {
        using (StreamWriter writer = new StreamWriter(logPath + @"\RemoteOperation_log.txt", true))
        {
            writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + strMsg);
        }
    }
}

public void LogException(Exception ex, string pPath)
{
    string appPath = pPath;
    string logPath = appPath + @"\Logs";

    using (StreamWriter writer = new StreamWriter(logPath + @"\RemoteOperation_log.txt", true))
    {
        writer.WriteLine(DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss:::") + "Exception Message:  " + ex.Message.ToString());
        writer.WriteLine("Inner Exception:  " + ex.InnerException);
        writer.WriteLine("StackTrace:  " + ex.StackTrace);
    }
}

            private int ExecuteCmd(string cmdName, string cmdArg,string pPath)
            {
                string commandArguments = cmdArg;
                using (var p = new Process())
                {
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
                        return p.ExitCode;
                        //return strSuccess;
                    }
                    catch (Exception ex)
                    {
                        LogException(ex,pPath);
                    }
                }

                return 1;
            }

            void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
            {
                // LogInfo(e.Data,logPath);
            }

            void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
            {
               // LogInfo(e.Data, logPath);
            }
           
        }
    }
}
