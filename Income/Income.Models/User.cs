using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Income.Models
{
    public class User: BaseEntity
    {
        public User()
        {
            Skills = new Collection<Skill>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public bool? Gender { get; set; }
        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }
        public byte[] Photo { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
