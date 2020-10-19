------- Delete Data from MessageTransaction Table ------------

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '350' AND FN.FieldName = 'Rate' AND PT.ParentTag = 'TaxRate_D_37L')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '350' AND FN.FieldName = 'Currency' AND PT.ParentTag = 'ReportingCurrencyAndTaxAmount_D_33E')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '350' AND FN.FieldName = 'Amount' AND PT.ParentTag = 'ReportingCurrencyAndTaxAmount_D_33E')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '500' AND FN.FieldName = 'CountryCode' AND PT.ParentTag = 'Place_C1_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '500' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C1_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '501' AND FN.FieldName = 'CountryCode' AND PT.ParentTag = 'Place_C1_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '501' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C1_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '502' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '510' AND FN.FieldName = 'CountryCode' AND PT.ParentTag = 'Place_B_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '510' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Reference_E_20C')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Reference' AND PT.ParentTag = 'Reference_E_20C')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '514' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_C1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_D2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '515' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_E_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_C2_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '518' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_D_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '519' AND FN.FieldName = 'CountryCode' AND PT.ParentTag = 'Place_C1_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '519' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C1_94D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Amount_E2_19A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'SignCodeAmount' AND PT.ParentTag = 'Amount_E2_19A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Amount_D2_19A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'SignCodeAmount' AND PT.ParentTag = 'Amount_D2_19A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '567' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Amount_B_19A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '567' AND FN.FieldName = 'SignCodeAmount' AND PT.ParentTag = 'Amount_B_19A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '576' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B2c_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B2b1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '584' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_C1c1_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Qualifier' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Line1' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Line2' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Line3' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Line4' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Line5' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '586' AND FN.FieldName = 'Line6' AND PT.ParentTag = 'Narrative_B5a_70D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '700' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'LoadingonBoardDispatchTakinginChargeAtFrom_44A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '700' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'ForTransportation_44B')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '705' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'LoadingOnBoardDispatchTakingInCharge_44A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '705' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'ForTransportation_44B')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '707' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'LoadingOnBoardDispatchTakingInCharge_44A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '707' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'ForTransportation_44B')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '710' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'LoadingOnBoardDispatchTakingInCharge_44A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '710' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'ForTransportationTo_44B')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '720' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'LoadingOnBoardDispatchTakingInChargeAtFrom_44A')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '720' AND FN.FieldName = 'Narrative' AND PT.ParentTag = 'ForTransportationTo_44B')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '941' AND FN.FieldName = 'NumberCurrencyandAmount' AND PT.ParentTag = 'NumberAndSumofEntries_90D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '941' AND FN.FieldName = 'NumberCurrencyandAmount' AND PT.ParentTag = 'NumberAndSumofEntries_90C')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '942' AND FN.FieldName = 'NumberCurrencyandAmount' AND PT.ParentTag = 'NumberAndSumOfEntries_90D')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '942' AND FN.FieldName = 'NumberCurrencyandAmount' AND PT.ParentTag = 'NumberAndSumOfEntries_90C')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '992' AND FN.FieldName = 'MTNumber' AND PT.ParentTag = 'MessageTypeAndDate_11S')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '992' AND FN.FieldName = 'Date' AND PT.ParentTag = 'MessageTypeAndDate_11S')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '992' AND FN.FieldName = 'SessionNumber' AND PT.ParentTag = 'MessageTypeAndDate_11S')

Delete From MessageTransaction Where MessageTransactionID in (
Select MessageTransactionID From MessageTransaction MTRN
Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  
Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID 
Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '992' AND FN.FieldName = 'ISN' AND PT.ParentTag = 'MessageTypeAndDate_11S')


----------------------Delete From Parent Tag --------------

if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Amount_D2_19A')
 Delete From ParentTag Where ParentTag = 'Amount_D2_19A'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Amount_E2_19A')
 Delete From ParentTag Where ParentTag = 'Amount_E2_19A'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'ForTransportation_44B')
 Delete From ParentTag Where ParentTag = 'ForTransportation_44B'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'ForTransportationTo_44B')
 Delete From ParentTag Where ParentTag = 'ForTransportationTo_44B'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'LoadingOnBoardDispatchTakingInCharge_44A')
 Delete From ParentTag Where ParentTag = 'LoadingOnBoardDispatchTakingInCharge_44A'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'LoadingonBoardDispatchTakinginChargeAtFrom_44A')
 Delete From ParentTag Where ParentTag = 'LoadingonBoardDispatchTakinginChargeAtFrom_44A'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'MessageTypeAndDate_11S')
 Delete From ParentTag Where ParentTag = 'MessageTypeAndDate_11S'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Narrative_B2_70D')
 Delete From ParentTag Where ParentTag = 'Narrative_B2_70D'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Narrative_B2b1_70D')
 Delete From ParentTag Where ParentTag = 'Narrative_B2b1_70D'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Narrative_B2c_70D')
 Delete From ParentTag Where ParentTag = 'Narrative_B2c_70D'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Narrative_C1c1_70D')
 Delete From ParentTag Where ParentTag = 'Narrative_C1c1_70D'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Narrative_D2_70D')
 Delete From ParentTag Where ParentTag = 'Narrative_D2_70D'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'Narrative_E_70D')
 Delete From ParentTag Where ParentTag = 'Narrative_E_70D'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'ReportingCurrencyAndTaxAmount_D_33E')
 Delete From ParentTag Where ParentTag = 'ReportingCurrencyAndTaxAmount_D_33E'
