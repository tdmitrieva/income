using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Income.Models
{
    public class Skill : BaseEntity
    {
        public Skill()
        {
            Users = new Collection<User>();
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Title { get; set; }
        public virtual ICollection<User> Users {get; set;}
    }
}
