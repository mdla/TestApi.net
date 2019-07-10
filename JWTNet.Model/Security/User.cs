using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWTNet.Models.Security
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string Rol { get; set; }
    }
}