GO
if Not exists (Select MPE.ParentTagID from MsgPatternElements MPE  Inner Join ParentTag PT ON PT.ParentTagID = MPE.ParentTagID Where PT.ParentTag = 'TaxRate_D_37L')
 Delete From ParentTag Where ParentTag = 'TaxRate_D_37L'

----------------------Delete From FieldName --------------

if Not exists (Select MPE.FieldNameID from MsgPatternElements MPE  Inner Join FieldName FN ON FN.FieldNameID = MPE.FieldNameID Where FN.FieldName = 'NumberCurrencyandAmount')
 Delete From FieldName Where FieldName = 'NumberCurrencyandAmount'
GO


-----------------Insert FieldName---------------------------


-- No New Data to Add to Field Name ----

------Insert Parent Tag ------------------------------------------
SET IDENTITY_INSERT ParentTag ON
Insert Into ParentTag(ParentTagId,ParentTag) Values (2461,'Amount_E2_19B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2462,'ApplicableRules_40E')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2463,'ApplicableRules_40F')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2464,'BrokersCommission_D2_71F')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2465,'CurrencyAndInterestAmount_D_34B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2466,'IdentificationOfFinancialInstrument_B1a_35B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2467,'IdentificationOfFinancialInstrument_B2_35B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2468,'IdentificationOfFinancialInstrument_B3_35B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2469,'IdentificationOfFinancialInstrument_C1a_35B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2470,'IdentificationOfFinancialInstrument_C3_35B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2471,'NonBankIssuer_50B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2472,'Place_B1a_94D')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2473,'Place_B3_94C')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2474,'Place_B3_94F')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2475,'Place_D1_94C')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2476,'Place_D1_94F')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2477,'PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2478,'PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2479,'PortOfDischargeAirportOfDestination_44F')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2480,'PortOfLoadingAirportOfDeparture_44E')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2481,'QuantityOfFinancialInstrument_A1_36B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2482,'ReportingCurrencyAndTaxAmount_D1_33E')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2483,'ReportingCurrencyAndTaxAmountOnBrokersCommission_D2_33E')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2484,'SecondIntermediary_86A')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2485,'SecondIntermediary_86B')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2486,'SecondIntermediary_86D')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2487,'TaxRate_D1_37L')
Insert Into ParentTag(ParentTagId,ParentTag) Values (2488,'TaxRateOnBrokersCommission_D2_37L')
SET IDENTITY_INSERT ParentTag OFF
GO 


------ Insert Message Transaction Table -------------------------------------

