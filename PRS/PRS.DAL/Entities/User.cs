using PRS.DAL.Repository.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS.DAL.Entities
{
    public class User: IEntity
    {
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string FirstName { get; set; }

        [Required, MaxLength(128)]
        public string LastName { get; set; }

        [Required, MaxLength(128)]
        public string Username { get; set; }

        [Required, MaxLength(2048)]
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
