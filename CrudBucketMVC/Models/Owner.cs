﻿namespace CrudBucketMVC.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public List<Property> Properties { get; set; }
    }
}