Declare @FieldNameID int
Declare @ParentTagID int

Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberCount_A_99B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("321",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT321_Interchange']/*[local-name()='SWIFT_CATERY3_MT321']/*[local-name()='SequenceA']/*[local-name()='NumberCount_A_99B']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Number'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberCount_A_99B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("321",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT321_Interchange']/*[local-name()='SWIFT_CATERY3_MT321']/*[local-name()='SequenceA']/*[local-name()='NumberCount_A_99B']/*[local-name()='Number']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='CurrencyAndInterestAmount_D_34B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='CurrencyAndInterestAmount_D_34B']/*[local-name()='Currency']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='CurrencyAndInterestAmount_D_34B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='CurrencyAndInterestAmount_D_34B']/*[local-name()='Amount']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Rate'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='TaxRate_D1_37L'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='TaxRate_D1_37L']/*[local-name()='Rate']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ReportingCurrencyAndTaxAmount_D1_33E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='ReportingCurrencyAndTaxAmount_D1_33E']/*[local-name()='Currency']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ReportingCurrencyAndTaxAmount_D1_33E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='ReportingCurrencyAndTaxAmount_D1_33E']/*[local-name()='Amount']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='BrokersCommission_D2_71F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='BrokersCommission_D2_71F']/*[local-name()='Currency']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='BrokersCommission_D2_71F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='BrokersCommission_D2_71F']/*[local-name()='Amount']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Rate'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='TaxRateOnBrokersCommission_D2_37L'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='TaxRateOnBrokersCommission_D2_37L']/*[local-name()='Rate']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ReportingCurrencyAndTaxAmountOnBrokersCommission_D2_33E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='ReportingCurrencyAndTaxAmountOnBrokersCommission_D2_33E']/*[local-name()='Currency']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ReportingCurrencyAndTaxAmountOnBrokersCommission_D2_33E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("350",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY3_MT350_Interchange']/*[local-name()='SWIFT_CATERY3_MT350']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='ReportingCurrencyAndTaxAmountOnBrokersCommission_D2_33E']/*[local-name()='Amount']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCodePlace'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C1_94D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='Place_C1_94D']/*[local-name()='CountryCodePlace']/*[local-name()='CountryCodePlace']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_E_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='StartOfBlock_E_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_E_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("500",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT500_Interchange']/*[local-name()='SWIFT_CATERY5_MT500']/*[local-name()='SequenceE']/*[local-name()='EndOfBlock_E_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCodePlace'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C1_94D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='Place_C1_94D']/*[local-name()='CountryCodePlace']/*[local-name()='CountryCodePlace']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_E_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='StartOfBlock_E_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_E_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("501",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT501_Interchange']/*[local-name()='SWIFT_CATERY5_MT501']/*[local-name()='SequenceE']/*[local-name()='EndOfBlock_E_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("502",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT502_Interchange']/*[local-name()='SWIFT_CATERY5_MT502']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='IdentificationOfFinancialInstrument_B3_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("502",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT502_Interchange']/*[local-name()='SWIFT_CATERY5_MT502']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='IdentificationOfFinancialInstrument_B3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("502",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT502_Interchange']/*[local-name()='SWIFT_CATERY5_MT502']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='IdentificationOfFinancialInstrument_B3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("502",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT502_Interchange']/*[local-name()='SWIFT_CATERY5_MT502']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='IdentificationOfFinancialInstrument_B3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("502",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT502_Interchange']/*[local-name()='SWIFT_CATERY5_MT502']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='IdentificationOfFinancialInstrument_B3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_D_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='StartOfBlock_D_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_D_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("503",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT503_Interchange']/*[local-name()='SWIFT_CATERY5_MT503']/*[local-name()='SequenceD']/*[local-name()='EndOfBlock_D_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_F_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='StartOfBlock_F_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_F_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='Party_F_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_F_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("504",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT504_Interchange']/*[local-name()='SWIFT_CATERY5_MT504']/*[local-name()='SequenceF']/*[local-name()='EndOfBlock_F_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_E_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='StartOfBlock_E_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_E_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("505",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT505_Interchange']/*[local-name()='SWIFT_CATERY5_MT505']/*[local-name()='SequenceE']/*[local-name()='EndOfBlock_E_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("506",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT506_Interchange']/*[local-name()='SWIFT_CATERY5_MT506']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_C_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='StartOfBlock_C_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_C_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("507",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT507_Interchange']/*[local-name()='SWIFT_CATERY5_MT507']/*[local-name()='SequenceC']/*[local-name()='EndOfBlock_C_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("508",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT508_Interchange']/*[local-name()='SWIFT_CATERY5_MT508']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("508",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT508_Interchange']/*[local-name()='SWIFT_CATERY5_MT508']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("508",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT508_Interchange']/*[local-name()='SWIFT_CATERY5_MT508']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("508",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT508_Interchange']/*[local-name()='SWIFT_CATERY5_MT508']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("508",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT508_Interchange']/*[local-name()='SWIFT_CATERY5_MT508']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_C_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='StartOfBlock_C_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_C_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("509",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT509_Interchange']/*[local-name()='SWIFT_CATERY5_MT509']/*[local-name()='SequenceC']/*[local-name()='EndOfBlock_C_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCodePlace'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B_94D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceB']/*[local-name()='Place_B_94D']/*[local-name()='CountryCodePlace']/*[local-name()='CountryCodePlace']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_C_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='StartOfBlock_C_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_C_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("510",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT510_Interchange']/*[local-name()='SWIFT_CATERY5_MT510']/*[local-name()='SequenceC']/*[local-name()='EndOfBlock_C_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC3']/*[local-name()='IdentificationOfFinancialInstrument_C3_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC3']/*[local-name()='IdentificationOfFinancialInstrument_C3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC3']/*[local-name()='IdentificationOfFinancialInstrument_C3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC3']/*[local-name()='IdentificationOfFinancialInstrument_C3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C3_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC3']/*[local-name()='IdentificationOfFinancialInstrument_C3_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Reference_E_20C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceE']/*[local-name()='Reference_E_20C']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Reference'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Reference_E_20C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("513",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT513_Interchange']/*[local-name()='SWIFT_CATERY5_MT513']/*[local-name()='SequenceE']/*[local-name()='Reference_E_20C']/*[local-name()='Reference']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("514",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT514_Interchange']/*[local-name()='SWIFT_CATERY5_MT514']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("514",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT514_Interchange']/*[local-name()='SWIFT_CATERY5_MT514']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("514",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT514_Interchange']/*[local-name()='SWIFT_CATERY5_MT514']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("514",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT514_Interchange']/*[local-name()='SWIFT_CATERY5_MT514']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("514",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT514_Interchange']/*[local-name()='SWIFT_CATERY5_MT514']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("515",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT515_Interchange']/*[local-name()='SWIFT_CATERY5_MT515']/*[local-name()='SequenceC']/*[local-name()='SequenceC2']/*[local-name()='IdentificationOfFinancialInstrument_C2_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("515",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT515_Interchange']/*[local-name()='SWIFT_CATERY5_MT515']/*[local-name()='SequenceC']/*[local-name()='SequenceC2']/*[local-name()='IdentificationOfFinancialInstrument_C2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("515",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT515_Interchange']/*[local-name()='SWIFT_CATERY5_MT515']/*[local-name()='SequenceC']/*[local-name()='SequenceC2']/*[local-name()='IdentificationOfFinancialInstrument_C2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("515",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT515_Interchange']/*[local-name()='SWIFT_CATERY5_MT515']/*[local-name()='SequenceC']/*[local-name()='SequenceC2']/*[local-name()='IdentificationOfFinancialInstrument_C2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("515",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT515_Interchange']/*[local-name()='SWIFT_CATERY5_MT515']/*[local-name()='SequenceC']/*[local-name()='SequenceC2']/*[local-name()='IdentificationOfFinancialInstrument_C2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("518",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT518_Interchange']/*[local-name()='SWIFT_CATERY5_MT518']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("518",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT518_Interchange']/*[local-name()='SWIFT_CATERY5_MT518']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("518",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT518_Interchange']/*[local-name()='SWIFT_CATERY5_MT518']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("518",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT518_Interchange']/*[local-name()='SWIFT_CATERY5_MT518']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("518",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT518_Interchange']/*[local-name()='SWIFT_CATERY5_MT518']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCodePlace'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C1_94D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='Place_C1_94D']/*[local-name()='CountryCodePlace']/*[local-name()='CountryCodePlace']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_D_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='StartOfBlock_D_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_D_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("519",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT519_Interchange']/*[local-name()='SWIFT_CATERY5_MT519']/*[local-name()='SequenceD']/*[local-name()='EndOfBlock_D_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("524",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT524_Interchange']/*[local-name()='SWIFT_CATERY5_MT524']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("524",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT524_Interchange']/*[local-name()='SWIFT_CATERY5_MT524']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("524",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT524_Interchange']/*[local-name()='SWIFT_CATERY5_MT524']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("524",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT524_Interchange']/*[local-name()='SWIFT_CATERY5_MT524']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("524",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT524_Interchange']/*[local-name()='SWIFT_CATERY5_MT524']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Status_A_25D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceA']/*[local-name()='Status_A_25D']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Status_A_25D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceA']/*[local-name()='Status_A_25D']/*[local-name()='DataSource']/*[local-name()='DataSourceScheme']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StatusCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Status_A_25D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceA']/*[local-name()='Status_A_25D']/*[local-name()='StatusCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Flag_D_17B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceD']/*[local-name()='Flag_D_17B']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Flag'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Flag_D_17B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceD']/*[local-name()='Flag_D_17B']/*[local-name()='Flag']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_E_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='StartOfBlock_E_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_E_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("527",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT527_Interchange']/*[local-name()='SWIFT_CATERY5_MT527']/*[local-name()='SequenceE']/*[local-name()='EndOfBlock_E_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("528",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT528_Interchange']/*[local-name()='SWIFT_CATERY5_MT528']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("528",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT528_Interchange']/*[local-name()='SWIFT_CATERY5_MT528']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("528",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT528_Interchange']/*[local-name()='SWIFT_CATERY5_MT528']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("528",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT528_Interchange']/*[local-name()='SWIFT_CATERY5_MT528']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("528",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT528_Interchange']/*[local-name()='SWIFT_CATERY5_MT528']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("529",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT529_Interchange']/*[local-name()='SWIFT_CATERY5_MT529']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("529",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT529_Interchange']/*[local-name()='SWIFT_CATERY5_MT529']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("529",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT529_Interchange']/*[local-name()='SWIFT_CATERY5_MT529']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("529",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT529_Interchange']/*[local-name()='SWIFT_CATERY5_MT529']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("529",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT529_Interchange']/*[local-name()='SWIFT_CATERY5_MT529']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B1a_94D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='Place_B1a_94D']/*[local-name()='Qualifier']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCodePlace'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B1a_94D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='Place_B1a_94D']/*[local-name()='CountryCodePlace']/*[local-name()='CountryCodePlace']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='IdentificationOfFinancialInstrument_B1a_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='IdentificationOfFinancialInstrument_B1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='IdentificationOfFinancialInstrument_B1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='IdentificationOfFinancialInstrument_B1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("535",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT535_Interchange']/*[local-name()='SWIFT_CATERY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1a']/*[local-name()='IdentificationOfFinancialInstrument_B1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("538",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT538_Interchange']/*[local-name()='SWIFT_CATERY5_MT538']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("538",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT538_Interchange']/*[local-name()='SWIFT_CATERY5_MT538']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("538",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT538_Interchange']/*[local-name()='SWIFT_CATERY5_MT538']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("538",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT538_Interchange']/*[local-name()='SWIFT_CATERY5_MT538']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("538",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT538_Interchange']/*[local-name()='SWIFT_CATERY5_MT538']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='QuantityTypeCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='QuantityTypeCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Quantity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='Quantity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("540",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT540_Interchange']/*[local-name()='SWIFT_CATERY5_MT540']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='QuantityTypeCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='QuantityTypeCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Quantity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='Quantity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("541",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT541_Interchange']/*[local-name()='SWIFT_CATERY5_MT541']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='QuantityTypeCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='QuantityTypeCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Quantity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='Quantity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("542",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT542_Interchange']/*[local-name()='SWIFT_CATERY5_MT542']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='QuantityTypeCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='QuantityTypeCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Quantity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='QuantityOfFinancialInstrument_A1_36B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceA']/*[local-name()='SequenceA1']/*[local-name()='QuantityOfFinancialInstrument_A1_36B']/*[local-name()='QuantityOfFinancialInstrument']/*[local-name()='Quantity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("543",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT543_Interchange']/*[local-name()='SWIFT_CATERY5_MT543']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("544",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT544_Interchange']/*[local-name()='SWIFT_CATERY5_MT544']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("544",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT544_Interchange']/*[local-name()='SWIFT_CATERY5_MT544']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("544",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT544_Interchange']/*[local-name()='SWIFT_CATERY5_MT544']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("544",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT544_Interchange']/*[local-name()='SWIFT_CATERY5_MT544']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("544",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT544_Interchange']/*[local-name()='SWIFT_CATERY5_MT544']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("545",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT545_Interchange']/*[local-name()='SWIFT_CATERY5_MT545']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("545",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT545_Interchange']/*[local-name()='SWIFT_CATERY5_MT545']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("545",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT545_Interchange']/*[local-name()='SWIFT_CATERY5_MT545']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("545",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT545_Interchange']/*[local-name()='SWIFT_CATERY5_MT545']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("545",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT545_Interchange']/*[local-name()='SWIFT_CATERY5_MT545']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("546",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT546_Interchange']/*[local-name()='SWIFT_CATERY5_MT546']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("546",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT546_Interchange']/*[local-name()='SWIFT_CATERY5_MT546']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("546",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT546_Interchange']/*[local-name()='SWIFT_CATERY5_MT546']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("546",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT546_Interchange']/*[local-name()='SWIFT_CATERY5_MT546']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("546",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT546_Interchange']/*[local-name()='SWIFT_CATERY5_MT546']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("547",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT547_Interchange']/*[local-name()='SWIFT_CATERY5_MT547']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("547",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT547_Interchange']/*[local-name()='SWIFT_CATERY5_MT547']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("547",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT547_Interchange']/*[local-name()='SWIFT_CATERY5_MT547']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("547",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT547_Interchange']/*[local-name()='SWIFT_CATERY5_MT547']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("547",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT547_Interchange']/*[local-name()='SWIFT_CATERY5_MT547']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Function'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='FunctionOfTheMessage_A_23G'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='FunctionOfTheMessage_A_23G']/*[local-name()='Function']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Subfunction'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='FunctionOfTheMessage_A_23G'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='FunctionOfTheMessage_A_23G']/*[local-name()='Subfunction']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_A1_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='StartOfBlock_A1_16R']/*[local-name()='StartOfBlock']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberIdentification_A1_13A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='NumberIdentification_A1_13A']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='NumberId'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberIdentification_A1_13A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='NumberIdentification_A1_13A']/*[local-name()='NumberId']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberIdentification_A1_13B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='NumberIdentification_A1_13B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberIdentification_A1_13B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='NumberIdentification_A1_13B']/*[local-name()='DataSource']/*[local-name()='DataSourceScheme']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Number_13B'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Number_13B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='NumberIdentification_A1_13B']/*[local-name()='Number_13B']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Reference_A1_20C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='Reference_A1_20C']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Reference'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Reference_A1_20C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='Reference_A1_20C']/*[local-name()='Reference']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_A1_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("549",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT549_Interchange']/*[local-name()='SWIFT_CATERY5_MT549']/*[local-name()='SequenceA']/*[local-name()='Sequence_A1']/*[local-name()='EndOfBlock_A1_16S']/*[local-name()='EndOfBlock']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_E_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='StartOfBlock_E_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_E_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='Party_E_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_E_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("558",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT558_Interchange']/*[local-name()='SWIFT_CATERY5_MT558']/*[local-name()='SequenceE']/*[local-name()='EndOfBlock_E_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_E2_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("564",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT564_Interchange']/*[local-name()='SWIFT_CATERY5_MT564']/*[local-name()='SequenceE']/*[local-name()='SequenceE2']/*[local-name()='Amount_E2_19B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CurrencyCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_E2_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("564",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT564_Interchange']/*[local-name()='SWIFT_CATERY5_MT564']/*[local-name()='SequenceE']/*[local-name()='SequenceE2']/*[local-name()='Amount_E2_19B']/*[local-name()='Amount']/*[local-name()='CurrencyCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_E2_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("564",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT564_Interchange']/*[local-name()='SWIFT_CATERY5_MT564']/*[local-name()='SequenceE']/*[local-name()='SequenceE2']/*[local-name()='Amount_E2_19B']/*[local-name()='Amount']/*[local-name()='Amount']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94C']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94C']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94B']/*[local-name()='DataSource']/*[local-name()='DataSourceScheme']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94B']/*[local-name()='PlaceCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative_94B'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94B']/*[local-name()='Narrative_94B']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94F']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Place'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94F']/*[local-name()='Place']/*[local-name()='Place']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_D1_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Place_D1_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_D2_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='Amount_D2_19B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CurrencyCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_D2_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='Amount_D2_19B']/*[local-name()='Amount']/*[local-name()='CurrencyCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_D2_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("566",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT566_Interchange']/*[local-name()='SWIFT_CATERY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD2']/*[local-name()='Amount_D2_19B']/*[local-name()='Amount']/*[local-name()='Amount']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_B_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Amount_B_19B']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CurrencyCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_B_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Amount_B_19B']/*[local-name()='Amount']/*[local-name()='CurrencyCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_B_19B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Amount_B_19B']/*[local-name()='Amount']/*[local-name()='Amount']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Balance_B_93B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Balance_B_93B']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Balance_B_93B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Balance_B_93B']/*[local-name()='DataSource']/*[local-name()='DataSourceScheme']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='QuantityTypeCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Balance_B_93B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Balance_B_93B']/*[local-name()='QuantityTypeCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='SignBalance'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Balance_B_93B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("567",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT567_Interchange']/*[local-name()='SWIFT_CATERY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Balance_B_93B']/*[local-name()='SignBalance']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Function'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='FunctionOfTheMessage_A_23G'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceA']/*[local-name()='FunctionOfTheMessage_A_23G']/*[local-name()='Function']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Subfunction'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='FunctionOfTheMessage_A_23G'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceA']/*[local-name()='FunctionOfTheMessage_A_23G']/*[local-name()='Subfunction']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("569",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT569_Interchange']/*[local-name()='SWIFT_CATERY5_MT569']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_IRSLST",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_IRSLST_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_IRSLST']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("574_W8BENO",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT574_W8BENO_Interchange']/*[local-name()='SWIFT_CATERY5_MT574_W8BENO']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_B2_19A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='Amount_B2_19A']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='SignCodeAmount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Amount_B2_19A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='Amount_B2_19A']/*[local-name()='SignCodeAmount']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_C_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='StartOfBlock_C_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_C_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='Party_C_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_C_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("576",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT576_Interchange']/*[local-name()='SWIFT_CATERY5_MT576']/*[local-name()='SequenceC']/*[local-name()='EndOfBlock_C_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='DataSource']/*[local-name()='DataSourceScheme']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative_94B'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='Narrative']/*[local-name()='Narrative_94B']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94C']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94C']/*[local-name()='CountryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94F']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Place'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94F']/*[local-name()='Place']/*[local-name()='Place']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_C_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("578",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT578_Interchange']/*[local-name()='SWIFT_CATERY5_MT578']/*[local-name()='SequenceC']/*[local-name()='Place_C_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B1_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='IdentificationOfFinancialInstrument_B1_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='SequenceC1a']/*[local-name()='IdentificationOfFinancialInstrument_C1a_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='SequenceC1a']/*[local-name()='IdentificationOfFinancialInstrument_C1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='SequenceC1a']/*[local-name()='IdentificationOfFinancialInstrument_C1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='SequenceC1a']/*[local-name()='IdentificationOfFinancialInstrument_C1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_C1a_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='SequenceC1a']/*[local-name()='IdentificationOfFinancialInstrument_C1a_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='StartOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='StartOfBlock_D_16R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='StartOfBlock_D_16R']/*[local-name()='StartOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95P'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95P']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='DataSourceScheme']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ProprietaryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95R'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95R']/*[local-name()='ProprietaryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Party_D_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='Qualifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line1']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line2']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line3']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NameAndAddress_95Q'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='Party_D_95Q']/*[local-name()='NameAndAddress_95Q']/*[local-name()='Line4']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='EndOfBlock'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='EndOfBlock_D_16S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("584",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT584_Interchange']/*[local-name()='SWIFT_CATERY5_MT584']/*[local-name()='SequenceD']/*[local-name()='EndOfBlock_D_16S']/*[local-name()='EndOfBlock']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='IdentificationOfSecurity'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='IdentificationOfSecurity']/*[local-name()='IdentificationOfSecurity']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line1']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line2']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line3']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='IdentificationOfFinancialInstrument_B2_35B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='IdentificationOfFinancialInstrument_B2_35B']/*[local-name()='DescriptionOfSecurity']/*[local-name()='Line4']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94B']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='DataSourceScheme'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94B']/*[local-name()='DataSource']/*[local-name()='DataSourceScheme']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94B']/*[local-name()='PlaceCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative_94B'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_94B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94B']/*[local-name()='Narrative']/*[local-name()='Narrative_94B']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94C']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94C']/*[local-name()='CountryCode']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94F']/*[local-name()='Qualifier']",5)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Place'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94F']/*[local-name()='Place']/*[local-name()='Place']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Place_B3_94F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB3']/*[local-name()='Place_B3_94F']/*[local-name()='Place']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Qualifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Qualifier']",6)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Narrative']/*[local-name()='Line1']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Narrative']/*[local-name()='Line2']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Narrative']/*[local-name()='Line3']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Narrative']/*[local-name()='Line4']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line5'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Narrative']/*[local-name()='Line5']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line6'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='Narrative_B5a_70D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("586",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY5_MT586_Interchange']/*[local-name()='SWIFT_CATERY5_MT586']/*[local-name()='SequenceB']/*[local-name()='SequenceB5']/*[local-name()='SequenceB5a']/*[local-name()='Narrative_B5a_70D']/*[local-name()='Narrative']/*[local-name()='Line6']",7)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Identifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86A']/*[local-name()='PartyIdentifier']/*[local-name()='Identifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BankCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86A']/*[local-name()='BankIdentifierCode']/*[local-name()='BankCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='CountryCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86A']/*[local-name()='BankIdentifierCode']/*[local-name()='CountryCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='AreaCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86A']/*[local-name()='BankIdentifierCode']/*[local-name()='AreaCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='BranchCode'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86A']/*[local-name()='BankIdentifierCode']/*[local-name()='BranchCode']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Identifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86B']/*[local-name()='PartyIdentifier']/*[local-name()='Identifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Location'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86B']/*[local-name()='Location']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Identifier'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86D']/*[local-name()='PartyIdentifier']/*[local-name()='Identifier']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86D']/*[local-name()='NameAndAddress']/*[local-name()='Line1']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86D']/*[local-name()='NameAndAddress']/*[local-name()='Line2']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86D']/*[local-name()='NameAndAddress']/*[local-name()='Line3']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='SecondIntermediary_86D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("604",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY6_MT604_Interchange']/*[local-name()='SWIFT_CATERY6_MT604']/*[local-name()='SecondIntermediary_86D']/*[local-name()='NameAndAddress']/*[local-name()='Line4']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Type'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("700",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT700_Interchange']/*[local-name()='SWIFT_CATERY7_MT700']/*[local-name()='ApplicableRules_40E']/*[local-name()='Type']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("700",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT700_Interchange']/*[local-name()='SWIFT_CATERY7_MT700']/*[local-name()='ApplicableRules_40E']/*[local-name()='Narrative']/*[local-name()='Narrative']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("700",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT700_Interchange']/*[local-name()='SWIFT_CATERY7_MT700']/*[local-name()='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfLoadingAirportOfDeparture_44E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("700",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT700_Interchange']/*[local-name()='SWIFT_CATERY7_MT700']/*[local-name()='PortOfLoadingAirportOfDeparture_44E']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfDischargeAirportOfDestination_44F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("700",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT700_Interchange']/*[local-name()='SWIFT_CATERY7_MT700']/*[local-name()='PortOfDischargeAirportOfDestination_44F']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("700",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT700_Interchange']/*[local-name()='SWIFT_CATERY7_MT700']/*[local-name()='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("705",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT705_Interchange']/*[local-name()='SWIFT_CATERY7_MT705']/*[local-name()='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfLoadingAirportOfDeparture_44E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("705",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT705_Interchange']/*[local-name()='SWIFT_CATERY7_MT705']/*[local-name()='PortOfLoadingAirportOfDeparture_44E']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfDischargeAirportOfDestination_44F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("705",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT705_Interchange']/*[local-name()='SWIFT_CATERY7_MT705']/*[local-name()='PortOfDischargeAirportOfDestination_44F']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("705",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT705_Interchange']/*[local-name()='SWIFT_CATERY7_MT705']/*[local-name()='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("707",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT707_Interchange']/*[local-name()='SWIFT_CATERY7_MT707']/*[local-name()='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfLoadingAirportOfDeparture_44E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("707",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT707_Interchange']/*[local-name()='SWIFT_CATERY7_MT707']/*[local-name()='PortOfLoadingAirportOfDeparture_44E']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfDischargeAirportOfDestination_44F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("707",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT707_Interchange']/*[local-name()='SWIFT_CATERY7_MT707']/*[local-name()='PortOfDischargeAirportOfDestination_44F']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("707",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT707_Interchange']/*[local-name()='SWIFT_CATERY7_MT707']/*[local-name()='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Type'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='ApplicableRules_40E']/*[local-name()='Type']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='ApplicableRules_40E']/*[local-name()='Narrative']/*[local-name()='Narrative']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line1']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line2']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line3']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line4']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfLoadingAirportOfDeparture_44E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='PortOfLoadingAirportOfDeparture_44E']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfDischargeAirportOfDestination_44F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='PortOfDischargeAirportOfDestination_44F']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("710",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT710_Interchange']/*[local-name()='SWIFT_CATERY7_MT710']/*[local-name()='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Type'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='ApplicableRules_40E']/*[local-name()='Type']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='ApplicableRules_40E']/*[local-name()='Narrative']/*[local-name()='Narrative']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line1'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line1']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line2'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line2']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line3'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line3']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line4'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NonBankIssuer_50B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='NonBankIssuer_50B']/*[local-name()='Line4']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='PlaceOfTakingInChargeDispatchFromPlaceOfReceipt_44A']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfLoadingAirportOfDeparture_44E'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='PortOfLoadingAirportOfDeparture_44E']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PortOfDischargeAirportOfDestination_44F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='PortOfDischargeAirportOfDestination_44F']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Narrative'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("720",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT720_Interchange']/*[local-name()='SWIFT_CATERY7_MT720']/*[local-name()='PlaceForFinalDestinationForTransportationToPlaceOfDelivery_44B']/*[local-name()='Narrative']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Type'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='ApplicableRules_40F'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("740",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT740_Interchange']/*[local-name()='SWIFT_CATERY7_MT740']/*[local-name()='ApplicableRules_40F']/*[local-name()='Type']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line93'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='DetailsOfGuarantee_77C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("760",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT760_Interchange']/*[local-name()='SWIFT_CATERY7_MT760']/*[local-name()='DetailsOfGuarantee_77C']/*[local-name()='Line93']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Line93'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='AmendmentDetails_77C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("767",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY7_MT767_Interchange']/*[local-name()='SWIFT_CATERY7_MT767']/*[local-name()='AmendmentDetails_77C']/*[local-name()='Line93']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Number'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumofEntries_90D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("941",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT941_Interchange']/*[local-name()='SWIFT_CATERY9_MT941']/*[local-name()='NumberAndSumofEntries_90D']/*[local-name()='Number']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumofEntries_90D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("941",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT941_Interchange']/*[local-name()='SWIFT_CATERY9_MT941']/*[local-name()='NumberAndSumofEntries_90D']/*[local-name()='Currency']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumofEntries_90D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("941",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT941_Interchange']/*[local-name()='SWIFT_CATERY9_MT941']/*[local-name()='NumberAndSumofEntries_90D']/*[local-name()='Amount']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Number'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumofEntries_90C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("941",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT941_Interchange']/*[local-name()='SWIFT_CATERY9_MT941']/*[local-name()='NumberAndSumofEntries_90C']/*[local-name()='Number']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumofEntries_90C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("941",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT941_Interchange']/*[local-name()='SWIFT_CATERY9_MT941']/*[local-name()='NumberAndSumofEntries_90C']/*[local-name()='Currency']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumofEntries_90C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("941",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT941_Interchange']/*[local-name()='SWIFT_CATERY9_MT941']/*[local-name()='NumberAndSumofEntries_90C']/*[local-name()='Amount']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Number'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumOfEntries_90D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("942",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT942_Interchange']/*[local-name()='SWIFT_CATERY9_MT942']/*[local-name()='NumberAndSumOfEntries_90D']/*[local-name()='Number']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumOfEntries_90D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("942",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT942_Interchange']/*[local-name()='SWIFT_CATERY9_MT942']/*[local-name()='NumberAndSumOfEntries_90D']/*[local-name()='Currency']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumOfEntries_90D'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("942",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT942_Interchange']/*[local-name()='SWIFT_CATERY9_MT942']/*[local-name()='NumberAndSumOfEntries_90D']/*[local-name()='Amount']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Number'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumOfEntries_90C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("942",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT942_Interchange']/*[local-name()='SWIFT_CATERY9_MT942']/*[local-name()='NumberAndSumOfEntries_90C']/*[local-name()='Number']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Currency'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumOfEntries_90C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("942",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT942_Interchange']/*[local-name()='SWIFT_CATERY9_MT942']/*[local-name()='NumberAndSumOfEntries_90C']/*[local-name()='Currency']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Amount'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='NumberAndSumOfEntries_90C'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("942",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT942_Interchange']/*[local-name()='SWIFT_CATERY9_MT942']/*[local-name()='NumberAndSumOfEntries_90C']/*[local-name()='Amount']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='MTNumber'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='MTAndDateOfTheOriginalMessage_11S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("992",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT992_Interchange']/*[local-name()='SWIFT_CATERY9_MT992']/*[local-name()='MTAndDateOfTheOriginalMessage_11S']/*[local-name()='MTNumber']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='MTAndDateOfTheOriginalMessage_11S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("992",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT992_Interchange']/*[local-name()='SWIFT_CATERY9_MT992']/*[local-name()='MTAndDateOfTheOriginalMessage_11S']/*[local-name()='Date']",3)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='SessionNumber'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='MTAndDateOfTheOriginalMessage_11S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("992",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT992_Interchange']/*[local-name()='SWIFT_CATERY9_MT992']/*[local-name()='MTAndDateOfTheOriginalMessage_11S']/*[local-name()='SessionNumberISN']/*[local-name()='SessionNumber']",4)	 
SET QUOTED_IDENTIFIER ON	 
 
 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='ISN'	 
Select @ParentTagID = ParentTagID From ParentTag Where ParentTag='MTAndDateOfTheOriginalMessage_11S'	 
SET QUOTED_IDENTIFIER OFF 
Insert Into MessageTransaction(MsgTypeID,FieldNameID,ParentTagID,XPath,Depth)	
Values ("992",@FieldNameID,@ParentTagID,"/*[local-name()='SWIFT_CATERY9_MT992_Interchange']/*[local-name()='SWIFT_CATERY9_MT992']/*[local-name()='MTAndDateOfTheOriginalMessage_11S']/*[local-name()='SessionNumberISN']/*[local-name()='ISN']",4)	 
SET QUOTED_IDENTIFIER ON	 
GO
 
--------------------------Update Message Transaction-------------

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT513_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='Period_C1_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_C1_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT513_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT513']/*[local-name()='SequenceC']/*[local-name()='SequenceC1']/*[local-name()='Period_C1_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '513' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_C1_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT524_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT524']/*[local-name()='SequenceB']/*[local-name()='Place_B_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '524' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT528_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT528']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '528' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT529_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT529']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '529' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT535_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT535']/*[local-name()='SequenceB']/*[local-name()='Place_B_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '535' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT535_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT535']/*[local-name()='SequenceB']/*[local-name()='SequenceB1']/*[local-name()='SequenceB1b']/*[local-name()='Place_B1b_94B']/*[local-name()='PlaceCode']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '535' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B1b_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT536_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT536']/*[local-name()='SequenceA']/*[local-name()='Period_A_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '536' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_A_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT536_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT536']/*[local-name()='SequenceA']/*[local-name()='Period_A_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '536' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_A_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT538_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT538']/*[local-name()='SequenceA']/*[local-name()='Period_A_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '538' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_A_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT538_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT538']/*[local-name()='SequenceA']/*[local-name()='Period_A_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '538' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_A_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT540_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT540']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '540' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT541_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT541']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '541' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT542_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT542']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '542' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT543_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT543']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '543' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT544_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT544']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '544' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT545_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT545']/*[local-name()='SequenceC']/*[local-name()='Place_C_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '545' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_C_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceB']/*[local-name()='SequenceB2']/*[local-name()='Place_B2_94B']/*[local-name()='PlaceCode']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B2_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceC']/*[local-name()='Period_C_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_C_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceC']/*[local-name()='Period_C_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_C_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceD']/*[local-name()='Period_D_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_D_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceD']/*[local-name()='Period_D_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_D_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceE']/*[local-name()='Period_E_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_E_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceE']/*[local-name()='Period_E_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_E_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceE']/*[local-name()='SequenceE1']/*[local-name()='Period_E1_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_E1_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT564_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT564']/*[local-name()='SequenceE']/*[local-name()='SequenceE1']/*[local-name()='Period_E1_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '564' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_E1_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceB']/*[local-name()='Place_B_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceC']/*[local-name()='Period_C_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_C_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceC']/*[local-name()='Period_C_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_C_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceD']/*[local-name()='Period_D_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_D_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceD']/*[local-name()='Period_D_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_D_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Period_D1_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_D1_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT566_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT566']/*[local-name()='SequenceD']/*[local-name()='SequenceD1']/*[local-name()='Period_D1_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 6 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '566' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_D1_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT567_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT567']/*[local-name()='SequenceB']/*[local-name()='Place_B_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '567' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='PlaceCode' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT568_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT568']/*[local-name()='SequenceB']/*[local-name()='Place_B_94B']/*[local-name()='PlaceCode']",
Depth = 4 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '568' AND FN.FieldName = 'Place' AND PT.ParentTag = 'Place_B_94B')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date1' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT575_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT575']/*[local-name()='SequenceA']/*[local-name()='Period_A_69A']/*[local-name()='Period']/*[local-name()='Date1']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '575' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_A_69A')	
SET QUOTED_IDENTIFIER ON
GO 

Declare @FieldNameID int 
Select @FieldNameID = FieldNameID From FieldName Where FieldName='Date2' 
SET  QUOTED_IDENTIFIER OFF 
Update MessageTransaction 
SET   FieldNameID = @FieldNameID, 
XPath ="/*[local-name()='SWIFT_CATEGORY5_MT575_Interchange']/*[local-name()='SWIFT_CATEGORY5_MT575']/*[local-name()='SequenceA']/*[local-name()='Period_A_69A']/*[local-name()='Period']/*[local-name()='Date2']",
Depth = 5 Where MessageTransactionID = 
(Select TOP 1 MTRN.MessageTransactionID From MessageTransaction MTRN Inner Join MsgType MT on MTRN.MsgTypeID = MT.MsgTypeID  Inner Join ParentTag PT ON MTRN.ParentTagID = PT.ParentTagID Inner Join FieldName FN ON MTRN.FieldNameID = FN.FieldNameID Where MT.MsgTypeID = '575' AND FN.FieldName = 'Date' AND PT.ParentTag = 'Period_A_69A')	
SET QUOTED_IDENTIFIER ON
GO 







