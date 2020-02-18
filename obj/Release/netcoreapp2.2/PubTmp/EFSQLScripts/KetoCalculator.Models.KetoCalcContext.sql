IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [DayRecipeFood] (
        [RecipeID] uniqueidentifier NOT NULL,
        [FoodID] uniqueidentifier NOT NULL,
        [RecipeDate] date NOT NULL,
        [Grams] decimal(18, 2) NOT NULL,
        [UpdateDateTime] datetime2(0) NOT NULL,
        CONSTRAINT [PK_DayRecipeFood] PRIMARY KEY ([RecipeID], [FoodID], [RecipeDate])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [DayRecipes] (
        [RecipeID] uniqueidentifier NOT NULL,
        [RecipeDate] date NOT NULL,
        [RecipeName] nvarchar(100) NOT NULL,
        [RecipieUser] uniqueidentifier NOT NULL,
        [Calories] decimal(18, 2) NOT NULL,
        [Ratio] decimal(18, 2) NOT NULL,
        [UpdateDateTime] datetime2(0) NOT NULL,
        CONSTRAINT [PK_DayRecipes] PRIMARY KEY ([RecipeID], [RecipeDate])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [FoodGroup] (
        [FoodGroupID] uniqueidentifier NOT NULL,
        [FoodGroupName] nvarchar(100) NOT NULL,
        [UpdateDatetime] datetime2(0) NOT NULL,
        CONSTRAINT [PK_FoodGroup] PRIMARY KEY ([FoodGroupID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [Recipes] (
        [RecipeID] uniqueidentifier NOT NULL,
        [RecipeName] nvarchar(100) NOT NULL,
        [RecipieUser] uniqueidentifier NULL,
        [Calories] decimal(18, 2) NOT NULL,
        [Ratio] decimal(18, 2) NOT NULL,
        [UpdateDateTime] datetime2(0) NOT NULL,
        CONSTRAINT [PK_Recipes] PRIMARY KEY ([RecipeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [FoodStuff] (
        [FoodID] uniqueidentifier NOT NULL,
        [FoodGroupID] uniqueidentifier NOT NULL,
        [FoodName] nvarchar(100) NOT NULL,
        [ProteinPer100] numeric(18, 2) NOT NULL,
        [FatPer100] numeric(18, 2) NOT NULL,
        [CarbPer100] numeric(18, 2) NOT NULL,
        [UpdateDateTime] datetime2(0) NOT NULL,
        CONSTRAINT [PK_FoodStuff] PRIMARY KEY ([FoodID]),
        CONSTRAINT [FK_FoodStuff_FoodGroup] FOREIGN KEY ([FoodGroupID]) REFERENCES [FoodGroup] ([FoodGroupID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE TABLE [RecipeFood] (
        [RecipeID] uniqueidentifier NOT NULL,
        [FoodID] uniqueidentifier NOT NULL,
        [Grams] decimal(18, 2) NOT NULL,
        [UpdateDateTime] datetime2(0) NOT NULL,
        CONSTRAINT [PK_RecipeFood] PRIMARY KEY ([RecipeID], [FoodID]),
        CONSTRAINT [FK_RecipeFood_FoodStuff] FOREIGN KEY ([FoodID]) REFERENCES [FoodStuff] ([FoodID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_RecipeFood_Recipes] FOREIGN KEY ([RecipeID]) REFERENCES [Recipes] ([RecipeID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE ([NormalizedName] IS NOT NULL);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE ([NormalizedUserName] IS NOT NULL);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [IX_FoodStuff_FoodGroupID] ON [FoodStuff] ([FoodGroupID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    CREATE INDEX [IX_RecipeFood_FoodID] ON [RecipeFood] ([FoodID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191103191747_dbmigrate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191103191747_dbmigrate', N'2.2.6-servicing-10079');
END;

GO

