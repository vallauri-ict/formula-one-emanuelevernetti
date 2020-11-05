ALTER TABLE [dbo].[Driver]  WITH CHECK ADD CONSTRAINT [FK_Driver_Country] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Country] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Team]  WITH CHECK ADD CONSTRAINT [FK_Team_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([countryCode])
ON UPDATE CASCADE;