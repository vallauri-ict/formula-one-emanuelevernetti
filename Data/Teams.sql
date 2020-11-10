CREATE TABLE [dbo].[Team] (
  [id] int PRIMARY KEY,
  [teamName] varchar(255) UNIQUE NOT NULL,
  [teamLogo] image NOT NULL,
  [base] varchar(255) NOT NULL,
  [teamChief] varchar(255) NOT NULL,
  [technicalChief] varchar(255) NOT NULL,
  [powerUnit] varchar(255) NOT NULL,
  [carImage] image NOT NULL,
  [country] char(2) NOT NULL,
  [worldChampionships] int DEFAULT (0),
  [polePositions] int DEFAULT (0)
);

INSERT INTO [Team]
VALUES(
		1,
		'Mercedes-AMG Petronas F1 Team',
		'C:\\data\\formulaone\\img\\mercedesTeamLogo.jpg',
        'Brackley',
		'Toto Wolff',
		'James Allison',
		'Mercedes',
		'C:\\data\\formulaone\\img\\mercedesCarImage.jpg',
		'GB',
		6,
		113        
);
INSERT INTO [Team]
VALUES(
		2,
		'Aston Martin Red Bull Racing',
		'C:\\data\\formulaone\\img\\redBullTeamLogo.jpg',
        'Milton Keynes',
		'Christian Horner',
		'Pierre Waché',
		'Honda',
		'C:\\data\\formulaone\\img\\redBullCarImage.jpg',
		'GB',
		4,
		66        
);
INSERT INTO [Team]
VALUES(
		3,
		'McLaren F1 Team',
		'C:\\data\\formulaone\\img\\mcLarenTeamLogo.jpg',
        'Woking',
		'Andreas Seidl',
		'James Key',
		'Renault',
		'C:\\data\\formulaone\\img\\mcLarenCarImage.jpg',
		'GB',
		8,
		155        
);
INSERT INTO [Team]
VALUES(
		4,
		'BWT Racing Point F1 Team',
		'C:\\data\\formulaone\\img\\racingPointTeamLogo.jpg',
        'Silverstone',
		'Otmar Szafnauer',
		'Andrew Green',
		'BWT Mercedes',
		'C:\\data\\formulaone\\img\\racingPointCarImage.jpg',
		'GB',
		0,
		0        
);
INSERT INTO [Team]
VALUES(
		5,
		'Renault DP World F1 Team',
		'C:\\data\\formulaone\\img\\renaultTeamLogo.jpg',
        'Enstone',
		'Cyril Abiteboul',
		'TBC',
		'Renault',
		'C:\\data\\formulaone\\img\\renaultCarImage.jpg',
		'GB',
		2,
		20        
);
INSERT INTO [Team]
VALUES(
		6,
		'Scuderia Ferrari Mission Winnow',
		'C:\\data\\formulaone\\img\\ferrariTeamLogo.jpg',
        'Maranello',
		'Mattia Binotto',
		'Simone Resta',
		'Ferrari',
		'C:\\data\\formulaone\\img\\ferrariCarImage.jpg',
		'IT',
		16,
		221        
);
INSERT INTO [Team]
VALUES(
		7,
		'Scuderia AlphaTauri Honda',
		'C:\\data\\formulaone\\img\\alphaTauriTeamLogo.jpg',
        'Faenza',
		'Franz Tost',
		'Jody Egginton',
		'Honda',
		'C:\\data\\formulaone\\img\\alphaTauriCarImage.jpg',
		'IT',
		0,
		1        
);
INSERT INTO [Team]
VALUES(
		8,
		'Alfa Romeo Racing ORLEN',
		'C:\\data\\formulaone\\img\\alfaRomeoTeamLogo.jpg',
        'Hinwil',
		'Frédéric Vasseur',
		'Jan Monchaux',
		'Ferrari',
		'C:\\data\\formulaone\\img\\alfaRomeoCarImage.jpg',
		'IT',
		0,
		1        
);
INSERT INTO [Team]
VALUES(
		9,
		'Haas F1 Team',
		'C:\\data\\formulaone\\img\\haasTeamLogo.jpg',
        'Kannapolis',
		'Guenther Steiner',
		'Rob Taylor',
		'Ferrari',
		'C:\\data\\formulaone\\img\\haasCarImage.jpg',
		'US',
		0,
		0        
);
INSERT INTO [Team]
VALUES(	
		10,
		'Williams Racing',
		'C:\\data\\formulaone\\img\\williamsTeamLogo.jpg',
        'Grove',
		'Simon Roberts',
		'TBC',
		'Mercedes',
		'C:\\data\\formulaone\\img\\williamsCarImage.jpg',
		'GB',
		9,
		129        
);

