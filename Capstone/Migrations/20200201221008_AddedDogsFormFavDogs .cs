using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class AddedDogsFormFavDogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Size = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    AnimalFriendly = table.Column<bool>(nullable: false),
                    CatFriendly = table.Column<bool>(nullable: false),
                    HouseTrained = table.Column<bool>(nullable: false),
                    LeashTrained = table.Column<bool>(nullable: false),
                    Neutered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteDog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteDog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DogId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Reference = table.Column<string>(nullable: false),
                    CurrentAnimalOwner = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Dog",
                columns: new[] { "Id", "AnimalFriendly", "Breed", "CatFriendly", "Description", "HouseTrained", "LeashTrained", "Location", "Name", "Neutered", "Sex", "Size" },
                values: new object[,]
                {
                    { 1, true, "Boxer", true, "He's a big boy!", true, true, "Nashville", "Gus", true, "Male", "Large" },
                    { 2, true, "Boxer", true, "Apollo (3 years old) came in this week. He is super sweet. He walks well on leash and was recently neutered. He will be ready to meet families very very soon!", true, true, "Brentwood, TN", "Apollo", false, "Male", "Medium" },
                    { 3, true, "Boxer", true, "Miss Coco was surrendered from the vet after having two seizures. Her bloodwork and labs showed a UTI..That is now under control and we believe the seizures to be epilepsy. She has regulated on her meds, but should likely be on them for life. This does not stop her from being one of the sweetest pups ever, promise!", true, true, "Nashville", "Coco", true, "Female", "Medium" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDog",
                columns: new[] { "Id", "DogId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Form",
                columns: new[] { "Id", "CurrentAnimalOwner", "Description", "DogId", "Reference", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, false, "I am a dog lover and I want Coco!", 1, "David Oakley 615 555 5555", "Adopting Coco", 1 },
                    { 2, true, "Apollo would be a great fit.", 3, "Maude 615 555 5555", "Adopting Apollo", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dog");

            migrationBuilder.DropTable(
                name: "FavoriteDog");

            migrationBuilder.DropTable(
                name: "Form");
        }
    }
}
