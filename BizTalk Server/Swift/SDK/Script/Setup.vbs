Dim wshShell

Set wshShell = CreateObject("Wscript.Shell")
Set wshSysEnv = wshShell.Environment("PROCESS")
dbServer = WScript.Arguments.Item(0)

creTab = "cmd /c OSQL -E -i DBref_CreateTables.sql" & " -S " & dbServer
fillCount = "cmd /c OSQL -E -i DBRef_FillCountryData.sql" & " -S " & dbServer
fillCurr = "cmd /c OSQL -E -i DBRef_FillCurrencyData.sql" & " -S " & dbServer
fillLegc = "cmd /c OSQL -E -i DBRef_FillLegacyCurrencyData.sql" & " -S " & dbServer


wshShell.Run creTab, 1, true
wshShell.Run fillCount, 1, true
wshShell.Run fillCurr, 1, true
wshShell.Run fillLegc, 1, true


Set wshShell = Nothing