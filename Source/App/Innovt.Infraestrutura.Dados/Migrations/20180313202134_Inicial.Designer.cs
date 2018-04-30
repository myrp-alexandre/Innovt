﻿// <auto-generated />
using Innovt.Infraestrutura.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Innovt.Infraestrutura.Dados.Migrations
{
    [DbContext(typeof(ContextoBanco))]
    [Migration("20180313202134_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            #region Tabela de Historico de Versões
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            #endregion
            #region Tabela de Mapas
            modelBuilder.Entity("Innovt.Dominio.Entidades.Mapa", b =>
                {
                    b.Property<int>("MapaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Longetude")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("MapaId")
                        .HasName("PK_Mapas_MapaId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("MapaId")
                        .IsUnique()
                        .HasName("IX_Mapas_MapaId");

                    b.ToTable("Mapas");
                });
            #endregion
            #region Tabela de Noticias
            modelBuilder.Entity("Innovt.Dominio.Entidades.Noticia", b =>
                {
                    b.Property<int>("NoticiaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ChamadaSocial")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Autor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Anônimo")
                        .HasMaxLength(50);

                    b.Property<string>("TextoMateria")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<byte[]>("Imagem")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<int>("MapaId");

                    b.HasKey("NoticiaId")
                        .HasName("PK_Noticias_NoticiaId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("MapaId");

                    b.HasIndex("NoticiaId")
                        .IsUnique()
                        .HasName("IX_Noticias_NoticiaId");

                    b.ToTable("Noticias");
                });
            //Relacionamento (criação de chave estrangeira)
            modelBuilder.Entity("Innovt.Dominio.Entidades.Noticia", b =>
                {
                    b.HasOne("Innovt.Dominio.Entidades.Mapa", "Mapa")
                        .WithMany("Noticias")
                        .HasForeignKey("MapaId")
                        .HasConstraintName("FK_Noticias_Mapas_MapaId");
                });
            #endregion
#pragma warning restore 612, 618
        }
    }
}
