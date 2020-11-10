CREATE TABLE [dbo].[Race] (
  [id] int PRIMARY KEY,
  [raceName] varchar(255) NOT NULL,
  [raceStartDate] date NOT NULL,
  [raceEndDate] date NOT NULL,
  [circuitId] int NOT NULL
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  1,
  'Formula 1 Rolex Grosser Preis Von Österreich 2020',
  CONVERT(date,'2020-07-03'),
  CONVERT(date,'2020-07-05'),
  1
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  2,
  'Formula 1 Pirelli Grosser Preis Der Steiermark 2020',
  CONVERT(date,'2020-07-10'),
  CONVERT(date,'2020-07-12'),
  1
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  3,
  'Formula 1 Aramco Magyar Nagydíj 2020',
  CONVERT(date,'2020-07-17'),
  CONVERT(date,'2020-07-19'),
  2
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  4,
  'Formula 1 Pirelli British Grand Prix 2020',
  CONVERT(date,'2020-07-31'),
  CONVERT(date,'2020-08-02'),
  3
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  5,
  'Emirates Formula 1 70th Anniversary Grand Prix 2020',
  CONVERT(date,'2020-08-07'),
  CONVERT(date,'2020-08-09'),
  3
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  6,
  'Formula 1 Aramco Gran Premio De España 2020',
  CONVERT(date,'2020-08-14'),
  CONVERT(date,'2020-08-16'),
  4
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  7,
  'Formula 1 Rolex Belgian Grand Prix 2020',
  CONVERT(date,'2020-08-28'),
  CONVERT(date,'2020-08-30'),
  5
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  8,
  'Formula 1 Gran Premio Heineken D’italia 2020',
  CONVERT(date,'2020-09-04'),
  CONVERT(date,'2020-09-06'),
  6
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  9,
  'Formula 1 Pirelli Gran Premio Della Toscana Ferrari 1000 2020',
  CONVERT(date,'2020-09-11'),
  CONVERT(date,'2020-09-13'),
  7
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  10,
  'Formula 1 VTB Russian Grand Prix 2020',
  CONVERT(date,'2020-09-25'),
  CONVERT(date,'2020-09-27'),
  8
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  11,
  'Formula 1 Aramco Grosser Preis Der Eifel 2020',
  CONVERT(date,'2020-10-09'),
  CONVERT(date,'2020-10-11'),
  9
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  12,
  'Formula 1 Heineken Grande Prémio De Portugal 2020',
  CONVERT(date,'2020-10-23'),
  CONVERT(date,'2020-10-25'),
  10
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  13,
  'Formula 1 Emirates Gran Premio Dellemilia Romagna 2020',
  CONVERT(date,'2020-10-30'),
  CONVERT(date,'2020-11-01'),
  11
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  14,
  'Formula 1 DHL Turkish Grand Prix 2020',
  CONVERT(date,'2020-11-12'),
  CONVERT(date,'2020-11-15'),
  12
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  15,
  'Formula 1 Gulf Air Bahrain Grand Prix 2020',
  CONVERT(date,'2020-11-26'),
  CONVERT(date,'2020-11-29'),
  13
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  16,
  'Formula 1 Rolex Sakhir Grand Prix 2020',
  CONVERT(date,'2020-12-03'),
  CONVERT(date,'2020-12-06'),
  14
);

INSERT INTO [Race] (id, raceName, raceStartDate, raceEndDate, circuitId) VALUES(
  17,
  'Formula 1 Etihad Airways Abu Dhabi Grand Prix 2020',
  CONVERT(date,'2020-12-10'),
  CONVERT(date,'2020-12-13'),
  15
);





