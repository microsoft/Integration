Summary
Host Integration Server (HIS) includes a Visual Studio Designer to allow for the creation of .hidx files that are used by various components of the HIS runtime to communicate with backend systems.  Creating .hidx files with the Studio Designer is strictly a manual operation, however having the capability to automate the generation of these files can save time over the life of a project.  Host Integration Server 2016 Cumulative Update 2 allows the creation and modification of .hidx files through the use of PowerShell.  It is important to note that the 32-bit version of PowerShell must be used because components of the 32-bit Visual Studio Designer are called.  If the 64-bit version of PowerShell is used, an error similar to the following is logged: 

The type initializer for 'Microsoft.HostIntegration.Importer.PowerShell.NewHisWipHidxFile' threw an exception.

The CreateWIPObject.ps1 script is a starter script that shows the steps to create an hidx file, add a method and parameters, and then save the file. For this script a TI WIP ELM User data hidx file is created.

Open the 32-bit Windows PowerShell ISE (x86), in the View menu select the Show Command Add-on. In the Commands tab select the Microsoft.HostIntegration.Importer.PowerShell module to display the full list of PowerShell commands that are available. Clicking on each of the commands will give additional information about the individual command.

Additional scripts will be added to GitHub as they become available.