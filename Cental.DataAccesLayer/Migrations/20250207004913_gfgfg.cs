using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cental.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class gfgfg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSocials",
                table: "UserSocials");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserSocials");

            migrationBuilder.RenameColumn(
                name: "İcon",
                table: "UserSocials",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "UserSocialUd",
                table: "UserSocials",
                newName: "UserSocialId");

            migrationBuilder.AlterColumn<int>(
                name: "UserSocialId",
                table: "UserSocials",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSocials",
                table: "UserSocials",
                column: "UserSocialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSocials",
                table: "UserSocials");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "UserSocials",
                newName: "İcon");

            migrationBuilder.RenameColumn(
                name: "UserSocialId",
                table: "UserSocials",
                newName: "UserSocialUd");

            migrationBuilder.AlterColumn<int>(
                name: "UserSocialUd",
                table: "UserSocials",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserSocials",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSocials",
                table: "UserSocials",
                column: "Id");
        }
    }
}
