using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScienceMap.Backend.Data.Migrations
{
    public partial class addfkmapping : Migration
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
                    table.ForeignKey(
                        name: "FK_SM_DISCUSSION_SM_DISCUSSION_TYPE_DISCUSSION_TYPE_ID",
                        column: x => x.DISCUSSION_TYPE_ID,
                        principalTable: "SM_DISCUSSION_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_ORGANISATION_SM_ORGANISATION_STATE_ORGANISATION_STATE_ID",
                        column: x => x.ORGANISATION_STATE_ID,
                        principalTable: "SM_ORGANISATION_STATE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_ORGANISATION_SM_ORGANISATION_TYPE_ORGANISATION_TYPE_ID",
                        column: x => x.ORGANISATION_TYPE_ID,
                        principalTable: "SM_ORGANISATION_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_TYPE_SM_PUB_INFLUENCE_TYPE_ASSESSMENT_PUB_INFLUENCE_TYPE_ASSEMENT_ID",
                        column: x => x.PUB_INFLUENCE_TYPE_ASSEMENT_ID,
                        principalTable: "SM_PUB_INFLUENCE_TYPE_ASSESSMENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_TYPE_SM_PUB_INFLUENCE_TYPE_STATE_PUB_INFLUENCE_TYPE_STATE_ID",
                        column: x => x.PUB_INFLUENCE_TYPE_STATE_ID,
                        principalTable: "SM_PUB_INFLUENCE_TYPE_STATE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_PUBLICATION_SM_PUBLICATION_STATE_PUBLICATION_STATE_ID",
                        column: x => x.PUBLICATION_STATE_ID,
                        principalTable: "SM_PUBLICATION_STATE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_SCS_SM_SCS_STATE_STATE_ID",
                        column: x => x.STATE_ID,
                        principalTable: "SM_SCS_STATE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_SM_USER_STATE_USER_STATE_ID",
                        column: x => x.USER_STATE_ID,
                        principalTable: "SM_USER_STATE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_PUBLICATION_AUTHOR_SM_AUTHOR_NAME_AUTHOR_NAME_ID",
                        column: x => x.AUTHOR_NAME_ID,
                        principalTable: "SM_AUTHOR_NAME",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUBLICATION_AUTHOR_SM_PUBLICATION_PUBLICATION_ID",
                        column: x => x.PUBLICATION_ID,
                        principalTable: "SM_PUBLICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_SCS_RELATION_SM_SCS_PARENT_SCS_ID",
                        column: x => x.PARENT_SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_RELATION_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_SM_DISCUSSION_ENTRY_SM_DISCUSSION_DISCUSSION_ID",
                        column: x => x.DISCUSSION_ID,
                        principalTable: "SM_DISCUSSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_DISCUSSION_ENTRY_SM_USER_CREATED_USER_ID",
                        column: x => x.CREATED_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_SM_PUB_INFLUENCE_TYPE_PUB_INFLUENCE_TYPE_ID",
                        column: x => x.PUB_INFLUENCE_TYPE_ID,
                        principalTable: "SM_PUB_INFLUENCE_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_SM_PUBLICATION_PUB_ID_SOURCE",
                        column: x => x.PUB_ID_SOURCE,
                        principalTable: "SM_PUBLICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_SM_PUBLICATION_PUB_ID_TARGET",
                        column: x => x.PUB_ID_TARGET,
                        principalTable: "SM_PUBLICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_SM_USER_CREATED_USER_ID",
                        column: x => x.CREATED_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_TYPE_SUGGESTION_SM_PUB_INFLUENCE_TYPE_PUB_INFLUENCE_TYPE_ID",
                        column: x => x.PUB_INFLUENCE_TYPE_ID,
                        principalTable: "SM_PUB_INFLUENCE_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_TYPE_SUGGESTION_SM_USER_SUGGESTED_USER_ID",
                        column: x => x.SUGGESTED_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_SCS_DISCUSSION_SM_DISCUSSION_DISCUSSION_ID",
                        column: x => x.DISCUSSION_ID,
                        principalTable: "SM_DISCUSSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_DISCUSSION_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_DISCUSSION_SM_USER_INITIATED_USER_ID",
                        column: x => x.INITIATED_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_SCS_PUBLICATION_SM_PUBLICATION_PUBLICATION_ID",
                        column: x => x.PUBLICATION_ID,
                        principalTable: "SM_PUBLICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_PUBLICATION_SM_SCS_PUBLICATION_STATE_SCS_PUBLICATION_STATE_ID",
                        column: x => x.SCS_PUBLICATION_STATE_ID,
                        principalTable: "SM_SCS_PUBLICATION_STATE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_PUBLICATION_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_PUBLICATION_SM_USER_ORIGINATOR_USER_ID",
                        column: x => x.ORIGINATOR_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_SCS_SUGGESTION_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_SUGGESTION_SM_USER_SUGGESTED_USER_ID",
                        column: x => x.SUGGESTED_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_SCS_USER_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_USER_SM_SCS_USER_ROLE_SCS_USER_ROLE_ID",
                        column: x => x.SCS_USER_ROLE_ID,
                        principalTable: "SM_SCS_USER_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_SCS_USER_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_FAV_SCS_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_FAV_SCS_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_FOLLOWER_DISCUSSION_SM_DISCUSSION_DISCUSSION_ID",
                        column: x => x.DISCUSSION_ID,
                        principalTable: "SM_DISCUSSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_FOLLOWER_DISCUSSION_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_ORGANISATION_SM_ORGANISATION_ORGANISATION_ID",
                        column: x => x.ORGANISATION_ID,
                        principalTable: "SM_ORGANISATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_ORGANISATION_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_ROLE_SM_USER_ROLE_TYPE_USER_ROLE_TYPE_ID",
                        column: x => x.USER_ROLE_TYPE_ID,
                        principalTable: "SM_USER_ROLE_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_ROLE_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_SCS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SCS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_SCS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SM_USER_SCS_SM_SCS_SCS_ID",
                        column: x => x.SCS_ID,
                        principalTable: "SM_SCS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_SCS_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_AUTHOR_SM_PUBLICATION_AUTHOR_PUBLICATION_AUTHOR_ID",
                        column: x => x.PUBLICATION_AUTHOR_ID,
                        principalTable: "SM_PUBLICATION_AUTHOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_AUTHOR_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_RATE_SM_DISCUSSION_DISCUSSION_ID",
                        column: x => x.DISCUSSION_ID,
                        principalTable: "SM_DISCUSSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_RATE_SM_PUB_INFLUENCE_PUB_INFLUENCE_ID",
                        column: x => x.PUB_INFLUENCE_ID,
                        principalTable: "SM_PUB_INFLUENCE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_RATE_SM_PUB_INFLUENCE_RATE_TYPE_PUB_INFLUENCE_RATE_TYPE_ID",
                        column: x => x.PUB_INFLUENCE_RATE_TYPE_ID,
                        principalTable: "SM_PUB_INFLUENCE_RATE_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_PUB_INFLUENCE_RATE_SM_USER_ORIGINATOR_USER_ID",
                        column: x => x.ORIGINATOR_USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_SM_USER_FAV_AUTHOR_SM_USER_AUTHOR_FAV_USER_AUTHOR_ID",
                        column: x => x.FAV_USER_AUTHOR_ID,
                        principalTable: "SM_USER_AUTHOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_FAV_AUTHOR_SM_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "SM_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SM_DISCUSSION_DISCUSSION_TYPE_ID",
                table: "SM_DISCUSSION",
                column: "DISCUSSION_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_DISCUSSION_ENTRY_CREATED_USER_ID",
                table: "SM_DISCUSSION_ENTRY",
                column: "CREATED_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_DISCUSSION_ENTRY_DISCUSSION_ID",
                table: "SM_DISCUSSION_ENTRY",
                column: "DISCUSSION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_ORGANISATION_ORGANISATION_STATE_ID",
                table: "SM_ORGANISATION",
                column: "ORGANISATION_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_ORGANISATION_ORGANISATION_TYPE_ID",
                table: "SM_ORGANISATION",
                column: "ORGANISATION_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_CREATED_USER_ID",
                table: "SM_PUB_INFLUENCE",
                column: "CREATED_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_PUB_ID_SOURCE",
                table: "SM_PUB_INFLUENCE",
                column: "PUB_ID_SOURCE");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_PUB_ID_TARGET",
                table: "SM_PUB_INFLUENCE",
                column: "PUB_ID_TARGET");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_PUB_INFLUENCE_TYPE_ID",
                table: "SM_PUB_INFLUENCE",
                column: "PUB_INFLUENCE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_RATE_DISCUSSION_ID",
                table: "SM_PUB_INFLUENCE_RATE",
                column: "DISCUSSION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_RATE_ORIGINATOR_USER_ID",
                table: "SM_PUB_INFLUENCE_RATE",
                column: "ORIGINATOR_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_RATE_PUB_INFLUENCE_ID",
                table: "SM_PUB_INFLUENCE_RATE",
                column: "PUB_INFLUENCE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_RATE_PUB_INFLUENCE_RATE_TYPE_ID",
                table: "SM_PUB_INFLUENCE_RATE",
                column: "PUB_INFLUENCE_RATE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_TYPE_PUB_INFLUENCE_TYPE_ASSEMENT_ID",
                table: "SM_PUB_INFLUENCE_TYPE",
                column: "PUB_INFLUENCE_TYPE_ASSEMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_TYPE_PUB_INFLUENCE_TYPE_STATE_ID",
                table: "SM_PUB_INFLUENCE_TYPE",
                column: "PUB_INFLUENCE_TYPE_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_TYPE_SUGGESTION_PUB_INFLUENCE_TYPE_ID",
                table: "SM_PUB_INFLUENCE_TYPE_SUGGESTION",
                column: "PUB_INFLUENCE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUB_INFLUENCE_TYPE_SUGGESTION_SUGGESTED_USER_ID",
                table: "SM_PUB_INFLUENCE_TYPE_SUGGESTION",
                column: "SUGGESTED_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUBLICATION_PUBLICATION_STATE_ID",
                table: "SM_PUBLICATION",
                column: "PUBLICATION_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUBLICATION_AUTHOR_AUTHOR_NAME_ID",
                table: "SM_PUBLICATION_AUTHOR",
                column: "AUTHOR_NAME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PUBLICATION_AUTHOR_PUBLICATION_ID",
                table: "SM_PUBLICATION_AUTHOR",
                column: "PUBLICATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_STATE_ID",
                table: "SM_SCS",
                column: "STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_DISCUSSION_DISCUSSION_ID",
                table: "SM_SCS_DISCUSSION",
                column: "DISCUSSION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_DISCUSSION_INITIATED_USER_ID",
                table: "SM_SCS_DISCUSSION",
                column: "INITIATED_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_DISCUSSION_SCS_ID",
                table: "SM_SCS_DISCUSSION",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_PUBLICATION_ORIGINATOR_USER_ID",
                table: "SM_SCS_PUBLICATION",
                column: "ORIGINATOR_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_PUBLICATION_PUBLICATION_ID",
                table: "SM_SCS_PUBLICATION",
                column: "PUBLICATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_PUBLICATION_SCS_ID",
                table: "SM_SCS_PUBLICATION",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_PUBLICATION_SCS_PUBLICATION_STATE_ID",
                table: "SM_SCS_PUBLICATION",
                column: "SCS_PUBLICATION_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_RELATION_PARENT_SCS_ID",
                table: "SM_SCS_RELATION",
                column: "PARENT_SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_RELATION_SCS_ID",
                table: "SM_SCS_RELATION",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_SUGGESTION_SCS_ID",
                table: "SM_SCS_SUGGESTION",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_SUGGESTION_SUGGESTED_USER_ID",
                table: "SM_SCS_SUGGESTION",
                column: "SUGGESTED_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_USER_SCS_ID",
                table: "SM_SCS_USER",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_USER_SCS_USER_ROLE_ID",
                table: "SM_SCS_USER",
                column: "SCS_USER_ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SCS_USER_USER_ID",
                table: "SM_SCS_USER",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_USER_STATE_ID",
                table: "SM_USER",
                column: "USER_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_AUTHOR_PUBLICATION_AUTHOR_ID",
                table: "SM_USER_AUTHOR",
                column: "PUBLICATION_AUTHOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_AUTHOR_USER_ID",
                table: "SM_USER_AUTHOR",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_FAV_AUTHOR_FAV_USER_AUTHOR_ID",
                table: "SM_USER_FAV_AUTHOR",
                column: "FAV_USER_AUTHOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_FAV_AUTHOR_USER_ID",
                table: "SM_USER_FAV_AUTHOR",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_FAV_SCS_SCS_ID",
                table: "SM_USER_FAV_SCS",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_FAV_SCS_USER_ID",
                table: "SM_USER_FAV_SCS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_FOLLOWER_DISCUSSION_DISCUSSION_ID",
                table: "SM_USER_FOLLOWER_DISCUSSION",
                column: "DISCUSSION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_FOLLOWER_DISCUSSION_USER_ID",
                table: "SM_USER_FOLLOWER_DISCUSSION",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_ORGANISATION_ORGANISATION_ID",
                table: "SM_USER_ORGANISATION",
                column: "ORGANISATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_ORGANISATION_USER_ID",
                table: "SM_USER_ORGANISATION",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_ROLE_USER_ID",
                table: "SM_USER_ROLE",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_ROLE_USER_ROLE_TYPE_ID",
                table: "SM_USER_ROLE",
                column: "USER_ROLE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_SCS_SCS_ID",
                table: "SM_USER_SCS",
                column: "SCS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_SCS_USER_ID",
                table: "SM_USER_SCS",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SM_DISCUSSION_ENTRY");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_RATE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE_SUGGESTION");

            migrationBuilder.DropTable(
                name: "SM_SCS_DISCUSSION");

            migrationBuilder.DropTable(
                name: "SM_SCS_PUBLICATION");

            migrationBuilder.DropTable(
                name: "SM_SCS_RELATION");

            migrationBuilder.DropTable(
                name: "SM_SCS_SUGGESTION");

            migrationBuilder.DropTable(
                name: "SM_SCS_USER");

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
                name: "SM_USER_SCS");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_RATE_TYPE");

            migrationBuilder.DropTable(
                name: "SM_SCS_PUBLICATION_STATE");

            migrationBuilder.DropTable(
                name: "SM_SCS_USER_ROLE");

            migrationBuilder.DropTable(
                name: "SM_USER_AUTHOR");

            migrationBuilder.DropTable(
                name: "SM_DISCUSSION");

            migrationBuilder.DropTable(
                name: "SM_ORGANISATION");

            migrationBuilder.DropTable(
                name: "SM_USER_ROLE_TYPE");

            migrationBuilder.DropTable(
                name: "SM_SCS");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE");

            migrationBuilder.DropTable(
                name: "SM_PUBLICATION_AUTHOR");

            migrationBuilder.DropTable(
                name: "SM_USER");

            migrationBuilder.DropTable(
                name: "SM_DISCUSSION_TYPE");

            migrationBuilder.DropTable(
                name: "SM_ORGANISATION_STATE");

            migrationBuilder.DropTable(
                name: "SM_ORGANISATION_TYPE");

            migrationBuilder.DropTable(
                name: "SM_SCS_STATE");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE_ASSESSMENT");

            migrationBuilder.DropTable(
                name: "SM_PUB_INFLUENCE_TYPE_STATE");

            migrationBuilder.DropTable(
                name: "SM_AUTHOR_NAME");

            migrationBuilder.DropTable(
                name: "SM_PUBLICATION");

            migrationBuilder.DropTable(
                name: "SM_USER_STATE");

            migrationBuilder.DropTable(
                name: "SM_PUBLICATION_STATE");
        }
    }
}
