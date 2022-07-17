﻿namespace WOW.Models
{
    public class Person
    {
        public Guid Id { get; set; } = new();
        public string Name { get; set; } = string.Empty;
        public List<Item>? PaidFor { get; set; }
        public List<Item>? Used { get; set; }
    }
}
