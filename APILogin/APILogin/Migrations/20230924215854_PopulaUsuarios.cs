using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APILogin.Migrations
{
    /// <inheritdoc />
    public partial class PopulaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Usuarios(NomeUsuario, Senha) Values('Lucas','s3nh@')");
            migrationBuilder.Sql("Insert into Usuarios(NomeUsuario, Senha) Values('Paulo','admin123')");
            migrationBuilder.Sql("Insert into Usuarios(NomeUsuario, Senha) Values('Frederico','123456@')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Usuarios");
        }
    }
}
