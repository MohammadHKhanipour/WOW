namespace WOW
{
    public class InitializeData
    {
        public static List<Item> Items = new()
        {
            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Panini MorghTorsh",
                Price = 123_000
            },

            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Vegan Borito",
                Price = 115_000
            },

            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Lemonade",
                Price = 35_000
            },

            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Seihun",
                Price = 35_000
            },

            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Jamaica",
                Price = 75_000
            },

            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Ghermez Yakhi",
                Price =77_000
            },

            new Item
            {
                Id = Guid.NewGuid(),
                Count = 1,
                Name = "Purple Shake",
                Price = 75_000
            }
        };

        public static List<Person> Persons = new()
        {
            new Person
            {
                Id = Guid.NewGuid(),
                Name = "Mamad",
                PaidFor = null,
                Used = Items?.Where(x=>x.Name == "Panini MorghTorsh" || x.Name == "Lemonade" || x.Name == "Ghermez Yakhi").ToList()
            },

            new Person
            {
                Id = Guid.NewGuid(),
                Name = "Mehdi",
                PaidFor = Items,
                Used = Items?.Where(x=>x.Name == "Vegan Borito" || x.Name == "Seihun" || x.Name == "Purple Shake").ToList()
            },

            new Person
            {
                Id = Guid.NewGuid(),
                Name = "Mojtaba",
                PaidFor = null,
                Used = Items?.Where(x=>x.Name == "Jamaica").ToList()
            },
        };
    }
}
