using LeaveManagement.DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagement.DataAccessLayer.Seed
{
    public static class CountrySeed
    {
        public static void Seed(EmployeeDbContext context)
        {
            if (!context.Countries.Any())
            {
                var countries = new List<Country>
                {
                    new Country { CountryName = "Afghanistan" },
                    new Country { CountryName = "Albania" },
                    new Country { CountryName = "Algeria" },
                    new Country { CountryName = "Andorra" },
                    new Country { CountryName = "Angola" },
                    new Country { CountryName = "Antigua and Barbuda" },
                    new Country { CountryName = "Argentina" },
                    new Country { CountryName = "Armenia" },
                    new Country { CountryName = "Aruba" },
                    new Country { CountryName = "Australia" },
                    new Country { CountryName = "Austria" },
                    new Country { CountryName = "Azerbaijan" },
                    new Country { CountryName = "Baden" },
                    new Country { CountryName = "Bahrain" },
                    new Country { CountryName = "Bangladesh" },
                    new Country { CountryName = "Barbados" },
                    new Country { CountryName = "Bavaria" },
                    new Country { CountryName = "Belarus" },
                    new Country { CountryName = "Belgium" },
                    new Country { CountryName = "Canada" },
                    new Country { CountryName = "China" },
                    new Country { CountryName = "Colombia" },
                    new Country { CountryName = "Denmark" },
                    new Country { CountryName = "Egypt" },
                    new Country { CountryName = "Finland" },
                    new Country { CountryName = "France" },
                    new Country { CountryName = "Germany" },
                    new Country { CountryName = "India" },
                    new Country { CountryName = "Japan" },
                    new Country { CountryName = "Korea" },
                    new Country { CountryName = "Kuwait" },
                    new Country { CountryName = "Malaysia" },
                    new Country { CountryName = "Mexico" },
                    new Country { CountryName = "New Zealand" },
                    new Country { CountryName = "Philippines" },
                    new Country { CountryName = "Qatar" },
                    new Country { CountryName = "Russia" },
                    new Country { CountryName = "Saudi Arabia" },
                    new Country { CountryName = "Spain" },
                    new Country { CountryName = "United Arab Emirates" },
                    new Country { CountryName = "United Kingdom" },
                    new Country { CountryName = "United States of America" }
                };
                context.Countries.AddRange(countries);
                context.SaveChanges();
            }
        }
    }
}
