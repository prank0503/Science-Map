using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScienceMap.WebServices.Data.Migrations
{
    public partial class createScienceMapDbAndTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SM_AUTHOR_NAME",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MIDDLE_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LAST_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_AUTHOR_NAME", x => x.ID);
                    table.UniqueConstraint("AlternateKey_FirstName", x => x.FIRST_NAME);
                });

            migrationBuilder.CreateTable(
                name: "SM_DISCUSSION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DISCUSSION_TYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_DISCUSSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_DISCUSSION_ENTRY",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DISCUSSION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PARENT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TEXT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CREATED_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_DISCUSSION_ENTRY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_DISCUSSION_TYPE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_DISCUSSION_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_ORGANISATION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORGANISATION_TYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORGANISATION_STATE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SHORT_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_ORGANISATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_ORGANISATION_STATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_ORGANISATION_STATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_ORGANISATION_TYPE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_ORGANISATION_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_ID_SOURCE = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_ID_TARGET = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_INFLUENCE_TYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOTE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CREATED_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE_RATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DISCUSSION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_INFLUENCE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_INFLUENCE_RATE_TYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORIGINATOR_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE_RATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE_RATE_TYPE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE_RATE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE_TYPE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PUB_INFLUENCE_TYPE_ASSEMENT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_INFLUENCE_TYPE_STATE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE_TYPE_ASSESSMENT",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE_TYPE_ASSESSMENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE_TYPE_STATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE_TYPE_STATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUB_INFLUENCE_TYPE_SUGGESTION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SUGGESTED_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUB_INFLUENCE_TYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUB_INFLUENCE_TYPE_SUGGESTION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUBLICATION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUBLICATION_STATE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TITLE = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    YEAR = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    ABSTRACT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ADDITIONAL_DETAILS = table.Column<string>(type: "nvarchar(360)", maxLength: 360, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUBLICATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUBLICATION_AUTHOR",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUBLICATION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AUTHOR_NAME_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORDER_KEY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUBLICATION_AUTHOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PUBLICATION_STATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PUBLICATION_STATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    IMAGE_URL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KEYWORDS = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STATE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_DISCUSSION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DISCUSSION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TITLE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    INITIATED_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    INITIATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KEYWORDS = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_DISCUSSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_PUBLICATION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUBLICATION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_PUBLICATION_STATE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORIGINATOR_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_PUBLICATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_PUBLICATION_STATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_PUBLICATION_STATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_RELATION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PARENT_SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_RELATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_STATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_STATE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_SUGGESTION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SUGGESTED_USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    APPLIED_USER_ORCHESTRATOR_ROLE = table.Column<bool>(type: "bit", nullable: false),
                    SUGGESTED_ORCHESTRATOR_NAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SUGGESTED_ORCHESTRATOR_MAIL = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SUGGESTED_ORCHESTRATOR_PHONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_SUGGESTION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_USER",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_USER_ROLE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SCS_USER_ROLE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SCS_USER_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ENCRYPTED_PASSWORD_HASH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    USER_STATE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_AUTHOR",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PUBLICATION_AUTHOR_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_AUTHOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_FAV_AUTHOR",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FAV_USER_AUTHOR_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_FAV_AUTHOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_FAV_SCS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_FAV_SCS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_FOLLOWER_DISCUSSION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DISCUSSION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_FOLLOWER_DISCUSSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_ORGANISATION",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORGANISATION_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORDER_KEY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_ORGANISATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_ROLE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ROLE_TYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_ROLE_TYPE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    DESCRIPTION = table.Column<Guid>(type: "uniqueidentifier", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_ROLE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_STATE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_STATE", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SM_AUTHOR_NAME");

            migrationBuilder.DropTable(
                name: "SM_DISCUSSION");

            migrationBuilder.DropTable(
                name: "SM_DISCUSSION_ENTRY");

            migrationBuilder.DropTable(
                name: "SM_DISCUSSION_TYPE");

            migrationBuilder.DropTable(
                name: "SM_ORGANISATION");

            migrationBuilder.DropTable(
                name: "SM_ORGANISATION_STATE");

            migrationBuilder.DropTable(
                name: "SM_ORGANISATION_TYPE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_RATE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_RATE_TYPE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE_ASSESSMENT");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE_STATE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE_SUGGESTION");

            migrationBuilder.DropTable(
                name: "SM_PUBLICATION");

            migrationBuilder.DropTable(
                name: "SM_PUBLICATION_AUTHOR");

            migrationBuilder.DropTable(
                name: "SM_PUBLICATION_STATE");

            migrationBuilder.DropTable(
                name: "SM_SCS");

            migrationBuilder.DropTable(
                name: "SM_SCS_DISCUSSION");

            migrationBuilder.DropTable(
                name: "SM_SCS_PUBLICATION");

            migrationBuilder.DropTable(
                name: "SM_SCS_PUBLICATION_STATE");

            migrationBuilder.DropTable(
                name: "SM_SCS_RELATION");

            migrationBuilder.DropTable(
                name: "SM_SCS_STATE");

            migrationBuilder.DropTable(
                name: "SM_SCS_SUGGESTION");

            migrationBuilder.DropTable(
                name: "SM_SCS_USER");

            migrationBuilder.DropTable(
                name: "SM_SCS_USER_ROLE");

            migrationBuilder.DropTable(
                name: "SM_USER");

            migrationBuilder.DropTable(
                name: "SM_USER_AUTHOR");

            migrationBuilder.DropTable(
                name: "SM_USER_FAV_AUTHOR");

            migrationBuilder.DropTable(
                name: "SM_USER_FAV_SCS");

            migrationBuilder.DropTable(
                name: "SM_USER_FOLLOWER_DISCUSSION");

            migrationBuilder.DropTable(
                name: "SM_USER_ORGANISATION");

            migrationBuilder.DropTable(
                name: "SM_USER_ROLE");

            migrationBuilder.DropTable(
                name: "SM_USER_ROLE_TYPE");

            migrationBuilder.DropTable(
                name: "SM_USER_STATE");
        }
    }
}
