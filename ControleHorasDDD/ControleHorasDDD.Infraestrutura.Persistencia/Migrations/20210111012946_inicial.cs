using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleHorasDDD.Infraestrutura.Persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    DataInicio = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFim = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    SobreNome = table.Column<string>(maxLength: 100, nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Senha = table.Column<string>(maxLength: 400, nullable: false),
                    EhAdministrador = table.Column<bool>(nullable: false),
                    TipoUsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoUsuario_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoraTrabalhada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastro = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    DataInicio = table.Column<DateTime>(type: "Date", nullable: false),
                    DataFim = table.Column<DateTime>(type: "Date", nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    ProjetosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoraTrabalhada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoraTrabalhada_Projetos_ProjetosId",
                        column: x => x.ProjetosId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoraTrabalhada_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioProjeto",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false),
                    IdProjeto = table.Column<int>(nullable: false),
                    UsuariosId = table.Column<int>(nullable: true),
                    ProjetosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioProjeto", x => new { x.IdUsuario, x.IdProjeto });
                    table.ForeignKey(
                        name: "FK_UsuarioProjeto_Projetos_ProjetosId",
                        column: x => x.ProjetosId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioProjeto_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "Id", "DataCadastro", "Descricao", "Nome" },
                values: new object[] { 1, new DateTime(2021, 1, 10, 22, 29, 45, 584, DateTimeKind.Local).AddTicks(3313), "Administrador do Sistema", "Administrador" });

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "Id", "DataCadastro", "Descricao", "Nome" },
                values: new object[] { 2, new DateTime(2021, 1, 10, 22, 29, 45, 585, DateTimeKind.Local).AddTicks(4268), "Usuário do Tipo Desenvolvedor", "Desenvolvedor" });

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "Id", "DataCadastro", "Descricao", "Nome" },
                values: new object[] { 3, new DateTime(2021, 1, 10, 22, 29, 45, 585, DateTimeKind.Local).AddTicks(4293), "Usuário do Tipo Gerente", "Gerente" });

            migrationBuilder.CreateIndex(
                name: "IX_HoraTrabalhada_ProjetosId",
                table: "HoraTrabalhada",
                column: "ProjetosId");

            migrationBuilder.CreateIndex(
                name: "IX_HoraTrabalhada_UsuarioId",
                table: "HoraTrabalhada",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioProjeto_ProjetosId",
                table: "UsuarioProjeto",
                column: "ProjetosId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioProjeto_UsuariosId",
                table: "UsuarioProjeto",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoraTrabalhada");

            migrationBuilder.DropTable(
                name: "UsuarioProjeto");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
