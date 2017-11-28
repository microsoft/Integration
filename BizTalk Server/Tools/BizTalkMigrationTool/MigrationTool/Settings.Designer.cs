namespace MigrationTool
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAppToRefer = new System.Windows.Forms.TextBox();
            this.txtTemporaryFolder = new System.Windows.Forms.TextBox();
            this.txtCertPass = new System.Windows.Forms.TextBox();
            this.txtFoldersToCopyNoFiles = new System.Windows.Forms.TextBox();
            this.txtFoldersToCopy = new System.Windows.Forms.TextBox();
            this.txtBiztalkAppToIgnore = new System.Windows.Forms.TextBox();
            this.txtCustomDllToInclude = new System.Windows.Forms.TextBox();
            this.txtWindowsServiceToIgnore = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWebSitesDrive = new System.Windows.Forms.TextBox();
            this.txtFoldersDrive = new System.Windows.Forms.TextBox();
            this.txtServicesDrive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application To Refer";
            this.toolTip1.SetToolTip(this.label3, "List of BizTalk applications to be referred.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temporary Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Certificate Password";
            this.toolTip1.SetToolTip(this.label2, "Password to export/import private certificates.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Folders To Copy (Without Files)";
            this.toolTip1.SetToolTip(this.label4, "List of folders (excluding files) to migrate.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Folders To Copy (With Files)";
            this.toolTip1.SetToolTip(this.label5, "List of folders (including files) to migrate.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "BizTalk App To Ignore";
            this.toolTip1.SetToolTip(this.label6, "List of BizTalk applications to ignore, migration.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Custom DLL";
            this.toolTip1.SetToolTip(this.label7, "List of custom assemblies to migrate.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Windows Service To Ignore";
            this.toolTip1.SetToolTip(this.label8, "List of windows service to ignore, migration.");
            // 
            // txtAppToRefer
            // 
            this.txtAppToRefer.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAppToRefer.Location = new System.Drawing.Point(201, 43);
            this.txtAppToRefer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAppToRefer.Name = "txtAppToRefer";
            this.txtAppToRefer.Size = new System.Drawing.Size(665, 32);
            this.txtAppToRefer.TabIndex = 8;
            // 
            // txtTemporaryFolder
            // 
            this.txtTemporaryFolder.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtTemporaryFolder.Location = new System.Drawing.Point(201, 421);
            this.txtTemporaryFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTemporaryFolder.Name = "txtTemporaryFolder";
            this.txtTemporaryFolder.Size = new System.Drawing.Size(665, 32);
            this.txtTemporaryFolder.TabIndex = 14;
            // 
            // txtCertPass
            // 
            this.txtCertPass.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtCertPass.Location = new System.Drawing.Point(201, 463);
            this.txtCertPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCertPass.Name = "txtCertPass";
            this.txtCertPass.Size = new System.Drawing.Size(665, 32);
            this.txtCertPass.TabIndex = 15;
            // 
            // txtFoldersToCopyNoFiles
            // 
            this.txtFoldersToCopyNoFiles.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFoldersToCopyNoFiles.Location = new System.Drawing.Point(201, 169);
            this.txtFoldersToCopyNoFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoldersToCopyNoFiles.Name = "txtFoldersToCopyNoFiles";
            this.txtFoldersToCopyNoFiles.Size = new System.Drawing.Size(665, 32);
            this.txtFoldersToCopyNoFiles.TabIndex = 11;
            // 
            // txtFoldersToCopy
            // 
            this.txtFoldersToCopy.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFoldersToCopy.Location = new System.Drawing.Point(201, 211);
            this.txtFoldersToCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoldersToCopy.Name = "txtFoldersToCopy";
            this.txtFoldersToCopy.Size = new System.Drawing.Size(665, 32);
            this.txtFoldersToCopy.TabIndex = 12;
            // 
            // txtBiztalkAppToIgnore
            // 
            this.txtBiztalkAppToIgnore.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtBiztalkAppToIgnore.Location = new System.Drawing.Point(201, 85);
            this.txtBiztalkAppToIgnore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBiztalkAppToIgnore.Name = "txtBiztalkAppToIgnore";
            this.txtBiztalkAppToIgnore.Size = new System.Drawing.Size(665, 32);
            this.txtBiztalkAppToIgnore.TabIndex = 9;
            // 
            // txtCustomDllToInclude
            // 
            this.txtCustomDllToInclude.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtCustomDllToInclude.Location = new System.Drawing.Point(201, 253);
            this.txtCustomDllToInclude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomDllToInclude.Name = "txtCustomDllToInclude";
            this.txtCustomDllToInclude.Size = new System.Drawing.Size(665, 32);
            this.txtCustomDllToInclude.TabIndex = 13;
            // 
            // txtWindowsServiceToIgnore
            // 
            this.txtWindowsServiceToIgnore.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtWindowsServiceToIgnore.Location = new System.Drawing.Point(201, 127);
            this.txtWindowsServiceToIgnore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWindowsServiceToIgnore.Name = "txtWindowsServiceToIgnore";
            this.txtWindowsServiceToIgnore.Size = new System.Drawing.Size(665, 32);
            this.txtWindowsServiceToIgnore.TabIndex = 10;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(193)))));
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(371, 516);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(165, 39);
            this.btnSaveSettings.TabIndex = 16;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Web Sites Drive (Destination)";
            this.toolTip1.SetToolTip(this.label9, "WebSite root drive on destination server.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 339);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Folders Drive (Destination)";
            this.toolTip1.SetToolTip(this.label10, "Folders (without files) drive on destination server.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 381);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Service Drive (Destination)";
            this.toolTip1.SetToolTip(this.label11, "Windows service drive on destination server.");
            // 
            // txtWebSitesDrive
            // 
            this.txtWebSitesDrive.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtWebSitesDrive.Location = new System.Drawing.Point(201, 295);
            this.txtWebSitesDrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWebSitesDrive.Name = "txtWebSitesDrive";
            this.txtWebSitesDrive.Size = new System.Drawing.Size(665, 32);
            this.txtWebSitesDrive.TabIndex = 18;
            // 
            // txtFoldersDrive
            // 
            this.txtFoldersDrive.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFoldersDrive.Location = new System.Drawing.Point(201, 337);
            this.txtFoldersDrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoldersDrive.Name = "txtFoldersDrive";
            this.txtFoldersDrive.Size = new System.Drawing.Size(665, 32);
            this.txtFoldersDrive.TabIndex = 20;
            // 
            // txtServicesDrive
            // 
            this.txtServicesDrive.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtServicesDrive.Location = new System.Drawing.Point(201, 379);
            this.txtServicesDrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicesDrive.Name = "txtServicesDrive";
            this.txtServicesDrive.Size = new System.Drawing.Size(665, 32);
            this.txtServicesDrive.TabIndex = 22;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 574);
            this.Controls.Add(this.txtServicesDrive);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFoldersDrive);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWebSitesDrive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtWindowsServiceToIgnore);
            this.Controls.Add(this.txtCustomDllToInclude);
            this.Controls.Add(this.txtBiztalkAppToIgnore);
            this.Controls.Add(this.txtFoldersToCopy);
            this.Controls.Add(this.txtFoldersToCopyNoFiles);
            this.Controls.Add(this.txtCertPass);
            this.Controls.Add(this.txtTemporaryFolder);
            this.Controls.Add(this.txtAppToRefer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(30, 40);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAppToRefer;
        private System.Windows.Forms.TextBox txtTemporaryFolder;
        private System.Windows.Forms.TextBox txtCertPass;
        private System.Windows.Forms.TextBox txtFoldersToCopyNoFiles;
        private System.Windows.Forms.TextBox txtFoldersToCopy;
        private System.Windows.Forms.TextBox txtBiztalkAppToIgnore;
        private System.Windows.Forms.TextBox txtCustomDllToInclude;
        private System.Windows.Forms.TextBox txtWindowsServiceToIgnore;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWebSitesDrive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFoldersDrive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtServicesDrive;
    }
}