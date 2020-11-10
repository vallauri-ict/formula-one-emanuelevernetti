CREATE TABLE [dbo].[Race] (
  [id] int PRIMARY KEY,
  [raceName] varchar(255) NOT NULL,
  [raceLapsNumber] int NOT NULL,
  [raceDate] date NOT NULL,
  [circuitId] int NOT NULL
);