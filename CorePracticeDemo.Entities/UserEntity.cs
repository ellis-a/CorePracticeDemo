using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorePracticeDemo.Entities
{
    [Table("User")]
    public class UserEntity
    {
        [Key, Required]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
