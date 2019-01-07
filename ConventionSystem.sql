USE [ConventionSystem]
GO

/****** Object:  Table [dbo].[Attendee]    Script Date: 1/7/2019 9:54:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Attendee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[TicketType] [varchar](50) NOT NULL,
	[DaysOfAttend] [int] NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Attendee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AttendeesPerEvent]    Script Date: 1/7/2019 9:54:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AttendeesPerEvent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NULL,
	[AttendeeId] [int] NULL,
 CONSTRAINT [PK_AttendeesPerEvent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AttendeesPerStall]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AttendeesPerStall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AttendeeId] [int] NULL,
	[StallId] [int] NULL,
	[AttendeeExhibitDate] [date] NOT NULL,
 CONSTRAINT [PK_AttendeesPerStall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[AudiencePerSeminar]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AudiencePerSeminar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeminarId] [int] NULL,
	[AttendeeId] [int] NULL,
 CONSTRAINT [PK_AudiencePerSeminar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Event]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Event](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](250) NOT NULL,
	[EventDateTime] [datetime] NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[PresentersPerSeminar]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PresentersPerSeminar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeminarId] [int] NULL,
	[AttendeeId] [int] NULL,
 CONSTRAINT [PK_PresentersPerSeminar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[RoomStallLocation]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RoomStallLocation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](500) NULL,
	[Capacity] [int] NULL,
	[Resource] [varchar](500) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Seminar]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Seminar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](250) NOT NULL,
	[SeminarDateTime] [datetime] NOT NULL,
	[RoomSize] [int] NOT NULL,
	[Duration] [decimal](18, 0) NOT NULL,
	[RoomStallLocationId] [int] NULL,
 CONSTRAINT [PK_Seminar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Stall]    Script Date: 1/7/2019 9:54:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomStallLocationId] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[StallType] [varchar](50) NULL,
 CONSTRAINT [PK_Stall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AttendeesPerEvent]  WITH CHECK ADD  CONSTRAINT [FK_AttendeesPerEvent_Attendee] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AttendeesPerEvent] CHECK CONSTRAINT [FK_AttendeesPerEvent_Attendee]
GO

ALTER TABLE [dbo].[AttendeesPerEvent]  WITH CHECK ADD  CONSTRAINT [FK_AttendeesPerEvent_Event] FOREIGN KEY([EventId])
REFERENCES [dbo].[Event] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AttendeesPerEvent] CHECK CONSTRAINT [FK_AttendeesPerEvent_Event]
GO

ALTER TABLE [dbo].[AttendeesPerStall]  WITH CHECK ADD  CONSTRAINT [FK_AttendeesPerStall_Attendee] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AttendeesPerStall] CHECK CONSTRAINT [FK_AttendeesPerStall_Attendee]
GO

ALTER TABLE [dbo].[AttendeesPerStall]  WITH CHECK ADD  CONSTRAINT [FK_AttendeesPerStall_Stall] FOREIGN KEY([StallId])
REFERENCES [dbo].[Stall] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AttendeesPerStall] CHECK CONSTRAINT [FK_AttendeesPerStall_Stall]
GO

ALTER TABLE [dbo].[AudiencePerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_AudiencePerSeminar_Attendee] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([Id])
GO

ALTER TABLE [dbo].[AudiencePerSeminar] CHECK CONSTRAINT [FK_AudiencePerSeminar_Attendee]
GO

ALTER TABLE [dbo].[AudiencePerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_AudiencePerSeminar_Seminar] FOREIGN KEY([SeminarId])
REFERENCES [dbo].[Seminar] ([Id])
GO

ALTER TABLE [dbo].[AudiencePerSeminar] CHECK CONSTRAINT [FK_AudiencePerSeminar_Seminar]
GO

ALTER TABLE [dbo].[PresentersPerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_PresentersPerSeminar_Attendee] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PresentersPerSeminar] CHECK CONSTRAINT [FK_PresentersPerSeminar_Attendee]
GO

ALTER TABLE [dbo].[PresentersPerSeminar]  WITH CHECK ADD  CONSTRAINT [FK_PresentersPerSeminar_Seminar] FOREIGN KEY([SeminarId])
REFERENCES [dbo].[Seminar] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PresentersPerSeminar] CHECK CONSTRAINT [FK_PresentersPerSeminar_Seminar]
GO

ALTER TABLE [dbo].[Seminar]  WITH CHECK ADD  CONSTRAINT [FK_Seminar_RoomStallLocation] FOREIGN KEY([RoomStallLocationId])
REFERENCES [dbo].[RoomStallLocation] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Seminar] CHECK CONSTRAINT [FK_Seminar_RoomStallLocation]
GO

ALTER TABLE [dbo].[Stall]  WITH CHECK ADD  CONSTRAINT [FK_Stall_RoomStallLocation] FOREIGN KEY([RoomStallLocationId])
REFERENCES [dbo].[RoomStallLocation] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Stall] CHECK CONSTRAINT [FK_Stall_RoomStallLocation]
GO


