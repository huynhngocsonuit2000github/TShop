// using Microsoft.EntityFrameworkCore;
// using TShop.Domain.Entities;

// namespace TShop.Domain.DataAccess;
// public class SchoolDBInitializer : DropCreateDatabaseAlways<TShopDbContext>
// {
//     protected override void Seed(TShopDbContext context)
//     {
//         List<User> users = new List<User>();

//         users.Add(new User { Id = 1, LastName = "Son", FirstName = "Huynh" },);
//         users.Add(new User { Id = 2, LastName = "Vinh", FirstName = "Dang" },);
//         users.Add(new User { Id = 3, LastName = "Nga", FirstName = "Le" });

//         context.Users.AddRange(users);

//         base.Seed(context);
//     }
// }