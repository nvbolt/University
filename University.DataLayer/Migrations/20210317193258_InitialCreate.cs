using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace University.DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    last_name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    first_name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    patronymic = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    nickname = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_students", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group_student",
                columns: table => new
                {
                    groups_id = table.Column<long>(type: "bigint", nullable: false),
                    students_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_group_student", x => new { x.groups_id, x.students_id });
                    table.ForeignKey(
                        name: "fk_group_student_groups_groups_id",
                        column: x => x.groups_id,
                        principalTable: "groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_group_student_students_students_id",
                        column: x => x.students_id,
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_group_student_students_id",
                table: "group_student",
                column: "students_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group_student");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
