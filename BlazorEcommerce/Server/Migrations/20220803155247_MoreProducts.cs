using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class MoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Kill la Kill (Japanese: キルラキル, Hepburn: Kiru Ra Kiru)[a] is a Japanese anime television series produced by Trigger. The series follows vagrant schoolgirl Ryuko Matoi on her search for her father's killer which brings her into violent conflict with Satsuki Kiryuin, the iron-willed student council president of Honnouji Academy, and her mother Ragyo Kiryuin's fashion empire. Ryuko, Satsuki, and others obtain martial arts superpowers from their clothes, which appear to have a will of their own.The series is Trigger's first original anime television project, directed by Hiroyuki Imaishi and written by Kazuki Nakashima, both of whom had previously worked together on Gurren Lagann in 2007 and would go on to work on Promare in 2019. Kill la Kill was broadcast in Japan on MBS' Animeism programming block between October 2013 and March 2014.An original video animation(OVA) was released as a 25th episode in September 2014.A manga adaptation by Ryō Akizuki began serialization in Kadokawa Shoten's Young Ace magazine from October 2013 to March 2015. A video game adaptation, titled Kill la Kill the Game: IF, was released in July 2019, with slight deviations to the main storyline of the anime.In North America,Aniplex of America licensed the anime for a simulcast with a home video release starting in July 2014.The series premiered in the United States on Adult Swim's Toonami block in February 2015.", "https://upload.wikimedia.org/wikipedia/en/a/a9/Killlakillpromo.jpg", 4.99m, "Kill La Kill" },
                    { 5, 2, "Zombie Land Saga (Japanese: ゾンビランドサガ, Hepburn: Zonbi Rando Saga) is an anime television series produced by MAPPA, Avex Pictures and Cygames. The series aired in Japan between October and December 2018. A second season titled Zombie Land Saga Revenge aired between April and June 2021. An anime film project has been announced. A manga adaptation that loosely follows the events of the anime, began serialization on Cygames' Cycomi website in October 2018; a spinoff series, titled Zombie Land Saga Sidestory: The First Zombie, started running in Ultra Jump magazine in May 2021. In the year 2008, high school student Sakura Minamoto is abruptly killed by a truck on the morning she plans to submit an idol application. Ten years later, Sakura, along with six legendary girls from various eras of Japan's history, are brought back as zombies by a man named Kotaro Tatsumi, who seeks to revitalize Saga Prefecture by putting together an all-zombie idol group that would become known as Franchouchou.", "https://upload.wikimedia.org/wikipedia/en/c/cd/Zombie_Land_Saga_Visual_2.jpg", 3.99m, "Zombieland Saga" },
                    { 6, 2, "Cowboy Bebop (Japanese: カウボーイビバップ, Hepburn: Kaubōi Bibappu) is a Japanese neo-noir science fiction anime[12] television series created and animated by Sunrise, led by a production team of director Shinichirō Watanabe, screenwriter Keiko Nobumoto, character designer Toshihiro Kawamoto, mechanical designer Kimitoshi Yamane, and composer Yoko Kanno, who are collectively billed as Hajime Yatate. The series,which ran for twenty - six episodes(dubbed sessions), is set in the year 2071, and follows the lives of a traveling bounty - hunting crew aboard a spaceship, the Bebop.Although it incorporates a wide variety of genres, the series draws most heavily from science fiction, western, and noir films.Its most prominent themes are existential ennui, loneliness, and the inability to escape one's past. The series was dubbed into English by Animaze and ZRO Limit Productions, and was originally licensed in North America by Bandai Entertainment(and is now licensed by Crunchyroll) and in Britain by Beez Entertainment(now by Anime Limited); Madman Entertainment owns the license in Australia and New Zealand.In 2001, it became the first anime title to be broadcast on Adult Swim. Cowboy Bebop has been hailed as one of the greatest animated television series of all time.It was a critical and commercial success both in Japanese and international markets, most notably in the United States.It garnered several major anime and science - fiction awards upon its release, and received unanimous praise for its style, characters, story, voice acting, animation, and soundtrack.The English dub was particularly lauded, and is regarded as one of the best anime dubs.[13] Credited with helping to introduce anime to a new wave of Western viewers in the early 2000s, Cowboy Bebop has also been called a gateway series for anime in general.", "https://upload.wikimedia.org/wikipedia/en/a/a9/Cowboy_Bebop_key_visual.jpg", 2.99m, "Cowboy Bebop" },
                    { 7, 3, "Kiki's Delivery Service (Japanese: 魔女の宅急便, Hepburn: Majo no Takkyūbin, lit. 'Witch's Express Home Delivery') is a 1989 Japanese animated fantasy film written, produced, and directed by Hayao Miyazaki, adapted from the 1985 novel by Eiko Kadono. It was animated by Studio Ghibli for Tokuma Shoten, Yamato Transport and the Nippon Television Network and distributed by the Toei Company. It tells the story of Kiki, a young witch who moves to a new town and uses her flying ability to earn a living. According to Miyazaki, the movie portrays the gulf between independence and reliance in teenage Japanese girls.[1] Kiki's Delivery Service was released in Japan on July 29, 1989,[2] and won the Animage Anime Grand Prix prize.[3] It was the first film released under a 15-year distribution partnership between The Walt Disney Company and Studio Ghibli.[4] Walt Disney Pictures produced an English dub in 1997, which premiered in United States theaters at the Seattle International Film Festival[5] on May 23, 1998. It was released on home video in the U.S. and Canada on September 1, 1998.[6]", "https://upload.wikimedia.org/wikipedia/en/0/07/Kiki%27s_Delivery_Service_%28Movie%29.jpg", 49.99m, "Kiki's Delivery Service" },
                    { 8, 3, "Sing a Bit of Harmony (Japanese: アイの歌声を聴かせて, Hepburn: Ai no Utagoe o Kikasete, lit. Let Me Hear You Sing of Love) is a 2021 Japanese animated slice of life science fiction[1] film, produced by J.C.Staff and directed by Yasuhiro Yoshiura. It premiered in Japan in October 2021.", "https://upload.wikimedia.org/wikipedia/en/8/81/Sing_a_Bit_of_Harmony.png", 9.99m, "Sing a Bit of Harmony" },
                    { 9, 3, "Belle (竜とそばかすの姫, Ryū to Sobakasu no Hime, literally The Dragon and the Freckled Princess) is a 2021 Japanese animated science fantasy film written and directed by Mamoru Hosoda and produced by Studio Chizu. The story is inspired by the 1756 French fairy tale Beauty and the Beast by Jeanne-Marie Leprince de Beaumont, with Hosoda taking cues from the 1991 Disney animated movie.[2 The film received its world premiere on July 15 2021 at the 2021 Cannes Film Festival [3] where it was well - received by critics with a standing ovation that lasted fourteen minutes.[4] It was released theatrically in Japan on July 16 2021.GKIDS has licensed the film in North America with a nationwide release date of January 14 2022 [5] and previews in select IMAX theaters on January 12 [6] while Anime Limited released the film in the United Kingdom on February 4, 2022.[7][8] Belle is the third - highest - grossing Japanese film of 2021, accounting for ¥6.53 billion in box - office rakings as of December 12, 2021.[9][10]", "https://upload.wikimedia.org/wikipedia/en/5/5e/Belle_2021_Poster.jpg", 14.99m, "Belle_(2021_film)" },
                    { 10, 3, "Weathering with You (Japanese: 天気の子, Hepburn: Tenki no Ko, lit. Child of Weather) is a 2019 Japanese animated romantic fantasy film produced by CoMix Wave Films and released by Toho.It depicts a high school boy who runs away from his rural home to Tokyo and befriends an orphan girl who has the ability to control the weather. The film was commissioned in 2018 written and directed by Makoto Shinkai.It features the voices of Kotaro Daigo and Nana Mori with animation direction by Atsushi Tamura character design by Masayoshi Tanaka and its orchestral score and soundtrack composed by Radwimps; the latter two previously collaborated with Shinkai on Your Name(2016). A light novel of the same name, also written by Shinkai, was published a day prior the film's premiere, while a manga adaptation was serialized in Afternoon on July 25, 2019. Weathering with You was theatrically released in conventional, IMAX, and 4DX theaters in Japan on July 19, 2019, and was released in the United States on January 20, 2020. It received positive reviews, with praise for the animation, narrative, music, visuals, and emotional weight, although some reviewers were divided over perceived similarities to Your Name. The film grossed ¥21.11 billion (US$193.65 million) worldwide, becoming the highest grossing Japanese film of 2019, and the sixth highest-of ll time, unadjusted for inflation. The film won a number of awards, including being selected as the Japanese entry for Best International Feature Film at the 92nd Academy Awards. It received four Annie Award nominations, including for Best Independent Animated Feature, tying Spirited Away and Millennium Actress (both 2001) for the most nominations for an anime film at the Annies (until it was surpassed by Hosoda's Belle(2021), with five nominations).", "https://upload.wikimedia.org/wikipedia/en/6/66/Weathering_with_You_Poster.jpg", 19.99m, "Weathering with You" },
                    { 11, 3, "Mirai (Japanese: 未来のミライ, Hepburn: Mirai no Mirai, literally Mirai of the Future[13]) is a 2018 Japanese animated adventure fantasy comedy film written and directed by Mamoru Hosoda and produced by Studio Chizu.[3] It premiered on May 16, 2018 at Directors' Fortnight[1] and released in Japan on July 20, 2018.[14] The film stars the voices of Moka Kamishiraishi, Haru Kuroki, Gen Hoshino, Kumiko Aso, Mitsuo Yoshihara, Yoshiko Miyazaki, Koji Yakusho and Masaharu Fukuyama.[8][9][10 It was released on August 23 2018 in Australia [15] September 20 in New Zealand[16] and November 2 in the United Kingdom and Ireland.[17] It was released on November 29 in the United States and Canada.[18] The film was nominated for Best Animated Feature Film at the 76th Golden Globe Awards,[19] Best Animated Feature at the 24th Critics' Choice Awards[20] and Best Animated Feature at the 91st Academy Awards, losing all three to Spider-Man: Into the Spider-Verse;[21] it is the sixth anime film, and the first non-Ghibli anime film, to receive an Academy Award nomination in the category.[22] The film also won Best Animated Feature — Independent at the 46th Annie Awards.[23]", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 20.99m, "Mirai (film)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
