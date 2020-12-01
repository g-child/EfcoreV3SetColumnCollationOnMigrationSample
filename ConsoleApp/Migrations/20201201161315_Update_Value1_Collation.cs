using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreV3MigrationSample.Migrations
{
    public partial class Update_Value1_Collation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // EF Core 3.x では Fluent API とかでは列レベルの照合順序の指定ができないので
            // 直接クエリを書いて反映する。もっと良い方法ある？
            migrationBuilder.Sql("ALTER TABLE dbo.Sample ALTER COLUMN Value1 VARCHAR(max) COLLATE Japanese_CI_AS_KS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // TODO: Write query of remove collation
        }
    }
}
