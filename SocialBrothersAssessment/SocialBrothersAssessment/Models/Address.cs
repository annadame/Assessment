using System.ComponentModel.DataAnnotations;

namespace SocialBrothersAssessment.Models
{
    public class Address
    {
        public long Id { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int HouseNumber { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
