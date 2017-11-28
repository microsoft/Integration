using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MigrationTool;

namespace MigrationTool
{
    public partial class Settings : Form
    {
        #region Variables
        string appPath, configFile;
        private BizTalkAdminOperations.BizTalkAdminOperations biztalkAdminOperations;
        #endregion
        #region Constructors
        public Settings()
        {
            InitializeComponent();
           
        }
        public Settings(BizTalkAdminOperations.BizTalkAdminOperations BiztalkAdminOperations)
        {
            InitializeComponent();
            biztalkAdminOperations = BiztalkAdminOperations;

        }
        #endregion
        #region Events
        private void Settings_Load(object sender, EventArgs e)
        {
             appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            configFile = System.IO.Path.Combine(appPath, "MigrationTool.exe.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            txtAppToRefer.Text = config.AppSettings.Settings["AppToRefer"].Value;
            txtBiztalkAppToIgnore.Text = config.AppSettings.Settings["BizTalkAppToIgnore"].Value;
            txtWindowsServiceToIgnore.Text= config.AppSettings.Settings["WindowsServiceToIgnore"].Value;
            txtFoldersToCopyNoFiles.Text= config.AppSettings.Settings["FoldersToCopyNoFiles"].Value;
            txtFoldersToCopy.Text= config.AppSettings.Settings["FoldersToCopy"].Value;
            txtCustomDllToInclude.Text= config.AppSettings.Settings["CustomDllToInclude"].Value;
            txtTemporaryFolder.Text = config.AppSettings.Settings["RemoteRootFolder"].Value;
            txtCertPass.Text = config.AppSettings.Settings["CertPass"].Value;
            txtWebSitesDrive.Text = config.AppSettings.Settings["WebSitesDriveDestination"].Value;
            txtFoldersDrive.Text = config.AppSettings.Settings["FoldersDriveDestination"].Value;
            txtServicesDrive.Text= config.AppSettings.Settings["ServicesDriveDestination"].Value;

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                
                //biztalkAdminOperations.LogInfoInLogFile("Settings:Update Started");

                 appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                 configFile = System.IO.Path.Combine(appPath, "MigrationTool.exe.config");
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = configFile;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                config.AppSettings.Settings["AppToRefer"].Value = txtAppToRefer.Text;
                config.AppSettings.Settings["RemoteRootFolder"].Value = txtTemporaryFolder.Text;
               // config.AppSettings.Settings["BamExePath"].Value = Environment.GetEnvironmentVariable("BTSINSTALLPATH") + @"Tracking\bm.exe";
                config.AppSettings.Settings["CertPass"].Value = txtCertPass.Text;
                config.AppSettings.Settings["FoldersToCopyNoFiles"].Value = txtFoldersToCopyNoFiles.Text;
                config.AppSettings.Settings["FoldersToCopy"].Value = txtFoldersToCopy.Text;
                config.AppSettings.Settings["BizTalkAppToIgnore"].Value = txtBiztalkAppToIgnore.Text;
                config.AppSettings.Settings["CustomDllToInclude"].Value = txtCustomDllToInclude.Text;
                config.AppSettings.Settings["WindowsServiceToIgnore"].Value = txtWindowsServiceToIgnore.Text;
                config.AppSettings.Settings["WebSitesDriveDestination"].Value = txtWebSitesDrive.Text;
                config.AppSettings.Settings["FoldersDriveDestination"].Value = txtFoldersDrive.Text;
                config.AppSettings.Settings["ServicesDriveDestination"].Value = txtServicesDrive.Text;
                config.Save();
                biztalkAdminOperations.UpdateSettings();
                this.Close();
               
                
                
               
            }
            catch (Exception ex)
            {
                BizTalkAdminOperations.BizTalkAdminOperations biztalkAdminOperations = new BizTalkAdminOperations.BizTalkAdminOperations();
                biztalkAdminOperations.LogInfoInLogFile("Error while Updating Settings to ConfigFile " + ex.Message + ", " + ex.StackTrace);
                this.Close();
            }
        }
        #endregion
    }
}
