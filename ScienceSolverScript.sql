USE [ScienceSolverDB]
GO
/****** Object:  Table [dbo].[ChemicalElement]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChemicalElement](
	[Number] [int] NOT NULL,
	[Symbol] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[AtomicMass] [float] NOT NULL,
	[Configuration] [varchar](50) NOT NULL,
	[Electronegativity] [float] NOT NULL,
	[Oxidation] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChemicalElement_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ChemicalElement_View] AS
SELECT* FROM ChemicalElement;
GO
/****** Object:  Table [dbo].[ChemicalConstant]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChemicalConstant](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Symbol] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[UNIT] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChemicalConstant_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ChemicalConstant_View] AS
SELECT * FROM ChemicalConstant;
GO
/****** Object:  Table [dbo].[ChemicalEquation]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChemicalEquation](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Precursors] [varchar](50) NOT NULL,
	[ChemicalEquation] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChemicalEquation_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ChemicalEquation_View] AS
SELECT * FROM ChemicalEquation;
GO
/****** Object:  Table [dbo].[ChemicalLaw]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChemicalLaw](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[FORMULA] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChemicalLaw_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ChemicalLaw_View] AS
SELECT * FROM ChemicalLaw;
GO
/****** Object:  Table [dbo].[PhysicalConstant]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhysicalConstant](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Symbol] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[VALUE] [varchar](100) NOT NULL,
	[UNIT] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PhysicalConstant_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PhysicalConstant_View] AS
SELECT * FROM PhysicalConstant;
GO
/****** Object:  Table [dbo].[PhysicalFormula]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhysicalFormula](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Formula] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[PhysicalFormula_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PhysicalFormula_View] AS
SELECT * FROM PhysicalFormula;
GO
/****** Object:  Table [dbo].[PhysicalLaw]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhysicalLaw](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Formula] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[PhysicalLaw_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PhysicalLaw_View] AS
SELECT * FROM PhysicalLaw;
GO
/****** Object:  Table [dbo].[MathematicalTheorem]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MathematicalTheorem](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](15) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[FORMULA] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[MathematicalTheorem_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MathematicalTheorem_View] AS
SELECT * FROM MathematicalTheorem;
GO
/****** Object:  Table [dbo].[MathematicalLaw]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MathematicalLaw](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[FORMULA] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[MathematicalLaw_View]    Script Date: 15-Dec-23 2:01:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MathematicalLaw_View] AS
SELECT * FROM MathematicalLaw;
GO
SET IDENTITY_INSERT [dbo].[ChemicalConstant] ON 

INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (1, N'NA', N'Avogadro''s number', N'6.0221419910^23', N'mol^-1')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (2, N'mp', N'Proton mass', N'1.6726215810^27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (3, N'mn', N'Neutron mass', N'1.6749271610^-27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (4, N'me', N'Electron mass', N'9.31093818810^-31', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (5, N'u', N'Unified atomic mass unit', N'1.6605387310^-27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (6, N'e', N'Elementary charge', N'-1.60217646210^-19', N'C')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (7, N'R', N'Ideal gas constant', N'8.314472', N'J/molK')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (8, N'Va', N'Volume of gas at standard conditions', N'22.4', N'l')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (9, N'B', N'Boltzmann constant', N'1.3806505(24)×10^(-23)', N'J/K')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (10, N'mC', N'Carbon mass', N'1.660 538 86(28) × 10^-27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (11, N'mp', N'Proton mass', N'1.6726215810^-27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (12, N'mn', N'Neutron mass', N'1.6749271610^-27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (13, N'me', N'Electron mass', N'9.31093818810^-31', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (14, N'a0', N'Bohr radius', N'5.29177208310^-11', N'm')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (15, N'h', N'Planck''s constant', N'6.62606875610^-34', N'Js')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (16, N'u', N'Unified atomic mass unit', N'1.6605387310^-27', N'kg')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (17, N'F', N'Faraday''s constant', N'964853415', N'mol/C')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (18, N'e', N'Elementary charge', N'-1.60217646210^-19', N'C')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (19, N'k', N'Boltzmann constant', N'1.380650310^-23', N'SI')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (20, N'Vm', N'Molar volume of gas (standard conditions)', N'0.022413996', N'm^3')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (21, N'R', N'Ideal gas constant', N'8.314472', N'J/molK')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (22, N'c0', N'Speed of light', N'299792458', N'm/s')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (23, N'Ef0', N'Dielectric constant', N'8.854187817910^-12', N'SI')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (24, N'Y0', N'Vacuum permittivity constant', N'1.25663706110^-6', N'SI')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (25, N'g', N'Acceleration due to gravity', N'9.80665', N'm/(s^2)')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (26, N't0', N'Absolute zero temperature', N'273.15', N'K')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (27, N'G', N'Gravitational constant', N'6.673.10^-11', N'(N*m^2)/kg^2')
INSERT [dbo].[ChemicalConstant] ([Number], [Symbol], [Name], [Value], [UNIT]) VALUES (28, N'atm', N'Atmospheric pressure constant', N'101325', N'Pa')
SET IDENTITY_INSERT [dbo].[ChemicalConstant] OFF
GO
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (1, N'H', N'Hydrogen', 1.008, N'1s1', 2.2, N'-1, 1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (2, N'He', N'Helium', 4.003, N'1s2', 0, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (3, N'Li', N'Lithium', 6.94, N'1s1 2s1', 0.98, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (4, N'Be', N'Beryllium', 9.04, N'1s2 2s2', 1.57, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (5, N'B', N'Boron', 10.81, N'1s2 2s2 2p1', 2.04, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (6, N'C', N'Cacbon', 12.01, N'1s2 2s2 2p2', 2.55, N'-4,-3,-2,-1,0,1,2,3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (7, N'N', N'Nito', 14.007, N'1s2 2s2 2p3', 3.04, N'-3,1,2,3,4,5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (8, N'O', N'Oxygen', 15.999, N'1s2 2s2 2p4', 3.44, N'-2,-1,-1/2,-1/3,1,2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (9, N'F', N'Fluorine', 18.998, N'1s2 2s2 2p5', 3.98, N'-1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (10, N'Ne', N'Neon', 20.18, N'1s2 2s2 2p6', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (11, N'Na', N'Sodium', 22.989, N'[Ne] 3s1', 0.93, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (12, N'Mg', N'Magnesium', 24.305, N'[Ne] 3s2', 1.31, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (13, N'Al', N'Aluminium', 26.98, N'[Ne] 3s2 3p1', 1.61, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (14, N'Si', N'Silicon', 28.09, N'[Ne]3s2 3p2', 1.9, N'4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (15, N'P', N'Phoshorus', 30.97, N'[Ne]3s2 3p3', 2.19, N'-3,(1),(4),5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (16, N'S', N'Sulfur', 32.06, N'[Ne]3s2 3p4', 2.58, N'-2,-1,(1,2),4,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (17, N'Cl', N'Chlorine', 35.45, N'[Ne]3s2 3p5', 3.16, N'-1,1,3,(4),5,7')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (18, N'Ar', N'Argon', 39.95, N'[Ne]3s2 3p6', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (19, N'K', N'Potassium', 39.098, N'[Ar] 4s1', 0.82, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (20, N'Ca', N'Calcium', 40.078, N'[Ar] 4s2', 1, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (21, N'Sc', N'Scandium', 44.956, N'[Ar] 4d1 ds2', 1.36, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (22, N'Ti', N'Titanium', 47.9, N'[Ar]3d24s2', 1.54, N'2.3.4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (23, N'V', N'Vanadium', 50.942, N'[Ar]3d34s2', 1.63, N'2,(3),4,5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (24, N'Cr', N'Chromium', 51.996, N'[Ar]3d54s1', 1.66, N'2,3,4,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (25, N'Mn', N'Manganese', 54.94, N'[Ar]3d54s2', 1.55, N'2,3,4,(5),6,7')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (26, N'Fe', N'Iron', 55.933, N'[Ar]3d64s3', 1.83, N'2,(3),(4)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (27, N'Co', N'Cobalt', 58.933, N'[Ar]3d74s2', 1.88, N'2,3,(4,5,6)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (28, N'Ni', N'Nickel', 58.71, N'[Ar]3d84s2', 1.91, N'2,(3),(4)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (29, N'Cu', N'Copper', 63.546, N'[Ar]3d104s1', 1.9, N'1,2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (30, N'Zn', N'Zinc', 65.39, N'[Ar]3d104s2', 1.65, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (31, N'Ga', N'Gallium', 69.732, N'[Ar]3d104s24p1', 1.81, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (32, N'Ge', N'Germanium', 72.61, N'[Ar]3d104s24p2', 2.01, N'2,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (33, N'Ar', N'Arsenic', 74.922, N'[Ar]3d104s24p3', 2.18, N'-3,3,5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (34, N'Se', N'Selenium', 78.972, N'[Ar]3d104s24p4', 2.55, N'-2,4,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (35, N'Br', N'Bromine', 79.904, N'[Ar]3d104s24p5', 2.96, N'-1,1,(3),(4),5,7')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (36, N'Kr', N'Krypton', 84.8, N'[Ar]3d104s24p6', 3, N'2,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (37, N'Rb', N'Rubidium', 84.468, N'[Kr]5s1', 0.62, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (38, N'Sr', N'Strontium', 87.62, N'[Kr]5s2', 0.95, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (39, N'Y', N'Ytri', 88.906, N'[Kr[4d155s2', 1.22, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (40, N'Zr', N'Ziriconium', 91.224, N'[Kr]4d25s2', 1.33, N'(2),(3),4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (41, N'Nb', N'Niobium', 92.906, N'[Kr]4d45s1', 1.6, N'(2),(3),(4),5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (42, N'Mo', N'Molybdenum', 95.95, N'[Kr]4d55s1', 2.16, N'2,3,4,(5),6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (43, N'Tc', N'Technetium', 98.907, N'[Kr]4d55s2', 1.9, N'3,4,(5),(6),8')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (44, N'Ru', N'Ruthenium', 101.07, N'[Kr]4d75s2', 2.2, N'2,3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (45, N'Rh', N'Rhodium', 102.906, N'[Kr]4d85s1', 2.28, N'2,3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (46, N'Pd', N'Palladium', 106.42, N'[Kr]4d105s0', 2.2, N'2,(3),4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (47, N'Ag', N'Silver', 107.868, N'[Kr]4d105s1', 1.93, N'1,(2)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (48, N'Cd', N'Cadmium', 112.411, N'[Kr]4d105s2', 1.69, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (49, N'In', N'Indium', 114.818, N'[Kr]4d105s25p1', 1.78, N'1,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (50, N'Sn', N'Tin', 118.71, N'[Kr]4d105s25p2', 1.96, N'2,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (51, N'Sb', N'Antimony', 121.76, N'[Kr]4d105s25p3', 2.05, N'-3,3,(4),5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (52, N'Te', N'Tellurium', 127.6, N'[Kr]4d105s25p4', 2.1, N'-2,(2),4,5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (53, N'I', N'Iodine', 126.904, N'[Kr]4d105s25p5', 2.66, N'-1,1,3,5,7')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (54, N'Xe', N'Xeon', 131.29, N'[Kr]4d105s25p9', 2.6, N'2,4,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (55, N'Cs', N'Cesium', 132.905, N'[Xe]6s1', 0.79, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (56, N'Ba', N'Barium', 137.327, N'[Xe]6s2', 0.89, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (57, N'La', N'Lanthanum', 138.906, N'[Xe]5d16s2', 1.1, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (58, N'Ce', N'Cerium', 140.115, N'[Xe]4f25d06s2', 1.12, N'3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (59, N'Pr', N'Praseodymium', 140.908, N'[Xe]4f35d06s2', 1.13, N'3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (60, N'Nd', N'Neodymium', 144.24, N'[Xe]4f45d06s2', 1.14, N'(2),3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (61, N'Pm', N'Promethium', 144.913, N'[Xe]4f55d06s2', 1.13, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (62, N'Sm', N'Samarium', 150.36, N'[Xe]4f65d06s2', 1.17, N'2,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (63, N'Eu', N'Europium', 151.966, N'[Xe]4f75d16s2', 1.2, N'2,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (64, N'Gd', N'Gadolinium', 157.25, N'[Xe]4f95d16s2', 1.2, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (65, N'Tb', N'Terbium', 158.925, N'[Xe]4f95d06s2', 1.1, N'3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (66, N'Dy', N'Dysprosium', 162.5, N'[Xe]4f105d06s2', 1.22, N'3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (67, N'Ho', N'Holium', 164.93, N'[Xe]4f115d06s2', 1.23, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (68, N'Er', N'Erbium', 167.26, N'[Xe]4f125d06s2', 1.24, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (69, N'Tm', N'Thulium', 168.934, N'[Xe]4f135d06s2', 1.24, N'(2),3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (70, N'Yb', N'Ytterbium', 173.04, N'[Xe]4f145d06s2', 1.1, N'2,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (71, N'Lu', N'Lutetium', 174.967, N'[Xe]4f145d16s2', 1.27, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (72, N'Hf', N'Hafnium', 178.49, N'[Xe]4f145d26s2', 1.3, N'(2),(3),4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (73, N'Ta', N'Tantalum', 180.948, N'[Xe]4f145d36s2', 1.5, N'(2),(3),(4),5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (74, N'W', N'Tungsten', 183.85, N'[Xe]4f145d46s2', 2.36, N'2,(3),(4),(5),6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (75, N'Re', N'Rhenium', 186.207, N'[Xe]4f145d56s2', 1.9, N'(2),3,4,(5),(6),7')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (76, N'Os', N'Osmium', 190.23, N'[Xe]4f145d66s2', 2.2, N'2,3,4,(6)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (77, N'Ir', N'Iridium', 192.22, N'[Xe]4f145d76s2', 2.2, N'2,3,4,(6)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (78, N'Pt', N'Platium', 195.08, N'[Xe]4f145d96s1', 2.28, N'2,(3),4,(6)')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (79, N'Au', N'Gold', 196.967, N'[Xe]4f145d106s1', 2.54, N'1,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (80, N'Hg', N'Mercury', 200.59, N'[Xe]4f145d106s1', 2, N'1,2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (81, N'Tl', N'Thallium', 204.383, N'[Xe]4f145d106s26p1', 1.62, N'1,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (82, N'Pb', N'lead', 207.2, N'[Xe]4f145d106s26p2', 2.33, N'2,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (83, N'Bi', N'Bismuth', 208.98, N'[Xe]4f145d106s26p3', 2.02, N'3,5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (84, N'Po', N'Polonium', 208.982, N'[Xe]4f145d106s26p4', 2, N'-2,2,4,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (85, N'At', N'Astatine', 209.987, N'[Xe]4f145d106s26p5', 2.2, N'-1,1,3,5,7')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (86, N'Rn', N'Radon', 222.018, N'[Xe]4f145d106s26p6', 0, N'4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (87, N'Fr', N'Francium', 223.02, N'[Rn]7s1', 0.7, N'1')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (88, N'Ra', N'Radium', 226.025, N'[Rn]7s2', 0.9, N'2')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (89, N'Ac', N'Actinium', 227.028, N'[Rn]6d17s2', 1.1, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (90, N'Th', N'Thorium', 232.038, N'[Rn]5f06d27s2', 1.3, N'4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (91, N'Pa', N'Protactinium', 231.036, N'[Rn]5f26d17s2', 1.5, N'4,5')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (92, N'U', N'Uranium', 238.029, N'[Rn]5f36d17s2', 1.38, N'(3),4,(5),6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (93, N'Np', N'Neptunium', 237.048, N'[Rn]5f46d17s2', 1.36, N'(3),4,5,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (94, N'Pu', N'Plutonium', 244.064, N'[Rn]5f66d07s2', 1.28, N'(3),4,5,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (95, N'Am', N'Americium', 243.061, N'[Rn]5f76d07s2', 1.13, N'(3),4,5,6')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (96, N'Cm', N'Cumrium', 247.07, N'[Rn]5f76d17s2', 1.28, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (97, N'Bk', N'Berkelium', 247.07, N'[Rn]5f96d07s2', 1.3, N'3,4')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (98, N'Cf', N'Californium', 241.08, N'[Rn]5f106d07s2', 1.3, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (99, N'Es', N'Einsteinium', 254, N'[Rn]5f116d07s2', 1.3, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (100, N'Fm', N'Fermium', 257.095, N'[Rn]5f126d07s2', 1.3, N'3')
GO
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (101, N'Md', N'Mendelevium;', 258.1, N'[Rn]5f136d07s2', 1.3, N'2,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (102, N'No', N'Nobelium', 259.101, N'[Rn]5f146d07s2', 1.3, N'2,3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (103, N'Lr', N'Lawrencium', 262, N'[Rn]5f146d17s2', 0, N'3')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (104, N'Rf', N'Rutherfordium', 261, N'[Rn]5f146d27s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (105, N'Db', N'Dubnium', 262, N'[Rn]5f146d37s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (106, N'Sg', N'Seaborgium', 266, N'[Rn]5f146d47s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (107, N'Bh', N'Bohrium', 264, N'[Rn]5f146d57s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (108, N'Hs', N'Hassium', 269, N'[Rn]5f146d67s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (109, N'Mt', N'Meitnerium', 268, N'[Rn]5f146d77s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (110, N'Ds', N'Darmstadtium', 269, N'[Rn]5f146d97s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (111, N'Rg', N'Roentgenium', 272, N'[Rn]5f146d107s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (112, N'Cn', N'Copernicium', 277, N'[Rn]5f146d107s2', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (113, N'Uut', N'Ununtrium', 280, N'0', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (114, N'Fl', N'Fleroium', 289, N'0', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (115, N'Uup', N'Ununpentium', 298, N'0', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (116, N'Lv', N'Livermorium', 292, N'0', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (117, N'Uus', N'Ununseptium', 301, N'0', 0, N'0')
INSERT [dbo].[ChemicalElement] ([Number], [Symbol], [Name], [AtomicMass], [Configuration], [Electronegativity], [Oxidation]) VALUES (118, N'Uuo', N' Ununoctium', 303, N'0', 0, N'0')
GO
SET IDENTITY_INSERT [dbo].[ChemicalEquation] ON 

INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1, N'naoh+hcl', N'NaOH+HCl->NaCl+H2O')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (2, N'fe+h2so4', N'Fe+H2SO4->FeSO4+H2/2Fe+6H2SO4->Fe2(SO4)3+3SO2+6H2O(điều kiện: H2SO4 đặc nóng)/8Fe+15H2SO4->4Fe2(SO4)3+3H2S+12H2O(đk:H2SO4 đặc nóng)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (3, N'fe+hcl', N'Fe+2HCL->FeCl2+H2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (4, N'fe+hno3', N'Fe+HNO3->Fe(No3)3+NO+H2O(điều kiện HNO3 đặc nóng)/Fe+4HNO3->Fe(No3)3+NO+2H2O(điều kiện HNO3 loãng)/8Fe+30HNO3->8Fe(No3)3+3N2O+15H2O(điều kiện HNO3 loãng)/8Fe+30HNO3->8Fe(NO3)3+3NH4NO3+9H2O(điều kiện HNO3 Lõang)/10Fe+36HNO3->10Fe(NO3)3+3N2+18H2O(điều kiện HNO3 loãng)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (5, N'zn+hcl', N'Zn+2HCl->ZnCl2+H2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (7, N'zn+h2so4', N'Zn+H2SO4->ZnSO4+H2/Zn+H2SO4->ZnSO4+SO2+2H2O(điều kiện H2SO4 đặc nóng)/3Zn+4H2SO4->3ZnSO4+S+4H2O(điều kiện H2SO4 đặc)/4Zn+5H2SO4->4ZnSO4+H2S+4H2O(điều kiện H2SO4 đặc)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (9, N'zn+hno3', N'10HNO3 + 4Zn → 3H2O + NH4NO3 + 4Zn(NO3)2/8HNO3 + 3Zn → 4H2O + 2NO + 3Zn(NO3)2/80HNO3 + 31Zn → 40H2O + NO + NO2 + 6N2O + 31Zn(NO3)2/10HNO3 + 4Zn → 5H2O + N2O + 4Zn(NO3)2/4HNO3 + Zn → 2H2O + 2NO2 + Zn(NO3)2/6HNO3 + 2Zn → 3H2O + NO + NO2 + 2Zn(NO3)2/2HNO3 + Zn → H2 + Zn(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (10, N'kmno4+h2o+so2', N'2H2O + 2KMnO4 + 5SO2 → 2H2SO4 + 2MnSO4 + K2SO4(điều kiện H2SO4 loãng)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (11, N'feo+h2o+kmno4', N'10FeO + 18H2SO4 + 2KMnO4 → 5Fe2(SO4)3 + 18H2O + 2MnSO4 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (12, N'kmno4', N'2KMnO4 → MnO2 + O2 + K2MnO4 (điều kiện nhiệt độ)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (13, N'nabr+kmno4+h2so4', N'8H2SO4 + 2KMnO4 + 10NaBr → 5Br2 + 8H2O + 2MnSO4 + 5Na2SO4 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (14, N'c2h4+h2o+kmno4', N'3C2H4 + 4H2O + 2KMnO4 → 2KOH + 2MnO2 + 3C2H4(OH)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1003, N'h2so4+kmno4+feso4', N'8H2SO4 + 2KMnO4 + 10FeSO4 → 5Fe2(SO4)3 + 8H2O + 2MnSO4 + 1K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1004, N'c2h4+h2o+kmno4', N'3C2H4 + 4H2O + 2KMnO4 → 2KOH + 2MnO2 + 3C2H4(OH)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1005, N'h2so4+kmno4+no', N'9H2SO4 + 6KMnO4 + 10NO → 4H2O + 10HNO3 + 6MnSO4 + 3K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1006, N'kmno4+koh+mnso4', N'2KMnO4 + 4KOH + 3MnSO4 → 2H2O + 5MnO2 + 3K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1007, N'kmno4+hbr', N'2KMnO4 + 16HBr → Br2 + 8H2O + 2KBr + 2MnBr2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1008, N'kmno4+hcl', N'16HCl + 2KMnO4 → 5Cl2 + 8H2O + 2KCl + 2MnCl2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1010, N'kmno4+h2o+na2so3', N'H2O + 2KMnO4 + 3Na2SO3 → 2KOH + 2MnO2 + 3Na2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1011, N'h2o+kmno4+mnso4', N'2H2O + 2KMnO4 + 3MnSO4 → 2H2SO4 + 5MnO2 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1012, N'h2o2+kmno4', N'3H2O2 + 2KMnO4 → 2H2O + 2KOH + 2MnO2 + 3O2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1013, N'kmno4+koh+k2so3', N'2KMnO4 + 2KOH + K2SO3 → H2O + K2SO4 + 2K2MnO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1014, N'h2o2+h2so4+kmno4', N'5H2O2 + 3H2SO4 + 2KMnO4 → 8H2O + 2MnSO4 + 5O2 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1015, N'h2so4+kmno4+nacl', N'8H2SO4 + 2KMnO4 + 10NaCl → 5Cl2 + 8H2O + 2MnSO4 + 5Na2SO4 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1016, N'kmno4+koh', N'2KMnO4 + 2KOH → H2O + O2 + 2K2MnO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1017, N'fes2+kmno4', N'4FeS2 + 22KMnO4 → 2Fe2O3 + 11MnO2 + 8SO2 + 11K2MnO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1018, N'h2so4+kmno4+nano2', N'3H2SO4 + 2KMnO4 + 5NaNO2 → 3H2O + 2MnSO4 + 5NaNO3 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1019, N'h2so4+kmno4+h2c2o4', N'3H2SO4 + 2KMnO4 + 5H2C2O4 → 8H2O + 2MnSO4 + K2SO4 + 10CO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1020, N'h2s+h2so4+kmno4', N'5H2S + 3H2SO4 + 2KMnO4 → 8H2O + 2MnSO4 + 2S + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1021, N'fe(no3)2+h2so4+kmno4', N'10Fe(NO3)2 + H2SO4 + 2KMnO4 → Fe2(SO4)3 + H2O + 2MnSO4 + K2SO4 + Fe(NO3)3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1022, N'kmno4+k2so3+khso4', N'2KMnO4 + 5K2SO3 + 6KHSO4 → 3H2O + 2MnSO4 + 9K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1023, N'kmno4+c6h5ch3', N'2KMnO4 + C6H5CH3 → H2O + KOH + 2MnO2 + C6H5COOK')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1024, N'h2o+kmno4+k2so3', N'H2O + 2KMnO4 + 3K2SO3 → 2KOH + 2MnO2 + 3K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1025, N'c2h2+h2so4+kmno4', N'C2H2 + 3H2SO4 + 2KMnO4 → 4H2O + 2MnSO4 + 2K2SO4 + 2CO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1026, N'h2so4+kmno4+kno2', N'3H2SO4 + 2KMnO4 + 5KNO2 → 3H2O + 5KNO3 + 2MnSO4 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1027, N'hcl+kmno4', N'16HCl + 2KMnO4 → 5Cl2 + 8H2O + 2KCl + 2MnCl2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1028, N'h2so4+k2s+kmno4', N'8H2SO4 + 5K2S + 2KMnO4 → 8H2O + 5S + 6K2SO4 + 2MnO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1029, N'fes2+h2so4+kmno4', N'2FeS2 + 8H2SO4 + 6KMnO4 → Fe2(SO4)3 + 8H2O + 6MnSO4 + 3K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1030, N'h2so4+kmno4+As', N'9H2SO4 + 6KMnO4 + 10As → 9H2O + 6MnSO4 + 3K2SO4 + 5As2O3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1031, N'kmno4+koh', N'KMnO4 + 4KOH → 2H2O + O2 + 4K2MnO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1033, N'kmno4+nh3', N'KMnO4 + 2NH3 → 2H2O + 2KOH + 2MnO2 + N2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1034, N'h2o+kmno4+k2so3', N'H2O + 2KMnO4 + 3K2SO3 → 2KOH + 2Mn(OH)4 + 3K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1035, N'h2so4+kcl+kmno4', N'8H2SO4 + 10KCl + 2KMnO4 → 5Cl2 + 8H2O + 2MnSO4 + 6K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1036, N'h2so4+kmno4+feso4', N'8H2SO4 + 2KMnO4 + 10FeSO4 → 5Fe2(SO4)3 + 8H2O + 2MnSO4 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1037, N'ch3coch3+kmno4+khso4', N'10CH3COCH3 + 12KMnO4 + 36KHSO4 → 10CH3COOH + 28H2O + 12MnSO4 + 24K2SO4 + 5CO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1038, N'h2so4+kmno4+P4', N'4H2SO4 + 4KMnO4 + P4 → 4MnSO4 + 4KH2PO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1039, N'h2so4+kmno4+k2so3', N'3H2SO4 + 2KMnO4 + 5K2SO3 → 3H2O + 2MnSO4 + 6K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1040, N'al+h2so4', N'2Al + 3H2SO4 → Al2(SO4)3 + 3H2/2Al + 3H2SO4 → Al2(SO4)3 + 3H2/2Al + 4H2SO4 → Al2(SO4)3 + 4H2O + S/2Al + 6H2SO4 → Al2(SO4)3 + 6H2O + 3SO2/8Al + 15H2SO4 → 4Al2(SO4)3 + 12H2O + 3H2S/8Al + 15H2SO4 → 4Al2(SO4)3 + 12H2O + 3H2S/8Al + 21H2SO4 + 3K2Cr2O7 → 4Al2(SO4)3 + 21H2O + 3K2SO4 + 6CrSO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1042, N'al+hcl', N'2Al + 6HCl → 2AlCl3 + 3H2/10Al + 36HCl + 6KNO3 → 10AlCl3 + 18H2O + 6KCl + 3N2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1044, N'al+hno3', N'Al + 6HNO3 → 3H2O + 3NO2 + Al(NO3)3/8Al + 30HNO3 → 9H2O + 3NH4NO3 + 8Al(NO3)3/Al + 4HNO3 → 2H2O + NO + Al(NO3)3/8Al + 30HNO3 → 15H2O + 3N2O + 8Al(NO3)3/8Al + 30HNO3 → 15H2O + 3N2O + 8Al(NO3)3/8Al + 30HNO3 → 9H2O + 3NH4NO3 + 8Al(NO3)3/8Al + 30HNO3 → 15H2O + 3N2O + 8Al(NO3)3/52Al + 192HNO3 → 96H2O + 9N2 + 6NO + 6N2O + 52Al(NO3)3/10Al + 36HNO3 → 18H2O + 3N2 + 10Al(NO3)3/8Al + 27HNO3 → 9H2O + 3NH3 + 8Al(NO3)3/2Al + 6HNO3 → 3H2 + 2Al(NO3)3(27 độ C)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1045, N'al+naoh', N'2Al + 2H2O + 2NaOH → 3H2 + 2NaAlO2(400-500 độ C)/2Al + 6H2O + 2NaOH → 3H2 + 2Na[Al(OH)4](nhiệt độ)/2Al + 6H2O + 2NaOH → 3H2 + 2Na[AlOH]4/Al + 3H2O + NaOH → 3/2H2 + Na[AlOH]4/2Al + 4H2O + 2NaOH + C6H5NO2 → C6H5NH2 + 2NaAl(OH)4/8Al + 2H2O + 3NaNO3 + 5NaOH → 3NH3 + 8NaAlO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1047, N'al+koh', N'2Al + 2H2O + 2KOH → 3H2 + 2KAlO2/2Al + 2H2O + 2KOH → 3H2 + 2KAlO2/Al + H2O + KOH → 3/2H2 + KAlO2/8Al + 18H2O + 3KNO3 + 5KOH → 3NH3 + 8KAl(OH)4/2Al + 6H2O + 2KOH → 3H2 + 2KAl(OH)4(400-500 độ C)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1048, N'al+ba(oh)2', N'2Al + 2H2O + Ba(OH)2 → 3H2 + Ba(AlO2)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1050, N'al+ca(oh)2', N'Al + Ca(OH)2 + H2O → H2 + Ca(AlO2)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1051, N'al2o3', N'2Al2O3 → 4Al + 3O2 (900 độ C, đpnc)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1052, N'Al+fe2o3', N'2Al + Fe2O3 → Al2O3 + 2Fe(nhiệt độ)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1054, N'fe2(so4)3', N'Fe2(SO4)3 → Fe2O3 + 3SO3(500-700 độ C)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1055, N'fe+h2so4+kmno4', N'10FeO + 18H2SO4 + 2KMnO4 → 5Fe2(SO4)3 + 18H2O + 2MnSO4 + K2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1056, N'hno3+fecus2', N'24HNO3 + FeCuS2 → Cu(NO3)2 + 10H2O + 2H2SO4 + 18NO2 + Fe(NO3)3 (nhiệt độ)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1057, N'naoh+ch3ch2cooch2c6h5', N'NaOH + CH3-CH2-COO-CH2-C6H5 → C6H5CH2OH + CH3CH2COONa')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1058, N'naoh+c6h5br', N'NaOH + C6H5Br → C6H5ONa + H2O + NaBr')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1059, N'naoh+nh4hso4', N'2NaOH + NH4HSO4 → 2H2O + Na2SO4 + NH3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1060, N'agno3+cu', N'2AgNO3 + Cu → 2Ag + Cu(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1062, N'hno3+[cu(nh3)4](oh)2', N'6HNO3 + [Cu(NH3)4](OH)2 → Cu(NO3)2 + 2H2O + 4NH4NO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1063, N'(nh4)3po4+ba(oh)2', N'2(NH4)3PO4 + 3Ba(OH)2 → 6H2O + 6NH3 + Ba3(PO4)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1064, N'hno3+fexOy', N'(6x-2y)HNO3 + FexOy → (3x-y)H2O + 3x-2yNO2 + xFe(NO3)3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1065, N'h2o+kmno4+so2', N'2H2O + 2KMnO4 + 5SO2 → 2H2SO4 + 2MnSO4 + K2SO4(h2so4 loãng)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1066, N'fe(so4)3+h2o', N'Fe2(SO4)3 + 3H2O → 2Fe + 3H2SO4 + 3/2O2 (đpdd)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1067, N'agno3', N'2AgNO3 → 2Ag + 2NO2 + O2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1068, N'cun(no3)2', N'2Cu(NO3)2 → 2CuO + 4NO2 + O2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1069, N'c2h5oh', N'2C2H5OH → C4H6 + H2 + H2O (Nhiệt độ: 450 độ C Xúc tác: Al2O3, Cr2O3)')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1070, N'c2h5oh+o2', N'C2H5OH + 3O2 → 3H2O + 2CO2 Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1071, N'c2h5oh + (ch3co)2o', N'C2H5OH + (C3CO)2O → CH3COOH + CH3COOC2H5Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1072, N'ch3cooh+cu(oh)2', N'2CH3COOH + Cu(OH)2 → 2H2O + (CH3COO)2Cu')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1073, N'ch3cooh+khco3', N'CH3COOH + KHCO3 → H2O + CO2 + CH3COOK')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1074, N'ch3cooh+mg(oh)2', N'2CH3COOH + Mg(OH)2 → 2H2O + (CH3COO)2Mg')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1075, N'c2h4+h2o', N'C2H4 + H2O → C2H5OH Xúc tác: H2SO4; H3PO4 Điều kiện khác: nhiệt độ cao')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1076, N'c6h12o6;', N'C6H12O6 → 2C2H5OH + 2CO2 Nhiệt độ: 30-35°C Xúc tác: enzim men zima')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1077, N'ch3cho+h2o', N'CH3CHO + H2O → C2H5OH Nhiệt độ: nhiệt độ Xúc tác: xúc tác')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1078, N'h2o+ch3cooc2h5', N'H2O + CH3COOC2H5 → C2H5OH + CH3COOH Điều kiện khác: với sự hiện diện của H+')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1079, N'ch3cooh+mg(oh)2', N'2CH3COOH + Mg(OH)2 → 2H2O + (CH3COO)2Mg')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1080, N'c2h4+h2o', N'C2H4 + H2O → C2H5OH Xúc tác: H2SO4; H3PO4 Điều kiện khác: nhiệt độ cao')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1081, N'c6h12o6', N'C6H12O6 → 2C2H5OH + 2CO2 Nhiệt độ: 30-35°C Xúc tác: enzim men zima')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1082, N'ch3cho+h2o', N'CH3CHO + H2O → C2H5OH Nhiệt độ: nhiệt độ Xúc tác: xúc tác')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1083, N'h2o+ch3cooc2h5', N'H2O + CH3COOC2H5 → C2H5OH + CH3COOH Điều kiện khác: với sự hiện diện của H+')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1084, N'hno2+c2h5nh2', N'HNO2 + C2H5NH2 → C2H5OH + H2O + N2 Nhiệt độ: nhiệt độ thường')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1085, N'h2o+c2h4', N'H2O + CH2=CH2 → C2H5OH Nhiệt độ: 300°C Xúc tác: H2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1086, N'ch3cho+h2', N'CH3CHO + H2 → C2H5OH')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1087, N'naoh+c2h5cooc2h5', N'NaOH + C2H5COOC2H5 → C2H5OH + C2H5COONa Nhiệt độ: t0 Xúc tác: H2O')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1088, N'h2o+co2+c2h5ona', N'H2O + CO2 + C2H5ONa → C2H5OH + NaHCO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1089, N'ch3cooc2h5', N'CH3COOC2H5 → C2H5OH + CH3CH2CHO  Xúc tác:LiAlH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1090, N'ch3cooch3', N'CH3COOCH3 → C2H5OH + CH3OH  Xúc tác: LiAlH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1091, N'hcl+c2h5ona', N'HCl + C2H5ONa → C2H5OH + NaCl')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1092, N'naoh+nh2ch2cooc2h5', N'NaOH + NH2CH2COOC2H5 → C2H5OH + H2N-CH2-COONa')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1093, N'naoh+c2h5cl', N'NaOH + C2H5Cl → C2H5OH + NaCl')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1094, N'ba(oh)2+ch3cooc2h5', N'Ba(OH)2 + 2CH3COOC2H5 → 2C2H5OH + (CH3COO)2Ba')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1095, N'koh+ch3cooc2h5', N'KOH + CH3COOC2H5 → C2H5OH + CH3COOK')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1096, N'koh+hcooc2h5', N'KOH + HCOOC2H5 → C2H5OH + HCOOK')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1097, N'naoh+hcooc2h5', N'NaOH + HCOOC2H5 → C2H5OH + HCOONa')
GO
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1098, N'naoh+c2h5ooccooch3', N'2NaOH + C2H5OOC-COOCH3 → C2H5OH + CH3OH + (COONa)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1099, N'ca(oh)2+2ch3cooc2h5', N'Ca(OH)2 + 2CH3COOC2H5 → (CH3COO)2Ca + 2C2H5OH')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1100, N'ch3cho+h2so4+nabh4', N'2CH3CHO + H2SO4 + 2NaBH4 → 2C2H5OH + Na2SO4 + 2BH3 Dung môi: THF')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1101, N'ch3cooch2ch3', N'CH3COOCH2CH3 → C2H5OH + CH3COOH')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1102, N'h2s+c2h5oli', N'H2S + C2H5OLi → C2H5OH + LiHS Dung môi: ête')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1103, N'h2s+c2h5ona', N'H2S + C2H5ONa → C2H5OH + NaHS Dung môi: ête')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1104, N'h2s+c2h5oka', N'H2S + C2H5OK → C2H5OH + KHS Dung môi: ête')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1105, N'h2s+li(c2h5o)', N'H2S + Li(C2H5O) → C2H5OH + LiHSDung môi: ête')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1106, N'c2h5ona+(nh3oh)cl', N'C2H5ONa + (NH3OH)Cl → C2H5OH + NaCl + NH2OHDung môi: etanol')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1107, N'ca(oh)2+hcooc2h5', N'Ca(OH)2 + 2HCOOC2H5 → 2C2H5OH + (HCOO)2Ca')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1108, N'naoh+ch3coo5', N'NaOH + CH3COOC2H5 → C2H5OH + CH3COONa')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1109, N'nahco3+ch3cooc2h5', N'NaHCO3 + CH3COOC2H5 → C2H5OH + CH3COONa + CO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1110, N'hno2+c2h5nh2', N'HNO2 + C2H5NH2 → C2H5OH + H2O + N2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1111, N'cu+hcl', N'Cu + 4HCl + 2KNO3 → 2H2O + 2KCl + 2NO2 + CuCl2/Cu + HCl + 1/2O2 → H2O + CuCl2/2Cu + H2O2 + 2HCl → 2H2O + 2CuCl/Cu + 8HCl + Fe3O4 → 3FeCl2 + 4H2O + CuCl2/3Cu + Cu(NO3)2 + 8HCl → 4H2O + 2NO + 4CuCl2/3Cu + 8HCl + 8NaNO3 → 3Cu(NO3)2 + 4H2O + 8NaCl + NO/3Cu + 8HCl + 2NaNO3 → 4H2O + 2NaCl + 2NO + 3CuCl2/2Cu + 4HCl → H2 + 2H[CuCl2]')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1112, N'h2+o2', N'2H2 + O2 → 2H2ONhiệt độ: 550°C Điều kiện khác: cháy trong không khí')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1114, N'cu+h2so4', N'Cu + 2H2SO4 → 2H2O + SO2 + CuSO4Nhiệt độ: nhiệt độ/3Cu + 4H2SO4 + 2NaNO3 → 4H2O + Na2SO4 + 2NO + 3CuSO4/Cu + 2H2SO4 + 4NH4NO3 → 2(NH4)2SO4 + Cu(NO3)2 + 2H2O + 2NO2/3Cu + 4H2SO4 + 2Al(NO3)3 → Al2(SO4)3 + 2Cu(NO3)2 + 4H2O + NO + CuSO4Nhiệt độ: Nhiệt độ/Cu + 2H2SO4 → 2H2O + SO2 + Cu(SO4)/2Cu + 2H2SO4 + O2 → 2H2O + 2CuSO4Nhiệt độ: Nhiệt độ./Cu + H2O2 + H2SO4 → 2H2O + CuSO4/9Cu + 12H2SO4 + 2Fe(NO3)3 → Fe2(SO4)3 + 12H2O + 6NO + 9CuSO4/3Cu + 4H2SO4 + 8NaNO3 → 3Cu(NO3)2 + 4H2O + 4Na2SO4 + 2NO/3Cu + 4H2SO4 + 2KNO3 → 4H2O + 2NO + K2SO4 + 3CuSO4/Cu + H2SO4 → H2 + CuSO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1115, N'cu+hno3', N'Cu + 4HNO3 → Cu(NO3)2 + 2H2O + 2NO2/3Cu + 8HNO3 → 3Cu(NO3)2 + 4H2O + 2NO/Cu + 2HNO3 → Cu(NO3)2 + H2Điều kiện khác: ở nhiệt độ phòng')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1116, N'agno3', N'2AgNO3 → 2Ag + 2NO2 + O2 Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1117, N'agno3+cu', N'2AgNO3 + Cu → 2Ag + Cu(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1118, N'agno3+no+hcho', N'2AgNO3 + H2O + HCHO + 3NH3 → 2Ag + 2NH4NO3 + HCOONH4 hiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1119, N'agno3+nacl', N'AgNO3 + NaCl → AgCl + NaNO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1120, N'agno3+ch3cho+nh3', N'4AgNO3 + 3CH3CHO + 5NH3 → 4Ag + 3NH4NO3 + 3CH3COONH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1121, N'agno3+nai', N'AgNO3 + NaI → NaNO3 + AgI')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1122, N'agno3+fe(no3)2', N'AgNO3 + Fe(NO3)2 → Ag + Fe(NO3)3 Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1123, N'agno3+hcl', N'AgNO3 + HCl → AgCl + HNO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1124, N'agno3+na2s', N'2AgNO3 + Na2S → 2NaNO3 + Ag2S')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1125, N'agno3+h2o+nh3+c6h12o6', N'2AgNO3 + H2O + 2NH3 + C6H12O6 → 2Ag + 2NH4NO3 + C6H12O7')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1126, N'agno3+h2o+2nh3+hcooc2h5', N'2AgNO3 + H2O + 3NH3 + HCOOC2H5 → 2Ag + 2NH4NO3 + C2H5OCOONH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1127, N'agno3+sn;', N'2AgNO3 + Sn → 2Ag + Sn(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1128, N'agno3+fe', N'2AgNO3 + Fe → 2Ag + Fe(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1129, N'agno3+fecl2', N'2AgNO3 + FeCl2 → 2AgCl + Fe(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1130, N'agno3+fecl3', N'3AgNO3 + FeCl3 → 3AgCl + Fe(NO3)3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1131, N'agno3+h2s', N'2AgNO3 + H2S → 2HNO3 + Ag2S')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1132, N'agno3+na2so4', N'2AgNO3 + Na2SO4 → 2NaNO3 + Ag2SO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1133, N'agno3+kcl', N'AgNO3 + KCl → AgCl + KNO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1134, N'agno3+i2', N'AgNO3 + I2 → AgI + INO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1135, N'agno3+cuo', N'2AgNO3 + CuO → Ag2O + Cu(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1136, N'agno3+feo', N'2AgNO3 + FeO → Ag2O + Fe(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1137, N'agno3+fecl2', N'3AgNO3 + FeCl2 → Ag + 2AgCl + Fe(NO3)3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1138, N'agno3+h2o+nh3+c2h5oh', N'2AgNO3 + H2O + 3NH3 + C2H5CHO → 2Ag + 2NH4NO3 + C2H5COONH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1139, N'agno3+h2o+nh3+c3h7cho', N'2AgNO3 + H2O + 3NH3 + C3H7CHO → 2Ag + 2NH4NO3 + C3H7COONH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1140, N'agno3+h2o+2nh3+c12h22o11', N'2AgNO3 + H2O + 2NH3 + C12H22O11 → 2Ag + NH4NO3 + C12H22O12')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1141, N'agno3+c6h12o6+h2o+nh3', N'2AgNO3 + C6H12O6 + H2O + 2NH3 → 2Ag + 2NH4NO3 + C6H12O7')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1142, N'agno3+c6h12o6', N'2AgNO3 + C6H12O6 + H2O + 3NH3 → 2Ag + 2NH4NO3 + C6H12O7NH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1143, N'agno3+zn', N'2AgNO3 + Zn → 2Ag + Zn(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1144, N'agno3+cucl2', N'2AgNO3 + CuCl2 → 2AgCl + Cu(NO3)2Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1145, N'agno3+fe', N'3AgNO3 + Fe → 3Ag + Fe(NO3)3Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1146, N'agno3+na3po4', N'3AgNO3 + Na3PO4 → 3NaNO3 + Ag3PO4Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1147, N'agno3+nh4cl', N'AgNO3 + NH4Cl → AgCl + NH4NO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1148, N'agno3+bacl2', N'2AgNO3 + BaCl2 → 2AgCl + Ba(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1149, N'agno3+zncl2', N'2AgNO3 + ZnCl2 → 2AgCl + Zn(NO3)2Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1150, N'agno3+cacl2', N'2AgNO3 + CaCl2 → 2AgCl + Ca(NO3)2Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1151, N'agno3+k2so4', N'2AgNO3 + K2SO4 → 2KNO3 + Ag2SO4Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1152, N'agno3+znbr2', N'2AgNO3 + ZnBr2 → 2AgBr + Zn(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1153, N'agno3+nabr', N'AgNO3 + NaBr → AgBr + NaNO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1154, N'agno3+h2o', N'AgNO3 + H2O → Ag + HNO3 + O2Điều kiện khác: điện phân dd')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1155, N'agno3+h2o+nh3', N'AgNO3 + H2O + 3NH3 → NH4NO3 + (Ag(NH3)2)OHNhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1156, N'agno3+bacl2', N'2AgNO3 + BaCl2 → 2AgCl + Ba(NO3)2 + BaCl2Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1157, N'agno+ba(oh)2', N'2AgNO3 + Ba(OH)2 → Ag2O + Ba(NO3)2 + H2O')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1158, N'agno3+ch3cho+nh3', N'4AgNO3 + 3CH3CHO + 5NH3 → 4Ag + 3NH4NO3 + 3CH3COONH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1159, N'agno3+h2o+hcho+nh3', N'4AgNO3 + 2H2O + HCHO + 6NH3 → (NH4)2CO3 + 4Ag + 4NH4NO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1160, N'agno3+h2o+nh3+hcooch3', N'2AgNO3 + H2O + 3NH3 + HCOOCH3 → 2Ag + 2NH4NO3 + NH4OCOOCH3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1161, N'agno3+h2o+nh3+hcooh', N'2AgNO3 + H2O + 4NH3 + HCOOH → (NH4)2CO3 + 2Ag + 2NH4NO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1162, N'agno3+mg', N'2AgNO3 + Mg → 2Ag + Mg(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1163, N'agno3+alcl3', N'3AgNO3 + AlCl3 → 3AgCl + Al(NO3)3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1164, N'agno3+koh', N'2AgNO3 + 2KOH → Ag2O + H2O + 2KNO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1165, N'agno3+h2o+ch3cocl', N'AgNO3 + H2O + CH3COCl → AgCl + CH3COOH + HNO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1166, N'agno3+nh3+c12h22o11', N'40AgNO3 + 14NH3 + 3C12H22O11 → 40Ag + 27NH4NO3 + 36CO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1167, N'agno3+h2o+nh3+hcooc2h5', N'2AgNO3 + H2O + 3NH3 + HCOOC2H5 → 2Ag + 2NH4NO3 + C2H5OCOONH4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1168, N'agno3+koh', N'AgNO3 + KOH → AgOH + KNO3Nhiệt độ: -50°C Dung môi: etanol')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1169, N'agno3+nh3+c12h22o11', N'40AgNO3 + 14NH3 + 3C12H22O11 → 40Ag + 27NH4NO3 + 36CO2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1170, N'(nh4)3po4+agno3', N'(NH4)3PO4 + 3AgNO3 → 3NH4NO3 + Ag3PO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1171, N'agno3+h2o+nh3+hcoor', N'2AgNO3 + 6H2O + 3NH3 + HCOOR → 2Ag + 4NH4NO3 + NH4OCOCH3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1172, N'agno3+geh4', N'4AgNO3 + GeH4 → 4HNO3 + Ag4Ge')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1173, N'agno3+mncl2', N'2AgNO3 + MnCl2 → 2AgCl + Mn(NO3)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1174, N'agno3+na2co3', N'AgNO3 + Na2CO3 → 2NaNO3 + Ag2CO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1175, N'bacl2+ca(oh)2', N'BaCl2 + Ca(OH)2 → Ba(OH)2 + CaCl2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1176, N'ca(oh)2+nahco3', N'Ca(OH)2 + NaHCO3 → CaCO3 + H2O + NaOH')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1177, N'ca(oh)2+co2', N'Ca(OH)2 + CO2 → CaCO3 + H2O')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1178, N'ca(oh2)+cl2', N'Ca(OH)2 + Cl2 → CaOCl2 + H2O')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1179, N'ca(oh)2+h2so4', N'Ca(OH)2 + H2SO4 → 2H2O + CaSO4')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1180, N'ca(oh)2+so2', N'Ca(OH)2 + SO2 → H2O + CaSO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1181, N'ca(oh)2+ch2ohch2cl', N'Ca(OH)2 + CH2OH-CH2Cl → 2H2O + CaCl2 + 2(CH2CH2)O')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1182, N'ca(oh)2+nh4cl', N'Ca(OH)2 + 2NH4Cl → 2H2O + 2NH3 + CaCl2Nhiệt độ: nhiệt độ')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1183, N'ca(oh)2+h2s', N'Ca(OH)2 + H2S → 2H2O + CaS')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1184, N'ca(oh)2+k2co3', N'Ca(OH)2 + K2CO3 → CaCO3 + 2KOH')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1185, N'ca(oh)2+cl2', N'6Ca(OH)2 + 6Cl2 → 6H2O + 5CaCl2 + Ca(ClO3)2/2Ca(OH)2 + 2Cl2 → 2H2O + CaCl2 + Ca(OCl)2')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1186, N'ca(oh)2+ba(hco3)2', N'Ca(OH)2 + Ba(HCO3)2 → CaCO3 + 2H2O + BaCO3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1187, N'ca(oh)2+nh4hco3', N'Ca(OH)2 + NH4HCO3 → CaCO3 + 2H2O + NH3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1188, N'ca(oh)2+naHf2', N'Ca(OH)2 + NaHF2 → CaF2 + H2O + NaOH')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1189, N'ca(oh)2+2nh4no3', N'Ca(OH)2 + 2NH4NO3 → Ca(NO3)2 + 2H2O + 2NH3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1190, N'ca(oh)2+nh4h2po4', N'3Ca(OH)2 + 2NH4H2PO4 → Ca3(PO4)2 + 6H2O + 2NH3')
INSERT [dbo].[ChemicalEquation] ([Number], [Precursors], [ChemicalEquation]) VALUES (1191, N'ca(oh)2+cao', N'Ca(OH)2 → CaO + H2OĐiều kiện khác: ở nhiệt độ cao')
SET IDENTITY_INSERT [dbo].[ChemicalEquation] OFF
GO
SET IDENTITY_INSERT [dbo].[ChemicalLaw] ON 

INSERT [dbo].[ChemicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (2, N'Law of Conservation of Energy', N' In a complete chemical reaction, the mass of the reactants equals the mass of the products. In other words, mass is conserved', N'∑mi=∑mj')
INSERT [dbo].[ChemicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (4, N'pH Law', N'A compound exhibits either acidic or basic properties when neutralized. We determine the pH level', N'pH=7(Neutral)/pH>7(Basic)/pH<7pH<7(Acidic)')
INSERT [dbo].[ChemicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (5, N'Law of Conservation of Elements:', N'In a chemical equation, the number of atoms of each element on the reactant side must be equal to the number of atoms of the same element on the product side', N'n(i)=n(f)')
SET IDENTITY_INSERT [dbo].[ChemicalLaw] OFF
GO
SET IDENTITY_INSERT [dbo].[MathematicalLaw] ON 

INSERT [dbo].[MathematicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (2, N'Pythagorean Theorem', N' In any right-angled triangle, the square of the hypotenuse is equal to the sum of the squares of the other two sides', N'a^2=b^2+c^2 (where a is the hypotenuse, and b and c are the legs))')
INSERT [dbo].[MathematicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (4, N'Ceva''s Theorem', N'In plane geometry, given any point outside a line, there is exactly one line that can be drawn through that point and is parallel to the given line', N'ERROR')
INSERT [dbo].[MathematicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (5, N'Cauchy Inequality (Cosy)', N'ERROR', N'(a1+a2+a3+...+an)>=Pow(a1*a2*a3*...*an,1/n) # và dbxrk a1=a2=a3=..=an')
INSERT [dbo].[MathematicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (6, N'Bất đẳng thức BunhiaCopski', N'ERORR', N'(a1^2+a2^2+a3+...+an)*(b1^2+b2^2+...+bn^2)>=(a1+b1)^2+....+(an+bn)^2 # và dbxrk a1/b2 = a2/b2 = ... = an/bn')
INSERT [dbo].[MathematicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (7, N'Quadratic Inequality', N'ERORR', N'(a1^2+a2^2) >= (2*a1*a2)')
INSERT [dbo].[MathematicalLaw] ([Number], [Name], [Content], [FORMULA]) VALUES (8, N'Vieta''s Formula', N'ERORR', N'x1+x2=-b/a # x1*x2=c/a')
SET IDENTITY_INSERT [dbo].[MathematicalLaw] OFF
GO
SET IDENTITY_INSERT [dbo].[MathematicalTheorem] ON 

INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (1, N'Algebra', N'Inequality formula', N'a>b+c <=> a-c>b')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (2, N'Algebra', N'Cozy Inequality', N'(a1+a2+...+an) >= sqrt((a1*a2*a3...a*n),1/n) first occurs when a1=a2=a3...=an')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (3, N'Algebra', N'Inequalities that treat absolute value signs |...|', N'|a+b|<=|a|+|b| , ||a|+|b||<=|a-b|, "==" occurs when a*b>=0')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (4, N'Algebra', N'Inequalities curing the five-two sign', N'x^2 >= 0')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (5, N'Algebra', N'Common inequality', N'(a^2+b^2)(x^2+y^2)>=(a*x+b*y)^2 (x,y,a,b in R)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (6, N'Algebra', N'Bunhacopski inequality', N'(a(1)^2+a(2)^2+...a(n)^2)*(b(1)^2+b(2)^2+...b(n)^2 )>=(a(1)*b(1)+a(2)*b(2)...a(n)*b(n))^2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (7, N'Algebra', N'Common inequality', N'a>b>0, c>d>0 =>ac>bd')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (8, N'Algebra', N'Common inequality', N'a>b>0, 1/a < 1/b')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (9, N'Algebra', N'Common inequality', N'a>b>0 => a^n>b^n (n > 0)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (10, N'Algebra', N'Common inequality', N'a>b>0 => sqrt(a,n) > sqrt(b,n) ( n>=0 )')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (11, N'Geometry', N'Calculate the area of a circle', N'S=p*r^2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (12, N'Geometry', N'Calculate the area of a square', N'S=r^2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (13, N'Geometry', N'Calculate the area of a rectangle', N'S=a*b')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (14, N'Geometry', N'Calculate the area of a triangle', N'S=1/2*a*b*sin(C)=1/2*b*c*sin(A)=1/2*a*c*sin(B)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (15, N'Geometry', N'Calculate the circumference of a circle', N'2p=p*r*2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (16, N'Geometry', N'Calculate the perimeter of a triangle', N'2p=a+b+c')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (17, N'Geometry', N'Calculate the perimeter of a square', N'2p=4*a')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (18, N'Geometry', N'Calculate the area of a triangle', N'S=sqrt(p*(p-a)*(p-b)*(p-c)) where p is the half circumference')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (19, N'Geometry', N'Calculate the perimeter of a rectangle', N'p=a+b')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (20, N'Geometry', N'Angle 180C', N'180(c)=p (radian)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (21, N'Geometry', N'Angle 1C', N'1C=p/180(radian) => 1 (rad) = 180/p')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (22, N'Geometry', N'tan(a)', N'tan(a)=sin(a)/cos(a)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (23, N'Geometry', N'tan(a)_2', N'1+tan(a)^2=1/(cos(a)^2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (24, N'Geometry', N'cotan(a)_2', N'1+cotan(a)^2=1/(sin(a)^2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (25, N'Geometry', N'sin(a),cos(a)', N'sin(a)^2+cos(a)^2=1')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (26, N'Geometry', N'Trigonometric expression', N'sin(a)^4+cos(a)^4=1-1/2*sin(2*x)^2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (27, N'Geometry', N'Trigonometric expression', N'sin(x)^6+cos(x)^6=1-3/4*sin(2*x)^2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (28, N'Geometry', N'Trigonometric expression', N'-1<sin(x)<1')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (29, N'Geometry', N'Trigonometric expression', N'-1<cos(x)<1')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (30, N'Geometry', N'Trigonometric expression', N'cos(-a)=cosa, sin(-a)=-sin(a)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (31, N'Geometry', N'Trigonometric expression', N'tan(-a)=-tan(a), cotan(-a)=-cotan(a)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (32, N'Geometry', N'Trigonometric expression', N'sin(p - a) = sin(a), cos(p - a)=-cos(a)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (33, N'Geometry', N'Trigonometric expression', N'tan(p-a)=-tan(a),cotan(p-a)=-cotan(a)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (34, N'Geometry', N'Trigonometric expression', N'sin(a)+sin(b)=2*sin((a+b)/2)*cos((a-b)/2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (35, N'Geometry', N'Trigonometric expression', N'sin(a)-sin(b)=2*sin((a+b)/2)*sin((a-b)/2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (36, N'Geometry', N'Trigonometric expression', N'cos(a)+cos(b)=2*cos((a+b)/2)*cos((a-b)/2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (37, N'Geometry', N'Trigonometric expression', N'cos(a)-cos(b)=-2*sin((a+b)/2)*sin((a-b)/2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (38, N'Geometry', N'Trigonometric expression', N'tan(a)+tan(b)=sin(a+b)/(cos(a)*cos(b))')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (39, N'Geometry', N'Trigonometric expression', N'tan(a)-tan(b)=sin(a-b)/(cos(a)*cos(b))')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (40, N'Geometry', N'Trigonometric expression', N'sin(x)+cos(x)=sqrt(2)*sin(x-p/4)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (41, N'Geometry', N'Trigonometric expression', N'sin(x)-cos(x)=-sqrt(2)*sin(x+p/4)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (42, N'Geometry', N'Downgrade_1', N'cos(2*x)=2*cos(x)^2-1=1-2*sin(x)^2')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (43, N'Geometry', N'Downgrade_2', N'sin(2*x)=2*sin(x)*cos(x)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (44, N'Geometry', N'2nd order trigonometric equation', N'a*sin(x)^2+b*sin(x)*cos(x)+cos(x)^2=d')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (45, N'Geometry', N'Trigonometric equation of degree 1', N'a*sin(x)+b*cos(x)=c (a^2+b^2>c^2)')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (46, N'Geometry', N'Symmetric and anti-symmetric equations', N'a*(sin(x)+cos(x))+b*sin(x)*cos(x)+c=0')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (47, N'Algebra', N'Addition rule, when two events are completely different', N'm1+m2+m3...')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (48, N'Algebra', N'Multiplication rule, when two events are related', N'm1*m2*m3...')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (49, N'Algebra', N'Permutation of n elements', N'Number of ways to arrange n elements into n different positions, P(n)=n!')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (50, N'Algebra', N'Combination of input k of n elements', N'has n elements and k places, number of ways to tell the positions;A(k,n)=P(k,n)=n(A)k')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (51, N'Algebra', N'Convolution k of n elements', N'there are n elements, number of ways to arrange n in k places (not including positions);nCk')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (52, N'Algebra', N'Newton Binomial', N'(a+b)^n=nC0*a^n*b^0+nC1*a^n-1*b^1+...+nCn*a^0*b^n')
INSERT [dbo].[MathematicalTheorem] ([Number], [Type], [Name], [FORMULA]) VALUES (53, N'Algebra', N'Probability', N'P| O |=1, P(A)=A/|O|')
SET IDENTITY_INSERT [dbo].[MathematicalTheorem] OFF
GO
SET IDENTITY_INSERT [dbo].[PhysicalConstant] ON 

INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (1, N'mp', N'proton mass', N'1.67262158*10^27', N'kg')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (2, N'mn', N'neutron mass', N'1.67492716*10^-27', N'kg')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (3, N'me', N'electron mass', N'9.310938188*10^-31', N'kg')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (4, N'a0', N'Radius Bo', N'5.291772083*10^-11', N'm')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (5, N'h', N'plank constant', N'6.626068756*10^-34', N'Js')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (6, N'u', N'mass 1u', N'1.66053873*10^-27', N'kg')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (7, N'F', N'Faraday''s constant', N'96485*3415', N'mol/C')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (8, N'e', N'Electron area', N'-1.602176462*10^-19', N'C')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (9, N'NA', N'Avogadro''s constant', N'6.02214199*10^23', N'mol^-1')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (10, N'k', N'Bozotman constant', N'1.3806503*10^-23', N'SI')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (11, N'Vm', N'Molar volume of gas (standard conditions)', N'0.022413996', N'm^3')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (12, N'R', N'Ideal gas constant', N'8.314472', N'J/mol*K')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (13, N'c0', N'Speed of light', N'299792458', N'm*s')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (14, N'Ef0', N'Dielectric constant', N'8.8541878179*10^-12', N'SI')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (15, N'Y0', N'The magnetic constant of vacuum environment', N'1.256637061*10^-6', N'SI')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (16, N'g', N'Gravitational acceleration', N'9.80665', N'm/(s^2))')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (17, N't0', N'Absolute zero temperature', N'273.15', N'K')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (18, N'G', N'Gravitational constant', N'6.673.10^-11', N'(N*m^2)/kg^2')
INSERT [dbo].[PhysicalConstant] ([Number], [Symbol], [Name], [VALUE], [UNIT]) VALUES (19, N'atm', N'Amperometric constant', N'101325', N'Pa')
SET IDENTITY_INSERT [dbo].[PhysicalConstant] OFF
GO
SET IDENTITY_INSERT [dbo].[PhysicalFormula] ON 

INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (1, N'Formula II New Ton', N'The combination of force vectors is equal to the product of acceleration and mass vectors', N'(SUM)F=m*a')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (2, N'Lever arm formula', N'Give me a fulcrum and I will be able to play this game', N'F1/F2=d1/d2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (3, N'Newton''s Third Law', N'When a force is applied to an object, that object will exert a reaction force of equal magnitude', N'F1=F2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (4, N'Formula for force through the east pulley', N'The force through the moving pulley will be reduced by 2 times', N'F''=F/2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (5, N'Formula of force through n movable pulleys', N'Force through n movable pulleys decreases by 2^n times', N'F''=F/(2^n)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (6, N'Formula for distance through n movable pulleys', N'Force through n movable pulleys decreases by 2^n times', N'd''=d*2^n')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (7, N'Looseness formula', N'The displacement vector is equal to the directional product of the velocity vector multiplied by time', N'r=v*t')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (8, N'Distance formula', N'Distance equals average speed and time', N's=v*t')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (9, N'Velocity', N'Displacement and time differential', N'v=dr/dt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (10, N'Speed', N'Magnitude of velocity', N'V=|v|')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (11, N'Acceleration from velocity', N'Acceleration is the differential of velocity with respect to time', N'a=dv/dt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (12, N'Uniform acceleration from speed', N'Acceleration is the rate of change of velocity', N'v(f)=v(i)+a*t')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (13, N'Formula for distance through the east pulley', N'The force through the moving pulley will be reduced by 2 times', N'd''=2*d')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (14, N'Acceleration from departure', N'Acceleration is the differential of velocity, velocity is the differential of displacement', N'a=d(dr/dt)/dt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (15, N'Uniform acceleration from distance', N'Acceleration is the rate of change in speed, speed is the rate of change in distance', N's(f)=s(i)+v(i)*t+*a*(t^2)/2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (16, N'Vector of velocity of object thrown obliquely at angle alpha', N'This speed is considered in two directions Ox,Oy', N'v=v(x)+v(y)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (17, N'Velocity vector on Ox in the slant throwing problem', N'Project vector v onto Ox', N'v(x)=v*cos(alpha)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (18, N'Velocity vector on Oy in the oblique throwing problem', N'Move vector v to Oy', N'v(y)=v*sin(alpha)-gt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (19, N'Skeet throwing process time', N'Equal to the time taken to throw it vertically upward with velocity v(y)', N't=2*v(y)/g')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (20, N'Lorentz force', N'Equal to the directional product of two components, B(magnetic induction), v(velocity)', N'f(L)=-eBv')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (21, N'Magnetic force', N'Equal to the directional product of two components, B(induction), current direction(I)', N'F(F)=-IBl')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (22, N'Circuit efficiency', N'Work has product over total work', N'H=A(ci)/A(tp)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (23, N'External circuit capacity', N'<many>', N'P=U*I=I^2*R=U^2/R')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (24, N'Wasted power', N'Power generated on the transmission line, and internal resistance of the source', N'P(hp)=I^2*r')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (25, N'Internal resistance of an electric wire', N'Product of output resistance with length above gives cross section', N'R = ?(l/S)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (26, N'Jun''s theorem', N'Heat dissipation', N'Q=I^2Rt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (27, N'First Principle of Thermodynamics', N'It states that the change in energy inside ?U of a closed system is equal to the amount of heat Q supplied to the system minus the amount of work A done by the system on the surrounding environment around', N'<ERORR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (28, N'Second Law of Thermodynamics', N'Second Law, or second principle, also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities, either increased, or remained the same', N'<ERORR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (29, N'Newton''s First Law', N'If an object is not acted upon by any force or is acted upon by a total force of zero, an object at rest will remain at rest forever, and an object in motion will move forever', N'<ERORR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (30, N'Newton''s Third Law', N'When object A exerts a force on object B, then object B also exerts a force on object A in the same direction but in opposite directions', N'd(Y/X)=M(Y)/M(X)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (31, N'Newton''s Second Law', N'The total force on an object is equal to the object''s mass multiplied by its acceleration', N'(SUM)F=a*m')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (32, N'Ohm''s law of circuits', N'The voltage difference at both ends of the circuit is equal to CDDD multiplied by resistance', N'(SUM)R*I=U')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (33, N'Ohm''s Law for the whole circuit', N'External circuit voltage equals Electromotive force export minus Potential drop', N'U=E-I.r')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (34, N'Hooke''s Law', N'An elastic object will have an elasticity coefficient k', N'F=-kx')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (35, N'Law of reflection', N'When light is reflected, the reflected ray will lie in the plane containing the incident ray and the normal of the mirror at the point of incidence. The angle of reflection will be equal to the angle of incidence', N'i''=i')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (36, N'Kirchhoff''s First Law', N'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', N'(SUM) I(k)=0')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (37, N'Kirchhoff''s Second Law', N'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', N'(SUM) V(k)=0')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (38, N'Culong''s Law', N'The force of attraction or repulsion between two point charges has a direction that coincides with the straight line connecting those two point charges. Has a magnitude proportional to the magnitude of the two charges and inversely proportional to the square of the distance between them', N'F=k*abs(q1*q2)/(r*r)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (39, N'Faraday''s Law of Induction', N'Faraday''s Law of Induction is a fundamental law in electromagnetism, stating that magnetic fields interact with an electric circuit to create electromotive force (EMF) - a phenomenon called electromagnetic induction. That is the basic operating principle of transformers, inductors, electric motors, generators and electromagnets', N'(Flux)B=(integral)B(r,t).dA')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (40, N'MaxWell Faraday Equation', N'In the case of an inductor with N turns, the formula becomes. In the case of an inductor there are N turns. formula becomes', N'V=-N*(denta)A/(denta)T')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (41, N'Law of straight propagation of light', N'In a transparent and uniform medium, light travels in straight lines', N'<ERORR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (42, N'Law of refraction of light', N'The refracted ray always lies in the plane of incidence and on the other side of the normal from the incident ray. The incident plane is the plane formed by the incident ray and the normal. With 2 certain transparent environments, the ratio between sin i and sin r is a constant', N'sin(i)n(i)=sin(r)n(r).n=c/v.n21=n2/n1.n1i=n2r')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (43, N'Law of light scattering', N'When light passes from one medium to any other medium, for example air, a glass of water, a part of the light is absorbed by particles of the previous medium. Its subsequent radiation is in a specific direction. This phenomenon is called light scattering', N'<ERORR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (44, N'Lorentz''s Law', N'Lorentz force', N'F=q(E+vB)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (45, N'Newton''s Law of Universal Gravitation', N'Every particle attracts every other particle in the universe with a force proportional to the mass product of them and is inversely proportional to the square of the distance between their centers. The publication of this theory is called "the first great unification" for it marks the union of the gravitational phenomena previously described on Earth with known astronomical behavior', N'F=G*(m1m2)/(r^2)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (46, N'Average formula', N'Error', N'(Avg)A=(A1+A2+...+An)/n')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (47, N'Measurement error formula', N'Error', N'?(A1)=|Avg(A)-A1|')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (48, N'How to write error', N'Error', N'A=Avg(A)+/- ?(A)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (49, N'Proportional error', N'ERORR', N'dA=?A/A.')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (50, N'Law of conservation of mass', N'The following mass must be equal to the original', N'm(i)=mf')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (51, N'Principle of conservation of energy', N'Energy remains constant before and after the process', N'W(i)=W(f)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (52, N'Law of conservation of momentum', N'Momentum will be conserved if there is no impulse', N'Smivi=Smfvf')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (53, N'Nuclear energy', N'Nuclear energy', N'E=mc^2. (m is the particle mass). c=310^8 (m/s) is the speed of light')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (54, N'Radiant energy', N'Radiant energy', N'W=hc/?=hf. (c is the speed of light). h is the Boltzmann constant. ? is the wave of light. f is the frequency of light')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (55, N'Pressure in the liquid', N'Pressure in the liquid', N'p=dgh. where d is the density of the liquid. g is the gravitational acceleration. h is the depth')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (56, N'Law of pressure balance', N'In liquid and gas environments, the pressure at two points of equal height will be equal', N'erorr')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (57, N'Formula II New Ton', N'The combination of force vectors is equal to the product of acceleration and mass vectors', N'(SUM)F=ma')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (58, N'Lever arm formula', N'Give me a fulcrum and I''ll be able to play this game', N'F1/F2=d1/d2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (59, N'Newton''s Third Law', N'When a force is applied to an object, that object will exert a reaction force of equal magnitude', N'F1=F2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (60, N'Formula for force through the east pulley', N'The force through the moving pulley will be reduced by 2 times', N'F''=F/2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (61, N'Formula of force through n movable pulleys', N'Force through n movable pulleys decreases by 2^n times', N'F''=F/(2^n)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (62, N'Formula for distance through n movable pulleys', N'Force through n movable pulleys decreases by 2^n times', N'd''=d2^n')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (63, N'Looseness formula', N'The displacement vector is equal to the directional product of the velocity vector multiplied by time', N'r=vt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (64, N'Distance formula', N'Distance equals average speed and time', N's=vt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (65, N'Velocity', N'Displacement and time differential', N'v=dr/dt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (66, N'Speed', N'Magnitude of velocity', N'V=|v|')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (67, N'Acceleration from velocity', N'Acceleration is the differential of velocity with respect to time', N'a=dv/dt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (68, N'Uniform acceleration from speed', N'Acceleration is the rate of change of velocity', N'v(f)=v(i)+at')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (69, N'Formula for distance through the east pulley', N'The force through the moving pulley will be reduced by 2 times', N'd''=2d')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (70, N'Acceleration from departure', N'Acceleration is the differential of velocity, velocity is the differential of displacement', N'a=d(dr/dt)/dt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (71, N'Uniform acceleration from distance', N'Acceleration is the rate of change in speed, speed is the rate of change in distance', N's(f)=s(i)+v(i)t+a(t^2)/2')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (72, N'Vector of velocity of object thrown obliquely at angle alpha', N'This speed is considered in two directions Ox,Oy', N'v=v(x)+v(y)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (73, N'Velocity vector on Ox in the slant throwing problem', N'Project vector v onto Ox', N'v(x)=vcos(alpha)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (74, N'Velocity vector on Oy in the oblique throwing problem', N'Move vector v to Oy', N'v(y)=vsin(alpha)-gt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (75, N'Skeet throwing process time', N'Equal to the time taken to throw it vertically upward with velocity v(y)', N't=2*v(y)/g')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (76, N'Lorentz force', N'Equal to the directional product of two components, B(magnetic induction), v(velocity)', N'f(L)=-eBv')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (77, N'Magnetic force', N'Equal to the directional product of two components, B(induction), current direction(I)', N'F(F)=-IBl')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (78, N'Circuit efficiency', N'Work has product over total work', N'H=A(ci)/A(tp)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (79, N'External circuit capacity', N'<many>', N'P=U*I=I^2*R=U^2/R')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (80, N'Wasted power', N'Power generated on the transmission line, and internal resistance of the source', N'P(hp)=I^2*r')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (81, N'Internal resistance of an electric wire', N'Product of output resistance with length above gives cross section', N'R = ?(l/S)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (82, N'Jun''s theorem', N'Heat dissipation', N'Q=I^2Rt')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (83, N'First Principle of Thermodynamics', N'It states that the change in energy inside ?U of a closed system is equal to the amount of heat Q supplied to the system minus the amount of work A done by the system on the surrounding environment around', N'<ERROR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (84, N'Principle II of HeatDynamics', N'Second law, or second principle. Also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities. Either increased, or remained the same', N'<ERROR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (85, N'Newton''s First Law', N'If an object is not acted upon by any force or is acted upon by a total force of zero, an object at rest will remain at rest forever, and an object in motion will move forever', N'<ERROR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (86, N'Newton''s Third Law', N'When object A exerts a force on object B, then object B also exerts a force on object A in the same direction but in opposite directions', N'd(Y/X)=M(Y)/M(X)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (87, N'Newton''s Second Law', N'The total force on an object is equal to the object''s mass multiplied by its acceleration', N'(SUM)F=a*m')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (88, N'Ohm''s law of circuits', N'The voltage difference at both ends of the circuit is equal to CDDD multiplied by resistance', N'(SUM)R*I=U')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (89, N'Ohm''s Law for the whole circuit', N'External circuit voltage equals Electromotive force export minus Potential drop', N'U=E-I.r')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (90, N'Hooke''s Law', N'An elastic object will have an elasticity coefficient k', N'F=-kx')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (91, N'Law of reflection', N'When light is reflected, the reflected ray will lie in the plane containing the incident ray and the normal of the mirror at the point of incidence. The angle of reflection will be equal to the angle of incidence', N'i''=i')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (92, N'Kirchhoff''s First Law', N'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', N'(SUM) I(k)=0')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (93, N'Kirchhoff''s Second Law', N'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', N'(SUM) V(k)=0')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (94, N'Culong''s Law', N'The force of attraction or repulsion between two point charges has a direction that coincides with the straight line connecting those two point charges. Has a magnitude proportional to the magnitude of the two charges and inversely proportional to the square of the distance between them', N'F=k*abs(q1*q2)/(r*r)')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (95, N'Faraday''s Law of Induction', N'Faraday''s Law of Induction is a fundamental law in electromagnetism, stating that magnetic fields interact with an electric circuit to create electromotive force (EMF) - a phenomenon called electromagnetic induction. That is the basic operating principle of transformers, inductors, electric motors, generators and electromagnets', N'(Flux)B=(integral)B(r,t).dA')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (96, N'Maxwell Faraday Equation', N'In the case of an inductor with N turns, the formula becomes. In the case of an inductor there are N turns. Formula becomes', N'V=-N*(denta)A/(denta)T')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (97, N'Law of straight propagation of light', N'Law of straight propagation of light. In a transparent and uniform medium, light travels in straight lines', N'<ERROR>')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (98, N'Law of refraction of light', N'Law of refraction of light is explained as follows. The refracted ray always lies in the plane of incidence and on the other side of the normal from the incident ray. The incident plane is the plane formed by the incident ray and the normal. With 2 certain transparent environments. The ratio between sin i and sin r is a constant', N'sin(i)*n(i)=sin(r)*n(r).n=c/v.n21=n2/n1.n1i=n2r')
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (99, N'Law of light scattering', N'When light passes from one medium to any other medium, for example air, a glass of water, a part of the light is absorbed by particles of the previous medium. Its subsequent radiation is in a specific direction. This phenomenon is called light scattering', N'<ERROR>')
GO
INSERT [dbo].[PhysicalFormula] ([Number], [Name], [Content], [Formula]) VALUES (100, N'Lorentz''s Law', N'Lorentz force', N'F=q*(E+v*B)')
SET IDENTITY_INSERT [dbo].[PhysicalFormula] OFF
GO
SET IDENTITY_INSERT [dbo].[PhysicalLaw] ON 

INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (1, N'Lorentz force', N'equal to the directional product of two components, B(magnetic induction), v(velocity)', N'f(L)=-eBv')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (2, N'Magnetic force', N'equal to the directional product of two components, B(induction), current direction(I)', N'F(F)=-IBl')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (3, N'Circuit efficiency', N'Work has product over total work', N'H=A(ci)/A(tp)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (4, N'External circuit power', N'<many ways>', N'P=U*I=I^2*R=U^2/R')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (5, N'Wasted power', N'power generated on the transmission line, and internal resistance of the source', N'P(hp)=I^2*r')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (6, N'Internal resistance of an electric wire', N'product of output resistance with length above gives cross section', N'R = ?(l/S)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (7, N'Jun''s theorem', N'heat dissipation', N'Q=I^2Rt')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (8, N'First Principle of Thermodynamics', N'It states that the change in energy.inside ?U of a closed system is equal to the amount of heat Q supplied to the system.minus the amount of work A done by the system on the surrounding environment around', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (9, N'Second Law of Thermodynamics', N'Second Law, or second principle. also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities. either increased, or remained the same', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (10, N'Newton''s First Law', N'If an object is not acted upon by any force or is acted upon by a total force of zero, an object at rest will remain at rest forever. and an object in motion will move forever', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (11, N'Newton''s Third Law', N'When object A exerts a force on object B. then object B also exerts a force on object A in the same direction but in opposite directions; d(Y/X)=M(Y)/M(X)', N'')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (12, N'Newton''s Second Law', N'The total force on an object is equal to the object''s mass multiplied by its acceleration', N'(SUM)F=a*m')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (13, N'Ohm''s law of circuits', N'The voltage difference at both ends of the circuit is equal to CDDD multiplied by resistance', N'(SUM)R*I=U')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (14, N'Ohm''s Law for the whole circuit', N'External circuit voltage equals Electromotive force export minus Potential drop', N'U=E-I.r')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (15, N'Hooke''s Law', N'An elastic object will have an elasticity coefficient k', N'F=-kx')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (16, N'Law of reflection', N'When light is reflected, the reflected ray will lie in the plane containing the incident ray and the normal of the mirror at the point of incidence. The angle of reflection will be equal to the angle of incidence', N'i''=i')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (17, N'Kirchhoff''s First Law', N'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', N'(SUM) I(k)=0')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (18, N'Kirchhoff''s Second Law', N'In electrical circuits, Kirchhoff''s laws are two equations to describe the relationship between current and voltage. These laws were formulated by Gustav Kirchhoff in 1845', N'(SUM) V(k)=0')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (19, N'Culong''s Law', N'The force of attraction or repulsion between two point charges has a direction that coincides with the straight line connecting those two point charges. has a magnitude proportional to the magnitude of the two charges and inversely proportional to the square of the distance between them', N'F=k*abs(q1*q2)/(r*r)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (20, N'Faraday''s Law of Induction', N'Faraday''s Law of Induction is a fundamental law in electromagnetism, stating that magnetic fields interact with an electric circuit to create electromotive force (EMF) - a phenomenon called electromagnetic induction. That is the basic operating principle of transformers, inductors, electric motors, generators and electromagnets', N'(Flux)B=(integral)B(r,t).dA')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (21, N'MaxWell Faraday Equation', N'In the case of an inductor with N turns, the formula becomes. In the case of an inductor there are N turns. formula becomes', N'V=-N*(denta)A/(denta)T')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (22, N'Law of straight propagation of light', N'Law of straight propagation of light. “In a transparent and uniform medium, light travels in straight lines', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (23, N'Law of refraction of light', N'Law of refraction of light is explained as follows. The refracted ray always lies in the plane of incidence and on the other side of the normal from the incident ray. The incident plane is the plane formed by the incident ray and the normal. With 2 certain transparent environments. the ratio between sin i and sin r is a constant', N'sin(i)*n(i)=sin(r)*n(r).n=c/v.n21=n2/n1.n1i=n2r')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (24, N'Law of light scattering', N'When light passes from one medium to any other medium, for example air, a glass of water, a part of the light is absorbed by particles of the previous medium. Its subsequent radiation is in a specific direction. This phenomenon is called light scattering', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (25, N'Lorentz''s Law', N'Lorentz force; F=q*(E+v*B)', N'')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (26, N'Newton''s Law of Universal Gravitation', N'Newton''s law of universal gravitation is often stated. that every particle attracts every other particle .in the universe with a force proportional to the mass product. of them and is inversely proportional to the square of the distance .between their centers.[note 1] The publication of this theory is .called " the first great unification ". for it marks the union of the gravitational phenomena previously described. on Earth with known astronomical behavior', N'F=G*(m1*m2)/(r^2)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (27, N'speed', N'magnitude of velocity', N'V=|v|')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (28, N'Acceleration from velocity', N'acceleration is the differential of velocity with respect to time', N'a=dv/dt')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (29, N'Uniform acceleration from speed', N'acceleration is the rate of change of velocity', N'v(f)=v(i)+a*t')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (30, N'Formula for distance through the east pulley', N'The force through the moving pulley will be reduced by 2 times', N'd''=2*d')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (31, N'acceleration from departure', N'acceleration is the differential of velocity, velocity is the differential of displacement', N'a= d(dr/dt)/dt')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (32, N'uniform acceleration from distance', N'acceleration is the rate of change in speed, speed is the rate of change in distance', N's(f)=s(i)+v(i)*t+*a*(t^2)/2')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (33, N'vector of velocity of object thrown obliquely at angle alpha', N'This speed is considered in two directions Ox,Oy', N'v=v(x)+v(y)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (34, N'velocity vector on Ox in the slant throwing problem', N'Project vector v onto Ox', N'v(x)=v*cos(alpha)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (35, N'velocity vector on Oy in the oblique throwing problem', N'Move vector v to Oy', N'v(y)=v*sin(alpha)-gt')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (36, N'skeet throwing process time', N'equal to the time taken to throw it vertically upward with velocity v(y)', N't=2*v(y)/g')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (37, N'Lorentz force', N'equal to the directional product of two components, B(magnetic induction), v(velocity)', N'f(L)=-eBv')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (38, N'Magnetic force', N'equal to the directional product of two components, B(induction), current direction(I)', N'F(F)=-IBl')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (39, N'Electrical circuit efficiency', N'Work has product over total work', N'H=A(ci)/A(tp)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (40, N'External circuit capacity', N'<many>', N'P=U*I=I^2*R=U^2/R')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (41, N'Internal resistance of an electric wire', N'product of output resistance with length above gives cross section', N'R = ?(l/S)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (42, N'Jun''s theorem', N'heat dissipation', N'Q=I^2Rt')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (43, N'First Principle of Thermodynamics', N'It states that the change in energy.inside ?U of a closed system is equal to the amount of heat Q supplied to the system.minus the amount of work A done by the system on the medium. surrounding field', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (44, N'Second Law of Thermodynamics', N'Second Law, or second principle. also known as the principle of entropy, relates to the irreversibility of a thermodynamic process and proposes the concept of entropy. This principle states that the entropy of a closed system has only two possibilities. either increased, or remained the same', N'<ERORR>')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (45, N'proportional error', N'ERORR', N'dA=?A/A')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (46, N'Law of conservation of mass', N'The following mass must be equal to the original', N'm(i)=mf')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (47, N'Principle of conservation of energy', N'energy remains constant before and after the process', N'W(i)=W(f)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (48, N'Law of conservation of momentum', N'Momentum will be conserved if there is no impulse', N'Smi*vi=Smf*vf')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (49, N'Nuclear energy', N'', N'E=m*c^2. (m is the particle mass). c=3*10^8 (m/s) is the speed of light')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (50, N'Radiant energy', N'', N'W=hc/?=hf. (c is the speed of light). h is the botzman constant. ? is the wave of light. f is the frequency of light')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (51, N'Pressure in the liquid', N'p=dgh. where d is the density of the liquid. g is the gravitational acceleration. h is the depth', N'')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (52, N'Law of pressure balance', N'In liquid and gas environments, the pressure at two points of equal height will be equal', N'erorr')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (53, N'Formula II New Ton', N'"The combination of force vectors is equal to the product of acceleration and mass vectors"', N'(SUM)F=m*a')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (54, N'Lever arm formula', N'"Give me a fulcrum and I''ll be able to play this game"', N'F1/F2=d1/d2')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (55, N'Newton''s Third Law', N'"When a force is applied to an object, that object will exert a reaction force of equal magnitude"', N'F1=F2')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (56, N'Formula for force through the east pulley', N'The force through the movable pulley will be reduced by 2 times', N'F''=F/2')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (57, N'Formula of force through n movable pulleys', N'force through n movable pulleys decreases by 2^n times', N'F''=F/(2^n)')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (58, N'Formula for distance through n movable pulleys', N'force through n movable pulleys decreases by 2^n times', N'd''=d*2^n')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (59, N'Looseness formula', N'The displacement vector is equal to the directional product of the velocity vector multiplied by time', N'r=v*t')
INSERT [dbo].[PhysicalLaw] ([Number], [Name], [Content], [Formula]) VALUES (60, N'Distance formula', N'Distance equals average speed and time', N's=v*t')
SET IDENTITY_INSERT [dbo].[PhysicalLaw] OFF
GO
