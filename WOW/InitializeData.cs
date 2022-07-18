namespace WOW
{
    public static class InitializeData
    {
        public static List<Person> Persons = new()
        {
            new Person
            {
                Name = "Mamad",
                PaidFor = null,
                Used = Items?.Where(x=>x.Name == "Panini MorghTorsh" || x.Name == "Lemonade" || x.Name == "Ghermez Yakhi").ToList()
            },

            new Person
            {
                Name = "Mehdi",
                PaidFor = Items,
                Used = Items?.Where(x=>x.Name == "Vegan Borito" || x.Name == "Seihun" || x.Name == "Purple Shake").ToList()
            },

            new Person
            {
                Name = "Mojtaba",
                PaidFor = null,
                Used = Items?.Where(x=>x.Name == "Jamaica").ToList()
            },
        };

        public static List<Item> Items = new()
        {
            new Item
            {
                Count = 1,
                Name = "Panini MorghTorsh",
                Price = 123_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x=>x.Name=="Mamad").ToList()
            },

            new Item
            {
                Count = 1,
                Name = "Vegan Borito",
                Price = 115_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x=>x.Name=="Mehdi").ToList()
            },

            new Item
            {
                Count = 1,
                Name = "Lemonade",
                Price = 35_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x => x.Name == "Mamad").ToList()
            },

            new Item
            {
                Count = 1,
                Name = "Seihun",
                Price = 35_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x => x.Name == "Mehdi").ToList()
            },

            new Item
            {
                Count = 1,
                Name = "Jamaica",
                Price = 75_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x => x.Name == "Mojtaba").ToList()
            },

            new Item
            {
                Count = 1,
                Name = "Ghermez Yakhi",
                Price =77_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x => x.Name == "Mamad").ToList()
            },

            new Item
            {
                Count = 1,
                Name = "Purple Shake",
                Price = 75_000,
                PaidBy = Persons?.SingleOrDefault(x=>x.Name=="Mehdi"),
                UsedBy = Persons?.Where(x => x.Name == "Mehdi").ToList()
            }
        };
    }
}
