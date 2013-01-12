USE [MasterMind]
GO
/****** Object:  Table [dbo].[Joueurs]    Script Date: 04/24/2012 17:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Joueurs](
	[idJ] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[prenom] [varchar](20) NOT NULL,
	[ddn] [date] NULL,
	[langue] [char](2) NULL,
	[nationalite] [char](2) NULL,
	[categorie] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idJ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Joueurs] ON
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (1, N'Legrand', N'Marc', CAST(0xFC110B00 AS Date), N'FR', N'BE', N'A')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (2, N'Amrani', N'Karim', CAST(0x610F0B00 AS Date), N'FR', N'BE', N'B')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (3, N'Celot', N'Chiara', CAST(0x39010B00 AS Date), N'IT', N'IT', N'A')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (4, N'Cuvelier', N'Sandrine', CAST(0x78160B00 AS Date), N'FR', N'FR', N'C')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (5, N'Ramirez', N'Alfonso', CAST(0xE5090B00 AS Date), N'ES', N'ES', N'B')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (6, N'Acedo', N'Ruben', CAST(0x2AFF0A00 AS Date), N'ES', N'ES', N'B')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (7, N'Westlake', N'Martin', CAST(0x74F20A00 AS Date), N'EN', N'GB', N'D')
INSERT [dbo].[Joueurs] ([idJ], [nom], [prenom], [ddn], [langue], [nationalite], [categorie]) VALUES (8, N'Boyle', N'Jane', CAST(0x100B0B00 AS Date), N'EN', N'GB', N'A')
SET IDENTITY_INSERT [dbo].[Joueurs] OFF
/****** Object:  Table [dbo].[Tournois]    Script Date: 04/24/2012 17:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tournois](
	[idT] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](20) NULL,
	[ville] [varchar](20) NULL,
	[province] [varchar](20) NULL,
	[dateT] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tournois] ON
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (1, N'MMGlobe', N'Bruxelles', N'Arr Brux Cap', CAST(0xF6330B00 AS Date))
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (2, N'PrimeMM', N'Namur', N'Namur', CAST(0xA3350B00 AS Date))
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (3, N'GrandPrix', N'Wavre', N'Brabant Wallon', CAST(0xA9320B00 AS Date))
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (4, N'Spécial', N'Herstal', N'Liège', CAST(0x8D320B00 AS Date))
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (5, N'Marignan', N'Verviers', N'LIège', CAST(0x00360B00 AS Date))
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (6, N'Stup', N'Arlon', N'Luxembourg', CAST(0x34340B00 AS Date))
INSERT [dbo].[Tournois] ([idT], [nom], [ville], [province], [dateT]) VALUES (7, N'Brillant', N'Dinant', N'Namur', CAST(0x21360B00 AS Date))
SET IDENTITY_INSERT [dbo].[Tournois] OFF
/****** Object:  Table [dbo].[Inscrire]    Script Date: 04/24/2012 17:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inscrire](
	[numJ] [int] NOT NULL,
	[numT] [int] NOT NULL,
	[paye] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[numJ] ASC,
	[numT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (1, 2, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (1, 3, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (1, 7, N'n')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (2, 4, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (3, 1, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (3, 5, N'n')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (3, 7, N'n')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (4, 2, N'n')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (4, 7, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (5, 1, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (5, 2, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (5, 3, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (5, 4, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (6, 1, N'n')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (7, 2, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (7, 7, N'n')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (8, 6, N'o')
INSERT [dbo].[Inscrire] ([numJ], [numT], [paye]) VALUES (8, 7, N'o')
/****** Object:  Table [dbo].[Parties]    Script Date: 04/24/2012 17:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parties](
	[idP] [int] IDENTITY(1,1) NOT NULL,
	[nbCouleurs] [int] NULL,
	[nbCases] [int] NULL,
	[nbEssaisMax] [int] NULL,
	[numT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Parties] ON
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (1, 4, 4, 10, 1)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (2, 4, 4, 10, 2)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (3, 4, 6, 12, 2)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (4, 5, 8, 12, 3)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (5, 8, 8, 14, 3)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (6, 4, 4, 8, 4)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (7, 5, 5, 12, 4)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (8, 4, 4, 8, 5)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (9, 4, 4, 8, 6)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (10, 6, 10, 20, 6)
INSERT [dbo].[Parties] ([idP], [nbCouleurs], [nbCases], [nbEssaisMax], [numT]) VALUES (11, 4, 4, 8, 7)
SET IDENTITY_INSERT [dbo].[Parties] OFF
/****** Object:  Table [dbo].[Jouer]    Script Date: 04/24/2012 17:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jouer](
	[numJ] [int] NOT NULL,
	[numP] [int] NOT NULL,
	[gagnePerdu] [char](1) NULL,
	[nbCoups] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[numJ] ASC,
	[numP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (1, 4, N'g', 7)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (2, 6, N'p', NULL)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (2, 7, N'p', NULL)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (3, 1, N'g', 7)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (5, 1, N'p', NULL)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (5, 4, N'g', 10)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (5, 5, N'g', 10)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (5, 6, N'p', NULL)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (5, 7, N'g', 11)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (6, 1, N'p', NULL)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (8, 9, N'g', 15)
INSERT [dbo].[Jouer] ([numJ], [numP], [gagnePerdu], [nbCoups]) VALUES (8, 10, NULL, 6)
/****** Object:  ForeignKey [FK__Inscrire__numJ__0DAF0CB0]    Script Date: 04/24/2012 17:53:44 ******/
ALTER TABLE [dbo].[Inscrire]  WITH CHECK ADD FOREIGN KEY([numJ])
REFERENCES [dbo].[Joueurs] ([idJ])
GO
/****** Object:  ForeignKey [FK__Inscrire__numT__0EA330E9]    Script Date: 04/24/2012 17:53:44 ******/
ALTER TABLE [dbo].[Inscrire]  WITH CHECK ADD FOREIGN KEY([numT])
REFERENCES [dbo].[Tournois] ([idT])
GO
/****** Object:  ForeignKey [FK__Jouer__numJ__1367E606]    Script Date: 04/24/2012 17:53:44 ******/
ALTER TABLE [dbo].[Jouer]  WITH CHECK ADD FOREIGN KEY([numJ])
REFERENCES [dbo].[Joueurs] ([idJ])
GO
/****** Object:  ForeignKey [FK__Jouer__numP__145C0A3F]    Script Date: 04/24/2012 17:53:44 ******/
ALTER TABLE [dbo].[Jouer]  WITH CHECK ADD FOREIGN KEY([numP])
REFERENCES [dbo].[Parties] ([idP])
GO
/****** Object:  ForeignKey [FK__Parties__numT__08EA5793]    Script Date: 04/24/2012 17:53:44 ******/
ALTER TABLE [dbo].[Parties]  WITH CHECK ADD FOREIGN KEY([numT])
REFERENCES [dbo].[Tournois] ([idT])
GO
