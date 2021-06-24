using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 1300, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerSkillsNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerSkillsNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactBetweenDepartmentsInbox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    To = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    isRead = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactBetweenDepartmentsInbox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactBetweenDepartmentsSent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    To = table.Column<string>(nullable: true),
                    isRead = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactBetweenDepartmentsSent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevicesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicesTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Holiday = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarialStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarialStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MillitaryRanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillitaryRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeNumber = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerSkillToLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComputerLevelsId = table.Column<int>(nullable: true),
                    ComputerSkillsNameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerSkillToLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerSkillToLevels_ComputerLevels_ComputerLevelsId",
                        column: x => x.ComputerLevelsId,
                        principalTable: "ComputerLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComputerSkillToLevels_ComputerSkillsNames_ComputerSkillsNameId",
                        column: x => x.ComputerSkillsNameId,
                        principalTable: "ComputerSkillsNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CountriesId = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    GivingTime = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: true),
                    DevicesTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_DevicesTypes_DevicesTypeId",
                        column: x => x.DevicesTypeId,
                        principalTable: "DevicesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Collages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    EducationTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collages_EducationTypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HighSchools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    EducationTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HighSchools_EducationTypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageToLanguageLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageLevelId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageToLanguageLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageToLanguageLevels_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LanguageToLanguageLevels_LanguageLevels_LanguageLevelId",
                        column: x => x.LanguageLevelId,
                        principalTable: "LanguageLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MillitaryStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    MillitaryRankId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillitaryStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MillitaryStatuses_MillitaryRanks_MillitaryRankId",
                        column: x => x.MillitaryRankId,
                        principalTable: "MillitaryRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Reason = table.Column<string>(maxLength: 50, nullable: false),
                    CreatingTime = table.Column<DateTime>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    FromDateForHour = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    PermissionTypeId = table.Column<int>(nullable: false),
                    Confirm = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Surname = table.Column<string>(maxLength: 50, nullable: true),
                    FatherName = table.Column<string>(maxLength: 50, nullable: true),
                    Number = table.Column<string>(maxLength: 12, nullable: true),
                    Adress = table.Column<string>(maxLength: 255, nullable: true),
                    WorkPlaceName = table.Column<string>(maxLength: 255, nullable: true),
                    RelationTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relations_RelationTypes_RelationTypeId",
                        column: x => x.RelationTypeId,
                        principalTable: "RelationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationTypeToUnivercities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationTypeId = table.Column<int>(nullable: false),
                    UniversitiesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypeToUnivercities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationTypeToUnivercities_EducationTypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "EducationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationTypeToUnivercities_Universities_UniversitiesId",
                        column: x => x.UniversitiesId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    TaxId = table.Column<string>(maxLength: 110, nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Website = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniFaculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    EducationTypeToUniversityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniFaculties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniFaculties_EducationTypeToUnivercities_EducationTypeToUniversityId",
                        column: x => x.EducationTypeToUniversityId,
                        principalTable: "EducationTypeToUnivercities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    UniFacultyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professions_UniFaculties_UniFacultyId",
                        column: x => x.UniFacultyId,
                        principalTable: "UniFaculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnteringTime = table.Column<string>(nullable: true),
                    FinishTime = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ProfessionId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "CommandsToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    CommandId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandsToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommandsToEmployees_Commands_CommandId",
                        column: x => x.CommandId,
                        principalTable: "Commands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 70, nullable: false),
                    FatherName = table.Column<string>(maxLength: 70, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    CompaniesId = table.Column<int>(nullable: true),
                    AdminId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentToCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentToCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentToCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    DepartmentToCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubDepartments_DepartmentToCompanies_DepartmentToCompanyId",
                        column: x => x.DepartmentToCompanyId,
                        principalTable: "DepartmentToCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    SubDepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_SubDepartments_SubDepartmentId",
                        column: x => x.SubDepartmentId,
                        principalTable: "SubDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emplooyeees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    FatherName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IdCard = table.Column<int>(nullable: false),
                    FinCode = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IsWorking = table.Column<bool>(nullable: false),
                    LivingAdress = table.Column<string>(maxLength: 255, nullable: false),
                    BirthPlace = table.Column<string>(maxLength: 255, nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    MarialstatusId = table.Column<int>(nullable: false),
                    Birthday = table.Column<string>(nullable: true),
                    PositionsId = table.Column<int>(nullable: true),
                    Salary = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    MillitaryStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emplooyeees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emplooyeees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emplooyeees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emplooyeees_MarialStatuses_MarialstatusId",
                        column: x => x.MarialstatusId,
                        principalTable: "MarialStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emplooyeees_MillitaryStatuses_MillitaryStatusId",
                        column: x => x.MillitaryStatusId,
                        principalTable: "MillitaryStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emplooyeees_Positions_PositionsId",
                        column: x => x.PositionsId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Certificate = table.Column<string>(nullable: true),
                    BankAccount = table.Column<string>(nullable: true),
                    SSK = table.Column<string>(nullable: true),
                    CorporateNumber = table.Column<string>(nullable: true),
                    MicrosoftWord = table.Column<string>(nullable: true),
                    AdobePdf = table.Column<string>(nullable: true),
                    AddditionImage = table.Column<string>(nullable: true),
                    EmplooyeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalInfos_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    ComputerSkillToLevelsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerToEmployees_ComputerSkillToLevels_ComputerSkillToLevelsId",
                        column: x => x.ComputerSkillToLevelsId,
                        principalTable: "ComputerSkillToLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Continuities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    PermissionType = table.Column<int>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continuities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Continuities_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    MenegerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Emplooyeees_MenegerId",
                        column: x => x.MenegerId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceId = table.Column<int>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceToEmployees_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationsToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationsToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationsToEmployees_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationsToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    LanguageToLanguageLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageToEmployees_LanguageToLanguageLevels_LanguageToLanguageLevelId",
                        column: x => x.LanguageToLanguageLevelId,
                        principalTable: "LanguageToLanguageLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LastWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: false),
                    WhenStarted = table.Column<string>(nullable: false),
                    WhenLeft = table.Column<string>(nullable: false),
                    PositionName = table.Column<string>(maxLength: 50, nullable: false),
                    Reason = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Salary = table.Column<string>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LastWorks_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionToEmployeees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PermissionId = table.Column<int>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionToEmployeees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionToEmployeees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionToEmployeees_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeID = table.Column<int>(nullable: false),
                    PhoneNumberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumberToEmployees_Emplooyeees_EmplooyeeID",
                        column: x => x.EmplooyeeID,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneNumberToEmployees_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelationToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    RelationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelationToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationToEmployees_Relations_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInfos_EmplooyeeId",
                table: "AdditionalInfos",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompaniesId",
                table: "AspNetUsers",
                column: "CompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmplooyeeId",
                table: "AspNetUsers",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountriesId",
                table: "Cities",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Collages_EducationTypeId",
                table: "Collages",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandsToEmployees_CommandId",
                table: "CommandsToEmployees",
                column: "CommandId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandsToEmployees_EmplooyeeId",
                table: "CommandsToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerSkillToLevels_ComputerLevelsId",
                table: "ComputerSkillToLevels",
                column: "ComputerLevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerSkillToLevels_ComputerSkillsNameId",
                table: "ComputerSkillToLevels",
                column: "ComputerSkillsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerToEmployees_ComputerSkillToLevelsId",
                table: "ComputerToEmployees",
                column: "ComputerSkillToLevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerToEmployees_EmplooyeeId",
                table: "ComputerToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Continuities_EmplooyeeId",
                table: "Continuities",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MenegerId",
                table: "Departments",
                column: "MenegerId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentToCompanies_CompanyId",
                table: "DepartmentToCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentToCompanies_DepartmentId",
                table: "DepartmentToCompanies",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DevicesTypeId",
                table: "Devices",
                column: "DevicesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceToEmployees_DeviceId",
                table: "DeviceToEmployees",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceToEmployees_EmplooyeeId",
                table: "DeviceToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ProfessionId",
                table: "Educations",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationsToEmployees_EducationId",
                table: "EducationsToEmployees",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationsToEmployees_EmplooyeeId",
                table: "EducationsToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationTypeToUnivercities_EducationTypeId",
                table: "EducationTypeToUnivercities",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationTypeToUnivercities_UniversitiesId",
                table: "EducationTypeToUnivercities",
                column: "UniversitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplooyeees_CompanyId",
                table: "Emplooyeees",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplooyeees_GenderId",
                table: "Emplooyeees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplooyeees_MarialstatusId",
                table: "Emplooyeees",
                column: "MarialstatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplooyeees_MillitaryStatusId",
                table: "Emplooyeees",
                column: "MillitaryStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplooyeees_PositionsId",
                table: "Emplooyeees",
                column: "PositionsId");

            migrationBuilder.CreateIndex(
                name: "IX_HighSchools_EducationTypeId",
                table: "HighSchools",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageToEmployees_EmplooyeeId",
                table: "LanguageToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageToEmployees_LanguageToLanguageLevelId",
                table: "LanguageToEmployees",
                column: "LanguageToLanguageLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageToLanguageLevels_LanguageId",
                table: "LanguageToLanguageLevels",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageToLanguageLevels_LanguageLevelId",
                table: "LanguageToLanguageLevels",
                column: "LanguageLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_LastWorks_EmplooyeeId",
                table: "LastWorks",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MillitaryStatuses_MillitaryRankId",
                table: "MillitaryStatuses",
                column: "MillitaryRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionTypeId",
                table: "Permissions",
                column: "PermissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionToEmployeees_EmplooyeeId",
                table: "PermissionToEmployeees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionToEmployeees_PermissionId",
                table: "PermissionToEmployeees",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberToEmployees_EmplooyeeID",
                table: "PhoneNumberToEmployees",
                column: "EmplooyeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberToEmployees_PhoneNumberId",
                table: "PhoneNumberToEmployees",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_SubDepartmentId",
                table: "Positions",
                column: "SubDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_UniFacultyId",
                table: "Professions",
                column: "UniFacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Relations_RelationTypeId",
                table: "Relations",
                column: "RelationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationToEmployees_EmplooyeeId",
                table: "RelationToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationToEmployees_RelationId",
                table: "RelationToEmployees",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartments_DepartmentToCompanyId",
                table: "SubDepartments",
                column: "DepartmentToCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UniFaculties_EducationTypeToUniversityId",
                table: "UniFaculties",
                column: "EducationTypeToUniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandsToEmployees_Emplooyeees_EmplooyeeId",
                table: "CommandsToEmployees",
                column: "EmplooyeeId",
                principalTable: "Emplooyeees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Emplooyeees_EmplooyeeId",
                table: "AspNetUsers",
                column: "EmplooyeeId",
                principalTable: "Emplooyeees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentToCompanies_Departments_DepartmentId",
                table: "DepartmentToCompanies",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Emplooyeees_MenegerId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "AdditionalInfos");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Collages");

            migrationBuilder.DropTable(
                name: "CommandsToEmployees");

            migrationBuilder.DropTable(
                name: "ComputerToEmployees");

            migrationBuilder.DropTable(
                name: "ContactBetweenDepartmentsInbox");

            migrationBuilder.DropTable(
                name: "ContactBetweenDepartmentsSent");

            migrationBuilder.DropTable(
                name: "Continuities");

            migrationBuilder.DropTable(
                name: "DeviceToEmployees");

            migrationBuilder.DropTable(
                name: "EducationsToEmployees");

            migrationBuilder.DropTable(
                name: "HighSchools");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "LanguageToEmployees");

            migrationBuilder.DropTable(
                name: "LastWorks");

            migrationBuilder.DropTable(
                name: "PermissionToEmployeees");

            migrationBuilder.DropTable(
                name: "PhoneNumberToEmployees");

            migrationBuilder.DropTable(
                name: "RelationToEmployees");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Commands");

            migrationBuilder.DropTable(
                name: "ComputerSkillToLevels");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "LanguageToLanguageLevels");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Relations");

            migrationBuilder.DropTable(
                name: "ComputerLevels");

            migrationBuilder.DropTable(
                name: "ComputerSkillsNames");

            migrationBuilder.DropTable(
                name: "DevicesTypes");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "LanguageLevels");

            migrationBuilder.DropTable(
                name: "PermissionTypes");

            migrationBuilder.DropTable(
                name: "RelationTypes");

            migrationBuilder.DropTable(
                name: "UniFaculties");

            migrationBuilder.DropTable(
                name: "EducationTypeToUnivercities");

            migrationBuilder.DropTable(
                name: "EducationTypes");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "Emplooyeees");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "MarialStatuses");

            migrationBuilder.DropTable(
                name: "MillitaryStatuses");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "MillitaryRanks");

            migrationBuilder.DropTable(
                name: "SubDepartments");

            migrationBuilder.DropTable(
                name: "DepartmentToCompanies");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
