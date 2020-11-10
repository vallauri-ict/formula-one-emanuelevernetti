CREATE TABLE [Result] (
  [id] int UNIQUE,
  [raceid] int,
  [driverId] int NOT NULL,
  [teamId] int NOT NULL,
  [driverTime] varchar(255) NOT NULL,
  [driverPosition] int NOT NULL,
  [driverFastestLap] varchar(255) DEFAULT (null),
  PRIMARY KEY ([raceid], [driverId])
);