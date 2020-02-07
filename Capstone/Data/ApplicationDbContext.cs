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
                PetId = 19-001,
                Age = 7,
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
                PetId = 19-002,
                Age = 3,
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
                PetId = 19-003,
                Age = 4,
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

            Dog dog4 = new Dog
            {
                Id = 4,
                PetId = 19-004,
                Age = 2,
                Name = "Bart",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Small",
                Description = "Miss Coco was surrendered from the vet after having two seizures. Her bloodwork and labs showed a UTI..That is now under control and we believe the seizures to be epilepsy. She has regulated on her meds, but should likely be on them for life. This does not stop her from being one of the sweetest pups ever, promise!",
                Location = "Nashville",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog4);

            Dog dog5 = new Dog
            {
                Id = 5,
                PetId = 19-005,
                Age = 2,
                Name = "Bart",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Small",
                Description = "Miss Coco was surrendered from the vet after having two seizures. Her bloodwork and labs showed a UTI..That is now under control and we believe the seizures to be epilepsy. She has regulated on her meds, but should likely be on them for life. This does not stop her from being one of the sweetest pups ever, promise!",
                Location = "Nashville",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog5);

            Dog dog6 = new Dog
            {
                Id = 6,
                PetId = 19-006,
                Age = 2,
                Name = "Brindlee",
                Breed = "Boxer",
                Sex = "Female",
                Size = "Large",
                Description = "Brindlee (6 years old) is super fearful when she meets new people. Once properly introduced, she is great….We are working on new people and situations and hope she will be ready in a few weeks. Please let me know if you think she could be a fit for you. I would also suggest a calmer home with someone home often.",
                Location = "Brentwood, TN",
                AnimalFriendly = false,
                CatFriendly = false,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog6);

            Dog dog7 = new Dog
            {
                Id = 7,
                PetId = 19 - 007,
                Age = 9,
                Name = "CJ",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Extra Large",
                Description = "CJ’s family went through a divorce and left him behind. He is 6 years old, was super scared at first, but as soon as he meets you….he warms right up. He is a big boy and needs a little leash work but would be a great addition to a calmer home.",
                Location = "Brentwood, TN",
                AnimalFriendly = true,
                CatFriendly = false,
                HouseTrained = true,
                LeashTrained = false,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog7);

            Dog dog8 = new Dog
            {
                Id = 8,
                PetId = 19 - 008,
                Age = 9,
                Name = "Coco",
                Breed = "Boxer",
                Sex = "Female",
                Size = "Large",
                Description = "Miss Coco was surrendered from the vet after having two seizures. Her bloodwork and labs showed a UTI..That is now under control and we believe the seizures to be epilepsy. She has regulated on her meds, but should likely be on them for life. This does not stop her from being one of the sweetest pups ever, promise!",
                Location = "Brentwood, TN",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog8);

            Dog dog9 = new Dog
            {
                Id = 9,
                PetId = 19 - 009,
                Age = 4,
                Name = "Freddy ",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Medium",
                Description = "Freddy (3-4 years old) is a big handsome boy! He loves his people, does well on leash and has been given a clean bill of health! Freddy prefers to be the only dog in the home, but only because he wants you all to himself.Do you need a new BFF?",
                Location = "Brentwood, TN",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog9);

            Dog dog10 = new Dog
            {
                Id = 10,
                PetId = 19 - 010,
                Age = 3,
                Name = "Harley ",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Medium",
                Description = "Harley (2-3 years old) recently came in from the shelter. He is super excited to meet everyone and full of love. He is on the smaller side and heartworm postive. We are looking for a foster or adopter (potentially foster to adopt) to see him through his treatment.",
                Location = "Brentwood, TN",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog10);

            Dog dog11 = new Dog
            {
                Id = 11,
                PetId = 19 - 011,
                Age = 14,
                Name = "Jack ",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Large",
                Description = "Jack is 14!! He has normal wear and tear of that of a 14 year old boxer, but we refuse to call him hospice. He is house trained, does not need a crate, does well with resident boxers, loves his foster momma……Jack deserves a forever home like anyone else!",
                Location = "Brentwood, TN",
                AnimalFriendly = true,
                CatFriendly = true,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog11);

            Dog dog12 = new Dog
            {
                Id = 12,
                PetId = 19 - 012,
                Age = 5,
                Name = "Lulu",
                Breed = "Boxer",
                Sex = "Female",
                Size = "Large",
                Description = "Lulu’s family recently surrendered her to the shelter. She is 6 years old, super sweet and a little chunky. We've started her on diet and exercise and she is loving life with MTBR. Let me know if you would like to meet this sweet girl asap.",
                Location = "Brentwood, TN",
                AnimalFriendly = false,
                CatFriendly = false,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog12);

            Dog dog13 = new Dog
            {
                Id = 13,
                PetId = 19 - 013,
                Age = 5,
                Name = "Max",
                Breed = "Boxer",
                Sex = "Male",
                Size = "Large",
                Description = "Max, 4-5 years old, was kept outside on a chain. He recently came to MTBR and had a pretty good check up. Some parasites and fleas but good food and simple meds is all that is needed. He will be neutered next week and ready for you!",
                Location = "Brentwood, TN",
                AnimalFriendly = false,
                CatFriendly = false,
                HouseTrained = true,
                LeashTrained = true,
                Neutered = true
            };
            modelBuilder.Entity<Dog>().HasData(dog13);


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
