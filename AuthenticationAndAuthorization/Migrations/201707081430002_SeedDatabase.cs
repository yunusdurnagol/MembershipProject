namespace AuthenticationAndAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDatabase : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'76c0d61d-aedc-4b5d-aea5-ee51b3aa5b66', N'admin@gmail.com', 0, N'AP/zLQJKENiWxsfFJFMjbVlrlaKrpObRlkBh2r4WFqk5Hac+fvlmqNnhbFZsqH52KA==', N'372c718f-ceef-4e3d-9c6f-5b45ecd2a9f8', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'cb3fc870-d0ea-4a77-a18c-084d8b08fadd', N'guest@gmail.com', 0, N'AO49rXYwVKMXork87FXVTtJpagq+RD1Sp9P5LU03eRxEVAE0clzpFSziyt2Ur9fu0A==', N'383371cc-0a1c-4774-b475-0349e6e5bfab', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
");
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'56a2e6dd-fa0a-4d41-87d4-de8e99752252', N'CanManageMovies')
");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'76c0d61d-aedc-4b5d-aea5-ee51b3aa5b66', N'56a2e6dd-fa0a-4d41-87d4-de8e99752252')
");
        }
        
        public override void Down()
        {
        }
    }
}
