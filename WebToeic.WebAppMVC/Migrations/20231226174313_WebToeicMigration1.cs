﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebToeic.WebAppMVC.Migrations
{
    public partial class WebToeicMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaxPoint = table.Column<int>(type: "int", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grammars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarkDownContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrammarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grammars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Listenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Part = table.Column<int>(type: "int", nullable: false),
                    Script = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListeningName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listenings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Readings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Part = table.Column<int>(type: "int", nullable: false),
                    Script = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadingsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlideBanners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlideName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlideContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideBanners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vocabularies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VocabularyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vocabularies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ParentCommentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GrammarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Grammars_GrammarId",
                        column: x => x.GrammarId,
                        principalTable: "Grammars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentListens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ParentCommentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ListeningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentListens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentListens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentListens_CommentListens_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "CommentListens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentListens_Listenings_ListeningId",
                        column: x => x.ListeningId,
                        principalTable: "Listenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListeningQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListeningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListeningQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListeningQuestions_Listenings_ListeningId",
                        column: x => x.ListeningId,
                        principalTable: "Listenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentReadings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ParentCommentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReadingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReadings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentReadings_CommentReadings_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "CommentReadings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReadings_Readings_ReadingId",
                        column: x => x.ReadingId,
                        principalTable: "Readings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReadingQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadingQuestions_Readings_ReadingId",
                        column: x => x.ReadingId,
                        principalTable: "Readings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrectListen = table.Column<int>(type: "int", nullable: false),
                    CorrectRead = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorrectNumber = table.Column<int>(type: "int", nullable: false),
                    InCorrectNumber = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AudioMp3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageTQ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paragraph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestQuestions_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentVocabularies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ParentCommentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VocabularyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentVocabularies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentVocabularies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentVocabularies_CommentVocabularies_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "CommentVocabularies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentVocabularies_Vocabularies_VocabularyId",
                        column: x => x.VocabularyId,
                        principalTable: "Vocabularies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VocabularyContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AudioMp3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageVC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Sentence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transcribed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VocabularyContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabularyContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VocabularyContents_Vocabularies_VocabularyContentId",
                        column: x => x.VocabularyContentId,
                        principalTable: "Vocabularies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "503B6BDD-7CC7-454E-9CFE-170D9D266450", "bdbf8c42-a2ee-428f-941f-a7b98b606f70", "Administrator role", "Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MaxPoint", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rank", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6EF4554C-0501-436A-B2EB-6F2A574BAD31", 0, "HaNoi", "1b8ac455-320c-4e9a-9b71-a24413305521", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminTest@gmail.com", true, false, null, null, "adminTest@gmail.com", "admin", "AQAAAAEAACcQAAAAELJoWlBbFVgcTUm3t05y/aTdA5VfzNiWe+/3e3YOjjO1zwDG9IEu0OPPbVKLa9t4Rw==", null, false, null, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Grammars",
                columns: new[] { "Id", "GrammarName", "HtmlContent", "ImageG", "MarkDownContent" },
                values: new object[,]
                {
                    { 13, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 14, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 15, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 16, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 17, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 18, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 19, "Giới từ trong tiếng Anh và quy tắc sử dụng", "<p><strong>I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG</strong></p>\r\n <p><strong>1.  Khái niệm</strong></p>\r\n <p>Trong ngữ pháp, <strong>giới từ (preposition)</strong> là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.</p>\r\n <p>Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”</p>\r\n <p><strong>2.  Nguyên tắc sử dụng giới từ</strong><br><strong>Vị trí của giới từ:</strong> Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh</p>\r\n <p><strong>Trước danh từ:</strong></p>\r\n <p>In the morning: Vào buổi sáng</p>\r\n <p>On Monday: Vào thứ 2</p>\r\n <p><strong>Sau động từ:</strong></p>\r\n <p>Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ</p>\r\n <ul>\r\n <li><p>The book is on the table = Quyển sách ở trên bàn.</p>\r\n </li>\r\n <li><p>I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.</p>\r\n </li>\r\n <li><p>He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua</p>\r\n </li>\r\n </ul>\r\n <p><strong>Sau tính từ:</strong></p>\r\n <ul>\r\n <li><p>I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.</p>\r\n </li>\r\n <li><p>He is not angry with you = Anh ấy không giận bạn.</p>\r\n </li>\r\n </ul>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý</strong></p>\r\n <p><strong>1. Một số giới từ thường gặp</strong><br>    1) Giời từ chỉ thời gian: </p>\r\n <ul>\r\n <li><p>At: vào lúc (thường đi với giờ) - I get up at 6.00</p>\r\n </li>\r\n <li><p>On: vào (thường đi với ngày) - The book on the table</p>\r\n </li>\r\n <li><p>In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday</p>\r\n </li>\r\n <li><p>Before: trước - Before my mother came home, my father had watered all the plants in the garden</p>\r\n </li>\r\n <li><p>After: sau - After David had gone home, we arrived</p>\r\n </li>\r\n <li><p>During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film</p>\r\n </li>\r\n </ul>\r\n <p>2) Giời từ chỉ nơi chốn:</p>\r\n <ul>\r\n <li><p>At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk</p>\r\n </li>\r\n <li><p>In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)</p>\r\n </li>\r\n </ul>\r\n <p>Coffee 2 in 1, I’m working in Hanoi</p>\r\n <ul>\r\n <li>On, above, over : trên - The cat sleeps above the box</li>\r\n </ul>\r\n <p>3) Giời từ chỉ sự chuyển dịch:</p>\r\n <ul>\r\n <li>To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm</li>\r\n </ul>\r\n <p>I go into the garden, the boat was driven onto the rocks</p>\r\n <ul>\r\n <li><p>Across : ngang qua – A bird is flying across</p>\r\n </li>\r\n <li><p>Along : dọc theo - I knew it all along</p>\r\n </li>\r\n <li><p>Round, around, about: quanh - a round voyage Halong bay</p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Một số sai lầm thường gặp khi sử dụng giới từ</strong></p>\r\n <p><strong><em>Sai lầm 1:</em></strong> Suy luận từ cách dùng đã gặp trước đó:<br>Trước đó ta gặp : worry about : lo lắng về</p>\r\n <p>Lần sau gặp chữ : discuss <strong>_</strong> (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.</p>\r\n <p><strong><em>Sai lầm 2:</em></strong> Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:<br>Trước đó ta gặp : in the morning</p>\r\n <p>Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in =&gt; sai (đúng ra phải dùng on )</p>\r\n <p><strong><em>Sai lầm 3:</em></strong> Bị tiếng Việt ảnh hưởng:<br>Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) =&gt; nên thay bằng từ: important (quan trọng) với/ đối với</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n ", "13.gioitu.jpg", "**I. KHÁI NIỆM VÀ NGUYÊN TẮC SỬ DỤNG**\r\n \r\n **1.  Khái niệm**\r\n \r\n Trong ngữ pháp, **giới từ (preposition)** là một bộ phận lời nói giới thiệu, giới từ được đặt vào câu sẽ chỉ ra mối quan hệ giữa những điều được đề cập trong câu ấy.\r\n \r\n Ví dụ, trong câu “The cat sleeps on the sofa” (Con mèo ngủ trên ghế sofa), từ “on” là một giới từ, giới thiệu 1 danh từ thứ 2 có trong câu “on the sofa”\r\n \r\n **2.  Nguyên tắc sử dụng giới từ**\r\n **Vị trí của giới từ:** Giới từ có vị trí đứng riêng của mình trong câu, dưới đây là vị trí của một số giới từ cơ bản trong tiếng Anh\r\n \r\n **Trước danh từ:**\r\n \r\n In the morning: Vào buổi sáng\r\n \r\n On Monday: Vào thứ 2\r\n \r\n **Sau động từ:**\r\n \r\n Có thể liền sau động từ, có thể bị 1 từ khác chen giữa động từ và giới từ\r\n \r\n + The book is on the table = Quyển sách ở trên bàn.\r\n \r\n + I live in Ho Chi Minh city = Tôi sống ở thành phố Hồ Chí Minh.\r\n \r\n + He picked me up (from the airport) yesterday = Anh ấy đã đưa tôi lên ( từ sân bay)  ngày hôm qua\r\n \r\n **Sau tính từ:**\r\n \r\n + I’m not worried about living in a foreign country = Tôi không lo lắng về việc sống ở nước ngoài.\r\n \r\n + He is not angry with you = Anh ấy không giận bạn.\r\n \r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Z4MB94CUVbY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. MỘT SỐ GIỚI TỪ THƯỜNG GẶP VÀ NHỮNG ĐIỀU CẦN CHÚ Ý**\r\n \r\n **1. Một số giới từ thường gặp**\r\n 	1) Giời từ chỉ thời gian: \r\n - At: vào lúc (thường đi với giờ) - I get up at 6.00\r\n \r\n - On: vào (thường đi với ngày) - The book on the table\r\n \r\n - In: vào (thường đi với tháng, năm, mùa, thế kỷ) - On my birthday, on Saturday\r\n \r\n - Before: trước - Before my mother came home, my father had watered all the plants in the garden\r\n \r\n - After: sau - After David had gone home, we arrived\r\n \r\n - During: (trong khoảng) đi với danh từ chỉ thời gian - I fell asleep during the film\r\n \r\n 2) Giời từ chỉ nơi chốn:\r\n - At : tại (dùng cho nơi chốn nhỏ như trường học, sân bay…) - The teacher is at the desk\r\n \r\n - In : trong (chỉ ở bên trong) , ở (nơi chốn lớn thành phố, tỉnh ,quốc gia, châu lục…)\r\n \r\n Coffee 2 in 1, I’m working in Hanoi\r\n \r\n - On, above, over : trên - The cat sleeps above the box\r\n \r\n 3) Giời từ chỉ sự chuyển dịch:\r\n - To, into, onto : đến, tiếp cận và tiếp xúc bề mặt,ở phía ngoài cùng của vật, địa điểm\r\n \r\n I go into the garden, the boat was driven onto the rocks\r\n \r\n - Across : ngang qua – A bird is flying across\r\n \r\n - Along : dọc theo - I knew it all along\r\n \r\n - Round, around, about: quanh - a round voyage Halong bay\r\n \r\n **2. Một số sai lầm thường gặp khi sử dụng giới từ**\r\n \r\n ***Sai lầm 1:*** Suy luận từ cách dùng đã gặp trước đó:\r\n Trước đó ta gặp : worry about : lo lắng về\r\n \r\n Lần sau gặp chữ : discuss _____ (thảo luận về) thế là ta suy ra từ câu trên mà điền about vào, thế là sai.\r\n \r\n ***Sai lầm 2:*** Không nhận ra là giới từ thay đổi vì thấy cùng một danh từ:\r\n Trước đó ta gặp : in the morning\r\n \r\n Thế là khi gặp : ___ a cold winter morning, thấy morning nên chọn ngay in => sai (đúng ra phải dùng on )\r\n \r\n ***Sai lầm 3:*** Bị tiếng Việt ảnh hưởng:\r\n Tiếng Việt nói: lịch sự với ai; nên khi gặp : polite (lịch sự ) liền dùng ngay with ( với ) => nên thay bằng từ: important (quan trọng) với/ đối với\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/hhPoCCxnmsI\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n " },
                    { 20, "Cấu trúc Used to và cách sử dụng thông dụng nhất", "<p><strong>Used to là 1 cấu trúc được sử dụng khá phổ biến trong tiếng Anh. Nhiều bạn thấy sự xuất hiện của đuôi &quot;ed&quot; thường đoán cụm từ này thuộc thì quá khứ, để tìm hiểu kĩ hơn, hãy xem ngay tại bài viết dưới đây nhé.</strong></p>\r\n <p><strong> I. DỊCH NGHĨA, KHÁI NIỆM</strong><br><strong>1. Use to là gì?</strong><br>Use to nếu được dùng riêng lẻ sẽ có nghĩa là: Từng, đã từng</p>\r\n <p>Used to là cấu trúc ngữ pháp tiếng Anh được sử dụng để nói tới một sự kiện đã xảy ra trong quá khứ mà không xảy ra trong hiện tại nữa. Hoặc việc sử dụng cấu trúc use to để nhấn mạnh sự khác biệt giữa hiện tại và quá khứ.</p>\r\n <p>Ví dụ: I used to live in Ha Noi. (Tôi đã từng sống ở Ha Noi – nhưng hiện tại đã không còn nữa)</p>\r\n <p>I didn’t used to stay up late when I was a student (Tôi không từng thức khuya khi tôi còn là sinh viên – giờ đã bỏ thói quen đó)</p>\r\n <p><strong>2. Cấu trúc Used to</strong><br>Khẳng định: S + used to + V</p>\r\n <p>Ví dụ:<br>I used to read to the book.  (Ngày trước tôi thường đọc sách.)<br>We used to go to school together.  (Ngày trước chúng tôi thường đi học cùng nhau.)</p>\r\n <p>Phủ định: S + did not + use to + V</p>\r\n <p>Ví dụ:<br>I didn&#39;t use to read to the book.  (Ngày trước tôi thường không đọc sách.)<br>We did not use to go to school together.  (Ngày trước chúng tôi thường không đi học cùng nhau.)</p>\r\n <p>Nghi vấn: Did + S + use to + V..?</p>\r\n <p>Ví dụ:<br>Did you use to read to the book?  (Ngày trước bạn có thường đoch sách không?)<br>Did you use to go to school together?  (Ngày trước các bạn có thường đi học cùng nhau không?)</p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/C_cmBCkFXIY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>II. CÁCH SỬ DỤNG THÔNG DỤNG NHẤT </strong><br><strong>1. Để chỉ thói quen trong quá khứ</strong><br>Used to được sử dụng để chỉ thói quen trong quá khứ và không được duy trì trong hiện tại.</p>\r\n <p>Ví dụ:</p>\r\n <ul>\r\n <li><p>We used to live in Thai Binh when I as a child.</p>\r\n </li>\r\n <li><p>I used to walk to work when I was younger. </p>\r\n </li>\r\n </ul>\r\n <p><strong>2. Tình trạng / trạng thái trong quá khứ</strong><br>Used to được dùng để thể hiện tình trạng trong quá khứ (thường dùng ở quá khứ đơn) nhưng không còn tồn tại nữa được thể hiện bằng những động từ biểu hiện trạng thái sau: Have, believe, know và like.</p>\r\n <p>Ví dụ:</p>\r\n <ul>\r\n <li><p>I used to like The Men but now I never listen to them.</p>\r\n </li>\r\n <li><p>She used to have long hair but nowadays this hair is very short.</p>\r\n </li>\r\n </ul>\r\n <p>Dạng câu hỏi của Used to: Did(n&#39;t) + subject + use to</p>\r\n <p>Ví dụ:</p>\r\n <p>Did she use to work in the office very late at night?</p>\r\n <p><strong>3. Dạng câu hỏi của Used to: Did(n’t) + subject + use to</strong><br>VD: used to, be used to và get used to</p>\r\n <p>Did he use to work in the office very late at night?</p>\r\n <p><strong>4. Dạng phủ định của Used to: Subject + didn’t + use to</strong><br>VD:  used to, be used to và get used to</p>\r\n <p>– We didn’t use to be vegetarians.</p>\r\n <p>– We didn’t use to get up early when we were children.</p>\r\n <p><strong>III. NHỮNG TỪ LOẠI TƯƠNG TỰ</strong><br>Cấu trúc Be used to, Used to V, Get used to trong tiếng Anh có cấu trúc khá giống nhau nên thường bị nhầm lẫn khi làm các bài tập ngữ pháp. Bài viết dưới đây sẽ giúp bạn dễ dàng phân biệt 3 cấu trúc trên.<br><strong>1. Cấu trúc BE USED TO (Đã quen với)</strong><br><strong>- Cấu trúc: To be + V-ing/ Noun</strong></p>\r\n <p>Be used to + cụm danh từ hoặc ving (trong cấu trúc này, used là 1 tính từ và to là 1 giới từ)</p>\r\n <p><strong>- Cách dùng</strong></p>\r\n <ul>\r\n <li>Để diễn tả ý nghĩa rằng bạn đã từng làm 1 việc gì đó nhiều lần, đã rất có kinh nghiệm với việc này rồi và không còn lạ lẫm hoặc gặp khó khăn với việc này nữa.</li>\r\n </ul>\r\n <p><strong>Ví dụ:</strong></p>\r\n <ul>\r\n <li><p>I am used to getting up lately in the morning.</p>\r\n </li>\r\n <li><p>She didn&#39;t complain about the noise nextdoor. She was used to it.</p>\r\n </li>\r\n <li><p>Nghĩa ngược lại của be used to la be NOT used to: không quen với, chưa quen với</p>\r\n </li>\r\n </ul>\r\n <p><strong>Ví dụ:</strong></p>\r\n <p>I am not used to the new system in the factory yet.</p>\r\n <p><strong>2. Cấu trúc to GET USED TO (Dần quen với)</strong><br><strong>- Cấu trúc</strong></p>\r\n <p>to get used to + V-ing/ noun</p>\r\n <p><strong>- Cách dùng</strong></p>\r\n <p>Được sử dụng để nhấn mạnh nội dung của cấu trúc này là việc dần quen với 1 vấn đề/sự việc nào đó</p>\r\n <p><strong>Ví dụ:</strong></p>\r\n <p>He got used to American food</p>\r\n <p>I got used to getting up early in the morning. </p>\r\n <p>He is used to swimming every day</p>\r\n <p><strong>IV. BÀI TẬP THỰC HÀNH VÀ ĐÁP ÁN</strong><br><strong>1. Hoàn thành các câu dưới đây.</strong><br><em>Bài tập</em></p>\r\n <ol>\r\n <li><p>Liz .... a motorbike,but last year she sold it and bought a car.</p>\r\n </li>\r\n <li><p>We came to live in London a few years ago. We .... in Leeds.</p>\r\n </li>\r\n <li><p>I rarely eat ice-cream now, but I .... it when I was a child.</p>\r\n </li>\r\n <li><p>Jim .... my best friend, but we aren&#39;t good friend any longer.</p>\r\n </li>\r\n <li><p>It only takes me about 40 minutes to get to work now that the new roadis open. It .... more than an hour.</p>\r\n </li>\r\n <li><p>There .... a hotel near the airport, but it closed a long time ago.</p>\r\n </li>\r\n <li><p>When you lived in New York, .... to the theatre very often?</p>\r\n </li>\r\n </ol>\r\n <p><em>Đáp án:</em></p>\r\n <ol>\r\n <li><p>used to have              </p>\r\n </li>\r\n <li><p>used to live        </p>\r\n </li>\r\n <li><p>used to eat</p>\r\n </li>\r\n <li><p>used to be</p>\r\n </li>\r\n <li><p>used to take       </p>\r\n </li>\r\n <li><p>used to be           </p>\r\n </li>\r\n <li><p>used to use to go</p>\r\n </li>\r\n </ol>\r\n <p><strong>2. Hoàn thành các câu sau</strong><br><em>Câu hỏi</em></p>\r\n <ol>\r\n <li><p>European drivers find it difficult to <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (drive) on the left when they visit Britain.</p>\r\n </li>\r\n <li><p>See that building there? I <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (go) to school there, but now it&#39;s a factory.</p>\r\n </li>\r\n <li><p>I&#39;ve only been at this company a couple of months. I <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (still not) how they do things round here.</p>\r\n </li>\r\n <li><p>When I first arrived in this neighbourhood, I <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (live) in a house. I had always lived in apartment buildings.</p>\r\n </li>\r\n <li><p>Working till 10pm isn&#39;t a problem. I <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (finish) late. I did it in my last job too.</p>\r\n </li>\r\n <li><p>I can&#39;t believe they are going to build an airport just two miles from our new house! I will <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (never) all that noise! What a nightmare.</p>\r\n </li>\r\n <li><p>His father <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (smoke) twenty cigars a day - now he doesn&#39;t smoke at all!</p>\r\n </li>\r\n <li><p>Whenever all my friends went to discos, I <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (never go) with them, but now I enjoy it.</p>\r\n </li>\r\n <li><p>I <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (drive) as I have had my driving licence almost a year now.</p>\r\n </li>\r\n </ol>\r\n <p>When Max went to live in Italy, he <strong><strong><strong><strong><strong>___</strong></strong></strong></strong></strong> (live) there very quickly. He&#39;s a very open minded person.</p>\r\n <p><em>Đáp án:</em></p>\r\n <ol>\r\n <li><p>get used to driving.</p>\r\n </li>\r\n <li><p>used to go.</p>\r\n </li>\r\n <li><p>am still not used to</p>\r\n </li>\r\n <li><p>used to live.</p>\r\n </li>\r\n <li><p>am used to finishing.</p>\r\n </li>\r\n <li><p>never get used to.</p>\r\n </li>\r\n <li><p>used to smoke.</p>\r\n </li>\r\n <li><p>never used to go.</p>\r\n </li>\r\n <li><p>am used to driving.</p>\r\n </li>\r\n <li><p>got used to living.</p>\r\n </li>\r\n </ol>\r\n ", "14.cautrucusedto.jpg", "**Used to là 1 cấu trúc được sử dụng khá phổ biến trong tiếng Anh. Nhiều bạn thấy sự xuất hiện của đuôi \"ed\" thường đoán cụm từ này thuộc thì quá khứ, để tìm hiểu kĩ hơn, hãy xem ngay tại bài viết dưới đây nhé.**\r\n \r\n ** I. DỊCH NGHĨA, KHÁI NIỆM**\r\n **1. Use to là gì?**\r\n Use to nếu được dùng riêng lẻ sẽ có nghĩa là: Từng, đã từng\r\n \r\n Used to là cấu trúc ngữ pháp tiếng Anh được sử dụng để nói tới một sự kiện đã xảy ra trong quá khứ mà không xảy ra trong hiện tại nữa. Hoặc việc sử dụng cấu trúc use to để nhấn mạnh sự khác biệt giữa hiện tại và quá khứ.\r\n \r\n Ví dụ: I used to live in Ha Noi. (Tôi đã từng sống ở Ha Noi – nhưng hiện tại đã không còn nữa)\r\n \r\n I didn’t used to stay up late when I was a student (Tôi không từng thức khuya khi tôi còn là sinh viên – giờ đã bỏ thói quen đó)\r\n \r\n **2. Cấu trúc Used to**\r\n Khẳng định: S + used to + V\r\n \r\n Ví dụ:\r\n I used to read to the book.  (Ngày trước tôi thường đọc sách.)\r\n We used to go to school together.  (Ngày trước chúng tôi thường đi học cùng nhau.)\r\n \r\n Phủ định: S + did not + use to + V\r\n \r\n Ví dụ:\r\n I didn't use to read to the book.  (Ngày trước tôi thường không đọc sách.)\r\n We did not use to go to school together.  (Ngày trước chúng tôi thường không đi học cùng nhau.)\r\n \r\n Nghi vấn: Did + S + use to + V..?\r\n \r\n Ví dụ:\r\n Did you use to read to the book?  (Ngày trước bạn có thường đoch sách không?)\r\n Did you use to go to school together?  (Ngày trước các bạn có thường đi học cùng nhau không?)\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/C_cmBCkFXIY\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **II. CÁCH SỬ DỤNG THÔNG DỤNG NHẤT **\r\n **1. Để chỉ thói quen trong quá khứ**\r\n Used to được sử dụng để chỉ thói quen trong quá khứ và không được duy trì trong hiện tại.\r\n \r\n Ví dụ:\r\n \r\n - We used to live in Thai Binh when I as a child.\r\n \r\n - I used to walk to work when I was younger. \r\n \r\n **2. Tình trạng / trạng thái trong quá khứ**\r\n Used to được dùng để thể hiện tình trạng trong quá khứ (thường dùng ở quá khứ đơn) nhưng không còn tồn tại nữa được thể hiện bằng những động từ biểu hiện trạng thái sau: Have, believe, know và like.\r\n \r\n Ví dụ:\r\n \r\n - I used to like The Men but now I never listen to them.\r\n \r\n - She used to have long hair but nowadays this hair is very short.\r\n \r\n Dạng câu hỏi của Used to: Did(n't) + subject + use to\r\n \r\n Ví dụ:\r\n \r\n Did she use to work in the office very late at night?\r\n \r\n **3. Dạng câu hỏi của Used to: Did(n’t) + subject + use to**\r\n VD: used to, be used to và get used to\r\n \r\n Did he use to work in the office very late at night?\r\n \r\n **4. Dạng phủ định của Used to: Subject + didn’t + use to**\r\n VD:  used to, be used to và get used to\r\n \r\n – We didn’t use to be vegetarians.\r\n \r\n – We didn’t use to get up early when we were children.\r\n \r\n **III. NHỮNG TỪ LOẠI TƯƠNG TỰ**\r\n Cấu trúc Be used to, Used to V, Get used to trong tiếng Anh có cấu trúc khá giống nhau nên thường bị nhầm lẫn khi làm các bài tập ngữ pháp. Bài viết dưới đây sẽ giúp bạn dễ dàng phân biệt 3 cấu trúc trên.\r\n **1. Cấu trúc BE USED TO (Đã quen với)**\r\n **- Cấu trúc: To be + V-ing/ Noun**\r\n \r\n Be used to + cụm danh từ hoặc ving (trong cấu trúc này, used là 1 tính từ và to là 1 giới từ)\r\n \r\n **- Cách dùng**\r\n \r\n + Để diễn tả ý nghĩa rằng bạn đã từng làm 1 việc gì đó nhiều lần, đã rất có kinh nghiệm với việc này rồi và không còn lạ lẫm hoặc gặp khó khăn với việc này nữa.\r\n \r\n **Ví dụ:**\r\n \r\n - I am used to getting up lately in the morning.\r\n \r\n - She didn't complain about the noise nextdoor. She was used to it.\r\n \r\n + Nghĩa ngược lại của be used to la be NOT used to: không quen với, chưa quen với\r\n \r\n **Ví dụ:**\r\n \r\n I am not used to the new system in the factory yet.\r\n \r\n **2. Cấu trúc to GET USED TO (Dần quen với)**\r\n **- Cấu trúc**\r\n \r\n to get used to + V-ing/ noun\r\n \r\n **- Cách dùng**\r\n \r\n Được sử dụng để nhấn mạnh nội dung của cấu trúc này là việc dần quen với 1 vấn đề/sự việc nào đó\r\n \r\n **Ví dụ:**\r\n \r\n He got used to American food\r\n \r\n I got used to getting up early in the morning. \r\n \r\n He is used to swimming every day\r\n \r\n **IV. BÀI TẬP THỰC HÀNH VÀ ĐÁP ÁN**\r\n **1. Hoàn thành các câu dưới đây.**\r\n *Bài tập*\r\n 1. Liz .... a motorbike,but last year she sold it and bought a car.\r\n \r\n 2. We came to live in London a few years ago. We .... in Leeds.\r\n \r\n 3. I rarely eat ice-cream now, but I .... it when I was a child.\r\n \r\n 4. Jim .... my best friend, but we aren't good friend any longer.\r\n \r\n 5. It only takes me about 40 minutes to get to work now that the new roadis open. It .... more than an hour.\r\n \r\n 6. There .... a hotel near the airport, but it closed a long time ago.\r\n \r\n 7. When you lived in New York, .... to the theatre very often?\r\n \r\n *Đáp án:*\r\n \r\n 1. used to have              \r\n \r\n 2. used to live        \r\n \r\n 3. used to eat\r\n \r\n 4. used to be\r\n \r\n 5. used to take       \r\n \r\n 6. used to be           \r\n \r\n 7. used to use to go\r\n \r\n **2. Hoàn thành các câu sau**\r\n *Câu hỏi*\r\n 1. European drivers find it difficult to _______________________ (drive) on the left when they visit Britain.\r\n \r\n 2. See that building there? I _______________________ (go) to school there, but now it's a factory.\r\n \r\n 3. I've only been at this company a couple of months. I _______________________ (still not) how they do things round here.\r\n \r\n 4. When I first arrived in this neighbourhood, I _______________________ (live) in a house. I had always lived in apartment buildings.\r\n \r\n 5. Working till 10pm isn't a problem. I _______________________ (finish) late. I did it in my last job too.\r\n \r\n 6. I can't believe they are going to build an airport just two miles from our new house! I will _______________________ (never) all that noise! What a nightmare.\r\n \r\n 7. His father _______________________ (smoke) twenty cigars a day - now he doesn't smoke at all!\r\n \r\n 8. Whenever all my friends went to discos, I _______________________ (never go) with them, but now I enjoy it.\r\n \r\n 9. I _______________________ (drive) as I have had my driving licence almost a year now.\r\n \r\n When Max went to live in Italy, he _______________________ (live) there very quickly. He's a very open minded person.\r\n \r\n *Đáp án:*\r\n 1. get used to driving.\r\n \r\n 2. used to go.\r\n \r\n 3. am still not used to\r\n \r\n 4. used to live.\r\n \r\n 5. am used to finishing.\r\n \r\n 6. never get used to.\r\n \r\n 7. used to smoke.\r\n \r\n 8. never used to go.\r\n \r\n 9. am used to driving.\r\n \r\n 10. got used to living.\r\n \r\n \r\n " },
                    { 21, "Each other dịch nghĩa và cách sử dụng thông dụng nhất", "<p><strong>Each other là một trong những dạng ngữ pháp được sử dụng với other, each other thường được sử dụng để đề cập tới mối quan hệ tác động qua lại giữa 2 người với nhau.</strong></p>\r\n <p><strong>I. DỊCH NGHĨA EACH OTHER</strong><br><strong>1. Dịch nghĩa</strong><br>Each other được dịch sang tiếng Việt là : Nhau, lẫn nhau</p>\r\n <p>Each other thuộc từ loại đại từ tương hỗ bất định</p>\r\n <p>Ví dụ: The husband and wife love each other</p>\r\n <p>Thường dùng trong phạm vi 02 người cùng thực hiện hành động và có tác động qua lại lẫn nhau.</p>\r\n <p>Ví dụ:</p>\r\n <p>Jun and Susie really love each other.<br>Herry and Tom love each other</p>\r\n <p><strong>2. Dịch nghĩa từng từ</strong><br>Each other: Nhau, lẫn nhau</p>\r\n <p>Other: Những cái khác, những người khác.</p>\r\n <p>Each: Nghĩa là mỗi</p>\r\n <p><strong>II. CÁCH SỬ DỤNG THÔNG DỤNG NHẤT</strong><br><strong>1. Cách sử dụng của each other</strong></p>\r\n <ul>\r\n <li><p>Được dùng với vai trò (object)<br>Trong một mệnh đề mà chủ từ và động từ bao giờ cũng ở số nhiều </p>\r\n </li>\r\n <li><p>“ each other “ được áp dụng cho mối quan hệ qua lại hai người<br>Được sử dụng cho mối quan hệ qua lại giữa 2 người ( không phải xuất phát từ 1 phía)</p>\r\n </li>\r\n </ul>\r\n <p>Ví dụ: A and B love each other</p>\r\n <ul>\r\n <li>Được sử dụng cùng sở hữu cách<br>Ví dụ : </li>\r\n </ul>\r\n <p>We often shared each other’s meal<br>Each other: nhau (hai người,có qua có lại)<br><strong>2. Vị trí của each other</strong></p>\r\n <ul>\r\n <li>Đại từ hỗ tương đặt liền sau động từ</li>\r\n <li>Khi có giới từ theo sau động từ, đại từ hỗ tương đặt liền sau giới từ đó<br>Ví dụ: </li>\r\n </ul>\r\n <p>They looked at one another with surprise<br>They don’t want to live with each other<br>Ghi chú :</p>\r\n <ul>\r\n <li>Đừng nhầm lẫn đại từ hỗ tương với bất định từ: one, the other, another vì đại từ hỗ tương không bao giờ rời nhau</li>\r\n <li>Hãy phân biệt đại từ hỗ tương với đại từ phản thân<br>Ví dụ: </li>\r\n </ul>\r\n <p>They look at each other<br>They look at themselves in mirror</p>\r\n <p><strong>3. Phân biệt cách dùng của each other</strong><br>Rất dễ nhầm lẫn về các trường hợp khi sử dụng each other và one another vì nghĩa của 2 từ này nếu tách riêng ra khá tương đồng nhau.</p>\r\n <ul>\r\n <li>Khi muốn nói: Hai cô bé này đã giúp đỡ lẫn nhau.<br><strong><em>Hãy nói:</em></strong> <em>These two girls helped each othe</em><br><strong><em>Không nói:</em></strong> <em>These two girls helped one another</em></li>\r\n <li>Khi muốn nói: Ba cô bé này đã giúp đỡ lẫn nhau.<br><strong><em>Hãy nói:</em></strong> <em>These three girls helped one another    </em><br><strong><em>Không nói:</em></strong> *These three girls helped each other</li>\r\n </ul>\r\n <p><strong>Lưu ý:</strong></p>\r\n <ul>\r\n <li><p>&quot;Each other&quot; chỉ dùng khi có hai người, còn &quot;one another&quot; được dùng khi có từ ba người trở lên.<br>Julia and I must try to help each other<br>We must all help one another</p>\r\n </li>\r\n <li><p>Những từ không được dùng với EACH OTHER:<br>They &quot; met&quot; in 1992.---&gt; MEET<br>They &quot; married&quot; in 1994.-----&gt; MARRY<br>They interests are very &quot; similar&quot;.----&gt; SIMILAR</p>\r\n </li>\r\n <li><p>Trong tiếng Anh hiện đại, hầu hết người ta thường dùng each other và one another giống nhau. Nhưng one another thường được sử dụng nhiều hơn (giống như one) trong những câu chung chung, và không nói đến một người cụ thể nào.</p>\r\n </li>\r\n </ul>\r\n <p><strong>III. NHỮNG TỪ LOẠI TƯƠNG TỰ</strong><br><strong>1. One another (nhau):</strong><br>Cách dùng giống như “”each other”” nhưng dùng khi có 3 đối tượng trở lên.<br><em>Ví dụ: Through the Internet people are discovering new ways to share relevant information with one another.</em></p>\r\n <p>Dùng giống Each other nhưng thường dùng trong phạm vi 3 người trở lên. Như vậy, đối với Each other, các chủ thể này cũng có sự tác động, ảnh hưởng qua lại lẫn nhau.</p>\r\n <p><em>Ví dụ: We’ve learnt a lot about one another in this lesson.<br>Chúng ta đã hiểu nhiều về nhau trong bài học này. (Mỗi người trong chúng ta đều học được nhiều điều về nhau, về từng người còn lại).</em></p>\r\n <p><strong>2. Together (cùng nhau):</strong><br>Được dùng khi các đối tượng cùng thực hiện hành động nào đó mà không có tác động qua lại<br><em>Ví dụ: Julia and I kiss the baby together : tôi và Julia cùng hôn đứa bé =&gt; tôi và Julia không có hôn nhau =&gt; tôi và Julia không có tác động qua lại, mà cùng nhau tác động lên đối tượng khác</em></p>\r\n <p>Dùng khi các chủ thể thực hiện hành động cùng nhau nhưng không có sự tác động lẫn nhau.</p>\r\n <p><em>Ví dụ: They had dinner together last night.</em><br><em>Tối qua họ ăn tối cùng nhau. (Mỗi người đều ăn, hành động này không gây ảnh hưởng, tác động đến những người còn lại).</em></p>\r\n ", "15.each_other.jpg", "**Each other là một trong những dạng ngữ pháp được sử dụng với other, each other thường được sử dụng để đề cập tới mối quan hệ tác động qua lại giữa 2 người với nhau.**\r\n \r\n **I. DỊCH NGHĨA EACH OTHER**\r\n **1. Dịch nghĩa**\r\n Each other được dịch sang tiếng Việt là : Nhau, lẫn nhau\r\n \r\n Each other thuộc từ loại đại từ tương hỗ bất định\r\n \r\n Ví dụ: The husband and wife love each other\r\n \r\n Thường dùng trong phạm vi 02 người cùng thực hiện hành động và có tác động qua lại lẫn nhau.\r\n \r\n Ví dụ:\r\n \r\n Jun and Susie really love each other.\r\n Herry and Tom love each other\r\n \r\n **2. Dịch nghĩa từng từ**\r\n Each other: Nhau, lẫn nhau\r\n \r\n Other: Những cái khác, những người khác.\r\n \r\n Each: Nghĩa là mỗi\r\n \r\n **II. CÁCH SỬ DỤNG THÔNG DỤNG NHẤT**\r\n **1. Cách sử dụng của each other**\r\n - Được dùng với vai trò (object)\r\n Trong một mệnh đề mà chủ từ và động từ bao giờ cũng ở số nhiều \r\n \r\n - “ each other “ được áp dụng cho mối quan hệ qua lại hai người \r\n Được sử dụng cho mối quan hệ qua lại giữa 2 người ( không phải xuất phát từ 1 phía)\r\n \r\n Ví dụ: A and B love each other\r\n \r\n - Được sử dụng cùng sở hữu cách\r\n Ví dụ : \r\n \r\n We often shared each other’s meal\r\n Each other: nhau (hai người,có qua có lại) \r\n **2. Vị trí của each other**\r\n -  Đại từ hỗ tương đặt liền sau động từ\r\n -  Khi có giới từ theo sau động từ, đại từ hỗ tương đặt liền sau giới từ đó\r\n Ví dụ: \r\n \r\n They looked at one another with surprise\r\n They don’t want to live with each other\r\n Ghi chú :\r\n - Đừng nhầm lẫn đại từ hỗ tương với bất định từ: one, the other, another vì đại từ hỗ tương không bao giờ rời nhau\r\n - Hãy phân biệt đại từ hỗ tương với đại từ phản thân\r\n Ví dụ: \r\n \r\n They look at each other\r\n They look at themselves in mirror\r\n \r\n **3. Phân biệt cách dùng của each other**\r\n Rất dễ nhầm lẫn về các trường hợp khi sử dụng each other và one another vì nghĩa của 2 từ này nếu tách riêng ra khá tương đồng nhau.\r\n \r\n * Khi muốn nói: Hai cô bé này đã giúp đỡ lẫn nhau.\r\n ***Hãy nói:*** *These two girls helped each othe*\r\n ***Không nói:*** *These two girls helped one another*\r\n * Khi muốn nói: Ba cô bé này đã giúp đỡ lẫn nhau.\r\n ***Hãy nói:*** *These three girls helped one another	*\r\n ***Không nói:*** *These three girls helped each other\r\n \r\n **Lưu ý:**\r\n \r\n - \"Each other\" chỉ dùng khi có hai người, còn \"one another\" được dùng khi có từ ba người trở lên.\r\n Julia and I must try to help each other\r\n We must all help one another\r\n \r\n - Những từ không được dùng với EACH OTHER:\r\n They \" met\" in 1992.---> MEET\r\n They \" married\" in 1994.-----> MARRY\r\n They interests are very \" similar\".----> SIMILAR\r\n \r\n - Trong tiếng Anh hiện đại, hầu hết người ta thường dùng each other và one another giống nhau. Nhưng one another thường được sử dụng nhiều hơn (giống như one) trong những câu chung chung, và không nói đến một người cụ thể nào.\r\n \r\n **III. NHỮNG TỪ LOẠI TƯƠNG TỰ**\r\n **1. One another (nhau):**\r\n Cách dùng giống như “”each other”” nhưng dùng khi có 3 đối tượng trở lên.\r\n *Ví dụ: Through the Internet people are discovering new ways to share relevant information with one another.*\r\n \r\n Dùng giống Each other nhưng thường dùng trong phạm vi 3 người trở lên. Như vậy, đối với Each other, các chủ thể này cũng có sự tác động, ảnh hưởng qua lại lẫn nhau.\r\n \r\n *Ví dụ: We’ve learnt a lot about one another in this lesson.\r\n Chúng ta đã hiểu nhiều về nhau trong bài học này. (Mỗi người trong chúng ta đều học được nhiều điều về nhau, về từng người còn lại).*\r\n \r\n **2. Together (cùng nhau):**\r\n Được dùng khi các đối tượng cùng thực hiện hành động nào đó mà không có tác động qua lại\r\n *Ví dụ: Julia and I kiss the baby together : tôi và Julia cùng hôn đứa bé => tôi và Julia không có hôn nhau => tôi và Julia không có tác động qua lại, mà cùng nhau tác động lên đối tượng khác*\r\n \r\n Dùng khi các chủ thể thực hiện hành động cùng nhau nhưng không có sự tác động lẫn nhau.\r\n \r\n *Ví dụ: They had dinner together last night.*\r\n *Tối qua họ ăn tối cùng nhau. (Mỗi người đều ăn, hành động này không gây ảnh hưởng, tác động đến những người còn lại).*" },
                    { 22, "As long as dịch nghĩa và cách sử dụng thông dụng nhất", "<p><strong>As long as được sử dụng khá thông dụng trong các trường hợp văn nói, viết của tiếng Anh, nếu dịch riêng từng từ một thì chúng ta có thể hiểu As long as là “càng dài” “vì dài” “vì lâu”… Nhưng những cách hiểu vậy đã đúng chưa?</strong></p>\r\n <p><strong>I. DỊCH NGHĨA</strong><br><strong>1. As long as là gì?</strong><br>“As long as” mang ý nghĩa là miễn như, miễn là, đây là nghĩa được hiểu theo cụm từ, bạn không thể dịch nghĩa từng từ để hiểu cả cụm. As long as thuộc nhóm từ (hay còn gọi là liên từ) được tạo nên bởi sự liên kết giữa 2 từ “as” và “long”</p>\r\n <p>Trong tiếng Anh có 3 loại liên từ chính là: Coordinating Conjunctions (liên từ kết hợp), Correlative Conjunctions (liên từ tương quan) và Subordinating Conjunctions (liên từ phụ thuộc). As long as nằm trong nhóm liên từ phụ thuộc.</p>\r\n <p>Lưu ý: Trong tiếng Anh có khá nhiều cụm từ được dịch nghĩa theo cụm, nếu tách rời cụm từ đó, nó sẽ được hiểu theo những nghĩa khác nhau.</p>\r\n <p>Ex: She may stay here as long as she likes.</p>\r\n <p><strong>2. Dịch nghĩa từng từ trong cụm</strong><br>As long as /trạng từ/ miễn là<br>As /trạng từ/ Nhân vì, như<br>As /liên từ/ bởi vì, tại vì, do<br>Long /tính từ/ dài, lâu</p>\r\n <p><strong>II. CÁCH SỬ DỤNG THÔNG DỤNG NHẤT</strong><br><strong>1. as long as&quot; mang ý nghĩa so sánh</strong><br>Trong trường hợp này, cụm từ as long as được sử dụng mang ý nghĩa so sánh ( đúng theo nghĩa của cụm từ as... as)<br>Ex:<br>This ruler is as long as my notebook.<br>The fish was as long as my arm.</p>\r\n <p><strong>2. “as long as” với nghĩa trong khoảng thời gian hoặc ở thời kỳ này </strong><br>Cụm từ được sử dụng mang nghĩa về thời gian để chỉ khoảng thời gian hoặc 1 thời kì ở hiện tại<br>Ex:<br>I’ll never forgive you as long as I live.<br>I’ll remember all the good times we had together as long as I live.</p>\r\n <p><strong>3. Tương tự nghĩa với Providing/ provided that với nghĩa miễn là</strong><br>Cụm từ được thể hiện theo đúng như nghĩa thường được dùng nhiều nhất hiện nay, mang nghĩa miễn là<br>Ex:<br>You can use my smartphone as long as you use it carefully.<br>You can stay here as long as you don’t drink.<br>You can stay here so long as you don’t drink.</p>\r\n <p><strong>4. “as long as” diễn tả độ lâu dài của hành động trong một khoảng thời gian.</strong><br>Ex:<br>The Asian Games can last as long as a month.<br>A cricket game can last as long as five days.</p>\r\n <p><strong><em>Giải trí: Bài hát As long as you love me</em></strong></p>\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Qol81esn1r8\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n <p><strong>III. NHỮNG TỪ LOẠI TƯƠNG TỰ VÀ CÁCH PHÂN BIỆT</strong><br><strong>1. Unless</strong></p>\r\n <p>Ý nghĩa: Unless có nghĩa tương tự như if not, với nghĩa “ trừ khi”,</p>\r\n <p>Unless = if not = excep if</p>\r\n <p>Come next week unless I phone ( = if don’t phone/Excep if I phone)</p>\r\n <p>I’ll take the job unless the pay is too low ( = if the pay isn’t too low/Excep if the pay is low)</p>\r\n <p>Khi nào không được dùng unless: Unless có thể được dùng thay cho if…not khi chúng ta đề cập tới những tình huống ngoại lệ sẽ thay đổi một tình trạng nào đó. Nhưng chúng ta không dùng unless để nói đến sự phủ định của 1 việc gì đó là nguyên nhân chính của tình huống chúng ta nói đến</p>\r\n <p><em>Ví dụ: My mother will be very upset if I don’t get back tomorrow (Not: My mother will be very upset unless I get back tomorrow)</em><br><em>Nếu người nói không trở lại, điều này là nguyên nhân chính gây nên sự bất bình của mẹ người đó – if not ở đây không có nghĩa “trừ phi”)</em></p>\r\n <p><em>Ví dụ: She’d look nicer if she didn’t wear so much make-up (Not: She’d look nicer unless she wore so much make-up)</em><br>Trong mệnh đề với unless, chúng ta thường dùng thì hiện tại nói đến tương lai<br>I’ll be in all day unless the office phones (Not: unless the office will phone)</p>\r\n <p><em>2.  So long so/ provided (that)/ providing (that) </em><br>Là những thành ngữ có nghĩa “nếu” hay “trong trường hợp mà“, “miễn là“</p>\r\n <p>Ví dụ:<br>You can take my car as long as / so long as you drive carefuly<br>Providing/ provided ( that) she studies hard – she’ll pass her Exams<br>Sau so long as/ provided that/ providing that chúng ta dùng thì hiện tại để diễn tả ý tương lai</p>\r\n <p>Ví dụ: I’ll remember that day as long as I live ( Not: as long as I will live)</p>\r\n ", "16.aslongas.jpg", "**As long as được sử dụng khá thông dụng trong các trường hợp văn nói, viết của tiếng Anh, nếu dịch riêng từng từ một thì chúng ta có thể hiểu As long as là “càng dài” “vì dài” “vì lâu”… Nhưng những cách hiểu vậy đã đúng chưa?**\r\n \r\n **I. DỊCH NGHĨA**\r\n **1. As long as là gì?**\r\n “As long as” mang ý nghĩa là miễn như, miễn là, đây là nghĩa được hiểu theo cụm từ, bạn không thể dịch nghĩa từng từ để hiểu cả cụm. As long as thuộc nhóm từ (hay còn gọi là liên từ) được tạo nên bởi sự liên kết giữa 2 từ “as” và “long”\r\n \r\n Trong tiếng Anh có 3 loại liên từ chính là: Coordinating Conjunctions (liên từ kết hợp), Correlative Conjunctions (liên từ tương quan) và Subordinating Conjunctions (liên từ phụ thuộc). As long as nằm trong nhóm liên từ phụ thuộc.\r\n \r\n Lưu ý: Trong tiếng Anh có khá nhiều cụm từ được dịch nghĩa theo cụm, nếu tách rời cụm từ đó, nó sẽ được hiểu theo những nghĩa khác nhau.\r\n \r\n Ex: She may stay here as long as she likes.\r\n \r\n **2. Dịch nghĩa từng từ trong cụm**\r\n As long as /trạng từ/ miễn là\r\n As /trạng từ/ Nhân vì, như\r\n As /liên từ/ bởi vì, tại vì, do\r\n Long /tính từ/ dài, lâu\r\n \r\n **II. CÁCH SỬ DỤNG THÔNG DỤNG NHẤT**\r\n **1. as long as\" mang ý nghĩa so sánh**\r\n Trong trường hợp này, cụm từ as long as được sử dụng mang ý nghĩa so sánh ( đúng theo nghĩa của cụm từ as... as)\r\n Ex:\r\n This ruler is as long as my notebook.\r\n The fish was as long as my arm.\r\n \r\n **2. “as long as” với nghĩa trong khoảng thời gian hoặc ở thời kỳ này **\r\n Cụm từ được sử dụng mang nghĩa về thời gian để chỉ khoảng thời gian hoặc 1 thời kì ở hiện tại\r\n Ex: \r\n I’ll never forgive you as long as I live.\r\n I’ll remember all the good times we had together as long as I live.\r\n \r\n **3. Tương tự nghĩa với Providing/ provided that với nghĩa miễn là**\r\n Cụm từ được thể hiện theo đúng như nghĩa thường được dùng nhiều nhất hiện nay, mang nghĩa miễn là\r\n Ex:\r\n You can use my smartphone as long as you use it carefully.\r\n You can stay here as long as you don’t drink.\r\n You can stay here so long as you don’t drink.\r\n \r\n **4. “as long as” diễn tả độ lâu dài của hành động trong một khoảng thời gian.**\r\n Ex: \r\n The Asian Games can last as long as a month. \r\n A cricket game can last as long as five days.\r\n \r\n ***Giải trí: Bài hát As long as you love me***\r\n <iframe width=\"750\" height=\"422\" src=\"https://www.youtube.com/embed/Qol81esn1r8\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n \r\n **III. NHỮNG TỪ LOẠI TƯƠNG TỰ VÀ CÁCH PHÂN BIỆT**\r\n **1. Unless**\r\n \r\n Ý nghĩa: Unless có nghĩa tương tự như if not, với nghĩa “ trừ khi”,\r\n \r\n Unless = if not = excep if\r\n \r\n Come next week unless I phone ( = if don’t phone/Excep if I phone)\r\n \r\n I’ll take the job unless the pay is too low ( = if the pay isn’t too low/Excep if the pay is low)\r\n \r\n Khi nào không được dùng unless: Unless có thể được dùng thay cho if…not khi chúng ta đề cập tới những tình huống ngoại lệ sẽ thay đổi một tình trạng nào đó. Nhưng chúng ta không dùng unless để nói đến sự phủ định của 1 việc gì đó là nguyên nhân chính của tình huống chúng ta nói đến\r\n \r\n *Ví dụ: My mother will be very upset if I don’t get back tomorrow (Not: My mother will be very upset unless I get back tomorrow)*\r\n *Nếu người nói không trở lại, điều này là nguyên nhân chính gây nên sự bất bình của mẹ người đó – if not ở đây không có nghĩa “trừ phi”)*\r\n \r\n *Ví dụ: She’d look nicer if she didn’t wear so much make-up (Not: She’d look nicer unless she wore so much make-up)*\r\n Trong mệnh đề với unless, chúng ta thường dùng thì hiện tại nói đến tương lai\r\n I’ll be in all day unless the office phones (Not: unless the office will phone)\r\n \r\n *2.  So long so/ provided (that)/ providing (that) *\r\n Là những thành ngữ có nghĩa “nếu” hay “trong trường hợp mà“, “miễn là“\r\n \r\n Ví dụ:\r\n You can take my car as long as / so long as you drive carefuly\r\n Providing/ provided ( that) she studies hard – she’ll pass her Exams\r\n Sau so long as/ provided that/ providing that chúng ta dùng thì hiện tại để diễn tả ý tương lai\r\n \r\n Ví dụ: I’ll remember that day as long as I live ( Not: as long as I will live)" },
                    { 23, "Thì hiện tại hoàn thành (Present Perfect) 1 – Công thức, Cách dùng, Dấu hiệu nhận biết và Bài tập", "<p><strong>Thì hiện tại hoàn thành rất phổ biến trong giao tiếp hàng ngày cũng như trong các văn phong trao đổi công việc. Bạn đã biết gì về thì này rồi, cùng anh ngữ Ms Hoa tìm hiểu thêm bạn nhé</strong></p>\r\n <p>Sau bài học trước về thì hiện tại đơn, hôm nay chúng ta tiếp tục học thì hiện tại hoàn thành (Present Perfect) – đây là thì tiếng Anh mà rất nhiều bạn nhầm lẫn cách sử dụng. Vì vậy, trong bài học kiến thức ngữ pháp cơ bản thì hiện tại hoàn thành, cô sẽ chia sẻ đầy đủ cho các bạn cấu trúc, cách sử dụng, dấu hiệu nhận biết và bài tập củng cố rèn luyện. Trong từng cách sử dụng cô sẽ bổ sung cả mẹo nhận biết và lưu ý những trường hợp đặc biệt để các bạn học đầy đủ và hiểu kiến thức thì hiện tại hoàn thành chi tiết nhất.</p>\r\n <p><img src=\"https://www.anhngumshoa.com//uploads/images/userfiles/thi_hien_tai_hoan_thanh.JPG\" alt=\"\"></p>\r\n <p><strong>I. KHÁI NIỆM</strong><br>Thì hiện tại hoàn thành dùng để diễn tả về một hành động đã hoàn thành cho tới thời điểm hiện tại mà không bàn về thời gian diễn ra nó.<br><strong>Câu khẳng định:</strong><br>S + have/ has + PII.</p>\r\n <p>CHÚ Ý:</p>\r\n <p>– S = I/ We/ You/ They + have</p>\r\n <p>– S = He/ She/ It + has</p>\r\n <p>Ví dụ:</p>\r\n <p>–  I have graduated from my university since 2012. (Tôi tốt nghiệp đại học từ năm 2012.)</p>\r\n <p>– We have worked for this company for 4 years. (Chúng tôi làm việc cho công ty này 4 năm rồi.)</p>\r\n <ul>\r\n <li>She has started the assignment. ( Cô ấy đã bắt đầu với nhiệm vụ.)</li>\r\n </ul>\r\n <p><strong>Câu phủ định</strong><br>S + haven’t/ hasn’t + PII.</p>\r\n <p>CHÚ Ý:</p>\r\n <p>– haven’t = have not</p>\r\n <p>– hasn’t = has not</p>\r\n <p>Ví dụ:</p>\r\n <p>– We haven’t met each other for a long time.(Chúng tôi không gặp nhau trong một thời gian dài rồi.)</p>\r\n <p>–  Daniel hasn’t come back his hometown since 2015. (Daniel không quay trở lại quê hương của mình từ năm 2015.)</p>\r\n <ul>\r\n <li>I haven’t started the assignment (Tôi chưa bắt đầu với nhiệm vụ)</li>\r\n </ul>\r\n <p><strong>Câu nghi vấn</strong><br>Q: Have/Has + S + PII?<br>A: Yes, S + have/ has.<br>      No, S + haven&#39;t / hasn&#39;t.</p>\r\n <p>Ví dụ:</p>\r\n <p>Have you ever travelled to Vietnam? (Bạn đã từng du lịch tới Việt Nam bao giờ chưa?)</p>\r\n <p>Yes, I have./ No, I haven’t.</p>\r\n <p>– Has she arrived London yet? (Cô ấy đã tới Luân Đôn chưa?)</p>\r\n <p>Yes, she has./ No, she hasn’t.</p>\r\n <ul>\r\n <li>Have you started the assignment? (Bạn đã bắt đầu với công việc, nhiệm vụ</li>\r\n </ul>\r\n <p><strong>III. CÁCH SỬ DỤNG THÌ HIỆN TẠI HOÀN THÀNH</strong><br>➣ Hành động đã hoàn thành cho tới thời điểm hiện tại mà không đề cập tới nó xảy ra khi nào.<br>E.g.: I’ve done all my homework. / Tôi đã làm hết bài tập về nhà.</p>\r\n <p>➣Hành động bắt đầu ở quá khứ và đang tiếp tục ở hiện tại.</p>\r\n <p>E.g. 1:  They’ve been married for nearly fifty years. (Họ đã kết hôn được 50 năm.)</p>\r\n <p>E.g. 2: She has lived in Tokyo all her life. (Cố ấy đã sống cả đời ở Liverpool.)</p>\r\n <p> Lưu ý : Chúng ta có thể sử dụng Thì hiện tại hoàn thành tiếp diễn cho những trường hợp như ví dụ 2.</p>\r\n <p>E.g.:</p>\r\n <p>She has been living in Tokyo all her life.<br>It’s been raining for hours.<br>➣ Diễn tả hành động đã từng làm trước đây và bây giờ vẫn còn làm</p>\r\n <p>E.g.:</p>\r\n <p>He has written three books and he is working on another book.( Anh ấy đã viết được 3 cuốn sách và đang viết cuốn tiếp theo.)</p>\r\n <p>I’ve played the guitar ever since I was a teenager.( Tôi đã chơi guitar kể từ khi còn nhỏ.)</p>\r\n <p>➣ Chúng ta thường sử dụng một mệnh đề với “since” chỉ ra khi một cái gì đó bắt đầu trong quá khứ:</p>\r\n <p>They’ve stayed with us since last week. (Họ đã ở với chúng tôi từ tuần trước.)</p>\r\n <p>I have worked here since I left school. ( Tôi đã làm việc ở đây kể từ khi tôi rời trường.)</p>\r\n <p>➣Một kinh nghiệm cho tới thời điểm hiện tại (thường dùng trạng từ ever)</p>\r\n <p>E.g.1: My last birthday was the worst day I’ve ever had. (Sinh nhật năm ngoái là ngày tệ nhất đời tôi.)</p>\r\n <p>E.g.2: Have you ever met George? Yes, but I’ve never met his wife. (Sử dụng never cho trường hợp tiêu cực)</p>\r\n <p>➣Về một hành động trong quá khứ nhưng quan trọng tại thời điểm nói</p>\r\n <p>E.g.1: I can’t get my house. I’ve lost my keys. (Tôi không thể vào nhà được. Tôi đánh mất chùm chìa khóa của mình rồi.)</p>\r\n <p>E.g. 2: Teresa isn’t at home. I think she has gone shopping. (Teresa không có ở nhà. Tôi nghĩ cô ấy đã đi mua sắm.)</p>\r\n <p>Lưu ý đặc biệt: Trong một số trường hợp, ta sử dụng trạng thái quá khứ phân từ của động từ TOBE : BEEN như một dạng quá khứ phân từ của động từ GO.</p>\r\n <p>Trong các thì tiếng Anh, &quot;thì hiện tại hoàn thành&quot; và &quot;thì quá khứ đơn&quot; là 2 thì rất nhiều bạn dễ bị nhầm lẫn cách sử dụng. Chính vì vậy, các bạn lưu ý thật kỹ để sử dụng thì tiếng Anh thật hợp lý trong ngữ cảnh nhé!</p>\r\n <p><strong>IV. DẤU HIỆU NHẬN BIẾT</strong></p>\r\n <ul>\r\n <li><p>just, recently, lately: gần đây, vừa mới</p>\r\n <ul>\r\n <li><p>already: rồi</p>\r\n </li>\r\n <li><p>before: trước đây</p>\r\n </li>\r\n <li><p>ever: đã từng</p>\r\n </li>\r\n </ul>\r\n </li>\r\n <li><p>never: chưa từng, không bao giờ</p>\r\n <ul>\r\n <li>yet: chưa (dùng trong câu phủ định và câu hỏi)</li>\r\n </ul>\r\n </li>\r\n <li><p>for + N – quãng thời gian: trong khoảng (for a year, for a long time, …) ví dụ: for 2 months: trong vòng 2 tháng</p>\r\n <ul>\r\n <li><p>since + N – mốc/điểm thời gian: từ khi (since 1992, since June, …)</p>\r\n </li>\r\n <li><p>so far = until now = up to now = up to the present: cho đến bây giờ</p>\r\n </li>\r\n <li><p>in/ for/ during/ over + the past/ last + thời gian: trong …. Qua ( Ví dụ: During the past 2 years: trong 2 năm qua)</p>\r\n </li>\r\n </ul>\r\n </li>\r\n </ul>\r\n <p><em>*</em> Vị trí của các trạng từ trong thì hiện tại hoàn thành:</p>\r\n <ul>\r\n <li><p>already, never, ever, just: sau “have/ has” và đứng trước động từ phân từ II.</p>\r\n </li>\r\n <li><p>already: cũng có thể đứng cuối câu.</p>\r\n </li>\r\n </ul>\r\n <p>E.g.: I have just come back home. (Tôi vừa mới về nhà.)</p>\r\n <ul>\r\n <li>Yet: đứng cuối câu, và thường được sử dụng trong câu phủ định và nghi vấn.</li>\r\n </ul>\r\n <p>E.g.: She hasn’t told me about you yet. (Cô ấy vẫn chưa kể với tôi về bạn.)</p>\r\n <ul>\r\n <li>so far, recently, lately, up to present, up to this moment, in/ for/ during/ over + the past/ last + thời gian: Có thể đứng đầu hoặc cuối câu.</li>\r\n </ul>\r\n <p>E.g.: I have seen this film recently. (Tôi xem bộ phim này gần đây.)</p>\r\n <p><strong>V. BÀI TẬP THÌ HIỆN TẠI HOÀN THÀNH</strong><br>Sau khi học kiến thức ngữ pháp cơ bản về thì hiện tại hoàn thành các bạn nên làm bài tập dưới đây để củng cố vững chắc hơn, hiểu và biết cách áp dụng tốt nhất nhé!</p>\r\n <p><strong>Bài tập 1:  Đọc các tình huống, sử dụng các động từ dưới đây và viết lại câu với thì hiện tại hoàn thành:</strong></p>\r\n <p>arrive - break – fall - go - up - grow - improve – lose</p>\r\n <ol>\r\n <li><p>Tom is looking for his key. He can&#39;t find it.  = Tom has lost his key.</p>\r\n </li>\r\n <li><p>Lisa can&#39;t walk and her leg is in plaster.<br>Lisa .................... . .... ............................................ .</p>\r\n </li>\r\n <li><p>Last week the bus fare was £1 .80. Now it is £2.<br>The bus fare ........................................ .............. ..</p>\r\n </li>\r\n <li><p>Maria&#39;s English wasn&#39;t very good. Now it is better.<br>Her English .............................................................. .</p>\r\n </li>\r\n <li><p>Dan didn&#39;t have a beard before. Now he has a beard.<br>Dan ..........................................................................</p>\r\n </li>\r\n <li><p>This morning I was expecting a letter. Now I have it.<br>The letter .................................................................</p>\r\n </li>\r\n <li><p>The temperature was 20 degrees. Now it is only 12.<br>The .................................................... ........................... ..</p>\r\n </li>\r\n </ol>\r\n <p><strong>Bài tập 2: Chọn “Been” hoặc “Gone”</strong></p>\r\n <ol>\r\n <li><p>James is on holiday. He&#39;s gone to Italy.</p>\r\n </li>\r\n <li><p>Hello! I&#39;ve just ........... ... to the shops. I&#39;ve bought lots of things.</p>\r\n </li>\r\n <li><p>A lice isn&#39;t here at the moment. She&#39;s ..... .......... ............................ to the shop to get a newspaper.</p>\r\n </li>\r\n <li><p>Tom has ..................................... out. He&#39;ll be back in about an hour.</p>\r\n </li>\r\n <li><p>&#39;Are you going to the bank?&#39; - &#39;No, I&#39;ve already ..... . ....................... ..... to the bank.&#39;</p>\r\n </li>\r\n </ol>\r\n <p><strong>Bài tập 3: Trả lời các câu hỏi dựa vào từ trong ngoặc</strong></p>\r\n <ol>\r\n <li><p>Would you like something to eat?<br>No, thanks. ..... I have just had lunch... (I / just / have / lunch)</p>\r\n </li>\r\n <li><p>Do you know where Julia is?<br>Yes, .................................. ................................................. .. ..... ............. . .. (I / just / see / her)</p>\r\n </li>\r\n <li><p>What time is David leaving?<br>.....................................................................................................................(He / already / leave)</p>\r\n </li>\r\n <li><p>What&#39;s in the newspaper today?<br>I don&#39;t know. .. ............................................................. .............................. (I / not / read / it / yet)</p>\r\n </li>\r\n <li><p>Is Sue com ing to the cinema with us?<br>No, ....... .. ............................................................................. .... .. (She / already / see / the film)</p>\r\n </li>\r\n <li><p>Are your friends here yet?<br>Yes, .. ................ ..........................................................................................  (they / just / arrive)</p>\r\n </li>\r\n <li><p>What does Tim think about your plan?<br>...........................................................................................................(we / not / tell / him / yet)</p>\r\n </li>\r\n </ol>\r\n <p><strong>VI. ĐÁP ÁN</strong></p>\r\n <p><strong>Bài tập 1:</strong><br>2, Lisa has broken her leg.<br>3, The bus fare has gone up.<br>4, Her English has improved.<br>5, Dan has grown a beard.<br>6, The letter has arrived.<br>7, The temperature has fallen.</p>\r\n <p><strong>Bài tập 2:</strong></p>\r\n <p>2, been</p>\r\n <p>3, gone</p>\r\n <p>4, gone</p>\r\n <p>5, been</p>\r\n <p><strong>Bài tập 3:</strong></p>\r\n <ol>\r\n <li><p>Yes, I&#39;ve just seen her.<br>Yes, I have just seen her.<br>or Yes, I just saw her.</p>\r\n </li>\r\n <li><p>He&#39;s already left.<br>He has already left.<br>or He already left.</p>\r\n </li>\r\n <li><p>I haven&#39;t read it yet.<br>or I didn&#39;t read it yet.</p>\r\n </li>\r\n <li><p>No, she&#39;s already seen the film.<br>No, she has already seen.<br>or No, she already saw.</p>\r\n </li>\r\n <li><p>Yes, they&#39;ve just arrived.<br>Yes, they have just arrived.<br>or Yes, they just arrived.</p>\r\n </li>\r\n <li><p>We haven&#39;t told him yet.<br>or We didn&#39;t tell him yet.</p>\r\n </li>\r\n </ol>\r\n ", "23.thi_htht_anhngumshoa.jpg", "**Thì hiện tại hoàn thành rất phổ biến trong giao tiếp hàng ngày cũng như trong các văn phong trao đổi công việc. Bạn đã biết gì về thì này rồi, cùng anh ngữ Ms Hoa tìm hiểu thêm bạn nhé**\r\n \r\n Sau bài học trước về thì hiện tại đơn, hôm nay chúng ta tiếp tục học thì hiện tại hoàn thành (Present Perfect) – đây là thì tiếng Anh mà rất nhiều bạn nhầm lẫn cách sử dụng. Vì vậy, trong bài học kiến thức ngữ pháp cơ bản thì hiện tại hoàn thành, cô sẽ chia sẻ đầy đủ cho các bạn cấu trúc, cách sử dụng, dấu hiệu nhận biết và bài tập củng cố rèn luyện. Trong từng cách sử dụng cô sẽ bổ sung cả mẹo nhận biết và lưu ý những trường hợp đặc biệt để các bạn học đầy đủ và hiểu kiến thức thì hiện tại hoàn thành chi tiết nhất.\r\n \r\n ![](https://www.anhngumshoa.com//uploads/images/userfiles/thi_hien_tai_hoan_thanh.JPG)\r\n \r\n **I. KHÁI NIỆM**\r\n Thì hiện tại hoàn thành dùng để diễn tả về một hành động đã hoàn thành cho tới thời điểm hiện tại mà không bàn về thời gian diễn ra nó. \r\n **Câu khẳng định:**\r\n S + have/ has + PII.\r\n \r\n CHÚ Ý:\r\n \r\n – S = I/ We/ You/ They + have\r\n \r\n – S = He/ She/ It + has\r\n \r\n Ví dụ:\r\n \r\n –  I have graduated from my university since 2012. (Tôi tốt nghiệp đại học từ năm 2012.)\r\n \r\n – We have worked for this company for 4 years. (Chúng tôi làm việc cho công ty này 4 năm rồi.)\r\n \r\n - She has started the assignment. ( Cô ấy đã bắt đầu với nhiệm vụ.)\r\n \r\n **Câu phủ định**\r\n S + haven’t/ hasn’t + PII.\r\n \r\n CHÚ Ý:\r\n \r\n – haven’t = have not\r\n \r\n – hasn’t = has not\r\n \r\n Ví dụ:\r\n \r\n – We haven’t met each other for a long time.(Chúng tôi không gặp nhau trong một thời gian dài rồi.)\r\n \r\n –  Daniel hasn’t come back his hometown since 2015. (Daniel không quay trở lại quê hương của mình từ năm 2015.)\r\n \r\n - I haven’t started the assignment (Tôi chưa bắt đầu với nhiệm vụ)\r\n \r\n **Câu nghi vấn**\r\n Q: Have/Has + S + PII?\r\n A: Yes, S + have/ has.\r\n       No, S + haven't / hasn't.\r\n \r\n Ví dụ:\r\n \r\n Have you ever travelled to Vietnam? (Bạn đã từng du lịch tới Việt Nam bao giờ chưa?)\r\n \r\n Yes, I have./ No, I haven’t.\r\n \r\n – Has she arrived London yet? (Cô ấy đã tới Luân Đôn chưa?)\r\n \r\n Yes, she has./ No, she hasn’t.\r\n \r\n - Have you started the assignment? (Bạn đã bắt đầu với công việc, nhiệm vụ\r\n \r\n **III. CÁCH SỬ DỤNG THÌ HIỆN TẠI HOÀN THÀNH**\r\n ➣ Hành động đã hoàn thành cho tới thời điểm hiện tại mà không đề cập tới nó xảy ra khi nào.\r\n E.g.: I’ve done all my homework. / Tôi đã làm hết bài tập về nhà.\r\n \r\n ➣Hành động bắt đầu ở quá khứ và đang tiếp tục ở hiện tại.\r\n \r\n E.g. 1:  They’ve been married for nearly fifty years. (Họ đã kết hôn được 50 năm.)\r\n \r\n E.g. 2: She has lived in Tokyo all her life. (Cố ấy đã sống cả đời ở Liverpool.)\r\n \r\n  Lưu ý : Chúng ta có thể sử dụng Thì hiện tại hoàn thành tiếp diễn cho những trường hợp như ví dụ 2.\r\n \r\n E.g.:\r\n \r\n She has been living in Tokyo all her life.\r\n It’s been raining for hours.\r\n ➣ Diễn tả hành động đã từng làm trước đây và bây giờ vẫn còn làm\r\n \r\n E.g.:\r\n \r\n He has written three books and he is working on another book.( Anh ấy đã viết được 3 cuốn sách và đang viết cuốn tiếp theo.)\r\n \r\n I’ve played the guitar ever since I was a teenager.( Tôi đã chơi guitar kể từ khi còn nhỏ.)\r\n \r\n ➣ Chúng ta thường sử dụng một mệnh đề với “since” chỉ ra khi một cái gì đó bắt đầu trong quá khứ:\r\n \r\n They’ve stayed with us since last week. (Họ đã ở với chúng tôi từ tuần trước.)\r\n \r\n I have worked here since I left school. ( Tôi đã làm việc ở đây kể từ khi tôi rời trường.)\r\n \r\n ➣Một kinh nghiệm cho tới thời điểm hiện tại (thường dùng trạng từ ever)\r\n \r\n E.g.1: My last birthday was the worst day I’ve ever had. (Sinh nhật năm ngoái là ngày tệ nhất đời tôi.)\r\n \r\n E.g.2: Have you ever met George? Yes, but I’ve never met his wife. (Sử dụng never cho trường hợp tiêu cực)\r\n \r\n ➣Về một hành động trong quá khứ nhưng quan trọng tại thời điểm nói\r\n \r\n E.g.1: I can’t get my house. I’ve lost my keys. (Tôi không thể vào nhà được. Tôi đánh mất chùm chìa khóa của mình rồi.)\r\n \r\n E.g. 2: Teresa isn’t at home. I think she has gone shopping. (Teresa không có ở nhà. Tôi nghĩ cô ấy đã đi mua sắm.)\r\n \r\n Lưu ý đặc biệt: Trong một số trường hợp, ta sử dụng trạng thái quá khứ phân từ của động từ TOBE : BEEN như một dạng quá khứ phân từ của động từ GO.\r\n \r\n Trong các thì tiếng Anh, \"thì hiện tại hoàn thành\" và \"thì quá khứ đơn\" là 2 thì rất nhiều bạn dễ bị nhầm lẫn cách sử dụng. Chính vì vậy, các bạn lưu ý thật kỹ để sử dụng thì tiếng Anh thật hợp lý trong ngữ cảnh nhé!\r\n \r\n **IV. DẤU HIỆU NHẬN BIẾT**\r\n \r\n - just, recently, lately: gần đây, vừa mới\r\n \r\n  - already: rồi\r\n \r\n  - before: trước đây\r\n \r\n  - ever: đã từng\r\n \r\n - never: chưa từng, không bao giờ\r\n \r\n  - yet: chưa (dùng trong câu phủ định và câu hỏi)\r\n  \r\n - for + N – quãng thời gian: trong khoảng (for a year, for a long time, …) ví dụ: for 2 months: trong vòng 2 tháng\r\n \r\n  - since + N – mốc/điểm thời gian: từ khi (since 1992, since June, …)\r\n \r\n  - so far = until now = up to now = up to the present: cho đến bây giờ\r\n \r\n  - in/ for/ during/ over + the past/ last + thời gian: trong …. Qua ( Ví dụ: During the past 2 years: trong 2 năm qua)\r\n \r\n *** Vị trí của các trạng từ trong thì hiện tại hoàn thành:\r\n \r\n - already, never, ever, just: sau “have/ has” và đứng trước động từ phân từ II.\r\n \r\n - already: cũng có thể đứng cuối câu.\r\n \r\n E.g.: I have just come back home. (Tôi vừa mới về nhà.)\r\n \r\n - Yet: đứng cuối câu, và thường được sử dụng trong câu phủ định và nghi vấn.\r\n \r\n E.g.: She hasn’t told me about you yet. (Cô ấy vẫn chưa kể với tôi về bạn.)\r\n \r\n - so far, recently, lately, up to present, up to this moment, in/ for/ during/ over + the past/ last + thời gian: Có thể đứng đầu hoặc cuối câu.\r\n \r\n E.g.: I have seen this film recently. (Tôi xem bộ phim này gần đây.)\r\n \r\n **V. BÀI TẬP THÌ HIỆN TẠI HOÀN THÀNH**\r\n Sau khi học kiến thức ngữ pháp cơ bản về thì hiện tại hoàn thành các bạn nên làm bài tập dưới đây để củng cố vững chắc hơn, hiểu và biết cách áp dụng tốt nhất nhé!\r\n \r\n **Bài tập 1:  Đọc các tình huống, sử dụng các động từ dưới đây và viết lại câu với thì hiện tại hoàn thành:**\r\n \r\n arrive - break – fall - go - up - grow - improve – lose\r\n \r\n 1. Tom is looking for his key. He can't find it.  = Tom has lost his key.\r\n 			\r\n 2. Lisa can't walk and her leg is in plaster.\r\n Lisa .................... . .... ............................................ .\r\n \r\n 3. Last week the bus fare was £1 .80. Now it is £2.\r\n The bus fare ........................................ .............. ..\r\n \r\n 4. Maria's English wasn't very good. Now it is better.\r\n Her English .............................................................. .\r\n \r\n 5. Dan didn't have a beard before. Now he has a beard.\r\n Dan ..........................................................................\r\n \r\n 6. This morning I was expecting a letter. Now I have it.\r\n The letter .................................................................\r\n \r\n 7. The temperature was 20 degrees. Now it is only 12.\r\n The .................................................... ........................... ..\r\n \r\n **Bài tập 2: Chọn “Been” hoặc “Gone”**\r\n \r\n 1. James is on holiday. He's gone to Italy.\r\n \r\n 2. Hello! I've just ........... ... to the shops. I've bought lots of things.\r\n \r\n 3. A lice isn't here at the moment. She's ..... .......... ............................ to the shop to get a newspaper.\r\n \r\n 4. Tom has ..................................... out. He'll be back in about an hour.\r\n \r\n 5. 'Are you going to the bank?' - 'No, I've already ..... . ....................... ..... to the bank.'\r\n \r\n **Bài tập 3: Trả lời các câu hỏi dựa vào từ trong ngoặc**\r\n \r\n 1. Would you like something to eat?\r\n  No, thanks. ..... I have just had lunch... (I / just / have / lunch)\r\n \r\n 2. Do you know where Julia is?\r\n Yes, .................................. ................................................. .. ..... ............. . .. (I / just / see / her)\r\n \r\n 3. What time is David leaving?\r\n .....................................................................................................................(He / already / leave)\r\n \r\n 4. What's in the newspaper today?\r\n I don't know. .. ............................................................. .............................. (I / not / read / it / yet)\r\n \r\n 5. Is Sue com ing to the cinema with us?\r\n No, ....... .. ............................................................................. .... .. (She / already / see / the film)\r\n \r\n 6. Are your friends here yet?\r\n Yes, .. ................ ..........................................................................................  (they / just / arrive)\r\n \r\n 7. What does Tim think about your plan?\r\n ...........................................................................................................(we / not / tell / him / yet)\r\n \r\n **VI. ĐÁP ÁN**\r\n \r\n **Bài tập 1:**\r\n 2, Lisa has broken her leg.\r\n 3, The bus fare has gone up.\r\n 4, Her English has improved.\r\n 5, Dan has grown a beard.\r\n 6, The letter has arrived.\r\n 7, The temperature has fallen.\r\n \r\n **Bài tập 2:**\r\n \r\n 2, been\r\n \r\n 3, gone\r\n \r\n 4, gone\r\n \r\n 5, been\r\n \r\n **Bài tập 3:**\r\n \r\n 2. Yes, I've just seen her.\r\n Yes, I have just seen her.\r\n or Yes, I just saw her.\r\n \r\n 3. He's already left.\r\n He has already left.\r\n or He already left.\r\n \r\n 4. I haven't read it yet.\r\n or I didn't read it yet.\r\n \r\n 5. No, she's already seen the film.\r\n No, she has already seen.\r\n or No, she already saw.\r\n \r\n 6. Yes, they've just arrived.\r\n  Yes, they have just arrived.\r\n or Yes, they just arrived.\r\n \r\n 7. We haven't told him yet.\r\n or We didn't tell him yet." },
                    { 24, "Thì hiện tại hoàn thành (Present Perfect) 1 – Công thức, Cách dùng, Dấu hiệu nhận biết và Bài tập", "<p><strong>Thì hiện tại hoàn thành rất phổ biến trong giao tiếp hàng ngày cũng như trong các văn phong trao đổi công việc. Bạn đã biết gì về thì này rồi, cùng anh ngữ Ms Hoa tìm hiểu thêm bạn nhé</strong></p>", "24.thi_htht_anhngumshoa.jpg", "**Thì hiện tại hoàn thành rất phổ biến trong giao tiếp hàng ngày cũng như trong các văn phong trao đổi công việc. Bạn đã biết gì về thì này rồi, cùng anh ngữ Ms Hoa tìm hiểu thêm bạn nhé**" },
                    { 25, "Thì hiện tại hoàn thành (Present Perfect) 3 – Công thức, Cách dùng, Dấu hiệu nhận biết và Bài tập", "<p><strong>Thì hiện tại hoàn thành rất phổ biến trong giao tiếp hàng ngày cũng như trong các văn phong trao đổi công việc. Bạn đã biết gì về thì này rồi, cùng anh ngữ Ms Hoa tìm hiểu thêm bạn nhé</strong></p>", "25.thi_htht_anhngumshoa.jpg", "**Thì hiện tại hoàn thành rất phổ biến trong giao tiếp hàng ngày cũng như trong các văn phong trao đổi công việc. Bạn đã biết gì về thì này rồi, cùng anh ngữ Ms Hoa tìm hiểu thêm bạn nhé**" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "ImageT", "TestName" },
                values: new object[,]
                {
                    { 1, "1.mini-test.png", "Practice Mini Test 1 - Test  TOEIC Reading, Listening" },
                    { 2, "2.exam-test.jpeg", "Practice Mini Test 2 - Test  TOEIC Reading, Listening" },
                    { 3, "3.mini-test.png", "Practice Mini Test 3 - Test  TOEIC Reading, Listening" },
                    { 4, "4.exam-test.jpeg", "Practice Mini Test 4 - Test  TOEIC Reading, Listening" },
                    { 5, "5.exam-test.jpeg", "Practice Mini Test 5 - Test  TOEIC Reading, Listening" }
                });

            migrationBuilder.InsertData(
                table: "Vocabularies",
                columns: new[] { "Id", "ImageV", "VocabularyName" },
                values: new object[,]
                {
                    { 1, "1.business plan.jpg", "Lesson 1 - Business planning" },
                    { 2, "2.computerandtheinternet.jpg", "Lesson 2 - Computer and the internet" },
                    { 3, "3.Salaries-and-Benefits.jpg", "Lesson 3 - Salaries & Benefits" },
                    { 4, "4.summer.jpg", "Lesson 4- Summer" },
                    { 5, "5.summer.jpg", "Lesson 5- Summer" }
                });

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
                name: "IX_CommentListens_ListeningId",
                table: "CommentListens",
                column: "ListeningId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentListens_ParentCommentId",
                table: "CommentListens",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentListens_UserId",
                table: "CommentListens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReadings_ParentCommentId",
                table: "CommentReadings",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReadings_ReadingId",
                table: "CommentReadings",
                column: "ReadingId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReadings_UserId",
                table: "CommentReadings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GrammarId",
                table: "Comments",
                column: "GrammarId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentVocabularies_ParentCommentId",
                table: "CommentVocabularies",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentVocabularies_UserId",
                table: "CommentVocabularies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentVocabularies_VocabularyId",
                table: "CommentVocabularies",
                column: "VocabularyId");

            migrationBuilder.CreateIndex(
                name: "IX_ListeningQuestions_ListeningId",
                table: "ListeningQuestions",
                column: "ListeningId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingQuestions_ReadingId",
                table: "ReadingQuestions",
                column: "ReadingId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_TestId",
                table: "Results",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_UserId",
                table: "Results",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TestQuestions_TestId",
                table: "TestQuestions",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabularyContents_VocabularyContentId",
                table: "VocabularyContents",
                column: "VocabularyContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CommentListens");

            migrationBuilder.DropTable(
                name: "CommentReadings");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CommentVocabularies");

            migrationBuilder.DropTable(
                name: "ListeningQuestions");

            migrationBuilder.DropTable(
                name: "ReadingQuestions");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "SlideBanners");

            migrationBuilder.DropTable(
                name: "TestQuestions");

            migrationBuilder.DropTable(
                name: "VocabularyContents");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Grammars");

            migrationBuilder.DropTable(
                name: "Listenings");

            migrationBuilder.DropTable(
                name: "Readings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Vocabularies");
        }
    }
}
