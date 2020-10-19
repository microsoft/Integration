
GO
ALTER TABLE [LegacyCurrencyCode_List] NOCHECK CONSTRAINT ALL
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('ATS','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('BEF','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('DEM','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('ESP','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('FIM','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('FRF','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('GRD','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('IEP','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('ITL','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('LUF','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('NLG','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('PTE','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('XEU','12/31/2001')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('SIT','12/31/2006')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('CYP','12/31/2007')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('MTL','12/31/2007')
GO
INSERT INTO [LegacyCurrencyCode_List]([CurrencyCode],[ValidDate])  VALUES('SKK','12/31/2008')
GO
ALTER TABLE [LegacyCurrencyCode_List] CHECK CONSTRAINT ALL
GO