﻿// <auto-generated />
using System;
using api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210217191800_CorrecaoDeOperador")]
    partial class CorrecaoDeOperador
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Models.Entities.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CheckListInicial")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaComTanqueCheio")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaLimpo")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaSemAmassados")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaSemArranhoes")
                        .HasColumnType("bit");

                    b.Property<int>("LocacaoVeiculoId")
                        .HasColumnType("int");

                    b.Property<int>("OperadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoVeiculoId");

                    b.HasIndex("OperadorId");

                    b.ToTable("CheckLists");
                });

            modelBuilder.Entity("api.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DiaDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("TipoDeUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "063.923.720-75",
                            DiaDeNascimento = new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Fulano da Silva Cliente",
                            TipoDeUsuario = 1
                        });
                });

            modelBuilder.Entity("api.Models.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("api.Models.Entities.LocacaoVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalHoras")
                        .HasColumnType("int");

                    b.Property<double>("ValorLocacao")
                        .HasColumnType("float");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("LocacaoVeiculos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            DataDevolucao = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataLocacao = new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TotalHoras = 48,
                            ValorLocacao = 91.900000000000006,
                            VeiculoId = 1
                        });
                });

            modelBuilder.Entity("api.Models.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fiat"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wolkswagen"
                        });
                });

            modelBuilder.Entity("api.Models.Entities.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MarcaId = 1,
                            Name = "Uno"
                        },
                        new
                        {
                            Id = 2,
                            MarcaId = 1,
                            Name = "Palio Attractive"
                        },
                        new
                        {
                            Id = 3,
                            MarcaId = 1,
                            Name = "Argo"
                        },
                        new
                        {
                            Id = 4,
                            MarcaId = 1,
                            Name = "Novo Fiat Strada"
                        },
                        new
                        {
                            Id = 5,
                            MarcaId = 2,
                            Name = "Gol - Gen 5"
                        },
                        new
                        {
                            Id = 6,
                            MarcaId = 2,
                            Name = "Up"
                        },
                        new
                        {
                            Id = 7,
                            MarcaId = 2,
                            Name = "Voyage"
                        },
                        new
                        {
                            Id = 8,
                            MarcaId = 2,
                            Name = "Jetta"
                        });
                });

            modelBuilder.Entity("api.Models.Entities.Operador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiaDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("TipoDeUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Operadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiaDeNascimento = new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = "123456",
                            Nome = "Beltrano da Silva Operador",
                            TipoDeUsuario = 0
                        });
                });

            modelBuilder.Entity("api.Models.Entities.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Ano")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstaLocado")
                        .HasColumnType("bit");

                    b.Property<int>("Kilometragem")
                        .HasColumnType("int");

                    b.Property<int>("LimitePortaMalas")
                        .HasColumnType("int");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDeCombustivel")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeVeiculo")
                        .HasColumnType("int");

                    b.Property<double>("ValorHora")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ModeloId");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstaLocado = false,
                            Kilometragem = 0,
                            LimitePortaMalas = 0,
                            ModeloId = 7,
                            Placa = "XXX-0909",
                            TipoDeCombustivel = 0,
                            TipoDeVeiculo = 0,
                            ValorHora = 45.950000000000003
                        });
                });

            modelBuilder.Entity("api.Models.Entities.CheckList", b =>
                {
                    b.HasOne("api.Models.Entities.LocacaoVeiculo", "LocacaoVeiculo")
                        .WithMany()
                        .HasForeignKey("LocacaoVeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Entities.Operador", "Operador")
                        .WithMany()
                        .HasForeignKey("OperadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocacaoVeiculo");

                    b.Navigation("Operador");
                });

            modelBuilder.Entity("api.Models.Entities.Cliente", b =>
                {
                    b.HasOne("api.Models.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("api.Models.Entities.LocacaoVeiculo", b =>
                {
                    b.HasOne("api.Models.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Entities.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("api.Models.Entities.Modelo", b =>
                {
                    b.HasOne("api.Models.Entities.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("api.Models.Entities.Operador", b =>
                {
                    b.HasOne("api.Models.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("api.Models.Entities.Veiculo", b =>
                {
                    b.HasOne("api.Models.Entities.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("api.Models.Entities.Marca", b =>
                {
                    b.Navigation("Modelos");
                });
#pragma warning restore 612, 618
        }
    }
}
