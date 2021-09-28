using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RegistrationApp.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApp.Models
{
    public class UsersDetailsForCreationDto
    {
        [Required(ErrorMessage = "You should provide a First Name.")]
        [MaxLength(150)]
        public string FirstName { get; set; }

        public string ClientCode { get; set; }

        [Required(ErrorMessage = "You should provide a Last Name.")]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You should provide a Street.")]
        [MaxLength(150)]
        public string Street { get; set; }

        [Required(ErrorMessage = "You should provide a house number.")]
        [MaxLength(50)]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "You should provide a Zip Code.")]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string PersonalNumber { get; set; }

        [MaxLength(200)]
        public string FavoriteFootBallTeam { get; set; }
    }
}
