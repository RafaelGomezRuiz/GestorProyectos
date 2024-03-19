using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManager.Migrations
{
    public partial class NuevaEstructura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Proyecto_proyectoId",
                table: "Tareas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Tareas_TareaId",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas");

            migrationBuilder.DropIndex(
                name: "IX_Tareas_proyectoId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "proyectoId",
                table: "Tareas");

            migrationBuilder.RenameTable(
                name: "Tareas",
                newName: "Tarea");

            migrationBuilder.AlterColumn<int>(
                name: "TareaId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoDb",
                table: "Tarea",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(30)",
                maxLength: 30,
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
                name: "FK_Tarea_Proyecto_IdProyecto",
                table: "Tarea",
                column: "IdProyecto",
                principalTable: "Proyecto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Tarea_TareaId",
                table: "Usuario",
                column: "TareaId",
                principalTable: "Tarea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Proyecto_IdProyecto",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Tarea_TareaId",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_IdProyecto",
                table: "Tarea");

            migrationBuilder.RenameTable(
                name: "Tarea",
                newName: "Tareas");

            migrationBuilder.AlterColumn<int>(
                name: "TareaId",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDb",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "proyectoId",
                table: "Tareas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_proyectoId",
                table: "Tareas",
                column: "proyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Proyecto_proyectoId",
                table: "Tareas",
                column: "proyectoId",
                principalTable: "Proyecto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Tareas_TareaId",
                table: "Usuario",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id");
        }
    }
}
