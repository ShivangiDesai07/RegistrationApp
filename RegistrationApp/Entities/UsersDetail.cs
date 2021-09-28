using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Entities
{
    [Table("mstUsersDetail", Schema = "dbo")]
    public class UsersDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [ForeignKey("Client")]
        public int ClientID { get; set; }

        public Client Clients { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string HouseNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string PersonalNumber { get; set; }

        [MaxLength(200)]
        public string FavoriteFootBallTeam { get; set; }
    }
}
