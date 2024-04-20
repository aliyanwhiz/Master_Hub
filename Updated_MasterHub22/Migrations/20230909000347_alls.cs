using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Updated_MasterHub22.Migrations
{
    public partial class alls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_adm1",
                columns: table => new
                {
                    Adm_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adm_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adm_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adm_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adm_image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_adm1", x => x.Adm_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_booking",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Custmers_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Custmers_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Custmers_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Messages = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_booking", x => x.Book_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_bookingservice",
                columns: table => new
                {
                    Book_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    service_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bookingservice", x => x.Book_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_city",
                columns: table => new
                {
                    City_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City_image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_city", x => x.City_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_cus1",
                columns: table => new
                {
                    Cus_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cus_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cus1", x => x.Cus_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_feed",
                columns: table => new
                {
                    Feedback_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feedback_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feedback_Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_feed", x => x.Feedback_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_part",
                columns: table => new
                {
                    Partner_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partner_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Partner_phonr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Partner_experties = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_part", x => x.Partner_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_services",
                columns: table => new
                {
                    Service_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Services_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Services_Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_services", x => x.Service_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_adm1");

            migrationBuilder.DropTable(
                name: "tbl_booking");

            migrationBuilder.DropTable(
                name: "tbl_bookingservice");

            migrationBuilder.DropTable(
                name: "tbl_city");

            migrationBuilder.DropTable(
                name: "tbl_cus1");

            migrationBuilder.DropTable(
                name: "tbl_feed");

            migrationBuilder.DropTable(
                name: "tbl_part");

            migrationBuilder.DropTable(
                name: "tbl_services");
        }
    }
}
