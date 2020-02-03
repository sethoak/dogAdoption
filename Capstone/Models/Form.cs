using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.Data
{
    public class Form
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DogId { get; set; }
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Reference { get; set; }

        [Required]
        public bool CurrentAnimalOwner { get; set; }
    }
}

