INSERT INTO [dbo].[ADRESSE] ([codePostal], [numero], [rue], [localite], [ville]) VALUES (N'H2L2J5', 188, N'Dominion', N'Cote-des-Neiges', N'Montreal')
INSERT INTO [dbo].[ADRESSE] ([codePostal], [numero], [rue], [localite], [ville]) VALUES (N'H2L2J6', 186, N'St-Hubert', N'Ville-Marie', N'Montreal')
INSERT INTO [dbo].[ADRESSE] ([codePostal], [numero], [rue], [localite], [ville]) VALUES (N'H3N2T6', 3750, N'Fleury', N'Anjour', N'Montreal')


INSERT INTO [dbo].[IMMEUBLE] ([ImmeubleID], [codePostal], [numero], [Type_Immeuble]) VALUES (N'C001', N'H3N2T6', 3750, N'Commerce')
INSERT INTO [dbo].[IMMEUBLE] ([ImmeubleID], [codePostal], [numero], [Type_Immeuble]) VALUES (N'R001', N'H2l2J5', 188, N'Residentielle')
INSERT INTO [dbo].[IMMEUBLE] ([ImmeubleID], [codePostal], [numero], [Type_Immeuble]) VALUES (N'R002', N'H2L2J6', 186, N'Residentielle')

INSERT INTO [dbo].[BIENIMMOBILIER] ([BIENID], [ImmeubleID], [Type_BIENIMMOBILIER], [Prix_loyer]) VALUES (10001, N'C001', N'Bureau', 900)
INSERT INTO [dbo].[BIENIMMOBILIER] ([BIENID], [ImmeubleID], [Type_BIENIMMOBILIER], [Prix_loyer]) VALUES (10001, N'R001', N'Appart', 800)
INSERT INTO [dbo].[BIENIMMOBILIER] ([BIENID], [ImmeubleID], [Type_BIENIMMOBILIER], [Prix_loyer]) VALUES (10002, N'C001', N'Bureau', 650)
INSERT INTO [dbo].[BIENIMMOBILIER] ([BIENID], [ImmeubleID], [Type_BIENIMMOBILIER], [Prix_loyer]) VALUES (10002, N'R001', N'Appart', 750)
INSERT INTO [dbo].[BIENIMMOBILIER] ([BIENID], [ImmeubleID], [Type_BIENIMMOBILIER], [Prix_loyer]) VALUES (20001, N'R002', N'Appart', 850)
INSERT INTO [dbo].[BIENIMMOBILIER] ([BIENID], [ImmeubleID], [Type_BIENIMMOBILIER], [Prix_loyer]) VALUES (20002, N'R002', N'Appart', 900)


INSERT INTO [dbo].[Annonce] ([numero], [titre], [nombrePieces], [nombreSDB], [surface], [anneeConstruction], [inclusion], [exclusion], [particularite], [autresDescription], [BIENID], [ImmeubleID]) VALUES (1001, N'Grand 4 1/2 pres de la sation Henri-Bourassa', 4, 2, 300, N'2018-07-10', N'chauffage inclus', N'frigo et poele', N'internet', N'proche du metro ', 10001, N'R001')
INSERT INTO [dbo].[Annonce] ([numero], [titre], [nombrePieces], [nombreSDB], [surface], [anneeConstruction], [inclusion], [exclusion], [particularite], [autresDescription], [BIENID], [ImmeubleID]) VALUES (1002, N'3 1/2 proche du centre d''achat', 4, 1, 400, N'1979-06-06', N'Chauffage inclus', N'frit et poele', N'internet', N'proche du metro et tous commerce', 10002, N'C001')





