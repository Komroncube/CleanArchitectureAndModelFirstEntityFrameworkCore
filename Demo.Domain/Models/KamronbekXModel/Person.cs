﻿namespace Demo.Domain.Models.KamronbekXModel
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<PersonCars> PersonCars { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
