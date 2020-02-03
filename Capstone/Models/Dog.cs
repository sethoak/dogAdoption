using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.Data
{
    public class Dog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please shorten the name to 20 characters")]
        public string Name { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public bool AnimalFriendly { get; set; }

        [Required]
        public bool CatFriendly { get; set; }

        [Required]
        public bool HouseTrained { get; set; }

        [Required]
        public bool LeashTrained { get; set; }

        [Required]
        public bool Neutered { get; set; }
    }
}