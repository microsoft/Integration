!INCLUDE $(INETROOT)\build\makefile.inc

CreateResources: $(RESX_FILES)
		resgen.exe /compile $(RESX_FILES)

Make_BTAHC_SatelliteDlls: $(TARGET) $(RESX_RESOURCES)
!IF "$(DOLINK)" == ""
!	IF !EXIST("$(O)\en-US")
	mkdir $(O)\en-US
!	ENDIF
	al.exe /culture:en-US /out:"$(O)\en-US\$(BTAHC_SATELLITEDLL)" /target:library /template:"$(TARGET)" $(RESX_SOURCES:/res:=/embed:)
!ENDIF


#copybin:
#   md .\bin\en-US
#   copy /y $(O)\Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.pdb .\bin\Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.pdb
#   copy /y $(O)\Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.dll .\bin\Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.dll
#   copy /y $(O)\en-US\Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.resources.dll .\bin\en-US\Microsoft.Solutions.FinancialServices.SWIFT.CommonFunctions.resources.dll
