CREATE TABLE [Result] (
  [id] int UNIQUE,
  [raceid] int,
  [driverId] int NOT NULL,
  [teamId] int NOT NULL,
  [driverTime] varchar(255) DEFAULT (null),
  [driverPosition] int DEFAULT (0),
  [driverLaps] int DEFAULT (0),
  [driverFastestLap] int DEFAULT (0),
  PRIMARY KEY ([raceid], [driverId], [driverPosition])
);

INSERT INTO [Result] VALUES(
  1,
  1,
  2,
  1,
  '1:30:55.739',
  1,
  71,
  68
);

INSERT INTO [Result] VALUES(
  2,
  1,
  5,
  6,
  '1:30:58.439',
  2,
  71,
  64
);

INSERT INTO [Result] VALUES(
  3,
  1,
  7,
  3,
  '1:30:61.230',
  3,
  71,
  71
);

INSERT INTO [Result] VALUES(
  4,
  1,
  1,
  1,
  '1:30:61.428',
  4,
  71,
  67
);

INSERT INTO [Result] VALUES(
  5,
  1,
  8,
  3,
  '1:30:64.642',
  5,
  71,
  63
);

INSERT INTO [Result] VALUES(
  6,
  1,
  6,
  4,
  '1:30:70.831',
  6,
  71,
  63
);

INSERT INTO [Result] VALUES(
  7,
  1,
  10,
  7,
  '1:30:72.421',
  7,
  71,
  64
);

INSERT INTO [Result] VALUES(
  8,
  1,
  12,
  7,
  '1:30:73.195',
  8,
  71,
  64
);

INSERT INTO [Result] VALUES(
  9,
  1,
  16,
  8,
  '1:30:76.885',
  9,
  71,
  70
);

INSERT INTO [Result] VALUES(
  10,
  1,
  14,
  6,
  '1:30:80.245',
  10,
  71,
  71
);

INSERT INTO [Result] VALUES(
  11,
  1,
  18,
  6,
  '1:30:87.389',
  11,
  71,
  63
);

INSERT INTO [Result] VALUES(
  12,
  1,
  13,
  7,
  null,
  12,
  69,
  50
);

INSERT INTO [Result] VALUES(
  13,
  1,
  9,
  2,
  null,
  13,
  67,
  50
);

INSERT INTO [Result] VALUES(
  14,
  1,
  15,
  8,
  null,
  0,
  53,
  48
);

INSERT INTO [Result] VALUES(
  15,
  1,
  19,
  10,
  null,
  0,
  49,
  49
);

INSERT INTO [Result] VALUES(
  16,
  1,
  20,
  9,
  null,
  0,
  49,
  46
);

INSERT INTO [Result] VALUES(
  17,
  1,
  17,
  9,
  null,
  0,
  24,
  23
);

INSERT INTO [Result] VALUES(
  18,
  1,
  11,
  4,
  null,
  0,
  20,
  4
);

INSERT INTO [Result] VALUES(
  19,
  1,
  4,
  5,
  null,
  0,
  17,
  8
);

INSERT INTO [Result] VALUES(
  20,
  1,
  3,
  2,
  null,
  0,
  11,
  5
);