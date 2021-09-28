using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RegistrationApp.Entities
{
    [Table("mstClient", Schema = "dbo")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(500)]
        public string ClientName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ClientCode { get; set; }

        [MaxLength(1000)]
        public string ClientDesc { get; set; }

        [Required]
        public bool ClientIsActive { get; set; }

        [Required]
        public DateTime ClientCreatedOn { get; set; }
        public DateTime? ClientModifiedOn { get; set; }

        public ICollection<UsersDetail> UserDetails { get; set; }
              = new List<UsersDetail>();
    }
}
