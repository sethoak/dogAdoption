using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Capstone.Models.Data;

namespace Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }

        public DbSet<Dog> Dog { get; set; }

        public DbSet<FavoriteDog> FavoriteDog { get; set; }

        public DbSet<Form> Form { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //Creat some Dogs

            Dog dog1 = new Dog
            {
                Id = 1,
                Name = "Gus",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Large",
                Description = "He's a big boy!",
                Location = "Nashville",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog1);

            Dog dog2 = new Dog
            {
                Id = 2,
                Name = "Apollo",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Medium",
                Description = "Apollo (3 years old) came in this week. He is super sweet. He walks well on leash and was recently neutered. He will be ready to meet families very very soon!",
                Location = "Brentwood, TN",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = false
            };
            modelBuilder.Entity<Dog>().HasData(dog2);

            Dog dog3 = new Dog
            {
                Id = 3,
                Name = "Coco",
                Breed = "Boxer",
                Sex = "Female",
                Size = "Medium",
                Description = "Miss Coco was surrendered from the vet after having two seizures. Her bloodwork and labs showed a UTI..That is now under control and we believe the seizures to be epilepsy. She has regulated on her meds, but should likely be on them for life. This does not stop her from being one of the sweetest pups ever, promise!",
                Location = "Nashville",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog3);


            //Create some Forms

            Form form1 = new Form
            {
                Id = 1,
                UserId = 1,
                DogId = 1,
                Title = "Adopting Coco",
                Description = "I am a dog lover and I want Coco!",
                Reference = "David Oakley 615 555 5555",
                CurrentAnimalOwner = false
            };
            modelBuilder.Entity<Form>().HasData(form1);

            Form form2 = new Form
            {
                Id = 2,
                UserId = 2,
                DogId = 3,
                Title = "Adopting Apollo",
                Description = "Apollo would be a great fit.",
                Reference = "Maude 615 555 5555",
                CurrentAnimalOwner = true
            };
            modelBuilder.Entity<Form>().HasData(form2);


            //Create come favorite dogs

            FavoriteDog favoriteDog1 = new FavoriteDog
            {
                Id = 1,
                DogId = 1,
                UserId = 1
            };
            modelBuilder.Entity<FavoriteDog>().HasData(favoriteDog1);

        }
    }
}
