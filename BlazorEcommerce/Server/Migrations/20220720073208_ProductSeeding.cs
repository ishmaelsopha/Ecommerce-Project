using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Call of the Night (Japanese: よふかしのうた, Hepburn: Yofukashi no Uta) is a Japanese manga series written and illustrated by Kotoyama. It has been serialized in Shogakukan's Weekly Shōnen Sunday since August 2019. In North America, the manga is licensed for English release by Viz Media. An anime television series adaptation by Liden Films premiered in July 2022 on Fuji TV's Noitamina programming block.", "https://upload.wikimedia.org/wikipedia/en/0/06/YofukashiNoUta.jpg", 9.99m, "Call of the Night" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "How Heavy Are the Dumbbells You Lift? (Japanese: ダンベル何キロ持てる？, Hepburn: Danberu Nan-Kiro Moteru?, lit. How Many Kilograms of Dumbbell Can You Lift?) is a Japanese manga series written by Yabako Sandrovich and illustrated by MAAM. It has been serialized via Shogakukan's Ura Sunday website and MangaONE app since August 2016 and has been collected into sixteen tankōbon volumes as of July 2022. The manga is licensed in North America by Seven Seas Entertainment. A twelve-episode anime television series adaptation by Doga Kobo aired from July to September 2019.", "https://upload.wikimedia.org/wikipedia/en/d/d1/Dumbbell_Nan-Kilo_Moteru%3F_volume_1_cover.jpg", 7.99m, "How Heavy Are the Dumbbells You Lift?" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Violet Evergarden (Japanese: ヴァイオレット・エヴァーガーデン, Hepburn: Vaioretto Evāgāden) is a Japanese light novel series written by Kana Akatsuki and illustrated by Akiko Takase. It won the grand prize in the fifth Kyoto Animation Award's novel category in 2014, the first ever work to win a grand prize in any of the three categories (novel, scenario, and manga).[3] Kyoto Animation published the first light novel in December 2015, under their KA Esuma Bunko imprint.[4]A 13-episode anime television series adaptation by Kyoto Animation aired between January and April 2018 with several advance screenings taking place in 2017. The series was awarded Best Animation at the 2019 Crunchyroll Anime Awards.[5] An original video animation episode was released in July 2018, and a spin-off film premiered in Japan in September 2019. A second anime film, Violet Evergarden: The Movie, premiered in September 2020.", "https://upload.wikimedia.org/wikipedia/en/b/be/Violet_Evergarden_light_novel_volume_1_cover.jpg", 6.99m, "Violet Evergarden" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
