using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using ShoppingCart.Models;

namespace ShoppingCart.Models
{

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
           
           
        }
        // [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public string ID { get; set; }
        [Required]
        [MaxLength(300)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        public string LastName { get; set; }

        [MaxLength(300)]
        public string Title { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public string CommonPassword { get; set; }
       
    }

    public class AppClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public AppClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager
            , RoleManager<IdentityRole> roleManager
            , IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, roleManager, optionsAccessor)
        { }

        public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);

            if (!string.IsNullOrWhiteSpace(user.FirstName))
            {
                var name = user.FirstName + " " + user.LastName;
                ((ClaimsIdentity)principal.Identity).AddClaims(new[] { new Claim(ClaimTypes.GivenName, name) });
            }

            ((ClaimsIdentity)principal.Identity).AddClaims(new[] { new Claim(ClaimTypes.SerialNumber, Guid.NewGuid().ToString()) });

            return principal;
        }


    }

   
}
