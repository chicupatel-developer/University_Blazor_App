using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addinggl_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GL_Postings",
                columns: table => new
                {
                    PostingsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(maxLength: 2, nullable: true),
                    RefNo = table.Column<string>(nullable: true),
                    TRDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GL_Postings", x => x.PostingsId);
                });

            migrationBuilder.CreateTable(
                name: "GLPS_Datas",
                columns: table => new
                {
                    GLPS_DataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingsId = table.Column<int>(nullable: false),
                    POS = table.Column<int>(nullable: false),
                    GLACCTNO = table.Column<string>(nullable: true),
                    Debit = table.Column<decimal>(nullable: true),
                    Credit = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLPS_Datas", x => x.GLPS_DataId);
                    table.ForeignKey(
                        name: "FK_GLPS_Datas_GL_Postings_PostingsId",
                        column: x => x.PostingsId,
                        principalTable: "GL_Postings",
                        principalColumn: "PostingsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GLPS_Datas_PostingsId",
                table: "GLPS_Datas",
                column: "PostingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GLPS_Datas");

            migrationBuilder.DropTable(
                name: "GL_Postings");
        }
    }
}
