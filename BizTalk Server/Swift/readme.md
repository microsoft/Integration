# Using Microsoft BizTalk Accelerator for Swift Message Pack Open Source Components

## About

The open source components of BizTalk Accelerator for Swift Message Pack can be used to update the existing environments based on new standards released by Swift every year.
This open source repository is meant to be used by customers who already have installed Swift Message Pack 2019 for Microsoft BizTalk Accelerator for SWIFT

The latest CU available is located [here](https://www.microsoft.com/en-us/download/details.aspx?id=102265)

## Contents

The directory structure of the repository has the following folders

1. Source: This directory includes the buildable components of the Message Pack. It includes the source code for the following assemblies.

   - Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.dll
   - Microsoft.Solutions.FinancialServices.SWIFT.ValidationMessages.ErrorLookup.dll
   - Microsoft.Solutions.FinancialServices.SWIFT.ValidationMessages.ErrorResources.dll

2. SWIFT Message: this directory has schemas for each category, base schemas and BRE Vocabulary and policies.

3. SDK: This directory contains miscellaneous samples, scripts etc.

## Prerequisites

The following prerequisites are required

- Microsoft BizTalk Server 2016 or higher
- Microsoft BizTalk Accelerator for Swift compatible with your BizTalk Server installation
- Microsoft BizTalk Accelerator for Swift Message Pack 2019 and latest cumulative update (CU) for Message Pack

For instructions on Installing and configuring the prerequisites please refer to documentation for each of the prerequisites.

## Building Assemblies

All the buildable components are in Source directory. These need to build on a machine with BizTalk developer components and BizTalk Rule engine (BRE) installed.

- CommonFunctions
- ErrorLookup
- ErrorResources

The assemblies can be built by using the visual studio solution in repository.

The generated assemblies are placed in bin directory of Source directory.

## Deploying the new assemblies, update to schemas and BRE rule policies

The generated assemblies need to be placed in GAC for the new assemblies to work correctly. Please follow the below steps after necessary updates to assemblies, schema or BRE rules.

### Deploying updated Assemblies and Policies

Following are the steps to deploy new assemblies and update rule policies.

1. Undeploy all existing (e.g., SWIFT 2019 Message Pack) schema assemblies. In a multi-computer environment, you must manually remove these schema assemblies from the GAC on all run-time servers and the Business Activity Services (BAS)/ MRSR Site (A4Swift 2013 / A4Swift 2013 R2 / A4Swift 2016)
2. Rebuild and deploy the schema assemblies with the schemas from repo under \<repo root>\Integration\BizTalk Server\Swift\SWIFT Messages\A4SWIFT-SRG.
3. Back up the BREDeployment utility configuration file BREDeployment.exe.config from the \<drive>\Program Files\Microsoft BizTalk Accelerator for SWIFT\SDK\Tools folder.

   Open the configuration file in Notepad and modify the values of the following keys to point to the appropriate directories in the SWIFT Message Pack repo. For example:

   - \<add key="BasePoliciesDirectory" value="\<repo root>\Integration\BizTalk Server\Swift\SWIFT Messages\A4SWIFT-SRG\Base Policies" />
   - \<add key="SchemasDirectory" value="\<repo root>\Integration\BizTalk Server\Swift\SWIFT Messages\A4SWIFT-SRG" />
   - \<add key="VocabularyDirectory" value="\<repo root>\Integration\BizTalk Server\Swift\SWIFT Messages\A4SWIFT-SRG\Base Policies\Vocabulary" />
   - \<add key="LogFileName" value="C:\Documents and Settings\All Users\Application Data\BREDeploymentLog.txt" />

4. Go to \<repo root>\Integration\BizTalk Server\Swift\SWIFT Messages\A4SWIFT-SRG.

   Open the file DBConnection_Master_Policy.xml. Change the “DATABASE SERVER” and “DATABASE NAME”. Ensure that “DATABASE NAME” is the same as you have entered when configuring the Message Pack 2019.

5. Manually deploy policy DBConnection_Master_Policy.xml using the Business Rule Engine Deployment Wizard. The file path to DBConnection_Master_Policy.xml is \<repo root>\Integration\BizTalk Server\Swift\SWIFT Messages\A4SWIFT-SRG\Base Policies\.

6. Run the BRE Deployment utility and point it to the schema assemblies as in step 2. This will update the BRE policies required based on the schemas in your solution.
7. Deploy the policies using the BRE rule composer.
8. Restart the rule update service.
