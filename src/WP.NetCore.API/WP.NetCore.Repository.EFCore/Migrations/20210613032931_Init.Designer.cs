﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WP.NetCore.Repository.EFCore;

namespace WP.NetCore.Repository.EFCore.Migrations
{
    [DbContext(typeof(WPDbContext))]
    [Migration("20210613032931_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("ClassId")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.ArticleClass", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ClassName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("ArticleClass");

                    b.HasData(
                        new
                        {
                            Id = 15329967632090131L,
                            ClassName = ".NetCore",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(5488),
                            IsDelete = false
                        },
                        new
                        {
                            Id = 15329967632090132L,
                            ClassName = "Vue",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(5879),
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Component")
                        .HasColumnType("text");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<bool>("IsButton")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Component = "user/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(829),
                            Icon = "el-icon-lightning",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 0L,
                            Sort = 1,
                            Title = "用户管理"
                        },
                        new
                        {
                            Id = 15329967632090112L,
                            Component = "getUser",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(2240),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1L,
                            Sort = 0,
                            Title = "查看",
                            Url = "user/get"
                        },
                        new
                        {
                            Id = 15329967632090113L,
                            Component = "addUser",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3305),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1L,
                            Sort = 0,
                            Title = "新增",
                            Url = "user/post"
                        },
                        new
                        {
                            Id = 15329967632090114L,
                            Component = "editUser",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3316),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1L,
                            Sort = 0,
                            Title = "编辑",
                            Url = "user/put"
                        },
                        new
                        {
                            Id = 15329967632090115L,
                            Component = "deleteUser",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3321),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1L,
                            Sort = 0,
                            Title = "删除",
                            Url = "user/delete"
                        },
                        new
                        {
                            Id = 2L,
                            Component = "role/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3332),
                            Icon = "el-icon-heavy-rain",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 0L,
                            Sort = 2,
                            Title = "角色管理"
                        },
                        new
                        {
                            Id = 15329967632090116L,
                            Component = "getRole",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3334),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 2L,
                            Sort = 0,
                            Title = "查看",
                            Url = "role/get"
                        },
                        new
                        {
                            Id = 15329967632090117L,
                            Component = "addRole",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3337),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 2L,
                            Sort = 0,
                            Title = "新增",
                            Url = "role/post"
                        },
                        new
                        {
                            Id = 15329967632090118L,
                            Component = "editRole",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3340),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 2L,
                            Sort = 0,
                            Title = "编辑",
                            Url = "role/put"
                        },
                        new
                        {
                            Id = 15329967632090119L,
                            Component = "deleteRole",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3389),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 2L,
                            Sort = 0,
                            Title = "删除",
                            Url = "role/delete"
                        },
                        new
                        {
                            Id = 15329967632090120L,
                            Component = "setPermission",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3394),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 2L,
                            Sort = 0,
                            Title = "设置权限",
                            Url = "role/setPermission/post"
                        },
                        new
                        {
                            Id = 15329967632090121L,
                            Component = "getPermission",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3400),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 2L,
                            Sort = 0,
                            Title = "查看权限",
                            Url = "role/getPermission/get"
                        },
                        new
                        {
                            Id = 6L,
                            Component = "menu/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3403),
                            Icon = "el-icon-cloudy-and-sunny",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 0L,
                            Sort = 3,
                            Title = "菜单管理"
                        },
                        new
                        {
                            Id = 15329967632090122L,
                            Component = "getMenu",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3404),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 6L,
                            Sort = 0,
                            Title = "查看菜单树",
                            Url = "menu/getMenuTree/get"
                        },
                        new
                        {
                            Id = 15329967632090123L,
                            Component = "addMenu",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3407),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 6L,
                            Sort = 0,
                            Title = "新增",
                            Url = "menu/post"
                        },
                        new
                        {
                            Id = 15329967632090124L,
                            Component = "getMenu",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3410),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 6L,
                            Sort = 0,
                            Title = "查看所有",
                            Url = "menu/get"
                        },
                        new
                        {
                            Id = 15329967632090125L,
                            Component = "editMenu",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3413),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 6L,
                            Sort = 0,
                            Title = "编辑",
                            Url = "menu/put"
                        },
                        new
                        {
                            Id = 15329967632090126L,
                            Component = "deleteMenu",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3419),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 6L,
                            Sort = 0,
                            Title = "删除",
                            Url = "menu/delete"
                        },
                        new
                        {
                            Id = 7L,
                            Component = "article/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3422),
                            Icon = "el-icon-cloudy",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 0L,
                            Sort = 4,
                            Title = "文章列表"
                        },
                        new
                        {
                            Id = 15329967632090127L,
                            Component = "getArticle",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3424),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 7L,
                            Sort = 0,
                            Title = "查看",
                            Url = "article/get"
                        },
                        new
                        {
                            Id = 15329967632090128L,
                            Component = "addArticle",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3426),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 7L,
                            Sort = 0,
                            Title = "新增",
                            Url = "article/post"
                        },
                        new
                        {
                            Id = 15329967632090129L,
                            Component = "editArticle",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3429),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 7L,
                            Sort = 0,
                            Title = "编辑",
                            Url = "article/put"
                        },
                        new
                        {
                            Id = 15329967632090130L,
                            Component = "deleteArticle",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3432),
                            IsButton = true,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 7L,
                            Sort = 0,
                            Title = "删除",
                            Url = "article/delete"
                        },
                        new
                        {
                            Id = 8L,
                            Component = "serverlog/request",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3435),
                            Icon = "el-icon-moon",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 0L,
                            Sort = 5,
                            Title = "审计日志"
                        },
                        new
                        {
                            Id = 1001L,
                            Component = "nested",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3437),
                            Icon = "nested",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 0L,
                            Sort = 999,
                            Title = "多级"
                        },
                        new
                        {
                            Id = 1002L,
                            Component = "nested/menu1/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3438),
                            Icon = "lightning",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1001L,
                            Sort = 1,
                            Title = "子级11"
                        },
                        new
                        {
                            Id = 1003L,
                            Component = "nested/menu2/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3440),
                            Icon = "lightning",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1001L,
                            Sort = 2,
                            Title = "子级22"
                        },
                        new
                        {
                            Id = 1004L,
                            Component = "nested/menu1/menu1-2/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3442),
                            Icon = "lightning",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1002L,
                            Sort = 3,
                            Title = "子级22"
                        },
                        new
                        {
                            Id = 1005L,
                            Component = "nested/menu1/menu1-2/menu1-2-1/index",
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 752, DateTimeKind.Local).AddTicks(3443),
                            Icon = "lightning",
                            IsButton = false,
                            IsDelete = false,
                            IsHidden = false,
                            ParentId = 1004L,
                            Sort = 4,
                            Title = "子级22"
                        });
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.MenuRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("MenuRole");
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.RequestLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("Properties")
                        .HasColumnType("text");

                    b.Property<string>("Timestamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("_ts")
                        .HasColumnType("datetime");

                    b.HasKey("id");

                    b.ToTable("RequestLog");
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 999999999L,
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 751, DateTimeKind.Local).AddTicks(4434),
                            IsDelete = false,
                            RoleName = "系统管理员"
                        });
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 999999999L,
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 748, DateTimeKind.Local).AddTicks(9789),
                            IsDelete = false,
                            IsEnable = true,
                            Name = "系统管理员",
                            Password = "670b14728ad9902aecba32e22fa4f6bd",
                            Sex = 1,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CreateBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = 15329967632073728L,
                            CreateTime = new DateTime(2021, 6, 13, 11, 29, 30, 751, DateTimeKind.Local).AddTicks(5667),
                            IsDelete = false,
                            RoleId = 999999999L,
                            UserId = 999999999L
                        });
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.Article", b =>
                {
                    b.HasOne("WP.NetCore.Model.EntityModel.ArticleClass", "Class")
                        .WithMany("Articles")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.MenuRole", b =>
                {
                    b.HasOne("WP.NetCore.Model.EntityModel.Menu", "Menu")
                        .WithMany("UserRoles")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WP.NetCore.Model.EntityModel.Role", "Role")
                        .WithMany("MenuRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WP.NetCore.Model.EntityModel.UserRole", b =>
                {
                    b.HasOne("WP.NetCore.Model.EntityModel.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WP.NetCore.Model.EntityModel.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}