IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'00000000000000_CreateIdentitySchema', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [Championship] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Title] int NOT NULL,
        [RunnerUp] int NOT NULL,
        [Playoff1] int NOT NULL,
        [Playoff2] int NOT NULL,
        [Playoff3] int NOT NULL,
        [Playoff4] int NOT NULL,
        [PlayoffWinner] int NOT NULL,
        [Relegation1] int NOT NULL,
        [Relegation2] int NOT NULL,
        [Relegation3] int NOT NULL,
        CONSTRAINT [PK_Championship] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [ChampionsLge] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [QF1] int NOT NULL,
        [QF2] int NOT NULL,
        [QF3] int NOT NULL,
        [QF4] int NOT NULL,
        [QF5] int NOT NULL,
        [QF6] int NOT NULL,
        [QF7] int NOT NULL,
        [QF8] int NOT NULL,
        [SF1] int NOT NULL,
        [SF2] int NOT NULL,
        [SF3] int NOT NULL,
        [SF4] int NOT NULL,
        [Winner] int NOT NULL,
        [RunnerUp] int NOT NULL,
        [TopScoreTeam] int NOT NULL,
        [TopScorePlayer] nvarchar(max) NULL,
        CONSTRAINT [PK_ChampionsLge] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [ChristmasPredictions] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Top] int NOT NULL,
        [Bottom] int NOT NULL,
        [ManagersOut] int NOT NULL,
        [PointsDifference] int NOT NULL,
        [PointsClear] int NOT NULL,
        CONSTRAINT [PK_ChristmasPredictions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [Completions] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [ScoresCom] bit NOT NULL,
        [FirstsCom] bit NOT NULL,
        [FinalCom] bit NOT NULL,
        [EoSCom] bit NOT NULL,
        [ChampionsLgeCom] bit NOT NULL,
        [FACupCom] bit NOT NULL,
        [ChampionshipCom] bit NOT NULL,
        [LeagueOneCom] bit NOT NULL,
        [LeagueTwoCom] bit NOT NULL,
        [NationalLeagueCom] bit NOT NULL,
        CONSTRAINT [PK_Completions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [FACup] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [QF1] int NOT NULL,
        [QF2] int NOT NULL,
        [QF3] int NOT NULL,
        [QF4] int NOT NULL,
        [QF5] int NOT NULL,
        [QF6] int NOT NULL,
        [QF7] int NOT NULL,
        [QF8] int NOT NULL,
        [SF1] int NOT NULL,
        [SF2] int NOT NULL,
        [SF3] int NOT NULL,
        [SF4] int NOT NULL,
        [Winner] int NOT NULL,
        [RunnerUp] int NOT NULL,
        CONSTRAINT [PK_FACup] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [Firsts] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Score25] int NOT NULL,
        [Score50] int NOT NULL,
        [Score75] int NOT NULL,
        [Score100] int NOT NULL,
        [Con25] int NOT NULL,
        [Con50] int NOT NULL,
        [Con75] int NOT NULL,
        [Con100] int NOT NULL,
        [TeamHattrick] int NOT NULL,
        [TeamLoseManager] int NOT NULL,
        [Score5in1] int NOT NULL,
        [Con5in1] int NOT NULL,
        [Win5inRow] int NOT NULL,
        [Lose5inRow] int NOT NULL,
        [TwoReds] int NOT NULL,
        [Win20] int NOT NULL,
        CONSTRAINT [PK_Firsts] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [LeagueOne] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Title] int NOT NULL,
        [RunnerUp] int NOT NULL,
        [Playoff1] int NOT NULL,
        [Playoff2] int NOT NULL,
        [Playoff3] int NOT NULL,
        [Playoff4] int NOT NULL,
        [PlayoffWinner] int NOT NULL,
        [Relegation1] int NOT NULL,
        [Relegation2] int NOT NULL,
        [Relegation3] int NOT NULL,
        CONSTRAINT [PK_LeagueOne] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [LeagueTwo] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Title] int NOT NULL,
        [RunnerUp] int NOT NULL,
        [Playoff1] int NOT NULL,
        [Playoff2] int NOT NULL,
        [Playoff3] int NOT NULL,
        [Playoff4] int NOT NULL,
        [PlayoffWinner] int NOT NULL,
        [Relegation1] int NOT NULL,
        [Relegation2] int NOT NULL,
        [Relegation3] int NOT NULL,
        CONSTRAINT [PK_LeagueTwo] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [NationalLeague] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Title] int NOT NULL,
        [PlayoffWinner] int NOT NULL,
        CONSTRAINT [PK_NationalLeague] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [PaymentConfirmations] (
        [Id] int NOT NULL,
        [UsersId] int NOT NULL,
        [Year] int NOT NULL,
        CONSTRAINT [PK_PaymentConfirmations] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [Scores] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Score1] int NOT NULL,
        [Score2] int NOT NULL,
        [Score3] int NOT NULL,
        [Score4] int NOT NULL,
        [Score5] int NOT NULL,
        [Score6] int NOT NULL,
        [Score7] int NOT NULL,
        [Score8] int NOT NULL,
        [Score9] int NOT NULL,
        [Score10] int NOT NULL,
        [Score11] int NOT NULL,
        [Score12] int NOT NULL,
        [Score13] int NOT NULL,
        [Score14] int NOT NULL,
        [Score15] int NOT NULL,
        [Score16] int NOT NULL,
        [Score17] int NOT NULL,
        [Score18] int NOT NULL,
        [Score19] int NOT NULL,
        [Score20] int NOT NULL,
        [Score21] int NOT NULL,
        [Score22] int NOT NULL,
        [Score23] int NOT NULL,
        [Score24] int NOT NULL,
        [Score25] int NOT NULL,
        [Score26] int NOT NULL,
        [Score27] int NOT NULL,
        [Score28] int NOT NULL,
        [Score29] int NOT NULL,
        [Score30] int NOT NULL,
        [Score31] int NOT NULL,
        [Score32] int NOT NULL,
        [Score33] int NOT NULL,
        [Score34] int NOT NULL,
        [Score35] int NOT NULL,
        [Score36] int NOT NULL,
        [Score37] int NOT NULL,
        [Score38] int NOT NULL,
        [Score39] int NOT NULL,
        [Score40] int NOT NULL,
        [Score41] int NOT NULL,
        [Score42] int NOT NULL,
        [Score43] int NOT NULL,
        [Score44] int NOT NULL,
        [Score45] int NOT NULL,
        [Score46] int NOT NULL,
        [Score47] int NOT NULL,
        [Score48] int NOT NULL,
        [Score49] int NOT NULL,
        [Score50] int NOT NULL,
        [Score51] int NOT NULL,
        [Score52] int NOT NULL,
        [Score53] int NOT NULL,
        [Score54] int NOT NULL,
        [Score55] int NOT NULL,
        [Score56] int NOT NULL,
        [Score57] int NOT NULL,
        [Score58] int NOT NULL,
        [Score59] int NOT NULL,
        [Score60] int NOT NULL,
        [Score61] int NOT NULL,
        [Score62] int NOT NULL,
        [Score63] int NOT NULL,
        [Score64] int NOT NULL,
        [Score65] int NOT NULL,
        [Score66] int NOT NULL,
        [Score67] int NOT NULL,
        [Score68] int NOT NULL,
        [Score69] int NOT NULL,
        [Score70] int NOT NULL,
        [Score71] int NOT NULL,
        [Score72] int NOT NULL,
        [Score73] int NOT NULL,
        [Score74] int NOT NULL,
        [Score75] int NOT NULL,
        [Score76] int NOT NULL,
        [Score77] int NOT NULL,
        [Score78] int NOT NULL,
        CONSTRAINT [PK_Scores] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    CREATE TABLE [Tables] (
        [Id] int NOT NULL,
        [User] nvarchar(max) NULL,
        [Place1] int NOT NULL,
        [Place2] int NOT NULL,
        [Place3] int NOT NULL,
        [Place4] int NOT NULL,
        [Place5] int NOT NULL,
        [Place6] int NOT NULL,
        [Place7] int NOT NULL,
        [Place8] int NOT NULL,
        [Place9] int NOT NULL,
        [Place10] int NOT NULL,
        [Place11] int NOT NULL,
        [Place12] int NOT NULL,
        [Place13] int NOT NULL,
        [Place14] int NOT NULL,
        [Place15] int NOT NULL,
        [Place16] int NOT NULL,
        [Place17] int NOT NULL,
        [Place18] int NOT NULL,
        [Place19] int NOT NULL,
        [Place20] int NOT NULL,
        CONSTRAINT [PK_Tables] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190411083602_InitialTransfer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190411083602_InitialTransfer', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190412094010_AddNamesToUserAccount')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FirstName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190412094010_AddNamesToUserAccount')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [LastName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190412094010_AddNamesToUserAccount')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190412094010_AddNamesToUserAccount', N'2.2.4-servicing-10062');
END;

GO

