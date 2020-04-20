using Microsoft.EntityFrameworkCore.Migrations;

namespace EmissorNSSuiteCSharp.DAO.Migrations.SqliteMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductCode = table.Column<string>(nullable: true),
                    BarCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CFOP = table.Column<string>(nullable: true),
                    NCM = table.Column<string>(nullable: true),
                    CEST = table.Column<string>(nullable: true),
                    ApproximateAmountTaxas = table.Column<double>(nullable: false),
                    CalculationRule = table.Column<string>(nullable: true),
                    BusinessUnit = table.Column<string>(nullable: true),
                    UnitaryValue = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Origination = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COFINS",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COFINS", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_COFINS_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ICMS",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CST = table.Column<string>(nullable: true),
                    CSOSN = table.Column<string>(nullable: true),
                    AliqICMS = table.Column<double>(nullable: false),
                    AliqICMSCred = table.Column<double>(nullable: false),
                    ValueICMSCred = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICMS", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ICMS_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPI",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPI", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_IPI_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ISSQN",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISSQN", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ISSQN_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PIS",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIS", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_PIS_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COFINS");

            migrationBuilder.DropTable(
                name: "ICMS");

            migrationBuilder.DropTable(
                name: "IPI");

            migrationBuilder.DropTable(
                name: "ISSQN");

            migrationBuilder.DropTable(
                name: "PIS");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
