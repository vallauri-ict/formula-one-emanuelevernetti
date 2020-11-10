ALTER TABLE [dbo].[Driver]  WITH CHECK ADD CONSTRAINT [FK_Driver_Country] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Country] ([countryCode]);

ALTER TABLE [dbo].[Team]  WITH CHECK ADD CONSTRAINT [FK_Team_Country] FOREIGN KEY([Country])
REFERENCES [dbo].[Country] ([countryCode]);

ALTER TABLE [dbo].[Circuit] WITH CHECK ADD CONSTRAINT [FK_Circuit_Country] FOREIGN KEY([circuitCountry])
REFERENCES [dbo].[Country] ([countryCode]);

ALTER TABLE [dbo].[Driver] WITH CHECK ADD CONSTRAINT [FK_Driver_Team] FOREIGN KEY([teamId])
REFERENCES [dbo].[Team] ([id]);

ALTER TABLE [dbo].[Race] WITH CHECK ADD CONSTRAINT [FK_Race_Circuit] FOREIGN KEY([circuitId])
REFERENCES [dbo].[Circuit] ([id]);

ALTER TABLE [dbo].[Result] WITH CHECK ADD CONSTRAINT [FK_Result_Team] FOREIGN KEY([teamId])
REFERENCES [dbo].[Team] ([id]);

ALTER TABLE [dbo].[Result] WITH CHECK ADD CONSTRAINT [FK_Result_Driver] FOREIGN KEY([driverId])
REFERENCES [dbo].[Driver] ([id]);

ALTER TABLE [dbo].[Result] WITH CHECK ADD CONSTRAINT [FK_Result_Race] FOREIGN KEY([raceId])
REFERENCES [dbo].[Race] ([id]);