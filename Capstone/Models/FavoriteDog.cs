using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models.Data
{
    public class FavoriteDog
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public int UserId { get; set; }
    }
}