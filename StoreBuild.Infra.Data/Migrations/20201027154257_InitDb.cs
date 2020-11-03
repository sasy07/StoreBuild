using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreBuild.Infra.Data.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    Password = table.Column<string>(maxLength: 64, nullable: false),
                    Mobile = table.Column<string>(maxLength: 16, nullable: false),
                    IdentificationCode = table.Column<string>(maxLength: 64, nullable: false),
                    ConfirmationCode = table.Column<int>(maxLength: 16, nullable: false),
                    RegisterIp = table.Column<string>(maxLength: 32, nullable: false),
                    LastLoginIp = table.Column<string>(maxLength: 32, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    EmailConfirmation = table.Column<bool>(nullable: false),
                    MobileConfirmation = table.Column<bool>(nullable: false),
                    TwoFactorAuthentication = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
