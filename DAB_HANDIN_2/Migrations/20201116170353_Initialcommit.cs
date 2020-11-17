using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB_HANDIN_2.Migrations
{
    public partial class Initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nations",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nations", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationId = table.Column<int>(type: "int", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nation_Name = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Municipalities_Nations_Nation_Name",
                        column: x => x.Nation_Name,
                        principalTable: "Nations",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipalityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Citizens_Municipalities_MunicipalityID",
                        column: x => x.MunicipalityID,
                        principalTable: "Municipalities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Addresse = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MunicipalityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Addresse);
                    table.ForeignKey(
                        name: "FK_Locations_Municipalities_MunicipalityID",
                        column: x => x.MunicipalityID,
                        principalTable: "Municipalities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestCenters",
                columns: table => new
                {
                    TestCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hours = table.Column<int>(type: "int", nullable: false),
                    MunicipalityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCenters", x => x.TestCenterId);
                    table.ForeignKey(
                        name: "FK_TestCenters_Municipalities_MunicipalityID",
                        column: x => x.MunicipalityID,
                        principalTable: "Municipalities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitizenLocations",
                columns: table => new
                {
                    CitizenLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Citizen_ID = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenLocations", x => x.CitizenLocationId);
                    table.ForeignKey(
                        name: "FK_CitizenLocations_Citizens_Citizen_ID",
                        column: x => x.Citizen_ID,
                        principalTable: "Citizens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitizenLocations_Locations_Adresse",
                        column: x => x.Adresse,
                        principalTable: "Locations",
                        principalColumn: "Addresse",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestCenterManagements",
                columns: table => new
                {
                    TestCenterManagementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestCenterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCenterManagements", x => x.TestCenterManagementId);
                    table.ForeignKey(
                        name: "FK_TestCenterManagements_TestCenters_TestCenterId",
                        column: x => x.TestCenterId,
                        principalTable: "TestCenters",
                        principalColumn: "TestCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestDates",
                columns: table => new
                {
                    TestDateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Citizen_ID = table.Column<int>(type: "int", nullable: false),
                    TestCenterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDates", x => x.TestDateID);
                    table.ForeignKey(
                        name: "FK_TestDates_Citizens_Citizen_ID",
                        column: x => x.Citizen_ID,
                        principalTable: "Citizens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestDates_TestCenters_TestCenterID",
                        column: x => x.TestCenterID,
                        principalTable: "TestCenters",
                        principalColumn: "TestCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Age", "FirstName", "LastName", "MunicipalityID", "SSN", "Sex" },
                values: new object[,]
                {
                    { 1, 11, "Henrik", "Hansen", null, "201209-9154", "either" },
                    { 73, 77, "Jesper", "Mortensen", null, "160343-8991", "male" },
                    { 72, 71, "Alice", "Olsen", null, "101249-7038", "either" },
                    { 71, 68, "Lise", "Hansen", null, "230252-6329", "either" },
                    { 70, 33, "Lise", "Larsen", null, "050687-4750", "either" },
                    { 69, 18, "Lise", "Frederiksen", null, "110802-9350", "either" },
                    { 68, 16, "Bob", "Jensen", null, "120904-3356", "male" },
                    { 67, 95, "Henrik", "Olsen", null, "160925-4371", "male" },
                    { 66, 8, "Hanne", "Frederiksen", null, "170312-3999", "female" },
                    { 65, 54, "Jesper", "Mortensen", null, "050466-5745", "either" },
                    { 64, 79, "Hanne", "Larsen", null, "080141-4287", "female" },
                    { 63, 99, "Jesper", "Mortensen", null, "080121-5419", "female" },
                    { 62, 40, "Jesper", "Mortensen", null, "150580-9963", "either" },
                    { 61, 60, "Henrik", "Larsen", null, "130660-0632", "either" },
                    { 60, 47, "Lene", "Jensen", null, "130673-2333", "male" },
                    { 59, 1, "Mette", "Frederiksen", null, "141219-7378", "female" },
                    { 58, 79, "Lene", "Frederiksen", null, "160141-3010", "male" },
                    { 57, 45, "Henrik", "Mortensen", null, "280875-4848", "female" },
                    { 56, 6, "Henrik", "Mortensen", null, "080314-8040", "female" },
                    { 55, 2, "Lene", "Hansen", null, "150518-3294", "female" },
                    { 54, 29, "Henrik", "Frederiksen", null, "120291-8868", "either" },
                    { 53, 78, "Mathias", "Frederiksen", null, "250942-2588", "female" },
                    { 74, 21, "Jens", "Olsen", null, "170699-2395", "either" },
                    { 75, 40, "Bob", "Frederiksen", null, "091280-7353", "male" },
                    { 76, 60, "Jesper", "Mortensen", null, "160960-4286", "male" },
                    { 77, 6, "Jesper", "Larsen", null, "190314-6674", "male" },
                    { 99, 54, "Hanne", "Hansen", null, "250866-4855", "female" },
                    { 98, 64, "Lise", "Olsen", null, "240156-0145", "either" },
                    { 97, 99, "Bob", "Frederiksen", null, "040221-5872", "either" },
                    { 96, 86, "Jesper", "Olsen", null, "280634-1809", "male" },
                    { 95, 89, "Henrik", "Larsen", null, "220931-5049", "male" },
                    { 94, 18, "Mette", "Olsen", null, "170702-3222", "male" },
                    { 93, 28, "Mette", "Jensen", null, "080192-6842", "either" },
                    { 92, 48, "Lene", "Jensen", null, "270372-5739", "male" },
                    { 91, 28, "Mette", "Jensen", null, "040592-9658", "male" },
                    { 90, 97, "Jesper", "Hansen", null, "261123-7154", "male" },
                    { 52, 57, "Alice", "Frederiksen", null, "011063-7581", "male" },
                    { 89, 22, "Lise", "Frederiksen", null, "260498-6785", "female" },
                    { 87, 44, "Bob", "Jensen", null, "230876-3875", "female" },
                    { 86, 64, "Bob", "Olsen", null, "031156-2270", "male" },
                    { 85, 61, "Lene", "Jensen", null, "080859-4024", "female" },
                    { 84, 87, "Bob", "Hansen", null, "090733-5712", "male" }
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Age", "FirstName", "LastName", "MunicipalityID", "SSN", "Sex" },
                values: new object[,]
                {
                    { 83, 13, "Jesper", "Hansen", null, "111207-6379", "either" },
                    { 82, 96, "Mathias", "Olsen", null, "070724-2622", "female" },
                    { 81, 1, "Lise", "Larsen", null, "160619-8717", "female" },
                    { 80, 0, "Mette", "Jensen", null, "011220-0166", "female" },
                    { 79, 18, "Mette", "Hansen", null, "190502-8797", "male" },
                    { 78, 59, "Morten", "Olsen", null, "060761-7447", "male" },
                    { 88, 64, "Henrik", "Olsen", null, "280556-3992", "either" },
                    { 100, 17, "Morten", "Larsen", null, "150103-4148", "male" },
                    { 51, 61, "Alice", "Olsen", null, "120859-8434", "male" },
                    { 49, 74, "Jesper", "Larsen", null, "131046-3640", "either" },
                    { 22, 87, "Jens", "Mortensen", null, "010833-4669", "female" },
                    { 21, 57, "Alice", "Olsen", null, "150563-4848", "female" },
                    { 20, 76, "Hanne", "Mortensen", null, "140944-8894", "male" },
                    { 19, 87, "Mathias", "Frederiksen", null, "260633-8511", "either" },
                    { 18, 58, "Jens", "Mortensen", null, "100662-6508", "female" },
                    { 17, 38, "Morten", "Jensen", null, "250382-2831", "female" },
                    { 16, 91, "Bob", "Larsen", null, "161029-0902", "either" },
                    { 15, 15, "Mette", "Olsen", null, "140505-8822", "female" },
                    { 14, 43, "Hanne", "Olsen", null, "210377-8834", "either" },
                    { 13, 98, "Alice", "Olsen", null, "040522-4917", "female" },
                    { 12, 80, "Alice", "Jensen", null, "071140-6096", "either" },
                    { 11, 28, "Alice", "Frederiksen", null, "180292-3819", "male" },
                    { 10, 29, "Lene", "Olsen", null, "210991-9650", "either" },
                    { 9, 0, "Bob", "Mortensen", null, "180920-7789", "either" },
                    { 8, 1, "Morten", "Olsen", null, "160819-2120", "male" },
                    { 7, 47, "Mette", "Hansen", null, "250273-3438", "female" },
                    { 6, 83, "Hans", "Olsen", null, "020637-9743", "female" },
                    { 5, 14, "Lise", "Frederiksen", null, "151006-5513", "either" },
                    { 4, 17, "Hans", "Mortensen", null, "200503-1945", "female" },
                    { 3, 38, "Hans", "Larsen", null, "100282-0686", "female" },
                    { 2, 85, "Lene", "Mortensen", null, "230735-2189", "female" },
                    { 23, 14, "Hanne", "Larsen", null, "260306-1597", "male" },
                    { 24, 66, "Jens", "Larsen", null, "100354-5700", "female" },
                    { 25, 39, "Lene", "Mortensen", null, "130581-6589", "male" },
                    { 26, 81, "Henrik", "Jensen", null, "030239-2849", "female" },
                    { 48, 89, "Lise", "Mortensen", null, "141131-0659", "female" },
                    { 47, 45, "Hanne", "Jensen", null, "200975-6615", "either" },
                    { 46, 50, "Bob", "Hansen", null, "220370-4840", "either" },
                    { 45, 5, "Bob", "Hansen", null, "080915-7389", "female" },
                    { 44, 85, "Mette", "Frederiksen", null, "081035-4520", "male" },
                    { 43, 7, "Lise", "Mortensen", null, "110813-0713", "female" },
                    { 42, 93, "Lise", "Larsen", null, "160527-9487", "male" }
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Age", "FirstName", "LastName", "MunicipalityID", "SSN", "Sex" },
                values: new object[,]
                {
                    { 41, 80, "Mette", "Hansen", null, "280340-2357", "male" },
                    { 40, 27, "Alice", "Mortensen", null, "080193-9200", "either" },
                    { 39, 81, "Alice", "Frederiksen", null, "280139-6939", "either" },
                    { 50, 29, "Lise", "Mortensen", null, "190391-3178", "either" },
                    { 38, 54, "Mathias", "Mortensen", null, "151266-4158", "male" },
                    { 36, 43, "Alice", "Jensen", null, "240477-4467", "either" },
                    { 35, 69, "Morten", "Mortensen", null, "170551-0100", "female" },
                    { 34, 90, "Henrik", "Hansen", null, "081130-0002", "male" },
                    { 33, 94, "Mathias", "Larsen", null, "190426-6611", "either" },
                    { 32, 43, "Hans", "Hansen", null, "240877-0805", "either" },
                    { 31, 83, "Mette", "Mortensen", null, "021137-0508", "female" },
                    { 30, 58, "Jens", "Olsen", null, "061062-6328", "male" },
                    { 29, 17, "Alice", "Hansen", null, "051103-4086", "either" },
                    { 28, 56, "Mette", "Hansen", null, "140964-3558", "male" },
                    { 27, 87, "Jens", "Frederiksen", null, "260533-9722", "either" },
                    { 37, 30, "Lise", "Hansen", null, "090490-6312", "either" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Addresse", "MunicipalityID" },
                values: new object[,]
                {
                    { "Skejby gade", null },
                    { "Århus skadevej", null },
                    { "Århus vænget", null }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "ID", "Name", "NationId", "Nation_Name", "Population" },
                values: new object[,]
                {
                    { 661, "Holstebro", 0, null, 58591 },
                    { 657, "Herning", 0, null, 89127 },
                    { 630, "Vejle", 0, null, 115748 },
                    { 621, "Kolding", 0, null, 93175 },
                    { 615, "Horsens", 0, null, 90966 },
                    { 607, "Fredericia", 0, null, 51377 },
                    { 580, "Aabenraa", 0, null, 58761 },
                    { 575, "Vejen", 0, null, 42742 },
                    { 573, "Varde", 0, null, 49961 },
                    { 563, "Fanø", 0, null, 3488 },
                    { 561, "Esbjerg", 0, null, 115483 },
                    { 550, "Tønder", 0, null, 37366 },
                    { 540, "Sønderborg", 0, null, 74220 },
                    { 530, "Billund", 0, null, 26608 },
                    { 510, "Haderslev", 0, null, 55670 },
                    { 492, "Ærø", 0, null, 5964 },
                    { 482, "Langeland", 0, null, 12491 },
                    { 480, "Nordfyns", 0, null, 29665 },
                    { 479, "Svendborg", 0, null, 58296 },
                    { 461, "Odense", 0, null, 204895 },
                    { 450, "Nyborg", 0, null, 32009 },
                    { 665, "Lemvig", 0, null, 19722 },
                    { 671, "Struer", 0, null, 21036 }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "ID", "Name", "NationId", "Nation_Name", "Population" },
                values: new object[,]
                {
                    { 706, "Syddjurs", 0, null, 42962 },
                    { 707, "Norddjurs", 0, null, 37089 },
                    { 851, "Aalborg", 0, null, 217075 },
                    { 849, "Jammerbugt", 0, null, 38324 },
                    { 846, "Mariagerfjord", 0, null, 41800 },
                    { 840, "Rebild", 0, null, 30113 },
                    { 825, "Læsø", 0, null, 1786 },
                    { 820, "Vesthimmerlands", 0, null, 36727 },
                    { 813, "Frederikshavn", 0, null, 59654 },
                    { 810, "Brønderslev", 0, null, 36304 },
                    { 791, "Viborg", 0, null, 96921 },
                    { 787, "Thisted", 0, null, 43423 },
                    { 440, "Kerteminde", 0, null, 23812 },
                    { 779, "Skive", 0, null, 45851 },
                    { 766, "Hedensted", 0, null, 46722 },
                    { 760, "Ringkøbing-Skjern", 0, null, 56594 },
                    { 756, "Ikast-Brande", 0, null, 41369 },
                    { 751, "Aarhus", 0, null, 349983 },
                    { 746, "Skanderborg", 0, null, 62678 },
                    { 741, "Samsø", 0, null, 3657 },
                    { 740, "Silkeborg", 0, null, 94026 },
                    { 730, "Randers", 0, null, 97805 },
                    { 727, "Odder", 0, null, 22844 },
                    { 710, "Favrskov", 0, null, 48397 },
                    { 773, "Morsø", 0, null, 20247 },
                    { 860, "Hjørring", 0, null, 64483 },
                    { 430, "Faaborg-Midtfyn", 0, null, 51556 },
                    { 411, "Christiansø", 0, null, 84000 },
                    { 217, "Helsingør", 0, null, 62695 },
                    { 210, "Fredensborg", 0, null, 40865 },
                    { 201, "Allerød", 0, null, 25633 },
                    { 190, "Furesø", 0, null, 40965 },
                    { 187, "Vallensbæk", 0, null, 16633 },
                    { 185, "Tårnby", 0, null, 42989 },
                    { 183, "Ishøj", 0, null, 22989 },
                    { 175, "Rødovre", 0, null, 40652 },
                    { 173, "Lyngby-Taarbæk", 0, null, 56214 },
                    { 169, "Høje-Taastrup", 0, null, 50759 },
                    { 167, "Hvidovre", 0, null, 53527 },
                    { 165, "Albertslund", 0, null, 27731 },
                    { 163, "Herlev", 0, null, 28953 },
                    { 161, "Glostrup", 0, null, 23128 }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "ID", "Name", "NationId", "Nation_Name", "Population" },
                values: new object[,]
                {
                    { 159, "Gladsaxe", 0, null, 69262 },
                    { 157, "Gentofte", 0, null, 74830 },
                    { 155, "Dragør", 0, null, 14494 },
                    { 153, "Brøndby", 0, null, 35090 },
                    { 151, "Ballerup", 0, null, 48602 },
                    { 147, "Frederiksberg", 0, null, 104305 },
                    { 101, "København", 0, null, 632340 },
                    { 219, "Hillerød", 0, null, 51183 },
                    { 223, "Hørsholm", 0, null, 24864 },
                    { 230, "Rudersdal", 0, null, 56728 },
                    { 240, "Egedal", 0, null, 43354 },
                    { 410, "Middelfart", 0, null, 38853 },
                    { 400, "Bornholm", 0, null, 39499 },
                    { 390, "Vordingborg", 0, null, 45566 },
                    { 376, "Guldborgsund", 0, null, 60722 },
                    { 370, "Næstved", 0, null, 83143 },
                    { 360, "Lolland", 0, null, 41105 },
                    { 350, "Lejre", 0, null, 27996 },
                    { 340, "Sorø", 0, null, 29881 },
                    { 336, "Stevns", 0, null, 22805 },
                    { 330, "Slagelse", 0, null, 79073 },
                    { 420, "Assens", 0, null, 40965 },
                    { 329, "Ringsted", 0, null, 34852 },
                    { 320, "Faxe", 0, null, 36576 },
                    { 316, "Holbæk", 0, null, 71541 },
                    { 306, "Odsherred", 0, null, 32957 },
                    { 270, "Gribskov", 0, null, 41048 },
                    { 269, "Solrød", 0, null, 23255 },
                    { 265, "Roskilde", 0, null, 87914 },
                    { 260, "Halsnæs", 0, null, 31384 },
                    { 259, "Køge", 0, null, 60979 },
                    { 253, "Greve", 0, null, 50558 },
                    { 250, "Frederikssund", 0, null, 45223 },
                    { 326, "Kalundborg", 0, null, 48436 }
                });

            migrationBuilder.InsertData(
                table: "Nations",
                column: "Name",
                value: "Danmark");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenLocations_Adresse",
                table: "CitizenLocations",
                column: "Adresse");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenLocations_Citizen_ID",
                table: "CitizenLocations",
                column: "Citizen_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_MunicipalityID",
                table: "Citizens",
                column: "MunicipalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MunicipalityID",
                table: "Locations",
                column: "MunicipalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_Nation_Name",
                table: "Municipalities",
                column: "Nation_Name");

            migrationBuilder.CreateIndex(
                name: "IX_TestCenterManagements_TestCenterId",
                table: "TestCenterManagements",
                column: "TestCenterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestCenters_MunicipalityID",
                table: "TestCenters",
                column: "MunicipalityID");

            migrationBuilder.CreateIndex(
                name: "IX_TestDates_Citizen_ID",
                table: "TestDates",
                column: "Citizen_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TestDates_TestCenterID",
                table: "TestDates",
                column: "TestCenterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenLocations");

            migrationBuilder.DropTable(
                name: "TestCenterManagements");

            migrationBuilder.DropTable(
                name: "TestDates");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "TestCenters");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Nations");
        }
    }
}
