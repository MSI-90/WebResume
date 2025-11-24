using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class CitizenshipConfiguration : IEntityTypeConfiguration<Citizenship>
  {
    public void Configure(EntityTypeBuilder<Citizenship> builder)
    {
      builder.ToTable("citizenship");
      builder.Property(c => c.CountryName).HasMaxLength(60).IsRequired().HasColumnName("country_name");
      builder.Property(c => c.CountryNameRu).HasMaxLength(60).IsRequired().HasColumnName("country_name_ru");
      builder.Property(c => c.Alpha2Code).HasMaxLength(5).IsRequired().HasColumnName("alpha2_code");
      builder.Property(c => c.Alpha3Code).HasMaxLength(5).IsRequired().HasColumnName("alpha3_code");
      builder.Property(c => c.NumericCode).HasMaxLength(5).IsRequired().HasColumnName("numeric_code");

      builder.HasData
      (
        new Citizenship
        {
          Id = Guid.Parse("409773ee-1e0a-40d4-beaf-47a643910585"),
          CountryName = "Afghanistan",
          CountryNameRu = "Афганистан",
          Alpha2Code = "AF",
          Alpha3Code = "AFG",
          NumericCode = "004"
        },

          new Citizenship
          {
            Id = Guid.Parse("f1622234-6c1f-4171-b45b-f60d9d56e141"),
            CountryName = "Albania",
            CountryNameRu = "Албания",
            Alpha2Code = "AL",
            Alpha3Code = "ALB",
            NumericCode = "008"
          },

          new Citizenship
          {
            Id = Guid.Parse("ed7b5707-d6b8-4efd-ab74-00aab6bc8a22"),
            CountryName = "Algeria",
            CountryNameRu = "Алжир",
            Alpha2Code = "DZ",
            Alpha3Code = "DZA",
            NumericCode = "012"
          },

          new Citizenship
          {
            Id = Guid.Parse("38d6dbcd-c9f8-40db-bf97-b88cbb1afe46"),
            CountryName = "American Samoa",
            CountryNameRu = "Американское Самоа",
            Alpha2Code = "AS",
            Alpha3Code = "ASM",
            NumericCode = "016"
          },

          new Citizenship
          {
            Id = Guid.Parse("09f22bf9-22e0-4418-983a-506c004a30bb"),
            CountryName = "Andorra",
            CountryNameRu = "Андорра",
            Alpha2Code = "AD",
            Alpha3Code = "AND",
            NumericCode = "020"
          },

          new Citizenship
          {
            Id = Guid.Parse("15b4230c-7c65-442a-ab00-11e3ebda82db"),
            CountryName = "Angola",
            CountryNameRu = "Ангола",
            Alpha2Code = "AO",
            Alpha3Code = "AGO",
            NumericCode = "024"
          },

          new Citizenship
          {
            Id = Guid.Parse("f84e4bf1-c03c-44f2-a2eb-fae74fb6270a"),
            CountryName = "Anguilla",
            CountryNameRu = "Ангилья",
            Alpha2Code = "AI",
            Alpha3Code = "AIA",
            NumericCode = "660"
          },

          new Citizenship
          {
            Id = Guid.Parse("e9bed67e-8cb0-4ca3-a930-e1fee6c9758a"),
            CountryName = "Antarctica",
            CountryNameRu = "Антарктида",
            Alpha2Code = "AQ",
            Alpha3Code = "ATA",
            NumericCode = "010"
          },

          new Citizenship
          {
            Id = Guid.Parse("a34b54b9-d7e4-4dd7-b833-d9cf054d5854"),
            CountryName = "Antigua and Barbuda",
            CountryNameRu = "Антигуа и Барбуда",
            Alpha2Code = "AG",
            Alpha3Code = "ATG",
            NumericCode = "028"
          },

          new Citizenship
          {
            Id = Guid.Parse("b1aa36f1-a353-425f-a542-fa52db7020e0"),
            CountryName = "Argentina",
            CountryNameRu = "Аргентина",
            Alpha2Code = "AR",
            Alpha3Code = "ARG",
            NumericCode = "032"
          },

          new Citizenship
          {
            Id = Guid.Parse("20884245-6976-4ba9-9b5d-5f3f963736de"),
            CountryName = "Armenia",
            CountryNameRu = "Армения",
            Alpha2Code = "AM",
            Alpha3Code = "ARM",
            NumericCode = "051"
          },

          new Citizenship
          {
            Id = Guid.Parse("4374488e-e3c5-4162-b5fb-b2e6077a1c41"),
            CountryName = "Aruba",
            CountryNameRu = "Аруба",
            Alpha2Code = "AW",
            Alpha3Code = "ABW",
            NumericCode = "533"
          },

          new Citizenship
          {
            Id = Guid.Parse("78778228-72fb-46af-92ab-919c80c6f4bf"),
            CountryName = "Australia",
            CountryNameRu = "Австралия",
            Alpha2Code = "AU",
            Alpha3Code = "AUS",
            NumericCode = "036"
          },

          new Citizenship
          {
            Id = Guid.Parse("04118e90-a24f-48c9-914c-2768e69e00f4"),
            CountryName = "Austria",
            CountryNameRu = "Австрия",
            Alpha2Code = "AT",
            Alpha3Code = "AUT",
            NumericCode = "040"
          },

          new Citizenship
          {
            Id = Guid.Parse("71358726-da19-4923-aa52-2909e2ff87f5"),
            CountryName = "Azerbaijan",
            CountryNameRu = "Азербайджан",
            Alpha2Code = "AZ",
            Alpha3Code = "AZE",
            NumericCode = "031"
          },

          new Citizenship
          {
            Id = Guid.Parse("78f37085-e726-4c1e-85f9-2a9cc9020394"),
            CountryName = "Bahamas (the)",
            CountryNameRu = "Багамские Острова",
            Alpha2Code = "BS",
            Alpha3Code = "BHS",
            NumericCode = "044"
          },

          new Citizenship
          {
            Id = Guid.Parse("5834859e-f9fd-402a-8c6f-aa1bc4a2557f"),
            CountryName = "Bahrain",
            CountryNameRu = "Бахрейн",
            Alpha2Code = "BH",
            Alpha3Code = "BHR",
            NumericCode = "048"
          },

          new Citizenship
          {
            Id = Guid.Parse("33cb90ca-f756-45d4-bcf5-a4de396f5473"),
            CountryName = "Bangladesh",
            CountryNameRu = "Бангладеш",
            Alpha2Code = "BD",
            Alpha3Code = "BGD",
            NumericCode = "050"
          },

          new Citizenship
          {
            Id = Guid.Parse("c329cca5-d501-48bb-9788-bccf4d8a47c1"),
            CountryName = "Barbados",
            CountryNameRu = "Барбадос",
            Alpha2Code = "BB",
            Alpha3Code = "BRB",
            NumericCode = "052"
          },

          new Citizenship
          {
            Id = Guid.Parse("b6b846e7-49b4-488a-bdab-92a53f5658a0"),
            CountryName = "Belarus",
            CountryNameRu = "Беларусь",
            Alpha2Code = "BY",
            Alpha3Code = "BLR",
            NumericCode = "112"
          },

          new Citizenship
          {
            Id = Guid.Parse("39a25227-a7c1-4fca-8be4-d26aff98015c"),
            CountryName = "Belgium",
            CountryNameRu = "Бельгия",
            Alpha2Code = "BE",
            Alpha3Code = "BEL",
            NumericCode = "056"
          },

          new Citizenship
          {
            Id = Guid.Parse("a858adee-9cd4-4f54-8d0c-ea3b75f68fd8"),
            CountryName = "Belize",
            CountryNameRu = "Белиз",
            Alpha2Code = "BZ",
            Alpha3Code = "BLZ",
            NumericCode = "084"
          },

          new Citizenship
          {
            Id = Guid.Parse("8861aa52-5424-400c-aea6-a6540718d517"),
            CountryName = "Benin",
            CountryNameRu = "Бенин",
            Alpha2Code = "BJ",
            Alpha3Code = "BEN",
            NumericCode = "204"
          },

          new Citizenship
          {
            Id = Guid.Parse("c9018998-20db-460b-85e5-fb97799cebd2"),
            CountryName = "Bermuda",
            CountryNameRu = "Бермудские острова",
            Alpha2Code = "BM",
            Alpha3Code = "BMU",
            NumericCode = "060"
          },

          new Citizenship
          {
            Id = Guid.Parse("8a2f8faf-981f-4d8a-907a-cd56fec28784"),
            CountryName = "Bhutan",
            CountryNameRu = "Бутан",
            Alpha2Code = "BT",
            Alpha3Code = "BTN",
            NumericCode = "064"
          },

          new Citizenship
          {
            Id = Guid.Parse("50556fc1-8495-4637-b5be-ddd38c816826"),
            CountryName = "Bolivia (Plurinational State of)",
            CountryNameRu = "Боливия",
            Alpha2Code = "BO",
            Alpha3Code = "BOL",
            NumericCode = "068"
          },

          new Citizenship
          {
            Id = Guid.Parse("0a184055-ad55-49ba-b440-07f80eed391f"),
            CountryName = "Bonaire, Sint Eustatius and Saba",
            CountryNameRu = "Бонэйр, Синт-Эстатиус и Саба",
            Alpha2Code = "BQ",
            Alpha3Code = "BES",
            NumericCode = "535"
          },

          new Citizenship
          {
            Id = Guid.Parse("052a4f5d-36af-4105-99ac-47211d2e8829"),
            CountryName = "Bosnia and Herzegovina",
            CountryNameRu = "Босния и Герцеговина",
            Alpha2Code = "BA",
            Alpha3Code = "BIH",
            NumericCode = "070"
          },

          new Citizenship
          {
            Id = Guid.Parse("882ea1c5-9da8-4492-9296-8e5fc4b34416"),
            CountryName = "Botswana",
            CountryNameRu = "Ботсвана",
            Alpha2Code = "BW",
            Alpha3Code = "BWA",
            NumericCode = "072"
          },

          new Citizenship
          {
            Id = Guid.Parse("99bd554b-1994-48a2-b384-0b878836f28e"),
            CountryName = "Bouvet Island",
            CountryNameRu = "Остров Буве",
            Alpha2Code = "BV",
            Alpha3Code = "BVT",
            NumericCode = "074"
          },

          new Citizenship
          {
            Id = Guid.Parse("7a1c4179-3b5b-4626-ab68-8c9fe3ef69c0"),
            CountryName = "Brazil",
            CountryNameRu = "Бразилия",
            Alpha2Code = "BR",
            Alpha3Code = "BRA",
            NumericCode = "076"
          },

          new Citizenship
          {
            Id = Guid.Parse("2f8cbe38-d312-4b23-bab8-8f47a82d17e2"),
            CountryName = "British Indian Ocean Territory (the)",
            CountryNameRu = "Британская территория в Индийском океане",
            Alpha2Code = "IO",
            Alpha3Code = "IOT",
            NumericCode = "086"
          },

          new Citizenship
          {
            Id = Guid.Parse("773b6618-f9d4-41cf-bd10-cbd278cce7c5"),
            CountryName = "Brunei Darussalam",
            CountryNameRu = "Бруней-Даруссалам",
            Alpha2Code = "BN",
            Alpha3Code = "BRN",
            NumericCode = "096"
          },

          new Citizenship
          {
            Id = Guid.Parse("4d0196f9-6387-40d0-97a5-02225f42d6c8"),
            CountryName = "Bulgaria",
            CountryNameRu = "Болгария",
            Alpha2Code = "BG",
            Alpha3Code = "BGR",
            NumericCode = "100"
          },

          new Citizenship
          {
            Id = Guid.Parse("476a4099-c3ab-47c6-ac27-01ad5139a1dc"),
            CountryName = "Burkina Faso",
            CountryNameRu = "Буркина-Фасо",
            Alpha2Code = "BF",
            Alpha3Code = "BFA",
            NumericCode = "854"
          },

          new Citizenship
          {
            Id = Guid.Parse("082663e6-59e6-4744-be1c-4cb69aa0ed39"),
            CountryName = "Burundi",
            CountryNameRu = "Бурунди",
            Alpha2Code = "BI",
            Alpha3Code = "BDI",
            NumericCode = "108"
          },

          new Citizenship
          {
            Id = Guid.Parse("c966075a-b2ad-4091-9b6e-72f105d58fd7"),
            CountryName = "Cabo Verde",
            CountryNameRu = "Кабо-Верде",
            Alpha2Code = "CV",
            Alpha3Code = "CPV",
            NumericCode = "132"
          },

          new Citizenship
          {
            Id = Guid.Parse("911830e9-0010-4b09-b5ef-e45c8774671f"),
            CountryName = "Cambodia",
            CountryNameRu = "Камбоджа",
            Alpha2Code = "KH",
            Alpha3Code = "KHM",
            NumericCode = "116"
          },

          new Citizenship
          {
            Id = Guid.Parse("2c3098eb-a005-4a5d-8743-2d7707659846"),
            CountryName = "Cameroon",
            CountryNameRu = "Камерун",
            Alpha2Code = "CM",
            Alpha3Code = "CMR",
            NumericCode = "120"
          },

          new Citizenship
          {
            Id = Guid.Parse("865d061a-9005-4e13-9279-596d8760fcfd"),
            CountryName = "Canada",
            CountryNameRu = "Канада",
            Alpha2Code = "CA",
            Alpha3Code = "CAN",
            NumericCode = "124"
          },

          new Citizenship
          {
            Id = Guid.Parse("0eeafbae-91c0-41da-ab12-36ecedfeeb33"),
            CountryName = "Cayman Islands (the)",
            CountryNameRu = "Каймановы острова",
            Alpha2Code = "KY",
            Alpha3Code = "CYM",
            NumericCode = "136"
          },

          new Citizenship
          {
            Id = Guid.Parse("40159fac-b8fd-4679-a3e2-b77e78302fec"),
            CountryName = "Central African Republic (the)",
            CountryNameRu = "Центральноафриканская Республика",
            Alpha2Code = "CF",
            Alpha3Code = "CAF",
            NumericCode = "140"
          },

          new Citizenship
          {
            Id = Guid.Parse("a20d2ea8-4423-4dca-8512-acc5fbe0e642"),
            CountryName = "Chad",
            CountryNameRu = "Чад",
            Alpha2Code = "TD",
            Alpha3Code = "TCD",
            NumericCode = "148"
          },

          new Citizenship
          {
            Id = Guid.Parse("53e2c6d0-0ca0-4a83-8a06-85b15271034c"),
            CountryName = "Chile",
            CountryNameRu = "Чили",
            Alpha2Code = "CL",
            Alpha3Code = "CHL",
            NumericCode = "152"
          },

          new Citizenship
          {
            Id = Guid.Parse("5aa96d29-a970-4e42-80fa-2eb8e45bfbe0"),
            CountryName = "China",
            CountryNameRu = "Китай",
            Alpha2Code = "CN",
            Alpha3Code = "CHN",
            NumericCode = "156"
          },

          new Citizenship
          {
            Id = Guid.Parse("0a1c48c4-7b1a-4802-b408-56f4feed4da5"),
            CountryName = "Christmas Island",
            CountryNameRu = "Остров Рождества",
            Alpha2Code = "CX",
            Alpha3Code = "CXR",
            NumericCode = "162"
          },

          new Citizenship
          {
            Id = Guid.Parse("c8283eee-cf37-44dd-aad2-6368acd794c1"),
            CountryName = "Cocos (Keeling) Islands (the)",
            CountryNameRu = "Кокосовые (Килинг) острова",
            Alpha2Code = "CC",
            Alpha3Code = "CCK",
            NumericCode = "166"
          },

          new Citizenship
          {
            Id = Guid.Parse("c29530d9-495f-40e4-ae38-ad26d4842df6"),
            CountryName = "Colombia",
            CountryNameRu = "Колумбия",
            Alpha2Code = "CO",
            Alpha3Code = "COL",
            NumericCode = "170"
          },

          new Citizenship
          {
            Id = Guid.Parse("0a6818a1-eff8-405f-8256-200300a6cd4d"),
            CountryName = "Comoros (the)",
            CountryNameRu = "Коморы",
            Alpha2Code = "KM",
            Alpha3Code = "COM",
            NumericCode = "174"
          },

          new Citizenship
          {
            Id = Guid.Parse("b9f1d1b8-c4f1-47b8-a62a-03fdd5aa9f37"),
            CountryName = "Congo (the Democratic Republic of the)",
            CountryNameRu = "Демократическая Республика Конго",
            Alpha2Code = "CD",
            Alpha3Code = "COD",
            NumericCode = "180"
          },

          new Citizenship
          {
            Id = Guid.Parse("ad22c605-e678-4f1e-8ccf-8a26703daecf"),
            CountryName = "Congo (the)",
            CountryNameRu = "Конго",
            Alpha2Code = "CG",
            Alpha3Code = "COG",
            NumericCode = "178"
          },

          new Citizenship
          {
            Id = Guid.Parse("b3d8baa2-a2f7-4972-8f48-63189b0c6b20"),
            CountryName = "Cook Islands (the)",
            CountryNameRu = "Острова Кука",
            Alpha2Code = "CK",
            Alpha3Code = "COK",
            NumericCode = "184"
          },

          new Citizenship
          {
            Id = Guid.Parse("cb0491e7-13b9-4b03-a617-d358d35d0e02"),
            CountryName = "Costa Rica",
            CountryNameRu = "Коста-Рика",
            Alpha2Code = "CR",
            Alpha3Code = "CRI",
            NumericCode = "188"
          },

          new Citizenship
          {
            Id = Guid.Parse("773c0ce7-9b03-4654-bb8c-8d219524db0d"),
            CountryName = "Croatia",
            CountryNameRu = "Хорватия",
            Alpha2Code = "HR",
            Alpha3Code = "HRV",
            NumericCode = "191"
          },

          new Citizenship
          {
            Id = Guid.Parse("cb47db1e-0d56-4b72-a156-f0430b12640a"),
            CountryName = "Cuba",
            CountryNameRu = "Куба",
            Alpha2Code = "CU",
            Alpha3Code = "CUB",
            NumericCode = "192"
          },

          new Citizenship
          {
            Id = Guid.Parse("ab511512-65d4-4754-bdf9-c0688a428ff9"),
            CountryName = "Curacao",
            CountryNameRu = "Кюрасао",
            Alpha2Code = "CW",
            Alpha3Code = "CUW",
            NumericCode = "531"
          },

          new Citizenship
          {
            Id = Guid.Parse("bd67769a-fe1c-4235-9a0d-1f916278eaab"),
            CountryName = "Cyprus",
            CountryNameRu = "Кипр",
            Alpha2Code = "CY",
            Alpha3Code = "CYP",
            NumericCode = "196"
          },

          new Citizenship
          {
            Id = Guid.Parse("59951f99-0a65-4d88-b061-aede7c0cd91d"),
            CountryName = "Czechia",
            CountryNameRu = "Чехия",
            Alpha2Code = "CZ",
            Alpha3Code = "CZE",
            NumericCode = "203"
          },

          new Citizenship
          {
            Id = Guid.Parse("b8d46a85-d1ef-49d4-8de1-6468f0616985"),
            CountryName = "Cote d'Ivoire",
            CountryNameRu = "Кот-д'Ивуар",
            Alpha2Code = "CI",
            Alpha3Code = "CIV",
            NumericCode = "384"
          },

          new Citizenship
          {
            Id = Guid.Parse("2607c7de-cf7c-4882-85e0-c94c95542515"),
            CountryName = "Denmark",
            CountryNameRu = "Дания",
            Alpha2Code = "DK",
            Alpha3Code = "DNK",
            NumericCode = "208"
          },

          new Citizenship
          {
            Id = Guid.Parse("8fdef0d7-bf63-465d-8db6-d8a45fcc436e"),
            CountryName = "Djibouti",
            CountryNameRu = "Джибути",
            Alpha2Code = "DJ",
            Alpha3Code = "DJI",
            NumericCode = "262"
          },

          new Citizenship
          {
            Id = Guid.Parse("54e95292-1fed-4c6d-b5c5-6cc771e5a478"),
            CountryName = "Dominica",
            CountryNameRu = "Доминика",
            Alpha2Code = "DM",
            Alpha3Code = "DMA",
            NumericCode = "212"
          },

          new Citizenship
          {
            Id = Guid.Parse("d1a5f774-2418-47ad-b9ee-be2e2564fe2a"),
            CountryName = "Dominican Republic (the)",
            CountryNameRu = "Доминиканская Республика",
            Alpha2Code = "DO",
            Alpha3Code = "DOM",
            NumericCode = "214"
          },

          new Citizenship
          {
            Id = Guid.Parse("c525ae2a-8c1a-4301-a5a4-dbe4a8d02b28"),
            CountryName = "Ecuador",
            CountryNameRu = "Эквадор",
            Alpha2Code = "EC",
            Alpha3Code = "ECU",
            NumericCode = "218"
          },

          new Citizenship
          {
            Id = Guid.Parse("5592ac12-2705-4360-a590-5298479f17b0"),
            CountryName = "Egypt",
            CountryNameRu = "Египет",
            Alpha2Code = "EG",
            Alpha3Code = "EGY",
            NumericCode = "818"
          },

          new Citizenship
          {
            Id = Guid.Parse("4ffa54b2-f07e-484d-bf06-e2c09a7f3f79"),
            CountryName = "El Salvador",
            CountryNameRu = "Сальвадор",
            Alpha2Code = "SV",
            Alpha3Code = "SLV",
            NumericCode = "222"
          },

          new Citizenship
          {
            Id = Guid.Parse("674ce67f-f3a3-4d67-b06f-73c76cdaa280"),
            CountryName = "Equatorial Guinea",
            CountryNameRu = "Экваториальная Гвинея",
            Alpha2Code = "GQ",
            Alpha3Code = "GNQ",
            NumericCode = "226"
          },

          new Citizenship
          {
            Id = Guid.Parse("23c26da7-f6f6-403d-8820-0f0e1ce8b577"),
            CountryName = "Eritrea",
            CountryNameRu = "Эритрея",
            Alpha2Code = "ER",
            Alpha3Code = "ERI",
            NumericCode = "232"
          },

          new Citizenship
          {
            Id = Guid.Parse("6fb335e6-efcc-46fd-8a48-99770d74c32f"),
            CountryName = "Estonia",
            CountryNameRu = "Эстония",
            Alpha2Code = "EE",
            Alpha3Code = "EST",
            NumericCode = "233"
          },

          new Citizenship
          {
            Id = Guid.Parse("f6119864-1850-436c-92ee-b169ad8957b8"),
            CountryName = "Eswatini",
            CountryNameRu = "Эсватини",
            Alpha2Code = "SZ",
            Alpha3Code = "SWZ",
            NumericCode = "748"
          },

          new Citizenship
          {
            Id = Guid.Parse("471a737c-6b76-4a58-81d0-30724f4ded17"),
            CountryName = "Ethiopia",
            CountryNameRu = "Эфиопия",
            Alpha2Code = "ET",
            Alpha3Code = "ETH",
            NumericCode = "231"
          },

          new Citizenship
          {
            Id = Guid.Parse("7b7fbeb0-8c51-4e6f-a8ce-042e65533795"),
            CountryName = "Falkland Islands (the) [Malvinas]",
            CountryNameRu = "Фолклендские (Мальвинские) острова",
            Alpha2Code = "FK",
            Alpha3Code = "FLK",
            NumericCode = "238"
          },

          new Citizenship
          {
            Id = Guid.Parse("6d8a8597-3805-4882-b97f-933038066085"),
            CountryName = "Faroe Islands (the)",
            CountryNameRu = "Фарерские острова",
            Alpha2Code = "FO",
            Alpha3Code = "FRO",
            NumericCode = "234"
          },

          new Citizenship
          {
            Id = Guid.Parse("9d6b3289-0489-4ef8-9506-86183e31a4b4"),
            CountryName = "Fiji",
            CountryNameRu = "Фиджи",
            Alpha2Code = "FJ",
            Alpha3Code = "FJI",
            NumericCode = "242"
          },

          new Citizenship
          {
            Id = Guid.Parse("f130a731-42ad-43ce-9736-1026d83c8e46"),
            CountryName = "Finland",
            CountryNameRu = "Финляндия",
            Alpha2Code = "FI",
            Alpha3Code = "FIN",
            NumericCode = "246"
          },

          new Citizenship
          {
            Id = Guid.Parse("3499061e-d3db-42f7-9327-35ec8591b91d"),
            CountryName = "France",
            CountryNameRu = "Франция",
            Alpha2Code = "FR",
            Alpha3Code = "FRA",
            NumericCode = "250"
          },

          new Citizenship
          {
            Id = Guid.Parse("af0f3bc1-8380-450b-82d6-0a3cfcb4cc26"),
            CountryName = "French Guiana",
            CountryNameRu = "Французская Гвиана",
            Alpha2Code = "GF",
            Alpha3Code = "GUF",
            NumericCode = "254"
          },

          new Citizenship
          {
            Id = Guid.Parse("410249d1-8f0e-4f35-99ea-caa8dc8ca26f"),
            CountryName = "French Polynesia",
            CountryNameRu = "Французская Полинезия",
            Alpha2Code = "PF",
            Alpha3Code = "PYF",
            NumericCode = "258"
          },

          new Citizenship
          {
            Id = Guid.Parse("b4601b73-9494-47d3-a0c1-216d890e052f"),
            CountryName = "French Southern Territories (the)",
            CountryNameRu = "Французские Южные и Антарктические территории",
            Alpha2Code = "TF",
            Alpha3Code = "ATF",
            NumericCode = "260"
          },

          new Citizenship
          {
            Id = Guid.Parse("14770db8-4f7f-41e1-a654-d2d6751ea906"),
            CountryName = "Gabon",
            CountryNameRu = "Габон",
            Alpha2Code = "GA",
            Alpha3Code = "GAB",
            NumericCode = "266"
          },

          new Citizenship
          {
            Id = Guid.Parse("c9a8a625-cc63-40c2-a7a7-a0f74a5641b7"),
            CountryName = "Gambia (the)",
            CountryNameRu = "Гамбия",
            Alpha2Code = "GM",
            Alpha3Code = "GMB",
            NumericCode = "270"
          },

          new Citizenship
          {
            Id = Guid.Parse("ffe01565-9e1c-4f72-882f-0baeceaf591b"),
            CountryName = "Georgia",
            CountryNameRu = "Грузия",
            Alpha2Code = "GE",
            Alpha3Code = "GEO",
            NumericCode = "268"
          },

          new Citizenship
          {
            Id = Guid.Parse("3bdc9c19-35f3-44e4-b62d-0db15a842a60"),
            CountryName = "Germany",
            CountryNameRu = "Германия",
            Alpha2Code = "DE",
            Alpha3Code = "DEU",
            NumericCode = "276"
          },

          new Citizenship
          {
            Id = Guid.Parse("5af967e0-d06a-4fc9-aa4f-4a0676501040"),
            CountryName = "Ghana",
            CountryNameRu = "Гана",
            Alpha2Code = "GH",
            Alpha3Code = "GHA",
            NumericCode = "288"
          },

          new Citizenship
          {
            Id = Guid.Parse("59f6ffd4-18f0-4528-9c19-b3100efe570d"),
            CountryName = "Gibraltar",
            CountryNameRu = "Гибралтар",
            Alpha2Code = "GI",
            Alpha3Code = "GIB",
            NumericCode = "292"
          },

          new Citizenship
          {
            Id = Guid.Parse("8ec2b615-1618-4cf9-868b-b4d82af116f5"),
            CountryName = "Greece",
            CountryNameRu = "Греция",
            Alpha2Code = "GR",
            Alpha3Code = "GRC",
            NumericCode = "300"
          },

          new Citizenship
          {
            Id = Guid.Parse("138d7e35-ab7b-40f3-b8a7-930312c95d3e"),
            CountryName = "Greenland",
            CountryNameRu = "Гренландия",
            Alpha2Code = "GL",
            Alpha3Code = "GRL",
            NumericCode = "304"
          },

          new Citizenship
          {
            Id = Guid.Parse("90dd1eb0-8adc-483a-8a3b-c9b8c0c0e518"),
            CountryName = "Grenada",
            CountryNameRu = "Гренада",
            Alpha2Code = "GD",
            Alpha3Code = "GRD",
            NumericCode = "308"
          },

          new Citizenship
          {
            Id = Guid.Parse("35f9dd5b-6164-47db-94e1-4e582f9ae92a"),
            CountryName = "Guadeloupe",
            CountryNameRu = "Гваделупа",
            Alpha2Code = "GP",
            Alpha3Code = "GLP",
            NumericCode = "312"
          },

          new Citizenship
          {
            Id = Guid.Parse("f97e6d8a-bba8-4d3b-9bc0-f751e081210d"),
            CountryName = "Guam",
            CountryNameRu = "Гуам",
            Alpha2Code = "GU",
            Alpha3Code = "GUM",
            NumericCode = "316"
          },

          new Citizenship
          {
            Id = Guid.Parse("e786fa53-5a05-4938-8b83-cc81df2c9489"),
            CountryName = "Guatemala",
            CountryNameRu = "Гватемала",
            Alpha2Code = "GT",
            Alpha3Code = "GTM",
            NumericCode = "320"
          },

          new Citizenship
          {
            Id = Guid.Parse("c0d93177-1391-4302-8b21-3bcdf972c7bb"),
            CountryName = "Guernsey",
            CountryNameRu = "Гернси",
            Alpha2Code = "GG",
            Alpha3Code = "GGY",
            NumericCode = "831"
          },

          new Citizenship
          {
            Id = Guid.Parse("17fcc2e5-fd5b-4d29-a5e7-d108e9d930a7"),
            CountryName = "Guinea",
            CountryNameRu = "Гвинея",
            Alpha2Code = "GN",
            Alpha3Code = "GIN",
            NumericCode = "324"
          },

          new Citizenship
          {
            Id = Guid.Parse("5b8b1c7e-5fa9-4dc9-b2b6-d6917ae76097"),
            CountryName = "Guinea-Bissau",
            CountryNameRu = "Гвинея-Бисау",
            Alpha2Code = "GW",
            Alpha3Code = "GNB",
            NumericCode = "624"
          },

          new Citizenship
          {
            Id = Guid.Parse("70ef5abb-2599-43d6-993c-f35d73d5883c"),
            CountryName = "Guyana",
            CountryNameRu = "Гайана",
            Alpha2Code = "GY",
            Alpha3Code = "GUY",
            NumericCode = "328"
          },

          new Citizenship
          {
            Id = Guid.Parse("a5f9263d-fa79-4594-b87b-ba56ec5da1a4"),
            CountryName = "Haiti",
            CountryNameRu = "Гаити",
            Alpha2Code = "HT",
            Alpha3Code = "HTI",
            NumericCode = "332"
          },

          new Citizenship
          {
            Id = Guid.Parse("a000386f-c814-4f53-8a78-cac6fed537e3"),
            CountryName = "Heard Island and McDonald Islands",
            CountryNameRu = "Острова Херд и Макдональд",
            Alpha2Code = "HM",
            Alpha3Code = "HMD",
            NumericCode = "334"
          },

          new Citizenship
          {
            Id = Guid.Parse("53b496da-f1bf-4605-ba63-7d5f3d1599e2"),
            CountryName = "Holy See (the)",
            CountryNameRu = "Святой Престол (Ватикан)",
            Alpha2Code = "VA",
            Alpha3Code = "VAT",
            NumericCode = "336"
          },

          new Citizenship
          {
            Id = Guid.Parse("ffdb699e-5625-4791-a93f-5f3e6612125f"),
            CountryName = "Honduras",
            CountryNameRu = "Гондурас",
            Alpha2Code = "HN",
            Alpha3Code = "HND",
            NumericCode = "340"
          },

          new Citizenship
          {
            Id = Guid.Parse("b0d3d204-8def-40b2-933d-c6451e24f7fc"),
            CountryName = "Hong Kong",
            CountryNameRu = "Гонконг",
            Alpha2Code = "HK",
            Alpha3Code = "HKG",
            NumericCode = "344"
          },

          new Citizenship
          {
            Id = Guid.Parse("014f212e-337b-4a73-88b0-628140c49763"),
            CountryName = "Hungary",
            CountryNameRu = "Венгрия",
            Alpha2Code = "HU",
            Alpha3Code = "HUN",
            NumericCode = "348"
          },

          new Citizenship
          {
            Id = Guid.Parse("a437b52e-af46-4c6e-86ec-993c885cb3b9"),
            CountryName = "Iceland",
            CountryNameRu = "Исландия",
            Alpha2Code = "IS",
            Alpha3Code = "ISL",
            NumericCode = "352"
          },

          new Citizenship
          {
            Id = Guid.Parse("492797e5-46fa-4f2f-b19e-02dd203cec3b"),
            CountryName = "India",
            CountryNameRu = "Индия",
            Alpha2Code = "IN",
            Alpha3Code = "IND",
            NumericCode = "356"
          },

          new Citizenship
          {
            Id = Guid.Parse("6cf502aa-d4f2-46ca-ae3b-c1f38993518f"),
            CountryName = "Indonesia",
            CountryNameRu = "Индонезия",
            Alpha2Code = "ID",
            Alpha3Code = "IDN",
            NumericCode = "360"
          },

          new Citizenship
          {
            Id = Guid.Parse("4a815a77-4e32-4e08-a25c-973df9e71a4d"),
            CountryName = "Iran (Islamic Republic of)",
            CountryNameRu = "Иран",
            Alpha2Code = "IR",
            Alpha3Code = "IRN",
            NumericCode = "364"
          },

          new Citizenship
          {
            Id = Guid.Parse("6c6b186f-53f1-493d-b253-5e28916234b6"),
            CountryName = "Iraq",
            CountryNameRu = "Ирак",
            Alpha2Code = "IQ",
            Alpha3Code = "IRQ",
            NumericCode = "368"
          },

          new Citizenship
          {
            Id = Guid.Parse("ae5add2b-b5c3-4677-9998-2a6f7d96eebb"),
            CountryName = "Ireland",
            CountryNameRu = "Ирландия",
            Alpha2Code = "IE",
            Alpha3Code = "IRL",
            NumericCode = "372"
          },

          new Citizenship
          {
            Id = Guid.Parse("16a5bff5-e046-495b-972d-a15bd1edb223"),
            CountryName = "Isle of Man",
            CountryNameRu = "Остров Мэн",
            Alpha2Code = "IM",
            Alpha3Code = "IMN",
            NumericCode = "833"
          },

          new Citizenship
          {
            Id = Guid.Parse("57dbdb09-3c4c-4634-a836-30f35ae41cb9"),
            CountryName = "Israel",
            CountryNameRu = "Израиль",
            Alpha2Code = "IL",
            Alpha3Code = "ISR",
            NumericCode = "376"
          },

          new Citizenship
          {
            Id = Guid.Parse("94513ee2-78d1-43b6-9f00-78ed9bbd2aad"),
            CountryName = "Italy",
            CountryNameRu = "Италия",
            Alpha2Code = "IT",
            Alpha3Code = "ITA",
            NumericCode = "380"
          },

          new Citizenship
          {
            Id = Guid.Parse("725046fb-2aff-4457-a99e-e1329096d2f8"),
            CountryName = "Jamaica",
            CountryNameRu = "Ямайка",
            Alpha2Code = "JM",
            Alpha3Code = "JAM",
            NumericCode = "388"
          },

          new Citizenship
          {
            Id = Guid.Parse("c56cd567-0f56-4285-9c22-2c60f9db26bf"),
            CountryName = "Japan",
            CountryNameRu = "Япония",
            Alpha2Code = "JP",
            Alpha3Code = "JPN",
            NumericCode = "392"
          },

          new Citizenship
          {
            Id = Guid.Parse("ff27576d-ffc3-41b5-894c-9a0395b5bcdb"),
            CountryName = "Jersey",
            CountryNameRu = "Джерси",
            Alpha2Code = "JE",
            Alpha3Code = "JEY",
            NumericCode = "832"
          },

          new Citizenship
          {
            Id = Guid.Parse("449a032d-5f7b-4afd-9325-8dcc61a21bd8"),
            CountryName = "Jordan",
            CountryNameRu = "Иордания",
            Alpha2Code = "JO",
            Alpha3Code = "JOR",
            NumericCode = "400"
          },

          new Citizenship
          {
            Id = Guid.Parse("f43ae112-85da-445b-849e-ee75af6a7891"),
            CountryName = "Kazakhstan",
            CountryNameRu = "Казахстан",
            Alpha2Code = "KZ",
            Alpha3Code = "KAZ",
            NumericCode = "398"
          },

          new Citizenship
          {
            Id = Guid.Parse("f7f90a58-27e1-4ebb-8f36-ee8641a53f12"),
            CountryName = "Kenya",
            CountryNameRu = "Кения",
            Alpha2Code = "KE",
            Alpha3Code = "KEN",
            NumericCode = "404"
          },

          new Citizenship
          {
            Id = Guid.Parse("169d28c0-5643-4f02-a0d0-60b2375c191c"),
            CountryName = "Kiribati",
            CountryNameRu = "Кирибати",
            Alpha2Code = "KI",
            Alpha3Code = "KIR",
            NumericCode = "296"
          },

          new Citizenship
          {
            Id = Guid.Parse("6530c60e-1845-46e2-85ca-5a60e9028f88"),
            CountryName = "Korea (the Democratic People's Republic of)",
            CountryNameRu = "Корейская Народно-Демократическая Республика",
            Alpha2Code = "KP",
            Alpha3Code = "PRK",
            NumericCode = "408"
          },

          new Citizenship
          {
            Id = Guid.Parse("efa9ce44-1767-413d-b5e3-58eaf4d3af50"),
            CountryName = "Korea (the Republic of)",
            CountryNameRu = "Республика Корея",
            Alpha2Code = "KR",
            Alpha3Code = "KOR",
            NumericCode = "410"
          },

          new Citizenship
          {
            Id = Guid.Parse("8858f8e0-5a07-4610-a22a-da235f2025a4"),
            CountryName = "Kuwait",
            CountryNameRu = "Кувейт",
            Alpha2Code = "KW",
            Alpha3Code = "KWT",
            NumericCode = "414"
          },

          new Citizenship
          {
            Id = Guid.Parse("4930893f-a9a9-48c1-8835-62400232c6ca"),
            CountryName = "Kyrgyzstan",
            CountryNameRu = "Кыргызстан",
            Alpha2Code = "KG",
            Alpha3Code = "KGZ",
            NumericCode = "417"
          },

          new Citizenship
          {
            Id = Guid.Parse("f9aaa5bb-310f-4e12-985e-b822ae909a4b"),
            CountryName = "Lao People's Democratic Republic (the)",
            CountryNameRu = "Лаос",
            Alpha2Code = "LA",
            Alpha3Code = "LAO",
            NumericCode = "418"
          },

          new Citizenship
          {
            Id = Guid.Parse("ea069df4-99b1-463d-b5c7-059cf852d436"),
            CountryName = "Latvia",
            CountryNameRu = "Латвия",
            Alpha2Code = "LV",
            Alpha3Code = "LVA",
            NumericCode = "428"
          },

          new Citizenship
          {
            Id = Guid.Parse("01a7e699-741b-453c-9467-dde6ab0630c5"),
            CountryName = "Lebanon",
            CountryNameRu = "Ливан",
            Alpha2Code = "LB",
            Alpha3Code = "LBN",
            NumericCode = "422"
          },

          new Citizenship
          {
            Id = Guid.Parse("62731f20-a6a1-4638-b4cc-77f8a7e3366a"),
            CountryName = "Lesotho",
            CountryNameRu = "Лесото",
            Alpha2Code = "LS",
            Alpha3Code = "LSO",
            NumericCode = "426"
          },

          new Citizenship
          {
            Id = Guid.Parse("d858a032-1b3e-4fbd-a0b9-878bc200ade2"),
            CountryName = "Liberia",
            CountryNameRu = "Либерия",
            Alpha2Code = "LR",
            Alpha3Code = "LBR",
            NumericCode = "430"
          },

          new Citizenship
          {
            Id = Guid.Parse("0696dbaa-f112-4fbb-b077-c38de25f7708"),
            CountryName = "Libya",
            CountryNameRu = "Ливия",
            Alpha2Code = "LY",
            Alpha3Code = "LBY",
            NumericCode = "434"
          },

          new Citizenship
          {
            Id = Guid.Parse("60426dee-ed82-4f14-a2bb-af7398d5bfab"),
            CountryName = "Liechtenstein",
            CountryNameRu = "Лихтенштейн",
            Alpha2Code = "LI",
            Alpha3Code = "LIE",
            NumericCode = "438"
          },

          new Citizenship
          {
            Id = Guid.Parse("64a868cf-4447-4435-a79d-f76195d946c5"),
            CountryName = "Lithuania",
            CountryNameRu = "Литва",
            Alpha2Code = "LT",
            Alpha3Code = "LTU",
            NumericCode = "440"
          },

          new Citizenship
          {
            Id = Guid.Parse("44a1617a-8e06-4689-a9f9-06ae5f7e42ef"),
            CountryName = "Luxembourg",
            CountryNameRu = "Люксембург",
            Alpha2Code = "LU",
            Alpha3Code = "LUX",
            NumericCode = "442"
          },

          new Citizenship
          {
            Id = Guid.Parse("710b89e2-17c3-4f63-bdd2-55023eecacb6"),
            CountryName = "Macao",
            CountryNameRu = "Макао",
            Alpha2Code = "MO",
            Alpha3Code = "MAC",
            NumericCode = "446"
          },

          new Citizenship
          {
            Id = Guid.Parse("51c98211-9dfb-499d-8171-98a228ebc01b"),
            CountryName = "Madagascar",
            CountryNameRu = "Мадагаскар",
            Alpha2Code = "MG",
            Alpha3Code = "MDG",
            NumericCode = "450"
          },

          new Citizenship
          {
            Id = Guid.Parse("90601758-eae9-4120-86c1-eed159ac63d4"),
            CountryName = "Malawi",
            CountryNameRu = "Малави",
            Alpha2Code = "MW",
            Alpha3Code = "MWI",
            NumericCode = "454"
          },

          new Citizenship
          {
            Id = Guid.Parse("ced6b11c-2ebe-48fd-90d4-aec756b13939"),
            CountryName = "Malaysia",
            CountryNameRu = "Малайзия",
            Alpha2Code = "MY",
            Alpha3Code = "MYS",
            NumericCode = "458"
          },

          new Citizenship
          {
            Id = Guid.Parse("afd9433a-09ed-4511-a7dd-c05a9bdbca4a"),
            CountryName = "Maldives",
            CountryNameRu = "Мальдивы",
            Alpha2Code = "MV",
            Alpha3Code = "MDV",
            NumericCode = "462"
          },

          new Citizenship
          {
            Id = Guid.Parse("10d36d38-3964-4107-af4f-106b1c67d13a"),
            CountryName = "Mali",
            CountryNameRu = "Мали",
            Alpha2Code = "ML",
            Alpha3Code = "MLI",
            NumericCode = "466"
          },

          new Citizenship
          {
            Id = Guid.Parse("44c91d1f-9133-478f-8664-33edb2a41a6f"),
            CountryName = "Malta",
            CountryNameRu = "Мальта",
            Alpha2Code = "MT",
            Alpha3Code = "MLT",
            NumericCode = "470"
          },

          new Citizenship
          {
            Id = Guid.Parse("5f0ba0ee-5220-4b49-9bb4-2c76f2b6155a"),
            CountryName = "Marshall Islands (the)",
            CountryNameRu = "Маршалловы Острова",
            Alpha2Code = "MH",
            Alpha3Code = "MHL",
            NumericCode = "584"
          },

          new Citizenship
          {
            Id = Guid.Parse("f1432f8b-184e-4ca3-9501-cb4fb2ae6c8a"),
            CountryName = "Martinique",
            CountryNameRu = "Мартиника",
            Alpha2Code = "MQ",
            Alpha3Code = "MTQ",
            NumericCode = "474"
          },

          new Citizenship
          {
            Id = Guid.Parse("883108a9-3cfc-4c91-90e9-30ecf6540ea8"),
            CountryName = "Mauritania",
            CountryNameRu = "Мавритания",
            Alpha2Code = "MR",
            Alpha3Code = "MRT",
            NumericCode = "478"
          },

          new Citizenship
          {
            Id = Guid.Parse("0bb0fe89-95ea-4478-9039-33067aec0c2e"),
            CountryName = "Mauritius",
            CountryNameRu = "Маврикий",
            Alpha2Code = "MU",
            Alpha3Code = "MUS",
            NumericCode = "480"
          },

          new Citizenship
          {
            Id = Guid.Parse("c0683c57-f78b-4e22-9212-17907417ca0a"),
            CountryName = "Mayotte",
            CountryNameRu = "Майотта",
            Alpha2Code = "YT",
            Alpha3Code = "MYT",
            NumericCode = "175"
          },

          new Citizenship
          {
            Id = Guid.Parse("829475cf-791d-457e-a9ea-fff4772db388"),
            CountryName = "Mexico",
            CountryNameRu = "Мексика",
            Alpha2Code = "MX",
            Alpha3Code = "MEX",
            NumericCode = "484"
          },

          new Citizenship
          {
            Id = Guid.Parse("bca1a91c-c859-4771-bc68-aa6decfcbccb"),
            CountryName = "Micronesia (Federated States of)",
            CountryNameRu = "Федеративные Штаты Микронезии",
            Alpha2Code = "FM",
            Alpha3Code = "FSM",
            NumericCode = "583"
          },

          new Citizenship
          {
            Id = Guid.Parse("66cef14b-89e5-436f-91ae-a3cfeb19a7c8"),
            CountryName = "Moldova (the Republic of)",
            CountryNameRu = "Молдова",
            Alpha2Code = "MD",
            Alpha3Code = "MDA",
            NumericCode = "498"
          },

          new Citizenship
          {
            Id = Guid.Parse("a4e32f03-3071-470a-a508-b5a1e6dc995f"),
            CountryName = "Monaco",
            CountryNameRu = "Монако",
            Alpha2Code = "MC",
            Alpha3Code = "MCO",
            NumericCode = "492"
          },

          new Citizenship
          {
            Id = Guid.Parse("5ef34c65-58bb-44b0-b519-3b4ca5f672ba"),
            CountryName = "Mongolia",
            CountryNameRu = "Монголия",
            Alpha2Code = "MN",
            Alpha3Code = "MNG",
            NumericCode = "496"
          },

          new Citizenship
          {
            Id = Guid.Parse("aae85562-69f5-4acf-a63a-22e50b879690"),
            CountryName = "Montenegro",
            CountryNameRu = "Черногория",
            Alpha2Code = "ME",
            Alpha3Code = "MNE",
            NumericCode = "499"
          },

          new Citizenship
          {
            Id = Guid.Parse("f2d1bc91-751e-438c-8102-0f09bc0a3f6e"),
            CountryName = "Montserrat",
            CountryNameRu = "Монтсеррат",
            Alpha2Code = "MS",
            Alpha3Code = "MSR",
            NumericCode = "500"
          },

          new Citizenship
          {
            Id = Guid.Parse("25e0c537-86cf-4aa6-a013-e861c4505fd9"),
            CountryName = "Morocco",
            CountryNameRu = "Марокко",
            Alpha2Code = "MA",
            Alpha3Code = "MAR",
            NumericCode = "504"
          },

          new Citizenship
          {
            Id = Guid.Parse("6af0358f-41a7-4380-bdfd-6b700fab2db4"),
            CountryName = "Mozambique",
            CountryNameRu = "Мозамбик",
            Alpha2Code = "MZ",
            Alpha3Code = "MOZ",
            NumericCode = "508"
          },

          new Citizenship
          {
            Id = Guid.Parse("f8d4e30d-4f1d-4638-b469-486d5e123b37"),
            CountryName = "Myanmar",
            CountryNameRu = "Мьянма",
            Alpha2Code = "MM",
            Alpha3Code = "MMR",
            NumericCode = "104"
          },

          new Citizenship
          {
            Id = Guid.Parse("39208975-8ef5-4111-bb65-f13dbfebaed7"),
            CountryName = "Namibia",
            CountryNameRu = "Намибия",
            Alpha2Code = "NA",
            Alpha3Code = "NAM",
            NumericCode = "516"
          },

          new Citizenship
          {
            Id = Guid.Parse("b54c1abf-b23a-4592-857a-3c415ef3186e"),
            CountryName = "Nauru",
            CountryNameRu = "Науру",
            Alpha2Code = "NR",
            Alpha3Code = "NRU",
            NumericCode = "520"
          },

          new Citizenship
          {
            Id = Guid.Parse("eb0196bb-644e-49ad-849d-f1aefbe1f32b"),
            CountryName = "Nepal",
            CountryNameRu = "Непал",
            Alpha2Code = "NP",
            Alpha3Code = "NPL",
            NumericCode = "524"
          },

          new Citizenship
          {
            Id = Guid.Parse("50da5e0c-61e2-48d4-8e53-5c120e2a267c"),
            CountryName = "Netherlands (the)",
            CountryNameRu = "Нидерланды",
            Alpha2Code = "NL",
            Alpha3Code = "NLD",
            NumericCode = "528"
          },

          new Citizenship
          {
            Id = Guid.Parse("03385e00-331f-4e1b-960f-0c0bd9addddf"),
            CountryName = "New Caledonia",
            CountryNameRu = "Новая Каледония",
            Alpha2Code = "NC",
            Alpha3Code = "NCL",
            NumericCode = "540"
          },

          new Citizenship
          {
            Id = Guid.Parse("7ecfd587-68fd-4090-b480-a7c2d16d88f1"),
            CountryName = "New Zealand",
            CountryNameRu = "Новая Зеландия",
            Alpha2Code = "NZ",
            Alpha3Code = "NZL",
            NumericCode = "554"
          },

          new Citizenship
          {
            Id = Guid.Parse("360f3e07-4e80-44c8-ac28-10294133afe0"),
            CountryName = "Nicaragua",
            CountryNameRu = "Никарагуа",
            Alpha2Code = "NI",
            Alpha3Code = "NIC",
            NumericCode = "558"
          },

          new Citizenship
          {
            Id = Guid.Parse("b67fdd6e-b4f2-4ac4-9afb-45fb83472053"),
            CountryName = "Niger (the)",
            CountryNameRu = "Нигер",
            Alpha2Code = "NE",
            Alpha3Code = "NER",
            NumericCode = "562"
          },

          new Citizenship
          {
            Id = Guid.Parse("c56e0297-6eb7-4c5d-9147-ccb75eb5487a"),
            CountryName = "Nigeria",
            CountryNameRu = "Нигерия",
            Alpha2Code = "NG",
            Alpha3Code = "NGA",
            NumericCode = "566"
          },

          new Citizenship
          {
            Id = Guid.Parse("9c95fb0d-c397-4f4b-b223-e047e601ab49"),
            CountryName = "Niue",
            CountryNameRu = "Ниуэ",
            Alpha2Code = "NU",
            Alpha3Code = "NIU",
            NumericCode = "570"
          },

          new Citizenship
          {
            Id = Guid.Parse("f52f650e-51e1-4d5a-b984-82fcf4386bbf"),
            CountryName = "Norfolk Island",
            CountryNameRu = "Остров Норфолк",
            Alpha2Code = "NF",
            Alpha3Code = "NFK",
            NumericCode = "574"
          },

          new Citizenship
          {
            Id = Guid.Parse("3e03199f-1b01-46a6-b4a5-eea64cd8305b"),
            CountryName = "Northern Mariana Islands (the)",
            CountryNameRu = "Северные Марианские острова",
            Alpha2Code = "MP",
            Alpha3Code = "MNP",
            NumericCode = "580"
          },

          new Citizenship
          {
            Id = Guid.Parse("34fd1952-3777-438c-a3b5-a1f099c4294d"),
            CountryName = "Norway",
            CountryNameRu = "Норвегия",
            Alpha2Code = "NO",
            Alpha3Code = "NOR",
            NumericCode = "578"
          },

          new Citizenship
          {
            Id = Guid.Parse("eac4d959-64db-41ee-95f4-db2d4d15cf05"),
            CountryName = "Oman",
            CountryNameRu = "Оман",
            Alpha2Code = "OM",
            Alpha3Code = "OMN",
            NumericCode = "512"
          },

          new Citizenship
          {
            Id = Guid.Parse("30f6e790-dc76-44a8-be1c-2a987325a247"),
            CountryName = "Pakistan",
            CountryNameRu = "Пакистан",
            Alpha2Code = "PK",
            Alpha3Code = "PAK",
            NumericCode = "586"
          },

          new Citizenship
          {
            Id = Guid.Parse("e6fabb92-6a05-4256-899b-4f66214c427a"),
            CountryName = "Palau",
            CountryNameRu = "Палау",
            Alpha2Code = "PW",
            Alpha3Code = "PLW",
            NumericCode = "585"
          },

          new Citizenship
          {
            Id = Guid.Parse("303bcf26-1ad0-47b0-ada5-b1c6a8bc4fbc"),
            CountryName = "Palestine, State of",
            CountryNameRu = "Государство Палестина",
            Alpha2Code = "PS",
            Alpha3Code = "PSE",
            NumericCode = "275"
          },

          new Citizenship
          {
            Id = Guid.Parse("8aa3ee18-b2b2-4945-9f52-5b0fc8ac2210"),
            CountryName = "Panama",
            CountryNameRu = "Панама",
            Alpha2Code = "PA",
            Alpha3Code = "PAN",
            NumericCode = "591"
          },

          new Citizenship
          {
            Id = Guid.Parse("9e36c5ce-e59b-40c4-8ff4-fa2985786c2c"),
            CountryName = "Papua New Guinea",
            CountryNameRu = "Папуа - Новая Гвинея",
            Alpha2Code = "PG",
            Alpha3Code = "PNG",
            NumericCode = "598"
          },

          new Citizenship
          {
            Id = Guid.Parse("f5119197-fbf9-428e-8afb-8dce1cfaccf3"),
            CountryName = "Paraguay",
            CountryNameRu = "Парагвай",
            Alpha2Code = "PY",
            Alpha3Code = "PRY",
            NumericCode = "600"
          },

          new Citizenship
          {
            Id = Guid.Parse("5031b4e7-6312-4207-a46e-a976be546742"),
            CountryName = "Peru",
            CountryNameRu = "Перу",
            Alpha2Code = "PE",
            Alpha3Code = "PER",
            NumericCode = "604"
          },

          new Citizenship
          {
            Id = Guid.Parse("9037d089-f4a8-4a4f-8526-c81a1bfc3b87"),
            CountryName = "Philippines (the)",
            CountryNameRu = "Филиппины",
            Alpha2Code = "PH",
            Alpha3Code = "PHL",
            NumericCode = "608"
          },

          new Citizenship
          {
            Id = Guid.Parse("126f137e-08e2-44b8-8521-3100e837bc96"),
            CountryName = "Pitcairn",
            CountryNameRu = "Питкэрн",
            Alpha2Code = "PN",
            Alpha3Code = "PCN",
            NumericCode = "612"
          },

          new Citizenship
          {
            Id = Guid.Parse("4179572d-ac9a-4421-aeaa-bd1513d5d512"),
            CountryName = "Poland",
            CountryNameRu = "Польша",
            Alpha2Code = "PL",
            Alpha3Code = "POL",
            NumericCode = "616"
          },

          new Citizenship
          {
            Id = Guid.Parse("dc4511de-4603-42aa-ae83-d8158738d052"),
            CountryName = "Portugal",
            CountryNameRu = "Португалия",
            Alpha2Code = "PT",
            Alpha3Code = "PRT",
            NumericCode = "620"
          },

          new Citizenship
          {
            Id = Guid.Parse("7d69bc63-1bbc-44cf-9525-71d6a910b276"),
            CountryName = "Puerto Rico",
            CountryNameRu = "Пуэрто-Рико",
            Alpha2Code = "PR",
            Alpha3Code = "PRI",
            NumericCode = "630"
          },

          new Citizenship
          {
            Id = Guid.Parse("3bd7af08-2977-4e7b-9214-083e76e1d9b6"),
            CountryName = "Qatar",
            CountryNameRu = "Катар",
            Alpha2Code = "QA",
            Alpha3Code = "QAT",
            NumericCode = "634"
          },

          new Citizenship
          {
            Id = Guid.Parse("234297a1-0fb7-4081-ac5e-44ce80a70259"),
            CountryName = "Republic of North Macedonia",
            CountryNameRu = "Северная Македония",
            Alpha2Code = "MK",
            Alpha3Code = "MKD",
            NumericCode = "807"
          },

          new Citizenship
          {
            Id = Guid.Parse("199603a0-62de-4e93-8931-bf61b43a09d1"),
            CountryName = "Romania",
            CountryNameRu = "Румыния",
            Alpha2Code = "RO",
            Alpha3Code = "ROU",
            NumericCode = "642"
          },

          new Citizenship
          {
            Id = Guid.Parse("1cbca6a4-dfbc-4d90-9758-0e87a66293b9"),
            CountryName = "Russian Federation (the)",
            CountryNameRu = "Российская Федерация",
            Alpha2Code = "RU",
            Alpha3Code = "RUS",
            NumericCode = "643"
          },

          new Citizenship
          {
            Id = Guid.Parse("b6fafb19-cc07-407f-bb99-87f43f04430e"),
            CountryName = "Rwanda",
            CountryNameRu = "Руанда",
            Alpha2Code = "RW",
            Alpha3Code = "RWA",
            NumericCode = "646"
          },

          new Citizenship
          {
            Id = Guid.Parse("097754f4-f1cf-4d0a-a8c5-a1eb4286efd2"),
            CountryName = "Reunion",
            CountryNameRu = "Реюньон",
            Alpha2Code = "RE",
            Alpha3Code = "REU",
            NumericCode = "638"
          },

          new Citizenship
          {
            Id = Guid.Parse("7916cfa5-b000-4b7d-8634-123aef1714b4"),
            CountryName = "Saint Barthelemy",
            CountryNameRu = "Сен-Бартелеми",
            Alpha2Code = "BL",
            Alpha3Code = "BLM",
            NumericCode = "652"
          },

          new Citizenship
          {
            Id = Guid.Parse("aa88db7f-8565-4a61-9c9a-092e4ebd3953"),
            CountryName = "Saint Helena, Ascension and Tristan da Cunha",
            CountryNameRu = "Остров Святой Елены, Вознесения и Тристан-да-Кунья",
            Alpha2Code = "SH",
            Alpha3Code = "SHN",
            NumericCode = "654"
          },

          new Citizenship
          {
            Id = Guid.Parse("d16bf78c-3af3-4900-8a73-4f02ae5aff2b"),
            CountryName = "Saint Kitts and Nevis",
            CountryNameRu = "Сент-Китс и Невис",
            Alpha2Code = "KN",
            Alpha3Code = "KNA",
            NumericCode = "659"
          },

          new Citizenship
          {
            Id = Guid.Parse("b21d5c23-bfd6-43c1-85a1-11f180553913"),
            CountryName = "Saint Lucia",
            CountryNameRu = "Сент-Люсия",
            Alpha2Code = "LC",
            Alpha3Code = "LCA",
            NumericCode = "662"
          },

          new Citizenship
          {
            Id = Guid.Parse("4cc2f590-e46e-4ef5-8e9f-5aa0c73954ef"),
            CountryName = "Saint Martin (French part)",
            CountryNameRu = "Сен-Мартен (французская часть)",
            Alpha2Code = "MF",
            Alpha3Code = "MAF",
            NumericCode = "663"
          },

          new Citizenship
          {
            Id = Guid.Parse("4ad2da45-29ff-467e-9a53-52912c3ecf5a"),
            CountryName = "Saint Pierre and Miquelon",
            CountryNameRu = "Сен-Пьер и Микелон",
            Alpha2Code = "PM",
            Alpha3Code = "SPM",
            NumericCode = "666"
          },

          new Citizenship
          {
            Id = Guid.Parse("6c909cc7-7223-4ed5-ad08-ec7408f5e44d"),
            CountryName = "Saint Vincent and the Grenadines",
            CountryNameRu = "Сент-Винсент и Гренадины",
            Alpha2Code = "VC",
            Alpha3Code = "VCT",
            NumericCode = "670"
          },

          new Citizenship
          {
            Id = Guid.Parse("f2026d3b-ab65-4c92-8ae6-867c10185a0d"),
            CountryName = "Samoa",
            CountryNameRu = "Самоа",
            Alpha2Code = "WS",
            Alpha3Code = "WSM",
            NumericCode = "882"
          },

          new Citizenship
          {
            Id = Guid.Parse("5e15b6e1-91b3-498a-b2b3-91f451575256"),
            CountryName = "San Marino",
            CountryNameRu = "Сан-Марино",
            Alpha2Code = "SM",
            Alpha3Code = "SMR",
            NumericCode = "674"
          },

          new Citizenship
          {
            Id = Guid.Parse("344a81dd-3ee9-4180-ad4d-734091158767"),
            CountryName = "Sao Tome and Principe",
            CountryNameRu = "Сан-Томе и Принсипи",
            Alpha2Code = "ST",
            Alpha3Code = "STP",
            NumericCode = "678"
          },

          new Citizenship
          {
            Id = Guid.Parse("ce2041ae-4ba0-4fe4-b49a-0d5dd3a8d30f"),
            CountryName = "Saudi Arabia",
            CountryNameRu = "Саудовская Аравия",
            Alpha2Code = "SA",
            Alpha3Code = "SAU",
            NumericCode = "682"
          },

          new Citizenship
          {
            Id = Guid.Parse("d8d404e9-1e8f-46f9-9918-f39ce5d0153c"),
            CountryName = "Senegal",
            CountryNameRu = "Сенегал",
            Alpha2Code = "SN",
            Alpha3Code = "SEN",
            NumericCode = "686"
          },

          new Citizenship
          {
            Id = Guid.Parse("2ba75bfb-4615-43c5-9023-3313edc4709b"),
            CountryName = "Serbia",
            CountryNameRu = "Сербия",
            Alpha2Code = "RS",
            Alpha3Code = "SRB",
            NumericCode = "688"
          },

          new Citizenship
          {
            Id = Guid.Parse("03fa2aa8-5cd3-44de-899b-a6944eff9f51"),
            CountryName = "Seychelles",
            CountryNameRu = "Сейшельские Острова",
            Alpha2Code = "SC",
            Alpha3Code = "SYC",
            NumericCode = "690"
          },

          new Citizenship
          {
            Id = Guid.Parse("5fd6ae77-db9a-4891-9802-355b697edf13"),
            CountryName = "Sierra Leone",
            CountryNameRu = "Сьерра-Леоне",
            Alpha2Code = "SL",
            Alpha3Code = "SLE",
            NumericCode = "694"
          },

          new Citizenship
          {
            Id = Guid.Parse("e4be36b3-7841-4a65-8abd-11b5fa1b8c16"),
            CountryName = "Singapore",
            CountryNameRu = "Сингапур",
            Alpha2Code = "SG",
            Alpha3Code = "SGP",
            NumericCode = "702"
          },

          new Citizenship
          {
            Id = Guid.Parse("83b2db8d-7d08-435b-b6d8-89f4db353395"),
            CountryName = "Sint Maarten (Dutch part)",
            CountryNameRu = "Синт-Мартен (нидерландская часть)",
            Alpha2Code = "SX",
            Alpha3Code = "SXM",
            NumericCode = "534"
          },

          new Citizenship
          {
            Id = Guid.Parse("c434dc87-51d6-48ed-8da5-b504a8a783ca"),
            CountryName = "Slovakia",
            CountryNameRu = "Словакия",
            Alpha2Code = "SK",
            Alpha3Code = "SVK",
            NumericCode = "703"
          },

          new Citizenship
          {
            Id = Guid.Parse("1a175d25-852c-4523-b448-3f5ebea13928"),
            CountryName = "Slovenia",
            CountryNameRu = "Словения",
            Alpha2Code = "SI",
            Alpha3Code = "SVN",
            NumericCode = "705"
          },

          new Citizenship
          {
            Id = Guid.Parse("0fa32ea3-ab78-4ef4-aaa3-5bfc0b0e9d05"),
            CountryName = "Solomon Islands",
            CountryNameRu = "Соломоновы Острова",
            Alpha2Code = "SB",
            Alpha3Code = "SLB",
            NumericCode = "090"
          },

          new Citizenship
          {
            Id = Guid.Parse("e57305f2-0555-46fb-9c33-54ce426c1237"),
            CountryName = "Somalia",
            CountryNameRu = "Сомали",
            Alpha2Code = "SO",
            Alpha3Code = "SOM",
            NumericCode = "706"
          },

          new Citizenship
          {
            Id = Guid.Parse("d75990bf-70df-49f2-bed3-db021e7bf05e"),
            CountryName = "South Africa",
            CountryNameRu = "Южно-Африканская Республика",
            Alpha2Code = "ZA",
            Alpha3Code = "ZAF",
            NumericCode = "710"
          },

          new Citizenship
          {
            Id = Guid.Parse("2af18e63-9ba1-4414-9013-2ab8b6ac562e"),
            CountryName = "South Georgia and the South Sandwich Islands",
            CountryNameRu = "Южная Георгия и Южные Сандвичевы острова",
            Alpha2Code = "GS",
            Alpha3Code = "SGS",
            NumericCode = "239"
          },

          new Citizenship
          {
            Id = Guid.Parse("9a39bacc-92e5-4393-997f-08a114f0778b"),
            CountryName = "South Sudan",
            CountryNameRu = "Южный Судан",
            Alpha2Code = "SS",
            Alpha3Code = "SSD",
            NumericCode = "728"
          },

          new Citizenship
          {
            Id = Guid.Parse("9d03ab08-eab7-4631-9e95-45828723e868"),
            CountryName = "Spain",
            CountryNameRu = "Испания",
            Alpha2Code = "ES",
            Alpha3Code = "ESP",
            NumericCode = "724"
          },

          new Citizenship
          {
            Id = Guid.Parse("ad7a35cf-b631-4ea2-bf1a-090d0512ec81"),
            CountryName = "Sri Lanka",
            CountryNameRu = "Шри-Ланка",
            Alpha2Code = "LK",
            Alpha3Code = "LKA",
            NumericCode = "144"
          },

          new Citizenship
          {
            Id = Guid.Parse("85a8614d-7a6c-4c4a-b696-8a2c4def1945"),
            CountryName = "Sudan (the)",
            CountryNameRu = "Судан",
            Alpha2Code = "SD",
            Alpha3Code = "SDN",
            NumericCode = "729"
          },

          new Citizenship
          {
            Id = Guid.Parse("55bdeb07-3b49-43cf-b029-ffda1ed3e656"),
            CountryName = "Suriname",
            CountryNameRu = "Суринам",
            Alpha2Code = "SR",
            Alpha3Code = "SUR",
            NumericCode = "740"
          },

          new Citizenship
          {
            Id = Guid.Parse("dd7955b8-d10b-4426-a648-5a29158737e1"),
            CountryName = "Svalbard and Jan Mayen",
            CountryNameRu = "Шпицберген и Ян-Майен",
            Alpha2Code = "SJ",
            Alpha3Code = "SJM",
            NumericCode = "744"
          },

          new Citizenship
          {
            Id = Guid.Parse("497c4882-13a6-4854-8115-d971b63f7d79"),
            CountryName = "Sweden",
            CountryNameRu = "Швеция",
            Alpha2Code = "SE",
            Alpha3Code = "SWE",
            NumericCode = "752"
          },

          new Citizenship
          {
            Id = Guid.Parse("94b8785a-4691-4b57-afb5-a8fad1766bde"),
            CountryName = "Switzerland",
            CountryNameRu = "Швейцария",
            Alpha2Code = "CH",
            Alpha3Code = "CHE",
            NumericCode = "756"
          },

          new Citizenship
          {
            Id = Guid.Parse("aec434a1-de10-48a6-8a42-8583ca7ff603"),
            CountryName = "Syrian Arab Republic",
            CountryNameRu = "Сирийская Арабская Республика",
            Alpha2Code = "SY",
            Alpha3Code = "SYR",
            NumericCode = "760"
          },

          new Citizenship
          {
            Id = Guid.Parse("6f61388c-7b34-4f7b-987c-5e8fc42ee04c"),
            CountryName = "Taiwan (Province of China)",
            CountryNameRu = "Тайвань",
            Alpha2Code = "TW",
            Alpha3Code = "TWN",
            NumericCode = "158"
          },

          new Citizenship
          {
            Id = Guid.Parse("b0bd4c86-9a58-4504-af03-6d722ef34f8b"),
            CountryName = "Tajikistan",
            CountryNameRu = "Таджикистан",
            Alpha2Code = "TJ",
            Alpha3Code = "TJK",
            NumericCode = "762"
          },

          new Citizenship
          {
            Id = Guid.Parse("88303ea3-e7ec-4fae-9365-d6e251f756fb"),
            CountryName = "Tanzania, United Republic of",
            CountryNameRu = "Танзания",
            Alpha2Code = "TZ",
            Alpha3Code = "TZA",
            NumericCode = "834"
          },

          new Citizenship
          {
            Id = Guid.Parse("c6063457-9024-4bc5-9f34-4f9ae35b5243"),
            CountryName = "Thailand",
            CountryNameRu = "Таиланд",
            Alpha2Code = "TH",
            Alpha3Code = "THA",
            NumericCode = "764"
          },

          new Citizenship
          {
            Id = Guid.Parse("6bd260ce-a3f6-4f9e-a12a-97098e7b3ad5"),
            CountryName = "Timor-Leste",
            CountryNameRu = "Восточный Тимор",
            Alpha2Code = "TL",
            Alpha3Code = "TLS",
            NumericCode = "626"
          },

          new Citizenship
          {
            Id = Guid.Parse("25d6c0e2-5ce6-4ae7-b5e3-2f92c5f7be52"),
            CountryName = "Togo",
            CountryNameRu = "Того",
            Alpha2Code = "TG",
            Alpha3Code = "TGO",
            NumericCode = "768"
          },

          new Citizenship
          {
            Id = Guid.Parse("87fe60ee-c120-498a-a503-e13ec638e429"),
            CountryName = "Tokelau",
            CountryNameRu = "Токелау",
            Alpha2Code = "TK",
            Alpha3Code = "TKL",
            NumericCode = "772"
          },

          new Citizenship
          {
            Id = Guid.Parse("8efb2b4a-1e8e-4596-ab2d-464fafa06906"),
            CountryName = "Tonga",
            CountryNameRu = "Тонга",
            Alpha2Code = "TO",
            Alpha3Code = "TON",
            NumericCode = "776"
          },

          new Citizenship
          {
            Id = Guid.Parse("a58e9df6-2679-4f4b-85f2-b5be1d040aa2"),
            CountryName = "Trinidad and Tobago",
            CountryNameRu = "Тринидад и Тобаго",
            Alpha2Code = "TT",
            Alpha3Code = "TTO",
            NumericCode = "780"
          },

          new Citizenship
          {
            Id = Guid.Parse("c82b5e24-9083-409c-acab-de1ef0c7d1dc"),
            CountryName = "Tunisia",
            CountryNameRu = "Тунис",
            Alpha2Code = "TN",
            Alpha3Code = "TUN",
            NumericCode = "788"
          },

          new Citizenship
          {
            Id = Guid.Parse("07b02a75-95a3-4bfc-88ab-d7f0da2ef107"),
            CountryName = "Turkey",
            CountryNameRu = "Турция",
            Alpha2Code = "TR",
            Alpha3Code = "TUR",
            NumericCode = "792"
          },

          new Citizenship
          {
            Id = Guid.Parse("4deb6639-2d76-4a9a-9b53-a1d31ea4211f"),
            CountryName = "Turkmenistan",
            CountryNameRu = "Туркменистан",
            Alpha2Code = "TM",
            Alpha3Code = "TKM",
            NumericCode = "795"
          },

          new Citizenship
          {
            Id = Guid.Parse("7661ad26-3574-468e-a3c5-db6b83aebd28"),
            CountryName = "Turks and Caicos Islands (the)",
            CountryNameRu = "Тёркс и Кайкос",
            Alpha2Code = "TC",
            Alpha3Code = "TCA",
            NumericCode = "796"
          },

          new Citizenship
          {
            Id = Guid.Parse("3ab7951c-b6a3-4f44-a33e-9ede3d7cdf20"),
            CountryName = "Tuvalu",
            CountryNameRu = "Тувалу",
            Alpha2Code = "TV",
            Alpha3Code = "TUV",
            NumericCode = "798"
          },

          new Citizenship
          {
            Id = Guid.Parse("569d0dde-d61d-4ae8-9651-1e5e5f8ee795"),
            CountryName = "Uganda",
            CountryNameRu = "Уганда",
            Alpha2Code = "UG",
            Alpha3Code = "UGA",
            NumericCode = "800"
          },

          new Citizenship
          {
            Id = Guid.Parse("5766be3e-6e2e-4f12-9717-453a19461382"),
            CountryName = "Ukraine",
            CountryNameRu = "Украина",
            Alpha2Code = "UA",
            Alpha3Code = "UKR",
            NumericCode = "804"
          },

          new Citizenship
          {
            Id = Guid.Parse("a28cc504-35c4-481f-9ddd-297e3f1c156e"),
            CountryName = "United Arab Emirates (the)",
            CountryNameRu = "Объединённые Арабские Эмираты",
            Alpha2Code = "AE",
            Alpha3Code = "ARE",
            NumericCode = "784"
          },

          new Citizenship
          {
            Id = Guid.Parse("0d46e0d1-7fbd-4b7a-860a-13f123e8268e"),
            CountryName = "United Kingdom of Great Britain and Northern Ireland (the)",
            CountryNameRu = "Великобритания",
            Alpha2Code = "GB",
            Alpha3Code = "GBR",
            NumericCode = "826"
          },

          new Citizenship
          {
            Id = Guid.Parse("eba05bac-e226-4611-9049-365855c14237"),
            CountryName = "United States Minor Outlying Islands (the)",
            CountryNameRu = "Внешние малые острова (США)",
            Alpha2Code = "UM",
            Alpha3Code = "UMI",
            NumericCode = "581"
          },

          new Citizenship
          {
            Id = Guid.Parse("a732e6d1-2384-4960-8657-8a27718d5226"),
            CountryName = "United States of America (the)",
            CountryNameRu = "США",
            Alpha2Code = "US",
            Alpha3Code = "USA",
            NumericCode = "840"
          },

          new Citizenship
          {
            Id = Guid.Parse("8f39f75c-aa63-473e-90e0-d09c043c9ce1"),
            CountryName = "Uruguay",
            CountryNameRu = "Уругвай",
            Alpha2Code = "UY",
            Alpha3Code = "URY",
            NumericCode = "858"
          },

          new Citizenship
          {
            Id = Guid.Parse("08de58df-e742-4b79-a873-ae8b8752330e"),
            CountryName = "Uzbekistan",
            CountryNameRu = "Узбекистан",
            Alpha2Code = "UZ",
            Alpha3Code = "UZB",
            NumericCode = "860"
          },

          new Citizenship
          {
            Id = Guid.Parse("d16600e1-38cc-4278-88de-59f2043f595b"),
            CountryName = "Vanuatu",
            CountryNameRu = "Вануату",
            Alpha2Code = "VU",
            Alpha3Code = "VUT",
            NumericCode = "548"
          },

          new Citizenship
          {
            Id = Guid.Parse("e1f71d77-7578-4c7e-b420-faa02692818b"),
            CountryName = "Venezuela (Bolivarian Republic of)",
            CountryNameRu = "Венесуэла",
            Alpha2Code = "VE",
            Alpha3Code = "VEN",
            NumericCode = "862"
          },

          new Citizenship
          {
            Id = Guid.Parse("bd44c19d-2e2a-46fc-b63e-062b3115050f"),
            CountryName = "Viet Nam",
            CountryNameRu = "Вьетнам",
            Alpha2Code = "VN",
            Alpha3Code = "VNM",
            NumericCode = "704"
          },

          new Citizenship
          {
            Id = Guid.Parse("1ced5721-dafe-4125-b20e-c4725d2688d4"),
            CountryName = "Virgin Islands (British)",
            CountryNameRu = "Британские Виргинские острова",
            Alpha2Code = "VG",
            Alpha3Code = "VGB",
            NumericCode = "092"
          },

          new Citizenship
          {
            Id = Guid.Parse("114a6e62-d6d6-4af5-be4c-aa9d6b7ed33e"),
            CountryName = "Virgin Islands (U.S.)",
            CountryNameRu = "Американские Виргинские острова",
            Alpha2Code = "VI",
            Alpha3Code = "VIR",
            NumericCode = "850"
          },

          new Citizenship
          {
            Id = Guid.Parse("a0bbfbce-7374-49d6-8146-a0e1d320c061"),
            CountryName = "Wallis and Futuna",
            CountryNameRu = "Уоллис и Футуна",
            Alpha2Code = "WF",
            Alpha3Code = "WLF",
            NumericCode = "876"
          },

          new Citizenship
          {
            Id = Guid.Parse("e33c1e61-4584-43c8-9ee5-258bcdc78715"),
            CountryName = "Western Sahara",
            CountryNameRu = "Западная Сахара",
            Alpha2Code = "EH",
            Alpha3Code = "ESH",
            NumericCode = "732"
          },

          new Citizenship
          {
            Id = Guid.Parse("3a72e6a7-fdd7-4f39-9bcc-8ee4b9ef95ba"),
            CountryName = "Yemen",
            CountryNameRu = "Йемен",
            Alpha2Code = "YE",
            Alpha3Code = "YEM",
            NumericCode = "887"
          },

          new Citizenship
          {
            Id = Guid.Parse("35fd823a-354f-458e-84e8-d0e951dc0c45"),
            CountryName = "Zambia",
            CountryNameRu = "Замбия",
            Alpha2Code = "ZM",
            Alpha3Code = "ZMB",
            NumericCode = "894"
          },

          new Citizenship
          {
            Id = Guid.Parse("6f8900d9-6cfd-4f4e-8b1e-3d1407402ba7"),
            CountryName = "Zimbabwe",
            CountryNameRu = "Зимбабве",
            Alpha2Code = "ZW",
            Alpha3Code = "ZWE",
            NumericCode = "716"
          },

          new Citizenship
          {
            Id = Guid.Parse("33a9cefa-65b0-4f3b-969f-fd82a1247780"),
            CountryName = "Aland Islands",
            CountryNameRu = "Аландские острова",
            Alpha2Code = "AX",
            Alpha3Code = "ALA",
            NumericCode = "248"
          }
      );
    }
  }
}
