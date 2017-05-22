CREATE TABLE Video_Games(
	Id INT								   NOT NULL   IDENTITY (1,1),
	Title NVARCHAR(50)					   NOT NULL,
	Edition NVARCHAR(50)				   NOT NULL,
	Platform NVARCHAR(30)				   NOT NULL,
	Year INT							   NOT NULL,
	PRIMARY KEY CLUSTERED(Id)
	);
