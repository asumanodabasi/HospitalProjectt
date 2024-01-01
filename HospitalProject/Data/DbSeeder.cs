using HospitalProject.Constants;
using HospitalProject.Models;
using Microsoft.AspNetCore.Identity;

namespace HospitalProject.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var user = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString())); 
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));


            //admin olusturma
            var user1 = new User
            {
                Email = "asuman.odabasi@sakarya.edu.tr",
               // PasswordHash = "Asuman2."

            };


            //user.CreateAsync(user1).Wait();
            //var adminRole = "Admin";
            //var roleExist = roleManager.RoleExistsAsync(adminRole).Result;

            //if(!roleExist)
            //{
            //    var roleResult = roleManager.CreateAsync(new IdentityRole(adminRole)).Result;

            //    if(roleResult.Succeeded)
            //    {
            //        user.AddToRoleAsync(user1, adminRole).Wait();
            //    }
            //}

            var userInDb = await user.FindByEmailAsync(user1.Email);
            if (userInDb == null)
            {
                await user.CreateAsync(user1, "admin@123");
                await user.AddToRoleAsync(user1, Roles.Admin.ToString());
            }




        }
    }
}
