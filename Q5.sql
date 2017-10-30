DECLARE @t TABLE(Id INT, Number INT);

INSERT INTO @t VALUES
(1,37),
(2,14),
(3,99),
(4,12),
(5,7);


Select t1.Id, t1.Number N1, (t1.Number + t2.Number) Result
From @t t1
LEFT Join @t t2
On t1.Id=(t2.Id - 1)
