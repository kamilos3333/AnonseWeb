namespace AnonseWeb.Data.Migrations
{
    using AnonseWeb.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AnonseWeb.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AnonseWeb.Data.ApplicationDbContext context)
        {
            var city = new List<City>
            {
                new City() { CityId = 1, CityName = "Bia³ystok" },
                new City() { CityId = 2, CityName = "Suwa³ki" },
                new City() { CityId = 3, CityName = "£om¿a" },
                new City() { CityId = 4, CityName = "Augustów" },
                new City() { CityId = 5, CityName = "Bielsk Podlaski" },
                new City() { CityId = 6, CityName = "Zambrów" },
                new City() { CityId = 7, CityName = "Grajewo" },
                new City() { CityId = 8, CityName = "Hajnówka" },
                new City() { CityId = 9, CityName = "Sokó³ka" },
                new City() { CityId = 10, CityName = "£apy" },
                new City() { CityId = 11, CityName = "Siemiatycze" },
                new City() { CityId = 12, CityName = "Wasilków" },
                new City() { CityId = 13, CityName = "Kolno" },
                new City() { CityId = 14, CityName = "Moñki" },
                new City() { CityId = 15, CityName = "Czarna Bia³ostocka" },
                new City() { CityId = 16, CityName = "Wysokie Mazowieckie" },
                new City() { CityId = 17, CityName = "Choroszcz" },
                new City() { CityId = 18, CityName = "D¹browa Bia³ostocka" },
                new City() { CityId = 19, CityName = "Sejny" },
                new City() { CityId = 20, CityName = "Ciechanowiec" },
                new City() { CityId = 21, CityName = "Supraœl" },
                new City() { CityId = 22, CityName = "Brañsk" },
                new City() { CityId = 23, CityName = "Szczuczyn" },
                new City() { CityId = 24, CityName = "Micha³owo" },
                new City() { CityId = 25, CityName = "Knyszyn" },
                new City() { CityId = 26, CityName = "Czy¿ew" },
                new City() { CityId = 27, CityName = "Zab³udów" },
                new City() { CityId = 28, CityName = "Krynki" },
                new City() { CityId = 29, CityName = "Stawiski" },
                new City() { CityId = 30, CityName = "Szepietowo" },
                new City() { CityId = 31, CityName = "Suchowola" },
                new City() { CityId = 32, CityName = "Nowogród" },
                new City() { CityId = 33, CityName = "Drohiczyn" },
                new City() { CityId = 34, CityName = "Tykocin" },
                new City() { CityId = 35, CityName = "Goni¹dz" },
                new City() { CityId = 36, CityName = "Jedwabne" },
                new City() { CityId = 37, CityName = "Rajgród" },
                new City() { CityId = 38, CityName = "Kleszczele" },
                new City() { CityId = 39, CityName = "Sura¿" },
                new City() { CityId = 40, CityName = "Warszawa" },
                new City() { CityId = 41, CityName = "Kraków" },
                new City() { CityId = 42, CityName = "Szczecin" },
                new City() { CityId = 43, CityName = "£ódŸ" },
                new City() { CityId = 44, CityName = "Wroc³aw" },
                new City() { CityId = 45, CityName = "Zielona Góra" },
                new City() { CityId = 46, CityName = "Gdañsk" },
                new City() { CityId = 47, CityName = "Poznañ" },
                new City() { CityId = 48, CityName = "Œwinoujœcie" },
                new City() { CityId = 49, CityName = "Bydgoszcz" },
                new City() { CityId = 50, CityName = "Katowice" },
                new City() { CityId = 51, CityName = "Czêstochowa" },
                new City() { CityId = 52, CityName = "Jaworzno" },
                new City() { CityId = 53, CityName = "Opole" },
                new City() { CityId = 54, CityName = "Rybnik" },
                new City() { CityId = 55, CityName = "Lublin" },
                new City() { CityId = 56, CityName = "Gdynia" },
                new City() { CityId = 57, CityName = "Gliwice" },
                new City() { CityId = 58, CityName = "Bielsko-Bia³a" },
                new City() { CityId = 59, CityName = "Kêdzierzyn-KoŸle" },
                new City() { CityId = 60, CityName = "Rzeszów" },
            };
            city.ForEach(k => context.Cities.AddOrUpdate(k));
            context.SaveChanges();

            var category = new List<Category>
            {
                new Category() { CategoryId = 1, CategoryName = "Nieruchomoœci"},
                new Category() { CategoryId = 2, CategoryName = "Budownictwo"},
                new Category() { CategoryId = 3, CategoryName = "Dom"},
                new Category() { CategoryId = 4, CategoryName = "Audio video"},
                new Category() { CategoryId = 5, CategoryName = "Komputery"},
                new Category() { CategoryId = 6, CategoryName = "Telefony"},
                new Category() { CategoryId = 7, CategoryName = "Edukacja"},
                new Category() { CategoryId = 8, CategoryName = "Dla dzieci"},
                new Category() { CategoryId = 9, CategoryName = "Wyposa¿enie i maszyny"},
                new Category() { CategoryId = 10, CategoryName = "Rolnictwo i ogrodnictwo"},
                new Category() { CategoryId = 11, CategoryName = "Motoryzacja i transport"},
                new Category() { CategoryId = 12, CategoryName = "Hobby"},
                new Category() { CategoryId = 13, CategoryName = "Roœliny i zwierzêta"},
                new Category() { CategoryId = 14, CategoryName = "Sport i rekreacja"},
                new Category() { CategoryId = 15, CategoryName = "Turystyka"},
                new Category() { CategoryId = 16, CategoryName = "Zdrowie"},
                new Category() { CategoryId = 17, CategoryName = "Moda"},
            };
            category.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
