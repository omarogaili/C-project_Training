using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace migration_database.Migrations
{
    /// <inheritdoc />
    public partial class Omar_Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Customers VALUES ('Isac', 'Ogaili', 'isacomarogili@hotmail.com', '378284732', 'nässjö', 'jönköping', '73232', 'sweden') ");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Customers WHERE firstName = 'Isac'");

        }
    }
}
