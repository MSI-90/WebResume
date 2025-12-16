using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class LanguageCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    name_ru = table.Column<string>(type: "text", nullable: false),
                    iso_code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "language_infos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: true),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language_infos", x => x.id);
                    table.ForeignKey(
                        name: "FK_language_infos_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "languages",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_language_infos_resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "resume",
                        principalColumn: "resume_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "id", "iso_code", "name", "name_ru" },
                values: new object[,]
                {
                    { new Guid("024a094c-363e-439c-880f-329bc25dcfaf"), "da", "Danish", "Датский" },
                    { new Guid("026954b5-3c12-438e-98ee-5d61a762fcfe"), "gu", "Gujarati", "Гуджарати" },
                    { new Guid("03943555-154d-4454-b854-4b1adb70d48c"), "ay", "Aymara", "Аймара" },
                    { new Guid("03961572-2e22-4c9b-bb0d-12dcdcdcb19f"), "hy", "Armenian", "Армянский" },
                    { new Guid("055703df-d05d-4903-8e43-4d15fb614c65"), "ko", "Korean", "Корейский" },
                    { new Guid("066a5556-edc6-4f9e-a8d4-5aee30ab7d64"), "ce", "Chechen", "Чеченский" },
                    { new Guid("06be568a-18fa-4325-967a-71624babf6cb"), "na", "Nauru", "Науру" },
                    { new Guid("089fbc43-ef94-4970-b6c4-64c951d635c9"), "km", "Khmer", "Кхмерский" },
                    { new Guid("092aca30-21c1-46c6-9464-673af9935b47"), "nl", "Dutch", "Нидерландский" },
                    { new Guid("097dcc8a-a3c1-4620-9e2e-433cd0a845c1"), "te", "Telugu", "Телугу" },
                    { new Guid("09a8aa36-c178-401d-8fa3-4c26f676abbf"), "ie", "Interlingue", "Окциденталь" },
                    { new Guid("0c958ae4-a650-4ab7-99ff-bb2f2792b0bd"), "nr", "Southern Ndebele", "Южный ндебеле" },
                    { new Guid("0c95b1cf-c71d-43fa-b7e3-446e14829fca"), "as", "Assamese", "Ассамский" },
                    { new Guid("10a1081b-6c2d-4533-8d4a-8e9228feae0a"), "jv", "Javanese", "Яванский" },
                    { new Guid("1164f268-4599-4787-a9d5-e59196277a38"), "fo", "Faroese", "Фарерский" },
                    { new Guid("12a50bff-8d3f-41ed-a76a-0518cee1d6b1"), "ks", "Kashmiri", "Кашмирский" },
                    { new Guid("12bb47c7-13f5-4ca0-89da-7e883a247fa5"), "vo", "Volapük", "Волапюк" },
                    { new Guid("15695d88-6ff7-4fa7-b80d-ca5278347915"), "th", "Thai", "Тайский" },
                    { new Guid("15b5a718-439f-480f-8a1f-74f7c879c147"), "bo", "Tibetan", "Тибетский" },
                    { new Guid("196d7da1-d923-465d-8498-c03f12926696"), "kl", "Greenlandic", "Гренландский" },
                    { new Guid("1b0456a7-ca44-4d1d-95af-3a8e7e463c13"), "kg", "Kongo", "Конго" },
                    { new Guid("1bb0f312-4ea7-40a7-a004-6fd7fe10bfaf"), "ki", "Kikuyu", "Кикуйю" },
                    { new Guid("1d230e99-ef44-4fd4-882f-e2ec2cb53f00"), "pt", "Portuguese", "Португальский" },
                    { new Guid("1d3dd7c7-a87d-413b-b889-e173a64041c4"), "fa", "Persian (Farsi)", "Персидский" },
                    { new Guid("1e5677d4-ecd0-4bbf-a78a-849a61c070b1"), "uk", "Ukrainian", "Украинский" },
                    { new Guid("1f63bb8b-a3ac-45fe-8de7-4ec053263426"), "st", "Sesotho", "Сесото" },
                    { new Guid("1f67ba14-2d26-4df4-b808-1a677525d678"), "bh", "Bihari", "Бихарский" },
                    { new Guid("1fc8d54a-ace7-489b-baf8-3dd869667c31"), "oc", "Occitan", "Окситанский" },
                    { new Guid("20ac2a3d-5d6a-40b5-91e7-24321bacc815"), "tt", "Tatar", "Татарский" },
                    { new Guid("212cedca-4fb4-4d91-a284-7169759b2fd7"), "ha", "Hausa", "Хауса" },
                    { new Guid("2329a844-86c1-4654-80dc-f9c6426e6ab3"), "lu", "Luga-Katanga", "Луба-Катанга" },
                    { new Guid("23754cb3-216d-4be6-87c8-863a8b836168"), "xh", "Xhosa", "Коса" },
                    { new Guid("26d16d6a-fd1a-4965-b723-d4d6a986373b"), "ja", "Japanese", "Японский" },
                    { new Guid("2879b010-c2ed-43fa-99d1-82b25d364e55"), "bs", "Bosnian", "Боснийский" },
                    { new Guid("2a1a9db7-d8d5-4592-b2be-d7c24d56d584"), "mh", "Marshallese", "Маршалльский" },
                    { new Guid("2ba638fb-85ac-4333-a411-3397f8cd68e0"), "kr", "Kanuri", "Канури" },
                    { new Guid("2c5e17da-bcfc-4f35-8e61-ac2ca503818a"), "ve", "Venda", "Венда" },
                    { new Guid("2c8725ff-77a8-450e-b139-f5af9ea33969"), "sl", "Slovenian", "Словенский" },
                    { new Guid("2c930131-6512-4a98-850c-d2b97384d2bc"), "hz", "Herero", "Гереро" },
                    { new Guid("2ed613b0-2619-4a71-bc10-ccd5dc1f667a"), "fr", "French", "Французский" },
                    { new Guid("2f02cc71-9509-4809-8df4-82da89052839"), "lv", "Latvian (Lettish)", "Латышский" },
                    { new Guid("2f2270e6-5f8c-4a37-a049-091b89d470bd"), "zh", "Chinese", "Китайский" },
                    { new Guid("2fb64081-e7ba-45c2-82e8-281a25047c8a"), "de", "German", "Немецкий" },
                    { new Guid("3038b47e-b4c7-4d58-a08a-d0365ce299fc"), "sr", "Serbian", "Сербский" },
                    { new Guid("312e5c74-2856-4c64-81f7-2fafa0cc608b"), "lo", "Lao", "Лаосский" },
                    { new Guid("322523cb-2065-4eec-9183-e8e42100e15b"), "es", "Spanish", "Испанский" },
                    { new Guid("33d18629-bd9e-4fa0-9117-9b4d00e129cc"), "ho", "Hiri Motu", "Хири-моту" },
                    { new Guid("347f0f68-cde9-4c30-80ec-c9f280a5d160"), "ii", "Sichuan Yi", "Сычуаньский и" },
                    { new Guid("36bee731-0ec6-4f2d-bb57-2bddea051e29"), "ml", "Malayalam", "Малаялам" },
                    { new Guid("3d87dead-a9f2-45d7-bea6-fc65db68645b"), "lt", "Lithuanian", "Литовский" },
                    { new Guid("4026d47e-296e-4d98-b37a-fa6faf20f6e4"), "rw", "Kinyarwanda (Rwanda)", "Киньяруанда" },
                    { new Guid("40887e05-6b48-4833-bb76-6b5664389673"), "pl", "Polish", "Польский" },
                    { new Guid("42c27504-d5e2-4d10-b60c-ceea92446cdd"), "av", "Avaric", "Аварский" },
                    { new Guid("4384a864-475f-4dec-8dc2-51ba9d8fb171"), "sw", "Swahili (Kiswahili)", "Суахили" },
                    { new Guid("443791d2-b84f-4ee9-a9b7-e98f6b0041ea"), "bm", "Bambara", "Бамбарский" },
                    { new Guid("4e9c16ba-6d37-4f8b-9feb-5b9f93b87b0a"), "ab", "Abkhazian", "Абхазский" },
                    { new Guid("4f4ca030-9b4c-4ce0-b4e1-73fabad7ab72"), "tk", "Turkmen", "Туркменский" },
                    { new Guid("4f611509-7322-41e2-940b-1adbdee6b012"), "su", "Sundanese", "Сунданский" },
                    { new Guid("50c437d3-7c24-4153-a4c2-514af5935dd0"), "ch", "Chamorro", "Чаморро" },
                    { new Guid("567c033c-29e0-4630-a888-d65941c1f9d5"), "hr", "Croatian", "Хорватский" },
                    { new Guid("568cbe6b-ffba-4518-b99b-5ddab564b2ff"), "fy", "Western Frisian", "Западно-фризский" },
                    { new Guid("580ff8d2-cb0a-4097-9805-804903c89039"), "et", "Estonian", "Эстонский" },
                    { new Guid("593788e6-8681-481d-a4f2-40192a7a959b"), "ku", "Kurdish", "Курдский" },
                    { new Guid("5d9f11f2-a1c5-4dab-97e0-1c109863535c"), "ga", "Irish", "Ирландский" },
                    { new Guid("5f78d649-5654-4e71-81e4-e8e739678b19"), "vi", "Vietnamese", "Вьетнамский" },
                    { new Guid("5f905a2e-db37-4ca3-a747-4da897ef656c"), "nn", "Norwegian nynorsk", "Норвежский (нюнорск)" },
                    { new Guid("6149f479-f737-42b1-9da8-86fea65f0699"), "sg", "Sango", "Санго" },
                    { new Guid("6178a390-ed44-478c-b4a9-49fc5545a6cb"), "he", "Hebrew", "Иврит" },
                    { new Guid("61e881ea-d119-46a7-8fb2-f385d40e51a3"), "tl", "Tagalog", "Тагальский" },
                    { new Guid("6c1a9e09-65dc-4343-8273-83266bcb64d9"), "ta", "Tamil", "Тамильский" },
                    { new Guid("6cc07f71-6a1e-42c9-90e7-8206b7b0a316"), "kn", "Kannada", "Каннада" },
                    { new Guid("6d013d3a-a593-459a-a9c8-44e1f169b53d"), "iu", "Inuktitut", "Инуктитут" },
                    { new Guid("6f2d72ca-94c3-406a-bc2d-414b2294775f"), "rn", "Kirundi", "Кирунди" },
                    { new Guid("70030cc2-49e5-4b0b-afe3-3d7a6fd69e4e"), "el", "Greek", "Греческий" },
                    { new Guid("701793e9-5482-4b06-9ef5-2aa3bad203da"), "la", "Latin", "Латинский" },
                    { new Guid("706ce507-b9e6-4a5d-b105-19920666b1fc"), "ar", "Arabic", "Арабский" },
                    { new Guid("70f40eaa-1358-48c5-ad5c-dd34d7d958f7"), "to", "Tonga", "Тонганский" },
                    { new Guid("7392f1f7-a343-4b35-be4d-0885b060581e"), "tn", "Setswana", "Сетсвана" },
                    { new Guid("7401946a-252e-40c4-9002-d28ce6eccbfe"), "ss", "Swati", "Свати" },
                    { new Guid("755a5bd2-d70d-4861-96c9-545613e1ce25"), "sm", "Samoan", "Самоанский" },
                    { new Guid("77b2a79d-c02c-40bf-9b24-9db54c826197"), "pa", "Punjabi (Eastern)", "Пенджаби" },
                    { new Guid("79090b14-2647-4310-8e25-f02c776cc0e8"), "pi", "Pāli", "Пали" },
                    { new Guid("79e8dc49-f3dd-4fbd-8e9f-2440fc90137e"), "dz", "Dzongkha", "Дзонг-кэ" },
                    { new Guid("79ef3212-1bda-4635-8dc0-edfe25163326"), "hu", "Hungarian", "Венгерский" },
                    { new Guid("7a4cb38b-0db9-4385-8bad-e551e4c66842"), "ee", "Ewe", "Эве" },
                    { new Guid("7b141879-6eed-4825-afe9-c521e0a78678"), "bg", "Bulgarian", "Болгарский" },
                    { new Guid("7cc9533b-b72c-438f-b203-cdeb3d1cb6a7"), "mr", "Marathi", "Маратхи" },
                    { new Guid("7d88414b-c653-4432-8c81-d32f6c92a62d"), "or", "Oriya", "Ория" },
                    { new Guid("7e1e8335-3257-4f4e-b52f-cabb7dbbede8"), "kj", "Kwanyama", "Кваньяма" },
                    { new Guid("7e44175f-50e5-49e5-b0d1-05560fc0df47"), "ky", "Kyrgyz", "Киргизский" },
                    { new Guid("7e9ab5a4-8e6f-42c6-acfa-e8a987703ce3"), "sa", "Sanskrit", "Санскрит" },
                    { new Guid("8114d8dc-6655-4f32-85a3-39dee4b09a8d"), "ne", "Nepali", "Непальский" },
                    { new Guid("813f8f10-374a-4533-9e19-37dd8061b953"), "ia", "Interlingua", "Интерлингва" },
                    { new Guid("817605c5-0434-461e-96a4-ffb459737fe7"), "ka", "Georgian", "Грузинский" },
                    { new Guid("83a23e16-ccf6-4e98-bb32-08be53086838"), "om", "Oromo (Afaan Oromo)", "Оромо" },
                    { new Guid("85becf6f-d11d-45c8-a561-94e2b594de9e"), "cy", "Welsh", "Уэльский" },
                    { new Guid("8bd04ba7-6f93-44b0-b626-5d1882972db3"), "sn", "Shona", "Шона" },
                    { new Guid("909468d1-831b-4803-92bc-f81f18f1f867"), "so", "Somali", "Сомалийский" },
                    { new Guid("9196fa63-3faf-476b-9023-24bb70e3d6df"), "sd", "Sindhi", "Синдхи" },
                    { new Guid("91a90c20-4e23-4508-abee-e8a69d8ce624"), "io", "Ido", "Идо" },
                    { new Guid("93fe3935-aeeb-42f3-99a8-7ddf7e6bb0cf"), "br", "Breton", "Бретонский" },
                    { new Guid("954c155a-2ab3-48d7-a14a-1506cf9650ae"), "yo", "Yoruba", "Йоруба" },
                    { new Guid("97603b87-5c22-4b06-8471-d39c3ce8f655"), "yi", "Yiddish", "Идиш" },
                    { new Guid("97b7fff9-a29d-4c61-9907-f29594b28a66"), "mi", "Maori", "Маори" },
                    { new Guid("980ab335-9d80-4b23-acbd-352aa3d27e33"), "az", "Azerbaijani", "Азербайджанский" },
                    { new Guid("998072d0-d171-4b28-bd7a-b0c803b9b074"), "fi", "Finnish", "Финский" },
                    { new Guid("9bf2e5db-968b-447d-8c9d-1cc031f412fa"), "ff", "Fula, Fulah, Pulaar, Pular", "Фула" },
                    { new Guid("9c64824e-7878-4934-8312-97d8236698d2"), "tw", "Twi", "Тви" },
                    { new Guid("9dca974d-4598-4324-8945-402da024da1b"), "cr", "Cree", "Кри" },
                    { new Guid("9f919b0c-7db8-4858-94da-7fb71717653f"), "eu", "Basque", "Баскский" },
                    { new Guid("a077db96-f14f-4b26-8c3a-5fe42f44a9c0"), "dv", "Divehi, Dhivehi, Maldivian", "Мальдивский" },
                    { new Guid("a22c5ffd-56c5-436f-96bb-bda34f5defd4"), "tr", "Turkish", "Турецкий" },
                    { new Guid("a380a29d-a231-4670-9341-fd8859c4b9a6"), "ca", "Catalan", "Каталанский" },
                    { new Guid("a49abea4-5958-43ca-af9f-f1db1902806f"), "rm", "Romansh", "Ретороманский" },
                    { new Guid("a4f264b1-c9f3-4e4b-a8d0-4fa8ade8a777"), "gl", "Galician", "Галисийский" },
                    { new Guid("a506e1f7-f66d-4d03-ab25-9f36545f1e8d"), "lb", "Luxembourgish", "Люксембургский" },
                    { new Guid("a703dc68-8df3-4776-b179-4e6336d4d049"), "kl", "Kalaallisut, Greenlandic", "Калаалисут" },
                    { new Guid("a88a3a3f-8402-43cb-9a6c-dbf5003751a9"), "ii", "Nuosu", "Нуосу" },
                    { new Guid("a8f60b8a-59b0-474b-a39f-1dfae13ed3eb"), "ur", "Urdu", "Урду" },
                    { new Guid("aae88611-3354-4a13-8b1f-744433532fb0"), "kv", "Komi", "Коми" },
                    { new Guid("ac58dcdb-cdcf-47e3-8012-de7f116db4e7"), "mt", "Maltese", "Мальтийский" },
                    { new Guid("ad98798e-23ba-4e78-a7a9-8d3c64d43974"), "no", "Norwegian", "Норвежский" },
                    { new Guid("ae7e7e7e-96f1-49a8-8185-62674035fea7"), "ig", "Igbo", "Игбо" },
                    { new Guid("b053bced-0ea9-40b2-be5b-974594e45f0d"), "co", "Corsican", "Корсиканский" },
                    { new Guid("b06995be-e74b-430f-bf10-f72dc6d8ec7d"), "si", "Sinhalese", "Сингальский" },
                    { new Guid("b08c00d5-e47b-46e1-93b7-52b8440eb521"), "ug", "Uyghur", "Уйгурский" },
                    { new Guid("b143005f-3c0e-4f75-a277-aa2b9cd60d0e"), "zh-Hant", "Chinese (Traditional)", "Китайский (традиционный)" },
                    { new Guid("b49cc277-25ac-4de7-abeb-f46049e5ec40"), "it", "Italian", "Итальянский" },
                    { new Guid("b5bc2073-f922-45f7-874e-918a39570c16"), "li", "Limburgish (Limberger)", "Лимбургский" },
                    { new Guid("b5bdd47c-7087-4c7b-b0dd-5aea28898697"), "hi", "Hindi", "Хинди" },
                    { new Guid("b6a8a6a2-e5ee-428d-8bdd-f41acc9b291c"), "gv", "Gaelic (Manx)", "Мэнский" },
                    { new Guid("b6fb8f5d-b41e-42a3-8972-acd23c681474"), "ht", "Haitian Creole", "Гаитянский креольский" },
                    { new Guid("b80b9963-bc44-474f-afcc-778d22556861"), "nd", "Northern Ndebele", "Северный ндебеле" },
                    { new Guid("b8122741-327f-460b-b35a-661baccfa430"), "zu", "Zulu", "Зулусский" },
                    { new Guid("b82b82e6-6317-48d0-a272-8d2db51cc444"), "tg", "Tajik", "Таджикский" },
                    { new Guid("b865e425-c5f3-4604-b2b3-6c92112b4f94"), "ln", "Lingala", "Лингала" },
                    { new Guid("bb4c72b3-aeed-43fb-899c-16b126d165b3"), "ss", "Siswati", "Сисвати" },
                    { new Guid("bc4bf932-3455-43c0-9da1-267282076972"), "cu", "Old Church Slavonic, Old Bulgarian", "Церковнославянский" },
                    { new Guid("bc752489-5784-4514-a174-900fd26625e1"), "wo", "Wolof", "Волоф" },
                    { new Guid("c04d5c3a-7e0d-4bcf-892f-839f75ade7e6"), "wa", "Wallon", "Валлонский" },
                    { new Guid("c0557b53-a343-4e5f-9b9f-9169bf0f7eef"), "eo", "Esperanto", "Эсперанто" },
                    { new Guid("c09b97a3-2fe9-4502-a214-0425118e3b1d"), "am", "Amharic", "Амхарский" },
                    { new Guid("c11fdc93-417a-4d60-be70-eefa7a585791"), "my", "Burmese", "Бирманский" },
                    { new Guid("c4aad18e-2c3c-4d2a-88e7-d8d916977b7d"), "gn", "Guarani", "Гуарани" },
                    { new Guid("c4cd418f-9f89-401b-bc44-77b8c88599d8"), "id", "Indonesian", "Индонезийский" },
                    { new Guid("c62d51fc-1b03-4190-ab63-07ab8fdf979e"), "ak", "Akan", "Акан" },
                    { new Guid("c6a3d4b1-c4d1-4b59-b018-0b3ee4e52ecc"), "aa", "Afar", "Афарский" },
                    { new Guid("c751fbda-e685-446f-a832-960c9adec396"), "sq", "Albanian", "Албанский" },
                    { new Guid("c796bbf1-7267-4886-9a95-ff130c3bbdf1"), "kw", "Cornish", "Корнский" },
                    { new Guid("c93f43a3-2137-42e8-8cf9-8d8814183071"), "sk", "Slovak", "Словацкий" },
                    { new Guid("ca02d271-b222-4424-9254-8db4e0dbc960"), "kk", "Kazakh", "Казахский" },
                    { new Guid("ca26e8c6-bc90-4e60-9193-cb50b11ab1a3"), "mg", "Malagasy", "Малагасийский" },
                    { new Guid("cd50b2c6-081c-4466-b236-1429302f3721"), "ms", "Malay", "Малайский" },
                    { new Guid("d0c8a71a-b8c3-49d8-b8ff-b4e76591c640"), "cs", "Czech", "Чешский" },
                    { new Guid("d11805b7-e937-4cba-be65-6ef10fb51dc4"), "mk", "Macedonian", "Македонский" },
                    { new Guid("d11ce7ab-7ef7-4a6f-8fdb-4ece85df129f"), "ba", "Bashkir", "Башкирский" },
                    { new Guid("d151b24f-1019-4c0b-852f-201b437237bb"), "ti", "Tigrinya", "Тигринья" },
                    { new Guid("d1b9043c-1354-4c96-b93d-de6d0e9baad7"), "bi", "Bislama", "Бислама" },
                    { new Guid("d2d54137-dfba-4414-8b0d-76557227ea6e"), "sv", "Swedish", "Шведский" },
                    { new Guid("d66d2e59-0b54-478b-8201-bfcb2ef67d03"), "se", "Sami", "Саамский" },
                    { new Guid("dbdcb59d-3adf-48ce-a02b-8d66095d1012"), "mn", "Mongolian", "Монгольский" },
                    { new Guid("dc2b2d29-7ea1-4445-8212-caebe6716a1f"), "bn", "Bengali (Bangla)", "Бенгальский" },
                    { new Guid("dc66d6e8-3a41-4905-a7b0-a4658da1ae85"), "ps", "Pashto, Pushto", "Пушту" },
                    { new Guid("dd6a207e-6c2c-45f1-b241-6f4e5cf41e48"), "cv", "Chuvash", "Чувашский" },
                    { new Guid("dedffff9-d88d-4975-a32e-1a0ec3490cc5"), "ng", "Ndonga", "Ндонга" },
                    { new Guid("deed6bed-c9c3-4a51-9727-b2a2c804800d"), "ts", "Tsonga", "Тсонга" },
                    { new Guid("dff6f6e1-ce26-4ee8-94d7-eb55aeae1fb8"), "af", "Afrikaans", "Африкаанс" },
                    { new Guid("e16d5de7-1fdc-4d72-99f0-f674070c4d0b"), "is", "Icelandic", "Исландский" },
                    { new Guid("e179e922-3903-4dd1-bc24-5e4b4e555380"), "an", "Aragonese", "Арагонский" },
                    { new Guid("e2c2a086-9216-4d0f-b6a9-1b720391a3ac"), "za", "Zhuang, Chuang", "Чжуанский" },
                    { new Guid("e4df8aad-f1c1-416c-aff3-ca3f6b0d98d2"), "ik", "Inupiak", "Инупиак" },
                    { new Guid("e57a2f33-2591-433b-b664-8dc41f46a24e"), "nv", "Navajo", "Навахо" },
                    { new Guid("e5b6ad06-16e1-40f0-8658-20a51c390c0e"), "os", "Ossetian", "Осетинский" },
                    { new Guid("e70d84bb-11dd-46ea-a133-6834a7365f80"), "qu", "Quechua", "Кечуа" },
                    { new Guid("e7956411-011b-496a-b9b0-acfbd329d540"), "be", "Belarusian", "Белорусский" },
                    { new Guid("ea641d82-5e17-403d-b110-ca2a795d3e37"), "nb", "Norwegian bokmål", "Норвежский (букмол)" },
                    { new Guid("ed967667-2a79-47b8-ad19-9b46bff43705"), "sh", "Serbo-Croatian", "Сербско-хорватский" },
                    { new Guid("f4b285b1-90cd-4c50-a317-55677e6bd210"), "en", "English", "Английский" },
                    { new Guid("f5649182-feb8-41c4-a374-9c5dbe78b08a"), "uz", "Uzbek", "Узбекский" },
                    { new Guid("f5cfedd0-9631-4a60-bf56-2fb5d0b3c0a5"), "ae", "Avestan", "Авестийский" },
                    { new Guid("f6ef7eee-eaca-4292-b15a-d08eff0272ca"), "oj", "Ojibwe", "Оджибве" },
                    { new Guid("f72c1626-0296-4794-b253-fb3199122301"), "gd", "Gaelic (Scottish)", "Шотландский гэльский" },
                    { new Guid("f7f062f7-872b-4279-b2bf-ff9cb6747d94"), "ny", "Chichewa, Chewa, Nyanja", "Чичева" },
                    { new Guid("f8d89827-6c69-4a2e-bdaa-4afbf41fdf86"), "lg", "Luganda, Ganda", "Луганда" },
                    { new Guid("f98f9e2b-2afc-4d8e-b9aa-e4822ef38051"), "ru", "Russian", "Русский" },
                    { new Guid("fa15ba44-2ef8-4661-b6d6-ea10d791fbf0"), "mo", "Moldavian", "Молдавский" },
                    { new Guid("fc390fd8-2016-4045-bfd4-ea5941347d8b"), "fj", "Fijian", "Фиджийский" },
                    { new Guid("fcc99c05-e86f-48b5-a4b0-79583378fa2a"), "zh-Hans", "Chinese (Simplified)", "Китайский (упрощённый)" },
                    { new Guid("fdd92e99-8a48-4c69-ab39-c5fd50bdb8e1"), "ty", "Tahitian", "Таитянский" },
                    { new Guid("ffcce7fc-f36d-4551-b93c-94002779d407"), "ro", "Romanian", "Румынский" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_language_infos_LanguageId",
                table: "language_infos",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_language_infos_ResumeId",
                table: "language_infos",
                column: "ResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "language_infos");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
