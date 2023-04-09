using Microsoft.AspNetCore.Identity;
using VacationManager.Data;
using static System.Formats.Asn1.AsnWriter;

namespace VacationManager.StaticClasses
{
    public static class Seeder
    {
        public static async Task SeedRoles(ApplicationDbContext db, RoleManager<IdentityRole> roleManager)
        {
            string[] roles = new string[] { "CEO", "Developer", "Team Lead", "Unassigned"};
            foreach (var role in roles)
            {
                bool exists = await roleManager.RoleExistsAsync(role);
                if (!exists)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            await db.SaveChangesAsync();
        }
    }
}
