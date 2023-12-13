CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Users" (
    /*"ID" TEXT NOT NULL CONSTRAINT "PK_Users" PRIMARY KEY,
    */
    "FirstName" TEXT NULL,
    "LastName" TEXT NULL,
    "Email" TEXT NULL,
    "Password" TEXT NULL,
    "PhoneNumber" TEXT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230527183243_InitialMigration', '7.0.5');

COMMIT;

