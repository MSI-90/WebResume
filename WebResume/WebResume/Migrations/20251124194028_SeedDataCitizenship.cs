using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebResume.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCitizenship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "citizenship",
                columns: new[] { "Id", "alpha2_code", "alpha3_code", "country_name", "country_name_ru", "numeric_code" },
                values: new object[,]
                {
                    { new Guid("014f212e-337b-4a73-88b0-628140c49763"), "HU", "HUN", "Hungary", "Венгрия", "348" },
                    { new Guid("01a7e699-741b-453c-9467-dde6ab0630c5"), "LB", "LBN", "Lebanon", "Ливан", "422" },
                    { new Guid("03385e00-331f-4e1b-960f-0c0bd9addddf"), "NC", "NCL", "New Caledonia", "Новая Каледония", "540" },
                    { new Guid("03fa2aa8-5cd3-44de-899b-a6944eff9f51"), "SC", "SYC", "Seychelles", "Сейшельские Острова", "690" },
                    { new Guid("04118e90-a24f-48c9-914c-2768e69e00f4"), "AT", "AUT", "Austria", "Австрия", "040" },
                    { new Guid("052a4f5d-36af-4105-99ac-47211d2e8829"), "BA", "BIH", "Bosnia and Herzegovina", "Босния и Герцеговина", "070" },
                    { new Guid("0696dbaa-f112-4fbb-b077-c38de25f7708"), "LY", "LBY", "Libya", "Ливия", "434" },
                    { new Guid("07b02a75-95a3-4bfc-88ab-d7f0da2ef107"), "TR", "TUR", "Turkey", "Турция", "792" },
                    { new Guid("082663e6-59e6-4744-be1c-4cb69aa0ed39"), "BI", "BDI", "Burundi", "Бурунди", "108" },
                    { new Guid("08de58df-e742-4b79-a873-ae8b8752330e"), "UZ", "UZB", "Uzbekistan", "Узбекистан", "860" },
                    { new Guid("097754f4-f1cf-4d0a-a8c5-a1eb4286efd2"), "RE", "REU", "Reunion", "Реюньон", "638" },
                    { new Guid("09f22bf9-22e0-4418-983a-506c004a30bb"), "AD", "AND", "Andorra", "Андорра", "020" },
                    { new Guid("0a184055-ad55-49ba-b440-07f80eed391f"), "BQ", "BES", "Bonaire, Sint Eustatius and Saba", "Бонэйр, Синт-Эстатиус и Саба", "535" },
                    { new Guid("0a1c48c4-7b1a-4802-b408-56f4feed4da5"), "CX", "CXR", "Christmas Island", "Остров Рождества", "162" },
                    { new Guid("0a6818a1-eff8-405f-8256-200300a6cd4d"), "KM", "COM", "Comoros (the)", "Коморы", "174" },
                    { new Guid("0bb0fe89-95ea-4478-9039-33067aec0c2e"), "MU", "MUS", "Mauritius", "Маврикий", "480" },
                    { new Guid("0d46e0d1-7fbd-4b7a-860a-13f123e8268e"), "GB", "GBR", "United Kingdom of Great Britain and Northern Ireland (the)", "Великобритания", "826" },
                    { new Guid("0eeafbae-91c0-41da-ab12-36ecedfeeb33"), "KY", "CYM", "Cayman Islands (the)", "Каймановы острова", "136" },
                    { new Guid("0fa32ea3-ab78-4ef4-aaa3-5bfc0b0e9d05"), "SB", "SLB", "Solomon Islands", "Соломоновы Острова", "090" },
                    { new Guid("10d36d38-3964-4107-af4f-106b1c67d13a"), "ML", "MLI", "Mali", "Мали", "466" },
                    { new Guid("114a6e62-d6d6-4af5-be4c-aa9d6b7ed33e"), "VI", "VIR", "Virgin Islands (U.S.)", "Американские Виргинские острова", "850" },
                    { new Guid("126f137e-08e2-44b8-8521-3100e837bc96"), "PN", "PCN", "Pitcairn", "Питкэрн", "612" },
                    { new Guid("138d7e35-ab7b-40f3-b8a7-930312c95d3e"), "GL", "GRL", "Greenland", "Гренландия", "304" },
                    { new Guid("14770db8-4f7f-41e1-a654-d2d6751ea906"), "GA", "GAB", "Gabon", "Габон", "266" },
                    { new Guid("15b4230c-7c65-442a-ab00-11e3ebda82db"), "AO", "AGO", "Angola", "Ангола", "024" },
                    { new Guid("169d28c0-5643-4f02-a0d0-60b2375c191c"), "KI", "KIR", "Kiribati", "Кирибати", "296" },
                    { new Guid("16a5bff5-e046-495b-972d-a15bd1edb223"), "IM", "IMN", "Isle of Man", "Остров Мэн", "833" },
                    { new Guid("17fcc2e5-fd5b-4d29-a5e7-d108e9d930a7"), "GN", "GIN", "Guinea", "Гвинея", "324" },
                    { new Guid("199603a0-62de-4e93-8931-bf61b43a09d1"), "RO", "ROU", "Romania", "Румыния", "642" },
                    { new Guid("1a175d25-852c-4523-b448-3f5ebea13928"), "SI", "SVN", "Slovenia", "Словения", "705" },
                    { new Guid("1cbca6a4-dfbc-4d90-9758-0e87a66293b9"), "RU", "RUS", "Russian Federation (the)", "Российская Федерация", "643" },
                    { new Guid("1ced5721-dafe-4125-b20e-c4725d2688d4"), "VG", "VGB", "Virgin Islands (British)", "Британские Виргинские острова", "092" },
                    { new Guid("20884245-6976-4ba9-9b5d-5f3f963736de"), "AM", "ARM", "Armenia", "Армения", "051" },
                    { new Guid("234297a1-0fb7-4081-ac5e-44ce80a70259"), "MK", "MKD", "Republic of North Macedonia", "Северная Македония", "807" },
                    { new Guid("23c26da7-f6f6-403d-8820-0f0e1ce8b577"), "ER", "ERI", "Eritrea", "Эритрея", "232" },
                    { new Guid("25d6c0e2-5ce6-4ae7-b5e3-2f92c5f7be52"), "TG", "TGO", "Togo", "Того", "768" },
                    { new Guid("25e0c537-86cf-4aa6-a013-e861c4505fd9"), "MA", "MAR", "Morocco", "Марокко", "504" },
                    { new Guid("2607c7de-cf7c-4882-85e0-c94c95542515"), "DK", "DNK", "Denmark", "Дания", "208" },
                    { new Guid("2af18e63-9ba1-4414-9013-2ab8b6ac562e"), "GS", "SGS", "South Georgia and the South Sandwich Islands", "Южная Георгия и Южные Сандвичевы острова", "239" },
                    { new Guid("2ba75bfb-4615-43c5-9023-3313edc4709b"), "RS", "SRB", "Serbia", "Сербия", "688" },
                    { new Guid("2c3098eb-a005-4a5d-8743-2d7707659846"), "CM", "CMR", "Cameroon", "Камерун", "120" },
                    { new Guid("2f8cbe38-d312-4b23-bab8-8f47a82d17e2"), "IO", "IOT", "British Indian Ocean Territory (the)", "Британская территория в Индийском океане", "086" },
                    { new Guid("303bcf26-1ad0-47b0-ada5-b1c6a8bc4fbc"), "PS", "PSE", "Palestine, State of", "Государство Палестина", "275" },
                    { new Guid("30f6e790-dc76-44a8-be1c-2a987325a247"), "PK", "PAK", "Pakistan", "Пакистан", "586" },
                    { new Guid("33a9cefa-65b0-4f3b-969f-fd82a1247780"), "AX", "ALA", "Aland Islands", "Аландские острова", "248" },
                    { new Guid("33cb90ca-f756-45d4-bcf5-a4de396f5473"), "BD", "BGD", "Bangladesh", "Бангладеш", "050" },
                    { new Guid("344a81dd-3ee9-4180-ad4d-734091158767"), "ST", "STP", "Sao Tome and Principe", "Сан-Томе и Принсипи", "678" },
                    { new Guid("3499061e-d3db-42f7-9327-35ec8591b91d"), "FR", "FRA", "France", "Франция", "250" },
                    { new Guid("34fd1952-3777-438c-a3b5-a1f099c4294d"), "NO", "NOR", "Norway", "Норвегия", "578" },
                    { new Guid("35f9dd5b-6164-47db-94e1-4e582f9ae92a"), "GP", "GLP", "Guadeloupe", "Гваделупа", "312" },
                    { new Guid("35fd823a-354f-458e-84e8-d0e951dc0c45"), "ZM", "ZMB", "Zambia", "Замбия", "894" },
                    { new Guid("360f3e07-4e80-44c8-ac28-10294133afe0"), "NI", "NIC", "Nicaragua", "Никарагуа", "558" },
                    { new Guid("38d6dbcd-c9f8-40db-bf97-b88cbb1afe46"), "AS", "ASM", "American Samoa", "Американское Самоа", "016" },
                    { new Guid("39208975-8ef5-4111-bb65-f13dbfebaed7"), "NA", "NAM", "Namibia", "Намибия", "516" },
                    { new Guid("39a25227-a7c1-4fca-8be4-d26aff98015c"), "BE", "BEL", "Belgium", "Бельгия", "056" },
                    { new Guid("3a72e6a7-fdd7-4f39-9bcc-8ee4b9ef95ba"), "YE", "YEM", "Yemen", "Йемен", "887" },
                    { new Guid("3ab7951c-b6a3-4f44-a33e-9ede3d7cdf20"), "TV", "TUV", "Tuvalu", "Тувалу", "798" },
                    { new Guid("3bd7af08-2977-4e7b-9214-083e76e1d9b6"), "QA", "QAT", "Qatar", "Катар", "634" },
                    { new Guid("3bdc9c19-35f3-44e4-b62d-0db15a842a60"), "DE", "DEU", "Germany", "Германия", "276" },
                    { new Guid("3e03199f-1b01-46a6-b4a5-eea64cd8305b"), "MP", "MNP", "Northern Mariana Islands (the)", "Северные Марианские острова", "580" },
                    { new Guid("40159fac-b8fd-4679-a3e2-b77e78302fec"), "CF", "CAF", "Central African Republic (the)", "Центральноафриканская Республика", "140" },
                    { new Guid("409773ee-1e0a-40d4-beaf-47a643910585"), "AF", "AFG", "Afghanistan", "Афганистан", "004" },
                    { new Guid("410249d1-8f0e-4f35-99ea-caa8dc8ca26f"), "PF", "PYF", "French Polynesia", "Французская Полинезия", "258" },
                    { new Guid("4179572d-ac9a-4421-aeaa-bd1513d5d512"), "PL", "POL", "Poland", "Польша", "616" },
                    { new Guid("4374488e-e3c5-4162-b5fb-b2e6077a1c41"), "AW", "ABW", "Aruba", "Аруба", "533" },
                    { new Guid("449a032d-5f7b-4afd-9325-8dcc61a21bd8"), "JO", "JOR", "Jordan", "Иордания", "400" },
                    { new Guid("44a1617a-8e06-4689-a9f9-06ae5f7e42ef"), "LU", "LUX", "Luxembourg", "Люксембург", "442" },
                    { new Guid("44c91d1f-9133-478f-8664-33edb2a41a6f"), "MT", "MLT", "Malta", "Мальта", "470" },
                    { new Guid("471a737c-6b76-4a58-81d0-30724f4ded17"), "ET", "ETH", "Ethiopia", "Эфиопия", "231" },
                    { new Guid("476a4099-c3ab-47c6-ac27-01ad5139a1dc"), "BF", "BFA", "Burkina Faso", "Буркина-Фасо", "854" },
                    { new Guid("492797e5-46fa-4f2f-b19e-02dd203cec3b"), "IN", "IND", "India", "Индия", "356" },
                    { new Guid("4930893f-a9a9-48c1-8835-62400232c6ca"), "KG", "KGZ", "Kyrgyzstan", "Кыргызстан", "417" },
                    { new Guid("497c4882-13a6-4854-8115-d971b63f7d79"), "SE", "SWE", "Sweden", "Швеция", "752" },
                    { new Guid("4a815a77-4e32-4e08-a25c-973df9e71a4d"), "IR", "IRN", "Iran (Islamic Republic of)", "Иран", "364" },
                    { new Guid("4ad2da45-29ff-467e-9a53-52912c3ecf5a"), "PM", "SPM", "Saint Pierre and Miquelon", "Сен-Пьер и Микелон", "666" },
                    { new Guid("4cc2f590-e46e-4ef5-8e9f-5aa0c73954ef"), "MF", "MAF", "Saint Martin (French part)", "Сен-Мартен (французская часть)", "663" },
                    { new Guid("4d0196f9-6387-40d0-97a5-02225f42d6c8"), "BG", "BGR", "Bulgaria", "Болгария", "100" },
                    { new Guid("4deb6639-2d76-4a9a-9b53-a1d31ea4211f"), "TM", "TKM", "Turkmenistan", "Туркменистан", "795" },
                    { new Guid("4ffa54b2-f07e-484d-bf06-e2c09a7f3f79"), "SV", "SLV", "El Salvador", "Сальвадор", "222" },
                    { new Guid("5031b4e7-6312-4207-a46e-a976be546742"), "PE", "PER", "Peru", "Перу", "604" },
                    { new Guid("50556fc1-8495-4637-b5be-ddd38c816826"), "BO", "BOL", "Bolivia (Plurinational State of)", "Боливия", "068" },
                    { new Guid("50da5e0c-61e2-48d4-8e53-5c120e2a267c"), "NL", "NLD", "Netherlands (the)", "Нидерланды", "528" },
                    { new Guid("51c98211-9dfb-499d-8171-98a228ebc01b"), "MG", "MDG", "Madagascar", "Мадагаскар", "450" },
                    { new Guid("53b496da-f1bf-4605-ba63-7d5f3d1599e2"), "VA", "VAT", "Holy See (the)", "Святой Престол (Ватикан)", "336" },
                    { new Guid("53e2c6d0-0ca0-4a83-8a06-85b15271034c"), "CL", "CHL", "Chile", "Чили", "152" },
                    { new Guid("54e95292-1fed-4c6d-b5c5-6cc771e5a478"), "DM", "DMA", "Dominica", "Доминика", "212" },
                    { new Guid("5592ac12-2705-4360-a590-5298479f17b0"), "EG", "EGY", "Egypt", "Египет", "818" },
                    { new Guid("55bdeb07-3b49-43cf-b029-ffda1ed3e656"), "SR", "SUR", "Suriname", "Суринам", "740" },
                    { new Guid("569d0dde-d61d-4ae8-9651-1e5e5f8ee795"), "UG", "UGA", "Uganda", "Уганда", "800" },
                    { new Guid("5766be3e-6e2e-4f12-9717-453a19461382"), "UA", "UKR", "Ukraine", "Украина", "804" },
                    { new Guid("57dbdb09-3c4c-4634-a836-30f35ae41cb9"), "IL", "ISR", "Israel", "Израиль", "376" },
                    { new Guid("5834859e-f9fd-402a-8c6f-aa1bc4a2557f"), "BH", "BHR", "Bahrain", "Бахрейн", "048" },
                    { new Guid("59951f99-0a65-4d88-b061-aede7c0cd91d"), "CZ", "CZE", "Czechia", "Чехия", "203" },
                    { new Guid("59f6ffd4-18f0-4528-9c19-b3100efe570d"), "GI", "GIB", "Gibraltar", "Гибралтар", "292" },
                    { new Guid("5aa96d29-a970-4e42-80fa-2eb8e45bfbe0"), "CN", "CHN", "China", "Китай", "156" },
                    { new Guid("5af967e0-d06a-4fc9-aa4f-4a0676501040"), "GH", "GHA", "Ghana", "Гана", "288" },
                    { new Guid("5b8b1c7e-5fa9-4dc9-b2b6-d6917ae76097"), "GW", "GNB", "Guinea-Bissau", "Гвинея-Бисау", "624" },
                    { new Guid("5e15b6e1-91b3-498a-b2b3-91f451575256"), "SM", "SMR", "San Marino", "Сан-Марино", "674" },
                    { new Guid("5ef34c65-58bb-44b0-b519-3b4ca5f672ba"), "MN", "MNG", "Mongolia", "Монголия", "496" },
                    { new Guid("5f0ba0ee-5220-4b49-9bb4-2c76f2b6155a"), "MH", "MHL", "Marshall Islands (the)", "Маршалловы Острова", "584" },
                    { new Guid("5fd6ae77-db9a-4891-9802-355b697edf13"), "SL", "SLE", "Sierra Leone", "Сьерра-Леоне", "694" },
                    { new Guid("60426dee-ed82-4f14-a2bb-af7398d5bfab"), "LI", "LIE", "Liechtenstein", "Лихтенштейн", "438" },
                    { new Guid("62731f20-a6a1-4638-b4cc-77f8a7e3366a"), "LS", "LSO", "Lesotho", "Лесото", "426" },
                    { new Guid("64a868cf-4447-4435-a79d-f76195d946c5"), "LT", "LTU", "Lithuania", "Литва", "440" },
                    { new Guid("6530c60e-1845-46e2-85ca-5a60e9028f88"), "KP", "PRK", "Korea (the Democratic People's Republic of)", "Корейская Народно-Демократическая Республика", "408" },
                    { new Guid("66cef14b-89e5-436f-91ae-a3cfeb19a7c8"), "MD", "MDA", "Moldova (the Republic of)", "Молдова", "498" },
                    { new Guid("674ce67f-f3a3-4d67-b06f-73c76cdaa280"), "GQ", "GNQ", "Equatorial Guinea", "Экваториальная Гвинея", "226" },
                    { new Guid("6af0358f-41a7-4380-bdfd-6b700fab2db4"), "MZ", "MOZ", "Mozambique", "Мозамбик", "508" },
                    { new Guid("6bd260ce-a3f6-4f9e-a12a-97098e7b3ad5"), "TL", "TLS", "Timor-Leste", "Восточный Тимор", "626" },
                    { new Guid("6c6b186f-53f1-493d-b253-5e28916234b6"), "IQ", "IRQ", "Iraq", "Ирак", "368" },
                    { new Guid("6c909cc7-7223-4ed5-ad08-ec7408f5e44d"), "VC", "VCT", "Saint Vincent and the Grenadines", "Сент-Винсент и Гренадины", "670" },
                    { new Guid("6cf502aa-d4f2-46ca-ae3b-c1f38993518f"), "ID", "IDN", "Indonesia", "Индонезия", "360" },
                    { new Guid("6d8a8597-3805-4882-b97f-933038066085"), "FO", "FRO", "Faroe Islands (the)", "Фарерские острова", "234" },
                    { new Guid("6f61388c-7b34-4f7b-987c-5e8fc42ee04c"), "TW", "TWN", "Taiwan (Province of China)", "Тайвань", "158" },
                    { new Guid("6f8900d9-6cfd-4f4e-8b1e-3d1407402ba7"), "ZW", "ZWE", "Zimbabwe", "Зимбабве", "716" },
                    { new Guid("6fb335e6-efcc-46fd-8a48-99770d74c32f"), "EE", "EST", "Estonia", "Эстония", "233" },
                    { new Guid("70ef5abb-2599-43d6-993c-f35d73d5883c"), "GY", "GUY", "Guyana", "Гайана", "328" },
                    { new Guid("710b89e2-17c3-4f63-bdd2-55023eecacb6"), "MO", "MAC", "Macao", "Макао", "446" },
                    { new Guid("71358726-da19-4923-aa52-2909e2ff87f5"), "AZ", "AZE", "Azerbaijan", "Азербайджан", "031" },
                    { new Guid("725046fb-2aff-4457-a99e-e1329096d2f8"), "JM", "JAM", "Jamaica", "Ямайка", "388" },
                    { new Guid("7661ad26-3574-468e-a3c5-db6b83aebd28"), "TC", "TCA", "Turks and Caicos Islands (the)", "Тёркс и Кайкос", "796" },
                    { new Guid("773b6618-f9d4-41cf-bd10-cbd278cce7c5"), "BN", "BRN", "Brunei Darussalam", "Бруней-Даруссалам", "096" },
                    { new Guid("773c0ce7-9b03-4654-bb8c-8d219524db0d"), "HR", "HRV", "Croatia", "Хорватия", "191" },
                    { new Guid("78778228-72fb-46af-92ab-919c80c6f4bf"), "AU", "AUS", "Australia", "Австралия", "036" },
                    { new Guid("78f37085-e726-4c1e-85f9-2a9cc9020394"), "BS", "BHS", "Bahamas (the)", "Багамские Острова", "044" },
                    { new Guid("7916cfa5-b000-4b7d-8634-123aef1714b4"), "BL", "BLM", "Saint Barthelemy", "Сен-Бартелеми", "652" },
                    { new Guid("7a1c4179-3b5b-4626-ab68-8c9fe3ef69c0"), "BR", "BRA", "Brazil", "Бразилия", "076" },
                    { new Guid("7b7fbeb0-8c51-4e6f-a8ce-042e65533795"), "FK", "FLK", "Falkland Islands (the) [Malvinas]", "Фолклендские (Мальвинские) острова", "238" },
                    { new Guid("7d69bc63-1bbc-44cf-9525-71d6a910b276"), "PR", "PRI", "Puerto Rico", "Пуэрто-Рико", "630" },
                    { new Guid("7ecfd587-68fd-4090-b480-a7c2d16d88f1"), "NZ", "NZL", "New Zealand", "Новая Зеландия", "554" },
                    { new Guid("829475cf-791d-457e-a9ea-fff4772db388"), "MX", "MEX", "Mexico", "Мексика", "484" },
                    { new Guid("83b2db8d-7d08-435b-b6d8-89f4db353395"), "SX", "SXM", "Sint Maarten (Dutch part)", "Синт-Мартен (нидерландская часть)", "534" },
                    { new Guid("85a8614d-7a6c-4c4a-b696-8a2c4def1945"), "SD", "SDN", "Sudan (the)", "Судан", "729" },
                    { new Guid("865d061a-9005-4e13-9279-596d8760fcfd"), "CA", "CAN", "Canada", "Канада", "124" },
                    { new Guid("87fe60ee-c120-498a-a503-e13ec638e429"), "TK", "TKL", "Tokelau", "Токелау", "772" },
                    { new Guid("882ea1c5-9da8-4492-9296-8e5fc4b34416"), "BW", "BWA", "Botswana", "Ботсвана", "072" },
                    { new Guid("88303ea3-e7ec-4fae-9365-d6e251f756fb"), "TZ", "TZA", "Tanzania, United Republic of", "Танзания", "834" },
                    { new Guid("883108a9-3cfc-4c91-90e9-30ecf6540ea8"), "MR", "MRT", "Mauritania", "Мавритания", "478" },
                    { new Guid("8858f8e0-5a07-4610-a22a-da235f2025a4"), "KW", "KWT", "Kuwait", "Кувейт", "414" },
                    { new Guid("8861aa52-5424-400c-aea6-a6540718d517"), "BJ", "BEN", "Benin", "Бенин", "204" },
                    { new Guid("8a2f8faf-981f-4d8a-907a-cd56fec28784"), "BT", "BTN", "Bhutan", "Бутан", "064" },
                    { new Guid("8aa3ee18-b2b2-4945-9f52-5b0fc8ac2210"), "PA", "PAN", "Panama", "Панама", "591" },
                    { new Guid("8ec2b615-1618-4cf9-868b-b4d82af116f5"), "GR", "GRC", "Greece", "Греция", "300" },
                    { new Guid("8efb2b4a-1e8e-4596-ab2d-464fafa06906"), "TO", "TON", "Tonga", "Тонга", "776" },
                    { new Guid("8f39f75c-aa63-473e-90e0-d09c043c9ce1"), "UY", "URY", "Uruguay", "Уругвай", "858" },
                    { new Guid("8fdef0d7-bf63-465d-8db6-d8a45fcc436e"), "DJ", "DJI", "Djibouti", "Джибути", "262" },
                    { new Guid("9037d089-f4a8-4a4f-8526-c81a1bfc3b87"), "PH", "PHL", "Philippines (the)", "Филиппины", "608" },
                    { new Guid("90601758-eae9-4120-86c1-eed159ac63d4"), "MW", "MWI", "Malawi", "Малави", "454" },
                    { new Guid("90dd1eb0-8adc-483a-8a3b-c9b8c0c0e518"), "GD", "GRD", "Grenada", "Гренада", "308" },
                    { new Guid("911830e9-0010-4b09-b5ef-e45c8774671f"), "KH", "KHM", "Cambodia", "Камбоджа", "116" },
                    { new Guid("94513ee2-78d1-43b6-9f00-78ed9bbd2aad"), "IT", "ITA", "Italy", "Италия", "380" },
                    { new Guid("94b8785a-4691-4b57-afb5-a8fad1766bde"), "CH", "CHE", "Switzerland", "Швейцария", "756" },
                    { new Guid("99bd554b-1994-48a2-b384-0b878836f28e"), "BV", "BVT", "Bouvet Island", "Остров Буве", "074" },
                    { new Guid("9a39bacc-92e5-4393-997f-08a114f0778b"), "SS", "SSD", "South Sudan", "Южный Судан", "728" },
                    { new Guid("9c95fb0d-c397-4f4b-b223-e047e601ab49"), "NU", "NIU", "Niue", "Ниуэ", "570" },
                    { new Guid("9d03ab08-eab7-4631-9e95-45828723e868"), "ES", "ESP", "Spain", "Испания", "724" },
                    { new Guid("9d6b3289-0489-4ef8-9506-86183e31a4b4"), "FJ", "FJI", "Fiji", "Фиджи", "242" },
                    { new Guid("9e36c5ce-e59b-40c4-8ff4-fa2985786c2c"), "PG", "PNG", "Papua New Guinea", "Папуа - Новая Гвинея", "598" },
                    { new Guid("a000386f-c814-4f53-8a78-cac6fed537e3"), "HM", "HMD", "Heard Island and McDonald Islands", "Острова Херд и Макдональд", "334" },
                    { new Guid("a0bbfbce-7374-49d6-8146-a0e1d320c061"), "WF", "WLF", "Wallis and Futuna", "Уоллис и Футуна", "876" },
                    { new Guid("a20d2ea8-4423-4dca-8512-acc5fbe0e642"), "TD", "TCD", "Chad", "Чад", "148" },
                    { new Guid("a28cc504-35c4-481f-9ddd-297e3f1c156e"), "AE", "ARE", "United Arab Emirates (the)", "Объединённые Арабские Эмираты", "784" },
                    { new Guid("a34b54b9-d7e4-4dd7-b833-d9cf054d5854"), "AG", "ATG", "Antigua and Barbuda", "Антигуа и Барбуда", "028" },
                    { new Guid("a437b52e-af46-4c6e-86ec-993c885cb3b9"), "IS", "ISL", "Iceland", "Исландия", "352" },
                    { new Guid("a4e32f03-3071-470a-a508-b5a1e6dc995f"), "MC", "MCO", "Monaco", "Монако", "492" },
                    { new Guid("a58e9df6-2679-4f4b-85f2-b5be1d040aa2"), "TT", "TTO", "Trinidad and Tobago", "Тринидад и Тобаго", "780" },
                    { new Guid("a5f9263d-fa79-4594-b87b-ba56ec5da1a4"), "HT", "HTI", "Haiti", "Гаити", "332" },
                    { new Guid("a732e6d1-2384-4960-8657-8a27718d5226"), "US", "USA", "United States of America (the)", "США", "840" },
                    { new Guid("a858adee-9cd4-4f54-8d0c-ea3b75f68fd8"), "BZ", "BLZ", "Belize", "Белиз", "084" },
                    { new Guid("aa88db7f-8565-4a61-9c9a-092e4ebd3953"), "SH", "SHN", "Saint Helena, Ascension and Tristan da Cunha", "Остров Святой Елены, Вознесения и Тристан-да-Кунья", "654" },
                    { new Guid("aae85562-69f5-4acf-a63a-22e50b879690"), "ME", "MNE", "Montenegro", "Черногория", "499" },
                    { new Guid("ab511512-65d4-4754-bdf9-c0688a428ff9"), "CW", "CUW", "Curacao", "Кюрасао", "531" },
                    { new Guid("ad22c605-e678-4f1e-8ccf-8a26703daecf"), "CG", "COG", "Congo (the)", "Конго", "178" },
                    { new Guid("ad7a35cf-b631-4ea2-bf1a-090d0512ec81"), "LK", "LKA", "Sri Lanka", "Шри-Ланка", "144" },
                    { new Guid("ae5add2b-b5c3-4677-9998-2a6f7d96eebb"), "IE", "IRL", "Ireland", "Ирландия", "372" },
                    { new Guid("aec434a1-de10-48a6-8a42-8583ca7ff603"), "SY", "SYR", "Syrian Arab Republic", "Сирийская Арабская Республика", "760" },
                    { new Guid("af0f3bc1-8380-450b-82d6-0a3cfcb4cc26"), "GF", "GUF", "French Guiana", "Французская Гвиана", "254" },
                    { new Guid("afd9433a-09ed-4511-a7dd-c05a9bdbca4a"), "MV", "MDV", "Maldives", "Мальдивы", "462" },
                    { new Guid("b0bd4c86-9a58-4504-af03-6d722ef34f8b"), "TJ", "TJK", "Tajikistan", "Таджикистан", "762" },
                    { new Guid("b0d3d204-8def-40b2-933d-c6451e24f7fc"), "HK", "HKG", "Hong Kong", "Гонконг", "344" },
                    { new Guid("b1aa36f1-a353-425f-a542-fa52db7020e0"), "AR", "ARG", "Argentina", "Аргентина", "032" },
                    { new Guid("b21d5c23-bfd6-43c1-85a1-11f180553913"), "LC", "LCA", "Saint Lucia", "Сент-Люсия", "662" },
                    { new Guid("b3d8baa2-a2f7-4972-8f48-63189b0c6b20"), "CK", "COK", "Cook Islands (the)", "Острова Кука", "184" },
                    { new Guid("b4601b73-9494-47d3-a0c1-216d890e052f"), "TF", "ATF", "French Southern Territories (the)", "Французские Южные и Антарктические территории", "260" },
                    { new Guid("b54c1abf-b23a-4592-857a-3c415ef3186e"), "NR", "NRU", "Nauru", "Науру", "520" },
                    { new Guid("b67fdd6e-b4f2-4ac4-9afb-45fb83472053"), "NE", "NER", "Niger (the)", "Нигер", "562" },
                    { new Guid("b6b846e7-49b4-488a-bdab-92a53f5658a0"), "BY", "BLR", "Belarus", "Беларусь", "112" },
                    { new Guid("b6fafb19-cc07-407f-bb99-87f43f04430e"), "RW", "RWA", "Rwanda", "Руанда", "646" },
                    { new Guid("b8d46a85-d1ef-49d4-8de1-6468f0616985"), "CI", "CIV", "Cote d'Ivoire", "Кот-д'Ивуар", "384" },
                    { new Guid("b9f1d1b8-c4f1-47b8-a62a-03fdd5aa9f37"), "CD", "COD", "Congo (the Democratic Republic of the)", "Демократическая Республика Конго", "180" },
                    { new Guid("bca1a91c-c859-4771-bc68-aa6decfcbccb"), "FM", "FSM", "Micronesia (Federated States of)", "Федеративные Штаты Микронезии", "583" },
                    { new Guid("bd44c19d-2e2a-46fc-b63e-062b3115050f"), "VN", "VNM", "Viet Nam", "Вьетнам", "704" },
                    { new Guid("bd67769a-fe1c-4235-9a0d-1f916278eaab"), "CY", "CYP", "Cyprus", "Кипр", "196" },
                    { new Guid("c0683c57-f78b-4e22-9212-17907417ca0a"), "YT", "MYT", "Mayotte", "Майотта", "175" },
                    { new Guid("c0d93177-1391-4302-8b21-3bcdf972c7bb"), "GG", "GGY", "Guernsey", "Гернси", "831" },
                    { new Guid("c29530d9-495f-40e4-ae38-ad26d4842df6"), "CO", "COL", "Colombia", "Колумбия", "170" },
                    { new Guid("c329cca5-d501-48bb-9788-bccf4d8a47c1"), "BB", "BRB", "Barbados", "Барбадос", "052" },
                    { new Guid("c434dc87-51d6-48ed-8da5-b504a8a783ca"), "SK", "SVK", "Slovakia", "Словакия", "703" },
                    { new Guid("c525ae2a-8c1a-4301-a5a4-dbe4a8d02b28"), "EC", "ECU", "Ecuador", "Эквадор", "218" },
                    { new Guid("c56cd567-0f56-4285-9c22-2c60f9db26bf"), "JP", "JPN", "Japan", "Япония", "392" },
                    { new Guid("c56e0297-6eb7-4c5d-9147-ccb75eb5487a"), "NG", "NGA", "Nigeria", "Нигерия", "566" },
                    { new Guid("c6063457-9024-4bc5-9f34-4f9ae35b5243"), "TH", "THA", "Thailand", "Таиланд", "764" },
                    { new Guid("c8283eee-cf37-44dd-aad2-6368acd794c1"), "CC", "CCK", "Cocos (Keeling) Islands (the)", "Кокосовые (Килинг) острова", "166" },
                    { new Guid("c82b5e24-9083-409c-acab-de1ef0c7d1dc"), "TN", "TUN", "Tunisia", "Тунис", "788" },
                    { new Guid("c9018998-20db-460b-85e5-fb97799cebd2"), "BM", "BMU", "Bermuda", "Бермудские острова", "060" },
                    { new Guid("c966075a-b2ad-4091-9b6e-72f105d58fd7"), "CV", "CPV", "Cabo Verde", "Кабо-Верде", "132" },
                    { new Guid("c9a8a625-cc63-40c2-a7a7-a0f74a5641b7"), "GM", "GMB", "Gambia (the)", "Гамбия", "270" },
                    { new Guid("cb0491e7-13b9-4b03-a617-d358d35d0e02"), "CR", "CRI", "Costa Rica", "Коста-Рика", "188" },
                    { new Guid("cb47db1e-0d56-4b72-a156-f0430b12640a"), "CU", "CUB", "Cuba", "Куба", "192" },
                    { new Guid("ce2041ae-4ba0-4fe4-b49a-0d5dd3a8d30f"), "SA", "SAU", "Saudi Arabia", "Саудовская Аравия", "682" },
                    { new Guid("ced6b11c-2ebe-48fd-90d4-aec756b13939"), "MY", "MYS", "Malaysia", "Малайзия", "458" },
                    { new Guid("d16600e1-38cc-4278-88de-59f2043f595b"), "VU", "VUT", "Vanuatu", "Вануату", "548" },
                    { new Guid("d16bf78c-3af3-4900-8a73-4f02ae5aff2b"), "KN", "KNA", "Saint Kitts and Nevis", "Сент-Китс и Невис", "659" },
                    { new Guid("d1a5f774-2418-47ad-b9ee-be2e2564fe2a"), "DO", "DOM", "Dominican Republic (the)", "Доминиканская Республика", "214" },
                    { new Guid("d75990bf-70df-49f2-bed3-db021e7bf05e"), "ZA", "ZAF", "South Africa", "Южно-Африканская Республика", "710" },
                    { new Guid("d858a032-1b3e-4fbd-a0b9-878bc200ade2"), "LR", "LBR", "Liberia", "Либерия", "430" },
                    { new Guid("d8d404e9-1e8f-46f9-9918-f39ce5d0153c"), "SN", "SEN", "Senegal", "Сенегал", "686" },
                    { new Guid("dc4511de-4603-42aa-ae83-d8158738d052"), "PT", "PRT", "Portugal", "Португалия", "620" },
                    { new Guid("dd7955b8-d10b-4426-a648-5a29158737e1"), "SJ", "SJM", "Svalbard and Jan Mayen", "Шпицберген и Ян-Майен", "744" },
                    { new Guid("e1f71d77-7578-4c7e-b420-faa02692818b"), "VE", "VEN", "Venezuela (Bolivarian Republic of)", "Венесуэла", "862" },
                    { new Guid("e33c1e61-4584-43c8-9ee5-258bcdc78715"), "EH", "ESH", "Western Sahara", "Западная Сахара", "732" },
                    { new Guid("e4be36b3-7841-4a65-8abd-11b5fa1b8c16"), "SG", "SGP", "Singapore", "Сингапур", "702" },
                    { new Guid("e57305f2-0555-46fb-9c33-54ce426c1237"), "SO", "SOM", "Somalia", "Сомали", "706" },
                    { new Guid("e6fabb92-6a05-4256-899b-4f66214c427a"), "PW", "PLW", "Palau", "Палау", "585" },
                    { new Guid("e786fa53-5a05-4938-8b83-cc81df2c9489"), "GT", "GTM", "Guatemala", "Гватемала", "320" },
                    { new Guid("e9bed67e-8cb0-4ca3-a930-e1fee6c9758a"), "AQ", "ATA", "Antarctica", "Антарктида", "010" },
                    { new Guid("ea069df4-99b1-463d-b5c7-059cf852d436"), "LV", "LVA", "Latvia", "Латвия", "428" },
                    { new Guid("eac4d959-64db-41ee-95f4-db2d4d15cf05"), "OM", "OMN", "Oman", "Оман", "512" },
                    { new Guid("eb0196bb-644e-49ad-849d-f1aefbe1f32b"), "NP", "NPL", "Nepal", "Непал", "524" },
                    { new Guid("eba05bac-e226-4611-9049-365855c14237"), "UM", "UMI", "United States Minor Outlying Islands (the)", "Внешние малые острова (США)", "581" },
                    { new Guid("ed7b5707-d6b8-4efd-ab74-00aab6bc8a22"), "DZ", "DZA", "Algeria", "Алжир", "012" },
                    { new Guid("efa9ce44-1767-413d-b5e3-58eaf4d3af50"), "KR", "KOR", "Korea (the Republic of)", "Республика Корея", "410" },
                    { new Guid("f130a731-42ad-43ce-9736-1026d83c8e46"), "FI", "FIN", "Finland", "Финляндия", "246" },
                    { new Guid("f1432f8b-184e-4ca3-9501-cb4fb2ae6c8a"), "MQ", "MTQ", "Martinique", "Мартиника", "474" },
                    { new Guid("f1622234-6c1f-4171-b45b-f60d9d56e141"), "AL", "ALB", "Albania", "Албания", "008" },
                    { new Guid("f2026d3b-ab65-4c92-8ae6-867c10185a0d"), "WS", "WSM", "Samoa", "Самоа", "882" },
                    { new Guid("f2d1bc91-751e-438c-8102-0f09bc0a3f6e"), "MS", "MSR", "Montserrat", "Монтсеррат", "500" },
                    { new Guid("f43ae112-85da-445b-849e-ee75af6a7891"), "KZ", "KAZ", "Kazakhstan", "Казахстан", "398" },
                    { new Guid("f5119197-fbf9-428e-8afb-8dce1cfaccf3"), "PY", "PRY", "Paraguay", "Парагвай", "600" },
                    { new Guid("f52f650e-51e1-4d5a-b984-82fcf4386bbf"), "NF", "NFK", "Norfolk Island", "Остров Норфолк", "574" },
                    { new Guid("f6119864-1850-436c-92ee-b169ad8957b8"), "SZ", "SWZ", "Eswatini", "Эсватини", "748" },
                    { new Guid("f7f90a58-27e1-4ebb-8f36-ee8641a53f12"), "KE", "KEN", "Kenya", "Кения", "404" },
                    { new Guid("f84e4bf1-c03c-44f2-a2eb-fae74fb6270a"), "AI", "AIA", "Anguilla", "Ангилья", "660" },
                    { new Guid("f8d4e30d-4f1d-4638-b469-486d5e123b37"), "MM", "MMR", "Myanmar", "Мьянма", "104" },
                    { new Guid("f97e6d8a-bba8-4d3b-9bc0-f751e081210d"), "GU", "GUM", "Guam", "Гуам", "316" },
                    { new Guid("f9aaa5bb-310f-4e12-985e-b822ae909a4b"), "LA", "LAO", "Lao People's Democratic Republic (the)", "Лаос", "418" },
                    { new Guid("ff27576d-ffc3-41b5-894c-9a0395b5bcdb"), "JE", "JEY", "Jersey", "Джерси", "832" },
                    { new Guid("ffdb699e-5625-4791-a93f-5f3e6612125f"), "HN", "HND", "Honduras", "Гондурас", "340" },
                    { new Guid("ffe01565-9e1c-4f72-882f-0baeceaf591b"), "GE", "GEO", "Georgia", "Грузия", "268" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("014f212e-337b-4a73-88b0-628140c49763"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("01a7e699-741b-453c-9467-dde6ab0630c5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("03385e00-331f-4e1b-960f-0c0bd9addddf"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("03fa2aa8-5cd3-44de-899b-a6944eff9f51"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("04118e90-a24f-48c9-914c-2768e69e00f4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("052a4f5d-36af-4105-99ac-47211d2e8829"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0696dbaa-f112-4fbb-b077-c38de25f7708"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("07b02a75-95a3-4bfc-88ab-d7f0da2ef107"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("082663e6-59e6-4744-be1c-4cb69aa0ed39"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("08de58df-e742-4b79-a873-ae8b8752330e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("097754f4-f1cf-4d0a-a8c5-a1eb4286efd2"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("09f22bf9-22e0-4418-983a-506c004a30bb"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0a184055-ad55-49ba-b440-07f80eed391f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0a1c48c4-7b1a-4802-b408-56f4feed4da5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0a6818a1-eff8-405f-8256-200300a6cd4d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0bb0fe89-95ea-4478-9039-33067aec0c2e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0d46e0d1-7fbd-4b7a-860a-13f123e8268e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0eeafbae-91c0-41da-ab12-36ecedfeeb33"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("0fa32ea3-ab78-4ef4-aaa3-5bfc0b0e9d05"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("10d36d38-3964-4107-af4f-106b1c67d13a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("114a6e62-d6d6-4af5-be4c-aa9d6b7ed33e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("126f137e-08e2-44b8-8521-3100e837bc96"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("138d7e35-ab7b-40f3-b8a7-930312c95d3e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("14770db8-4f7f-41e1-a654-d2d6751ea906"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("15b4230c-7c65-442a-ab00-11e3ebda82db"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("169d28c0-5643-4f02-a0d0-60b2375c191c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("16a5bff5-e046-495b-972d-a15bd1edb223"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("17fcc2e5-fd5b-4d29-a5e7-d108e9d930a7"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("199603a0-62de-4e93-8931-bf61b43a09d1"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("1a175d25-852c-4523-b448-3f5ebea13928"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("1cbca6a4-dfbc-4d90-9758-0e87a66293b9"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("1ced5721-dafe-4125-b20e-c4725d2688d4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("20884245-6976-4ba9-9b5d-5f3f963736de"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("234297a1-0fb7-4081-ac5e-44ce80a70259"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("23c26da7-f6f6-403d-8820-0f0e1ce8b577"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("25d6c0e2-5ce6-4ae7-b5e3-2f92c5f7be52"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("25e0c537-86cf-4aa6-a013-e861c4505fd9"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("2607c7de-cf7c-4882-85e0-c94c95542515"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("2af18e63-9ba1-4414-9013-2ab8b6ac562e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("2ba75bfb-4615-43c5-9023-3313edc4709b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("2c3098eb-a005-4a5d-8743-2d7707659846"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("2f8cbe38-d312-4b23-bab8-8f47a82d17e2"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("303bcf26-1ad0-47b0-ada5-b1c6a8bc4fbc"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("30f6e790-dc76-44a8-be1c-2a987325a247"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("33a9cefa-65b0-4f3b-969f-fd82a1247780"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("33cb90ca-f756-45d4-bcf5-a4de396f5473"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("344a81dd-3ee9-4180-ad4d-734091158767"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("3499061e-d3db-42f7-9327-35ec8591b91d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("34fd1952-3777-438c-a3b5-a1f099c4294d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("35f9dd5b-6164-47db-94e1-4e582f9ae92a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("35fd823a-354f-458e-84e8-d0e951dc0c45"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("360f3e07-4e80-44c8-ac28-10294133afe0"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("38d6dbcd-c9f8-40db-bf97-b88cbb1afe46"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("39208975-8ef5-4111-bb65-f13dbfebaed7"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("39a25227-a7c1-4fca-8be4-d26aff98015c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("3a72e6a7-fdd7-4f39-9bcc-8ee4b9ef95ba"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("3ab7951c-b6a3-4f44-a33e-9ede3d7cdf20"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("3bd7af08-2977-4e7b-9214-083e76e1d9b6"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("3bdc9c19-35f3-44e4-b62d-0db15a842a60"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("3e03199f-1b01-46a6-b4a5-eea64cd8305b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("40159fac-b8fd-4679-a3e2-b77e78302fec"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("409773ee-1e0a-40d4-beaf-47a643910585"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("410249d1-8f0e-4f35-99ea-caa8dc8ca26f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4179572d-ac9a-4421-aeaa-bd1513d5d512"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4374488e-e3c5-4162-b5fb-b2e6077a1c41"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("449a032d-5f7b-4afd-9325-8dcc61a21bd8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("44a1617a-8e06-4689-a9f9-06ae5f7e42ef"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("44c91d1f-9133-478f-8664-33edb2a41a6f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("471a737c-6b76-4a58-81d0-30724f4ded17"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("476a4099-c3ab-47c6-ac27-01ad5139a1dc"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("492797e5-46fa-4f2f-b19e-02dd203cec3b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4930893f-a9a9-48c1-8835-62400232c6ca"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("497c4882-13a6-4854-8115-d971b63f7d79"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4a815a77-4e32-4e08-a25c-973df9e71a4d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4ad2da45-29ff-467e-9a53-52912c3ecf5a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4cc2f590-e46e-4ef5-8e9f-5aa0c73954ef"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4d0196f9-6387-40d0-97a5-02225f42d6c8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4deb6639-2d76-4a9a-9b53-a1d31ea4211f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("4ffa54b2-f07e-484d-bf06-e2c09a7f3f79"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5031b4e7-6312-4207-a46e-a976be546742"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("50556fc1-8495-4637-b5be-ddd38c816826"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("50da5e0c-61e2-48d4-8e53-5c120e2a267c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("51c98211-9dfb-499d-8171-98a228ebc01b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("53b496da-f1bf-4605-ba63-7d5f3d1599e2"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("53e2c6d0-0ca0-4a83-8a06-85b15271034c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("54e95292-1fed-4c6d-b5c5-6cc771e5a478"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5592ac12-2705-4360-a590-5298479f17b0"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("55bdeb07-3b49-43cf-b029-ffda1ed3e656"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("569d0dde-d61d-4ae8-9651-1e5e5f8ee795"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5766be3e-6e2e-4f12-9717-453a19461382"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("57dbdb09-3c4c-4634-a836-30f35ae41cb9"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5834859e-f9fd-402a-8c6f-aa1bc4a2557f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("59951f99-0a65-4d88-b061-aede7c0cd91d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("59f6ffd4-18f0-4528-9c19-b3100efe570d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5aa96d29-a970-4e42-80fa-2eb8e45bfbe0"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5af967e0-d06a-4fc9-aa4f-4a0676501040"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5b8b1c7e-5fa9-4dc9-b2b6-d6917ae76097"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5e15b6e1-91b3-498a-b2b3-91f451575256"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5ef34c65-58bb-44b0-b519-3b4ca5f672ba"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5f0ba0ee-5220-4b49-9bb4-2c76f2b6155a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("5fd6ae77-db9a-4891-9802-355b697edf13"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("60426dee-ed82-4f14-a2bb-af7398d5bfab"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("62731f20-a6a1-4638-b4cc-77f8a7e3366a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("64a868cf-4447-4435-a79d-f76195d946c5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6530c60e-1845-46e2-85ca-5a60e9028f88"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("66cef14b-89e5-436f-91ae-a3cfeb19a7c8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("674ce67f-f3a3-4d67-b06f-73c76cdaa280"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6af0358f-41a7-4380-bdfd-6b700fab2db4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6bd260ce-a3f6-4f9e-a12a-97098e7b3ad5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6c6b186f-53f1-493d-b253-5e28916234b6"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6c909cc7-7223-4ed5-ad08-ec7408f5e44d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6cf502aa-d4f2-46ca-ae3b-c1f38993518f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6d8a8597-3805-4882-b97f-933038066085"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6f61388c-7b34-4f7b-987c-5e8fc42ee04c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6f8900d9-6cfd-4f4e-8b1e-3d1407402ba7"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("6fb335e6-efcc-46fd-8a48-99770d74c32f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("70ef5abb-2599-43d6-993c-f35d73d5883c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("710b89e2-17c3-4f63-bdd2-55023eecacb6"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("71358726-da19-4923-aa52-2909e2ff87f5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("725046fb-2aff-4457-a99e-e1329096d2f8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("7661ad26-3574-468e-a3c5-db6b83aebd28"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("773b6618-f9d4-41cf-bd10-cbd278cce7c5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("773c0ce7-9b03-4654-bb8c-8d219524db0d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("78778228-72fb-46af-92ab-919c80c6f4bf"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("78f37085-e726-4c1e-85f9-2a9cc9020394"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("7916cfa5-b000-4b7d-8634-123aef1714b4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("7a1c4179-3b5b-4626-ab68-8c9fe3ef69c0"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("7b7fbeb0-8c51-4e6f-a8ce-042e65533795"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("7d69bc63-1bbc-44cf-9525-71d6a910b276"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("7ecfd587-68fd-4090-b480-a7c2d16d88f1"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("829475cf-791d-457e-a9ea-fff4772db388"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("83b2db8d-7d08-435b-b6d8-89f4db353395"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("85a8614d-7a6c-4c4a-b696-8a2c4def1945"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("865d061a-9005-4e13-9279-596d8760fcfd"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("87fe60ee-c120-498a-a503-e13ec638e429"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("882ea1c5-9da8-4492-9296-8e5fc4b34416"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("88303ea3-e7ec-4fae-9365-d6e251f756fb"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("883108a9-3cfc-4c91-90e9-30ecf6540ea8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8858f8e0-5a07-4610-a22a-da235f2025a4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8861aa52-5424-400c-aea6-a6540718d517"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8a2f8faf-981f-4d8a-907a-cd56fec28784"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8aa3ee18-b2b2-4945-9f52-5b0fc8ac2210"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8ec2b615-1618-4cf9-868b-b4d82af116f5"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8efb2b4a-1e8e-4596-ab2d-464fafa06906"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8f39f75c-aa63-473e-90e0-d09c043c9ce1"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("8fdef0d7-bf63-465d-8db6-d8a45fcc436e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("9037d089-f4a8-4a4f-8526-c81a1bfc3b87"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("90601758-eae9-4120-86c1-eed159ac63d4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("90dd1eb0-8adc-483a-8a3b-c9b8c0c0e518"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("911830e9-0010-4b09-b5ef-e45c8774671f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("94513ee2-78d1-43b6-9f00-78ed9bbd2aad"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("94b8785a-4691-4b57-afb5-a8fad1766bde"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("99bd554b-1994-48a2-b384-0b878836f28e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("9a39bacc-92e5-4393-997f-08a114f0778b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("9c95fb0d-c397-4f4b-b223-e047e601ab49"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("9d03ab08-eab7-4631-9e95-45828723e868"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("9d6b3289-0489-4ef8-9506-86183e31a4b4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("9e36c5ce-e59b-40c4-8ff4-fa2985786c2c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a000386f-c814-4f53-8a78-cac6fed537e3"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a0bbfbce-7374-49d6-8146-a0e1d320c061"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a20d2ea8-4423-4dca-8512-acc5fbe0e642"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a28cc504-35c4-481f-9ddd-297e3f1c156e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a34b54b9-d7e4-4dd7-b833-d9cf054d5854"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a437b52e-af46-4c6e-86ec-993c885cb3b9"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a4e32f03-3071-470a-a508-b5a1e6dc995f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a58e9df6-2679-4f4b-85f2-b5be1d040aa2"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a5f9263d-fa79-4594-b87b-ba56ec5da1a4"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a732e6d1-2384-4960-8657-8a27718d5226"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("a858adee-9cd4-4f54-8d0c-ea3b75f68fd8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("aa88db7f-8565-4a61-9c9a-092e4ebd3953"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("aae85562-69f5-4acf-a63a-22e50b879690"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ab511512-65d4-4754-bdf9-c0688a428ff9"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ad22c605-e678-4f1e-8ccf-8a26703daecf"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ad7a35cf-b631-4ea2-bf1a-090d0512ec81"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ae5add2b-b5c3-4677-9998-2a6f7d96eebb"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("aec434a1-de10-48a6-8a42-8583ca7ff603"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("af0f3bc1-8380-450b-82d6-0a3cfcb4cc26"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("afd9433a-09ed-4511-a7dd-c05a9bdbca4a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b0bd4c86-9a58-4504-af03-6d722ef34f8b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b0d3d204-8def-40b2-933d-c6451e24f7fc"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b1aa36f1-a353-425f-a542-fa52db7020e0"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b21d5c23-bfd6-43c1-85a1-11f180553913"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b3d8baa2-a2f7-4972-8f48-63189b0c6b20"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b4601b73-9494-47d3-a0c1-216d890e052f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b54c1abf-b23a-4592-857a-3c415ef3186e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b67fdd6e-b4f2-4ac4-9afb-45fb83472053"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b6b846e7-49b4-488a-bdab-92a53f5658a0"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b6fafb19-cc07-407f-bb99-87f43f04430e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b8d46a85-d1ef-49d4-8de1-6468f0616985"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("b9f1d1b8-c4f1-47b8-a62a-03fdd5aa9f37"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("bca1a91c-c859-4771-bc68-aa6decfcbccb"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("bd44c19d-2e2a-46fc-b63e-062b3115050f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("bd67769a-fe1c-4235-9a0d-1f916278eaab"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c0683c57-f78b-4e22-9212-17907417ca0a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c0d93177-1391-4302-8b21-3bcdf972c7bb"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c29530d9-495f-40e4-ae38-ad26d4842df6"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c329cca5-d501-48bb-9788-bccf4d8a47c1"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c434dc87-51d6-48ed-8da5-b504a8a783ca"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c525ae2a-8c1a-4301-a5a4-dbe4a8d02b28"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c56cd567-0f56-4285-9c22-2c60f9db26bf"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c56e0297-6eb7-4c5d-9147-ccb75eb5487a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c6063457-9024-4bc5-9f34-4f9ae35b5243"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c8283eee-cf37-44dd-aad2-6368acd794c1"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c82b5e24-9083-409c-acab-de1ef0c7d1dc"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c9018998-20db-460b-85e5-fb97799cebd2"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c966075a-b2ad-4091-9b6e-72f105d58fd7"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("c9a8a625-cc63-40c2-a7a7-a0f74a5641b7"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("cb0491e7-13b9-4b03-a617-d358d35d0e02"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("cb47db1e-0d56-4b72-a156-f0430b12640a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ce2041ae-4ba0-4fe4-b49a-0d5dd3a8d30f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ced6b11c-2ebe-48fd-90d4-aec756b13939"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("d16600e1-38cc-4278-88de-59f2043f595b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("d16bf78c-3af3-4900-8a73-4f02ae5aff2b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("d1a5f774-2418-47ad-b9ee-be2e2564fe2a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("d75990bf-70df-49f2-bed3-db021e7bf05e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("d858a032-1b3e-4fbd-a0b9-878bc200ade2"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("d8d404e9-1e8f-46f9-9918-f39ce5d0153c"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("dc4511de-4603-42aa-ae83-d8158738d052"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("dd7955b8-d10b-4426-a648-5a29158737e1"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e1f71d77-7578-4c7e-b420-faa02692818b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e33c1e61-4584-43c8-9ee5-258bcdc78715"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e4be36b3-7841-4a65-8abd-11b5fa1b8c16"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e57305f2-0555-46fb-9c33-54ce426c1237"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e6fabb92-6a05-4256-899b-4f66214c427a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e786fa53-5a05-4938-8b83-cc81df2c9489"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("e9bed67e-8cb0-4ca3-a930-e1fee6c9758a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ea069df4-99b1-463d-b5c7-059cf852d436"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("eac4d959-64db-41ee-95f4-db2d4d15cf05"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("eb0196bb-644e-49ad-849d-f1aefbe1f32b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("eba05bac-e226-4611-9049-365855c14237"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ed7b5707-d6b8-4efd-ab74-00aab6bc8a22"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("efa9ce44-1767-413d-b5e3-58eaf4d3af50"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f130a731-42ad-43ce-9736-1026d83c8e46"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f1432f8b-184e-4ca3-9501-cb4fb2ae6c8a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f1622234-6c1f-4171-b45b-f60d9d56e141"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f2026d3b-ab65-4c92-8ae6-867c10185a0d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f2d1bc91-751e-438c-8102-0f09bc0a3f6e"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f43ae112-85da-445b-849e-ee75af6a7891"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f5119197-fbf9-428e-8afb-8dce1cfaccf3"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f52f650e-51e1-4d5a-b984-82fcf4386bbf"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f6119864-1850-436c-92ee-b169ad8957b8"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f7f90a58-27e1-4ebb-8f36-ee8641a53f12"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f84e4bf1-c03c-44f2-a2eb-fae74fb6270a"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f8d4e30d-4f1d-4638-b469-486d5e123b37"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f97e6d8a-bba8-4d3b-9bc0-f751e081210d"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("f9aaa5bb-310f-4e12-985e-b822ae909a4b"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ff27576d-ffc3-41b5-894c-9a0395b5bcdb"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ffdb699e-5625-4791-a93f-5f3e6612125f"));

            migrationBuilder.DeleteData(
                table: "citizenship",
                keyColumn: "Id",
                keyValue: new Guid("ffe01565-9e1c-4f72-882f-0baeceaf591b"));
        }
    }
}
