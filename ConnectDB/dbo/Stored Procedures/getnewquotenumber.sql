﻿/****** Script for SelectTopNRows command from SSMS  ******/
create procedure getnewquotenumber
as
select max(quote) + 1 as NextQuoteNo
from
(SELECT *
 FROM [SPM_Database].[dbo].[Opportunities]
 where  LEN([Quote]) >= 4 and ISNUMERIC(Quote) = 1)a