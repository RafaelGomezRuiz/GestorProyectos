using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManager.Migrations.SqlServer
{
    public partial class SecdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Proyectos_ProyectoId",
                table: "Tareas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Tareas_TareaId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas");

            migrationBuilder.DropIndex(
                name: "IX_Tareas_ProyectoId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "ProyectoId",
                table: "Tareas");

            migrationBuilder.RenameTable(
                name: "Tareas",
                newName: "Tarea");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDb",
                table: "Tarea",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_IdProyecto",
                table: "Tarea",
                column: "IdProyecto");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Proyectos_IdProyecto",
                table: "Tarea",
                column: "IdProyecto",
                principalTable: "Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Tarea_TareaId",
                table: "Usuarios",
                column: "TareaId",
                principalTable: "Tarea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Proyectos_IdProyecto",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Tarea_TareaId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_IdProyecto",
                table: "Tarea");

            migrationBuilder.RenameTable(
                name: "Tarea",
                newName: "Tareas");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDb",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "ProyectoId",
                table: "Tareas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_ProyectoId",
                table: "Tareas",
                column: "ProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Proyectos_ProyectoId",
                table: "Tareas",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Tareas_TareaId",
                table: "Usuarios",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
