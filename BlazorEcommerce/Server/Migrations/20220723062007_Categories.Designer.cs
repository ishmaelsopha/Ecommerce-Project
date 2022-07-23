﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220723062007_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Anime Originals",
                            Url = "Anime Originals"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Movies",
                            Url = "Movies"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Call of the Night (Japanese: よふかしのうた, Hepburn: Yofukashi no Uta) is a Japanese manga series written and illustrated by Kotoyama. It has been serialized in Shogakukan's Weekly Shōnen Sunday since August 2019. In North America, the manga is licensed for English release by Viz Media. An anime television series adaptation by Liden Films premiered in July 2022 on Fuji TV's Noitamina programming block.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/06/YofukashiNoUta.jpg",
                            Price = 9.99m,
                            Title = "Call of the Night"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "How Heavy Are the Dumbbells You Lift? (Japanese: ダンベル何キロ持てる？, Hepburn: Danberu Nan-Kiro Moteru?, lit. How Many Kilograms of Dumbbell Can You Lift?) is a Japanese manga series written by Yabako Sandrovich and illustrated by MAAM. It has been serialized via Shogakukan's Ura Sunday website and MangaONE app since August 2016 and has been collected into sixteen tankōbon volumes as of July 2022. The manga is licensed in North America by Seven Seas Entertainment. A twelve-episode anime television series adaptation by Doga Kobo aired from July to September 2019.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d1/Dumbbell_Nan-Kilo_Moteru%3F_volume_1_cover.jpg",
                            Price = 7.99m,
                            Title = "How Heavy Are the Dumbbells You Lift?"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Violet Evergarden (Japanese: ヴァイオレット・エヴァーガーデン, Hepburn: Vaioretto Evāgāden) is a Japanese light novel series written by Kana Akatsuki and illustrated by Akiko Takase. It won the grand prize in the fifth Kyoto Animation Award's novel category in 2014, the first ever work to win a grand prize in any of the three categories (novel, scenario, and manga).[3] Kyoto Animation published the first light novel in December 2015, under their KA Esuma Bunko imprint.[4]A 13-episode anime television series adaptation by Kyoto Animation aired between January and April 2018 with several advance screenings taking place in 2017. The series was awarded Best Animation at the 2019 Crunchyroll Anime Awards.[5] An original video animation episode was released in July 2018, and a spin-off film premiered in Japan in September 2019. A second anime film, Violet Evergarden: The Movie, premiered in September 2020.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/be/Violet_Evergarden_light_novel_volume_1_cover.jpg",
                            Price = 6.99m,
                            Title = "Violet Evergarden"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
