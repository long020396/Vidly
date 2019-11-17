namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'54ac5ce2-7832-4f0b-bb29-33ce6f44dc68', N'admin@vidly.com', 0, N'AOYU3fWHM2wIhk6GOP65v0070X2Lx92k0th82DMJYxDvpqlO8+Y8H/rh9PFOSIqoaA==', N'f9da6f16-ff86-43cd-bf7e-7dea070b5a6b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e57bc80-5fe5-4048-a6a2-7f7984332ffb', N'long020396@vidly.com', 0, N'ACnxYgTDGShIT8WIBkVqHi9wc7vNdmdg8U9jctcDmYYous23JHM5RavFYhf2e3B+PA==', N'c8929050-ac00-499f-ac6e-4b7455324169', NULL, 0, 0, NULL, 1, 0, N'long020396@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1b165988-06c4-4e13-9b72-76923cc21b1f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'54ac5ce2-7832-4f0b-bb29-33ce6f44dc68', N'1b165988-06c4-4e13-9b72-76923cc21b1f')
");
        }

        public override void Down()
        {
        }
    }
}
