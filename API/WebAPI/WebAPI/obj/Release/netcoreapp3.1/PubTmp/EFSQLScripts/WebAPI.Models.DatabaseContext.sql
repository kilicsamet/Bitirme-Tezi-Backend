IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221207164627_InitialCreate')
BEGIN
    CREATE TABLE [subelers] (
        [SubelerID] int NOT NULL IDENTITY,
        [SubelerName] nvarchar(max) NULL,
        [SubelerIl] nvarchar(max) NULL,
        [SubelerAdres] nvarchar(max) NULL,
        [SubelerTelefon] nvarchar(max) NULL,
        [SubelerImageURL] nvarchar(max) NULL,
        CONSTRAINT [PK_subelers] PRIMARY KEY ([SubelerID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221207164627_InitialCreate')
BEGIN
    CREATE TABLE [urunlers] (
        [UrunlerID] int NOT NULL IDENTITY,
        [UrunlerName] nvarchar(max) NULL,
        [UrunlerUzunAciklama] nvarchar(max) NULL,
        [UrunlerKisaAciklama] nvarchar(max) NULL,
        [UrunlerImageURL] nvarchar(max) NULL,
        CONSTRAINT [PK_urunlers] PRIMARY KEY ([UrunlerID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221207164627_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221207164627_InitialCreate', N'5.0.17');
END;
GO

COMMIT;
GO

