﻿;WITH CTE AS
(
    SELECT convert(date, GETDATE()) sDate
    UNION ALL
    SELECT DATEADD(DAY,-1,sDate)
    FROM CTE
    WHERE sDate > GETDATE()-90
)
SELECT * FROM CTE