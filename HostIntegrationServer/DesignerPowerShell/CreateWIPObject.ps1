# Sample script to create a TI WIP Object for ELM User Data, add a method and parameters, and save the hidx file
"Turn on PowerShell tracing to display each line"
Set-PSDebug -Trace 1
" Create the WIP object - this is for ELM User Data. Note that the C:\lab folder must exist."
$WIPhidx = New-HisWipHidxFile -ElmUserData -Name MyNamespace -Interface IMyInterface -Description "My Description" -File C:\Lab\WIPSample.hidx
#Display the object and its members
$WIPhidx
Read-Host -Prompt "Press Enter to continue"
" Add a method to the WIPhidx object"
$WIPMethod = Add-HisHidxElement -InputObject $WIPhidx -Method -Name GetAccounts
$WIPMethod
Read-Host -Prompt "Press Enter to continue"
" Add a parameter to the method, set it as input, string, 30 characters"
$NameParameter = $WIPMethod | Add-HisHidxParameter -Name CustomerName -Atomic
$NameParameter.Direction = "In"
$NameParameter.DataType = "String"
$NameParameter.ConversionInformation.Size = 30
$NameParameter
Read-Host -Prompt "Press Enter to continue"
" Add another parameter, set it as input, string, 6 characters"
$AccountParameter = $WIPMethod | Add-HisHidxParameter -Name AccountNum -Atomic
$AccountParameter.Direction = "In"
$AccountParameter.DataType = "String"
$AccountParameter.ConversionInformation.Size = 6
$AccountParameter
Read-Host -Prompt "Press Enter to continue"
" Add a third parameter, set it as output, decimal, PIC S9(7)V99"
$BalanceParameter = $WIPMethod | Add-HisHidxParameter -Name Balance -Atomic
$BalanceParameter.Direction = "Out"
$BalanceParameter.DataType = "Decimal"
$BalanceParameter.ConversionInformation.HostDataType = "PIC S9(n)V9(n) COMP-3"
$BalanceParameter.ConversionInformation.Precision = 7
$BalanceParameter.ConversionInformation.Scale = 2
$BalanceParameter
Read-Host -Prompt "Press Enter to continue"
" Save the hidx file"
$WIPhidx.Save()
Set-PSDebug -Off
"PowerShell tracing turned off"