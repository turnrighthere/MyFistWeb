﻿namespace Visual_learning_ytb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }    
        public string? Role { get; set; }
        public bool KeepLoggedin { get; set; }
    }
}
