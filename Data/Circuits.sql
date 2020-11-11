CREATE TABLE [dbo].[Circuit] (
  [id] int PRIMARY KEY,
  [circuitName] varchar(255) UNIQUE NOT NULL,
  [circuitCountry] char(2) NOT NULL,
  [circuitLength] int NOT NULL,
  [circuitTypology] varchar(255) DEFAULT (null),
  [laps] int NOT NULL,
  [turns] int NOT NULL,
  [recordLap] varchar(255) DEFAULT (null),
  [recordLapOwner] varchar(255) DEFAULT (null),
  [img] image DEFAULT (null)
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  1,
  'Red Bull Ring',
  'AT',
  4318,
  'Permanent',
  71,
  9,
  '1:05.619',
  'Carlos Sainz',
  'C:\data\formulaone\img\redBullRingCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  2,
  'Hungaroring',
  'HU',
  4381,
  'Permanent',
  70,
  14,
  '1:17.103',
  'Max Verstappen',
  'C:\data\formulaone\img\hungaroringCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  3,
  'Silverstone Circuit',
  'GB',
  5891,
  'Permanent',
  52,
  18,
  '1:27.097',
  'Max Verstappen',
  'C:\data\formulaone\img\silverstoneCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  4,
  'Circuit de Barcelona-Catalunya',
  'ES',
  4655,
  'Permanent',
  66,
  16,
  '1:18.183',
  'Valterri Bottas',
  'C:\data\formulaone\img\barcellonaCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  5,
  'Circuit de Spa-Francorchamps',
  'BE',
  7004,
  'Permanent',
  44,
  19,
  '1:46.286',
  'Valtteri Bottas',
  'C:\data\formulaone\img\francorchampsCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  6,
  'Autodromo Nazionale di Monza',
  'IT',
  5793,
  'Permanent',
  53,
  11,
  '1:21.046',
  'Rubens Barrichello',
  'C:\data\formulaone\img\monzaCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  7,
  'Autodromo internazionale del Mugello',
  'IT',
  5245,
  'Permanent',
  59,
  15,
  '1:18.833',
  'Lewis Hamilton',
  'C:\data\formulaone\img\mugelloCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  8,
  'Sochi Autodrom',
  'RU',
  5848,
  'Road',
  53,
  18,
  '1:35.761',
  'Lewis Hamilton',
  'C:\data\formulaone\img\russia-sochiCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  9,
  'Nürburgring',
  'DE',
  5148,
  'Permanent',
  60,
  15,
  '1:28.139',
  'Max Verstappen',
  'C:\data\formulaone\img\nurburgringCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  10,
  'Autódromo Internacional do Algarve',
  'PT',
  4684,
  'Permanent',
  66,
  15,
  '1:18.750',
  'Lewis Hamilton',
  'C:\data\formulaone\img\autodromoAlgarveCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  11,
  'Autodromo Enzo e Dino Ferrari',
  'IT',
  4909,
  'Permanent',
  63,
  0,
  '1:15.484',
  'Lewis Hamilton',
  'C:\data\formulaone\img\imolaCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  12,
  'Intercity Istanbul Park',
  'TR',
  5338,
  'Permanent',
  58,
  14,
  '1:24.770',
  'Juan Pablo Montoya',
  'C:\data\formulaone\img\istanbulCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  13,
  'Bahrain International Circuit',
  'BH',
  5412,
  'Permanent',
  57,
  15,
  '1:31.447',
  'Pedro de la Rosa',
  'C:\data\formulaone\img\barhainCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  14,
  'Bahrain International Circuit - Outer Track',
  'BH',
  3543,
  'Permanent',
  87,
  11,
  '',
  '',
  'C:\data\formulaone\img\barhainOuterCircuit.png'
);

INSERT INTO [Circuit] (id, circuitName, circuitCountry, circuitLength, circuitTypology, laps, turns, recordLap, recordLapOwner, img) VALUES (
  15,
  'Yas Marina Circuit',
  'AE',
  5554,
  'Permanent',
  55,
  21,
  '1:39.283',
  'Lewis Hamilton',
  'C:\data\formulaone\img\yasMarinaCircuit.png'
);